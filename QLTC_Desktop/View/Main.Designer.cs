namespace QLTC_Desktop.View
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.víTiềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchCácVíTiềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêm1VíTiềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuchiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmKhoảngThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmKhoảngChiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinPhầnMềmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMoney = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvWallet = new System.Windows.Forms.DataGridView();
            this.dtgvAction = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvWallet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAction)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 32);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(13, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 279);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvWallet);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(15, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 213);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgvAction);
            this.panel4.Controls.Add(this.lbMoney);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(266, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(459, 213);
            this.panel4.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.víTiềnToolStripMenuItem,
            this.thuchiToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // víTiềnToolStripMenuItem
            // 
            this.víTiềnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchCácVíTiềnToolStripMenuItem,
            this.thêm1VíTiềnToolStripMenuItem});
            this.víTiềnToolStripMenuItem.Name = "víTiềnToolStripMenuItem";
            this.víTiềnToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.víTiềnToolStripMenuItem.Text = "Ví tiền";
            // 
            // danhSáchCácVíTiềnToolStripMenuItem
            // 
            this.danhSáchCácVíTiềnToolStripMenuItem.Name = "danhSáchCácVíTiềnToolStripMenuItem";
            this.danhSáchCácVíTiềnToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.danhSáchCácVíTiềnToolStripMenuItem.Text = "Danh sách các ví tiền";
            this.danhSáchCácVíTiềnToolStripMenuItem.Click += new System.EventHandler(this.danhSáchCácVíTiềnToolStripMenuItem_Click);
            // 
            // thêm1VíTiềnToolStripMenuItem
            // 
            this.thêm1VíTiềnToolStripMenuItem.Name = "thêm1VíTiềnToolStripMenuItem";
            this.thêm1VíTiềnToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.thêm1VíTiềnToolStripMenuItem.Text = "Thêm 1 ví tiền";
            this.thêm1VíTiềnToolStripMenuItem.Click += new System.EventHandler(this.thêm1VíTiềnToolStripMenuItem_Click);
            // 
            // thuchiToolStripMenuItem
            // 
            this.thuchiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmKhoảngThuToolStripMenuItem,
            this.thêmKhoảngChiToolStripMenuItem,
            this.traCứuToolStripMenuItem});
            this.thuchiToolStripMenuItem.Name = "thuchiToolStripMenuItem";
            this.thuchiToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.thuchiToolStripMenuItem.Text = "Thu/chi";
            // 
            // thêmKhoảngThuToolStripMenuItem
            // 
            this.thêmKhoảngThuToolStripMenuItem.Name = "thêmKhoảngThuToolStripMenuItem";
            this.thêmKhoảngThuToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.thêmKhoảngThuToolStripMenuItem.Text = "Thêm khoảng thu";
            this.thêmKhoảngThuToolStripMenuItem.Click += new System.EventHandler(this.thêmKhoảngThuToolStripMenuItem_Click);
            // 
            // thêmKhoảngChiToolStripMenuItem
            // 
            this.thêmKhoảngChiToolStripMenuItem.Name = "thêmKhoảngChiToolStripMenuItem";
            this.thêmKhoảngChiToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.thêmKhoảngChiToolStripMenuItem.Text = "Thêm khoảng chi";
            this.thêmKhoảngChiToolStripMenuItem.Click += new System.EventHandler(this.thêmKhoảngChiToolStripMenuItem_Click);
            // 
            // traCứuToolStripMenuItem
            // 
            this.traCứuToolStripMenuItem.Name = "traCứuToolStripMenuItem";
            this.traCứuToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.traCứuToolStripMenuItem.Text = "Tra cứu";
            this.traCứuToolStripMenuItem.Click += new System.EventHandler(this.traCứuToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinPhầnMềmToolStripMenuItem});
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // thôngTinPhầnMềmToolStripMenuItem
            // 
            this.thôngTinPhầnMềmToolStripMenuItem.Name = "thôngTinPhầnMềmToolStripMenuItem";
            this.thôngTinPhầnMềmToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.thôngTinPhầnMềmToolStripMenuItem.Text = "Thông tin phần mềm";
            this.thôngTinPhầnMềmToolStripMenuItem.Click += new System.EventHandler(this.thôngTinPhầnMềmToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách ví tiền";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng số tiền còn lại";
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Location = new System.Drawing.Point(152, 15);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(39, 13);
            this.lbMoney.TabIndex = 1;
            this.lbMoney.Text = "0 VNĐ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh sách các hoạt động";
            // 
            // dtgvWallet
            // 
            this.dtgvWallet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvWallet.Location = new System.Drawing.Point(14, 38);
            this.dtgvWallet.Name = "dtgvWallet";
            this.dtgvWallet.Size = new System.Drawing.Size(196, 169);
            this.dtgvWallet.TabIndex = 1;
            this.dtgvWallet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvWallet_CellContentClick);
            // 
            // dtgvAction
            // 
            this.dtgvAction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAction.Location = new System.Drawing.Point(16, 54);
            this.dtgvAction.Name = "dtgvAction";
            this.dtgvAction.Size = new System.Drawing.Size(421, 148);
            this.dtgvAction.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 342);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvWallet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem víTiềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchCácVíTiềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêm1VíTiềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuchiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmKhoảngThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmKhoảngChiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinPhầnMềmToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvAction;
        private System.Windows.Forms.DataGridView dtgvWallet;
    }
}