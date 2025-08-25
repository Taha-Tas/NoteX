using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NoteX
{
    public partial class Form1 : Form
    {
        bool saved = false;
        bool Isexit = false;

        string saveLocation = "";

        DialogResult result;

        Label lblTextInfo;
        public Form1()
        {
            InitializeComponent();
        }


        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeFont();
        }
        public void changeFont()
        {
            FontDialog changeFont = new FontDialog();
            if (changeFont.ShowDialog() == DialogResult.OK)
            {
                txtText.Font = changeFont.Font;
            }
        }
        private void TextWord()
        {
            string text = txtText.Text;
            int lineCount = txtText.Lines.Length;
            int charCount = text.Count(c => !char.IsWhiteSpace(c));
            int wordCount = text.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;

            lblTextInfo.Text=($"Line(s): {lineCount} | Letter(s): {charCount} | Word(s): {wordCount}");   
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {
            saved = false;
            TextWord();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTextInfo = new Label();
            lblTextInfo.Text = ("Line(s): 0 | Letter(s): 0 | Word(s): 0");
            lblTextInfo.ForeColor = Color.White;
            lblTextInfo.Font = new Font("Arial", 13);
            lblTextInfo.AutoSize = true;
            pnlInfo.Controls.Add(lblTextInfo);
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFile();
        }
        public void newFile()
        {
            if (saved)
            {
                txtText.Clear();
                saved = false;
                saveLocation = "";
            }
            else
            {
                result = MessageBox.Show("File was not saved! Do you want to save it?","Save File?",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
                if (result==DialogResult.Yes)saveFile();
                else if (result == DialogResult.No)
                {
                    txtText.Clear();
                    saved = false;
                    saveLocation = "";
                }
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }
        public void saveFile()
        {
            if (saveLocation == "")
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    saveFileDialog.Title = "Save File";
                    saveFileDialog.DefaultExt = "txt";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.File.WriteAllText(saveFileDialog.FileName, txtText.Text);
                        saved = true;
                        saveLocation = saveFileDialog.FileName;
                    }
                }
            }
            else
            {
                System.IO.File.WriteAllText(saveLocation, txtText.Text);
                saved = true;
            }
        }

        private void saveAsFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveLocation = "";
            saveFile();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit();
        }
        public void exit()
        {
            if (txtText.Text.Length>0)
            if (saved)
            {
                Isexit = true;
                Application.Exit();
            }
            else
            {
                result = MessageBox.Show("File was not saved! Do you want to save it?", "Save File?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) saveFile();
                else if (result == DialogResult.No)
                {
                    Isexit = true;
                    Application.Exit();
                    
                }
            }
        }
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }
        public void openFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Open File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileContent = System.IO.File.ReadAllText(openFileDialog.FileName);
                    txtText.Text = fileContent;
                    saved = true;
                    saveLocation = openFileDialog.FileName;
                }
            }
        }
        private void CopyText()
        {
            if (!string.IsNullOrEmpty(txtText.SelectedText))
            {
                Clipboard.SetText(txtText.SelectedText);
            }
        }

        // Kes
        private void CutText()
        {
            if (!string.IsNullOrEmpty(txtText.SelectedText))
            {
                Clipboard.SetText(txtText.SelectedText);
                txtText.SelectedText = ""; // seçilen kısmı sil
            }
        }

        // Yapıştır
        private void PasteText()
        {
            if (Clipboard.ContainsText())
            {
                int selectionIndex = txtText.SelectionStart;
                txtText.Text = txtText.Text.Insert(selectionIndex, Clipboard.GetText());
                txtText.SelectionStart = selectionIndex + Clipboard.GetText().Length;
            }
        }
        private void DeleteText()
        {
            if (!string.IsNullOrEmpty(txtText.SelectedText))
            {
                txtText.SelectedText = ""; // seçili metni siler
            }
        }

        // Select All (tüm metni seç)
        private void SelectAllText()
        {
            txtText.SelectAll(); // tüm metni seçer
        }
        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CutText();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyText();
        }

        private void yapılştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteText();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteText();
        }

        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAllText();
        }
        public void lightTheme()
        {
            this.BackColor = Color.White;
            pnlInfo.BackColor = Color.Gray;
            txtText.BackColor = Color.White;
            menuStrip1.BackColor = Color.Gray;

            pnlInfo.ForeColor = Color.Black;
            txtText.ForeColor = Color.Black;
            menuStrip1.ForeColor = Color.Black;

            newFileToolStripMenuItem.BackColor = Color.FromArgb(200,200,200);
            openFileToolStripMenuItem.BackColor = Color.FromArgb(200, 200, 200);
            saveAsFileToolStripMenuItem.BackColor = Color.FromArgb(200, 200, 200);
            saveFileToolStripMenuItem.BackColor = Color.FromArgb(200, 200, 200);
            editToolStripMenuItem.BackColor = Color.FromArgb(200, 200, 200);
            fileToolStripMenuItem.BackColor = Color.FromArgb(200, 200, 200);
            temaToolStripMenuItem.BackColor = Color.FromArgb(200, 200, 200);
            çıkışToolStripMenuItem.BackColor = Color.FromArgb(200, 200, 200);
            görünümToolStripMenuItem.BackColor = Color.FromArgb(200, 200, 200);

            fontToolStripMenuItem.BackColor = Color.FromArgb(200, 200, 200);
            kesToolStripMenuItem.BackColor = Color.FromArgb(200, 200, 200);
            yapılştırToolStripMenuItem.BackColor = Color.FromArgb(200, 200, 200);
            btnFind.BackColor = Color.FromArgb(200, 200, 200);
            kopyalaToolStripMenuItem.BackColor = Color.FromArgb(200, 200, 200);
            tümünüSeçToolStripMenuItem.BackColor = Color.FromArgb(200, 200, 200);
            txtSearch.BackColor = Color.FromArgb(200, 200, 200);
            silToolStripMenuItem.BackColor = Color.FromArgb(200, 200, 200);
            
            lightThemeToolStripMenuItem.BackColor = Color.FromArgb(200, 200, 200);
            darkThemeToolStripMenuItem.BackColor = Color.FromArgb(200, 200, 200);

            newFileToolStripMenuItem.ForeColor = Color.Black;
            openFileToolStripMenuItem.ForeColor = Color.Black;
            saveAsFileToolStripMenuItem.ForeColor = Color.Black;
            saveFileToolStripMenuItem.ForeColor = Color.Black;
            editToolStripMenuItem.ForeColor = Color.Black;
            fileToolStripMenuItem.ForeColor = Color.Black;
            temaToolStripMenuItem.ForeColor = Color.Black;
            çıkışToolStripMenuItem.ForeColor = Color.Black;
            görünümToolStripMenuItem.ForeColor = Color.Black;

            fontToolStripMenuItem.ForeColor = Color.Black;
            kesToolStripMenuItem.ForeColor = Color.Black;
            yapılştırToolStripMenuItem.ForeColor = Color.Black;
            btnFind.ForeColor = Color.Black;
            kopyalaToolStripMenuItem.ForeColor = Color.Black;
            tümünüSeçToolStripMenuItem.ForeColor = Color.Black;
            txtSearch.ForeColor = Color.Black;
            silToolStripMenuItem.ForeColor = Color.Black;

            lightThemeToolStripMenuItem.ForeColor = Color.Black;
            darkThemeToolStripMenuItem.ForeColor = Color.Black;

            lblTextInfo.ForeColor = Color.Black;
        }
        public void darkTheme()
          
        {
            this.BackColor = Color.FromArgb(50,50,50);
            pnlInfo.BackColor = Color.FromArgb(40,40,40);
            txtText.BackColor = Color.FromArgb(50, 50, 50); ;
            menuStrip1.BackColor = Color.FromArgb(40, 40, 40);

            pnlInfo.ForeColor = Color.White;
            txtText.ForeColor = Color.White;
            menuStrip1.ForeColor = Color.White;

            newFileToolStripMenuItem.BackColor = Color.FromArgb(40, 40, 40);
            openFileToolStripMenuItem.BackColor = Color.FromArgb(40, 40, 40);
            saveAsFileToolStripMenuItem.BackColor = Color.FromArgb(40, 40, 40);
            saveFileToolStripMenuItem.BackColor = Color.FromArgb(40, 40, 40);
            editToolStripMenuItem.BackColor = Color.FromArgb(40, 40, 40);
            fileToolStripMenuItem.BackColor = Color.FromArgb(40, 40, 40);
            temaToolStripMenuItem.BackColor = Color.FromArgb(40, 40, 40);
            çıkışToolStripMenuItem.BackColor = Color.FromArgb(40, 40, 40);
            görünümToolStripMenuItem.BackColor = Color.FromArgb(40, 40, 40);

            fontToolStripMenuItem.BackColor = Color.FromArgb(40, 40, 40);
            kesToolStripMenuItem.BackColor = Color.FromArgb(40, 40, 40);
            yapılştırToolStripMenuItem.BackColor = Color.FromArgb(40, 40, 40);
            btnFind.BackColor = Color.FromArgb(40, 40, 40);
            kopyalaToolStripMenuItem.BackColor = Color.FromArgb(40, 40, 40);
            tümünüSeçToolStripMenuItem.BackColor = Color.FromArgb(40, 40, 40);
            txtSearch.BackColor = Color.FromArgb(40, 40, 40);
            silToolStripMenuItem.BackColor = Color.FromArgb(40, 40, 40);

            lightThemeToolStripMenuItem.BackColor = Color.FromArgb(40, 40, 40);
            darkThemeToolStripMenuItem.BackColor = Color.FromArgb(40, 40, 40);

            newFileToolStripMenuItem.ForeColor = Color.White;
            openFileToolStripMenuItem.ForeColor = Color.White;
            saveAsFileToolStripMenuItem.ForeColor = Color.White;
            saveFileToolStripMenuItem.ForeColor = Color.White;
            editToolStripMenuItem.ForeColor = Color.White;
            fileToolStripMenuItem.ForeColor = Color.White;
            temaToolStripMenuItem.ForeColor = Color.White;
            çıkışToolStripMenuItem.ForeColor = Color.White;
            görünümToolStripMenuItem.ForeColor = Color.White;

            fontToolStripMenuItem.ForeColor = Color.White;
            kesToolStripMenuItem.ForeColor = Color.White;
            yapılştırToolStripMenuItem.ForeColor = Color.White;
            btnFind.ForeColor = Color.White;
            kopyalaToolStripMenuItem.ForeColor = Color.White;
            tümünüSeçToolStripMenuItem.ForeColor = Color.White;
            txtSearch.ForeColor = Color.White;
            silToolStripMenuItem.ForeColor = Color.White;

            lightThemeToolStripMenuItem.ForeColor = Color.White;
            darkThemeToolStripMenuItem.ForeColor = Color.White;

            lblTextInfo.ForeColor = Color.White;
        }

        private void darkThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            darkTheme();
        }

        private void lightThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lightTheme();
        }
        private void FindText(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
                return;

            int index = txtText.Text.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase);
            if (index >= 0)
            {
                txtText.Select(index, searchTerm.Length);
                txtText.Focus(); // textbox'a odaklan
            }
            else
            {
                MessageBox.Show("The searched text was not found!","Not Found!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text; // kullanıcı arama kutusuna yazdı
            FindText(searchTerm);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Isexit == false) exit();
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                saveFile();
            }
            else if (e.Control && e.Shift && e.KeyCode == Keys.S)
            {
                saveLocation = "";
                saveFile();
            }
            if (e.Control && e.KeyCode == Keys.Q)
            {
                exit();
            }
            if (e.Control && e.KeyCode == Keys.O)
            {
                openFile();
            }

            if (e.Control && e.KeyCode == Keys.F)
            {
                changeFont();
            }
            if (e.Control && e.KeyCode == Keys.X)
            {
                CutText();
            }
            if (e.Control && e.KeyCode == Keys.C)
            {
                CopyText();
            }
            if (e.Control && e.KeyCode == Keys.V)
            {
                PasteText();
            }
            if (e.Control && e.KeyCode == Keys.Delete)
            {
                DeleteText();
            }
            if (e.Control && e.KeyCode == Keys.A)
            {
                SelectAllText();
            }
        }

    }
}
