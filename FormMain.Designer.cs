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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            Btn_Generate = new Button();
            Txt_Name = new TextBox();
            label1 = new Label();
            Txt_Occupation = new TextBox();
            label2 = new Label();
            Txt_Income = new TextBox();
            label3 = new Label();
            Txt_Age = new TextBox();
            label4 = new Label();
            label5 = new Label();
            Txt_Anniversary = new TextBox();
            Txt_MaritalStatus = new TextBox();
            label6 = new Label();
            Rdo_Male = new RadioButton();
            Rdo_Female = new RadioButton();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_Generate
            // 
            Btn_Generate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Generate.Location = new Point(243, 262);
            Btn_Generate.Name = "Btn_Generate";
            Btn_Generate.Size = new Size(75, 32);
            Btn_Generate.TabIndex = 2;
            Btn_Generate.Text = "Generate";
            Btn_Generate.UseVisualStyleBackColor = true;
            Btn_Generate.Click += Btn_Generate_Click;
            // 
            // Txt_Name
            // 
            Txt_Name.BackColor = Color.White;
            Txt_Name.BorderStyle = BorderStyle.FixedSingle;
            Txt_Name.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Name.Location = new Point(85, 25);
            Txt_Name.Margin = new Padding(4);
            Txt_Name.MaxLength = 30;
            Txt_Name.Name = "Txt_Name";
            Txt_Name.ReadOnly = true;
            Txt_Name.Size = new Size(233, 25);
            Txt_Name.TabIndex = 1;
            Txt_Name.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 35);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 2;
            label1.Text = "Name: ";
            // 
            // Txt_Occupation
            // 
            Txt_Occupation.BackColor = Color.White;
            Txt_Occupation.BorderStyle = BorderStyle.FixedSingle;
            Txt_Occupation.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Occupation.Location = new Point(103, 158);
            Txt_Occupation.Margin = new Padding(4);
            Txt_Occupation.MaxLength = 30;
            Txt_Occupation.Name = "Txt_Occupation";
            Txt_Occupation.ReadOnly = true;
            Txt_Occupation.Size = new Size(215, 25);
            Txt_Occupation.TabIndex = 1;
            Txt_Occupation.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 168);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "Occupation: ";
            // 
            // Txt_Income
            // 
            Txt_Income.BackColor = Color.White;
            Txt_Income.BorderStyle = BorderStyle.FixedSingle;
            Txt_Income.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Income.Location = new Point(103, 191);
            Txt_Income.Margin = new Padding(4);
            Txt_Income.MaxLength = 30;
            Txt_Income.Name = "Txt_Income";
            Txt_Income.ReadOnly = true;
            Txt_Income.Size = new Size(117, 25);
            Txt_Income.TabIndex = 1;
            Txt_Income.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 201);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Income: ";
            // 
            // Txt_Age
            // 
            Txt_Age.BackColor = Color.White;
            Txt_Age.BorderStyle = BorderStyle.FixedSingle;
            Txt_Age.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Age.Location = new Point(275, 58);
            Txt_Age.Margin = new Padding(4);
            Txt_Age.MaxLength = 30;
            Txt_Age.Name = "Txt_Age";
            Txt_Age.ReadOnly = true;
            Txt_Age.Size = new Size(43, 25);
            Txt_Age.TabIndex = 1;
            Txt_Age.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(234, 68);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 2;
            label4.Text = "Age: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 68);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 2;
            label5.Text = "Birthday: ";
            // 
            // Txt_Anniversary
            // 
            Txt_Anniversary.BackColor = Color.White;
            Txt_Anniversary.BorderStyle = BorderStyle.FixedSingle;
            Txt_Anniversary.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Anniversary.Location = new Point(85, 58);
            Txt_Anniversary.Margin = new Padding(4);
            Txt_Anniversary.MaxLength = 30;
            Txt_Anniversary.Name = "Txt_Anniversary";
            Txt_Anniversary.ReadOnly = true;
            Txt_Anniversary.Size = new Size(135, 25);
            Txt_Anniversary.TabIndex = 1;
            Txt_Anniversary.TabStop = false;
            // 
            // Txt_MaritalStatus
            // 
            Txt_MaritalStatus.BackColor = Color.White;
            Txt_MaritalStatus.BorderStyle = BorderStyle.FixedSingle;
            Txt_MaritalStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_MaritalStatus.Location = new Point(113, 91);
            Txt_MaritalStatus.Margin = new Padding(4);
            Txt_MaritalStatus.MaxLength = 30;
            Txt_MaritalStatus.Name = "Txt_MaritalStatus";
            Txt_MaritalStatus.ReadOnly = true;
            Txt_MaritalStatus.Size = new Size(107, 25);
            Txt_MaritalStatus.TabIndex = 1;
            Txt_MaritalStatus.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 101);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 2;
            label6.Text = "Marital Status: ";
            // 
            // Rdo_Male
            // 
            Rdo_Male.AutoSize = true;
            Rdo_Male.Checked = true;
            Rdo_Male.Location = new Point(21, 250);
            Rdo_Male.Name = "Rdo_Male";
            Rdo_Male.Size = new Size(51, 19);
            Rdo_Male.TabIndex = 0;
            Rdo_Male.TabStop = true;
            Rdo_Male.Text = "Male";
            Rdo_Male.UseVisualStyleBackColor = true;
            // 
            // Rdo_Female
            // 
            Rdo_Female.AutoSize = true;
            Rdo_Female.Location = new Point(21, 275);
            Rdo_Female.Name = "Rdo_Female";
            Rdo_Female.Size = new Size(63, 19);
            Rdo_Female.TabIndex = 1;
            Rdo_Female.Text = "Female";
            Rdo_Female.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 318);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Txt_Name);
            panel1.Controls.Add(Txt_Occupation);
            panel1.Controls.Add(Btn_Generate);
            panel1.Controls.Add(Rdo_Female);
            panel1.Controls.Add(Txt_Income);
            panel1.Controls.Add(Txt_Age);
            panel1.Controls.Add(Rdo_Male);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Txt_Anniversary);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(Txt_MaritalStatus);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(307, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 318);
            panel1.TabIndex = 5;
            // 
            // FormMain
            // 
            ClientSize = new Size(686, 387);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "People Generator";
            TopMost = true;
            FormClosing += FormMain_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_Generate;
        private TextBox Txt_Name;
        private Label label1;
        private TextBox Txt_Occupation;
        private Label label2;
        private TextBox Txt_Income;
        private Label label3;
        private TextBox Txt_Age;
        private Label label4;
        private Label label5;
        private TextBox Txt_Anniversary;
        private TextBox Txt_MaritalStatus;
        private Label label6;
        private RadioButton Rdo_Male;
        private RadioButton Rdo_Female;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}