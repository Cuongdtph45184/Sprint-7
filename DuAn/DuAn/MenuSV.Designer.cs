namespace DuAn
{
    partial class MenuSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuSV));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvDanhSachSV = new DataGridView();
            txttimkiem = new TextBox();
            btntimkiem = new Button();
            btnthoat = new Button();
            tphotro = new TabPage();
            button2 = new Button();
            button1 = new Button();
            label13 = new Label();
            cbodanhmuc = new ComboBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            txtcauhoi = new TextBox();
            label17 = new Label();
            button3 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSV).BeginInit();
            tphotro.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tphotro);
            tabControl1.Location = new Point(10, 2);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(754, 470);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvDanhSachSV);
            tabPage1.Controls.Add(txttimkiem);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(btntimkiem);
            tabPage1.Controls.Add(btnthoat);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(746, 442);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Bảng nhân viên";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvDanhSachSV
            // 
            dgvDanhSachSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachSV.Location = new Point(16, 10);
            dgvDanhSachSV.Margin = new Padding(2);
            dgvDanhSachSV.Name = "dgvDanhSachSV";
            dgvDanhSachSV.RowHeadersWidth = 62;
            dgvDanhSachSV.RowTemplate.Height = 33;
            dgvDanhSachSV.Size = new Size(718, 256);
            dgvDanhSachSV.TabIndex = 72;
            // 
            // txttimkiem
            // 
            txttimkiem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txttimkiem.Location = new Point(390, 281);
            txttimkiem.Margin = new Padding(3, 2, 3, 2);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(133, 27);
            txttimkiem.TabIndex = 12;
            // 
            // btntimkiem
            // 
            btntimkiem.BackColor = SystemColors.ControlLight;
            btntimkiem.Location = new Point(557, 281);
            btntimkiem.Margin = new Padding(3, 2, 3, 2);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(82, 27);
            btntimkiem.TabIndex = 10;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.UseVisualStyleBackColor = false;
            btntimkiem.Click += btntimkiem_Click;
            // 
            // btnthoat
            // 
            btnthoat.BackColor = SystemColors.ControlLight;
            btnthoat.Location = new Point(557, 380);
            btnthoat.Margin = new Padding(3, 2, 3, 2);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(82, 37);
            btnthoat.TabIndex = 11;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = false;
            btnthoat.Click += btnthoat_Click_1;
            // 
            // tphotro
            // 
            tphotro.Controls.Add(button2);
            tphotro.Controls.Add(button1);
            tphotro.Controls.Add(label13);
            tphotro.Controls.Add(cbodanhmuc);
            tphotro.Controls.Add(label14);
            tphotro.Controls.Add(label15);
            tphotro.Controls.Add(label16);
            tphotro.Controls.Add(txtcauhoi);
            tphotro.Controls.Add(label17);
            tphotro.Location = new Point(4, 24);
            tphotro.Margin = new Padding(3, 2, 3, 2);
            tphotro.Name = "tphotro";
            tphotro.Padding = new Padding(3, 2, 3, 2);
            tphotro.Size = new Size(746, 442);
            tphotro.TabIndex = 1;
            tphotro.Text = "Hỗ trợ";
            tphotro.UseVisualStyleBackColor = true;
            tphotro.Click += tphotro_Click;
            // 
            // button2
            // 
            button2.Location = new Point(373, 141);
            button2.Name = "button2";
            button2.Size = new Size(75, 22);
            button2.TabIndex = 35;
            button2.Text = "Gửi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(613, 348);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 26);
            button1.TabIndex = 34;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.Location = new Point(256, 216);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(360, 136);
            label13.TabIndex = 33;
            label13.Text = resources.GetString("label13.Text");
            // 
            // cbodanhmuc
            // 
            cbodanhmuc.FormattingEnabled = true;
            cbodanhmuc.Items.AddRange(new object[] { "DvSV", "Khảo Thí", "Đào Tạo ", "Hành Chính", "IT" });
            cbodanhmuc.Location = new Point(60, 202);
            cbodanhmuc.Margin = new Padding(2);
            cbodanhmuc.Name = "cbodanhmuc";
            cbodanhmuc.Size = new Size(129, 23);
            cbodanhmuc.TabIndex = 32;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(361, 186);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(124, 19);
            label14.TabIndex = 29;
            label14.Text = "Thông tin liên hệ ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(57, 118);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(64, 19);
            label15.TabIndex = 30;
            label15.Text = "Câu Hỏi";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(57, 181);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(80, 19);
            label16.TabIndex = 31;
            label16.Text = "Danh mục ";
            // 
            // txtcauhoi
            // 
            txtcauhoi.Location = new Point(60, 143);
            txtcauhoi.Margin = new Padding(2);
            txtcauhoi.Name = "txtcauhoi";
            txtcauhoi.Size = new Size(281, 23);
            txtcauhoi.TabIndex = 28;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.Red;
            label17.Location = new Point(332, 36);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(65, 21);
            label17.TabIndex = 27;
            label17.Text = "Hỗ Trợ";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Location = new Point(557, 331);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 27);
            button3.TabIndex = 10;
            button3.Text = "Hiển Thị";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Btn_hienthi;
            // 
            // MenuSV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 482);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuSV";
            Text = "MenuSV";
            Load += MenuSV_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSV).EndInit();
            tphotro.ResumeLayout(false);
            tphotro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnthoat;
        private TabPage tphotro;
        private Button button2;
        private Button button1;
        private Label label13;
        private ComboBox cbodanhmuc;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox txtcauhoi;
        private Label label17;
        private TextBox txttimkiem;
        private Button btntimkiem;
        private DataGridView dgvDanhSachSV;
        private Button button3;
    }
}