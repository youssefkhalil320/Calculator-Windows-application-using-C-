namespace Dashboard
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.exit_btn = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btndivide = new Guna.UI2.WinForms.Guna2Button();
            this.btnadd = new Guna.UI2.WinForms.Guna2Button();
            this.btnsub = new Guna.UI2.WinForms.Guna2Button();
            this.btnequal = new Guna.UI2.WinForms.Guna2Button();
            this.btnthree = new Guna.UI2.WinForms.Guna2Button();
            this.btnsix = new Guna.UI2.WinForms.Guna2Button();
            this.btnmod = new Guna.UI2.WinForms.Guna2Button();
            this.btndot = new Guna.UI2.WinForms.Guna2Button();
            this.btntwo = new Guna.UI2.WinForms.Guna2Button();
            this.btnfive = new Guna.UI2.WinForms.Guna2Button();
            this.btnzero = new Guna.UI2.WinForms.Guna2Button();
            this.btnone = new Guna.UI2.WinForms.Guna2Button();
            this.btnfour = new Guna.UI2.WinForms.Guna2Button();
            this.btnclear = new Guna.UI2.WinForms.Guna2Button();
            this.btnseven = new Guna.UI2.WinForms.Guna2Button();
            this.btneight = new Guna.UI2.WinForms.Guna2Button();
            this.btnnine = new Guna.UI2.WinForms.Guna2Button();
            this.btnmult = new Guna.UI2.WinForms.Guna2Button();
            this.textstore = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtresult = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_btn
            // 
            this.exit_btn.Image = ((System.Drawing.Image)(resources.GetObject("exit_btn.Image")));
            this.exit_btn.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Vertical;
            this.exit_btn.ImageRotate = 90F;
            this.exit_btn.Location = new System.Drawing.Point(333, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exit_btn.Size = new System.Drawing.Size(39, 38);
            this.exit_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit_btn.TabIndex = 0;
            this.exit_btn.TabStop = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lbl.Location = new System.Drawing.Point(3, 5);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(124, 33);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Calculator";
            this.lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // btndivide
            // 
            this.btndivide.BackColor = System.Drawing.Color.Transparent;
            this.btndivide.BorderRadius = 15;
            this.btndivide.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndivide.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndivide.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndivide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndivide.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btndivide.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btndivide.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btndivide.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btndivide.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btndivide.Location = new System.Drawing.Point(272, 238);
            this.btndivide.Name = "btndivide";
            this.btndivide.ShadowDecoration.BorderRadius = 15;
            this.btndivide.ShadowDecoration.Color = System.Drawing.Color.LightSkyBlue;
            this.btndivide.ShadowDecoration.Enabled = true;
            this.btndivide.Size = new System.Drawing.Size(56, 45);
            this.btndivide.TabIndex = 2;
            this.btndivide.Text = "/";
            this.btndivide.Click += new System.EventHandler(this.btndivide_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Transparent;
            this.btnadd.BorderRadius = 15;
            this.btnadd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnadd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnadd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnadd.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnadd.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnadd.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnadd.Location = new System.Drawing.Point(272, 363);
            this.btnadd.Name = "btnadd";
            this.btnadd.ShadowDecoration.BorderRadius = 15;
            this.btnadd.ShadowDecoration.Color = System.Drawing.Color.LightSkyBlue;
            this.btnadd.ShadowDecoration.Enabled = true;
            this.btnadd.Size = new System.Drawing.Size(56, 45);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "+";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsub
            // 
            this.btnsub.BackColor = System.Drawing.Color.Transparent;
            this.btnsub.BorderRadius = 15;
            this.btnsub.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsub.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsub.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsub.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsub.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnsub.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnsub.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnsub.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnsub.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnsub.Location = new System.Drawing.Point(272, 425);
            this.btnsub.Name = "btnsub";
            this.btnsub.ShadowDecoration.BorderRadius = 15;
            this.btnsub.ShadowDecoration.Color = System.Drawing.Color.LightSkyBlue;
            this.btnsub.ShadowDecoration.Enabled = true;
            this.btnsub.Size = new System.Drawing.Size(56, 45);
            this.btnsub.TabIndex = 4;
            this.btnsub.Text = "-";
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btnequal
            // 
            this.btnequal.BackColor = System.Drawing.Color.Transparent;
            this.btnequal.BorderRadius = 15;
            this.btnequal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnequal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnequal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnequal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnequal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnequal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnequal.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnequal.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnequal.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnequal.Location = new System.Drawing.Point(189, 487);
            this.btnequal.Name = "btnequal";
            this.btnequal.ShadowDecoration.BorderRadius = 15;
            this.btnequal.ShadowDecoration.Color = System.Drawing.Color.LightSkyBlue;
            this.btnequal.ShadowDecoration.Enabled = true;
            this.btnequal.Size = new System.Drawing.Size(139, 45);
            this.btnequal.TabIndex = 9;
            this.btnequal.Text = "=";
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // btnthree
            // 
            this.btnthree.BackColor = System.Drawing.Color.Transparent;
            this.btnthree.BorderRadius = 15;
            this.btnthree.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthree.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthree.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthree.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthree.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnthree.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnthree.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnthree.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnthree.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnthree.Location = new System.Drawing.Point(189, 427);
            this.btnthree.Name = "btnthree";
            this.btnthree.ShadowDecoration.BorderRadius = 15;
            this.btnthree.ShadowDecoration.Color = System.Drawing.Color.LightSkyBlue;
            this.btnthree.ShadowDecoration.Enabled = true;
            this.btnthree.Size = new System.Drawing.Size(56, 45);
            this.btnthree.TabIndex = 8;
            this.btnthree.Text = "3";
            this.btnthree.Click += new System.EventHandler(this.btnthree_Click);
            // 
            // btnsix
            // 
            this.btnsix.BackColor = System.Drawing.Color.Transparent;
            this.btnsix.BorderRadius = 15;
            this.btnsix.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsix.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsix.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnsix.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnsix.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnsix.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnsix.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnsix.Location = new System.Drawing.Point(189, 362);
            this.btnsix.Name = "btnsix";
            this.btnsix.ShadowDecoration.BorderRadius = 15;
            this.btnsix.ShadowDecoration.Color = System.Drawing.Color.LightSkyBlue;
            this.btnsix.ShadowDecoration.Enabled = true;
            this.btnsix.Size = new System.Drawing.Size(56, 45);
            this.btnsix.TabIndex = 7;
            this.btnsix.Text = "6";
            this.btnsix.Click += new System.EventHandler(this.btnsix_Click);
            // 
            // btnmod
            // 
            this.btnmod.BackColor = System.Drawing.Color.Transparent;
            this.btnmod.BorderRadius = 15;
            this.btnmod.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmod.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnmod.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnmod.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnmod.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnmod.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnmod.Location = new System.Drawing.Point(189, 238);
            this.btnmod.Name = "btnmod";
            this.btnmod.ShadowDecoration.BorderRadius = 15;
            this.btnmod.ShadowDecoration.Color = System.Drawing.Color.LightSkyBlue;
            this.btnmod.ShadowDecoration.Enabled = true;
            this.btnmod.Size = new System.Drawing.Size(56, 45);
            this.btnmod.TabIndex = 6;
            this.btnmod.Text = "%";
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // btndot
            // 
            this.btndot.BackColor = System.Drawing.Color.Transparent;
            this.btndot.BorderRadius = 15;
            this.btndot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndot.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btndot.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btndot.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btndot.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btndot.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btndot.Location = new System.Drawing.Point(110, 488);
            this.btndot.Name = "btndot";
            this.btndot.ShadowDecoration.BorderRadius = 15;
            this.btndot.ShadowDecoration.Color = System.Drawing.Color.LightSkyBlue;
            this.btndot.ShadowDecoration.Enabled = true;
            this.btndot.Size = new System.Drawing.Size(56, 45);
            this.btndot.TabIndex = 13;
            this.btndot.Text = ".";
            this.btndot.Click += new System.EventHandler(this.btndot_Click);
            // 
            // btntwo
            // 
            this.btntwo.BackColor = System.Drawing.Color.Transparent;
            this.btntwo.BorderRadius = 15;
            this.btntwo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntwo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntwo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntwo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntwo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btntwo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btntwo.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btntwo.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btntwo.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btntwo.Location = new System.Drawing.Point(110, 427);
            this.btntwo.Name = "btntwo";
            this.btntwo.ShadowDecoration.BorderRadius = 15;
            this.btntwo.ShadowDecoration.Color = System.Drawing.Color.LightSkyBlue;
            this.btntwo.ShadowDecoration.Enabled = true;
            this.btntwo.Size = new System.Drawing.Size(56, 45);
            this.btntwo.TabIndex = 12;
            this.btntwo.Text = "2";
            this.btntwo.Click += new System.EventHandler(this.btntwo_Click);
            // 
            // btnfive
            // 
            this.btnfive.BackColor = System.Drawing.Color.Transparent;
            this.btnfive.BorderRadius = 15;
            this.btnfive.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnfive.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnfive.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnfive.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnfive.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnfive.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnfive.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnfive.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnfive.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnfive.Location = new System.Drawing.Point(110, 362);
            this.btnfive.Name = "btnfive";
            this.btnfive.ShadowDecoration.BorderRadius = 15;
            this.btnfive.ShadowDecoration.Color = System.Drawing.Color.LightSkyBlue;
            this.btnfive.ShadowDecoration.Enabled = true;
            this.btnfive.Size = new System.Drawing.Size(56, 45);
            this.btnfive.TabIndex = 11;
            this.btnfive.Text = "5";
            this.btnfive.Click += new System.EventHandler(this.btnfive_Click);
            // 
            // btnzero
            // 
            this.btnzero.BackColor = System.Drawing.Color.Transparent;
            this.btnzero.BorderRadius = 15;
            this.btnzero.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnzero.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnzero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnzero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnzero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnzero.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnzero.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnzero.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnzero.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnzero.Location = new System.Drawing.Point(32, 488);
            this.btnzero.Name = "btnzero";
            this.btnzero.ShadowDecoration.BorderRadius = 15;
            this.btnzero.ShadowDecoration.Color = System.Drawing.Color.LightSkyBlue;
            this.btnzero.ShadowDecoration.Enabled = true;
            this.btnzero.Size = new System.Drawing.Size(56, 45);
            this.btnzero.TabIndex = 17;
            this.btnzero.Text = "0";
            this.btnzero.Click += new System.EventHandler(this.btnzero_Click);
            // 
            // btnone
            // 
            this.btnone.BackColor = System.Drawing.Color.Transparent;
            this.btnone.BorderRadius = 15;
            this.btnone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnone.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnone.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnone.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnone.Location = new System.Drawing.Point(32, 427);
            this.btnone.Name = "btnone";
            this.btnone.ShadowDecoration.BorderRadius = 15;
            this.btnone.ShadowDecoration.Color = System.Drawing.Color.LightSkyBlue;
            this.btnone.ShadowDecoration.Enabled = true;
            this.btnone.Size = new System.Drawing.Size(56, 45);
            this.btnone.TabIndex = 16;
            this.btnone.Text = "1";
            this.btnone.Click += new System.EventHandler(this.btnone_Click);
            // 
            // btnfour
            // 
            this.btnfour.BackColor = System.Drawing.Color.Transparent;
            this.btnfour.BorderRadius = 15;
            this.btnfour.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnfour.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnfour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnfour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnfour.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnfour.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnfour.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnfour.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnfour.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnfour.Location = new System.Drawing.Point(32, 362);
            this.btnfour.Name = "btnfour";
            this.btnfour.ShadowDecoration.BorderRadius = 15;
            this.btnfour.ShadowDecoration.Color = System.Drawing.Color.LightSkyBlue;
            this.btnfour.ShadowDecoration.Enabled = true;
            this.btnfour.Size = new System.Drawing.Size(56, 45);
            this.btnfour.TabIndex = 15;
            this.btnfour.Text = "4";
            this.btnfour.Click += new System.EventHandler(this.btnfour_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Transparent;
            this.btnclear.BorderRadius = 15;
            this.btnclear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnclear.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnclear.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnclear.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnclear.Location = new System.Drawing.Point(32, 238);
            this.btnclear.Name = "btnclear";
            this.btnclear.ShadowDecoration.BorderRadius = 15;
            this.btnclear.ShadowDecoration.Color = System.Drawing.Color.LightSkyBlue;
            this.btnclear.ShadowDecoration.Enabled = true;
            this.btnclear.Size = new System.Drawing.Size(134, 45);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "C";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnseven
            // 
            this.btnseven.BackColor = System.Drawing.Color.Transparent;
            this.btnseven.BorderRadius = 15;
            this.btnseven.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnseven.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnseven.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnseven.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnseven.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnseven.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnseven.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnseven.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnseven.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnseven.Location = new System.Drawing.Point(32, 301);
            this.btnseven.Name = "btnseven";
            this.btnseven.ShadowDecoration.BorderRadius = 15;
            this.btnseven.ShadowDecoration.Color = System.Drawing.Color.LightSkyBlue;
            this.btnseven.ShadowDecoration.Enabled = true;
            this.btnseven.Size = new System.Drawing.Size(56, 45);
            this.btnseven.TabIndex = 21;
            this.btnseven.Text = "7";
            this.btnseven.Click += new System.EventHandler(this.btnseven_Click);
            // 
            // btneight
            // 
            this.btneight.BackColor = System.Drawing.Color.Transparent;
            this.btneight.BorderRadius = 15;
            this.btneight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btneight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btneight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btneight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btneight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btneight.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btneight.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btneight.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btneight.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btneight.Location = new System.Drawing.Point(110, 301);
            this.btneight.Name = "btneight";
            this.btneight.ShadowDecoration.BorderRadius = 15;
            this.btneight.ShadowDecoration.Color = System.Drawing.Color.LightSkyBlue;
            this.btneight.ShadowDecoration.Enabled = true;
            this.btneight.Size = new System.Drawing.Size(56, 45);
            this.btneight.TabIndex = 20;
            this.btneight.Text = "8";
            this.btneight.Click += new System.EventHandler(this.btneight_Click);
            // 
            // btnnine
            // 
            this.btnnine.BackColor = System.Drawing.Color.Transparent;
            this.btnnine.BorderRadius = 15;
            this.btnnine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnnine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnnine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnnine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnnine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnnine.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnnine.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnnine.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnnine.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnnine.Location = new System.Drawing.Point(189, 301);
            this.btnnine.Name = "btnnine";
            this.btnnine.ShadowDecoration.BorderRadius = 15;
            this.btnnine.ShadowDecoration.Color = System.Drawing.Color.LightSkyBlue;
            this.btnnine.ShadowDecoration.Enabled = true;
            this.btnnine.Size = new System.Drawing.Size(56, 45);
            this.btnnine.TabIndex = 19;
            this.btnnine.Text = "9";
            this.btnnine.Click += new System.EventHandler(this.btnnine_Click);
            // 
            // btnmult
            // 
            this.btnmult.BackColor = System.Drawing.Color.Transparent;
            this.btnmult.BorderRadius = 15;
            this.btnmult.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmult.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmult.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmult.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmult.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnmult.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnmult.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnmult.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnmult.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnmult.Location = new System.Drawing.Point(272, 302);
            this.btnmult.Name = "btnmult";
            this.btnmult.ShadowDecoration.BorderRadius = 15;
            this.btnmult.ShadowDecoration.Color = System.Drawing.Color.LightSkyBlue;
            this.btnmult.ShadowDecoration.Enabled = true;
            this.btnmult.Size = new System.Drawing.Size(56, 45);
            this.btnmult.TabIndex = 18;
            this.btnmult.Text = "x";
            this.btnmult.Click += new System.EventHandler(this.btnmult_Click);
            // 
            // textstore
            // 
            this.textstore.BorderThickness = 0;
            this.textstore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textstore.DefaultText = "";
            this.textstore.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textstore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textstore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textstore.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textstore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.textstore.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textstore.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.textstore.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textstore.Location = new System.Drawing.Point(32, 145);
            this.textstore.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textstore.Name = "textstore";
            this.textstore.PasswordChar = '\0';
            this.textstore.PlaceholderText = "";
            this.textstore.SelectedText = "";
            this.textstore.Size = new System.Drawing.Size(296, 67);
            this.textstore.TabIndex = 22;
            this.textstore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtresult
            // 
            this.txtresult.BorderThickness = 0;
            this.txtresult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtresult.DefaultText = "";
            this.txtresult.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtresult.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtresult.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtresult.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtresult.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtresult.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtresult.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.txtresult.ForeColor = System.Drawing.Color.White;
            this.txtresult.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtresult.Location = new System.Drawing.Point(32, 42);
            this.txtresult.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtresult.Name = "txtresult";
            this.txtresult.PasswordChar = '\0';
            this.txtresult.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtresult.PlaceholderText = "0";
            this.txtresult.SelectedText = "";
            this.txtresult.Size = new System.Drawing.Size(296, 89);
            this.txtresult.TabIndex = 23;
            this.txtresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(373, 577);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.textstore);
            this.Controls.Add(this.btnseven);
            this.Controls.Add(this.btneight);
            this.Controls.Add(this.btnnine);
            this.Controls.Add(this.btnmult);
            this.Controls.Add(this.btnzero);
            this.Controls.Add(this.btnone);
            this.Controls.Add(this.btnfour);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndot);
            this.Controls.Add(this.btntwo);
            this.Controls.Add(this.btnfive);
            this.Controls.Add(this.btnequal);
            this.Controls.Add(this.btnthree);
            this.Controls.Add(this.btnsix);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btndivide);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.exit_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox exit_btn;
        private System.Windows.Forms.Label lbl;
        private Guna.UI2.WinForms.Guna2Button btndivide;
        private Guna.UI2.WinForms.Guna2Button btnadd;
        private Guna.UI2.WinForms.Guna2Button btnsub;
        private Guna.UI2.WinForms.Guna2Button btnequal;
        private Guna.UI2.WinForms.Guna2Button btnthree;
        private Guna.UI2.WinForms.Guna2Button btnsix;
        private Guna.UI2.WinForms.Guna2Button btnmod;
        private Guna.UI2.WinForms.Guna2Button btndot;
        private Guna.UI2.WinForms.Guna2Button btntwo;
        private Guna.UI2.WinForms.Guna2Button btnfive;
        private Guna.UI2.WinForms.Guna2Button btnzero;
        private Guna.UI2.WinForms.Guna2Button btnone;
        private Guna.UI2.WinForms.Guna2Button btnfour;
        private Guna.UI2.WinForms.Guna2Button btnclear;
        private Guna.UI2.WinForms.Guna2Button btnseven;
        private Guna.UI2.WinForms.Guna2Button btneight;
        private Guna.UI2.WinForms.Guna2Button btnnine;
        private Guna.UI2.WinForms.Guna2Button btnmult;
        private Guna.UI2.WinForms.Guna2TextBox textstore;
        private Guna.UI2.WinForms.Guna2TextBox txtresult;
    }
}

