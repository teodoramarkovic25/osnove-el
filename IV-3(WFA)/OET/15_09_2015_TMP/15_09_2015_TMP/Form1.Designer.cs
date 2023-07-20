namespace _15_09_2015_TMP
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_omovzakon = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_struja = new System.Windows.Forms.Label();
            this.lbl_napon = new System.Windows.Forms.Label();
            this.lbl_otpornost = new System.Windows.Forms.Label();
            this.txtbox_struja = new System.Windows.Forms.TextBox();
            this.txtbox_napon = new System.Windows.Forms.TextBox();
            this.txtbox_otpornost = new System.Windows.Forms.TextBox();
            this.pictureBox_omovzakon = new System.Windows.Forms.PictureBox();
            this.btn_izracunaj_omovzakon = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_vrijeme = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPage_otpornost = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_R1 = new System.Windows.Forms.Label();
            this.lbl_R2 = new System.Windows.Forms.Label();
            this.lbl_Rekv = new System.Windows.Forms.Label();
            this.txtbox_r1 = new System.Windows.Forms.TextBox();
            this.txtbox_r2 = new System.Windows.Forms.TextBox();
            this.txtbox_rekv = new System.Windows.Forms.TextBox();
            this.lbl_tipveze = new System.Windows.Forms.Label();
            this.radiobtn_serijska = new System.Windows.Forms.RadioButton();
            this.radiobtn_paralelna = new System.Windows.Forms.RadioButton();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus_vrijemee = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox_otpornost = new System.Windows.Forms.PictureBox();
            this.timer_sat = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage_omovzakon.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_omovzakon)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tabPage_otpornost.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_otpornost)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_omovzakon);
            this.tabControl1.Controls.Add(this.tabPage_otpornost);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(659, 395);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_omovzakon
            // 
            this.tabPage_omovzakon.Controls.Add(this.tableLayoutPanel1);
            this.tabPage_omovzakon.Location = new System.Drawing.Point(4, 25);
            this.tabPage_omovzakon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_omovzakon.Name = "tabPage_omovzakon";
            this.tabPage_omovzakon.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_omovzakon.Size = new System.Drawing.Size(651, 366);
            this.tabPage_omovzakon.TabIndex = 0;
            this.tabPage_omovzakon.Text = "Omov zakon";
            this.tabPage_omovzakon.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_struja, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_napon, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_otpornost, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtbox_struja, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtbox_napon, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtbox_otpornost, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_omovzakon, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_izracunaj_omovzakon, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.57752F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.57752F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.57752F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.57752F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.689922F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(643, 358);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_struja
            // 
            this.lbl_struja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_struja.AutoSize = true;
            this.lbl_struja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_struja.Location = new System.Drawing.Point(41, 30);
            this.lbl_struja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_struja.Name = "lbl_struja";
            this.lbl_struja.Size = new System.Drawing.Size(46, 20);
            this.lbl_struja.TabIndex = 0;
            this.lbl_struja.Text = "I(A):";
            // 
            // lbl_napon
            // 
            this.lbl_napon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_napon.AutoSize = true;
            this.lbl_napon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_napon.Location = new System.Drawing.Point(37, 110);
            this.lbl_napon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_napon.Name = "lbl_napon";
            this.lbl_napon.Size = new System.Drawing.Size(54, 20);
            this.lbl_napon.TabIndex = 1;
            this.lbl_napon.Text = "U(V):";
            // 
            // lbl_otpornost
            // 
            this.lbl_otpornost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_otpornost.AutoSize = true;
            this.lbl_otpornost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_otpornost.Location = new System.Drawing.Point(36, 190);
            this.lbl_otpornost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_otpornost.Name = "lbl_otpornost";
            this.lbl_otpornost.Size = new System.Drawing.Size(56, 20);
            this.lbl_otpornost.TabIndex = 2;
            this.lbl_otpornost.Text = "R(Ω):";
            // 
            // txtbox_struja
            // 
            this.txtbox_struja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_struja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtbox_struja.Location = new System.Drawing.Point(132, 27);
            this.txtbox_struja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbox_struja.Name = "txtbox_struja";
            this.txtbox_struja.Size = new System.Drawing.Size(120, 26);
            this.txtbox_struja.TabIndex = 3;
            this.txtbox_struja.TextChanged += new System.EventHandler(this.txtbox_struja_TextChanged);
            // 
            // txtbox_napon
            // 
            this.txtbox_napon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_napon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtbox_napon.Location = new System.Drawing.Point(132, 107);
            this.txtbox_napon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbox_napon.Name = "txtbox_napon";
            this.txtbox_napon.Size = new System.Drawing.Size(120, 26);
            this.txtbox_napon.TabIndex = 4;
            this.txtbox_napon.TextChanged += new System.EventHandler(this.txtbox_napon_TextChanged);
            // 
            // txtbox_otpornost
            // 
            this.txtbox_otpornost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_otpornost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtbox_otpornost.Location = new System.Drawing.Point(132, 187);
            this.txtbox_otpornost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbox_otpornost.Name = "txtbox_otpornost";
            this.txtbox_otpornost.Size = new System.Drawing.Size(120, 26);
            this.txtbox_otpornost.TabIndex = 5;
            this.txtbox_otpornost.TextChanged += new System.EventHandler(this.txtbox_otpornost_TextChanged);
            // 
            // pictureBox_omovzakon
            // 
            this.pictureBox_omovzakon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_omovzakon.Image = global::_15_09_2015_TMP.Properties.Resources.OmovZakon;
            this.pictureBox_omovzakon.Location = new System.Drawing.Point(260, 4);
            this.pictureBox_omovzakon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_omovzakon.Name = "pictureBox_omovzakon";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox_omovzakon, 3);
            this.pictureBox_omovzakon.Size = new System.Drawing.Size(379, 232);
            this.pictureBox_omovzakon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_omovzakon.TabIndex = 6;
            this.pictureBox_omovzakon.TabStop = false;
            // 
            // btn_izracunaj_omovzakon
            // 
            this.btn_izracunaj_omovzakon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.btn_izracunaj_omovzakon, 2);
            this.btn_izracunaj_omovzakon.Enabled = false;
            this.btn_izracunaj_omovzakon.Location = new System.Drawing.Point(65, 263);
            this.btn_izracunaj_omovzakon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_izracunaj_omovzakon.Name = "btn_izracunaj_omovzakon";
            this.btn_izracunaj_omovzakon.Size = new System.Drawing.Size(125, 34);
            this.btn_izracunaj_omovzakon.TabIndex = 7;
            this.btn_izracunaj_omovzakon.Text = "Izracunaj";
            this.btn_izracunaj_omovzakon.UseVisualStyleBackColor = true;
            this.btn_izracunaj_omovzakon.Click += new System.EventHandler(this.btn_izracunaj_omovzakon_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.statusStrip1, 3);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_vrijeme});
            this.statusStrip1.Location = new System.Drawing.Point(0, 332);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(643, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_vrijeme
            // 
            this.toolStripStatusLabel_vrijeme.Name = "toolStripStatusLabel_vrijeme";
            this.toolStripStatusLabel_vrijeme.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel_vrijeme.Text = "toolStripStatusLabel1";
            // 
            // tabPage_otpornost
            // 
            this.tabPage_otpornost.Controls.Add(this.tableLayoutPanel2);
            this.tabPage_otpornost.Location = new System.Drawing.Point(4, 25);
            this.tabPage_otpornost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_otpornost.Name = "tabPage_otpornost";
            this.tabPage_otpornost.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_otpornost.Size = new System.Drawing.Size(651, 366);
            this.tabPage_otpornost.TabIndex = 1;
            this.tabPage_otpornost.Text = "Otpornost";
            this.tabPage_otpornost.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.988F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.988F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.02401F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_R1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_R2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Rekv, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtbox_r1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtbox_r2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtbox_rekv, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lbl_tipveze, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.radiobtn_serijska, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.radiobtn_paralelna, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.statusStrip2, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox_otpornost, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(643, 358);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lbl_R1
            // 
            this.lbl_R1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_R1.AutoSize = true;
            this.lbl_R1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_R1.Location = new System.Drawing.Point(31, 22);
            this.lbl_R1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_R1.Name = "lbl_R1";
            this.lbl_R1.Size = new System.Drawing.Size(66, 20);
            this.lbl_R1.TabIndex = 0;
            this.lbl_R1.Text = "R1(Ω):";
            // 
            // lbl_R2
            // 
            this.lbl_R2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_R2.AutoSize = true;
            this.lbl_R2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_R2.Location = new System.Drawing.Point(31, 86);
            this.lbl_R2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_R2.Name = "lbl_R2";
            this.lbl_R2.Size = new System.Drawing.Size(66, 20);
            this.lbl_R2.TabIndex = 1;
            this.lbl_R2.Text = "R2(Ω):";
            // 
            // lbl_Rekv
            // 
            this.lbl_Rekv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Rekv.AutoSize = true;
            this.lbl_Rekv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Rekv.Location = new System.Drawing.Point(22, 278);
            this.lbl_Rekv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Rekv.Name = "lbl_Rekv";
            this.lbl_Rekv.Size = new System.Drawing.Size(84, 20);
            this.lbl_Rekv.TabIndex = 2;
            this.lbl_Rekv.Text = "Rekv(Ω):";
            // 
            // txtbox_r1
            // 
            this.txtbox_r1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_r1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtbox_r1.Location = new System.Drawing.Point(132, 19);
            this.txtbox_r1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbox_r1.Name = "txtbox_r1";
            this.txtbox_r1.Size = new System.Drawing.Size(120, 26);
            this.txtbox_r1.TabIndex = 3;
            // 
            // txtbox_r2
            // 
            this.txtbox_r2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_r2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtbox_r2.Location = new System.Drawing.Point(132, 83);
            this.txtbox_r2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbox_r2.Name = "txtbox_r2";
            this.txtbox_r2.Size = new System.Drawing.Size(120, 26);
            this.txtbox_r2.TabIndex = 4;
            // 
            // txtbox_rekv
            // 
            this.txtbox_rekv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_rekv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtbox_rekv.Location = new System.Drawing.Point(132, 275);
            this.txtbox_rekv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbox_rekv.Name = "txtbox_rekv";
            this.txtbox_rekv.Size = new System.Drawing.Size(120, 26);
            this.txtbox_rekv.TabIndex = 5;
            // 
            // lbl_tipveze
            // 
            this.lbl_tipveze.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tipveze.AutoSize = true;
            this.lbl_tipveze.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_tipveze.Location = new System.Drawing.Point(21, 182);
            this.lbl_tipveze.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tipveze.Name = "lbl_tipveze";
            this.tableLayoutPanel2.SetRowSpan(this.lbl_tipveze, 2);
            this.lbl_tipveze.Size = new System.Drawing.Size(86, 20);
            this.lbl_tipveze.TabIndex = 6;
            this.lbl_tipveze.Text = "Tip veze:";
            // 
            // radiobtn_serijska
            // 
            this.radiobtn_serijska.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radiobtn_serijska.AutoSize = true;
            this.radiobtn_serijska.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radiobtn_serijska.Location = new System.Drawing.Point(132, 166);
            this.radiobtn_serijska.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radiobtn_serijska.Name = "radiobtn_serijska";
            this.radiobtn_serijska.Size = new System.Drawing.Size(90, 22);
            this.radiobtn_serijska.TabIndex = 7;
            this.radiobtn_serijska.TabStop = true;
            this.radiobtn_serijska.Text = "Serijska";
            this.radiobtn_serijska.UseVisualStyleBackColor = true;
            this.radiobtn_serijska.Click += new System.EventHandler(this.radiobtn_serijska_Click);
            // 
            // radiobtn_paralelna
            // 
            this.radiobtn_paralelna.AutoSize = true;
            this.radiobtn_paralelna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radiobtn_paralelna.Location = new System.Drawing.Point(132, 196);
            this.radiobtn_paralelna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radiobtn_paralelna.Name = "radiobtn_paralelna";
            this.radiobtn_paralelna.Size = new System.Drawing.Size(99, 22);
            this.radiobtn_paralelna.TabIndex = 9;
            this.radiobtn_paralelna.TabStop = true;
            this.radiobtn_paralelna.Text = "Paralelna";
            this.radiobtn_paralelna.UseVisualStyleBackColor = true;
            this.radiobtn_paralelna.CheckedChanged += new System.EventHandler(this.radiobtn_paralelna_CheckedChanged);
            // 
            // statusStrip2
            // 
            this.statusStrip2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.SetColumnSpan(this.statusStrip2, 3);
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus_vrijemee});
            this.statusStrip2.Location = new System.Drawing.Point(0, 332);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip2.Size = new System.Drawing.Size(643, 26);
            this.statusStrip2.TabIndex = 10;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatus_vrijemee
            // 
            this.toolStripStatus_vrijemee.Name = "toolStripStatus_vrijemee";
            this.toolStripStatus_vrijemee.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatus_vrijemee.Text = "toolStripStatusLabel1";
            // 
            // pictureBox_otpornost
            // 
            this.pictureBox_otpornost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_otpornost.Image = global::_15_09_2015_TMP.Properties.Resources.Otpornost;
            this.pictureBox_otpornost.Location = new System.Drawing.Point(260, 4);
            this.pictureBox_otpornost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_otpornost.Name = "pictureBox_otpornost";
            this.tableLayoutPanel2.SetRowSpan(this.pictureBox_otpornost, 5);
            this.pictureBox_otpornost.Size = new System.Drawing.Size(379, 312);
            this.pictureBox_otpornost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_otpornost.TabIndex = 11;
            this.pictureBox_otpornost.TabStop = false;
            // 
            // timer_sat
            // 
            this.timer_sat.Interval = 1000;
            this.timer_sat.Tick += new System.EventHandler(this.timer_sat_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 395);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(807, 555);
            this.MinimumSize = new System.Drawing.Size(541, 309);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Osnove elektrotehnike";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_omovzakon.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_omovzakon)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage_otpornost.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_otpornost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_omovzakon;
        private System.Windows.Forms.TabPage tabPage_otpornost;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_struja;
        private System.Windows.Forms.Label lbl_napon;
        private System.Windows.Forms.Label lbl_otpornost;
        private System.Windows.Forms.TextBox txtbox_struja;
        private System.Windows.Forms.TextBox txtbox_napon;
        private System.Windows.Forms.TextBox txtbox_otpornost;
        private System.Windows.Forms.PictureBox pictureBox_omovzakon;
        private System.Windows.Forms.Button btn_izracunaj_omovzakon;
        private System.Windows.Forms.Timer timer_sat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_vrijeme;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_R1;
        private System.Windows.Forms.Label lbl_R2;
        private System.Windows.Forms.Label lbl_Rekv;
        private System.Windows.Forms.TextBox txtbox_r1;
        private System.Windows.Forms.TextBox txtbox_r2;
        private System.Windows.Forms.TextBox txtbox_rekv;
        private System.Windows.Forms.Label lbl_tipveze;
        private System.Windows.Forms.RadioButton radiobtn_serijska;
        private System.Windows.Forms.RadioButton radiobtn_paralelna;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_vrijemee;
        private System.Windows.Forms.PictureBox pictureBox_otpornost;
    }
}

