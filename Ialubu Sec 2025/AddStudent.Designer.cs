namespace Ialubu_Sec_2025
{
    partial class AddStudent
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
            txtName = new TextBox();
            txtGrade = new TextBox();
            txtSubject = new TextBox();
            txtMarks = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(277, 78);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 0;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(277, 135);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(146, 31);
            txtGrade.TabIndex = 1;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(277, 195);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(150, 31);
            txtSubject.TabIndex = 2;
            // 
            // txtMarks
            // 
            txtMarks.Location = new Point(277, 268);
            txtMarks.Name = "txtMarks";
            txtMarks.Size = new Size(150, 31);
            txtMarks.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(273, 332);
            button1.Name = "button1";
            button1.Size = new Size(151, 34);
            button1.TabIndex = 4;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 84);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 201);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 6;
            label2.Text = "Subject";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 141);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 7;
            label3.Text = "Grade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(190, 268);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 8;
            label4.Text = "Marks";
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtMarks);
            Controls.Add(txtSubject);
            Controls.Add(txtGrade);
            Controls.Add(txtName);
            Name = "AddStudent";
            Text = "AddStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtGrade;
        private TextBox txtSubject;
        private TextBox txtMarks;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}