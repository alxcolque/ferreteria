namespace ferreteria_x_2019.Vista
{
    partial class frmAddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddItem));
            this.curvaBoton = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnGuardarItem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.curvaForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblTitleItem = new System.Windows.Forms.Label();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbxTipo = new System.Windows.Forms.ComboBox();
            this.txtItem = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxMarca = new System.Windows.Forms.ComboBox();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // curvaBoton
            // 
            this.curvaBoton.ElipseRadius = 15;
            this.curvaBoton.TargetControl = this.btnGuardarItem;
            // 
            // btnGuardarItem
            // 
            this.btnGuardarItem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGuardarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGuardarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarItem.BorderRadius = 0;
            this.btnGuardarItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnGuardarItem.ButtonText = "Guardar Datos";
            this.btnGuardarItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarItem.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarItem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardarItem.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardarItem.Iconimage")));
            this.btnGuardarItem.Iconimage_right = null;
            this.btnGuardarItem.Iconimage_right_Selected = null;
            this.btnGuardarItem.Iconimage_Selected = null;
            this.btnGuardarItem.IconMarginLeft = 0;
            this.btnGuardarItem.IconMarginRight = 0;
            this.btnGuardarItem.IconRightVisible = true;
            this.btnGuardarItem.IconRightZoom = 0D;
            this.btnGuardarItem.IconVisible = true;
            this.btnGuardarItem.IconZoom = 50D;
            this.btnGuardarItem.IsTab = false;
            this.btnGuardarItem.Location = new System.Drawing.Point(181, 430);
            this.btnGuardarItem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGuardarItem.Name = "btnGuardarItem";
            this.btnGuardarItem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGuardarItem.OnHovercolor = System.Drawing.Color.Teal;
            this.btnGuardarItem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardarItem.selected = false;
            this.btnGuardarItem.Size = new System.Drawing.Size(193, 42);
            this.btnGuardarItem.TabIndex = 45;
            this.btnGuardarItem.Text = "Guardar Datos";
            this.btnGuardarItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarItem.Textcolor = System.Drawing.Color.White;
            this.btnGuardarItem.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarItem.Click += new System.EventHandler(this.btnGuardarItem_Click);
            // 
            // curvaForm
            // 
            this.curvaForm.ElipseRadius = 20;
            this.curvaForm.TargetControl = this;
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.pnlSuperior.Controls.Add(this.lblTitleItem);
            this.pnlSuperior.Controls.Add(this.btnCerrar);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(400, 53);
            this.pnlSuperior.TabIndex = 39;
            this.pnlSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSuperior_MouseDown_1);
            // 
            // lblTitleItem
            // 
            this.lblTitleItem.AutoSize = true;
            this.lblTitleItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleItem.Location = new System.Drawing.Point(19, 18);
            this.lblTitleItem.Name = "lblTitleItem";
            this.lblTitleItem.Size = new System.Drawing.Size(207, 20);
            this.lblTitleItem.TabIndex = 9;
            this.lblTitleItem.Text = "GESTIONAR ARTICULO";
            this.lblTitleItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitleItem_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(361, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 28);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "Precio (Utilice la coma para punto decimal)";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(69, 149);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(254, 24);
            this.txtPrecio.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nombre del Item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 18);
            this.label5.TabIndex = 47;
            this.label5.Text = "Seleccione Tipo";
            // 
            // cmbxTipo
            // 
            this.cmbxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxTipo.FormattingEnabled = true;
            this.cmbxTipo.Location = new System.Drawing.Point(69, 373);
            this.cmbxTipo.Name = "cmbxTipo";
            this.cmbxTipo.Size = new System.Drawing.Size(254, 26);
            this.cmbxTipo.TabIndex = 46;
            this.cmbxTipo.SelectedIndexChanged += new System.EventHandler(this.cmbxTipo_SelectedIndexChanged);
            // 
            // txtItem
            // 
            this.txtItem.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(69, 93);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(254, 24);
            this.txtItem.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 49;
            this.label1.Text = "Seleccione Tipo";
            // 
            // cmbxMarca
            // 
            this.cmbxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxMarca.FormattingEnabled = true;
            this.cmbxMarca.Location = new System.Drawing.Point(73, 239);
            this.cmbxMarca.Name = "cmbxMarca";
            this.cmbxMarca.Size = new System.Drawing.Size(254, 26);
            this.cmbxMarca.TabIndex = 48;
            this.cmbxMarca.SelectedIndexChanged += new System.EventHandler(this.cmbxMarca_SelectedIndexChanged);
            // 
            // frmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 479);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxMarca);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.btnGuardarItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbxTipo);
            this.Controls.Add(this.txtItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddItem";
            this.Text = "frmAddItem";
            this.Load += new System.EventHandler(this.frmAddItem_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse curvaBoton;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardarItem;
        private Bunifu.Framework.UI.BunifuElipse curvaForm;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblTitleItem;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private System.Windows.Forms.Label label3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbxTipo;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxMarca;
    }
}