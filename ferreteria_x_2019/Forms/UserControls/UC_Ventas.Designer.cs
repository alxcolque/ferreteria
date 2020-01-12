namespace ferreteria_x_2019.UC_Inicio
{
    partial class UC_Ventas
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Ventas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVentas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.curvaBuscar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnDV = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVaciarVenta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 47);
            this.panel1.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "/ Ventas";
            // 
            // dgvVentas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(65)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVentas.DoubleBuffered = true;
            this.dgvVentas.EnableHeadersVisualStyles = false;
            this.dgvVentas.HeaderBgColor = System.Drawing.Color.DodgerBlue;
            this.dgvVentas.HeaderForeColor = System.Drawing.Color.White;
            this.dgvVentas.Location = new System.Drawing.Point(95, 157);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVentas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVentas.Size = new System.Drawing.Size(603, 447);
            this.dgvVentas.TabIndex = 70;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nro";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cliente";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha Venta";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscar.BackColor = System.Drawing.Color.Silver;
            this.txtBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscar.BackgroundImage")));
            this.txtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBuscar.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscar.Icon")));
            this.txtBuscar.Location = new System.Drawing.Point(515, 97);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(178, 39);
            this.txtBuscar.TabIndex = 73;
            this.txtBuscar.text = "Buscar";
            // 
            // curvaBuscar
            // 
            this.curvaBuscar.ElipseRadius = 10;
            this.curvaBuscar.TargetControl = this.txtBuscar;
            // 
            // btnDV
            // 
            this.btnDV.Activecolor = System.Drawing.Color.Teal;
            this.btnDV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDV.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDV.BorderRadius = 0;
            this.btnDV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnDV.ButtonText = "Detalle de venta";
            this.btnDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDV.DisabledColor = System.Drawing.Color.Gray;
            this.btnDV.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDV.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDV.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDV.Iconimage")));
            this.btnDV.Iconimage_right = null;
            this.btnDV.Iconimage_right_Selected = null;
            this.btnDV.Iconimage_Selected = null;
            this.btnDV.IconMarginLeft = 0;
            this.btnDV.IconMarginRight = 0;
            this.btnDV.IconRightVisible = true;
            this.btnDV.IconRightZoom = 0D;
            this.btnDV.IconVisible = true;
            this.btnDV.IconZoom = 50D;
            this.btnDV.IsTab = false;
            this.btnDV.Location = new System.Drawing.Point(95, 90);
            this.btnDV.Margin = new System.Windows.Forms.Padding(5);
            this.btnDV.Name = "btnDV";
            this.btnDV.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnDV.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDV.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDV.selected = false;
            this.btnDV.Size = new System.Drawing.Size(200, 46);
            this.btnDV.TabIndex = 75;
            this.btnDV.Text = "Detalle de venta";
            this.btnDV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDV.Textcolor = System.Drawing.Color.White;
            this.btnDV.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDV.Click += new System.EventHandler(this.btnDV_Click);
            // 
            // btnVaciarVenta
            // 
            this.btnVaciarVenta.Activecolor = System.Drawing.Color.Teal;
            this.btnVaciarVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVaciarVenta.BackColor = System.Drawing.Color.Crimson;
            this.btnVaciarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVaciarVenta.BorderRadius = 0;
            this.btnVaciarVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnVaciarVenta.ButtonText = "Vaciar Ventas";
            this.btnVaciarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaciarVenta.DisabledColor = System.Drawing.Color.Gray;
            this.btnVaciarVenta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaciarVenta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVaciarVenta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVaciarVenta.Iconimage")));
            this.btnVaciarVenta.Iconimage_right = null;
            this.btnVaciarVenta.Iconimage_right_Selected = null;
            this.btnVaciarVenta.Iconimage_Selected = null;
            this.btnVaciarVenta.IconMarginLeft = 0;
            this.btnVaciarVenta.IconMarginRight = 0;
            this.btnVaciarVenta.IconRightVisible = true;
            this.btnVaciarVenta.IconRightZoom = 0D;
            this.btnVaciarVenta.IconVisible = true;
            this.btnVaciarVenta.IconZoom = 50D;
            this.btnVaciarVenta.IsTab = false;
            this.btnVaciarVenta.Location = new System.Drawing.Point(328, 90);
            this.btnVaciarVenta.Margin = new System.Windows.Forms.Padding(5);
            this.btnVaciarVenta.Name = "btnVaciarVenta";
            this.btnVaciarVenta.Normalcolor = System.Drawing.Color.Crimson;
            this.btnVaciarVenta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVaciarVenta.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVaciarVenta.selected = false;
            this.btnVaciarVenta.Size = new System.Drawing.Size(177, 46);
            this.btnVaciarVenta.TabIndex = 76;
            this.btnVaciarVenta.Text = "Vaciar Ventas";
            this.btnVaciarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVaciarVenta.Textcolor = System.Drawing.Color.White;
            this.btnVaciarVenta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaciarVenta.Click += new System.EventHandler(this.btnVaciarVenta_Click);
            // 
            // UC_Ventas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.btnVaciarVenta);
            this.Controls.Add(this.btnDV);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvVentas);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_Ventas";
            this.Size = new System.Drawing.Size(800, 654);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvVentas;
        public Bunifu.Framework.UI.BunifuTextbox txtBuscar;
        private Bunifu.Framework.UI.BunifuElipse curvaBuscar;
        private Bunifu.Framework.UI.BunifuFlatButton btnDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Bunifu.Framework.UI.BunifuFlatButton btnVaciarVenta;
    }
}
