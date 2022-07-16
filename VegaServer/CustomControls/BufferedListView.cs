namespace VegaServer.CustomControls
{
    /// <summary>
    /// ダブルバッファの設定が有効化された ListView コントロール
    /// </summary>
    public partial class BufferedListView : ListView
    {
        protected override bool DoubleBuffered { get { return true; } set { } }

        public BufferedListView()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
