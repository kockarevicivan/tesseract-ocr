using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.Util;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.CvEnum;

using System.Speech;
using System.Speech.Synthesis;

namespace OCRSoftware
{
    public partial class OCRPanel : Form
    {
        bool binFirstTimeInResizeEvent = true;
        int intOrigFormWidth;
        int intOrigFormHeight;
        int intOrigTableLayoutPanelWidth;
        int intOrigTableLayoutPanelHeight;

        Image<Bgr, Byte> imgImage = null;
        Image<Bgr, Byte> imgBlank = null;

        Tesseract tess;

        public OCRPanel()
        {
            InitializeComponent();

            intOrigFormWidth = this.Width;
            intOrigFormHeight = this.Height;
            intOrigTableLayoutPanelWidth = tlpTextBoxAndImageBox.Width;
            intOrigTableLayoutPanelHeight = tlpTextBoxAndImageBox.Height;

            try
            {
                tess = new Tesseract("tessdata", "eng", Tesseract.OcrEngineMode.OEM_DEFAULT);
            }
            catch (Exception ex)
            {
                this.Text = "Error instantiating Tesseract object";
                txtOCR.Text = "Error instantiating Tesseract object";
                txtFile.Enabled = false;
                btnFile.Enabled = false;
            }
        }

        SpeechSynthesizer reader = new SpeechSynthesizer();

        private void OCRPanel_Resize(object sender, EventArgs e)
        {
            if (binFirstTimeInResizeEvent == true)
            {
                binFirstTimeInResizeEvent = false;
            }
            else
            {
                tlpTextBoxAndImageBox.Width = this.Width - (intOrigFormWidth - intOrigTableLayoutPanelHeight);
                tlpTextBoxAndImageBox.Height = this.Height - (intOrigFormHeight - intOrigTableLayoutPanelHeight);
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = ofdFile.ShowDialog();

            if (dialogResult == DialogResult.OK || dialogResult == DialogResult.Yes)
            {
                txtFile.Text = ofdFile.FileName;
            }
        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {
            txtFile.SelectionStart = txtFile.Text.Length;
            if (txtFile.Text != String.Empty)
            {
                ProcessImageAndUpdateGUI();
            }
        }

        public void ProcessImageAndUpdateGUI()
        {
            try
            {
                //Image<Bgr, Byte> img1 = new Image<Bgr, Byte>(480, 320);
                imgImage = new Image<Bgr, Byte>(txtFile.Text);
            }
            catch (Exception ex)
            {
                this.Text = "Error occured while opening file.";
                return;
            }
            if (imgImage == null)
            {
                return;
            }

            this.Text = "Processing,please wait..";
            //ibImage.Image = imgBlank.ToBitmap();

            ibImage.Image = imgImage.ToBitmap();

            Application.DoEvents();

            tess.Recognize(imgImage);
            txtOCR.Text = tess.GetText();

            

            this.Text = "Done processing,choose another image if desired.";

        }

        private void speak_Click(object sender, EventArgs e)
        {
            if (txtOCR.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(txtOCR.Text);
            }
            else
            {
                MessageBox.Show("Please enter some value in the textbox.");
            }
        }

        private void pause_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                if (reader.State == SynthesizerState.Speaking)
                {
                    reader.Pause();
                }
            }
        }

        private void resume_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                if (reader.State == SynthesizerState.Paused)
                {
                    reader.Resume();
                }
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                reader.Dispose();
            }
        }
    }
}
