namespace SistemadeControlPoliciaco
{
    partial class calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculadora));
            this.txtPrevio = new System.Windows.Forms.TextBox();
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.btsum = new System.Windows.Forms.Button();
            this.btres = new System.Windows.Forms.Button();
            this.btmul = new System.Windows.Forms.Button();
            this.btigual = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btdiv = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.btc = new System.Windows.Forms.Button();
            this.btp = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.btce = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPrevio
            // 
            this.txtPrevio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPrevio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrevio.Enabled = false;
            this.txtPrevio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrevio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtPrevio.Location = new System.Drawing.Point(12, 43);
            this.txtPrevio.Margin = new System.Windows.Forms.Padding(0);
            this.txtPrevio.Name = "txtPrevio";
            this.txtPrevio.Size = new System.Drawing.Size(189, 14);
            this.txtPrevio.TabIndex = 43;
            this.txtPrevio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPantalla
            // 
            this.txtPantalla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPantalla.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPantalla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPantalla.Enabled = false;
            this.txtPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPantalla.ForeColor = System.Drawing.Color.Navy;
            this.txtPantalla.Location = new System.Drawing.Point(12, 57);
            this.txtPantalla.Margin = new System.Windows.Forms.Padding(0);
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.Size = new System.Drawing.Size(189, 24);
            this.txtPantalla.TabIndex = 42;
            this.txtPantalla.Text = "0";
            this.txtPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btsum
            // 
            this.btsum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsum.ForeColor = System.Drawing.Color.Navy;
            this.btsum.Location = new System.Drawing.Point(156, 194);
            this.btsum.Name = "btsum";
            this.btsum.Size = new System.Drawing.Size(45, 94);
            this.btsum.TabIndex = 41;
            this.btsum.Text = "+";
            this.btsum.UseVisualStyleBackColor = true;
            this.btsum.Click += new System.EventHandler(this.btsum_Click);
            // 
            // btres
            // 
            this.btres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btres.ForeColor = System.Drawing.Color.Navy;
            this.btres.Location = new System.Drawing.Point(156, 146);
            this.btres.Name = "btres";
            this.btres.Size = new System.Drawing.Size(45, 45);
            this.btres.TabIndex = 40;
            this.btres.Text = "-";
            this.btres.UseVisualStyleBackColor = true;
            this.btres.Click += new System.EventHandler(this.btres_Click);
            // 
            // btmul
            // 
            this.btmul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmul.ForeColor = System.Drawing.Color.Navy;
            this.btmul.Location = new System.Drawing.Point(156, 97);
            this.btmul.Name = "btmul";
            this.btmul.Size = new System.Drawing.Size(45, 45);
            this.btmul.TabIndex = 39;
            this.btmul.Text = "*";
            this.btmul.UseVisualStyleBackColor = true;
            this.btmul.Click += new System.EventHandler(this.btmul_Click);
            // 
            // btigual
            // 
            this.btigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btigual.Location = new System.Drawing.Point(108, 291);
            this.btigual.Name = "btigual";
            this.btigual.Size = new System.Drawing.Size(93, 45);
            this.btigual.TabIndex = 38;
            this.btigual.Text = "=";
            this.btigual.UseVisualStyleBackColor = true;
            this.btigual.Click += new System.EventHandler(this.btigual_Click);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt3.Location = new System.Drawing.Point(108, 243);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(45, 45);
            this.bt3.TabIndex = 37;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt6
            // 
            this.bt6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt6.Location = new System.Drawing.Point(108, 194);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(45, 45);
            this.bt6.TabIndex = 36;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = false;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt9
            // 
            this.bt9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt9.BackColor = System.Drawing.Color.Transparent;
            this.bt9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt9.BackgroundImage")));
            this.bt9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt9.Location = new System.Drawing.Point(108, 146);
            this.bt9.Margin = new System.Windows.Forms.Padding(0);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(45, 45);
            this.bt9.TabIndex = 35;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = false;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // btdiv
            // 
            this.btdiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdiv.ForeColor = System.Drawing.Color.Navy;
            this.btdiv.Location = new System.Drawing.Point(108, 97);
            this.btdiv.Name = "btdiv";
            this.btdiv.Size = new System.Drawing.Size(45, 45);
            this.btdiv.TabIndex = 34;
            this.btdiv.Text = "/";
            this.btdiv.UseVisualStyleBackColor = true;
            this.btdiv.Click += new System.EventHandler(this.btdiv_Click);
            // 
            // bt0
            // 
            this.bt0.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt0.Location = new System.Drawing.Point(60, 291);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(45, 45);
            this.bt0.TabIndex = 33;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = false;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt2.Location = new System.Drawing.Point(60, 243);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(45, 45);
            this.bt2.TabIndex = 32;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt5.Location = new System.Drawing.Point(60, 194);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(45, 45);
            this.bt5.TabIndex = 31;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt8
            // 
            this.bt8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt8.Location = new System.Drawing.Point(60, 146);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(45, 45);
            this.bt8.TabIndex = 30;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = false;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // btc
            // 
            this.btc.BackColor = System.Drawing.Color.Transparent;
            this.btc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btc.ForeColor = System.Drawing.Color.Red;
            this.btc.Location = new System.Drawing.Point(12, 97);
            this.btc.Name = "btc";
            this.btc.Size = new System.Drawing.Size(45, 45);
            this.btc.TabIndex = 29;
            this.btc.Text = "C";
            this.btc.UseVisualStyleBackColor = false;
            this.btc.Click += new System.EventHandler(this.btc_Click);
            // 
            // btp
            // 
            this.btp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btp.Location = new System.Drawing.Point(12, 291);
            this.btp.Name = "btp";
            this.btp.Size = new System.Drawing.Size(45, 45);
            this.btp.TabIndex = 28;
            this.btp.Text = ".";
            this.btp.UseVisualStyleBackColor = true;
            this.btp.Click += new System.EventHandler(this.btp_Click);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt1.Location = new System.Drawing.Point(12, 243);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(45, 45);
            this.bt1.TabIndex = 27;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt4.Location = new System.Drawing.Point(12, 194);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(45, 45);
            this.bt4.TabIndex = 26;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt7
            // 
            this.bt7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt7.Location = new System.Drawing.Point(12, 146);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(45, 45);
            this.bt7.TabIndex = 25;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = false;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // btce
            // 
            this.btce.BackColor = System.Drawing.Color.Transparent;
            this.btce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btce.Location = new System.Drawing.Point(60, 97);
            this.btce.Name = "btce";
            this.btce.Size = new System.Drawing.Size(45, 45);
            this.btce.TabIndex = 24;
            this.btce.Text = "CE";
            this.btce.UseVisualStyleBackColor = false;
            this.btce.Click += new System.EventHandler(this.btce_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(211, 24);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.toolStripSeparator4});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "&Editar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripMenuItem.Image")));
            this.copiarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copiarToolStripMenuItem.Text = "&Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pegarToolStripMenuItem.Image")));
            this.pegarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pegarToolStripMenuItem.Text = "&Pegar";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(148, 6);
            // 
            // calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 347);
            this.Controls.Add(this.txtPrevio);
            this.Controls.Add(this.txtPantalla);
            this.Controls.Add(this.btsum);
            this.Controls.Add(this.btres);
            this.Controls.Add(this.btmul);
            this.Controls.Add(this.btigual);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.btdiv);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.btc);
            this.Controls.Add(this.btp);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.btce);
            this.Controls.Add(this.menuStrip1);
            this.Name = "calculadora";
            this.Text = "calculadora";
            this.Load += new System.EventHandler(this.calculadora_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrevio;
        private System.Windows.Forms.TextBox txtPantalla;
        private System.Windows.Forms.Button btsum;
        private System.Windows.Forms.Button btres;
        private System.Windows.Forms.Button btmul;
        private System.Windows.Forms.Button btigual;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btdiv;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button btc;
        private System.Windows.Forms.Button btp;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button btce;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

    }
}