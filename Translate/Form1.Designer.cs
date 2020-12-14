namespace Translate
{
    partial class Form1
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
            this.textBoxEnglish = new System.Windows.Forms.TextBox();
            this.textBoxTranslate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTranslator = new System.Windows.Forms.Label();
            this.rbLatin = new System.Windows.Forms.RadioButton();
            this.rbGreek = new System.Windows.Forms.RadioButton();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEnglish
            // 
            this.textBoxEnglish.Location = new System.Drawing.Point(35, 52);
            this.textBoxEnglish.Multiline = true;
            this.textBoxEnglish.Name = "textBoxEnglish";
            this.textBoxEnglish.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxEnglish.Size = new System.Drawing.Size(482, 130);
            this.textBoxEnglish.TabIndex = 0;
            // 
            // textBoxTranslate
            // 
            this.textBoxTranslate.Location = new System.Drawing.Point(35, 298);
            this.textBoxTranslate.Multiline = true;
            this.textBoxTranslate.Name = "textBoxTranslate";
            this.textBoxTranslate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTranslate.Size = new System.Drawing.Size(482, 245);
            this.textBoxTranslate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter English Text Here:";
            // 
            // lblTranslator
            // 
            this.lblTranslator.AutoSize = true;
            this.lblTranslator.Location = new System.Drawing.Point(35, 265);
            this.lblTranslator.Name = "lblTranslator";
            this.lblTranslator.Size = new System.Drawing.Size(0, 20);
            this.lblTranslator.TabIndex = 3;
            // 
            // rbLatin
            // 
            this.rbLatin.AutoSize = true;
            this.rbLatin.Location = new System.Drawing.Point(35, 219);
            this.rbLatin.Name = "rbLatin";
            this.rbLatin.Size = new System.Drawing.Size(95, 24);
            this.rbLatin.TabIndex = 4;
            this.rbLatin.TabStop = true;
            this.rbLatin.Text = "Pig Latin";
            this.rbLatin.UseVisualStyleBackColor = true;
            this.rbLatin.CheckedChanged += new System.EventHandler(this.rbLatin_CheckedChanged);
            // 
            // rbGreek
            // 
            this.rbGreek.AutoSize = true;
            this.rbGreek.Location = new System.Drawing.Point(193, 219);
            this.rbGreek.Name = "rbGreek";
            this.rbGreek.Size = new System.Drawing.Size(104, 24);
            this.rbGreek.TabIndex = 5;
            this.rbGreek.TabStop = true;
            this.rbGreek.Text = "Pig Greek";
            this.rbGreek.UseVisualStyleBackColor = true;
            this.rbGreek.CheckedChanged += new System.EventHandler(this.rbGreek_CheckedChanged);
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(35, 584);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(114, 35);
            this.btnTranslate.TabIndex = 6;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(183, 584);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 35);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(403, 584);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 35);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 642);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.rbGreek);
            this.Controls.Add(this.rbLatin);
            this.Controls.Add(this.lblTranslator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTranslate);
            this.Controls.Add(this.textBoxEnglish);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEnglish;
        private System.Windows.Forms.TextBox textBoxTranslate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTranslator;
        private System.Windows.Forms.RadioButton rbLatin;
        private System.Windows.Forms.RadioButton rbGreek;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

