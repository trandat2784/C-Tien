namespace ManageLibrary
{
    partial class Form_Menu
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            accountToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            informationToolStripMenuItem = new ToolStripMenuItem();
            bookToolStripMenuItem = new ToolStripMenuItem();
            authorToolStripMenuItem = new ToolStripMenuItem();
            nXBToolStripMenuItem = new ToolStripMenuItem();
            muonTraToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { accountToolStripMenuItem, informationToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(139, 450);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.AutoSize = false;
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logOutToolStripMenuItem, exitToolStripMenuItem });
            accountToolStripMenuItem.Font = new Font("#9Slide03 SVND Sari", 9.999999F, FontStyle.Regular, GraphicsUnit.Point);
            accountToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(150, 50);
            accountToolStripMenuItem.Text = "Tài khoản";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(202, 34);
            logOutToolStripMenuItem.Text = "Đăng xuất";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(202, 34);
            exitToolStripMenuItem.Text = "Thoát";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // informationToolStripMenuItem
            // 
            informationToolStripMenuItem.AutoSize = false;
            informationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bookToolStripMenuItem, authorToolStripMenuItem, nXBToolStripMenuItem, muonTraToolStripMenuItem });
            informationToolStripMenuItem.Font = new Font("#9Slide03 SVND Sari", 9.999999F, FontStyle.Regular, GraphicsUnit.Point);
            informationToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            informationToolStripMenuItem.ImageTransparentColor = Color.WhiteSmoke;
            informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            informationToolStripMenuItem.Size = new Size(150, 50);
            informationToolStripMenuItem.Text = "Quản lí";
            // 
            // bookToolStripMenuItem
            // 
            bookToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            bookToolStripMenuItem.Size = new Size(270, 34);
            bookToolStripMenuItem.Text = "Sách";
            bookToolStripMenuItem.Click += bookToolStripMenuItem_Click;
            // 
            // authorToolStripMenuItem
            // 
            authorToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            authorToolStripMenuItem.Size = new Size(270, 34);
            authorToolStripMenuItem.Text = "Tác giả";
            authorToolStripMenuItem.Click += authorToolStripMenuItem_Click;
            // 
            // nXBToolStripMenuItem
            // 
            nXBToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            nXBToolStripMenuItem.ForeColor = SystemColors.ControlText;
            nXBToolStripMenuItem.Name = "nXBToolStripMenuItem";
            nXBToolStripMenuItem.Size = new Size(270, 34);
            nXBToolStripMenuItem.Text = "NXB";
            nXBToolStripMenuItem.Click += nXBToolStripMenuItem_Click;
            // 
            // muonTraToolStripMenuItem
            // 
            muonTraToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            muonTraToolStripMenuItem.ForeColor = SystemColors.ControlText;
            muonTraToolStripMenuItem.Name = "muonTraToolStripMenuItem";
            muonTraToolStripMenuItem.Size = new Size(270, 34);
            muonTraToolStripMenuItem.Text = "Mượn Trả";
            muonTraToolStripMenuItem.Click += muonTraToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.AutoSize = false;
            toolStripMenuItem1.Font = new Font("#9Slide03 SVND Sari", 9.999999F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(150, 50);
            toolStripMenuItem1.Text = "Thông tin";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // Form_Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form_Menu";
            Text = "Form_Menu";
            Load += Form_Menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem informationToolStripMenuItem;
        private ToolStripMenuItem bookToolStripMenuItem;
        private ToolStripMenuItem authorToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem nXBToolStripMenuItem;
        private ToolStripMenuItem muonTraToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}