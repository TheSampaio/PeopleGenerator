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
            txt_Anniversary = new TextBox();
            txt_MaritalStatus = new TextBox();
            label6 = new Label();
            rdo_Male = new RadioButton();
            rdo_Female = new RadioButton();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Generate
            // 
            btn_Generate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Generate.Location = new Point(135, 261);
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
            txt_Name.Location = new Point(85, 25);
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
            label1.Location = new Point(21, 35);
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
            txt_Occupation.Location = new Point(103, 160);
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
            label2.Location = new Point(21, 170);
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
            txt_Income.Location = new Point(103, 193);
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
            label3.Location = new Point(21, 203);
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
            txt_Age.Location = new Point(275, 58);
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
            // txt_Anniversary
            // 
            txt_Anniversary.BackColor = Color.White;
            txt_Anniversary.BorderStyle = BorderStyle.FixedSingle;
            txt_Anniversary.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Anniversary.Location = new Point(85, 58);
            txt_Anniversary.Margin = new Padding(4);
            txt_Anniversary.MaxLength = 30;
            txt_Anniversary.Name = "txt_Anniversary";
            txt_Anniversary.ReadOnly = true;
            txt_Anniversary.Size = new Size(125, 25);
            txt_Anniversary.TabIndex = 1;
            // 
            // txt_MaritalStatus
            // 
            txt_MaritalStatus.BackColor = Color.White;
            txt_MaritalStatus.BorderStyle = BorderStyle.FixedSingle;
            txt_MaritalStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaritalStatus.Location = new Point(113, 91);
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
            label6.Location = new Point(21, 101);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 2;
            label6.Text = "Marital Status: ";
            // 
            // rdo_Male
            // 
            rdo_Male.AutoSize = true;
            rdo_Male.Checked = true;
            rdo_Male.Location = new Point(21, 250);
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
            rdo_Female.Location = new Point(21, 275);
            rdo_Female.Name = "rdo_Female";
            rdo_Female.Size = new Size(63, 19);
            rdo_Female.TabIndex = 3;
            rdo_Female.Text = "Female";
            rdo_Female.UseVisualStyleBackColor = true;
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
            panel1.Controls.Add(txt_Name);
            panel1.Controls.Add(txt_Occupation);
            panel1.Controls.Add(btn_Generate);
            panel1.Controls.Add(rdo_Female);
            panel1.Controls.Add(txt_Income);
            panel1.Controls.Add(txt_Age);
            panel1.Controls.Add(rdo_Male);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_Anniversary);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txt_MaritalStatus);
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
        private TextBox txt_Anniversary;
        private TextBox txt_MaritalStatus;
        private Label label6;
        private RadioButton rdo_Male;
        private RadioButton rdo_Female;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}