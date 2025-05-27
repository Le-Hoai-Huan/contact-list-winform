namespace ContactList;

public partial class AddContactForm : Form
{
    public AddContactForm()
    {
        InitializeComponent();
        var nameLabel = new Label { Text = "Họ tên", Location = new System.Drawing.Point(10, 10), AutoSize = true };
        var nameTextBox = new TextBox { Location = new System.Drawing.Point(80, 10), Width = 200 };
        var phoneLabel = new Label { Text = "Số điện thoại", Location = new System.Drawing.Point(10, 40), AutoSize = true };
        var phoneTextBox = new TextBox { Location = new System.Drawing.Point(80, 40), Width = 200 };
        var saveButton = new Button { Text = "Lưu", Location = new System.Drawing.Point(80, 70) };
        saveButton.Click += (s, e) => { MessageBox.Show("Đã lưu!"); };
        this.Controls.Add(nameLabel);
        this.Controls.Add(nameTextBox);
        this.Controls.Add(phoneLabel);
        this.Controls.Add(phoneTextBox);
        this.Controls.Add(saveButton);
    }
    
}