namespace ferreteria_x_2019.Forms
{
    partial class frmMarca
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarca));
            this.dgvM = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dgvTi = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtMarca = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.btnNewM = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnUptM = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnElimM = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnElimT = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnUptT = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnNewT = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblAgregarItems = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipo = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUptM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnElimM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnElimT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUptT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvM
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dgvM.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.dgvM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvM.DoubleBuffered = true;
            this.dgvM.EnableHeadersVisualStyles = false;
            this.dgvM.GridColor = System.Drawing.Color.Teal;
            this.dgvM.HeaderBgColor = System.Drawing.Color.DarkCyan;
            this.dgvM.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dgvM.Location = new System.Drawing.Point(40, 224);
            this.dgvM.Name = "dgvM";
            this.dgvM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvM.Size = new System.Drawing.Size(261, 214);
            this.dgvM.TabIndex = 8;
            this.dgvM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMa_CellContentClick);
            this.dgvM.SelectionChanged += new System.EventHandler(this.dgvMa_SelectionChanged);
            // 
            // dgvTi
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dgvTi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.dgvTi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTi.DoubleBuffered = true;
            this.dgvTi.EnableHeadersVisualStyles = false;
            this.dgvTi.GridColor = System.Drawing.Color.Teal;
            this.dgvTi.HeaderBgColor = System.Drawing.Color.DarkCyan;
            this.dgvTi.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dgvTi.Location = new System.Drawing.Point(363, 224);
            this.dgvTi.Name = "dgvTi";
            this.dgvTi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTi.Size = new System.Drawing.Size(262, 214);
            this.dgvTi.TabIndex = 9;
            this.dgvTi.SelectionChanged += new System.EventHandler(this.dgvTi_SelectionChanged);
            // 
            // txtMarca
            // 
            this.txtMarca.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtMarca.Location = new System.Drawing.Point(54, 118);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(193, 26);
            this.txtMarca.TabIndex = 10;
            // 
            // lblMarcas
            // 
            this.lblMarcas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcas.ForeColor = System.Drawing.Color.Honeydew;
            this.lblMarcas.Location = new System.Drawing.Point(52, 83);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(113, 20);
            this.lblMarcas.TabIndex = 76;
            this.lblMarcas.Text = "&Nombre Marca";
            // 
            // btnNewM
            // 
            this.btnNewM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewM.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNewM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnNewM.Image = ((System.Drawing.Image)(resources.GetObject("btnNewM.Image")));
            this.btnNewM.ImageActive = null;
            this.btnNewM.Location = new System.Drawing.Point(52, 160);
            this.btnNewM.Name = "btnNewM";
            this.btnNewM.Size = new System.Drawing.Size(53, 46);
            this.btnNewM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNewM.TabIndex = 77;
            this.btnNewM.TabStop = false;
            this.btnNewM.Zoom = 10;
            this.btnNewM.Click += new System.EventHandler(this.btnNewM_Click);
            // 
            // btnUptM
            // 
            this.btnUptM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUptM.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUptM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnUptM.Enabled = false;
            this.btnUptM.Image = ((System.Drawing.Image)(resources.GetObject("btnUptM.Image")));
            this.btnUptM.ImageActive = null;
            this.btnUptM.Location = new System.Drawing.Point(121, 160);
            this.btnUptM.Name = "btnUptM";
            this.btnUptM.Size = new System.Drawing.Size(53, 46);
            this.btnUptM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUptM.TabIndex = 78;
            this.btnUptM.TabStop = false;
            this.btnUptM.Zoom = 10;
            this.btnUptM.Click += new System.EventHandler(this.btnUptM_Click);
            // 
            // btnElimM
            // 
            this.btnElimM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnElimM.BackColor = System.Drawing.Color.Crimson;
            this.btnElimM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnElimM.Image = ((System.Drawing.Image)(resources.GetObject("btnElimM.Image")));
            this.btnElimM.ImageActive = null;
            this.btnElimM.Location = new System.Drawing.Point(192, 160);
            this.btnElimM.Name = "btnElimM";
            this.btnElimM.Size = new System.Drawing.Size(53, 46);
            this.btnElimM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnElimM.TabIndex = 79;
            this.btnElimM.TabStop = false;
            this.btnElimM.Zoom = 10;
            this.btnElimM.Click += new System.EventHandler(this.btnElimM_Click);
            // 
            // btnElimT
            // 
            this.btnElimT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnElimT.BackColor = System.Drawing.Color.Crimson;
            this.btnElimT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnElimT.Image = ((System.Drawing.Image)(resources.GetObject("btnElimT.Image")));
            this.btnElimT.ImageActive = null;
            this.btnElimT.Location = new System.Drawing.Point(549, 160);
            this.btnElimT.Name = "btnElimT";
            this.btnElimT.Size = new System.Drawing.Size(53, 46);
            this.btnElimT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnElimT.TabIndex = 82;
            this.btnElimT.TabStop = false;
            this.btnElimT.Zoom = 10;
            this.btnElimT.Click += new System.EventHandler(this.btnElimT_Click);
            // 
            // btnUptT
            // 
            this.btnUptT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUptT.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUptT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnUptT.Image = ((System.Drawing.Image)(resources.GetObject("btnUptT.Image")));
            this.btnUptT.ImageActive = null;
            this.btnUptT.Location = new System.Drawing.Point(478, 160);
            this.btnUptT.Name = "btnUptT";
            this.btnUptT.Size = new System.Drawing.Size(53, 46);
            this.btnUptT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUptT.TabIndex = 81;
            this.btnUptT.TabStop = false;
            this.btnUptT.Zoom = 10;
            this.btnUptT.Click += new System.EventHandler(this.btnUptT_Click);
            // 
            // btnNewT
            // 
            this.btnNewT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewT.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNewT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnNewT.Image = ((System.Drawing.Image)(resources.GetObject("btnNewT.Image")));
            this.btnNewT.ImageActive = null;
            this.btnNewT.Location = new System.Drawing.Point(409, 160);
            this.btnNewT.Name = "btnNewT";
            this.btnNewT.Size = new System.Drawing.Size(53, 46);
            this.btnNewT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNewT.TabIndex = 80;
            this.btnNewT.TabStop = false;
            this.btnNewT.Zoom = 10;
            this.btnNewT.Click += new System.EventHandler(this.btnNewT_Click);
            // 
            // lblAgregarItems
            // 
            this.lblAgregarItems.AutoSize = true;
            this.lblAgregarItems.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarItems.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAgregarItems.Location = new System.Drawing.Point(54, 33);
            this.lblAgregarItems.Name = "lblAgregarItems";
            this.lblAgregarItems.Size = new System.Drawing.Size(158, 19);
            this.lblAgregarItems.TabIndex = 83;
            this.lblAgregarItems.Text = "GESTIONAR MARCA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(410, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 84;
            this.label1.Text = "GESTIONAR TIPO";
            // 
            // txtTipo
            // 
            this.txtTipo.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtTipo.Location = new System.Drawing.Point(408, 118);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(193, 26);
            this.txtTipo.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(408, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 86;
            this.label2.Text = "&Nombre Tipo";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(626, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 28);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 87;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmMarca
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAgregarItems);
            this.Controls.Add(this.btnElimT);
            this.Controls.Add(this.btnUptT);
            this.Controls.Add(this.btnNewT);
            this.Controls.Add(this.btnElimM);
            this.Controls.Add(this.btnUptM);
            this.Controls.Add(this.btnNewM);
            this.Controls.Add(this.lblMarcas);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.dgvTi);
            this.Controls.Add(this.dgvM);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMarca";
            ((System.ComponentModel.ISupportInitialize)(this.dgvM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUptM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnElimM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnElimT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUptT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuCustomDataGrid dgvM;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dgvTi;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtMarca;
        private System.Windows.Forms.Label lblMarcas;
        private Bunifu.Framework.UI.BunifuImageButton btnNewM;
        private Bunifu.Framework.UI.BunifuImageButton btnUptM;
        private Bunifu.Framework.UI.BunifuImageButton btnElimM;
        private Bunifu.Framework.UI.BunifuImageButton btnElimT;
        private Bunifu.Framework.UI.BunifuImageButton btnUptT;
        private Bunifu.Framework.UI.BunifuImageButton btnNewT;
        private System.Windows.Forms.Label lblAgregarItems;
        private System.Windows.Forms.Label label1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtTipo;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
    }
}