using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace TicTacToe
{
    public partial class FormMain : Form
    {
        #region "Campos"
        // General
        private Game game;
        private bool automaticGC;

        // Navegador
        private ArrayList nodes;
        private int lastBrowsedNode, lastBrowsedSubNode, _startupPlayer;

        // MinMax
        private bool minMaxStarted;
        private int[,] minMaxBoard;
        private Node minMaxActualNode;
        private int minMaxFirstPlayer;

        // Heurística
        private bool heuStarted;
        private int[,] heuBoard;
        private int heuFirstPlayer, heuLastWeight;
        private Node heuActualNode;
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public FormMain()
        {
            game = new Game();
            startupPlayer = 1;
            automaticGC = true;

            // MinMax
            minMaxStarted = false;
            minMaxBoard = new int[3, 3];
            minMaxFirstPlayer = 1;

            // Heurística
            heuStarted = false;
            heuBoard = new int[3, 3];
            heuFirstPlayer = 1;
            heuLastWeight = 0;

            // Interfaz
            InitializeComponent();
        }

        #region "Funciones generales"
        /// <summary>
        /// Convierte -1 y 1 en "X" o "O" según el jugador inicial
        /// </summary>
        /// <param name="player">Jugada</param>
        /// <returns>La jugada como letra</returns>
        private String IntToStringPiece(int player)
        {
            switch (player)
            {
                case 1: return Properties.Resources.ResourceManager.GetString("Player_1");
                case -1: return Properties.Resources.ResourceManager.GetString("Player_2");
            }
            return "";
        }

        /// <summary>
        /// Dibuja el tablero actual del navegador de la solución
        /// </summary>
        private void DrawCurrentNodeBoard()
        {
            if (game.Solved && nodes!=null)
            {
                Node node = ((Node)nodes[lastBrowsedNode]).GetNode(lastBrowsedSubNode);
                int[,] board = (node.Board);

                buttonBoard0.Text = IntToStringPiece(board[0, 0]);
                buttonBoard1.Text = IntToStringPiece(board[0, 1]);
                buttonBoard2.Text = IntToStringPiece(board[0, 2]);
                buttonBoard3.Text = IntToStringPiece(board[1, 0]);
                buttonBoard4.Text = IntToStringPiece(board[1, 1]);
                buttonBoard5.Text = IntToStringPiece(board[1, 2]);
                buttonBoard6.Text = IntToStringPiece(board[2, 0]);
                buttonBoard7.Text = IntToStringPiece(board[2, 1]);
                buttonBoard8.Text = IntToStringPiece(board[2, 2]);

                textBoxDepth.Text = "" + lastBrowsedNode;
                textBoxSubIndex.Text = "" + lastBrowsedSubNode;
                textBoxTurn.Text = "" + node.Turn;
                textBoxParent.Text = "" + node.Parent.GetBoardAsString();

                if (node.Weighted)
                    textBoxWeight.Text = "" + node.Weight;
                else
                    textBoxWeight.Text = Properties.Resources.ResourceManager.GetString("Not_available");

                CheckGuiEnableDisable();
            }
        }

        /// <summary>
        /// Ajustes de la interfaz
        /// </summary>
        private void CheckGuiEnableDisable()
        {
            if (((Node)nodes[lastBrowsedNode]).GetNode(lastBrowsedSubNode).Count == 0)
                buttonBoardDeeper.Enabled = false;
            else
                buttonBoardDeeper.Enabled = true;

            if (lastBrowsedSubNode + 1 == ((Node)nodes[lastBrowsedNode]).Count)
                buttonBoardNext.Enabled = false;
            else
                buttonBoardNext.Enabled = true;

            if (lastBrowsedSubNode == 0)
                buttonBoardPrevious.Enabled = false;
            else
                buttonBoardPrevious.Enabled = true;

            if (lastBrowsedNode > 0)
                buttonBoardParent.Enabled = true;
            else
                buttonBoardParent.Enabled = false;
        }

        /// <summary>
        /// Definición del jugador inicial para resolver el juego, en el navegador
        /// </summary>
        private int startupPlayer
        {
            get
            {
                return _startupPlayer;
            }
            set
            {
                _startupPlayer = value;

                try
                {
                    if (_startupPlayer == 1)
                    {
                        player2StartsToolStripMenuItem.Checked = false;
                        player1StartsToolStripMenuItem.Checked = true;
                    }
                    else
                    {
                        player2StartsToolStripMenuItem.Checked = true;
                        player1StartsToolStripMenuItem.Checked = false;
                    }
                }
                catch { }
            }
        }

        /// <summary>
        /// Compara dos tableros de juego
        /// </summary>
        /// <param name="a">Primer tablero</param>
        /// <param name="b">Segundo tablero</param>
        /// <returns>Resultado de la comparación</returns>
        private bool BoardsAreEqual(int[,] a, int[,] b)
        {
            int i, j;
            for (i = 0; i < 3; i++)
                for (j = 0; j < 3; j++)
                    if (a[i, j] != b[i, j])
                        return false;
            return true;
        }
        #endregion

        #region "MinMax"
        /// <summary>
        /// Vuelve a inicializar el juego del panel de MinMax
        /// </summary>
        private void MinMaxReset()
        {
            labelMinMax.Text = Properties.Resources.ResourceManager.GetString("Click_to_begin");
            minMaxActualNode = game.SolutionRoot;
            Application.DoEvents();

            DrawCurrentMinMaxBoard();

            textBoxMinMaxTurn.Text = "";
            textBoxMinMaxDepth.Text = "";
            textBoxMinMaxWeight.Text = "";
            textBoxMinMaxParent.Text = "";

            minMaxStarted = false;
        }

        /// <summary>
        /// Inicializa el juego del panel de MinMax
        /// </summary>
        /// <param name="firstPlayer">Primer jugador</param>
        private void MinMaxInitialization(int firstPlayer)
        {
            if (!minMaxStarted)
            {
                minMaxStarted = true;

                if (!game.Solved || game.SolvedFor != firstPlayer)
                {
                    labelMinMax.Text = Properties.Resources.ResourceManager.GetString("Solution_tree_generation");
                    Application.DoEvents();

                    game.Solve(firstPlayer);

                    // Recolección instantánea de basura
                    if (automaticGC)
                        GC.Collect();

                    minMaxFirstPlayer = firstPlayer;
                }

                if (!game.UtilityCalculated)
                    game.CalculeUtility();

                minMaxActualNode = game.SolutionRoot;
            }
        }

        /// <summary>
        /// Elije la mejor jugada basándose en la utilidad por MinMax, según el turno del nodo mismo y del jugador actual para quien se resolvió el juego
        /// </summary>
        /// <param name="startupNode">Nodo desde donde bajar</param>
        /// <returns>Nodo con mejor utilidad</returns>
        private Node MinMaxPickTheBest(Node startupNode)
        {
            if (Game.RemainingPlays(startupNode.Board) > 0 && Game.WhoWins(startupNode.Board) == 0)
            {
                int i, weight, minMaxNode = 0, minMax;
                if (startupNode.Count > 0)
                {
                    minMax = startupNode.GetNode(0).Weight;

                    if (startupNode.Count > 1)
                    {
                        for (i = 1; i < startupNode.Count; i++)
                        {
                            weight = startupNode.GetNode(i).Weight;

                            if (minMaxFirstPlayer == 1)
                            {
                                if (weight < minMax)
                                {
                                    minMax = weight;
                                    minMaxNode = i;
                                }
                            }
                            else
                            {
                                if (weight > minMax)
                                {
                                    minMax = weight;
                                    minMaxNode = i;
                                }
                            }
                        }
                    }
                }
                return startupNode.GetNode(minMaxNode);
            }

            return startupNode;
        }

        /// <summary>
        /// Dibuja el tablero de juego y actualiza el panel de detalles
        /// </summary>
        private void DrawCurrentMinMaxBoard()
        {
            if (minMaxActualNode != null)
            {
                buttonMinMax1.Text = IntToStringPiece(minMaxActualNode.Board[0, 0]);
                buttonMinMax2.Text = IntToStringPiece(minMaxActualNode.Board[1, 0]);
                buttonMinMax3.Text = IntToStringPiece(minMaxActualNode.Board[2, 0]);
                buttonMinMax4.Text = IntToStringPiece(minMaxActualNode.Board[0, 1]);
                buttonMinMax5.Text = IntToStringPiece(minMaxActualNode.Board[1, 1]);
                buttonMinMax6.Text = IntToStringPiece(minMaxActualNode.Board[2, 1]);
                buttonMinMax7.Text = IntToStringPiece(minMaxActualNode.Board[0, 2]);
                buttonMinMax8.Text = IntToStringPiece(minMaxActualNode.Board[1, 2]);
                buttonMinMax9.Text = IntToStringPiece(minMaxActualNode.Board[2, 2]);

                textBoxMinMaxTurn.Text = minMaxActualNode.Turn + "";
                textBoxMinMaxDepth.Text = minMaxActualNode.Count + "";
                textBoxMinMaxWeight.Text = minMaxActualNode.Weight + "";

                if (minMaxActualNode.Parent != null)
                    textBoxMinMaxParent.Text = minMaxActualNode.Parent.GetBoardAsString();

                if (Game.RemainingPlays(minMaxActualNode.Board) == 0)
                    labelMinMax.Text = Properties.Resources.ResourceManager.GetString("Draw");
                else
                {
                    switch (Game.WhoWins(minMaxActualNode.Board))
                    {
                        case -1:
                            labelMinMax.Text = Properties.Resources.ResourceManager.GetString("Lose");
                            break;
                        case 1:
                            labelMinMax.Text = Properties.Resources.ResourceManager.GetString("Win");
                            break;
                        default:
                            if (minMaxStarted)
                                labelMinMax.Text = Properties.Resources.ResourceManager.GetString("Turn");
                            break;
                    }
                }
            }
        }
        #endregion

        #region "Heurística"
        /// <summary>
        /// Vuelve a inicializar el juego del panel de Heurística
        /// </summary>
        private void HeuReset()
        {
            labelHeu.Text = Properties.Resources.ResourceManager.GetString("Click_to_begin");
            heuActualNode = game.SolutionRoot;
            Application.DoEvents();

            heuLastWeight = 0;
            DrawCurrentHeuBoard();

            textBoxHeuTurn.Text = "";
            textBoxHeuDepth.Text = "";
            textBoxHeuWeight.Text = "";
            textBoxHeuParent.Text = "";

            heuStarted = false;
        }

        /// <summary>
        /// Inicializa el juego del panel de Heu
        /// </summary>
        /// <param name="firstPlayer">Primer jugador</param>
        private void HeuInitialization(int firstPlayer)
        {
            if (!heuStarted)
            {
                heuStarted = true;

                if (!game.Solved || game.SolvedFor != firstPlayer)
                {
                    labelHeu.Text = Properties.Resources.ResourceManager.GetString("Solution_tree_generation");
                    Application.DoEvents();

                    game.Solve(firstPlayer);

                    // Recolección instantánea de basura
                    if (automaticGC)
                        GC.Collect();

                    heuFirstPlayer = firstPlayer;
                }

                if (!game.UtilityCalculated)
                    game.CalculeUtility();

                heuActualNode = game.SolutionRoot;
            }
        }

        /// <summary>
        /// Dibuja el tablero de juego y actualiza el panel de detalles
        /// </summary>
        private void DrawCurrentHeuBoard()
        {
            if (heuActualNode != null)
            {
                buttonHeu1.Text = IntToStringPiece(heuActualNode.Board[0, 0]);
                buttonHeu2.Text = IntToStringPiece(heuActualNode.Board[1, 0]);
                buttonHeu3.Text = IntToStringPiece(heuActualNode.Board[2, 0]);
                buttonHeu4.Text = IntToStringPiece(heuActualNode.Board[0, 1]);
                buttonHeu5.Text = IntToStringPiece(heuActualNode.Board[1, 1]);
                buttonHeu6.Text = IntToStringPiece(heuActualNode.Board[2, 1]);
                buttonHeu7.Text = IntToStringPiece(heuActualNode.Board[0, 2]);
                buttonHeu8.Text = IntToStringPiece(heuActualNode.Board[1, 2]);
                buttonHeu9.Text = IntToStringPiece(heuActualNode.Board[2, 2]);

                textBoxHeuTurn.Text = heuActualNode.Turn + "";
                textBoxHeuDepth.Text = heuActualNode.Count + "";
                textBoxHeuWeight.Text = heuLastWeight + "";

                if (heuActualNode.Parent != null)
                    textBoxHeuParent.Text = heuActualNode.Parent.GetBoardAsString();

                if (Game.RemainingPlays(heuActualNode.Board) == 0)
                    labelHeu.Text = Properties.Resources.ResourceManager.GetString("Draw");
                else
                {
                    switch (Game.WhoWins(heuActualNode.Board))
                    {
                        case -1:
                            labelHeu.Text = Properties.Resources.ResourceManager.GetString("Lose");
                            break;
                        case 1:
                            labelHeu.Text = Properties.Resources.ResourceManager.GetString("Win");
                            break;
                        default:
                            if (heuStarted)
                                labelHeu.Text = Properties.Resources.ResourceManager.GetString("Turn");
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Aplica una heurística basado en un tablero inicial y final, para evaluar la jugada hecha entre ellos
        /// </summary>
        /// <param name="prevBoard">Tablero antes de la jugada</param>
        /// <param name="board">Tablero actual</param>
        /// <param name="player">Jugador del turno</param>
        /// <returns>El peso estimado del tablero</returns>
        private int HeuristicAnalize(int[,] prevBoard, int[,] board, int player)
        {
            int winner = Game.WhoWins(board), play_i = 0, play_j = 0, i, j;

            // Evaluación de ganar o perder
            if (player == winner)
                return 10; // Máxima utilidad
            else
                if (winner != 0)
                    return -10; // Mínima utilidad

            // Analizar jugada
            for (i = 0; i < 3; i++)
                for (j = 0; j < 3; j++)
                    if (board[i, j] != 0)
                        if (prevBoard[i, j] == 0)
                        {
                            play_i = i;
                            play_j = j;
                            break;
                        }

            int player1, player2, empty;

            // ¿Bloqueó diagonalmente al oponente?
            player1 = 0; player2 = 0; empty = 0;
            for (i = 0; i < 3; i++)
            {
                if (prevBoard[i, i] == 0)
                    empty++;

                if (board[i, i] == player)
                {
                    player1++;
                }
                else
                    if (board[i, i] == -player)
                        player2++;
            }

            if (player1 == 1 && player2 == 2 && empty == 1)
                return 7;

            player1 = 0; player2 = 0; empty = 0;
            for (i = 0; i < 3; i++)
            {
                if (prevBoard[i, 2 - i] == 0)
                    empty++;

                if (board[i, 2 - i] == player)
                {
                    player1++;
                }
                else
                    if (board[i, 2 - i] == -player)
                        player2++;
            }

            if (player1 == 1 && player2 == 2 && empty == 1)
                return 7;

            // ¿Bloqueó horizontal o verticalmente al oponente?
            player1 = 0; player2 = 0; empty = 0;
            for (i = 0; i < 3; i++)
            {
                if (prevBoard[i, play_j] == 0)
                    empty++;

                if (board[i, play_j] == player)
                {
                    player1++;
                }
                else
                    if (board[i, play_j] == -player)
                        player2++;
            }

            if (player1 == 1 && player2 == 2 && empty == 1)
                return 5;

            player1 = 0; player2 = 0; empty = 0;
            for (i = 0; i < 3; i++)
            {
                if (prevBoard[play_i, i] == 0)
                    empty++;

                if (board[play_i, i] == player)
                {
                    player1++;
                }
                else
                    if (board[play_i, i] == -player)
                        player2++;
            }

            if (player1 == 1 && player2 == 2 && empty == 1)
                return 5;

            // Bloquear la jugada de tres esquinas
            if ((play_i == 0 && play_j == 1) || (play_i == 1 && play_j == 0) ||
                (play_i == 1 && play_j == 2) || (play_i == 2 && play_j == 1))
                if ((board[0, 0] == -player && board[2, 2] == -player) ||
                    (board[0, 2] == -player && board[2, 0] == -player))
                    return 4;

            // Bloquear la jugada de esquina y lateral, y la de los dos laterales
            if (play_i + play_j == 4)
                if (board[1, 2] == -player && board[2, 0] == -player)
                    return 3;
                else
                    if (board[0, 2] == -player && board[2, 1] == -player)
                        return 3;
                    else
                        if (board[1, 2] == -player && board[2, 1] == -player)
                            return 2; // Dos laterales

            if (play_i == 0 & play_j == 2)
                if (board[0, 1] == -player && board[2, 2] == -player)
                    return 3;
                else
                    if (board[0, 0] == -player && board[1, 2] == -player)
                        return 3;
                    else
                        if (board[1, 2] == -player && board[0, 1] == -player)
                            return 2; // Dos laterales

            if (play_i + play_j == 0)
                if (board[1, 0] == -player && board[0, 2] == -player)
                    return 3;
                else
                    if (board[0, 1] == -player && board[2, 0] == -player)
                        return 3;
                    else
                        if (board[1, 0] == -player && board[0, 1] == -player)
                            return 2; // Dos laterales

            if (play_i == 2 & play_j == 0)
                if (board[2, 1] == -player && board[0, 0] == -player)
                    return 3;
                else
                    if (board[1, 0] == -player && board[2, 2] == -player)
                        return 3;
                    else
                        if (board[1, 0] == -player && board[2, 1] == -player)
                            return 2; // Dos laterales

            // Al centro
            if (play_i == 1 && play_j == 1)
                return 1;

            // A la esquina
            if (play_i + play_j == 2 || play_i + play_j == 4 || play_i + play_j == 0)
                return 0; // Neutral

            return -5; // Indiferente
        }

        /// <summary>
        /// Elije la mejor jugada basándose en la utilidad por Heurística, indaga en el tablero actual y en uno más adelante
        /// </summary>
        /// <param name="startupNode">Nodo desde donde bajar</param>
        /// <returns>Nodo con mejor utilidad</returns>
        private Node HeuPickTheBest(Node startupNode)
        {
            // Sólo sí hay un nivel inferior
            if (startupNode.Count > 0)
            {
                int i, j;
                ArrayList HeuWeight = new ArrayList();

                for (i = 0; i < startupNode.Count; i++)
                {
                    int[] Heu = new int[2];

                    Heu[0] = i;

                    // Analizar
                    Heu[1] = HeuristicAnalize(startupNode.Board, startupNode.GetNode(i).Board, -1);
                    HeuWeight.Add(Heu);
                }

                for (i = 0; i < HeuWeight.Count; i++)
                    for (j = 0; j < HeuWeight.Count; j++)
                        if (((int[])HeuWeight[i])[1] > ((int[])HeuWeight[j])[1])
                        {
                            int[] temp = (int[])HeuWeight[i];
                            HeuWeight[i] = HeuWeight[j];
                            HeuWeight[j] = temp;
                        }

                // Dejar los que tengan el máximo
                int pivot = 1, maxValue = ((int[])HeuWeight[0])[1];
                if (HeuWeight.Count > 0)
                    for (i = 1; i < HeuWeight.Count; i++)
                        if (((int[])HeuWeight[i])[1] == maxValue)
                            pivot++;

                // Elegir al azar
                Random n = new Random();
                heuLastWeight = ((int[])HeuWeight[n.Next(0, pivot)])[1];

                return startupNode.GetNode(((int[])HeuWeight[n.Next(0, pivot)])[0]);
            }

            // Si no hay otra jugada
            return startupNode;
        }
        #endregion

        #region "Funciones de la interfaz"
        private void solveTicTacToeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!game.Solved || startupPlayer != game.SolvedFor || groupBoxSolutionBrowser.Enabled == false)
            {
                labelStatus.Text = Properties.Resources.ResourceManager.GetString("Solving");
                Application.DoEvents();

                // Resolver
                game.Solve(startupPlayer);
                
                // Recolección instantánea de basura
                if (automaticGC)
                    GC.Collect();

                // Para navegar el árbol
                lastBrowsedNode = 0;
                lastBrowsedSubNode = 0;
                nodes = new ArrayList();
                nodes.Add(game.SolutionRoot);

                DrawCurrentNodeBoard();
                groupBoxSolutionBrowser.Enabled = true;
            }
            else
            {
                MessageBox.Show(Properties.Resources.ResourceManager.GetString("Solved"),
                    Properties.Resources.ResourceManager.GetString("Solver"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            labelStatus.Text = Properties.Resources.ResourceManager.GetString("Solution_generated");
        }

        private void buttonBoardNext_Click(object sender, EventArgs e)
        {
            if (lastBrowsedSubNode + 1 < ((Node)nodes[lastBrowsedNode]).Count)
                lastBrowsedSubNode++;
            DrawCurrentNodeBoard();
        }

        private void buttonBoardPrevious_Click(object sender, EventArgs e)
        {
            if (lastBrowsedSubNode > 0)
                lastBrowsedSubNode--;

            DrawCurrentNodeBoard();
        }

        private void buttonBoardDeeper_Click(object sender, EventArgs e)
        {
            if (((Node)nodes[lastBrowsedNode]).GetNode(lastBrowsedSubNode).Count > 0)
            {
                nodes.Add(((Node)nodes[lastBrowsedNode]).GetNode(lastBrowsedSubNode));
                lastBrowsedNode++;
                lastBrowsedSubNode = 0;
            }

            DrawCurrentNodeBoard();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.ResourceManager.GetString("About"),
                Properties.Resources.ResourceManager.GetString("About_title"));
        }

        private void buttonBoardParent_Click(object sender, EventArgs e)
        {
            if (lastBrowsedNode > 0)
            {
                nodes.RemoveAt(lastBrowsedNode--);
                lastBrowsedSubNode = 0;
            }
            DrawCurrentNodeBoard();
        }

        private void player1StartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startupPlayer = 1;
        }

        private void player2StartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startupPlayer = -1;
        }

        private void calculateUtilityFromBottomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!game.UtilityCalculated && game.Solved)
            {
                labelStatus.Text = Properties.Resources.ResourceManager.GetString("Calculating");
                Application.DoEvents();

                // Resolver
                game.CalculeUtility();
                DrawCurrentNodeBoard();

                labelStatus.Text = Properties.Resources.ResourceManager.GetString("Utility_calculated");
            }
            else
            {
                if (game.Solved && groupBoxSolutionBrowser.Enabled)
                {
                    MessageBox.Show(Properties.Resources.ResourceManager.GetString("Already_calculated"),
                        Properties.Resources.ResourceManager.GetString("Solver"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Properties.Resources.ResourceManager.GetString("Unsolved"),
                        Properties.Resources.ResourceManager.GetString("Solver"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonMinMax_Click(object sender, EventArgs e)
        {
            MinMaxInitialization(1);

            minMaxBoard = (int[,])minMaxActualNode.Board.Clone();
            if (Game.RemainingPlays(minMaxBoard) > 0 && Game.WhoWins(minMaxBoard) == 0)
            {
                /*  1 | 2 | 3
                 * ---+---+---
                 *  4 | 5 | 6
                 * ---+---+---
                 *  7 | 8 | 9
                 */

                switch (Convert.ToInt16(((Button)sender).Tag.ToString()))
                {
                    case 1:
                        if (minMaxBoard[0, 0] == 0)
                            minMaxBoard[0, 0] = 1;
                        break;
                    case 2:
                        if (minMaxBoard[1, 0] == 0)
                            minMaxBoard[1, 0] = 1;
                        break;
                    case 3:
                        if (minMaxBoard[2, 0] == 0)
                            minMaxBoard[2, 0] = 1;
                        break;
                    case 4:
                        if (minMaxBoard[0, 1] == 0)
                            minMaxBoard[0, 1] = 1;
                        break;
                    case 5:
                        if (minMaxBoard[1, 1] == 0)
                            minMaxBoard[1, 1] = 1;
                        break;
                    case 6:
                        if (minMaxBoard[2, 1] == 0)
                            minMaxBoard[2, 1] = 1;
                        break;
                    case 7:
                        if (minMaxBoard[0, 2] == 0)
                            minMaxBoard[0, 2] = 1;
                        break;
                    case 8:
                        if (minMaxBoard[1, 2] == 0)
                            minMaxBoard[1, 2] = 1;
                        break;
                    case 9:
                        if (minMaxBoard[2, 2] == 0)
                            minMaxBoard[2, 2] = 1;
                        break;
                }

                // ¿Hizo realmente alguna jugada?
                if (!BoardsAreEqual(minMaxActualNode.Board, minMaxBoard))
                {
                    int i;

                    // Bajar el árbol, según la jugada
                    for (i = 0; i < minMaxActualNode.Count; i++)
                    {
                        if (BoardsAreEqual(minMaxBoard, minMaxActualNode.GetNode(i).Board))
                        {
                            minMaxActualNode = minMaxActualNode.GetNode(i);
                            break;
                        }
                    }

                    // Elegir la mejor siguiente jugada
                    if (this.checkBoxMinMaxDelay.Checked && Game.RemainingPlays(minMaxActualNode.Board) > 0)
                    {
                        DateTime start = DateTime.Now;

                        DrawCurrentMinMaxBoard();
                        labelMinMax.Text = Properties.Resources.ResourceManager.GetString("Thinking");

                        tabControlMain.Enabled = false;
                        while (DateTime.Now.Ticks - start.Ticks < 15000000)
                            Application.DoEvents();
                        tabControlMain.Enabled = true;
                    }

                    minMaxActualNode = MinMaxPickTheBest(minMaxActualNode);
                }
            }

            DrawCurrentMinMaxBoard();
        }

        private void buttonMinMaxReset_Click(object sender, EventArgs e)
        {
            MinMaxReset();
        }

        private void buttonMinMaxComputer_Click(object sender, EventArgs e)
        {
            MinMaxReset();
            MinMaxInitialization(-1);

            // Iniciar en el centro
            if (startAtcenterToolStripMenuItem.Checked)
                minMaxActualNode = minMaxActualNode.GetNode(4);
            else
            {
                Random n = new Random();
                minMaxActualNode = minMaxActualNode.GetNode(n.Next(0, 9));
            }

            DrawCurrentMinMaxBoard();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxMinMaxDetails.Visible = checkBoxMinMaxDetails.Checked;
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Esto debería funcionar sólo con Windows, no Mono
                if (Environment.GetEnvironmentVariable("OS").IndexOf("Windows") != -1)
                {
                    actionsToolStripMenuItem.Visible = (tabControlMain.SelectedIndex == 0);
                    minmaxToolStripMenuItem.Visible = (tabControlMain.SelectedIndex == 1);
                }
            }
            catch (Exception) { }

            switch (tabControlMain.SelectedIndex)
            {
                case 0:
                    DrawCurrentNodeBoard();
                    break;
                case 1:
                    minMaxStarted = false;
                    MinMaxReset();
                    break;
                case 2:
                    heuStarted = false;
                    HeuReset();
                    break;
            }

        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            long prev = GC.GetTotalMemory(false);
            GC.Collect();
            long post = GC.GetTotalMemory(true);

            double mb = prev - post;
            mb = Math.Round(mb / 1024 / 1024, 1);

            MessageBox.Show(String.Format(Properties.Resources.ResourceManager.GetString("Garbage_collected"), mb),
                Properties.Resources.ResourceManager.GetString("Garbage_collected_title"));
        }

        private void automaticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            automaticGC = automaticToolStripMenuItem.Checked;
        }

        private void buttonHeu_Click(object sender, EventArgs e)
        {
            HeuInitialization(1);

            heuBoard = (int[,])heuActualNode.Board.Clone();
            if (Game.RemainingPlays(heuBoard) > 0 && Game.WhoWins(heuBoard) == 0)
            {
                /*  1 | 2 | 3
                 * ---+---+---
                 *  4 | 5 | 6
                 * ---+---+---
                 *  7 | 8 | 9
                 */

                switch (Convert.ToInt16(((Button)sender).Tag.ToString()))
                {
                    case 1:
                        if (heuBoard[0, 0] == 0)
                            heuBoard[0, 0] = 1;
                        break;
                    case 2:
                        if (heuBoard[1, 0] == 0)
                            heuBoard[1, 0] = 1;
                        break;
                    case 3:
                        if (heuBoard[2, 0] == 0)
                            heuBoard[2, 0] = 1;
                        break;
                    case 4:
                        if (heuBoard[0, 1] == 0)
                            heuBoard[0, 1] = 1;
                        break;
                    case 5:
                        if (heuBoard[1, 1] == 0)
                            heuBoard[1, 1] = 1;
                        break;
                    case 6:
                        if (heuBoard[2, 1] == 0)
                            heuBoard[2, 1] = 1;
                        break;
                    case 7:
                        if (heuBoard[0, 2] == 0)
                            heuBoard[0, 2] = 1;
                        break;
                    case 8:
                        if (heuBoard[1, 2] == 0)
                            heuBoard[1, 2] = 1;
                        break;
                    case 9:
                        if (heuBoard[2, 2] == 0)
                            heuBoard[2, 2] = 1;
                        break;
                }

                // ¿Hizo realmente alguna jugada?
                if (!BoardsAreEqual(heuActualNode.Board, heuBoard))
                {
                    int i;

                    // Bajar el árbol, según la jugada
                    for (i = 0; i < heuActualNode.Count; i++)
                    {
                        if (BoardsAreEqual(heuBoard, heuActualNode.GetNode(i).Board))
                        {
                            heuActualNode = heuActualNode.GetNode(i);
                            break;
                        }
                    }

                    // Elegir la mejor siguiente jugada
                    if (this.checkBoxHeuDelay.Checked && Game.RemainingPlays(heuActualNode.Board) > 0)
                    {
                        DateTime start = DateTime.Now;

                        DrawCurrentHeuBoard();
                        labelHeu.Text = Properties.Resources.ResourceManager.GetString("Thinking");

                        tabControlMain.Enabled = false;
                        while (DateTime.Now.Ticks - start.Ticks < 15000000)
                            Application.DoEvents();
                        tabControlMain.Enabled = true;
                    }

                    heuActualNode = HeuPickTheBest(heuActualNode);
                }
            }

            DrawCurrentHeuBoard();
        }

        private void buttonHeuReset_Click(object sender, EventArgs e)
        {
            HeuReset();
        }

        private void checkBoxHeuDetails_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxHeuDetails.Visible = checkBoxHeuDetails.Checked;
        }

        private void buttonHeuComputer_Click(object sender, EventArgs e)
        {
            HeuReset();
            HeuInitialization(-1);
            heuActualNode = HeuPickTheBest(heuActualNode);
            DrawCurrentHeuBoard();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            checkBoxHeuDetails.Checked = true;
            checkBoxMinMaxDetails.Checked = true;

            // Hacer cambio de pestaña
            if (tabControlMain.SelectedIndex == 0)
                tabControlMain.SelectedIndex = 1;
            tabControlMain.SelectedIndex = 0;
        }

        private void randomStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            randomStartToolStripMenuItem.Checked = true;
            startAtcenterToolStripMenuItem.Checked = false;
        }

        private void startAtcenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            randomStartToolStripMenuItem.Checked = false;
            startAtcenterToolStripMenuItem.Checked = true;
        }
        
        #endregion
    }
}