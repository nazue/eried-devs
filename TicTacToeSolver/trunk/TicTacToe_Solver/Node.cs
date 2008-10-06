using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace TicTacToe
{
    /// <summary>
    /// Nodo de un arbol de jugadas del Gato
    /// </summary>
    class Node
    {
        #region "Campos"
        private ArrayList _nodes;
        private Node _parent;
        private int[,] _board;
        private int _weight, _turn;
        private bool _weighted;
        #endregion

        #region "Constructores"
        /// <summary>
        /// Inicializa un nodo con un tablero, jugador inicial y padre designado
        /// </summary>
        /// <param name="initialBoard">Tablero inicial</param>
        /// <param name="player">Jugador</param>
        /// <param name="newParent">Nuevo padre</param>
        public Node(int[,] initialBoard, int player, Node newParent)
        {
            _turn = player;
            _board = initialBoard;
            _nodes = new ArrayList();
            _weight = 0;
            _parent = newParent;
            _weighted = false;
        }

        /// <summary>
        /// Inicializa un nodo con un tablero y jugador inicial designado
        /// </summary>
        /// <param name="initialBoard">Tablero inicial</param>
        /// <param name="player">Jugador</param>
        public Node(int[,] initialBoard, int player)
        {
            _turn = player;
            _board = initialBoard;
            _nodes = new ArrayList();
            _weight = 0;
            _weighted = false;
        }

        /// <summary>
        /// Inicializa un nodo con un tablero designado
        /// </summary>
        /// <param name="initialBoard">Tablero inicial</param>
        public Node(int[,] initialBoard)
        {
            _turn = 0;
            _board = initialBoard;
            _nodes = new ArrayList();
            _weight = 0;
            _weighted = false;
        }

        /// <summary>
        /// Inicializa un nodo con un tablero vacío
        /// </summary>
        public Node()
        {
            _turn = 0;
            _board = new int[3, 3];
            _nodes = new ArrayList();
            _weight = 0;
            _weighted = false;
        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Define si fue calculado el peso del nodo
        /// </summary>
        public bool Weighted
        {
            get
            {
                return _weighted;
            }
            set
            {
                _weighted = value;
            }
        }
        /// <summary>
        /// Peso del nodo
        /// </summary>
        public int Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
            }
        }

        /// <summary>
        /// Turno jugado en este nodo
        /// </summary>
        public int Turn
        {
            get
            {
                return _turn;
            }
            set
            {
                _turn = value;
            }
        }

        /// <summary>
        /// Padre del nodo
        /// </summary>
        public Node Parent
        {
            get
            {
                return _parent;
            }
            set
            {
                _parent = value;
            }
        }

        /// <summary>
        /// Total de los nodos
        /// </summary>
        public int Count
        {
            get
            {
                return _nodes.Count;
            }
        }

        /// <summary>
        /// Tablero del nodo actual
        /// </summary>
        public int[,] Board
        {
            get
            {
                return _board;
            }
            set
            {
                _board = value;
            }
        }
        #endregion

        #region "Funciones"
        ///<summary>
        ///Obtiene el tablero como cadena
        ///</summary>
        ///<returns>El tablero como una cadena de texto</returns>
        public String GetBoardAsString()
        {
            String a = "", c;

            foreach (int z in _board)
            {
                c = "_";
                switch (z)
                {
                    case 1: c = "X"; break;
                    case -1: c = "O"; break;
                }
                a += c;
            }

            return a;
        }

        /// <summary>
        /// Añade un nodo nuevo
        /// </summary>
        /// <param name="addThis">Nodo a añadir</param>
        public void AddNode(Node addThis)
        {
            _nodes.Add(addThis);
        }

        /// <summary>
        /// Obtiene un nodo
        /// </summary>
        /// <param name="n">Índice de nodo</param>
        /// <returns>Nodo con el índice indicado</returns>
        public Node GetNode(int n)
        {
            return (Node)_nodes[n];
        }
        #endregion
    }
}
