namespace QSOLogger
{
    partial class Station
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
            this.label2 = new System.Windows.Forms.Label();
            this.oznaka_stanice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oznaka_operatora = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lokator_stanice = new System.Windows.Forms.TextBox();
            this.spremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(19, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Oznaka Stanice";
            // 
            // oznaka_stanice
            // 
            this.oznaka_stanice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.oznaka_stanice.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oznaka_stanice.Location = new System.Drawing.Point(12, 33);
            this.oznaka_stanice.Name = "oznaka_stanice";
            this.oznaka_stanice.Size = new System.Drawing.Size(134, 32);
            this.oznaka_stanice.TabIndex = 0;
            this.oznaka_stanice.Text = "LB100XCS";
            this.oznaka_stanice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(10, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Oznaka Operatora";
            // 
            // oznaka_operatora
            // 
            this.oznaka_operatora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.oznaka_operatora.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oznaka_operatora.Location = new System.Drawing.Point(12, 99);
            this.oznaka_operatora.Name = "oznaka_operatora";
            this.oznaka_operatora.Size = new System.Drawing.Size(134, 32);
            this.oznaka_operatora.TabIndex = 2;
            this.oznaka_operatora.Text = "LB100XCS";
            this.oznaka_operatora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(174, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lokator";
            // 
            // lokator_stanice
            // 
            this.lokator_stanice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lokator_stanice.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lokator_stanice.Location = new System.Drawing.Point(152, 33);
            this.lokator_stanice.Name = "lokator_stanice";
            this.lokator_stanice.Size = new System.Drawing.Size(110, 32);
            this.lokator_stanice.TabIndex = 1;
            this.lokator_stanice.Text = "JN85KV13";
            this.lokator_stanice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // spremi
            // 
            this.spremi.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.spremi.Location = new System.Drawing.Point(166, 89);
            this.spremi.Name = "spremi";
            this.spremi.Size = new System.Drawing.Size(96, 51);
            this.spremi.TabIndex = 3;
            this.spremi.Text = "Spremi";
            this.spremi.UseVisualStyleBackColor = true;
            this.spremi.Click += new System.EventHandler(this.spremi_Click);
            // 
            // Station
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 170);
            this.Controls.Add(this.spremi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lokator_stanice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oznaka_operatora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oznaka_stanice);
            this.Name = "Station";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Station";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oznaka_stanice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oznaka_operatora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lokator_stanice;
        private System.Windows.Forms.Button spremi;
    }
}