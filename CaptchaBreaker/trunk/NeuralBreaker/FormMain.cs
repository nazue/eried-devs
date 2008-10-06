using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Diagnostics;
using NeuralBreaker.Properties;

namespace NeuralBreaker
{
    public partial class FormMain : Form
    {
        private const int MAX_WIDTH_TRAIN_IMAGELIST = 80,
            MAX_WIDTH_QUERY_IMAGELIST = 60;

        private NeuralNetwork.NeuralNetwork neuralNetwork;
        private ArrayList inputFiles, captchaAnalized, captchaAnalizedQuery;
        private int zoomMode, zoomModeTrain;
        private Size originalSize, originalSizeTrain;
        private String pathTemporalDump, pathTemporalImg;

        /// <summary>
        /// Constructor del formulario principal
        /// </summary>
        public FormMain()
        {
            // Inicializaciones
            pathTemporalDump = Path.GetTempFileName();
            pathTemporalImg = Path.GetTempFileName();
            inputFiles = new ArrayList();
            captchaAnalized = new ArrayList();
            captchaAnalizedQuery = new ArrayList();

            // Zoom de las vistas previas
            zoomMode = 0;
            zoomModeTrain = 0;

            // Formularios
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            originalSize = this.pictureBoxCaptchaPreview.Size;
            originalSizeTrain = this.pictureBoxTrainPreview.Size;

            // Cargar configuración
            LoadAppSettings();

            // Cargar red neuronal
            ReloadNeuralNetwork();

            /*
            BinaryTranslator.BinaryTranslator z = new BinaryTranslator.BinaryTranslator();
            
            String t = "", f="";
            foreach (byte a in z.GetBinaryArray('a'))
                t += Convert.ToString(a);
            f += t + ", "; t = "";

            foreach (byte a in z.GetBinaryArray('z'))
                t += Convert.ToString(a);
            f += t + ", "; t = "";

            foreach (byte a in z.GetBinaryArray('A'))
                t += Convert.ToString(a);
            f += t + ", "; t = "";

            foreach (byte a in z.GetBinaryArray('Z'))
                t += Convert.ToString(a);
            f += t + ", "; t = "";

            foreach (byte a in z.GetBinaryArray('5'))
                t += Convert.ToString(a);

            f += t + " versus "; t = "";

            f += z.GetOriginalChar(new float[] { 1, 0, 0, 1, 0, 0 }, 0.5f);
            f += z.GetOriginalChar(new float[] { 0, 0, 0, 0, 0, 0 }, 0.5f);
            f += z.GetOriginalChar(new float[] { 0, 0, 1, 0, 1, 0 }, 0.5f);
            f += z.GetOriginalChar(new float[] { 1, 0, 0, 0, 1, 1 }, 0.5f);
            f += z.GetOriginalChar(new float[] { 1, 1, 1, 1, 0, 1 }, 0.5f);

            MessageBox.Show(f);*/

        }

        /// <summary>
        /// Actualizar o crear una nueva red
        /// </summary>
        private void ReloadNeuralNetwork()
        {
            labelTrainNetworkStatus.Text = "Cargando...";
            Application.DoEvents();

            neuralNetwork = null;

            if (File.Exists(this.textBoxNetworkPathSave.Text))
            {
                try
                {
                    neuralNetwork = NeuralNetwork.NeuralNetwork.LoadFromFile(this.textBoxNetworkPathSave.Text);
                    this.labelTrainNetworkStatus.Text = "Cargado el archivo de datos de una sesión anterior.";
                }
                catch { }
            }

            if (neuralNetwork == null)
            {
                neuralNetwork = new NeuralNetwork.NeuralNetwork();

                //neuralNetwork = new NeuralNetwork.NeuralNetwork(961, new int[] { 6 },
                //  new NeuralNetwork.SigmoidActivationFunction());

                //neuralNetwork = new NeuralNetwork.NeuralNetwork(961, new int[] { 6 },
                //   new NeuralNetwork.GaussianActivationFunction(),
                // new NeuralNetwork.GeneticLearningAlgorithm(neuralNetwork));
                this.labelTrainNetworkStatus.Text = "Nuevo archivo de datos listo para recibir entrenamiento.";
            }
        }

        private void listBoxInputImages_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy; // Manejar el arrastre
        }

        private void listBoxInputImages_DragDrop(object sender, DragEventArgs e)
        {
            ImportDraggedFiles((string[])e.Data.GetData(DataFormats.FileDrop));
        }

        /// <summary>
        /// Importar archivos
        /// </summary>
        /// <param name="files">Lista de las rutas a archivos</param>
        private void ImportDraggedFiles(string[] files)
        {
            foreach (string eachFile in files)
            {
                try
                {
                    AddCaptchaFile(eachFile);
                }
                catch { }
            }

            UpdateInputImagesList();

            if (checkBoxAutoStartTrain.Checked)
                BeginAutoTraining();

        }

        /// <summary>
        /// Actualiza las listas de imágenes
        /// </summary>
        private void UpdateInputImagesList()
        {
            this.listBoxInputImages.Items.Clear();
            this.comboBoxTrainImages.Items.Clear();
            this.comboBoxQueryImage.Items.Clear();

            this.listBoxInputImages.Items.AddRange(inputFiles.ToArray());

            // Añadir las imágenes con un largo ajustado
            foreach (String t in inputFiles.ToArray())
            {
                this.comboBoxTrainImages.Items.Add(t.Length > MAX_WIDTH_TRAIN_IMAGELIST ? "..." + t.Substring(t.Length - MAX_WIDTH_TRAIN_IMAGELIST - 3) : t);
                this.comboBoxQueryImage.Items.Add(t.Length > MAX_WIDTH_QUERY_IMAGELIST ? "..." + t.Substring(t.Length - MAX_WIDTH_QUERY_IMAGELIST - 3) : t);
            }
        }

        /// <summary>
        /// Añadir una imagen única a la lista de entrada
        /// </summary>
        /// <param name="bmpPath">Ruta del mapa de bits</param>
        private void AddCaptchaFile(string bmpPath)
        {
            if (!inputFiles.Contains(bmpPath))
                inputFiles.Add(bmpPath);
        }

        private void buttonZoomMode_Click(object sender, EventArgs e)
        {
            HandleZoom(ref zoomMode, pictureBoxCaptchaPreview, ref originalSize);
        }

        private void listBoxInputImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sIm = listBoxInputImages.SelectedIndex;

            if (sIm >= 0)
            {
                String im = (String)inputFiles[sIm];

                if (im.Length > 0)
                {
                    try
                    {
                        this.pictureBoxCaptchaPreview.Load(im);
                    }
                    catch { }
                }
            }
        }

        private void linkLabelOpenRiedWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String target = linkLabelOpenRiedWebsite.Text;
            if (null != target && target.StartsWith("http://"))
            {
                Process.Start(target);
            }

        }

        private void buttonTrainZoom_Click(object sender, EventArgs e)
        {
            HandleZoom(ref zoomModeTrain, this.pictureBoxTrainPreview, ref originalSizeTrain);
        }

        /// <summary>
        /// Manejar el zoom de las vistas previas
        /// </summary>
        /// <param name="actualZoomMode">Modo actual de zoom</param>
        /// <param name="picturePreview">Cuadro de imagen para mostrar la imagen</param>
        /// <param name="originalPreviewSize">Tamaño original inicial del recuadro de vista previa</param>
        private void HandleZoom(ref int actualZoomMode, PictureBox picturePreview, ref Size originalPreviewSize)
        {
            actualZoomMode = (++actualZoomMode == 3) ? 0 : actualZoomMode;

            picturePreview.SizeMode = !(actualZoomMode < 1) ? PictureBoxSizeMode.StretchImage : PictureBoxSizeMode.CenterImage;
            picturePreview.Size = (actualZoomMode == 2) ? new Size(originalPreviewSize.Width * 2, originalPreviewSize.Height * 2) : originalPreviewSize;
        }

        private void buttonTrainActual_Click(object sender, EventArgs e)
        {
            PrepareForTrainFirst();
        }

        private void PrepareForTrainFirst()
        {
            PrepareForTrain(this.comboBoxTrainImages.SelectedIndex, ref captchaAnalized, pictureBoxTrainPreview);
        }

        /// <summary>
        /// Preparar el aprendizaje
        /// </summary>
        /// <param name="id">Código del captcha</param>
        /// <param name="captchaToAnalize">ArrayList que contendrá la interpretación binaria del captcha</param>
        /// <param name="previewPicture">Recuadro que mostrará la vista previa del captcha</param>
        private void PrepareForTrain(int id, ref ArrayList captchaToAnalize, PictureBox previewPicture)
        {
            String err = "";
            try
            {
                if (id >= 0 && id < inputFiles.Count)
                {
                    String shellCmdArgs = this.textBoxCommandLineArgs.Text.Trim();
                    shellCmdArgs = shellCmdArgs.Replace("%temp%", pathTemporalDump);
                    shellCmdArgs = shellCmdArgs.Replace("%image%", pathTemporalImg);

                    File.Delete(pathTemporalDump);
                    File.Copy((String)inputFiles[id], pathTemporalImg, true);

                    Process analizer = Process.Start(this.textBoxCommandline.Text.Trim(), shellCmdArgs);
                    analizer.WaitForExit();

                    previewPicture.Load(pathTemporalImg);
                    captchaToAnalize.Clear();

                    captchaToAnalize.AddRange(File.ReadAllLines(pathTemporalDump)[0].Split(';'));
                    SelectCaptchaForNext();
                }
            }
            catch (Win32Exception)
            {
                err = "No se encontró el ejecutable del analizador, configúrelo correctamente en la pestaña de Configuración.";
            }
            catch (Exception)
            {
                err = "Se produjo un error inesperado, probablemente el archivo de la imagen es incorrecto.";
            }
            finally
            {
                if (err.Length > 0)
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTrainView_Click(object sender, EventArgs e)
        {
            DisplayCaptchaData(captchaAnalized);
        }

        /// <summary>
        /// Desplegar el análisis del captcha
        /// </summary>
        /// <param name="captcha">Lista con el análisis</param>
        private void DisplayCaptchaData(ArrayList captcha)
        {
            if (captcha.Count > 0)
            {
                FormViewer v = new FormViewer(captcha);
                v.ShowDialog();
                v.Dispose();
            }
            else
            {
                MessageBox.Show("No hay ningún análisis para mostrar.", "No hay datos para mostrar",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonTrainSkip_Click(object sender, EventArgs e)
        {
            PrepareForTrainNext();
        }

        private void PrepareForTrainNext()
        {
            if (this.comboBoxTrainImages.SelectedIndex < this.comboBoxTrainImages.Items.Count - 1)
            {
                this.comboBoxTrainImages.SelectedIndex++;
                PrepareForTrain(this.comboBoxTrainImages.SelectedIndex, ref captchaAnalized, pictureBoxTrainPreview);
            }
        }

        private void buttonTrainSave_Click(object sender, EventArgs e)
        {
            TrainNetworkWithKnowedText();
            SelectCaptchaForNext();
        }

        private void SelectCaptchaForNext()
        {
            textBoxTrainKnowOutput.MaxLength = captchaAnalized.Count;
            textBoxTrainKnowOutput.SelectAll();
            textBoxTrainKnowOutput.Focus();
        }

        /// <summary>
        /// Entrena la red neurona con la salida proporcionada por el usuario
        /// </summary>
        private void TrainNetworkWithKnowedText()
        {
            String s = textBoxTrainKnowOutput.Text.Trim();

            if (s.Length > 0 && s.Length == captchaAnalized.Count)
            {
                float[] output;

                // Entrenar todos los casos
                for (int i = 0; i < s.Length; i++)
                {
                    byte[] temp = BinaryTranslator.Translator.GetBinaryArray(s.Substring(i, 1).ToCharArray()[0]);
                    output = new float[temp.Length];
                    temp.CopyTo(output, 0);

                    neuralNetwork.Learn(GetBinaryFloatArray((String)captchaAnalized[i]), output);
                }

                // ¿Guardar automáticamente la red?
                if (this.checkBoxTrainAutoSave.Checked)
                    NeuralNetworkSave();
                else
                    labelTrainNetworkStatus.Text = "Hay cambios en la red neuronal, presione Guardar";

            }
        }

        /// <summary>
        /// Retorna un arreglo con ceros o unos
        /// </summary>
        /// <param name="test">La cadena de ceros y unos</param>
        /// <returns>Arreglo de floats "binario"</returns>
        private float[] GetBinaryFloatArray(string test)
        {
            float[] input = new float[test.Length];
            for (int j = 0; j < test.Length; j++)
                input[j] = test.Substring(j, 1).CompareTo("0") == 0 ? 0 : 1;

            return input;
        }

        /// <summary>
        /// Guardar la red neuronal
        /// </summary>
        private void NeuralNetworkSave()
        {
            // try
            {
                String p = this.textBoxNetworkPathSave.Text;
                neuralNetwork.SaveToFile(p);
                String s = File.GetLastWriteTime(p).ToString("G");
                this.labelTrainNetworkStatus.Text = String.Format("La red neuronal actual se actualizó correctamente ({0}).", s);
            }
            // catch
            {
                //MessageBox.Show("No se puede guardar la red neuronal, ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTrainSaveNext_Click(object sender, EventArgs e)
        {
            TrainNetworkWithKnowedTextNext();
        }

        private void TrainNetworkWithKnowedTextNext()
        {
            TrainNetworkWithKnowedText();
            PrepareForTrainNext();
        }

        private void textBoxTrainKnowOutput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                TrainNetworkWithKnowedTextNext();
            }
        }

        private void checkBoxTrainAutoSave_CheckedChanged(object sender, EventArgs e)
        {
            this.buttonTrainManualSave.Enabled = !checkBoxTrainAutoSave.Checked;
        }

        private void buttonTrainManualSave_Click(object sender, EventArgs e)
        {
            NeuralNetworkSave();
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            QuerySelectedCaptchaValue();
        }

        /// <summary>
        /// Hacer una consulta a la red neuronal
        /// </summary>
        private void QuerySelectedCaptchaValue()
        {
            captchaAnalizedQuery.Clear();
            PrepareForTrain(this.comboBoxQueryImage.SelectedIndex,
                ref captchaAnalizedQuery, this.pictureBoxQueryPreview);

            if (captchaAnalizedQuery.Count > 0)
            {
                ArrayList output = new ArrayList();
                BinaryTranslator.Translator b = new BinaryTranslator.Translator();

                // Consultar cada carácter
                for (int i = 0; i < captchaAnalizedQuery.Count; i++)
                {
                    output.Add(BinaryTranslator.Translator.GetOriginalChar(
                        neuralNetwork.Output(GetBinaryFloatArray((String)captchaAnalizedQuery[i]))));
                }

                this.textBoxQueryOutput.Text = "";
                foreach (char z in (char[])output.ToArray(typeof(char)))
                {
                    this.textBoxQueryOutput.Text += z;
                }
            }
        }

        private void buttonReloadNetwork_Click(object sender, EventArgs e)
        {
            ReloadNeuralNetwork();
        }

        private void buttonSaveSettingsNow_Click(object sender, EventArgs e)
        {
            SaveAppSettings();
        }

        /// <summary>
        /// Guarda la configuración de la aplicación al archivo
        /// </summary>
        private void SaveAppSettings()
        {
            Settings.Default.autostartLearning = this.checkBoxAutoStartTrain.Checked;
            Settings.Default.onlyUseUppercase = this.checkBoxAlwaysUppercase.Checked;
            Settings.Default.lockedConfiguration = this.checkBoxSetupReadOnly.Checked;
            Settings.Default.automaticSave = this.checkBoxTrainAutoSave.Checked;
            Settings.Default.commandLineApp = this.textBoxCommandline.Text;
            Settings.Default.commandLineArgs = this.textBoxCommandLineArgs.Text;
            Settings.Default.pathNeuralNetwork = this.textBoxNetworkPathSave.Text;

            try
            {
                Settings.Default.Save();
            }
            catch { }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveAppSettings();
        }

        private void buttonResetSettings_Click(object sender, EventArgs e)
        {
            LoadAppSettings();
        }

        /// <summary>
        /// Carga la configuración de la aplicación desde archivo
        /// </summary>
        private void LoadAppSettings()
        {
            this.checkBoxAutoStartTrain.Checked = Settings.Default.autostartLearning;
            this.checkBoxAlwaysUppercase.Checked = Settings.Default.onlyUseUppercase;
            this.checkBoxSetupReadOnly.Checked = Settings.Default.lockedConfiguration;
            this.checkBoxTrainAutoSave.Checked = Settings.Default.automaticSave;
            this.textBoxCommandline.Text = Settings.Default.commandLineApp;
            this.textBoxCommandLineArgs.Text = Settings.Default.commandLineArgs;
            this.textBoxNetworkPathSave.Text = Settings.Default.pathNeuralNetwork;
        }

        private void buttonResetNetwork_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(this.textBoxNetworkPathSave.Text);
                ReloadNeuralNetwork();
            }
            catch { }
        }

        private void labelTrainNetworkStatus_TextChanged(object sender, EventArgs e)
        {
            labelNeuralNetworkStatusEx.Text = "Estado: " + labelTrainNetworkStatus.Text;
        }

        private void buttonSaveNetworkNow_Click(object sender, EventArgs e)
        {
            NeuralNetworkSave();
        }

        private void checkBoxSetupReadOnly_CheckedChanged(object sender, EventArgs e)
        {
            if(!checkBoxSetupReadOnly.Checked)
                labelConfigurationWarn.Visible = false;
            panelSetup.Enabled = !checkBoxSetupReadOnly.Checked;
        }

        private void checkBoxLimitedMode_CheckedChanged(object sender, EventArgs e)
        {
            GuiTrainMode(!checkBoxLimitedMode.Checked);
        }

        /// <summary>
        /// Deshabilitar o habilitar los controles avanzandos para entrenar
        /// </summary>
        /// <param name="p">Estado de los controles</param>
        private void GuiTrainMode(bool p)
        {
            comboBoxTrainImages.Enabled = p;
            buttonTrainActual.Enabled = p;
            buttonTrainSkip.Enabled = p;
            buttonTrainView.Enabled = p;
            buttonTrainSave.Enabled = p;
        }

        private void buttonClearList_Click(object sender, EventArgs e)
        {
            if (inputFiles.Count > 0)
            {
                if (MessageBox.Show("¿Borrar toda la lista?", "Borrar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.inputFiles.Clear();
                    this.pictureBoxCaptchaPreview.Image = null;
                    UpdateInputImagesList();
                }
            }
        }

        private void buttonBeginTraining_Click(object sender, EventArgs e)
        {
            BeginAutoTraining();
        }

        /// <summary>
        /// Comenzar el entrenamiento automático
        /// </summary>
        private void BeginAutoTraining()
        {
            if (inputFiles.Count > 0)
            {
                comboBoxTrainImages.SelectedIndex = -1;
                checkBoxLimitedMode.Checked = true;
                tabControlMain.SelectedIndex = 1;
                Application.DoEvents();
                PrepareForTrainNext();
            }
        }

        private void buttonViewer_Click(object sender, EventArgs e)
        {
            DisplayCaptchaData(captchaAnalizedQuery);
        }

        private void buttonQueryCopy_Click(object sender, EventArgs e)
        {
            if (textBoxQueryOutput.Text.Length > 0)
                Clipboard.SetText(textBoxQueryOutput.Text);
        }

        private void checkBoxAlwaysUppercase_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAlwaysUppercase.Checked)
                this.textBoxTrainKnowOutput.CharacterCasing = CharacterCasing.Upper;
            else
                this.textBoxTrainKnowOutput.CharacterCasing = CharacterCasing.Normal;
        }
        /*
                private void buttonQueryWeight_Click(object sender, EventArgs e)
                {
                    if (matchList.Count > 0)
                    {
                        FormWeights c = new FormWeights(matchList);
                        c.ShowDialog();
                        c.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("No hay información sobre las coincidencias para mostrar.", "No hay datos para mostrar",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }*/
    }
}