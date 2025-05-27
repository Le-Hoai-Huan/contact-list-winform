namespace ContactList;

public partial class AddContactForm : Form
{
    private TextBox nameTextBox;
    private TextBox phoneTextBox;
    private Button saveButton; // Khai báo nút Lưu

    public string ContactName => nameTextBox.Text;
    public string ContactPhone => phoneTextBox.Text;
    public string ContactEmail => emailTextBox.Text;
    public AddContactForm()
    {
        InitializeComponent();
        nameTextBox = new TextBox { Location = new Point(80, 10), Width = 200 };
        phoneTextBox = new TextBox { Location = new Point(80, 40), Width = 200 };
        emailTextBox = new TextBox { Location = new Point(80, 70), Width = 200 }; // TextBox cho Email
        saveButton = new Button { Text = "Lưu", Location = new Point(80, 100), Width = 100 };

        // Gán sự kiện Click cho nút Lưu
        saveButton.Click += SaveButton_Click;

        // Thêm các thành phần vào form
        this.Controls.Add(new Label { Text = "Họ tên", Location = new Point(10, 10), AutoSize = true });
        this.Controls.Add(nameTextBox);
        this.Controls.Add(new Label { Text = "Số điện thoại", Location = new Point(10, 40), AutoSize = true });
        this.Controls.Add(phoneTextBox);
        this.Controls.Add(new Label { Text = "Email", Location = new Point(10, 70), AutoSize = true }); // Label cho Email
        this.Controls.Add(emailTextBox);
        this.Controls.Add(saveButton);
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(nameTextBox.Text) &&
            !string.IsNullOrWhiteSpace(phoneTextBox.Text) &&
            !string.IsNullOrWhiteSpace(emailTextBox.Text))
        {
            DialogResult = DialogResult.OK; // Báo hiệu lưu thành công
            Close();
        }
        else
        {
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
        }
    }

    private void AddContactForm_Load(object sender, EventArgs e)
    {
        // Có thể thêm logic khi form được tải, ví dụ: làm trống các trường nhập
        nameTextBox.Text = string.Empty;
        phoneTextBox.Text = string.Empty;
        emailTextBox.Text = string.Empty;
    }

    private void AddContactForm_Load_1(object sender, EventArgs e)
    {

    }

    private void emailTextBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void phoneTextBox_TextChanged(object sender, EventArgs e)
    {

    }
}