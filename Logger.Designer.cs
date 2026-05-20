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
            this.broj_veze = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otvoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spremiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stanicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // oznaka
            // 
            this.oznaka.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.oznaka.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oznaka.Location = new System.Drawing.Point(208, 53);
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
            this.s_rst.Location = new System.Drawing.Point(348, 53);
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
            this.r_rst.Location = new System.Drawing.Point(423, 53);
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
            this.vrijeme.Location = new System.Drawing.Point(102, 53);
            this.vrijeme.Name = "vrijeme";
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
            this.label1.Location = new System.Drawing.Point(122, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vrijeme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(248, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Oznaka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(345, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pre. RST";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(423, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pri. RST";
            // 
            // lokator
            // 
            this.lokator.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lokator.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lokator.Location = new System.Drawing.Point(501, 53);
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
            this.label5.Location = new System.Drawing.Point(523, 33);
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
            this.veze_log.Location = new System.Drawing.Point(10, 91);
            this.veze_log.Name = "veze_log";
            this.veze_log.Size = new System.Drawing.Size(485, 224);
            this.veze_log.TabIndex = 10;
            this.veze_log.TabStop = false;
            // 
            // broj_veze
            // 
            this.broj_veze.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.broj_veze.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.broj_veze.Location = new System.Drawing.Point(10, 53);
            this.broj_veze.Name = "broj_veze";
            this.broj_veze.Size = new System.Drawing.Size(86, 32);
            this.broj_veze.TabIndex = 0;
            this.broj_veze.TabStop = false;
            this.broj_veze.Text = "001";
            this.broj_veze.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.broj_veze.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Unesi_vezu);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(14, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Broj veze";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem,
            this.stanicaToolStripMenuItem,
            this.informacijeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(622, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otvoriToolStripMenuItem,
            this.spremiToolStripMenuItem});
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            // 
            // otvoriToolStripMenuItem
            // 
            this.otvoriToolStripMenuItem.Name = "otvoriToolStripMenuItem";
            this.otvoriToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.otvoriToolStripMenuItem.Text = "Otvori";
            // 
            // spremiToolStripMenuItem
            // 
            this.spremiToolStripMenuItem.Name = "spremiToolStripMenuItem";
            this.spremiToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.spremiToolStripMenuItem.Text = "Spremi";
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
            // Logger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 324);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.broj_veze);
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
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox broj_veze;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otvoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spremiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stanicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacijeToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

