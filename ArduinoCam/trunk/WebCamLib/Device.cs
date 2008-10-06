using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WebCamLib
{
    /// <summary>
    /// Para más información vea:
    /// http://windowssdk.msdn.microsoft.com/library/default.asp?url=/library/en-us/Multimed/htm/_win32_using_video_capture.asp
    /// </summary>
    public class Device
    {
        private int index;
        private int deviceHandle;
        private string _name;
        private string _version;

        #region "Constantes para la librería avicap32"
        private const short WM_CAP = 0x400;
        private const int WM_CAP_DRIVER_CONNECT = 0x40a;
        private const int WM_CAP_DRIVER_DISCONNECT = 0x40b;
        private const int WM_CAP_EDIT_COPY = 0x41e;
        private const int WM_CAP_DLG_VIDEOFORMAT = 0x429;
        private const int WM_CAP_DLG_VIDEOSOURCE = 0x42A;
        private const int WM_CAP_DLG_VIDEODISPLAY = 0x42B;
        private const int WM_CAP_SET_PREVIEW = 0x432;
        private const int WM_CAP_SET_OVERLAY = 0x433;
        private const int WM_CAP_GRAB_FRAME_NOSTOP = 0x43d;
        private const int WM_CAP_SET_PREVIEWRATE = 0x434;
        private const int WM_CAP_SET_SCALE = 0x435;
        private const int WS_CHILD = 0x40000000;
        private const int WS_VISIBLE = 0x10000000;
        #endregion

        #region "Librerías de la clase"
        [DllImport("avicap32.dll")]
        protected static extern int capCreateCaptureWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszWindowName,
            int dwStyle, int x, int y, int nWidth, int nHeight, int hWndParent, int nID);

        [DllImport("user32", EntryPoint = "SendMessageA")]
        protected static extern int SendMessage(int hwnd, int wMsg, int wParam, [MarshalAs(UnmanagedType.AsAny)] object lParam);

        [DllImport("user32")]
        protected static extern int SetWindowPos(int hwnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);

        [DllImport("user32")]
        protected static extern bool DestroyWindow(int hwnd);
        #endregion

        public Device(int index)
        {
            this.index = index;
        }

        public string Name
        {
            get { return _name.Replace("\0"," ").Trim(); }
            set { _name = value; }
        }

        public string Version
        {
            get { return _version.Replace("\0"," ").Replace("Version:  ","").Trim(); }
            set { _version = value; }
        }

        /// <summary>
        /// Copiar la imagen actual del dispositivo al portapapeles
        /// </summary>
        public void CopyFrameToClipboard()
        {
            SendMessage(deviceHandle, WM_CAP_GRAB_FRAME_NOSTOP, -1, 0);
            SendMessage(deviceHandle, WM_CAP_EDIT_COPY, -1, 0);
        }

        public void SaveFrameToFile(string p)
        {
            
        }

        public void GetFrameAsImage()
        {

        }

        public void ShowVideoDisplayDialog()
        {
            SendMessage(deviceHandle, WM_CAP_DLG_VIDEODISPLAY, -1, 0);
        }

        public void ShowVideoFormatDialog()
        {
            SendMessage(deviceHandle, WM_CAP_DLG_VIDEOFORMAT, -1, 0);
        }

        public void ShowVideoSourceDialog()
        {
            SendMessage(deviceHandle, WM_CAP_DLG_VIDEOSOURCE, -1, 0);
        }

        public override string ToString()
        {
            return this.Name;
        }
        /// <summary>
        /// Inicializar el dispositivo
        /// </summary>
        /// <param name="windowHeight">Alto de la ventana</param>
        /// <param name="windowWidth">Ancho de la ventana</param>
        /// <param name="handle">El control de ventana para desplegar la vista previa</param>
        public void Init(int windowHeight, int windowWidth, int handle)
        {
            string deviceIndex = Convert.ToString(this.index);
            deviceHandle = capCreateCaptureWindowA(ref deviceIndex, WS_VISIBLE | WS_CHILD, 0, 0, windowWidth, windowHeight, handle, 0);

            if (SendMessage(deviceHandle, WM_CAP_DRIVER_CONNECT, this.index, 0) > 0)
            {
                SendMessage(deviceHandle, WM_CAP_SET_SCALE, -1, 0);
                SendMessage(deviceHandle, WM_CAP_SET_PREVIEWRATE, 0x42, 0);
                SendMessage(deviceHandle, WM_CAP_SET_PREVIEW, -1, 0);

                SetWindowPos(deviceHandle, 1, 0, 0, windowWidth, windowHeight, 6);
            }
        }

        /// <summary>
        /// Mostrar la vista previa
        /// </summary>
        /// <param name="windowsControl">Un control para mostrar la vista previa</param>
        public void ShowWindow(global::System.Windows.Forms.Control windowsControl)
        {
            Init(windowsControl.Height, windowsControl.Width, windowsControl.Handle.ToInt32());                        
        }

        /// <summary>
        /// Detener la cámara
        /// </summary>
        public void Stop()
        {
            SendMessage(deviceHandle, WM_CAP_DRIVER_DISCONNECT, this.index, 0);
            DestroyWindow(deviceHandle);
        }
    }
}
