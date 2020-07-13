namespace JS_LearnApp
{
    partial class TestForm
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
            this.testRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.answeBbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testRichTextBox1
            // 
            this.testRichTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.testRichTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testRichTextBox1.Location = new System.Drawing.Point(271, 23);
            this.testRichTextBox1.Name = "testRichTextBox1";
            this.testRichTextBox1.Size = new System.Drawing.Size(459, 242);
            this.testRichTextBox1.TabIndex = 0;
            this.testRichTextBox1.Text = "";
            // 
            // answeBbutton1
            // 
            this.answeBbutton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.answeBbutton1.Location = new System.Drawing.Point(324, 354);
            this.answeBbutton1.Name = "answeBbutton1";
            this.answeBbutton1.Size = new System.Drawing.Size(75, 23);
            this.answeBbutton1.TabIndex = 1;
            this.answeBbutton1.Text = "Ответить";
            this.answeBbutton1.UseVisualStyleBackColor = false;
            this.answeBbutton1.Click += new System.EventHandler(this.answeBbutton1_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JS_LearnApp.Properties.Resources.Common;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(764, 452);
            this.Controls.Add(this.answeBbutton1);
            this.Controls.Add(this.testRichTextBox1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox testRichTextBox1;
        private System.Windows.Forms.Button answeBbutton1;
    }
}