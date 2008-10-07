using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using TM_Tracks_Password_Editor.Properties;

namespace TM_Tracks_Password_Editor
{
    public partial class FormMain : Form
    {
        bool hayPassword = false;
        
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    hayPassword = false;
                    Byte[] archivo;
                    archivo = File.ReadAllBytes(openFileDialog1.FileName);

                    int posActual, posInicial, posFinal;

                    for (posActual = 6; posActual < 512; posActual++)
                    {
                        if (archivo[posActual - 1] == 229
                            & archivo[posActual - 2] == 180
                            & archivo[posActual - 3] == 31
                            & archivo[posActual - 4] == 0
                            & archivo[posActual - 5] == 0
                            & archivo[posActual - 6] == 0)
                        {
                            break;
                        }
                    }

                    posInicial = posActual;

                    if (posInicial == 512)
                    {
                        hayPassword = false;
                        textBox1.Text = "(No se encontró una contraseña)";
                    }
                    else
                    {
                        for (posActual = posInicial; posActual < archivo.Length - 10; posActual++)
                        {
                            if (archivo[posActual + 1] == 0
                                & archivo[posActual + 2] == 0
                                & archivo[posActual + 3] == 0
                                & archivo[posActual + 4] == 64
                                & archivo[posActual + 5] == 3)
                            {
                                break;
                            }
                        }

                        posFinal = posActual;
                        string password = "";
                        char temporalCharPass;

                        for (posActual = posInicial; posActual <= posFinal; posActual++)
                        {
                            temporalCharPass = decodifica(archivo[posActual], ((posActual - posInicial) % 5) + 1);
                            /*
                            // Es un caracter extendido?
                            if (temporalCharPass == ' ' && posActual+1<=posFinal)
                            {
                                temporalCharPass = decodificaExtendido(archivo[posActual], archivo[posActual+1], ((posActual - posInicial) % 5) + 2);
                                if (temporalCharPass == ' ')
                                {
                                    posActual++;
                                }
                            }
                             */
                            
                            password += temporalCharPass;
                        }

                        if (password.IndexOf(' ') > 0)
                        {
                            hayPassword = false;
                            textBox1.Text = "(La contraseña es inválida)";
                        }
                        else
                        {
                            hayPassword = true;
                            textBox1.Text = password;
                        }
                    }
                }
                catch (Exception)
                {
                    hayPassword = false;
                    textBox1.Text = "(Error al leer el archivo)";
                }
                
                //MessageBox.Show(posInicial + ", " + posFinal + "  aaa: " + openFileDialog1.FileName);
            }
        }
        /*
        private char decodificaExtendido(byte caracter, byte caracter2, int posicion)
        {
            #region Condiciones

            #endregion
        }
        */
        private char decodifica(byte caracter, int posicion)
        {
            #region Condiciones
            //if (caracter == 10 & posicion == 1) { return 'a'; }
            if (caracter == 0 && posicion == 5) { return 'Z'; }
            if (caracter == 2 && posicion == 5) { return 'X'; }
            if (caracter == 3 && posicion == 5) { return 'Y'; }
            if (caracter == 4 && posicion == 1) { return 'Z'; }
            if (caracter == 6 && posicion == 1) { return 'X'; }
            if (caracter == 7 && posicion == 1) { return 'Y'; }
            if (caracter == 8 && posicion == 5) { return 'R'; }
            if (caracter == 8 && posicion == 1) { return 'V'; }
            if (caracter == 9 && posicion == 5) { return 'S'; }
            if (caracter == 9 && posicion == 1) { return 'W'; }
            if (caracter == 10 && posicion == 5) { return 'P'; }
            if (caracter == 10 && posicion == 1) { return 'T'; }
            if (caracter == 11 && posicion == 5) { return 'Q'; }
            if (caracter == 11 && posicion == 1) { return 'U'; }
            if (caracter == 12 && posicion == 1) { return 'R'; }
            if (caracter == 12 && posicion == 5) { return 'V'; }
            if (caracter == 13 && posicion == 1) { return 'S'; }
            if (caracter == 13 && posicion == 5) { return 'W'; }
            if (caracter == 14 && posicion == 1) { return 'P'; }
            if (caracter == 14 && posicion == 5) { return 'T'; }
            if (caracter == 15 && posicion == 1) { return 'Q'; }
            if (caracter == 15 && posicion == 5) { return 'U'; }
            if (caracter == 16 && posicion == 5) { return 'J'; }
            if (caracter == 16 && posicion == 1) { return 'N'; }
            if (caracter == 16 && posicion == 2) { return '4'; }
            if (caracter == 17 && posicion == 5) { return 'K'; }
            if (caracter == 17 && posicion == 1) { return 'O'; }
            if (caracter == 17 && posicion == 2) { return '5'; }
            if (caracter == 18 && posicion == 5) { return 'H'; }
            if (caracter == 18 && posicion == 1) { return 'L'; }
            if (caracter == 18 && posicion == 2) { return '6'; }
            if (caracter == 19 && posicion == 5) { return 'I'; }
            if (caracter == 19 && posicion == 1) { return 'M'; }
            if (caracter == 19 && posicion == 2) { return '7'; }
            if (caracter == 20 && posicion == 1) { return 'J'; }
            if (caracter == 20 && posicion == 5) { return 'N'; }
            if (caracter == 20 && posicion == 2) { return '0'; }
            if (caracter == 21 && posicion == 1) { return 'K'; }
            if (caracter == 21 && posicion == 5) { return 'O'; }
            if (caracter == 21 && posicion == 2) { return '1'; }
            if (caracter == 22 && posicion == 1) { return 'H'; }
            if (caracter == 22 && posicion == 5) { return 'L'; }
            if (caracter == 22 && posicion == 2) { return '2'; }
            if (caracter == 23 && posicion == 1) { return 'I'; }
            if (caracter == 23 && posicion == 5) { return 'M'; }
            if (caracter == 23 && posicion == 2) { return '3'; }
            if (caracter == 24 && posicion == 5) { return 'B'; }
            if (caracter == 24 && posicion == 1) { return 'F'; }
            if (caracter == 25 && posicion == 5) { return 'C'; }
            if (caracter == 25 && posicion == 1) { return 'G'; }
            if (caracter == 26 && posicion == 1) { return 'D'; }
            if (caracter == 27 && posicion == 5) { return 'A'; }
            if (caracter == 27 && posicion == 1) { return 'E'; }
            if (caracter == 28 && posicion == 1) { return 'B'; }
            if (caracter == 28 && posicion == 5) { return 'F'; }
            if (caracter == 28 && posicion == 2) { return '8'; }
            if (caracter == 29 && posicion == 1) { return 'C'; }
            if (caracter == 29 && posicion == 5) { return 'G'; }
            if (caracter == 29 && posicion == 2) { return '9'; }
            if (caracter == 30 && posicion == 5) { return 'D'; }
            if (caracter == 31 && posicion == 1) { return 'A'; }
            if (caracter == 31 && posicion == 5) { return 'E'; }
            if (caracter == 32 && posicion == 5) { return 'z'; }
            if (caracter == 34 && posicion == 5) { return 'x'; }
            if (caracter == 35 && posicion == 5) { return 'y'; }
            if (caracter == 36 && posicion == 1) { return 'z'; }
            if (caracter == 38 && posicion == 1) { return 'x'; }
            if (caracter == 39 && posicion == 1) { return 'y'; }
            if (caracter == 40 && posicion == 5) { return 'r'; }
            if (caracter == 40 && posicion == 1) { return 'v'; }
            if (caracter == 41 && posicion == 5) { return 's'; }
            if (caracter == 41 && posicion == 1) { return 'w'; }
            if (caracter == 42 && posicion == 5) { return 'p'; }
            if (caracter == 42 && posicion == 1) { return 't'; }
            if (caracter == 43 && posicion == 5) { return 'q'; }
            if (caracter == 43 && posicion == 1) { return 'u'; }
            if (caracter == 44 && posicion == 1) { return 'r'; }
            if (caracter == 44 && posicion == 5) { return 'v'; }
            if (caracter == 45 && posicion == 1) { return 's'; }
            if (caracter == 45 && posicion == 5) { return 'w'; }
            if (caracter == 46 && posicion == 1) { return 'p'; }
            if (caracter == 46 && posicion == 5) { return 't'; }
            if (caracter == 47 && posicion == 1) { return 'q'; }
            if (caracter == 47 && posicion == 5) { return 'u'; }
            if (caracter == 48 && posicion == 5) { return 'j'; }
            if (caracter == 48 && posicion == 1) { return 'n'; }
            if (caracter == 49 && posicion == 5) { return 'k'; }
            if (caracter == 49 && posicion == 1) { return 'o'; }
            if (caracter == 50 && posicion == 5) { return 'h'; }
            if (caracter == 50 && posicion == 1) { return 'l'; }
            if (caracter == 51 && posicion == 5) { return 'i'; }
            if (caracter == 51 && posicion == 1) { return 'm'; }
            if (caracter == 52 && posicion == 1) { return 'j'; }
            if (caracter == 52 && posicion == 5) { return 'n'; }
            if (caracter == 53 && posicion == 1) { return 'k'; }
            if (caracter == 53 && posicion == 5) { return 'o'; }
            if (caracter == 54 && posicion == 1) { return 'h'; }
            if (caracter == 54 && posicion == 5) { return 'l'; }
            if (caracter == 54 && posicion == 4) { return '9'; }
            if (caracter == 55 && posicion == 1) { return 'i'; }
            if (caracter == 55 && posicion == 5) { return 'm'; }
            if (caracter == 55 && posicion == 4) { return '8'; }
            if (caracter == 56 && posicion == 5) { return 'b'; }
            if (caracter == 56 && posicion == 1) { return 'f'; }
            if (caracter == 56 && posicion == 4) { return '7'; }
            if (caracter == 57 && posicion == 5) { return 'c'; }
            if (caracter == 57 && posicion == 1) { return 'g'; }
            if (caracter == 57 && posicion == 4) { return '6'; }
            if (caracter == 58 && posicion == 1) { return 'd'; }
            if (caracter == 58 && posicion == 4) { return '5'; }
            if (caracter == 59 && posicion == 5) { return 'a'; }
            if (caracter == 59 && posicion == 1) { return 'e'; }
            if (caracter == 59 && posicion == 4) { return '4'; }
            if (caracter == 60 && posicion == 1) { return 'b'; }
            if (caracter == 60 && posicion == 5) { return 'f'; }
            if (caracter == 60 && posicion == 4) { return '3'; }
            if (caracter == 61 && posicion == 1) { return 'c'; }
            if (caracter == 61 && posicion == 5) { return 'g'; }
            if (caracter == 61 && posicion == 4) { return '2'; }
            if (caracter == 62 && posicion == 5) { return 'd'; }
            if (caracter == 62 && posicion == 4) { return '1'; }
            if (caracter == 63 && posicion == 1) { return 'a'; }
            if (caracter == 63 && posicion == 5) { return 'e'; }
            if (caracter == 63 && posicion == 4) { return '0'; }
            if (caracter == 64 && posicion == 2) { return 'd'; }
            if (caracter == 64 && posicion == 4) { return 'O'; }
            if (caracter == 65 && posicion == 2) { return 'e'; }
            if (caracter == 65 && posicion == 4) { return 'N'; }
            if (caracter == 66 && posicion == 2) { return 'f'; }
            if (caracter == 66 && posicion == 4) { return 'M'; }
            if (caracter == 67 && posicion == 2) { return 'g'; }
            if (caracter == 67 && posicion == 4) { return 'L'; }
            if (caracter == 68 && posicion == 4) { return 'K'; }
            if (caracter == 69 && posicion == 2) { return 'a'; }
            if (caracter == 69 && posicion == 4) { return 'J'; }
            if (caracter == 70 && posicion == 2) { return 'b'; }
            if (caracter == 70 && posicion == 4) { return 'I'; }
            if (caracter == 71 && posicion == 2) { return 'c'; }
            if (caracter == 71 && posicion == 4) { return 'H'; }
            if (caracter == 72 && posicion == 2) { return 'l'; }
            if (caracter == 72 && posicion == 4) { return 'G'; }
            if (caracter == 73 && posicion == 2) { return 'm'; }
            if (caracter == 73 && posicion == 4) { return 'F'; }
            if (caracter == 74 && posicion == 2) { return 'n'; }
            if (caracter == 74 && posicion == 4) { return 'E'; }
            if (caracter == 75 && posicion == 2) { return 'o'; }
            if (caracter == 75 && posicion == 4) { return 'D'; }
            if (caracter == 76 && posicion == 2) { return 'h'; }
            if (caracter == 76 && posicion == 4) { return 'C'; }
            if (caracter == 77 && posicion == 2) { return 'i'; }
            if (caracter == 77 && posicion == 4) { return 'B'; }
            if (caracter == 78 && posicion == 2) { return 'j'; }
            if (caracter == 78 && posicion == 4) { return 'A'; }
            if (caracter == 79 && posicion == 2) { return 'k'; }
            if (caracter == 80 && posicion == 2) { return 't'; }
            if (caracter == 81 && posicion == 2) { return 'u'; }
            if (caracter == 82 && posicion == 2) { return 'v'; }
            if (caracter == 83 && posicion == 2) { return 'w'; }
            if (caracter == 84 && posicion == 2) { return 'p'; }
            if (caracter == 85 && posicion == 2) { return 'q'; }
            if (caracter == 85 && posicion == 4) { return 'Z'; }
            if (caracter == 86 && posicion == 2) { return 'r'; }
            if (caracter == 86 && posicion == 4) { return 'Y'; }
            if (caracter == 87 && posicion == 2) { return 's'; }
            if (caracter == 87 && posicion == 4) { return 'X'; }
            if (caracter == 88 && posicion == 4) { return 'W'; }
            if (caracter == 89 && posicion == 4) { return 'V'; }
            if (caracter == 90 && posicion == 4) { return 'U'; }
            if (caracter == 91 && posicion == 4) { return 'T'; }
            if (caracter == 92 && posicion == 2) { return 'x'; }
            if (caracter == 92 && posicion == 4) { return 'S'; }
            if (caracter == 93 && posicion == 2) { return 'y'; }
            if (caracter == 93 && posicion == 4) { return 'R'; }
            if (caracter == 94 && posicion == 2) { return 'z'; }
            if (caracter == 94 && posicion == 4) { return 'Q'; }
            if (caracter == 95 && posicion == 4) { return 'P'; }
            if (caracter == 96 && posicion == 4) { return 'o'; }
            if (caracter == 96 && posicion == 2) { return 'D'; }
            if (caracter == 97 && posicion == 4) { return 'n'; }
            if (caracter == 97 && posicion == 2) { return 'E'; }
            if (caracter == 98 && posicion == 4) { return 'm'; }
            if (caracter == 98 && posicion == 2) { return 'F'; }
            if (caracter == 98 && posicion == 5) { return '8'; }
            if (caracter == 99 && posicion == 4) { return 'l'; }
            if (caracter == 99 && posicion == 2) { return 'G'; }
            if (caracter == 99 && posicion == 5) { return '9'; }
            if (caracter == 100 && posicion == 4) { return 'k'; }
            if (caracter == 101 && posicion == 4) { return 'j'; }
            if (caracter == 101 && posicion == 2) { return 'A'; }
            if (caracter == 102 && posicion == 4) { return 'i'; }
            if (caracter == 102 && posicion == 2) { return 'B'; }
            if (caracter == 102 && posicion == 1) { return '8'; }
            if (caracter == 103 && posicion == 4) { return 'h'; }
            if (caracter == 103 && posicion == 2) { return 'C'; }
            if (caracter == 103 && posicion == 1) { return '9'; }
            if (caracter == 104 && posicion == 4) { return 'g'; }
            if (caracter == 104 && posicion == 2) { return 'L'; }
            if (caracter == 104 && posicion == 5) { return '2'; }
            if (caracter == 104 && posicion == 1) { return '6'; }
            if (caracter == 105 && posicion == 4) { return 'f'; }
            if (caracter == 105 && posicion == 2) { return 'M'; }
            if (caracter == 105 && posicion == 5) { return '3'; }
            if (caracter == 105 && posicion == 1) { return '7'; }
            if (caracter == 106 && posicion == 4) { return 'e'; }
            if (caracter == 106 && posicion == 2) { return 'N'; }
            if (caracter == 106 && posicion == 5) { return '0'; }
            if (caracter == 106 && posicion == 1) { return '4'; }
            if (caracter == 107 && posicion == 4) { return 'd'; }
            if (caracter == 107 && posicion == 2) { return 'O'; }
            if (caracter == 107 && posicion == 5) { return '1'; }
            if (caracter == 107 && posicion == 1) { return '5'; }
            if (caracter == 108 && posicion == 4) { return 'c'; }
            if (caracter == 108 && posicion == 2) { return 'H'; }
            if (caracter == 108 && posicion == 1) { return '2'; }
            if (caracter == 108 && posicion == 5) { return '6'; }
            if (caracter == 109 && posicion == 4) { return 'b'; }
            if (caracter == 109 && posicion == 2) { return 'I'; }
            if (caracter == 109 && posicion == 1) { return '3'; }
            if (caracter == 109 && posicion == 5) { return '7'; }
            if (caracter == 110 && posicion == 4) { return 'a'; }
            if (caracter == 110 && posicion == 2) { return 'J'; }
            if (caracter == 110 && posicion == 1) { return '0'; }
            if (caracter == 110 && posicion == 5) { return '4'; }
            if (caracter == 111 && posicion == 2) { return 'K'; }
            if (caracter == 111 && posicion == 1) { return '1'; }
            if (caracter == 111 && posicion == 5) { return '5'; }
            if (caracter == 112 && posicion == 2) { return 'T'; }
            if (caracter == 113 && posicion == 2) { return 'U'; }
            if (caracter == 114 && posicion == 2) { return 'V'; }
            if (caracter == 115 && posicion == 2) { return 'W'; }
            if (caracter == 116 && posicion == 2) { return 'P'; }
            if (caracter == 117 && posicion == 4) { return 'z'; }
            if (caracter == 117 && posicion == 2) { return 'Q'; }
            if (caracter == 118 && posicion == 4) { return 'y'; }
            if (caracter == 118 && posicion == 2) { return 'R'; }
            if (caracter == 119 && posicion == 4) { return 'x'; }
            if (caracter == 119 && posicion == 2) { return 'S'; }
            if (caracter == 120 && posicion == 4) { return 'w'; }
            if (caracter == 121 && posicion == 4) { return 'v'; }
            if (caracter == 122 && posicion == 4) { return 'u'; }
            if (caracter == 123 && posicion == 4) { return 't'; }
            if (caracter == 124 && posicion == 4) { return 's'; }
            if (caracter == 124 && posicion == 2) { return 'X'; }
            if (caracter == 125 && posicion == 4) { return 'r'; }
            if (caracter == 125 && posicion == 2) { return 'Y'; }
            if (caracter == 126 && posicion == 4) { return 'q'; }
            if (caracter == 126 && posicion == 2) { return 'Z'; }
            if (caracter == 127 && posicion == 4) { return 'p'; }
            if (caracter == 128 && posicion == 3) { return 'p'; }
            if (caracter == 129 && posicion == 3) { return 'q'; }
            if (caracter == 130 && posicion == 3) { return 'r'; }
            if (caracter == 131 && posicion == 3) { return 's'; }
            if (caracter == 132 && posicion == 3) { return 't'; }
            if (caracter == 133 && posicion == 3) { return 'u'; }
            if (caracter == 134 && posicion == 3) { return 'v'; }
            if (caracter == 135 && posicion == 3) { return 'w'; }
            if (caracter == 136 && posicion == 3) { return 'x'; }
            if (caracter == 137 && posicion == 3) { return 'y'; }
            if (caracter == 138 && posicion == 3) { return 'z'; }
            if (caracter == 145 && posicion == 3) { return 'a'; }
            if (caracter == 146 && posicion == 3) { return 'b'; }
            if (caracter == 147 && posicion == 3) { return 'c'; }
            if (caracter == 148 && posicion == 3) { return 'd'; }
            if (caracter == 149 && posicion == 3) { return 'e'; }
            if (caracter == 150 && posicion == 3) { return 'f'; }
            if (caracter == 151 && posicion == 3) { return 'g'; }
            if (caracter == 152 && posicion == 3) { return 'h'; }
            if (caracter == 153 && posicion == 3) { return 'i'; }
            if (caracter == 154 && posicion == 3) { return 'j'; }
            if (caracter == 155 && posicion == 3) { return 'k'; }
            if (caracter == 156 && posicion == 3) { return 'l'; }
            if (caracter == 157 && posicion == 3) { return 'm'; }
            if (caracter == 158 && posicion == 3) { return 'n'; }
            if (caracter == 159 && posicion == 3) { return 'o'; }
            if (caracter == 160 && posicion == 3) { return 'P'; }
            if (caracter == 161 && posicion == 3) { return 'Q'; }
            if (caracter == 162 && posicion == 3) { return 'R'; }
            if (caracter == 163 && posicion == 3) { return 'S'; }
            if (caracter == 164 && posicion == 3) { return 'T'; }
            if (caracter == 165 && posicion == 3) { return 'U'; }
            if (caracter == 166 && posicion == 3) { return 'V'; }
            if (caracter == 167 && posicion == 3) { return 'W'; }
            if (caracter == 168 && posicion == 3) { return 'X'; }
            if (caracter == 169 && posicion == 3) { return 'Y'; }
            if (caracter == 170 && posicion == 3) { return 'Z'; }
            if (caracter == 177 && posicion == 3) { return 'A'; }
            if (caracter == 178 && posicion == 3) { return 'B'; }
            if (caracter == 179 && posicion == 3) { return 'C'; }
            if (caracter == 180 && posicion == 3) { return 'D'; }
            if (caracter == 181 && posicion == 3) { return 'E'; }
            if (caracter == 182 && posicion == 3) { return 'F'; }
            if (caracter == 183 && posicion == 3) { return 'G'; }
            if (caracter == 184 && posicion == 3) { return 'H'; }
            if (caracter == 185 && posicion == 3) { return 'I'; }
            if (caracter == 186 && posicion == 3) { return 'J'; }
            if (caracter == 187 && posicion == 3) { return 'K'; }
            if (caracter == 188 && posicion == 3) { return 'L'; }
            if (caracter == 189 && posicion == 3) { return 'M'; }
            if (caracter == 190 && posicion == 3) { return 'N'; }
            if (caracter == 191 && posicion == 3) { return 'O'; }
            if (caracter == 192 && posicion == 3) { return '0'; }
            if (caracter == 193 && posicion == 3) { return '1'; }
            if (caracter == 194 && posicion == 3) { return '2'; }
            if (caracter == 195 && posicion == 3) { return '3'; }
            if (caracter == 196 && posicion == 3) { return '4'; }
            if (caracter == 197 && posicion == 3) { return '5'; }
            if (caracter == 198 && posicion == 3) { return '6'; }
            if (caracter == 199 && posicion == 3) { return '7'; }
            if (caracter == 200 && posicion == 3) { return '8'; }
            if (caracter == 201 && posicion == 3) { return '9'; }


            return ' '; 
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (hayPassword)
            {
                Clipboard.SetText(textBox1.Text);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            String autor = "Erwin Ried";
            linkLabel1.Text += autor;
            linkLabel1.Links.Add(linkLabel1.Text.IndexOf(autor),autor.Length,"http://erwin.ried.cl");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}