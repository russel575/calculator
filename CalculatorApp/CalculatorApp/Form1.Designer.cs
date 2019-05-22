namespace CalculatorApp
{
    partial class Calculator
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
            this.FirstNumber = new System.Windows.Forms.TextBox();
            this.SecondNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.multiButton = new System.Windows.Forms.Button();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // FirstNumber
            // 
            this.FirstNumber.Location = new System.Drawing.Point(271, 94);
            this.FirstNumber.Name = "FirstNumber";
            this.FirstNumber.Size = new System.Drawing.Size(271, 20);
            this.FirstNumber.TabIndex = 0;
            // 
            // SecondNumber
            // 
            this.SecondNumber.Location = new System.Drawing.Point(271, 140);
            this.SecondNumber.Name = "SecondNumber";
            this.SecondNumber.Size = new System.Drawing.Size(271, 20);
            this.SecondNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(285, 223);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(450, 223);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(75, 23);
            this.subtractButton.TabIndex = 2;
            this.subtractButton.Text = "Subtract";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(450, 265);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(75, 23);
            this.divideButton.TabIndex = 2;
            this.divideButton.Text = "Divide";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // multiButton
            // 
            this.multiButton.Location = new System.Drawing.Point(285, 265);
            this.multiButton.Name = "multiButton";
            this.multiButton.Size = new System.Drawing.Size(75, 23);
            this.multiButton.TabIndex = 2;
            this.multiButton.Text = "Multiplay";
            this.multiButton.UseVisualStyleBackColor = true;
            this.multiButton.Click += new System.EventHandler(this.multiButton_Click);
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(271, 140);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(271, 20);
            this.secondNumberTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Second Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Result";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(271, 186);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(271, 25);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.multiButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.SecondNumber);
            this.Controls.Add(this.FirstNumber);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNumber;
        private System.Windows.Forms.TextBox SecondNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button multiButton;
        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

