using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersianNotepad
{
    public partial class Form1 : Form
    {
        bool _documentIsChanged = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void SaveDocument(string fileName)
        {
            using (StreamWriter streamWriter = new StreamWriter(fileName))
            {
                streamWriter.Write(richText.Text);
            }
        }

        private void btnNewDocument_Click(object sender, EventArgs e)
        {
            if (richText.Text == "")
                _documentIsChanged = false;

            if (_documentIsChanged)
            {
                DialogResult dialogResult = RtlMessageBox.Show("آیا میخواهید تغییرات ایجاد شده را ذخیره نمایید؟",
                    "ذخیره سند", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (dialogResult == DialogResult.Yes)
                {
                    var dialogResultSave = saveFileDialog.ShowDialog();

                    if (dialogResultSave == DialogResult.OK)
                    {
                        SaveDocument(saveFileDialog.FileName);
                    }
                    _documentIsChanged = false;
                    richText.Text = "";
                }
                else if (dialogResult == DialogResult.No)
                {
                    _documentIsChanged = false;
                    richText.Text = "";
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    if (richText.Text == "")
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
    }
}
