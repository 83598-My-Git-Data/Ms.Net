namespace _08Demo_Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button button1 = new Button();
            button1.Text = "Click Me";

            EventHandler pointer = new EventHandler(CallMe);

           // pointer(null, new EventArgs());
            button1.Click += pointer;

            this.Controls.Add(button1);
        }

        public void CallMe(object sender, EventArgs args)
        {
            MessageBox.Show("This is Test");
        }
    }
}
