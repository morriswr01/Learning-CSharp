namespace MethodsExample
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(33, 73);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(63, 20);
            this.num1.TabIndex = 2;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(173, 73);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(63, 20);
            this.num2.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(33, 110);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(33, 148);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 23);
            this.btnDiv.TabIndex = 5;
            this.btnDiv.Text = "Divide";
            this.btnDiv.UseVisualStyleBackColor = true;
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(173, 110);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(75, 23);
            this.btnSubtract.TabIndex = 6;
            this.btnSubtract.Text = "Subtract";
            this.btnSubtract.UseVisualStyleBackColor = true;
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(173, 148);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(75, 23);
            this.btnMult.TabIndex = 7;
            this.btnMult.Text = "Multiply";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMult;
    }
}

