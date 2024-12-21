
namespace BMI___Body_mass_index___calculator
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
            this.weightBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkW = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BMIbtn = new System.Windows.Forms.Button();
            this.BMIBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Weight Here";
            // 
            // weightBox
            // 
            this.weightBox.Location = new System.Drawing.Point(241, 52);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(100, 20);
            this.weightBox.TabIndex = 1;
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(241, 88);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(100, 20);
            this.heightBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Height Here";
            // 
            // checkW
            // 
            this.checkW.Location = new System.Drawing.Point(457, 48);
            this.checkW.Name = "checkW";
            this.checkW.Size = new System.Drawing.Size(117, 23);
            this.checkW.TabIndex = 4;
            this.checkW.Text = "Check Weight";
            this.checkW.UseVisualStyleBackColor = true;
            this.checkW.Click += new System.EventHandler(this.checkW_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "KG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "M";
            // 
            // BMIbtn
            // 
            this.BMIbtn.Location = new System.Drawing.Point(457, 129);
            this.BMIbtn.Name = "BMIbtn";
            this.BMIbtn.Size = new System.Drawing.Size(117, 23);
            this.BMIbtn.TabIndex = 7;
            this.BMIbtn.Text = "Get BMI";
            this.BMIbtn.UseVisualStyleBackColor = true;
            this.BMIbtn.Click += new System.EventHandler(this.BMIbtn_Click);
            // 
            // BMIBox
            // 
            this.BMIBox.Location = new System.Drawing.Point(241, 184);
            this.BMIBox.Name = "BMIBox";
            this.BMIBox.ReadOnly = true;
            this.BMIBox.Size = new System.Drawing.Size(100, 20);
            this.BMIBox.TabIndex = 9;
            this.BMIBox.Text = "0";
            this.BMIBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "BMI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BMIBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BMIbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkW);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Body Mass Index Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button checkW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BMIbtn;
        private System.Windows.Forms.TextBox BMIBox;
        private System.Windows.Forms.Label label5;
    }
}

