namespace lab7
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.списокЗадачToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задача2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задача3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задача4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокЗадачToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Список задач";
            // 
            // списокЗадачToolStripMenuItem
            // 
            this.списокЗадачToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задача2ToolStripMenuItem,
            this.задача3ToolStripMenuItem,
            this.задача4ToolStripMenuItem});
            this.списокЗадачToolStripMenuItem.Name = "списокЗадачToolStripMenuItem";
            this.списокЗадачToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.списокЗадачToolStripMenuItem.Text = "Список задач";
            // 
            // задача2ToolStripMenuItem
            // 
            this.задача2ToolStripMenuItem.Name = "задача2ToolStripMenuItem";
            this.задача2ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.задача2ToolStripMenuItem.Text = "Задача 2";
            this.задача2ToolStripMenuItem.Click += new System.EventHandler(this.задача2ToolStripMenuItem_Click);
            // 
            // задача3ToolStripMenuItem
            // 
            this.задача3ToolStripMenuItem.Name = "задача3ToolStripMenuItem";
            this.задача3ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.задача3ToolStripMenuItem.Text = "Задача 3";
            this.задача3ToolStripMenuItem.Click += new System.EventHandler(this.задача3ToolStripMenuItem_Click);
            // 
            // задача4ToolStripMenuItem
            // 
            this.задача4ToolStripMenuItem.Name = "задача4ToolStripMenuItem";
            this.задача4ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.задача4ToolStripMenuItem.Text = "Задача 4";
            this.задача4ToolStripMenuItem.Click += new System.EventHandler(this.задача4ToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(643, 363);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(666, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "ГЛАВНАЯ ФОРМА";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem списокЗадачToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задача2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задача3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задача4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}