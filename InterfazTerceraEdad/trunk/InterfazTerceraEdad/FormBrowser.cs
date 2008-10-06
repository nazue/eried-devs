using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InterfazTerceraEdad
{
    public partial class FormBrowser : Form
    {
        private const int SEARCH_TEXT_LENGTH = 40;
        public FormBrowser()
        {
            InitializeComponent();
        }

        private void webBrowserMain_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void textBoxURL_TextChanged(object sender, EventArgs e)
        {
            this.timerUrlFinder.Stop();
            this.timerUrlFinder.Start();
        }

        private void timerUrlFinder_Tick(object sender, EventArgs e)
        {
            String query = this.textBoxURL.Text.Trim();

            if (webBrowserMain.ReadyState == WebBrowserReadyState.Loading)
                webBrowserMain.Stop();

            if (query.Length > 0)
            {
                if (query.LastIndexOf("://") == -1)
                {
                    this.linkLabelSearch.Visible = true;

                    this.linkLabelSearch.Text = "También puede que desee buscar \"" + query.Substring(0, Math.Min(query.Length, SEARCH_TEXT_LENGTH));
                    if (query.Length > SEARCH_TEXT_LENGTH)
                        this.linkLabelSearch.Text += "...";
                    this.linkLabelSearch.Text += "\" en internet";
                }


                this.webBrowserMain.Navigate("http://www.google.cl/search?hl=es&q=" + query + "&btnI=Voy+a+tener+suerte");
            }
            else
            {
                this.linkLabelSearch.Visible = false;
            }

            this.timerUrlFinder.Stop();
        }

        private void textBoxReference_TextChanged(object sender, EventArgs e)
        {
            this.timerReference.Stop();
            this.timerReference.Start();
        }

        private void timerReference_Tick(object sender, EventArgs e)
        {
            String query = this.textBoxReference.Text.Trim();

            if(webBrowserMain.ReadyState == WebBrowserReadyState.Loading)
                webBrowserMain.Stop();

            if (query.Length > 0)
            {
                int item = (this.listBoxReferenceMode.GetItemRectangle(0).Y)/-(this.listBoxReferenceMode.GetItemRectangle(0).Height);
                switch (item)
                {
                    case 0: // Wiki esp
                        this.webBrowserMain.Navigate("http://es.wikipedia.org/wiki/" + query);
                        break;
                    case 1: // Wiki eng
                        this.webBrowserMain.Navigate("http://en.wikipedia.org/wiki/" + query);
                        break;
                    case 2: // Rae
                        this.webBrowserMain.Navigate("http://buscon.rae.es/draeI/SrvltGUIBusUsual?LEMA=" + query+ "&origen=RAE");
                        break;
                    case 3: // Sinónimos
                        this.webBrowserMain.Navigate("http://www.sinonimos.org/buscar.php?termino=" + query);
                        break;
                    case 4: // Inglés
                        this.webBrowserMain.Navigate("http://translate.google.com/translate_t?text=" + query + "&langpair=es|en");
                        break;
                    case 5: // Español
                        this.webBrowserMain.Navigate("http://translate.google.com/translate_t?text=" + query + "&langpair=en|es");
                        break;
                }
            }

            this.timerReference.Stop();
        }

        private void listBoxReferenceMode_Scroll(object Sender, BetterListBox.BetterListBoxScrollArgs e)
        {
            this.timerReference.Stop();
            this.timerReference.Start();
        }

        private void tabControlBrowser_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.tabControlBrowser.SelectedIndex+1)
            {
                case 0:
                    // Nada
                    break;
                case 1:
                    this.timerUrlFinder.Start();
                    this.textBoxURL.Focus();
                    break;
                case 2:
                    this.timerSearch.Start();
                    this.textBoxSearch.Focus();
                    break;
                case 3:
                    this.timerReference.Start();
                    this.textBoxReference.Focus();
                    break;
            }
        }

        private void timerSearch_Tick(object sender, EventArgs e)
        {
            String query = this.textBoxSearch.Text.Trim();

            if (webBrowserMain.ReadyState == WebBrowserReadyState.Loading)
                webBrowserMain.Stop();

            if (query.Length > 0)
            {
                int item = (this.listBoxSearchEngines.GetItemRectangle(0).Y) / -(this.listBoxSearchEngines.GetItemRectangle(0).Height);
                switch (item)
                {
                    case 0: // Google
                        this.webBrowserMain.Navigate("http://www.google.com/search?q=" + query);
                        break;
                    case 1: // Msn
                        this.webBrowserMain.Navigate("http://search.live.com/results.aspx?q=" + query);
                        break;
                    case 2: // Altavista
                        this.webBrowserMain.Navigate("http://es.altavista.com/web/results?q=" + query);
                        break;
                    case 3: // Youtube
                        this.webBrowserMain.Navigate("http://www.youtube.com/results?search_query=" + query);
                        break;
                }
            }

            this.timerSearch.Stop();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            this.timerSearch.Stop();
            this.timerSearch.Start();
        }

        private void listBoxSearchEngines_Scroll(object Sender, BetterListBox.BetterListBoxScrollArgs e)
        {
            this.timerSearch.Stop();
            this.timerSearch.Start();
        }

        private void FormBrowser_Load(object sender, EventArgs e)
        {
            this.tabControlBrowser.SelectedIndex = 1;
            this.tabControlBrowser.SelectedIndex = 0;
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void webBrowserMain_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            panelBrowserBorder.Visible = true;
            panelStartup.Visible = false;
        }

        private void linkLabelSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.textBoxSearch.Text = this.textBoxURL.Text;
            this.tabControlBrowser.SelectedIndex = 1;
        }



    }
}