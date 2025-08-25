namespace NoteX
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapılştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümünüSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.txtText = new System.Windows.Forms.RichTextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 13F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.görünümToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.fileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.saveAsFileToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.newFileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.newFileToolStripMenuItem.Text = "New (Ctrl + N)";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.openFileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.openFileToolStripMenuItem.Text = "Open (Ctrl + O)";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.saveFileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.saveFileToolStripMenuItem.Text = "Save (Ctrl + S)";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // saveAsFileToolStripMenuItem
            // 
            this.saveAsFileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.saveAsFileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveAsFileToolStripMenuItem.Name = "saveAsFileToolStripMenuItem";
            this.saveAsFileToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.saveAsFileToolStripMenuItem.Text = "Save As (Ctrl + Shift + S)";
            this.saveAsFileToolStripMenuItem.Click += new System.EventHandler(this.saveAsFileToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.çıkışToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.çıkışToolStripMenuItem.Text = "Exit (Ctrl + Q)";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.editToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapılştırToolStripMenuItem,
            this.silToolStripMenuItem,
            this.tümünüSeçToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(53, 25);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.fontToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.fontToolStripMenuItem.Text = "Font (Ctrl + F)";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.kesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.kesToolStripMenuItem.Text = "Cut (Ctrl + X)";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click);
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.kopyalaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.kopyalaToolStripMenuItem.Text = "Copy (Ctrl + C)";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);
            // 
            // yapılştırToolStripMenuItem
            // 
            this.yapılştırToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.yapılştırToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.yapılştırToolStripMenuItem.Name = "yapılştırToolStripMenuItem";
            this.yapılştırToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.yapılştırToolStripMenuItem.Text = "Paste (Ctrl + V)";
            this.yapılştırToolStripMenuItem.Click += new System.EventHandler(this.yapılştırToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.silToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.silToolStripMenuItem.Text = "Delete (Del)";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // tümünüSeçToolStripMenuItem
            // 
            this.tümünüSeçToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tümünüSeçToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tümünüSeçToolStripMenuItem.Name = "tümünüSeçToolStripMenuItem";
            this.tümünüSeçToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.tümünüSeçToolStripMenuItem.Text = "Select All (Ctrl + A)";
            this.tümünüSeçToolStripMenuItem.Click += new System.EventHandler(this.tümünüSeçToolStripMenuItem_Click);
            // 
            // görünümToolStripMenuItem
            // 
            this.görünümToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.görünümToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.görünümToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temaToolStripMenuItem});
            this.görünümToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            this.görünümToolStripMenuItem.Size = new System.Drawing.Size(118, 25);
            this.görünümToolStripMenuItem.Text = "Appearance";
            // 
            // temaToolStripMenuItem
            // 
            this.temaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.temaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkThemeToolStripMenuItem,
            this.lightThemeToolStripMenuItem});
            this.temaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.temaToolStripMenuItem.Name = "temaToolStripMenuItem";
            this.temaToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.temaToolStripMenuItem.Text = "Theme";
            // 
            // darkThemeToolStripMenuItem
            // 
            this.darkThemeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.darkThemeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.darkThemeToolStripMenuItem.Name = "darkThemeToolStripMenuItem";
            this.darkThemeToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.darkThemeToolStripMenuItem.Text = "Dark Theme";
            this.darkThemeToolStripMenuItem.Click += new System.EventHandler(this.darkThemeToolStripMenuItem_Click);
            // 
            // lightThemeToolStripMenuItem
            // 
            this.lightThemeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lightThemeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.lightThemeToolStripMenuItem.Name = "lightThemeToolStripMenuItem";
            this.lightThemeToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.lightThemeToolStripMenuItem.Text = "Light Theme";
            this.lightThemeToolStripMenuItem.Click += new System.EventHandler(this.lightThemeToolStripMenuItem_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlInfo.Location = new System.Drawing.Point(12, 412);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(775, 30);
            this.pnlInfo.TabIndex = 2;
            // 
            // txtText
            // 
            this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtText.ForeColor = System.Drawing.Color.White;
            this.txtText.Location = new System.Drawing.Point(12, 32);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(775, 370);
            this.txtText.TabIndex = 3;
            this.txtText.Text = "";
            this.txtText.TextChanged += new System.EventHandler(this.txtText_TextChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(529, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(178, 25);
            this.txtSearch.TabIndex = 4;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(713, 4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteX";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapılştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümünüSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görünümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.RichTextBox txtText;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnFind;
    }
}

