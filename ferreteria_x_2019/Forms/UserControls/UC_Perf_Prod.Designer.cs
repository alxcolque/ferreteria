namespace ferreteria_x_2019.UC_Inicio
{
    partial class UC_Perf_Prod
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Perf_Prod));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStock = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddStock = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Eliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 47);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "/ Control de Productos";
            // 
            // dgvStock
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
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
            this.dgvStock.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStock.DoubleBuffered = true;
            this.dgvStock.EnableHeadersVisualStyles = false;
            this.dgvStock.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.dgvStock.HeaderForeColor = System.Drawing.Color.White;
            this.dgvStock.Location = new System.Drawing.Point(51, 159);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStock.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStock.Size = new System.Drawing.Size(692, 460);
            this.dgvStock.TabIndex = 73;
            this.dgvStock.SelectionChanged += new System.EventHandler(this.dgvStock_SelectionChanged);
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
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Fecha";
            this.Column6.Name = "Column6";
            // 
            // btnAddStock
            // 
            this.btnAddStock.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddStock.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddStock.BorderRadius = 0;
            this.btnAddStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnAddStock.ButtonText = "Agregar Stock";
            this.btnAddStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStock.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStock.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddStock.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddStock.Iconimage")));
            this.btnAddStock.Iconimage_right = null;
            this.btnAddStock.Iconimage_right_Selected = null;
            this.btnAddStock.Iconimage_Selected = null;
            this.btnAddStock.IconMarginLeft = 0;
            this.btnAddStock.IconMarginRight = 0;
            this.btnAddStock.IconRightVisible = true;
            this.btnAddStock.IconRightZoom = 0D;
            this.btnAddStock.IconVisible = true;
            this.btnAddStock.IconZoom = 50D;
            this.btnAddStock.IsTab = false;
            this.btnAddStock.Location = new System.Drawing.Point(51, 94);
            this.btnAddStock.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Normalcolor = System.Drawing.Color.ForestGreen;
            this.btnAddStock.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddStock.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddStock.selected = false;
            this.btnAddStock.Size = new System.Drawing.Size(162, 44);
            this.btnAddStock.TabIndex = 74;
            this.btnAddStock.Text = "Agregar Stock";
            this.btnAddStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStock.Textcolor = System.Drawing.Color.White;
            this.btnAddStock.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
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
            this.Eliminar.Location = new System.Drawing.Point(223, 94);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(5);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Normalcolor = System.Drawing.Color.Crimson;
            this.Eliminar.OnHovercolor = System.Drawing.Color.PaleVioletRed;
            this.Eliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.Eliminar.selected = false;
            this.Eliminar.Size = new System.Drawing.Size(135, 46);
            this.Eliminar.TabIndex = 75;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminar.Textcolor = System.Drawing.Color.White;
            this.Eliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // UC_Perf_Prod
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_Perf_Prod";
            this.Size = new System.Drawing.Size(800, 654);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddStock;
        private Bunifu.Framework.UI.BunifuFlatButton Eliminar;
    }
}
