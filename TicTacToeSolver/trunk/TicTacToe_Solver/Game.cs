using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace TicTacToe
{
    /// <summary>
    /// Maneja el juego y lo resuelve
    /// </summary>
    class Game
    {
        #region "Campos"
        private bool _solved, _utilityCalculated;
        private Node _solution;
        private int _solvedFor;
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public Game()
        {
            _utilityCalculated = false;
            _solved = false;
            _solvedFor = 0;
        }

        #region "Métodos de clase"
        /// <summary>
        /// Define para quien fue resuelto el juego la última vez
        /// </summary>
        public int SolvedFor
        {
            get
            {
                return _solvedFor;
            }
        }

        /// <summary>
        /// Define si el juego ha sido resuelto o no aún
        /// </summary>
        public bool Solved
        {
            get
            {
                return _solved;
            }
        }

        /// <summary>
        /// Define si la utilidad del árbol fue calculada para todos los nodos
        /// </summary>
        public bool UtilityCalculated
        {
            get
            {
                return _utilityCalculated;
            }
        }

        /// <summary>
        /// Nodo raiz de la solución
        /// </summary>
        public Node SolutionRoot
        {
            get
            {
                if (_solved)
                {
                    return _solution;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Calcula la utilidad, desde las hojas hacia arriba
        /// </summary>
        public void CalculeUtility()
        {
            if (_solved)
            {
                SetTheMinMax(_solution);
                _utilityCalculated = true;
            }
        }

        /// <summary>
        /// Sube el peso de los nodos hoja dependiendo del turno
        /// </summary>
        /// <param name="start">Nodo inicial</param>
        private int SetTheMinMax(Node start)
        {
            if (start.Weighted)
                return start.Weight;

            int i, w;
            start.Weight = SetTheMinMax(start.GetNode(0));

            for (i = 1; i < start.Count; i++)
            {
                w = SetTheMinMax(start.GetNode(i));
                if (start.Turn == _solvedFor)
                {
                    if (w < start.Weight)
                        start.Weight = w;
                }
                else
                {
                    if (w > start.Weight)
                        start.Weight = w;
                }
            }

            start.Weighted = true;
            return start.Weight;
            
        }

        /// <summary>
        /// Resuelve el juego
        /// </summary>
        /// <param name="player">Jugador inicial</param>
        /// <returns>Retorna el nodo superior del árbol de solución</returns>
        public void Solve(int player)
        {
            int[,] board = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            Node initial = new Node();

            initial.Board = board;

            _solved = true;
            _solvedFor = player;
            _utilityCalculated = false;
            _solution = ExpandAllNodes(initial, player);
        }

        /// <summary>
        /// Expande un nodo dado a todas las soluciones posibles
        /// </summary>
        /// <param name="start">Nodo inicial</param>
        /// <param name="player">Turno que se expandirá</param>
        /// <returns>El nodo inicial expandido</returns>
        private Node ExpandAllNodes(Node start, int player)
        {
            int[,] board = start.Board;
            int rem, i, whoWinsNow;

            rem = RemainingPlays(board);
            whoWinsNow = WhoWins(board);

            if (rem > 0 && whoWinsNow == 0)
            {
                ArrayList nextNodes = new ArrayList();
                nextNodes = ExpandNode(start, player);
                for (i = 0; i < nextNodes.Count; i++)
                    start.AddNode(ExpandAllNodes((Node)nextNodes[i], NextPlayer(player)));
            }
            else
            {
                start.Weight = _solvedFor * whoWinsNow * 10;
                start.Weighted = true;
            }

            return start;
        }

        /// <summary>
        /// Retorna el siguiente jugador
        /// </summary>
        /// <param name="player">Jugador actual</param>
        /// <returns>Siguiente jugador</returns>
        private int NextPlayer(int player)
        {
            return -player;
        }

        /// <summary>
        /// Realiza una jugada, saltando un número de jugadas designadas
        /// </summary>
        /// <param name="originalBoard">Tablero de juego</param>
        /// <param name="player">Jugador actual</param>
        /// <param name="skip">Jugadas a saltar</param>
        /// <returns>El tablero despues de la jugada</returns>
        private int[,] DoPlay(int[,] originalBoard, int player, int skip)
        {
            int i, j, len, skipped = 0;
            int[,] board = (int[,])originalBoard.Clone();

            len = board.GetLength(0);

            bool endFor = false;
            for (i = 0; i < len; i++)
            {
                for (j = 0; j < len; j++)
                {
                    if (board[i, j] == 0)
                    {
                        if (skipped == skip)
                        {
                            board[i, j] = player;
                            endFor = true;
                            break;
                        }
                        skipped++;
                    }
                }
                if (endFor)
                    break;
            }

            return board;
        }

        /// <summary>
        /// Expande un tablero, según las jugadas posibles
        /// </summary>
        /// <param name="start">Nodo inicial</param>
        /// <param name="player">Jugador actual</param>
        /// <returns>Lista de tableros</returns>
        private ArrayList ExpandNode(Node start, int player)
        {
            int i, rem;

            rem = RemainingPlays(start.Board);

            ArrayList output = new ArrayList();

            int[,] newBoard = (int[,])start.Board.Clone();

            for (i = 0; i < rem; i++)
                output.Add(new Node(DoPlay(newBoard, player, i), player, start));

            return output;
        }
        #endregion

        #region "Métodos estáticos generales"
        /// <summary>
        /// Comprueba si el tablero está lleno
        /// </summary>
        /// <param name="board">Tablero de juego</param>
        /// <returns>Casillas vacías</returns>
        public static int RemainingPlays(int[,] board)
        {
            int i, j, len, rem = 0;
            len = board.GetLength(0);

            for (i = 0; i < len; i++)
                for (j = 0; j < len; j++)
                    if (board[i, j] == 0)
                        rem++;
            return rem;
        }

        /// <summary>
        /// Comprueba si el juego terminó o no
        /// </summary>
        /// <param name="board">Tablero de juego</param>
        /// <returns>Valor del ganador o cero si ninguno ganó</returns>
        public static int WhoWins(int[,] board)
        {
            int i, j, player, checks, len;
            len = board.GetLength(0);

            // Comprobación horizontal
            for (j = 0; j < len; j++)
            {
                player = 0; checks = 0;
                for (i = 0; i < len; i++)
                {
                    if (board[i, j] != 0)
                        if (player != 0)
                        {
                            if (board[i, j] == player)
                                checks++;
                        }
                        else
                        {
                            player = board[i, j];
                            checks++;
                        }
                }

                if (checks == len)
                    return player;
            }

            // Comprobación vertical
            for (i = 0; i < len; i++)
            {
                player = 0; checks = 0;
                for (j = 0; j < len; j++)
                {
                    if (board[i, j] != 0)
                        if (player != 0)
                        {
                            if (board[i, j] == player)
                                checks++;
                        }
                        else
                        {
                            player = board[i, j];
                            checks++;
                        }
                }

                if (checks == len)
                    return player;
            }

            // Comprobación diagonal
            player = 0; checks = 0;
            for (i = 0; i < len; i++)
            {

                if (board[i, i] != 0)
                    if (player != 0)
                    {
                        if (board[i, i] == player)
                            checks++;
                    }
                    else
                    {
                        player = board[i, i];
                        checks++;
                    }

            }
            if (checks == len)
                return player;

            player = 0; checks = 0;
            for (i = 0; i < len; i++)
            {

                j = (len - 1) - i;
                if (board[j, i] != 0)
                    if (player != 0)
                    {
                        if (board[j, i] == player)
                            checks++;
                    }
                    else
                    {
                        player = board[j, i];
                        checks++;
                    }

            }
            if (checks == len)
                return player;

            // Nadie ganó
            return 0;
        }
        #endregion
    }
}
