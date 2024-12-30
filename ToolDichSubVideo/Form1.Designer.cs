namespace ToolDichSubVideo
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
            this.srcLangComboBox = new System.Windows.Forms.ComboBox();
            this.destLangComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // srcLangComboBox
            // 
            this.srcLangComboBox.FormattingEnabled = true;
            this.srcLangComboBox.Location = new System.Drawing.Point(68, 64);
            this.srcLangComboBox.Name = "srcLangComboBox";
            this.srcLangComboBox.Size = new System.Drawing.Size(276, 24);
            this.srcLangComboBox.TabIndex = 0;
            // 
            // destLangComboBox
            // 
            this.destLangComboBox.FormattingEnabled = true;
            this.destLangComboBox.Location = new System.Drawing.Point(68, 129);
            this.destLangComboBox.Name = "destLangComboBox";
            this.destLangComboBox.Size = new System.Drawing.Size(276, 24);
            this.destLangComboBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 76);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 76);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(68, 204);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(281, 22);
            this.txtFilePath.TabIndex = 4;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(409, 22);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(363, 416);
            this.txtResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.destLangComboBox);
            this.Controls.Add(this.srcLangComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox srcLangComboBox;
        private System.Windows.Forms.ComboBox destLangComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtResult;
    }
}

