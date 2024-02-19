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
    public partial class frmSearch : Form
    {
        private readonly Form1 _form1;
        private List<SearchResult> _searchResults = new List<SearchResult>();
        private int _indexSelectedSearchResult = -1;

        public frmSearch(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            string searchText = txtSearch.Text;
            int startIndex = 0;

            _form1.richText.SelectionBackColor = _form1.richText.BackColor;

            var searchOption = RichTextBoxFinds.None;
            if (rdbExactly.Checked)
            {
                searchOption = RichTextBoxFinds.WholeWord;
            }

            if (txtSearch.Text != _searchResults.FirstOrDefault()?.SearchText)
            {
                _searchResults.Clear();
            }

            if (_searchResults.Count==0)
            {
                _searchResults.Clear();
                while (startIndex < _form1.richText.TextLength)
                {
                    int wordIndex = _form1.richText.Find(searchText, startIndex, searchOption);

                    if (wordIndex != -1)
                    {
                        _searchResults.Add(new SearchResult
                        {
                            SelectionStart = wordIndex,
                            SelectionLength = searchText.Length,
                            SearchText = searchText
                        });
                    }
                    else
                    {
                        break;
                    }

                    startIndex = wordIndex + searchText.Length;
                }
            }
            
            if (_searchResults.Any())
            {
                ShowResultWithSelected(rdbDown.Checked);
            }
        }

        private void ShowResultWithSelected(bool isDown)
        {
            try
            {
                if (isDown)
                {
                    _indexSelectedSearchResult++;
                }
                else
                {
                    _indexSelectedSearchResult--;
                }

                if (_searchResults.Count() <= _indexSelectedSearchResult)
                {
                    _indexSelectedSearchResult = 0;
                }

                if (_indexSelectedSearchResult < 0)
                {
                    _indexSelectedSearchResult = _searchResults.Count()-1;
                }


                var selected = _searchResults[_indexSelectedSearchResult];
                _form1.richText.SelectionStart = selected.SelectionStart;
                _form1.richText.SelectionLength = selected.SelectionLength;
                _form1.richText.SelectionBackColor = Color.PowderBlue;

            }
            catch (Exception)
            {
                if (isDown)
                {
                    _indexSelectedSearchResult--;
                }
                else
                {
                    _indexSelectedSearchResult++;
                }

                if (_indexSelectedSearchResult >= 0 && _indexSelectedSearchResult < _searchResults.Count())
                {
                    var selected = _searchResults[_indexSelectedSearchResult];
                    _form1.richText.SelectionStart = selected.SelectionStart;
                    _form1.richText.SelectionLength = selected.SelectionLength;
                    _form1.richText.SelectionBackColor = Color.PowderBlue;
                }
            }
        }

        private void frmSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form1.richText.SelectionBackColor = _form1.richText.BackColor;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (rdbDown.Checked)
                _indexSelectedSearchResult--;
            Search();
            if (!string.IsNullOrWhiteSpace(_form1.richText.SelectedText))
            {
                _form1.richText.SelectionBackColor = _form1.richText.BackColor;
                _form1.richText.SelectedText = _form1.richText.SelectedText.Replace(_form1.richText.SelectedText,txtReplace.Text);
                _searchResults.Clear();
            }
        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            Search();
            if (!string.IsNullOrWhiteSpace(_form1.richText.SelectedText))
            {
                _form1.richText.SelectionBackColor = _form1.richText.BackColor;
                _form1.richText.Text = _form1.richText.Text.Replace(_form1.richText.SelectedText, txtReplace.Text);
                _searchResults.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
