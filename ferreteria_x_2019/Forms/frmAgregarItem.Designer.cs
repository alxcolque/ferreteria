namespace ferreteria_x_2019.Forms
{
    partial class frmAgregarItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarItem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitleItem = new System.Windows.Forms.Label();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtArt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbxTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCod = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnGuardarArticulos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.curvaForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.curvaBoton = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cmbxMarca = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.lblTitleItem);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 53);
            this.panel1.TabIndex = 0;
            // 
            // lblTitleItem
            // 
            this.lblTitleItem.AutoSize = true;
            this.lblTitleItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleItem.Location = new System.Drawing.Point(19, 18);
            this.lblTitleItem.Name = "lblTitleItem";
            this.lblTitleItem.Size = new System.Drawing.Size(173, 19);
            this.lblTitleItem.TabIndex = 9;
            this.lblTitleItem.Text = "GESTIONAR ARTICULO";
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
            // txtArt
            // 
            this.txtArt.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtArt.Location = new System.Drawing.Point(70, 107);
            this.txtArt.Name = "txtArt";
            this.txtArt.Size = new System.Drawing.Size(254, 27);
            this.txtArt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre del Artículo";
            // 
            // cmbxTipo
            // 
            this.cmbxTipo.FormattingEnabled = true;
            this.cmbxTipo.Location = new System.Drawing.Point(70, 287);
            this.cmbxTipo.Name = "cmbxTipo";
            this.cmbxTipo.Size = new System.Drawing.Size(254, 29);
            this.cmbxTipo.TabIndex = 4;
            this.cmbxTipo.SelectedIndexChanged += new System.EventHandler(this.cmbxTipo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtPrecio.Location = new System.Drawing.Point(70, 161);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(254, 27);
            this.txtPrecio.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Código";
            // 
            // txtCod
            // 
            this.txtCod.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtCod.Location = new System.Drawing.Point(70, 224);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(254, 27);
            this.txtCod.TabIndex = 7;
            // 
            // btnGuardarArticulos
            // 
            this.btnGuardarArticulos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGuardarArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGuardarArticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarArticulos.BorderRadius = 0;
            this.btnGuardarArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnGuardarArticulos.ButtonText = "Guardar Datos";
            this.btnGuardarArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarArticulos.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardarArticulos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarArticulos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardarArticulos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardarArticulos.Iconimage")));
            this.btnGuardarArticulos.Iconimage_right = null;
            this.btnGuardarArticulos.Iconimage_right_Selected = null;
            this.btnGuardarArticulos.Iconimage_Selected = null;
            this.btnGuardarArticulos.IconMarginLeft = 0;
            this.btnGuardarArticulos.IconMarginRight = 0;
            this.btnGuardarArticulos.IconRightVisible = true;
            this.btnGuardarArticulos.IconRightZoom = 0D;
            this.btnGuardarArticulos.IconVisible = true;
            this.btnGuardarArticulos.IconZoom = 50D;
            this.btnGuardarArticulos.IsTab = false;
            this.btnGuardarArticulos.Location = new System.Drawing.Point(193, 390);
            this.btnGuardarArticulos.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardarArticulos.Name = "btnGuardarArticulos";
            this.btnGuardarArticulos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGuardarArticulos.OnHovercolor = System.Drawing.Color.Teal;
            this.btnGuardarArticulos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardarArticulos.selected = false;
            this.btnGuardarArticulos.Size = new System.Drawing.Size(193, 46);
            this.btnGuardarArticulos.TabIndex = 9;
            this.btnGuardarArticulos.Text = "Guardar Datos";
            this.btnGuardarArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarArticulos.Textcolor = System.Drawing.Color.White;
            this.btnGuardarArticulos.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarArticulos.Click += new System.EventHandler(this.btnGuardarArticulos_Click);
            // 
            // curvaForm
            // 
            this.curvaForm.ElipseRadius = 20;
            this.curvaForm.TargetControl = this;
            // 
            // curvaBoton
            // 
            this.curvaBoton.ElipseRadius = 45;
            this.curvaBoton.TargetControl = this.btnGuardarArticulos;
            // 
            // cmbxMarca
            // 
            this.cmbxMarca.FormattingEnabled = true;
            this.cmbxMarca.Location = new System.Drawing.Point(70, 353);
            this.cmbxMarca.Name = "cmbxMarca";
            this.cmbxMarca.Size = new System.Drawing.Size(254, 29);
            this.cmbxMarca.TabIndex = 10;
            this.cmbxMarca.SelectedIndexChanged += new System.EventHandler(this.cmbxMarca_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Seleccione marca";
            // 
            // frmAgregarItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbxMarca);
            this.Controls.Add(this.btnGuardarArticulos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cmbxTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArt);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarItem";
            this.Load += new System.EventHandler(this.frmAgregarItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private System.Windows.Forms.Label lblTitleItem;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtArt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbxTipo;
        private System.Windows.Forms.Label label3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtPrecio;
        private System.Windows.Forms.Label label4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtCod;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardarArticulos;
        private Bunifu.Framework.UI.BunifuElipse curvaForm;
        private Bunifu.Framework.UI.BunifuElipse curvaBoton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbxMarca;
    }
}