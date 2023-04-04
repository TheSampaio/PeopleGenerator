namespace PeopleGenerator
{
    partial class FormMain
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
            btn_Generate = new Button();
            txt_Name = new TextBox();
            label1 = new Label();
            txt_Occupation = new TextBox();
            label2 = new Label();
            txt_Income = new TextBox();
            label3 = new Label();
            txt_Age = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txt_Birthday = new TextBox();
            txt_MaritalStatus = new TextBox();
            label6 = new Label();
            rdo_Male = new RadioButton();
            rdo_Female = new RadioButton();
            SuspendLayout();
            // 
            // btn_Generate
            // 
            btn_Generate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Generate.Location = new Point(354, 481);
            btn_Generate.Name = "btn_Generate";
            btn_Generate.Size = new Size(75, 32);
            btn_Generate.TabIndex = 0;
            btn_Generate.Text = "Generate";
            btn_Generate.UseVisualStyleBackColor = true;
            btn_Generate.Click += btn_Generate_Click;
            // 
            // txt_Name
            // 
            txt_Name.BackColor = Color.White;
            txt_Name.BorderStyle = BorderStyle.FixedSingle;
            txt_Name.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Name.Location = new Point(463, 106);
            txt_Name.Margin = new Padding(4);
            txt_Name.MaxLength = 30;
            txt_Name.Name = "txt_Name";
            txt_Name.ReadOnly = true;
            txt_Name.Size = new Size(233, 25);
            txt_Name.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(399, 116);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 2;
            label1.Text = "Name: ";
            // 
            // txt_Occupation
            // 
            txt_Occupation.BackColor = Color.White;
            txt_Occupation.BorderStyle = BorderStyle.FixedSingle;
            txt_Occupation.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Occupation.Location = new Point(481, 251);
            txt_Occupation.Margin = new Padding(4);
            txt_Occupation.MaxLength = 30;
            txt_Occupation.Name = "txt_Occupation";
            txt_Occupation.ReadOnly = true;
            txt_Occupation.Size = new Size(215, 25);
            txt_Occupation.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(399, 261);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "Occupation: ";
            // 
            // txt_Income
            // 
            txt_Income.BackColor = Color.White;
            txt_Income.BorderStyle = BorderStyle.FixedSingle;
            txt_Income.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Income.Location = new Point(481, 284);
            txt_Income.Margin = new Padding(4);
            txt_Income.MaxLength = 30;
            txt_Income.Name = "txt_Income";
            txt_Income.ReadOnly = true;
            txt_Income.Size = new Size(107, 25);
            txt_Income.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(399, 294);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Income: ";
            // 
            // txt_Age
            // 
            txt_Age.BackColor = Color.White;
            txt_Age.BorderStyle = BorderStyle.FixedSingle;
            txt_Age.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Age.Location = new Point(653, 139);
            txt_Age.Margin = new Padding(4);
            txt_Age.MaxLength = 30;
            txt_Age.Name = "txt_Age";
            txt_Age.ReadOnly = true;
            txt_Age.Size = new Size(43, 25);
            txt_Age.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(612, 149);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 2;
            label4.Text = "Age: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(399, 149);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 2;
            label5.Text = "Birthday: ";
            // 
            // txt_Birthday
            // 
            txt_Birthday.BackColor = Color.White;
            txt_Birthday.BorderStyle = BorderStyle.FixedSingle;
            txt_Birthday.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Birthday.Location = new Point(463, 139);
            txt_Birthday.Margin = new Padding(4);
            txt_Birthday.MaxLength = 30;
            txt_Birthday.Name = "txt_Birthday";
            txt_Birthday.ReadOnly = true;
            txt_Birthday.Size = new Size(125, 25);
            txt_Birthday.TabIndex = 1;
            // 
            // txt_MaritalStatus
            // 
            txt_MaritalStatus.BackColor = Color.White;
            txt_MaritalStatus.BorderStyle = BorderStyle.FixedSingle;
            txt_MaritalStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaritalStatus.Location = new Point(491, 172);
            txt_MaritalStatus.Margin = new Padding(4);
            txt_MaritalStatus.MaxLength = 30;
            txt_MaritalStatus.Name = "txt_MaritalStatus";
            txt_MaritalStatus.ReadOnly = true;
            txt_MaritalStatus.Size = new Size(97, 25);
            txt_MaritalStatus.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(399, 182);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 2;
            label6.Text = "Marital Status: ";
            // 
            // rdo_Male
            // 
            rdo_Male.AutoSize = true;
            rdo_Male.Checked = true;
            rdo_Male.Location = new Point(399, 363);
            rdo_Male.Name = "rdo_Male";
            rdo_Male.Size = new Size(51, 19);
            rdo_Male.TabIndex = 3;
            rdo_Male.TabStop = true;
            rdo_Male.Text = "Male";
            rdo_Male.UseVisualStyleBackColor = true;
            // 
            // rdo_Female
            // 
            rdo_Female.AutoSize = true;
            rdo_Female.Location = new Point(399, 388);
            rdo_Female.Name = "rdo_Female";
            rdo_Female.Size = new Size(63, 19);
            rdo_Female.TabIndex = 3;
            rdo_Female.Text = "Female";
            rdo_Female.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            ClientSize = new Size(784, 561);
            Controls.Add(rdo_Female);
            Controls.Add(rdo_Male);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_MaritalStatus);
            Controls.Add(txt_Birthday);
            Controls.Add(txt_Age);
            Controls.Add(txt_Income);
            Controls.Add(txt_Occupation);
            Controls.Add(txt_Name);
            Controls.Add(btn_Generate);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "People Generator";
            TopMost = true;
            FormClosing += FormMain_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Generate;
        private TextBox txt_Name;
        private Label label1;
        private TextBox txt_Occupation;
        private Label label2;
        private TextBox txt_Income;
        private Label label3;
        private TextBox txt_Age;
        private Label label4;
        private Label label5;
        private TextBox txt_Birthday;
        private TextBox txt_MaritalStatus;
        private Label label6;
        private RadioButton rdo_Male;
        private RadioButton rdo_Female;
    }
}