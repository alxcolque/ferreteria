namespace ferreteria_x_2019.Forms
{
    partial class frmModalGO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModalGO));
            this.btnNuevoCliente = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnGuardarC = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCancelarOrden = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.txtID_Clie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevoCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardarC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelarOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnNuevoCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnNuevoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoCliente.Image")));
            this.btnNuevoCliente.ImageActive = null;
            this.btnNuevoCliente.Location = new System.Drawing.Point(220, 34);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(60, 42);
            this.btnNuevoCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNuevoCliente.TabIndex = 11;
            this.btnNuevoCliente.TabStop = false;
            this.btnNuevoCliente.Zoom = 10;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnGuardarC
            // 
            this.btnGuardarC.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnGuardarC.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarC.Image")));
            this.btnGuardarC.ImageActive = null;
            this.btnGuardarC.Location = new System.Drawing.Point(191, 116);
            this.btnGuardarC.Name = "btnGuardarC";
            this.btnGuardarC.Size = new System.Drawing.Size(113, 49);
            this.btnGuardarC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGuardarC.TabIndex = 10;
            this.btnGuardarC.TabStop = false;
            this.btnGuardarC.Zoom = 10;
            this.btnGuardarC.Click += new System.EventHandler(this.btnGuardarC_Click);
            // 
            // btnCancelarOrden
            // 
            this.btnCancelarOrden.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelarOrden.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnCancelarOrden.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarOrden.Image")));
            this.btnCancelarOrden.ImageActive = null;
            this.btnCancelarOrden.Location = new System.Drawing.Point(38, 116);
            this.btnCancelarOrden.Name = "btnCancelarOrden";
            this.btnCancelarOrden.Size = new System.Drawing.Size(121, 49);
            this.btnCancelarOrden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancelarOrden.TabIndex = 9;
            this.btnCancelarOrden.TabStop = false;
            this.btnCancelarOrden.Zoom = 10;
            this.btnCancelarOrden.Click += new System.EventHandler(this.btnCancelarOrden_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seleccione Cliente";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(38, 47);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(176, 29);
            this.comboBoxCliente.TabIndex = 7;
            this.comboBoxCliente.SelectedIndexChanged += new System.EventHandler(this.comboBoxCliente_SelectedIndexChanged);
            // 
            // txtID_Clie
            // 
            this.txtID_Clie.Location = new System.Drawing.Point(114, 83);
            this.txtID_Clie.Name = "txtID_Clie";
            this.txtID_Clie.Size = new System.Drawing.Size(100, 27);
            this.txtID_Clie.TabIndex = 12;
            this.txtID_Clie.Text = "1";
            this.txtID_Clie.Visible = false;
            // 
            // frmModalGO
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(343, 221);
            this.Controls.Add(this.txtID_Clie);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.btnGuardarC);
            this.Controls.Add(this.btnCancelarOrden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCliente);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmModalGO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModalGO";
            this.Load += new System.EventHandler(this.frmModalGO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevoCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardarC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelarOrden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnNuevoCliente;
        private Bunifu.Framework.UI.BunifuImageButton btnGuardarC;
        private Bunifu.Framework.UI.BunifuImageButton btnCancelarOrden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.TextBox txtID_Clie;
    }
}