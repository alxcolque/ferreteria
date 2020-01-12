namespace ferreteria_x_2019.Forms
{
    partial class Modal_Add_Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modal_Add_Cart));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnCancelarOrden = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnProcesar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblItemsSel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelarOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcesar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESE LA CANTIDAD PARA:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtCantidad.Location = new System.Drawing.Point(77, 75);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(174, 26);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.Text = "1";
            // 
            // btnCancelarOrden
            // 
            this.btnCancelarOrden.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelarOrden.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnCancelarOrden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarOrden.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarOrden.Image")));
            this.btnCancelarOrden.ImageActive = null;
            this.btnCancelarOrden.Location = new System.Drawing.Point(33, 121);
            this.btnCancelarOrden.Name = "btnCancelarOrden";
            this.btnCancelarOrden.Size = new System.Drawing.Size(113, 49);
            this.btnCancelarOrden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancelarOrden.TabIndex = 4;
            this.btnCancelarOrden.TabStop = false;
            this.btnCancelarOrden.Zoom = 10;
            this.btnCancelarOrden.Click += new System.EventHandler(this.btnCancelarOrden_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnProcesar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnProcesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcesar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcesar.Image")));
            this.btnProcesar.ImageActive = null;
            this.btnProcesar.Location = new System.Drawing.Point(196, 121);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(113, 49);
            this.btnProcesar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnProcesar.TabIndex = 5;
            this.btnProcesar.TabStop = false;
            this.btnProcesar.Zoom = 10;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // lblItemsSel
            // 
            this.lblItemsSel.AutoSize = true;
            this.lblItemsSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsSel.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblItemsSel.Location = new System.Drawing.Point(83, 42);
            this.lblItemsSel.Name = "lblItemsSel";
            this.lblItemsSel.Size = new System.Drawing.Size(63, 20);
            this.lblItemsSel.TabIndex = 6;
            this.lblItemsSel.Text = "ITEMS";
            // 
            // Modal_Add_Cart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(342, 219);
            this.Controls.Add(this.lblItemsSel);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.btnCancelarOrden);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modal_Add_Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modal_Add_Cart";
            this.Load += new System.EventHandler(this.Modal_Add_Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelarOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcesar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtCantidad;
        private Bunifu.Framework.UI.BunifuImageButton btnCancelarOrden;
        private Bunifu.Framework.UI.BunifuImageButton btnProcesar;
        private System.Windows.Forms.Label lblItemsSel;
    }
}