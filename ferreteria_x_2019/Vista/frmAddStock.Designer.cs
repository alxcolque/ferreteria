namespace ferreteria_x_2019.Forms
{
    partial class frmAddStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStock));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitleItem = new System.Windows.Forms.Label();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnGuardarStock = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCant = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.curvaForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.curvaBoton = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cmbxArt = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblTitleItem);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 53);
            this.panel1.TabIndex = 12;
            // 
            // lblTitleItem
            // 
            this.lblTitleItem.AutoSize = true;
            this.lblTitleItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleItem.Location = new System.Drawing.Point(19, 18);
            this.lblTitleItem.Name = "lblTitleItem";
            this.lblTitleItem.Size = new System.Drawing.Size(149, 19);
            this.lblTitleItem.TabIndex = 9;
            this.lblTitleItem.Text = "GESTIONAR STOCK";
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
            // btnGuardarStock
            // 
            this.btnGuardarStock.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGuardarStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGuardarStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarStock.BorderRadius = 0;
            this.btnGuardarStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnGuardarStock.ButtonText = "Guardar Datos";
            this.btnGuardarStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarStock.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardarStock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarStock.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardarStock.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardarStock.Iconimage")));
            this.btnGuardarStock.Iconimage_right = null;
            this.btnGuardarStock.Iconimage_right_Selected = null;
            this.btnGuardarStock.Iconimage_Selected = null;
            this.btnGuardarStock.IconMarginLeft = 0;
            this.btnGuardarStock.IconMarginRight = 0;
            this.btnGuardarStock.IconRightVisible = true;
            this.btnGuardarStock.IconRightZoom = 0D;
            this.btnGuardarStock.IconVisible = true;
            this.btnGuardarStock.IconZoom = 50D;
            this.btnGuardarStock.IsTab = false;
            this.btnGuardarStock.Location = new System.Drawing.Point(184, 398);
            this.btnGuardarStock.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardarStock.Name = "btnGuardarStock";
            this.btnGuardarStock.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGuardarStock.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGuardarStock.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardarStock.selected = false;
            this.btnGuardarStock.Size = new System.Drawing.Size(193, 46);
            this.btnGuardarStock.TabIndex = 21;
            this.btnGuardarStock.Text = "Guardar Datos";
            this.btnGuardarStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarStock.Textcolor = System.Drawing.Color.White;
            this.btnGuardarStock.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarStock.Click += new System.EventHandler(this.btnGuardarStock_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cantidad";
            // 
            // txtCant
            // 
            this.txtCant.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtCant.Location = new System.Drawing.Point(70, 173);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(254, 26);
            this.txtCant.TabIndex = 13;
            // 
            // curvaForm
            // 
            this.curvaForm.ElipseRadius = 20;
            this.curvaForm.TargetControl = this;
            // 
            // curvaBoton
            // 
            this.curvaBoton.ElipseRadius = 45;
            this.curvaBoton.TargetControl = this.btnGuardarStock;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Seleccione un Artículo";
            // 
            // cmbxArt
            // 
            this.cmbxArt.FormattingEnabled = true;
            this.cmbxArt.Location = new System.Drawing.Point(70, 108);
            this.cmbxArt.Name = "cmbxArt";
            this.cmbxArt.Size = new System.Drawing.Size(254, 28);
            this.cmbxArt.TabIndex = 22;
            this.cmbxArt.SelectedIndexChanged += new System.EventHandler(this.cmbxArt_SelectedIndexChanged);
            this.cmbxArt.Click += new System.EventHandler(this.cmbxArt_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(94, 224);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 24;
            // 
            // frmAddStock
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(400, 458);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuardarStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbxArt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddStock";
            this.Load += new System.EventHandler(this.frmAddStock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitleItem;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardarStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtCant;
        private Bunifu.Framework.UI.BunifuElipse curvaForm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbxArt;
        private Bunifu.Framework.UI.BunifuElipse curvaBoton;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}