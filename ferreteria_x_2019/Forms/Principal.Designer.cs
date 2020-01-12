namespace ferreteria_x_2019
{
    partial class Principal
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTimer = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMaximizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRestaurar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlSidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGraficos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelAct = new System.Windows.Forms.Panel();
            this.btnDiarias = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPrincipal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStock = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnListprod = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPerfProducto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlCuerpo = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.curvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.curvaCerrar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tiempoReal = new System.Windows.Forms.Timer(this.components);
            this.animacion1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.animacion2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.pnlSuperior.Controls.Add(this.btnCerrar);
            this.pnlSuperior.Controls.Add(this.lblTimer);
            this.pnlSuperior.Controls.Add(this.btnMenu);
            this.pnlSuperior.Controls.Add(this.btnMaximizar);
            this.pnlSuperior.Controls.Add(this.btnRestaurar);
            this.pnlSuperior.Controls.Add(this.btnMinimizar);
            this.animacion2.SetDecoration(this.pnlSuperior, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.pnlSuperior, BunifuAnimatorNS.DecorationType.None);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1000, 46);
            this.pnlSuperior.TabIndex = 0;
            this.pnlSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSuperior_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.animacion2.SetDecoration(this.btnCerrar, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.btnCerrar, BunifuAnimatorNS.DecorationType.None);
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(968, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 26);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimer.AutoSize = true;
            this.animacion1.SetDecoration(this.lblTimer, BunifuAnimatorNS.DecorationType.None);
            this.animacion2.SetDecoration(this.lblTimer, BunifuAnimatorNS.DecorationType.None);
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(798, 16);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(82, 16);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "HH:MM:SS";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacion2.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(30, 10);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(25, 25);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 13;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.animacion2.SetDecoration(this.btnMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.btnMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.ImageActive = null;
            this.btnMaximizar.Location = new System.Drawing.Point(916, 12);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(20, 20);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMaximizar.TabIndex = 12;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Zoom = 10;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackColor = System.Drawing.Color.Transparent;
            this.animacion2.SetDecoration(this.btnRestaurar, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.btnRestaurar, BunifuAnimatorNS.DecorationType.None);
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.ImageActive = null;
            this.btnRestaurar.Location = new System.Drawing.Point(916, 12);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(20, 20);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRestaurar.TabIndex = 11;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Zoom = 10;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.animacion2.SetDecoration(this.btnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.btnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.ImageActive = null;
            this.btnMinimizar.Location = new System.Drawing.Point(942, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 10;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Zoom = 10;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.pnlLeft.Controls.Add(this.pnlSidebar);
            this.animacion2.SetDecoration(this.pnlLeft, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.pnlLeft, BunifuAnimatorNS.DecorationType.None);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 46);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 654);
            this.pnlLeft.TabIndex = 1;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSidebar.BackgroundImage")));
            this.pnlSidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSidebar.Controls.Add(this.lblAdmin);
            this.pnlSidebar.Controls.Add(this.pictureBox1);
            this.pnlSidebar.Controls.Add(this.btnGraficos);
            this.pnlSidebar.Controls.Add(this.panelAct);
            this.pnlSidebar.Controls.Add(this.btnDiarias);
            this.pnlSidebar.Controls.Add(this.btnPrincipal);
            this.pnlSidebar.Controls.Add(this.btnStock);
            this.pnlSidebar.Controls.Add(this.btnListprod);
            this.pnlSidebar.Controls.Add(this.btnPerfProducto);
            this.animacion2.SetDecoration(this.pnlSidebar, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.pnlSidebar, BunifuAnimatorNS.DecorationType.None);
            this.pnlSidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.pnlSidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.pnlSidebar.GradientTopLeft = System.Drawing.SystemColors.HotTrack;
            this.pnlSidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.pnlSidebar.Location = new System.Drawing.Point(9, 3);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Quality = 10;
            this.pnlSidebar.Size = new System.Drawing.Size(182, 648);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.animacion1.SetDecoration(this.lblAdmin, BunifuAnimatorNS.DecorationType.None);
            this.animacion2.SetDecoration(this.lblAdmin, BunifuAnimatorNS.DecorationType.None);
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAdmin.Location = new System.Drawing.Point(72, 29);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(75, 25);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.animacion1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.animacion2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnGraficos
            // 
            this.btnGraficos.Activecolor = System.Drawing.Color.Transparent;
            this.btnGraficos.BackColor = System.Drawing.Color.Transparent;
            this.btnGraficos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGraficos.BorderRadius = 0;
            this.btnGraficos.ButtonText = "    Gráficos";
            this.btnGraficos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacion2.SetDecoration(this.btnGraficos, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.btnGraficos, BunifuAnimatorNS.DecorationType.None);
            this.btnGraficos.DisabledColor = System.Drawing.Color.Gray;
            this.btnGraficos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGraficos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGraficos.Iconimage")));
            this.btnGraficos.Iconimage_right = null;
            this.btnGraficos.Iconimage_right_Selected = null;
            this.btnGraficos.Iconimage_Selected = null;
            this.btnGraficos.IconMarginLeft = 0;
            this.btnGraficos.IconMarginRight = 0;
            this.btnGraficos.IconRightVisible = true;
            this.btnGraficos.IconRightZoom = 0D;
            this.btnGraficos.IconVisible = true;
            this.btnGraficos.IconZoom = 90D;
            this.btnGraficos.IsTab = false;
            this.btnGraficos.Location = new System.Drawing.Point(14, 446);
            this.btnGraficos.Name = "btnGraficos";
            this.btnGraficos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnGraficos.OnHovercolor = System.Drawing.Color.Crimson;
            this.btnGraficos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGraficos.selected = false;
            this.btnGraficos.Size = new System.Drawing.Size(168, 48);
            this.btnGraficos.TabIndex = 15;
            this.btnGraficos.Text = "    Gráficos";
            this.btnGraficos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGraficos.Textcolor = System.Drawing.Color.White;
            this.btnGraficos.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficos.Click += new System.EventHandler(this.btnGraficos_Click);
            // 
            // panelAct
            // 
            this.panelAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.animacion2.SetDecoration(this.panelAct, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.panelAct, BunifuAnimatorNS.DecorationType.None);
            this.panelAct.Location = new System.Drawing.Point(3, 99);
            this.panelAct.Name = "panelAct";
            this.panelAct.Size = new System.Drawing.Size(10, 48);
            this.panelAct.TabIndex = 14;
            this.panelAct.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAct_Paint);
            // 
            // btnDiarias
            // 
            this.btnDiarias.Activecolor = System.Drawing.Color.Transparent;
            this.btnDiarias.BackColor = System.Drawing.Color.Transparent;
            this.btnDiarias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDiarias.BorderRadius = 0;
            this.btnDiarias.ButtonText = "      VENTAS";
            this.btnDiarias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacion2.SetDecoration(this.btnDiarias, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.btnDiarias, BunifuAnimatorNS.DecorationType.None);
            this.btnDiarias.DisabledColor = System.Drawing.Color.Gray;
            this.btnDiarias.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDiarias.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDiarias.Iconimage")));
            this.btnDiarias.Iconimage_right = null;
            this.btnDiarias.Iconimage_right_Selected = null;
            this.btnDiarias.Iconimage_Selected = null;
            this.btnDiarias.IconMarginLeft = 0;
            this.btnDiarias.IconMarginRight = 0;
            this.btnDiarias.IconRightVisible = true;
            this.btnDiarias.IconRightZoom = 0D;
            this.btnDiarias.IconVisible = true;
            this.btnDiarias.IconZoom = 90D;
            this.btnDiarias.IsTab = false;
            this.btnDiarias.Location = new System.Drawing.Point(7, 372);
            this.btnDiarias.Name = "btnDiarias";
            this.btnDiarias.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDiarias.OnHovercolor = System.Drawing.Color.Crimson;
            this.btnDiarias.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDiarias.selected = false;
            this.btnDiarias.Size = new System.Drawing.Size(179, 48);
            this.btnDiarias.TabIndex = 12;
            this.btnDiarias.Text = "      VENTAS";
            this.btnDiarias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiarias.Textcolor = System.Drawing.Color.White;
            this.btnDiarias.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiarias.Click += new System.EventHandler(this.btnDiarias_Click);
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Activecolor = System.Drawing.Color.Transparent;
            this.btnPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btnPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrincipal.BorderRadius = 0;
            this.btnPrincipal.ButtonText = "      PRINCIPAL";
            this.btnPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacion2.SetDecoration(this.btnPrincipal, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.btnPrincipal, BunifuAnimatorNS.DecorationType.None);
            this.btnPrincipal.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrincipal.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrincipal.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPrincipal.Iconimage")));
            this.btnPrincipal.Iconimage_right = null;
            this.btnPrincipal.Iconimage_right_Selected = null;
            this.btnPrincipal.Iconimage_Selected = null;
            this.btnPrincipal.IconMarginLeft = 0;
            this.btnPrincipal.IconMarginRight = 0;
            this.btnPrincipal.IconRightVisible = true;
            this.btnPrincipal.IconRightZoom = 0D;
            this.btnPrincipal.IconVisible = true;
            this.btnPrincipal.IconZoom = 90D;
            this.btnPrincipal.IsTab = false;
            this.btnPrincipal.Location = new System.Drawing.Point(7, 98);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPrincipal.OnHovercolor = System.Drawing.Color.Crimson;
            this.btnPrincipal.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrincipal.selected = false;
            this.btnPrincipal.Size = new System.Drawing.Size(179, 48);
            this.btnPrincipal.TabIndex = 8;
            this.btnPrincipal.Text = "      PRINCIPAL";
            this.btnPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrincipal.Textcolor = System.Drawing.Color.White;
            this.btnPrincipal.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // btnStock
            // 
            this.btnStock.Activecolor = System.Drawing.Color.Transparent;
            this.btnStock.BackColor = System.Drawing.Color.Transparent;
            this.btnStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStock.BorderRadius = 0;
            this.btnStock.ButtonText = "      &CLIENTES";
            this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacion2.SetDecoration(this.btnStock, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.btnStock, BunifuAnimatorNS.DecorationType.None);
            this.btnStock.DisabledColor = System.Drawing.Color.Gray;
            this.btnStock.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStock.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStock.Iconimage")));
            this.btnStock.Iconimage_right = null;
            this.btnStock.Iconimage_right_Selected = null;
            this.btnStock.Iconimage_Selected = null;
            this.btnStock.IconMarginLeft = 0;
            this.btnStock.IconMarginRight = 0;
            this.btnStock.IconRightVisible = true;
            this.btnStock.IconRightZoom = 0D;
            this.btnStock.IconVisible = true;
            this.btnStock.IconZoom = 90D;
            this.btnStock.IsTab = false;
            this.btnStock.Location = new System.Drawing.Point(8, 302);
            this.btnStock.Name = "btnStock";
            this.btnStock.Normalcolor = System.Drawing.Color.Transparent;
            this.btnStock.OnHovercolor = System.Drawing.Color.Crimson;
            this.btnStock.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStock.selected = false;
            this.btnStock.Size = new System.Drawing.Size(176, 48);
            this.btnStock.TabIndex = 11;
            this.btnStock.Text = "      &CLIENTES";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Textcolor = System.Drawing.Color.White;
            this.btnStock.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnListprod
            // 
            this.btnListprod.Activecolor = System.Drawing.Color.Transparent;
            this.btnListprod.BackColor = System.Drawing.Color.Transparent;
            this.btnListprod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListprod.BorderRadius = 0;
            this.btnListprod.ButtonText = "      ITEMS";
            this.btnListprod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacion2.SetDecoration(this.btnListprod, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.btnListprod, BunifuAnimatorNS.DecorationType.None);
            this.btnListprod.DisabledColor = System.Drawing.Color.Gray;
            this.btnListprod.Iconcolor = System.Drawing.Color.Transparent;
            this.btnListprod.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnListprod.Iconimage")));
            this.btnListprod.Iconimage_right = null;
            this.btnListprod.Iconimage_right_Selected = null;
            this.btnListprod.Iconimage_Selected = null;
            this.btnListprod.IconMarginLeft = 0;
            this.btnListprod.IconMarginRight = 0;
            this.btnListprod.IconRightVisible = true;
            this.btnListprod.IconRightZoom = 0D;
            this.btnListprod.IconVisible = true;
            this.btnListprod.IconZoom = 90D;
            this.btnListprod.IsTab = false;
            this.btnListprod.Location = new System.Drawing.Point(10, 162);
            this.btnListprod.Name = "btnListprod";
            this.btnListprod.Normalcolor = System.Drawing.Color.Transparent;
            this.btnListprod.OnHovercolor = System.Drawing.Color.Crimson;
            this.btnListprod.OnHoverTextColor = System.Drawing.Color.White;
            this.btnListprod.selected = false;
            this.btnListprod.Size = new System.Drawing.Size(173, 48);
            this.btnListprod.TabIndex = 9;
            this.btnListprod.Text = "      ITEMS";
            this.btnListprod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListprod.Textcolor = System.Drawing.Color.White;
            this.btnListprod.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListprod.Click += new System.EventHandler(this.btnListprod_Click);
            // 
            // btnPerfProducto
            // 
            this.btnPerfProducto.Activecolor = System.Drawing.Color.Transparent;
            this.btnPerfProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnPerfProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPerfProducto.BorderRadius = 0;
            this.btnPerfProducto.ButtonText = "      PERFIL ITEMS";
            this.btnPerfProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animacion2.SetDecoration(this.btnPerfProducto, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.btnPerfProducto, BunifuAnimatorNS.DecorationType.None);
            this.btnPerfProducto.DisabledColor = System.Drawing.Color.Gray;
            this.btnPerfProducto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPerfProducto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPerfProducto.Iconimage")));
            this.btnPerfProducto.Iconimage_right = null;
            this.btnPerfProducto.Iconimage_right_Selected = null;
            this.btnPerfProducto.Iconimage_Selected = null;
            this.btnPerfProducto.IconMarginLeft = 0;
            this.btnPerfProducto.IconMarginRight = 0;
            this.btnPerfProducto.IconRightVisible = true;
            this.btnPerfProducto.IconRightZoom = 0D;
            this.btnPerfProducto.IconVisible = true;
            this.btnPerfProducto.IconZoom = 90D;
            this.btnPerfProducto.IsTab = false;
            this.btnPerfProducto.Location = new System.Drawing.Point(8, 232);
            this.btnPerfProducto.Name = "btnPerfProducto";
            this.btnPerfProducto.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPerfProducto.OnHovercolor = System.Drawing.Color.Crimson;
            this.btnPerfProducto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPerfProducto.selected = false;
            this.btnPerfProducto.Size = new System.Drawing.Size(176, 48);
            this.btnPerfProducto.TabIndex = 10;
            this.btnPerfProducto.Text = "      PERFIL ITEMS";
            this.btnPerfProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfProducto.Textcolor = System.Drawing.Color.White;
            this.btnPerfProducto.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfProducto.Click += new System.EventHandler(this.btnPerfProducto_Click);
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.animacion2.SetDecoration(this.pnlCuerpo, BunifuAnimatorNS.DecorationType.None);
            this.animacion1.SetDecoration(this.pnlCuerpo, BunifuAnimatorNS.DecorationType.None);
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpo.ForeColor = System.Drawing.Color.Black;
            this.pnlCuerpo.Location = new System.Drawing.Point(200, 46);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Size = new System.Drawing.Size(800, 654);
            this.pnlCuerpo.TabIndex = 2;
            this.pnlCuerpo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCuerpo_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // curvaSidebar
            // 
            this.curvaSidebar.ElipseRadius = 10;
            this.curvaSidebar.TargetControl = this.pnlSidebar;
            // 
            // curvaCerrar
            // 
            this.curvaCerrar.ElipseRadius = 20;
            this.curvaCerrar.TargetControl = this.btnCerrar;
            // 
            // tiempoReal
            // 
            this.tiempoReal.Tick += new System.EventHandler(this.tiempoReal_Tick);
            // 
            // animacion1
            // 
            this.animacion1.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.animacion1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 1;
            animation2.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 2F;
            animation2.TransparencyCoeff = 0F;
            this.animacion1.DefaultAnimation = animation2;
            // 
            // animacion2
            // 
            this.animacion2.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.animacion2.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.animacion2.DefaultAnimation = animation1;
            // 
            // Principal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.pnlCuerpo);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlSuperior);
            this.animacion1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animacion2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlCuerpo;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private Bunifu.Framework.UI.BunifuImageButton btnMaximizar;
        private Bunifu.Framework.UI.BunifuImageButton btnRestaurar;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrincipal;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnDiarias;
        private Bunifu.Framework.UI.BunifuFlatButton btnStock;
        private Bunifu.Framework.UI.BunifuFlatButton btnPerfProducto;
        private Bunifu.Framework.UI.BunifuFlatButton btnListprod;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTimer;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlSidebar;
        private Bunifu.Framework.UI.BunifuElipse curvaSidebar;
        private Bunifu.Framework.UI.BunifuElipse curvaCerrar;
        private System.Windows.Forms.Panel panelAct;
        private System.Windows.Forms.Timer tiempoReal;
        private Bunifu.Framework.UI.BunifuFlatButton btnGraficos;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BunifuAnimatorNS.BunifuTransition animacion1;
        private BunifuAnimatorNS.BunifuTransition animacion2;
    }
}