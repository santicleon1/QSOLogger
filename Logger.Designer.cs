namespace QSOLogger
{
    partial class Logger
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
            this.oznaka = new System.Windows.Forms.TextBox();
            this.s_rst = new System.Windows.Forms.TextBox();
            this.r_rst = new System.Windows.Forms.TextBox();
            this.vrijeme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lokator = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.veze_log = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stanicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.band = new System.Windows.Forms.ComboBox();
            this.mod = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.frekvencija = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // oznaka
            // 
            this.oznaka.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.oznaka.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oznaka.Location = new System.Drawing.Point(10, 105);
            this.oznaka.Name = "oznaka";
            this.oznaka.Size = new System.Drawing.Size(134, 32);
            this.oznaka.TabIndex = 2;
            this.oznaka.Text = "LB100XCS";
            this.oznaka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.oznaka.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Unesi_vezu);
            // 
            // s_rst
            // 
            this.s_rst.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.s_rst.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.s_rst.Location = new System.Drawing.Point(150, 105);
            this.s_rst.Name = "s_rst";
            this.s_rst.Size = new System.Drawing.Size(69, 32);
            this.s_rst.TabIndex = 3;
            this.s_rst.Text = "59";
            this.s_rst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.s_rst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Unesi_vezu);
            // 
            // r_rst
            // 
            this.r_rst.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.r_rst.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.r_rst.Location = new System.Drawing.Point(225, 105);
            this.r_rst.Name = "r_rst";
            this.r_rst.Size = new System.Drawing.Size(72, 32);
            this.r_rst.TabIndex = 4;
            this.r_rst.Text = "59";
            this.r_rst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.r_rst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Unesi_vezu);
            // 
            // vrijeme
            // 
            this.vrijeme.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.vrijeme.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vrijeme.Location = new System.Drawing.Point(10, 44);
            this.vrijeme.Name = "vrijeme";
            this.vrijeme.ReadOnly = true;
            this.vrijeme.Size = new System.Drawing.Size(100, 32);
            this.vrijeme.TabIndex = 1;
            this.vrijeme.TabStop = false;
            this.vrijeme.Text = "17:21";
            this.vrijeme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vrijeme.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Unesi_vezu);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vrijeme (UTC)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(50, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Oznaka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(147, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pre. RST";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(225, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pri. RST";
            // 
            // lokator
            // 
            this.lokator.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lokator.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lokator.Location = new System.Drawing.Point(303, 105);
            this.lokator.Name = "lokator";
            this.lokator.Size = new System.Drawing.Size(110, 32);
            this.lokator.TabIndex = 5;
            this.lokator.Text = "JN85KV13";
            this.lokator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lokator.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Unesi_vezu);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(325, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lokator";
            // 
            // veze_log
            // 
            this.veze_log.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.veze_log.FormattingEnabled = true;
            this.veze_log.ItemHeight = 22;
            this.veze_log.Location = new System.Drawing.Point(10, 152);
            this.veze_log.Name = "veze_log";
            this.veze_log.Size = new System.Drawing.Size(696, 224);
            this.veze_log.TabIndex = 10;
            this.veze_log.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stanicaToolStripMenuItem,
            this.informacijeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stanicaToolStripMenuItem
            // 
            this.stanicaToolStripMenuItem.Name = "stanicaToolStripMenuItem";
            this.stanicaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.stanicaToolStripMenuItem.Text = "Stanica";
            // 
            // informacijeToolStripMenuItem
            // 
            this.informacijeToolStripMenuItem.Name = "informacijeToolStripMenuItem";
            this.informacijeToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.informacijeToolStripMenuItem.Text = "Informacije";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(133, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Band";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(217, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Mod";
            // 
            // band
            // 
            this.band.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.band.FormattingEnabled = true;
            this.band.Items.AddRange(new object[] {
            "160m",
            "80m",
            "60m",
            "40m",
            "30m",
            "20m",
            "15m",
            "10m",
            "6m",
            "2m"});
            this.band.Location = new System.Drawing.Point(116, 44);
            this.band.Name = "band";
            this.band.Size = new System.Drawing.Size(75, 32);
            this.band.TabIndex = 18;
            this.band.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Unesi_vezu);
            // 
            // mod
            // 
            this.mod.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.mod.FormattingEnabled = true;
            this.mod.Items.AddRange(new object[] {
            "SSB",
            "CW",
            "FM"});
            this.mod.Location = new System.Drawing.Point(197, 44);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(75, 32);
            this.mod.TabIndex = 19;
            this.mod.TextChanged += new System.EventHandler(this.mod_TextUpdate);
            this.mod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Unesi_vezu);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(284, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Frekvencija";
            // 
            // frekvencija
            // 
            this.frekvencija.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.frekvencija.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.frekvencija.Location = new System.Drawing.Point(278, 44);
            this.frekvencija.Name = "frekvencija";
            this.frekvencija.Size = new System.Drawing.Size(110, 32);
            this.frekvencija.TabIndex = 20;
            this.frekvencija.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.frekvencija.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Unesi_vezu);
            // 
            // Logger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 387);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.frekvencija);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.band);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.veze_log);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lokator);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vrijeme);
            this.Controls.Add(this.r_rst);
            this.Controls.Add(this.s_rst);
            this.Controls.Add(this.oznaka);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Logger";
            this.Text = "QSOLogger";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Unesi_vezu);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox oznaka;
        private System.Windows.Forms.TextBox s_rst;
        private System.Windows.Forms.TextBox r_rst;
        private System.Windows.Forms.TextBox vrijeme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lokator;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox veze_log;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stanicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacijeToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox band;
        private System.Windows.Forms.ComboBox mod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox frekvencija;
    }
}

