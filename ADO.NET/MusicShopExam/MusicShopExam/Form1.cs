namespace MusicShopExam
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void registerButton_Click(object sender, EventArgs e)
		{
			RegisterForm form = new RegisterForm();
			this.Hide();
			form.ShowDialog();
			this.Close();
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			LoginForm form = new LoginForm();
			this.Hide();
			form.ShowDialog();
			this.Close();
		}
	}
}