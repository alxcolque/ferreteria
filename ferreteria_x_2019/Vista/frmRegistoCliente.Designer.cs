namespace ferreteria_x_2019.Forms
{
    partial class frmRegistoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistoCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnGuardarCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTel = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCli = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.curvaForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.curvaBoton = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 53);
            this.panel1.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(19, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(67, 19);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "CLIENTE";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(362, 11);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 28);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGuardarCliente.BackColor = System.Drawing.Color.Crimson;
            this.btnGuardarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarCliente.BorderRadius = 0;
            this.btnGuardarCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnGuardarCliente.ButtonText = "Guardar Datos";
            this.btnGuardarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCliente.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardarCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardarCliente.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardarCliente.Iconimage")));
            this.btnGuardarCliente.Iconimage_right = null;
            this.btnGuardarCliente.Iconimage_right_Selected = null;
            this.btnGuardarCliente.Iconimage_Selected = null;
            this.btnGuardarCliente.IconMarginLeft = 0;
            this.btnGuardarCliente.IconMarginRight = 0;
            this.btnGuardarCliente.IconRightVisible = true;
            this.btnGuardarCliente.IconRightZoom = 0D;
            this.btnGuardarCliente.IconVisible = true;
            this.btnGuardarCliente.IconZoom = 50D;
            this.btnGuardarCliente.IsTab = false;
            this.btnGuardarCliente.Location = new System.Drawing.Point(75, 245);
            this.btnGuardarCliente.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Normalcolor = System.Drawing.Color.Crimson;
            this.btnGuardarCliente.OnHovercolor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardarCliente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardarCliente.selected = false;
            this.btnGuardarCliente.Size = new System.Drawing.Size(254, 48);
            this.btnGuardarCliente.TabIndex = 19;
            this.btnGuardarCliente.Text = "Guardar Datos";
            this.btnGuardarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCliente.Textcolor = System.Drawing.Color.White;
            this.btnGuardarCliente.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Número de Celular/telegram/WhatsApp";
            // 
            // txtTel
            // 
            this.txtTel.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(75, 185);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(254, 26);
            this.txtTel.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre del Cliente";
            // 
            // txtNombreCli
            // 
            this.txtNombreCli.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtNombreCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCli.Location = new System.Drawing.Point(75, 122);
            this.txtNombreCli.Name = "txtNombreCli";
            this.txtNombreCli.Size = new System.Drawing.Size(254, 26);
            this.txtNombreCli.TabIndex = 11;
            // 
            // curvaForm
            // 
            this.curvaForm.ElipseRadius = 20;
            this.curvaForm.TargetControl = this;
            // 
            // curvaBoton
            // 
            this.curvaBoton.ElipseRadius = 45;
            this.curvaBoton.TargetControl = this.btnGuardarCliente;
            // 
            // frmRegistoCliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(400, 335);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuardarCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreCli);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistoCliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardarCliente;
        private System.Windows.Forms.Label label3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtTel;
        private System.Windows.Forms.Label label2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtNombreCli;
        private Bunifu.Framework.UI.BunifuElipse curvaForm;
        private Bunifu.Framework.UI.BunifuElipse curvaBoton;
    }
}