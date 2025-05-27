namespace ContactList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            using (AddContactForm addContactForm = new AddContactForm())
            {
                if (addContactForm.ShowDialog() == DialogResult.OK)
                {
                    string name = addContactForm.ContactName;
                    string phone = addContactForm.ContactPhone;
                    string email = addContactForm.ContactEmail; // Lấy Email
                    MessageBox.Show($"Liên hệ đã được thêm: {name} - {phone} - {email}");
                    // Thêm logic để lưu hoặc hiển thị danh sách liên hệ
                }
            }
        }
    }
}
