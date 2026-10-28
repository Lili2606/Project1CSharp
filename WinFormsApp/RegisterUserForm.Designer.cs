namespace WinFormsApp
{
    partial class RegisterUserForm
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
            firstNameTextBox = new TextBox();
            Label = new Label();
            label2 = new Label();
            lastNameTextBox = new TextBox();
            label3 = new Label();
            mobileTextBox = new TextBox();
            label4 = new Label();
            nationalCodeTextBox = new TextBox();
            searchUserButton = new Button();
            createUserButton = new Button();
            userDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            SuspendLayout();
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(145, 47);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(179, 27);
            firstNameTextBox.TabIndex = 0;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Location = new Point(49, 50);
            Label.Name = "Label";
            Label.Size = new Size(27, 20);
            Label.TabIndex = 7;
            Label.Text = "نام";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 104);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 9;
            label2.Text = "نام خانوادگی";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(145, 101);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(179, 27);
            lastNameTextBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 163);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 11;
            label3.Text = "شماره تلفن";
            // 
            // mobileTextBox
            // 
            mobileTextBox.Location = new Point(145, 160);
            mobileTextBox.Name = "mobileTextBox";
            mobileTextBox.Size = new Size(179, 27);
            mobileTextBox.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 223);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 13;
            label4.Text = "کد ملی";
            // 
            // nationalCodeTextBox
            // 
            nationalCodeTextBox.Location = new Point(145, 220);
            nationalCodeTextBox.Name = "nationalCodeTextBox";
            nationalCodeTextBox.Size = new Size(179, 27);
            nationalCodeTextBox.TabIndex = 12;
            // 
            // searchUserButton
            // 
            searchUserButton.Location = new Point(49, 275);
            searchUserButton.Name = "searchUserButton";
            searchUserButton.Size = new Size(275, 40);
            searchUserButton.TabIndex = 14;
            searchUserButton.Text = "جستجو";
            searchUserButton.UseVisualStyleBackColor = true;
            // 
            // createUserButton
            // 
            createUserButton.Location = new Point(49, 321);
            createUserButton.Name = "createUserButton";
            createUserButton.Size = new Size(275, 43);
            createUserButton.TabIndex = 15;
            createUserButton.Text = "ایجاد کاربر";
            createUserButton.UseVisualStyleBackColor = true;
            createUserButton.Click += createUserButton_Click;
            // 
            // userDataGridView
            // 
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGridView.Location = new Point(355, 47);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.RowHeadersWidth = 51;
            userDataGridView.Size = new Size(540, 317);
            userDataGridView.TabIndex = 16;
            // 
            // RegisterUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 450);
            Controls.Add(userDataGridView);
            Controls.Add(createUserButton);
            Controls.Add(searchUserButton);
            Controls.Add(label4);
            Controls.Add(nationalCodeTextBox);
            Controls.Add(label3);
            Controls.Add(mobileTextBox);
            Controls.Add(label2);
            Controls.Add(lastNameTextBox);
            Controls.Add(Label);
            Controls.Add(firstNameTextBox);
            Name = "RegisterUserForm";
            Text = "RegisterUserForm";
            ((System.ComponentModel.ISupportInitialize)userDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameTextBox;
        private Label Label;
        private Label label2;
        private TextBox lastNameTextBox;
        private Label label3;
        private TextBox mobileTextBox;
        private Label label4;
        private TextBox nationalCodeTextBox;
        private Button searchUserButton;
        private Button createUserButton;
        private DataGridView userDataGridView;
    }
}