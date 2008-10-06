using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WebCamLib;
using SerialHandlerLib;
using System.Net.Sockets;
using System.Net;

namespace ArduinoCam
{
    public partial class FormMain : Form
    {
        private Socket m_mainSocket, m_workerSocket;
        private AsyncCallback pfnWorkerCallBack;

        Device c;
        Serial s;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Cámara
            c = DeviceManager.GetAllDevices()[0];
            c.ShowWindow(pictureBox1);

            // Puerto serie
            s = new Serial(31);

            // Socket
            m_mainSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipLocal = new IPEndPoint(IPAddress.Any, 6666);

            m_mainSocket.Bind(ipLocal);
            m_mainSocket.Listen(4);
            m_mainSocket.BeginAccept(new AsyncCallback(OnClientConnect), null);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                s.Close();
                c.Stop();
            }
            catch { }
        }

        #region "Control de la cámara"
        private void buttonRight_MouseDown(object sender, MouseEventArgs e)
        {
            CameraRightSlow();
        }

        private void CameraRightSlow()
        {
            s.Send(new byte[] { 0xee, 0x20, 0xee, 0x0f });
        }

        private void buttonRight_MouseUp(object sender, MouseEventArgs e)
        {
            CameraStop();
        }

        private void buttonLeft_MouseDown(object sender, MouseEventArgs e)
        {
            CameraLeftSlow();
        }

        private void CameraLeftSlow()
        {
            s.Send(new byte[] { 0xee, 0x20, 0xee, 0x0d });
        }

        private void buttonLeft_MouseUp(object sender, MouseEventArgs e)
        {
            CameraStop();
        }

        private void CameraStop()
        {
            s.Send(new byte[] { 0xee, 0x00 });
        }

        private void buttonFastLeft_MouseDown(object sender, MouseEventArgs e)
        {
            CameraLeftFast();
        }

        private void CameraLeftFast()
        {
            s.Send(new byte[] { 0xee, 0x32, 0xee, 0x0d });
        }

        private void buttonFastLeft_MouseUp(object sender, MouseEventArgs e)
        {
            CameraStop();
        }

        private void buttonFastRight_MouseUp(object sender, MouseEventArgs e)
        {
            CameraStop();
        }

        private void buttonFastRight_MouseDown(object sender, MouseEventArgs e)
        {
            CameraRightFast();
        }

        private void CameraRightFast()
        {
            s.Send(new byte[] { 0xee, 0x32, 0xee, 0x0f });
        }
        #endregion

        #region "Conexión remota"
        public void OnClientConnect(IAsyncResult asyn)
        {
           /* try
            {*/
                m_workerSocket = m_mainSocket.EndAccept(asyn);
                WaitForData(m_workerSocket);
                StatusText("Conectado.");
            /*}
            catch { }*/
        }

        delegate void SetTextCallback(string text);

        private void StatusText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.label1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(StatusText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.label1.Text = text;
            }
        }


        public class SocketPacket
        {
            public System.Net.Sockets.Socket m_currentSocket;
            public byte[] dataBuffer = new byte[1];
        }

        private void WaitForData(Socket soc)
        {
            /*try
            {*/
                if (pfnWorkerCallBack == null)
                {
                    pfnWorkerCallBack = new AsyncCallback(OnDataReceived);
                }

                SocketPacket theSocPkt = new SocketPacket();
                theSocPkt.m_currentSocket = soc;

                soc.BeginReceive(theSocPkt.dataBuffer, 0,
                                   theSocPkt.dataBuffer.Length,
                                   SocketFlags.None,
                                   pfnWorkerCallBack,
                                   theSocPkt);
            /*}
            catch { }*/
        }

        public void OnDataReceived(IAsyncResult asyn)
        {
           /* try
            {*/
                SocketPacket socketData = (SocketPacket)asyn.AsyncState;

                int iRx = 0;
                iRx = socketData.m_currentSocket.EndReceive(asyn);
                char[] chars = new char[iRx + 1];
                System.Text.Decoder d = System.Text.Encoding.UTF8.GetDecoder();
                int charLen = d.GetChars(socketData.dataBuffer,
                                         0, iRx, chars, 0);
                System.String szData = new System.String(chars);

                switch (szData.ToCharArray()[0])
                {
                    case 'L':
                        CameraLeftSlow();
                        break;
                    case 'l':
                        CameraLeftFast();
                        break;
                    case 'R':
                        CameraRightSlow();
                        break;
                    case 'r':
                        CameraRightFast();
                        break;
                    case 'S':
                        CameraStop();
                        break;
                }

                //StatusText("Se recibió: " + szData);

                WaitForData(socketData.m_currentSocket);
           /* c }
           atch { }*/
        }

        private void RemoteCommand(string szData)
        {
            // Comprobar la estructura del comando CMD;<comando>;END
            // Comandos disponibles: SL_LEF, FA_LEF, SL_RIG, FA_RIG, M_STOP
            /*String[] c = szData.Split(';');

            if (c.Length >= 3)
            {
                if (c[0].CompareTo("CMD") == 0 && c[2].CompareTo("END") == 0)
                {
                    switch (c[1])
                    {
                        case "SL_LEF":
                            CameraLeftSlow();
                            break;
                        case "FA_LEF":
                            break;
                        case "SL_RIG":
                            CameraRightSlow();
                            break;
                        case "FA_RIG":
                            break;
                        case "M_STOP":
                            CameraStop();
                            break;
                    }
                }
            }*/


        }


        #endregion
    }
}