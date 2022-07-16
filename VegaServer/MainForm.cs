using VegaServer.Win32;

namespace VegaServer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            UxTheme.SetWindowTheme(serverListBox.Handle, "Explorer", null);

            ListViewItem item2 = new ListViewItem("item2");
            item2.SubItems.Add("avaliable");
            item2.SubItems.Add("114514");
            serverListBox.Items.Add(item2);
        }
    }
}