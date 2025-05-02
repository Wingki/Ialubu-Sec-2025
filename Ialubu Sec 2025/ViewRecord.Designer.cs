namespace Ialubu_Sec_2025
{
    partial class ViewRecord
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
            components = new System.ComponentModel.Container();
            databaseHelperBindingSource = new BindingSource(components);
            viewButton = new Button();
            PdfButton = new Button();
            Deletebutton = new Button();
            viewLabel = new Label();
            studentGridView = new DataGridView();
            NameTB = new TextBox();
            SubjectTB = new TextBox();
            GradeTB = new TextBox();
            MarksTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            UpdateBTN = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)databaseHelperBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentGridView).BeginInit();
            SuspendLayout();
            // 
            // viewButton
            // 
            viewButton.Location = new Point(12, 12);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(112, 34);
            viewButton.TabIndex = 1;
            viewButton.Text = "View";
            viewButton.UseVisualStyleBackColor = true;
            viewButton.Click += viewButton_Click;
            // 
            // PdfButton
            // 
            PdfButton.Location = new Point(174, 12);
            PdfButton.Name = "PdfButton";
            PdfButton.Size = new Size(140, 40);
            PdfButton.TabIndex = 5;
            PdfButton.Text = "PDF Download";
            PdfButton.Click += PdfButton_Click;
            // 
            // Deletebutton
            // 
            Deletebutton.Location = new Point(346, 12);
            Deletebutton.Name = "Deletebutton";
            Deletebutton.Size = new Size(112, 40);
            Deletebutton.TabIndex = 7;
            Deletebutton.Text = "Delete";
            Deletebutton.UseVisualStyleBackColor = true;
            Deletebutton.Click += Deletebutton_Click;
            // 
            // viewLabel
            // 
            viewLabel.AutoSize = true;
            viewLabel.BackColor = SystemColors.ActiveCaption;
            viewLabel.Location = new Point(57, 90);
            viewLabel.Name = "viewLabel";
            viewLabel.Size = new Size(0, 25);
            viewLabel.TabIndex = 8;
            // 
            // studentGridView
            // 
            studentGridView.BackgroundColor = Color.CornflowerBlue;
            studentGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentGridView.Location = new Point(12, 68);
            studentGridView.Name = "studentGridView";
            studentGridView.RowHeadersWidth = 62;
            studentGridView.Size = new Size(718, 296);
            studentGridView.TabIndex = 9;
            studentGridView.CellContentClick += studentGridView_CellContentClick;
            // 
            // NameTB
            // 
            NameTB.Location = new Point(155, 392);
            NameTB.Name = "NameTB";
            NameTB.Size = new Size(150, 31);
            NameTB.TabIndex = 10;
            // 
            // SubjectTB
            // 
            SubjectTB.Location = new Point(422, 392);
            SubjectTB.Name = "SubjectTB";
            SubjectTB.Size = new Size(150, 31);
            SubjectTB.TabIndex = 11;
            // 
            // GradeTB
            // 
            GradeTB.Location = new Point(155, 454);
            GradeTB.Name = "GradeTB";
            GradeTB.Size = new Size(150, 31);
            GradeTB.TabIndex = 12;
            // 
            // MarksTB
            // 
            MarksTB.Location = new Point(422, 454);
            MarksTB.Name = "MarksTB";
            MarksTB.Size = new Size(150, 31);
            MarksTB.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 397);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 14;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 454);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 15;
            label2.Text = "Grade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(331, 393);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 16;
            label3.Text = "Subject";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(334, 456);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 17;
            label4.Text = "Marks";
            // 
            // UpdateBTN
            // 
            UpdateBTN.Location = new Point(618, 445);
            UpdateBTN.Name = "UpdateBTN";
            UpdateBTN.Size = new Size(112, 40);
            UpdateBTN.TabIndex = 18;
            UpdateBTN.Text = "Update";
            UpdateBTN.UseVisualStyleBackColor = true;
            UpdateBTN.Click += UpdateBTN_Click;
            // 
            // button1
            // 
            button1.Location = new Point(618, 11);
            button1.Name = "button1";
            button1.Size = new Size(112, 42);
            button1.TabIndex = 19;
            button1.Text = "Add New";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ViewRecord
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 530);
            Controls.Add(button1);
            Controls.Add(UpdateBTN);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MarksTB);
            Controls.Add(GradeTB);
            Controls.Add(SubjectTB);
            Controls.Add(NameTB);
            Controls.Add(studentGridView);
            Controls.Add(viewLabel);
            Controls.Add(Deletebutton);
            Controls.Add(PdfButton);
            Controls.Add(viewButton);
            Name = "ViewRecord";
            Text = "ViewRecord";
            ((System.ComponentModel.ISupportInitialize)databaseHelperBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource databaseHelperBindingSource;
        private Button viewButton;
        private Button PdfButton;
        private Button Deletebutton;
        private Label viewLabel;
        private DataGridView studentGridView;
        private TextBox NameTB;
        private TextBox SubjectTB;
        private TextBox GradeTB;
        private TextBox MarksTB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button UpdateBTN;
        private Button button1;
    }
}