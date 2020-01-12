namespace ferreteria_x_2019.UC_Inicio
{
    partial class UC_Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Items));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTipos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.btnAgregarItems = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvItems = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnModificar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Eliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.lblTipos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblMarcas);
            this.panel1.Location = new System.Drawing.Point(18, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 47);
            this.panel1.TabIndex = 0;
            // 
            // lblTipos
            // 
            this.lblTipos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipos.AutoSize = true;
            this.lblTipos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipos.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTipos.Location = new System.Drawing.Point(210, 13);
            this.lblTipos.Name = "lblTipos";
            this.lblTipos.Size = new System.Drawing.Size(77, 20);
            this.lblTipos.TabIndex = 76;
            this.lblTipos.Text = "/    &Tipos";
            this.lblTipos.Click += new System.EventHandler(this.lblTipos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "/ Productos";
            // 
            // lblMarcas
            // 
            this.lblMarcas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcas.ForeColor = System.Drawing.Color.DarkGray;
            this.lblMarcas.Location = new System.Drawing.Point(118, 14);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(82, 20);
            this.lblMarcas.TabIndex = 75;
            this.lblMarcas.Text = "/  &Marcas";
            this.lblMarcas.Click += new System.EventHandler(this.lblMarcas_Click);
            // 
            // btnAgregarItems
            // 
            this.btnAgregarItems.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAgregarItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarItems.BackColor = System.Drawing.Color.Green;
            this.btnAgregarItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarItems.BorderRadius = 0;
            this.btnAgregarItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnAgregarItems.ButtonText = "Agregar Items";
            this.btnAgregarItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarItems.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarItems.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarItems.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregarItems.Iconimage")));
            this.btnAgregarItems.Iconimage_right = null;
            this.btnAgregarItems.Iconimage_right_Selected = null;
            this.btnAgregarItems.Iconimage_Selected = null;
            this.btnAgregarItems.IconMarginLeft = 0;
            this.btnAgregarItems.IconMarginRight = 0;
            this.btnAgregarItems.IconRightVisible = true;
            this.btnAgregarItems.IconRightZoom = 0D;
            this.btnAgregarItems.IconVisible = true;
            this.btnAgregarItems.IconZoom = 50D;
            this.btnAgregarItems.IsTab = false;
            this.btnAgregarItems.Location = new System.Drawing.Point(25, 105);
            this.btnAgregarItems.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregarItems.Name = "btnAgregarItems";
            this.btnAgregarItems.Normalcolor = System.Drawing.Color.Green;
            this.btnAgregarItems.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregarItems.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarItems.selected = false;
            this.btnAgregarItems.Size = new System.Drawing.Size(172, 44);
            this.btnAgregarItems.TabIndex = 63;
            this.btnAgregarItems.Text = "Agregar Items";
            this.btnAgregarItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarItems.Textcolor = System.Drawing.Color.White;
            this.btnAgregarItems.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarItems.Click += new System.EventHandler(this.btnAgregarItems_Click);
            // 
            // dgvItems
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(65)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItems.DoubleBuffered = true;
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.dgvItems.HeaderForeColor = System.Drawing.Color.White;
            this.dgvItems.Location = new System.Drawing.Point(59, 161);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvItems.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItems.Size = new System.Drawing.Size(678, 465);
            this.dgvItems.TabIndex = 72;
            // 
            // btnModificar
            // 
            this.btnModificar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.BorderRadius = 0;
            this.btnModificar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnModificar.ButtonText = "Modificar";
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.DisabledColor = System.Drawing.Color.Gray;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnModificar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnModificar.Iconimage")));
            this.btnModificar.Iconimage_right = null;
            this.btnModificar.Iconimage_right_Selected = null;
            this.btnModificar.Iconimage_Selected = null;
            this.btnModificar.IconMarginLeft = 0;
            this.btnModificar.IconMarginRight = 0;
            this.btnModificar.IconRightVisible = true;
            this.btnModificar.IconRightZoom = 0D;
            this.btnModificar.IconVisible = true;
            this.btnModificar.IconZoom = 50D;
            this.btnModificar.IsTab = false;
            this.btnModificar.Location = new System.Drawing.Point(207, 105);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnModificar.OnHovercolor = System.Drawing.Color.DeepSkyBlue;
            this.btnModificar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnModificar.selected = false;
            this.btnModificar.Size = new System.Drawing.Size(163, 46);
            this.btnModificar.TabIndex = 73;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Textcolor = System.Drawing.Color.White;
            this.btnModificar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Eliminar.BackColor = System.Drawing.Color.Crimson;
            this.Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Eliminar.BorderRadius = 0;
            this.Eliminar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Eliminar.ButtonText = "Eliminar";
            this.Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Eliminar.DisabledColor = System.Drawing.Color.Gray;
            this.Eliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.Eliminar.Iconimage = ((System.Drawing.Image)(resources.GetObject("Eliminar.Iconimage")));
            this.Eliminar.Iconimage_right = null;
            this.Eliminar.Iconimage_right_Selected = null;
            this.Eliminar.Iconimage_Selected = null;
            this.Eliminar.IconMarginLeft = 0;
            this.Eliminar.IconMarginRight = 0;
            this.Eliminar.IconRightVisible = true;
            this.Eliminar.IconRightZoom = 0D;
            this.Eliminar.IconVisible = true;
            this.Eliminar.IconZoom = 50D;
            this.Eliminar.IsTab = false;
            this.Eliminar.Location = new System.Drawing.Point(380, 105);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(5);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Normalcolor = System.Drawing.Color.Crimson;
            this.Eliminar.OnHovercolor = System.Drawing.Color.PaleVioletRed;
            this.Eliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.Eliminar.selected = false;
            this.Eliminar.Size = new System.Drawing.Size(163, 46);
            this.Eliminar.TabIndex = 74;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminar.Textcolor = System.Drawing.Color.White;
            this.Eliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Artículo";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tipo";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Marca";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Precio U.";
            this.Column6.Name = "Column6";
            // 
            // UC_Items
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.btnAgregarItems);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_Items";
            this.Size = new System.Drawing.Size(800, 654);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarItems;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvItems;
        private Bunifu.Framework.UI.BunifuFlatButton btnModificar;
        private Bunifu.Framework.UI.BunifuFlatButton Eliminar;
        private System.Windows.Forms.Label lblMarcas;
        private System.Windows.Forms.Label lblTipos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
