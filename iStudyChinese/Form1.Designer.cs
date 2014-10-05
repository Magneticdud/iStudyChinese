namespace iStudyChinese
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoximi = new System.Windows.Forms.TextBox();
            this.textBoxhanzi = new System.Windows.Forms.TextBox();
            this.textBoxpinyin = new System.Windows.Forms.TextBox();
            this.buttoncsharp = new System.Windows.Forms.Button();
            this.buttonhtml = new System.Windows.Forms.Button();
            this.radioButtonfemmina = new System.Windows.Forms.RadioButton();
            this.radioButtonmaschio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxcsharp = new System.Windows.Forms.RichTextBox();
            this.textBoxhtml = new System.Windows.Forms.RichTextBox();
            this.radioButtonfemmina2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBoximi
            // 
            this.textBoximi.Location = new System.Drawing.Point(87, 12);
            this.textBoximi.Name = "textBoximi";
            this.textBoximi.Size = new System.Drawing.Size(188, 21);
            this.textBoximi.TabIndex = 0;
            this.textBoximi.Enter += new System.EventHandler(this.textBoximi_Enter);
            // 
            // textBoxhanzi
            // 
            this.textBoxhanzi.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBoxhanzi.Location = new System.Drawing.Point(473, 12);
            this.textBoxhanzi.Name = "textBoxhanzi";
            this.textBoxhanzi.Size = new System.Drawing.Size(79, 21);
            this.textBoxhanzi.TabIndex = 2;
            this.textBoxhanzi.Enter += new System.EventHandler(this.textBoxhanzi_Enter);
            // 
            // textBoxpinyin
            // 
            this.textBoxpinyin.Location = new System.Drawing.Point(328, 12);
            this.textBoxpinyin.Name = "textBoxpinyin";
            this.textBoxpinyin.Size = new System.Drawing.Size(100, 21);
            this.textBoxpinyin.TabIndex = 1;
            this.textBoxpinyin.Enter += new System.EventHandler(this.textBoxpinyin_Enter);
            // 
            // buttoncsharp
            // 
            this.buttoncsharp.Location = new System.Drawing.Point(87, 54);
            this.buttoncsharp.Name = "buttoncsharp";
            this.buttoncsharp.Size = new System.Drawing.Size(188, 23);
            this.buttoncsharp.TabIndex = 5;
            this.buttoncsharp.Text = "Codice C# (Aggiungi)";
            this.buttoncsharp.UseVisualStyleBackColor = true;
            this.buttoncsharp.Click += new System.EventHandler(this.buttoncsharp_Click);
            // 
            // buttonhtml
            // 
            this.buttonhtml.Location = new System.Drawing.Point(473, 54);
            this.buttonhtml.Name = "buttonhtml";
            this.buttonhtml.Size = new System.Drawing.Size(79, 23);
            this.buttonhtml.TabIndex = 6;
            this.buttonhtml.Text = "Codice HTML";
            this.buttonhtml.UseVisualStyleBackColor = true;
            this.buttonhtml.Click += new System.EventHandler(this.buttonhtml_Click);
            // 
            // radioButtonfemmina
            // 
            this.radioButtonfemmina.AutoSize = true;
            this.radioButtonfemmina.Checked = true;
            this.radioButtonfemmina.Location = new System.Drawing.Point(328, 36);
            this.radioButtonfemmina.Name = "radioButtonfemmina";
            this.radioButtonfemmina.Size = new System.Drawing.Size(65, 16);
            this.radioButtonfemmina.TabIndex = 7;
            this.radioButtonfemmina.TabStop = true;
            this.radioButtonfemmina.Text = "Femmina";
            this.radioButtonfemmina.UseVisualStyleBackColor = true;
            // 
            // radioButtonmaschio
            // 
            this.radioButtonmaschio.AutoSize = true;
            this.radioButtonmaschio.Location = new System.Drawing.Point(328, 58);
            this.radioButtonmaschio.Name = "radioButtonmaschio";
            this.radioButtonmaschio.Size = new System.Drawing.Size(65, 16);
            this.radioButtonmaschio.TabIndex = 8;
            this.radioButtonmaschio.Text = "Maschio";
            this.radioButtonmaschio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Significato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pīnyīn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "汉字";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(545, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "Il codice che ti serve viene automaticamente copiato negli appunti, non ti preocc" +
                "upare :-)";
            // 
            // textBoxcsharp
            // 
            this.textBoxcsharp.Location = new System.Drawing.Point(12, 98);
            this.textBoxcsharp.Name = "textBoxcsharp";
            this.textBoxcsharp.Size = new System.Drawing.Size(263, 250);
            this.textBoxcsharp.TabIndex = 14;
            this.textBoxcsharp.Text = "";
            // 
            // textBoxhtml
            // 
            this.textBoxhtml.Location = new System.Drawing.Point(283, 98);
            this.textBoxhtml.Name = "textBoxhtml";
            this.textBoxhtml.Size = new System.Drawing.Size(269, 250);
            this.textBoxhtml.TabIndex = 15;
            this.textBoxhtml.Text = "";
            // 
            // radioButtonfemmina2
            // 
            this.radioButtonfemmina2.AutoSize = true;
            this.radioButtonfemmina2.Location = new System.Drawing.Point(328, 80);
            this.radioButtonfemmina2.Name = "radioButtonfemmina2";
            this.radioButtonfemmina2.Size = new System.Drawing.Size(77, 16);
            this.radioButtonfemmina2.TabIndex = 16;
            this.radioButtonfemmina2.Text = "Femmina 2";
            this.radioButtonfemmina2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 378);
            this.Controls.Add(this.radioButtonfemmina2);
            this.Controls.Add(this.textBoxhtml);
            this.Controls.Add(this.textBoxcsharp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonmaschio);
            this.Controls.Add(this.radioButtonfemmina);
            this.Controls.Add(this.buttonhtml);
            this.Controls.Add(this.buttoncsharp);
            this.Controls.Add(this.textBoxpinyin);
            this.Controls.Add(this.textBoxhanzi);
            this.Controls.Add(this.textBoximi);
            this.Name = "Form1";
            this.Text = "iStudyChinese";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoximi;
        private System.Windows.Forms.TextBox textBoxhanzi;
        private System.Windows.Forms.TextBox textBoxpinyin;
        private System.Windows.Forms.Button buttoncsharp;
        private System.Windows.Forms.Button buttonhtml;
        private System.Windows.Forms.RadioButton radioButtonfemmina;
        private System.Windows.Forms.RadioButton radioButtonmaschio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox textBoxcsharp;
        private System.Windows.Forms.RichTextBox textBoxhtml;
        private System.Windows.Forms.RadioButton radioButtonfemmina2;
    }
}

