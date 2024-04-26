namespace WinForms_Anket
{
    partial class Form1
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
            panel1 = new Panel();
            add_btn = new Button();
            change_btn = new Button();
            dateTimePicker1 = new DateTimePicker();
            PhoneBox = new TextBox();
            EmailBox = new TextBox();
            SurnameBox = new TextBox();
            NameBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            Save_btn = new Button();
            Load_btn = new Button();
            FileNameBox = new TextBox();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(add_btn);
            panel1.Controls.Add(change_btn);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(PhoneBox);
            panel1.Controls.Add(EmailBox);
            panel1.Controls.Add(SurnameBox);
            panel1.Controls.Add(NameBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(28, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 426);
            panel1.TabIndex = 0;
            // 
            // add_btn
            // 
            add_btn.BackColor = SystemColors.ActiveCaption;
            add_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            add_btn.Location = new Point(237, 372);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(94, 29);
            add_btn.TabIndex = 11;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // change_btn
            // 
            change_btn.BackColor = SystemColors.ActiveCaption;
            change_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            change_btn.Location = new Point(90, 372);
            change_btn.Name = "change_btn";
            change_btn.Size = new Size(94, 29);
            change_btn.TabIndex = 10;
            change_btn.Text = "Change";
            change_btn.UseVisualStyleBackColor = false;
            change_btn.Visible = false;
            change_btn.Click += change_btn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(147, 279);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(147, 223);
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new Size(250, 27);
            PhoneBox.TabIndex = 8;
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(147, 157);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(250, 27);
            EmailBox.TabIndex = 7;
            // 
            // SurnameBox
            // 
            SurnameBox.Location = new Point(147, 95);
            SurnameBox.Name = "SurnameBox";
            SurnameBox.Size = new Size(250, 27);
            SurnameBox.TabIndex = 6;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(147, 37);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(250, 27);
            NameBox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AccessibleRole = AccessibleRole.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 0, 192);
            label5.Location = new Point(18, 279);
            label5.Name = "label5";
            label5.Size = new Size(99, 31);
            label5.TabIndex = 4;
            label5.Text = "Birthday";
            // 
            // label4
            // 
            label4.AccessibleRole = AccessibleRole.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(23, 217);
            label4.Name = "label4";
            label4.Size = new Size(84, 31);
            label4.TabIndex = 3;
            label4.Text = "Phone ";
            // 
            // label3
            // 
            label3.AccessibleRole = AccessibleRole.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(23, 151);
            label3.Name = "label3";
            label3.Size = new Size(70, 31);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AccessibleRole = AccessibleRole.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(18, 89);
            label2.Name = "label2";
            label2.Size = new Size(104, 31);
            label2.TabIndex = 1;
            label2.Text = "Surname";
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(18, 33);
            label1.Name = "label1";
            label1.Size = new Size(75, 31);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // panel2
            // 
            panel2.Controls.Add(Save_btn);
            panel2.Controls.Add(Load_btn);
            panel2.Controls.Add(FileNameBox);
            panel2.Controls.Add(listBox1);
            panel2.Location = new Point(465, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(308, 426);
            panel2.TabIndex = 1;
            // 
            // Save_btn
            // 
            Save_btn.BackColor = SystemColors.ActiveCaption;
            Save_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Save_btn.Location = new Point(165, 372);
            Save_btn.Name = "Save_btn";
            Save_btn.Size = new Size(94, 29);
            Save_btn.TabIndex = 3;
            Save_btn.Text = "Save";
            Save_btn.UseVisualStyleBackColor = false;
            Save_btn.Click += Save_btn_Click;
            // 
            // Load_btn
            // 
            Load_btn.BackColor = SystemColors.ActiveCaption;
            Load_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Load_btn.Location = new Point(44, 372);
            Load_btn.Name = "Load_btn";
            Load_btn.Size = new Size(94, 29);
            Load_btn.TabIndex = 2;
            Load_btn.Text = "Load";
            Load_btn.UseVisualStyleBackColor = false;
            Load_btn.Click += Load_btn_Click;
            // 
            // FileNameBox
            // 
            FileNameBox.Location = new Point(26, 325);
            FileNameBox.Name = "FileNameBox";
            FileNameBox.Size = new Size(244, 27);
            FileNameBox.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(3, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(302, 304);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button Save_btn;
        private Button Load_btn;
        private TextBox FileNameBox;
        private ListBox listBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox EmailBox;
        private TextBox SurnameBox;
        private TextBox NameBox;
        private Button add_btn;
        private Button change_btn;
        private DateTimePicker dateTimePicker1;
        private TextBox PhoneBox;
    }
}
