using System;
using System.IO;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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
            richText.Font = fontDialog.Font;
        }

        private void SaveDocument()
        {
            if (string.IsNullOrEmpty(_pathSaved))
            {
                var dialogResultSave = saveFileDialog.ShowDialog();

                if (dialogResultSave == DialogResult.OK)
                {
                    WriteDocument(saveFileDialog.FileName);
                    _pathSaved = saveFileDialog.FileName;
                    _documentIsChanged = false;
                }
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

        private void mnuBtnViewFonts_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            richText.Font = fontDialog.Font;
        }

        private void mnuBtnExitDocument_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_documentIsChanged)
            {
                DialogResult dialogResult = RtlMessageBox.Show("آیا میخواهید تغییرات ایجاد شده را ذخیره نمایید؟",
                    "ذخیره سند", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (dialogResult == DialogResult.Yes)
                {
                    SaveDocument();
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void mnuBtnViewStatusBar_Click(object sender, EventArgs e)
        {
            this.panel3.AutoSize = true;
            this.panel4.AutoSize = true;
            statusBar.Visible = !statusBar.Visible;
            mnuBtnViewStatusBar.Checked = !mnuBtnViewStatusBar.Checked;
        }

        private void mnuBtnViewToolBox_Click(object sender, EventArgs e)
        {
            this.panel2.AutoSize = true;
            toolBox.Visible = !toolBox.Visible;
            mnuBtnViewToolBox.Checked = !mnuBtnViewToolBox.Checked;
        }

        private void mnuBtnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richText.SelectedText))
            {
                Clipboard.SetText(richText.SelectedText);
            }
            else if (!string.IsNullOrEmpty(richText.Text))
            {
                Clipboard.SetText(richText.Text);
            }
        }

        private void mnuBtnPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                if (!string.IsNullOrEmpty(richText.SelectedText))
                {
                    richText.SelectedText = Clipboard.GetText(TextDataFormat.UnicodeText); ;
                }
                else
                {
                    richText.Text += Clipboard.GetText(TextDataFormat.UnicodeText);
                }

                
            }
        }

        private void mnuBtnClear_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richText.SelectedText))
            {
                richText.SelectedText = "";
            }
            else
            {
                richText.Text = "";
            }
            
        }

        private void mnuBtnCut_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richText.SelectedText))
            {
                Clipboard.SetText(richText.SelectedText);
                richText.SelectedText = "";
            }
            else if(!string.IsNullOrEmpty(richText.Text))
            {
                Clipboard.SetText(richText.Text);
                richText.Text = "";
            }
        }

        private void mnuBtnSelectAll_Click(object sender, EventArgs e)
        {
            richText.SelectAll();
        }

        private void mnuBtnInsertDate_Click(object sender, EventArgs e)
        {
            PersianCalendar persianCalendar = new PersianCalendar();

            if (!string.IsNullOrEmpty(richText.SelectedText))
            {
                richText.SelectedText =
                    $"{persianCalendar.GetYear(DateTime.Now)}/{persianCalendar.GetMonth(DateTime.Now)}/{persianCalendar.GetDayOfMonth(DateTime.Now)}"; ;
            }
            else
            {
                richText.Text +=
                    $@"{persianCalendar.GetYear(DateTime.Now)}/{persianCalendar.GetMonth(DateTime.Now)}/{persianCalendar.GetDayOfMonth(DateTime.Now)}";
            }
        }

        private void mnuBtnPrintDocument_Click(object sender, EventArgs e)
        {
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strText = richText.Text;
            int chars;
            int lines;

            SolidBrush b = new SolidBrush(Color.Black);
            StringFormat strformat = new StringFormat();
            strformat.Trimming = StringTrimming.Word;
            RectangleF myRectangleF = new RectangleF(e.MarginBounds.Left,
                e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height);
            SizeF mySizeF = new SizeF(e.MarginBounds.Width, e.MarginBounds.Height - fontDialog.Font.GetHeight(e.Graphics));
            e.Graphics.MeasureString(strText, fontDialog.Font, mySizeF, strformat, out chars, out lines);
            string printstr = strText.Substring(0, chars);
            e.Graphics.DrawString(printstr, fontDialog.Font, b, myRectangleF, strformat);
            if (strText.Length > chars)
            {
                strText = strText.Substring(chars);
                e.HasMorePages = true;
            }
            else
                e.HasMorePages = false;

        }

        private void mnuBtnSearch_Click(object sender, EventArgs e)
        {
            frmSearch frmSearch = new frmSearch(this);
            frmSearch.ShowDialog();
        }

        private void mnuBtnReplace_Click(object sender, EventArgs e)
        {
            frmSearch frmSearch = new frmSearch(this);
            frmSearch.ShowDialog();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var pc = new PersianCalendar();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = $"{pc.GetYear(DateTime.Now)}/{pc.GetMonth(DateTime.Now)}/{pc.GetDayOfMonth(DateTime.Now)}";

        }

        private void mnuBtnAboutUs_Click(object sender, EventArgs e)
        {
            frmAboutUs frmAboutUs = new frmAboutUs();
            frmAboutUs.ShowDialog();
        }
    }
}
