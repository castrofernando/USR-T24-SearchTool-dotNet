namespace IpSearchTool
{
    partial class IpSearch
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tmrBuscar = new System.Windows.Forms.Timer(this.components);
            this.txtMac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVersao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDestIp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPortaDst = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPortaSrc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGateway = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBaudRate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSubNetMask = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.grdDevices = new System.Windows.Forms.DataGridView();
            this._ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._mac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pgrBuscar = new System.Windows.Forms.ProgressBar();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnSetIp = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.txtIpTcp = new System.Windows.Forms.TextBox();
            this.txtPortaTcp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPulsar = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdDevices)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 363);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(251, 31);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar Hardware";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tmrBuscar
            // 
            this.tmrBuscar.Interval = 1000;
            this.tmrBuscar.Tick += new System.EventHandler(this.tmrBuscar_Tick);
            // 
            // txtMac
            // 
            this.txtMac.Enabled = false;
            this.txtMac.Location = new System.Drawing.Point(110, 218);
            this.txtMac.Name = "txtMac";
            this.txtMac.Size = new System.Drawing.Size(153, 20);
            this.txtMac.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Endereço MAC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Versao:";
            // 
            // txtVersao
            // 
            this.txtVersao.Enabled = false;
            this.txtVersao.Location = new System.Drawing.Point(110, 322);
            this.txtVersao.Name = "txtVersao";
            this.txtVersao.Size = new System.Drawing.Size(153, 20);
            this.txtVersao.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dest IP:";
            // 
            // txtDestIp
            // 
            this.txtDestIp.Location = new System.Drawing.Point(380, 218);
            this.txtDestIp.Name = "txtDestIp";
            this.txtDestIp.Size = new System.Drawing.Size(153, 20);
            this.txtDestIp.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Porta Dst:";
            // 
            // txtPortaDst
            // 
            this.txtPortaDst.Location = new System.Drawing.Point(380, 244);
            this.txtPortaDst.Name = "txtPortaDst";
            this.txtPortaDst.Size = new System.Drawing.Size(153, 20);
            this.txtPortaDst.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "IP:";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(110, 244);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(153, 20);
            this.txtIp.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Porta Src:";
            // 
            // txtPortaSrc
            // 
            this.txtPortaSrc.Location = new System.Drawing.Point(380, 270);
            this.txtPortaSrc.Name = "txtPortaSrc";
            this.txtPortaSrc.Size = new System.Drawing.Size(153, 20);
            this.txtPortaSrc.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Gateway:";
            // 
            // txtGateway
            // 
            this.txtGateway.Location = new System.Drawing.Point(110, 296);
            this.txtGateway.Name = "txtGateway";
            this.txtGateway.Size = new System.Drawing.Size(153, 20);
            this.txtGateway.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(337, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Modo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(319, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Baud Rate:";
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Location = new System.Drawing.Point(380, 323);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(153, 20);
            this.txtBaudRate.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Mascara de rede:";
            // 
            // txtSubNetMask
            // 
            this.txtSubNetMask.Location = new System.Drawing.Point(110, 270);
            this.txtSubNetMask.Name = "txtSubNetMask";
            this.txtSubNetMask.Size = new System.Drawing.Size(153, 20);
            this.txtSubNetMask.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(377, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Qtd. Placas Encontradas:";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(514, 184);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(0, 13);
            this.lblQtd.TabIndex = 28;
            // 
            // grdDevices
            // 
            this.grdDevices.AllowUserToAddRows = false;
            this.grdDevices.AllowUserToDeleteRows = false;
            this.grdDevices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDevices.BackgroundColor = System.Drawing.Color.White;
            this.grdDevices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDevices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._ip,
            this._mac});
            this.grdDevices.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grdDevices.Location = new System.Drawing.Point(12, 12);
            this.grdDevices.MultiSelect = false;
            this.grdDevices.Name = "grdDevices";
            this.grdDevices.ReadOnly = true;
            this.grdDevices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDevices.Size = new System.Drawing.Size(521, 169);
            this.grdDevices.TabIndex = 29;
            this.grdDevices.SelectionChanged += new System.EventHandler(this.grdDevices_SelectionChanged);
            // 
            // _ip
            // 
            this._ip.HeaderText = "IP";
            this._ip.Name = "_ip";
            this._ip.ReadOnly = true;
            // 
            // _mac
            // 
            this._mac.HeaderText = "Mac Address";
            this._mac.Name = "_mac";
            this._mac.ReadOnly = true;
            // 
            // pgrBuscar
            // 
            this.pgrBuscar.Location = new System.Drawing.Point(12, 403);
            this.pgrBuscar.Name = "pgrBuscar";
            this.pgrBuscar.Size = new System.Drawing.Size(521, 28);
            this.pgrBuscar.Step = 20;
            this.pgrBuscar.TabIndex = 31;
            // 
            // cmbTipo
            // 
            this.cmbTipo.Enabled = false;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "0 - UDP Mode",
            "1 - TCP Client",
            "2 - UDP Server",
            "3 - TCP Server"});
            this.cmbTipo.Location = new System.Drawing.Point(380, 296);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(153, 21);
            this.cmbTipo.TabIndex = 32;
            // 
            // btnSetIp
            // 
            this.btnSetIp.Location = new System.Drawing.Point(282, 363);
            this.btnSetIp.Name = "btnSetIp";
            this.btnSetIp.Size = new System.Drawing.Size(251, 31);
            this.btnSetIp.TabIndex = 33;
            this.btnSetIp.Text = "Configurar Hardware";
            this.btnSetIp.UseVisualStyleBackColor = true;
            this.btnSetIp.Click += new System.EventHandler(this.btnSetIp_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(141, 77);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(81, 23);
            this.btnConectar.TabIndex = 34;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(141, 106);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(81, 23);
            this.btnDesconectar.TabIndex = 35;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // txtIpTcp
            // 
            this.txtIpTcp.Location = new System.Drawing.Point(56, 25);
            this.txtIpTcp.Name = "txtIpTcp";
            this.txtIpTcp.Size = new System.Drawing.Size(166, 20);
            this.txtIpTcp.TabIndex = 36;
            this.txtIpTcp.Text = "192.168.0.102";
            // 
            // txtPortaTcp
            // 
            this.txtPortaTcp.Location = new System.Drawing.Point(56, 51);
            this.txtPortaTcp.Name = "txtPortaTcp";
            this.txtPortaTcp.Size = new System.Drawing.Size(166, 20);
            this.txtPortaTcp.TabIndex = 37;
            this.txtPortaTcp.Text = "3500";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "IP:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Porta:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.btnDesconectar);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnConectar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtIpTcp);
            this.groupBox1.Controls.Add(this.txtPortaTcp);
            this.groupBox1.Location = new System.Drawing.Point(548, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 141);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tcp Client";
            // 
            // btnPulsar
            // 
            this.btnPulsar.Location = new System.Drawing.Point(581, 184);
            this.btnPulsar.Name = "btnPulsar";
            this.btnPulsar.Size = new System.Drawing.Size(75, 23);
            this.btnPulsar.TabIndex = 41;
            this.btnPulsar.Text = "Pulsar Relé";
            this.btnPulsar.UseVisualStyleBackColor = true;
            this.btnPulsar.Click += new System.EventHandler(this.btnPulsar_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(18, 98);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(55, 20);
            this.txtResult.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Resultado:";
            // 
            // IpSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 440);
            this.Controls.Add(this.btnPulsar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSetIp);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.pgrBuscar);
            this.Controls.Add(this.grdDevices);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSubNetMask);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBaudRate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGateway);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPortaSrc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPortaDst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDestIp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVersao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMac);
            this.Controls.Add(this.btnBuscar);
            this.Name = "IpSearch";
            this.Text = "DSnet Search";
            ((System.ComponentModel.ISupportInitialize)(this.grdDevices)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Timer tmrBuscar;
        private System.Windows.Forms.TextBox txtMac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVersao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDestIp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPortaDst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPortaSrc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGateway;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBaudRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSubNetMask;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.DataGridView grdDevices;
        private System.Windows.Forms.DataGridViewTextBoxColumn _ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn _mac;
        private System.Windows.Forms.ProgressBar pgrBuscar;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnSetIp;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.TextBox txtIpTcp;
        private System.Windows.Forms.TextBox txtPortaTcp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPulsar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtResult;
    }
}

