using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SautinSoft.Document;

namespace FileConverter
{
    public partial class Form1 : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        string FormatFile = "", ConvertFormatFile = "", fileToConvert = "", convertFile = "";
        string[] fileFormats = { ".txt", ".docx", ".doc", ".pdf", ".html", ".odt" };
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "(*.txt)|*.txt|(*.doc)|*.doc|(*.docx)|*.docx|(*.pdf)|*.pdf|(*.html)|*.html|(*.odt)|*.odt";
            saveFileDialog1.Filter = "(*.txt)|*.txt|(*.doc)|*.doc|(*.docx)|*.docx|(*.pdf)|*.pdf|(*.html)|*.html|(*.odt)|*.odt";
        }

        #region Design
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void Button3_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(FilePath.Text) | !string.IsNullOrWhiteSpace(ConvertFilePath.Text))
            {
                if (!ConvertFile(fileToConvert, convertFile))
                {
                    MessageBox.Show("Something go wrong...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Convert finished well!", "Finished", MessageBoxButtons.OK, MessageBoxIcon.None);
                    FilePath.Text = ConvertFilePath.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Empty text box!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void browseFiles_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FilePath.Text = fileToConvert = openFileDialog1.FileName;
            }
            for(int i = 0; i < fileFormats.Length; i++)
            {
                if (fileToConvert.IndexOf(fileFormats[i].ToString()) != -1)
                {
                    FormatFile = fileFormats[i];
                    break;
                }
            }
        }
        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ConvertFilePath.Text = convertFile = saveFileDialog1.FileName;
            }
            for (int i = 0; i < fileFormats.Length; i++)
            {
                if (convertFile.IndexOf(fileFormats[i].ToString()) != -1)
                {
                    ConvertFormatFile = fileFormats[i];
                    break;
                }
            }
        }
        public bool ConvertFile(string sourceFile, string convertFile)
        {
            try
            {
                DocumentCore documentCore = DocumentCore.Load(sourceFile);
                documentCore.Save(convertFile);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}