using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace PersianNotepad
{
    public partial class Form1 : Form
    {
        bool _documentIsChanged = false;
        private string _pathSaved = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void SaveDocument()
        {
            if (string.IsNullOrEmpty(_pathSaved))
            {
                var dialogResultSave = saveFileDialog.ShowDialog();

                if (dialogResultSave == DialogResult.OK)
                {
                    WriteDocument(saveFileDialog.FileName);
                    _documentIsChanged = false;
                }
                _pathSaved = saveFileDialog.FileName;
            }
            else
            {
                WriteDocument(_pathSaved);
                _documentIsChanged = false;
            }
        }

        private void SaveAsDocument()
        {
            var dialogResultSave = saveFileDialog.ShowDialog();

            if (dialogResultSave == DialogResult.OK)
            {
                WriteDocument(saveFileDialog.FileName);
                _documentIsChanged = false;
            }
            _pathSaved = saveFileDialog.FileName;
        }

        private void ReadDocument(string fileName)
        {
            string txtStreamReader = "";
            using (StreamReader streamReader = new StreamReader(fileName))
            {
                txtStreamReader = streamReader.ReadToEnd();
            }

            richText.Text = txtStreamReader;
        }

        private void WriteDocument(string fileName)
        {
            using (StreamWriter streamWriter = new StreamWriter(fileName))
            {
                streamWriter.Write(richText.Text);
            }
        }

        private void mnuBtnNewDocument_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richText.Text))
                _documentIsChanged = false;

            if (_documentIsChanged)
            {
                DialogResult dialogResult = RtlMessageBox.Show("آیا میخواهید تغییرات ایجاد شده را ذخیره نمایید؟",
                    "ذخیره سند", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (dialogResult == DialogResult.Yes)
                {
                    SaveDocument();
                    richText.Text = "";
                }
                else if (dialogResult == DialogResult.No)
                {
                    _documentIsChanged = false;
                    richText.Text = "";
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    if (string.IsNullOrEmpty(richText.Text))
                        _documentIsChanged = false;
                }
            }
            else
            {
                richText.Text = "";
                _documentIsChanged = false;
            }

        }

        private void richText_TextChanged(object sender, EventArgs e)
        {
            _documentIsChanged = true;
        }

        private void mnuBtnOpenDocument_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =  openFileDialog.ShowDialog();
            _pathSaved = openFileDialog.FileName;

            if (dialogResult == DialogResult.OK)
            {
                ReadDocument(openFileDialog.FileName);
                _documentIsChanged = false;
            }
        }

        private void mnuBtnNewWindow_Click(object sender, EventArgs e)
        {
            Process.Start(Process.GetCurrentProcess().ProcessName);
        }

        private void mnuBtnSaveDocument_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        private void mnuBtnSaveAsDocument_Click(object sender, EventArgs e)
        {
            SaveAsDocument();
        }
    }
}
