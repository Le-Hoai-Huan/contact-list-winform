using System.ComponentModel;

namespace ContactList;

partial class AddContactForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        nameTextBox = new TextBox();
        phoneTextBox = new TextBox();
        saveButton = new Button();
        EmailTexbox = new TextBox();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        SuspendLayout();
        // 
        // nameTextBox
        // 
        nameTextBox.Location = new Point(259, 57);
        nameTextBox.Name = "nameTextBox";
        nameTextBox.Size = new Size(200, 27);
        nameTextBox.TabIndex = 1;
        // 
        // phoneTextBox
        // 
        phoneTextBox.Location = new Point(259, 103);
        phoneTextBox.Name = "phoneTextBox";
        phoneTextBox.Size = new Size(200, 27);
        phoneTextBox.TabIndex = 2;
        phoneTextBox.TextChanged += phoneTextBox_TextChanged;
        // 
        // saveButton
        // 
        saveButton.Location = new Point(307, 223);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(100, 30);
        saveButton.TabIndex = 4;
        saveButton.Text = "Lưu";
        saveButton.UseVisualStyleBackColor = true;
        saveButton.Click += SaveButton_Click;
        // 
        // EmailTexbox
        // 
        EmailTexbox.Location = new Point(259, 150);
        EmailTexbox.Name = "EmailTexbox";
        EmailTexbox.Size = new Size(200, 27);
        EmailTexbox.TabIndex = 7;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(191, 157);
        label1.Name = "label1";
        label1.Size = new Size(50, 20);
        label1.TabIndex = 8;
        label1.Text = "Email ";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(191, 60);
        label2.Name = "label2";
        label2.Size = new Size(50, 20);
        label2.TabIndex = 9;
        label2.Text = "Phone";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(191, 110);
        label3.Name = "label3";
        label3.Size = new Size(25, 20);
        label3.TabIndex = 10;
        label3.Text = "Dt";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(191, 199);
        label4.Name = "label4";
        label4.Size = new Size(130, 20);
        label4.TabIndex = 11;
        label4.Text = "Thông tin bổ xung";
        // 
        // AddContactForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(EmailTexbox);
        Controls.Add(saveButton);
        Controls.Add(phoneTextBox);
        Controls.Add(nameTextBox);
        Name = "AddContactForm";
        Text = "AddContactForm";
        Load += AddContactForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox EmailTexbox;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
}