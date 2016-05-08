namespace EasyPhotoshop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wstawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.znakWodnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bezEfektówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czarnoBiałyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negatywToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.wstawToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtrToolStripMenuItem});
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            // 
            // wstawToolStripMenuItem
            // 
            this.wstawToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.znakWodnyToolStripMenuItem});
            this.wstawToolStripMenuItem.Name = "wstawToolStripMenuItem";
            this.wstawToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.wstawToolStripMenuItem.Text = "Wstaw";
            // 
            // znakWodnyToolStripMenuItem
            // 
            this.znakWodnyToolStripMenuItem.Name = "znakWodnyToolStripMenuItem";
            this.znakWodnyToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.znakWodnyToolStripMenuItem.Text = "Znak wodny";
            this.znakWodnyToolStripMenuItem.Click += new System.EventHandler(this.znakWodnyToolStripMenuItem_Click);
            // 
            // filtrToolStripMenuItem
            // 
            this.filtrToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bezEfektówToolStripMenuItem,
            this.czarnoBiałyToolStripMenuItem,
            this.sepiaToolStripMenuItem,
            this.negatywToolStripMenuItem});
            this.filtrToolStripMenuItem.Name = "filtrToolStripMenuItem";
            this.filtrToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.filtrToolStripMenuItem.Text = "Filtr";
            // 
            // bezEfektówToolStripMenuItem
            // 
            this.bezEfektówToolStripMenuItem.Name = "bezEfektówToolStripMenuItem";
            this.bezEfektówToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.bezEfektówToolStripMenuItem.Text = "Bez efektów";
            // 
            // czarnoBiałyToolStripMenuItem
            // 
            this.czarnoBiałyToolStripMenuItem.Name = "czarnoBiałyToolStripMenuItem";
            this.czarnoBiałyToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.czarnoBiałyToolStripMenuItem.Text = "Czarno - biały";
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            // 
            // negatywToolStripMenuItem
            // 
            this.negatywToolStripMenuItem.Name = "negatywToolStripMenuItem";
            this.negatywToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.negatywToolStripMenuItem.Text = "Negatyw";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Plik graficzny|*.jpg*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "bez nazwy";
            this.saveFileDialog1.Filter = "Plik graficzny|*.jpg*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(758, 510);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "EasyPhotoshop";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wstawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bezEfektówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czarnoBiałyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negatywToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem znakWodnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

