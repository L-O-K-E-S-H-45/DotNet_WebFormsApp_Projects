namespace EmployeeManagementSystem_WindowsForms_3._1V
{
    partial class Employee
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            textBox4 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(180, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(106, 18);
            label1.TabIndex = 0;
            label1.Text = "EmployeeId";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(355, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(168, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(355, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(168, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(180, 63);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(136, 18);
            label2.TabIndex = 2;
            label2.Text = "EmployeeName";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(355, 102);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(168, 23);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(180, 102);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(68, 18);
            label3.TabIndex = 4;
            label3.Text = "Addess";
            label3.Click += label3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(355, 142);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(168, 23);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(180, 142);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(60, 18);
            label4.TabIndex = 6;
            label4.Text = "Salary";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(180, 177);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(44, 18);
            label5.TabIndex = 8;
            label5.Text = "Role";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Clerk", "Employee", "Manager", "CEO" });
            comboBox1.Location = new System.Drawing.Point(355, 183);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(168, 23);
            comboBox1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(68, 235);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 33);
            button1.TabIndex = 10;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Insert_Click;
            // 
            // button2
            // 
            button2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(201, 235);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 33);
            button2.TabIndex = 11;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Update_Click;
            // 
            // button3
            // 
            button3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button3.Location = new System.Drawing.Point(345, 235);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(75, 33);
            button3.TabIndex = 12;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Delete_Click;
            // 
            // button4
            // 
            button4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button4.Location = new System.Drawing.Point(610, 235);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(75, 33);
            button4.TabIndex = 13;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Clear_Click;
            // 
            // button5
            // 
            button5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button5.Location = new System.Drawing.Point(481, 235);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(75, 33);
            button5.TabIndex = 14;
            button5.Text = "Fetch";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Fetch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(24, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(754, 150);
            dataGridView1.TabIndex = 15;
            // 
            // Employee
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Employee";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Form1";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
