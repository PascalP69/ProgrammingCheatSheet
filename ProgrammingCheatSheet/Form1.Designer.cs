namespace ProgrammingCheatSheet
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_SchreibeLinie = new System.Windows.Forms.Button();
            this.btn_SchreibeLinieLaenge = new System.Windows.Forms.Button();
            this.btn_RechneQuadrat = new System.Windows.Forms.Button();
            this.btn_ZeichneRaute = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btn_SchreibeLinie
            // 
            this.btn_SchreibeLinie.Location = new System.Drawing.Point(308, 88);
            this.btn_SchreibeLinie.Name = "btn_SchreibeLinie";
            this.btn_SchreibeLinie.Size = new System.Drawing.Size(183, 23);
            this.btn_SchreibeLinie.TabIndex = 3;
            this.btn_SchreibeLinie.Text = "SchreibeLinie Methode";
            this.btn_SchreibeLinie.UseVisualStyleBackColor = true;
            this.btn_SchreibeLinie.Click += new System.EventHandler(this.btn_SchreibeLinie_Click);
            // 
            // btn_SchreibeLinieLaenge
            // 
            this.btn_SchreibeLinieLaenge.Location = new System.Drawing.Point(308, 118);
            this.btn_SchreibeLinieLaenge.Name = "btn_SchreibeLinieLaenge";
            this.btn_SchreibeLinieLaenge.Size = new System.Drawing.Size(183, 23);
            this.btn_SchreibeLinieLaenge.TabIndex = 4;
            this.btn_SchreibeLinieLaenge.Text = "SchreibeLinieLaenge";
            this.btn_SchreibeLinieLaenge.UseVisualStyleBackColor = true;
            this.btn_SchreibeLinieLaenge.Click += new System.EventHandler(this.btn_SchreibeLinieLaenge_Click);
            // 
            // btn_RechneQuadrat
            // 
            this.btn_RechneQuadrat.Location = new System.Drawing.Point(308, 148);
            this.btn_RechneQuadrat.Name = "btn_RechneQuadrat";
            this.btn_RechneQuadrat.Size = new System.Drawing.Size(183, 23);
            this.btn_RechneQuadrat.TabIndex = 5;
            this.btn_RechneQuadrat.Text = "RechneQuadrat Methode";
            this.btn_RechneQuadrat.UseVisualStyleBackColor = true;
            this.btn_RechneQuadrat.Click += new System.EventHandler(this.btn_RechneQuadrat_Click);
            // 
            // btn_ZeichneRaute
            // 
            this.btn_ZeichneRaute.Location = new System.Drawing.Point(308, 178);
            this.btn_ZeichneRaute.Name = "btn_ZeichneRaute";
            this.btn_ZeichneRaute.Size = new System.Drawing.Size(183, 23);
            this.btn_ZeichneRaute.TabIndex = 6;
            this.btn_ZeichneRaute.Text = "ZeichneRaute Methode";
            this.btn_ZeichneRaute.UseVisualStyleBackColor = true;
            this.btn_ZeichneRaute.Click += new System.EventHandler(this.btn_ZeichneRaute_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(71, 162);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 342);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_ZeichneRaute);
            this.Controls.Add(this.btn_RechneQuadrat);
            this.Controls.Add(this.btn_SchreibeLinieLaenge);
            this.Controls.Add(this.btn_SchreibeLinie);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_SchreibeLinie;
        private System.Windows.Forms.Button btn_SchreibeLinieLaenge;
        private System.Windows.Forms.Button btn_RechneQuadrat;
        private System.Windows.Forms.Button btn_ZeichneRaute;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

