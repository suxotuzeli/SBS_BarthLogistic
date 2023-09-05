using System.Drawing;
using System.Windows.Forms;

namespace SBS_Moms.Controls
{
    public sealed partial class FMGListControl : ListBox
    {
        public FMGListControl()
        {
            ItemHeight = 60 + Margin.Vertical;
            InitializeComponent();
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (Items.Count <= 0 || e.Index <= -1) return;
            var item = (FMGListBoxItem)Items[e.Index];
            item.drawItem(e, Margin, new Font(Font, FontStyle.Bold), new Font(Font, FontStyle.Regular));
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }

    public class FMGListBoxItem
    {
        public FMGListBoxItem(string id, string title, string details, bool isLeft, bool isMyselft)
        {
            Id = id;
            Title = title;
            Details = details;
            IsLeft = isLeft;
            IsMyselft = isMyselft;
        }

        public string Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public bool IsLeft { get; set; }
        public bool IsMyselft { get; set; }

        public void drawItem(DrawItemEventArgs e, Padding margin, Font titleFont, Font detailsFont)
        {
            e.Graphics.FillRectangle(
                (e.State & DrawItemState.Selected) == DrawItemState.Selected
                    ? Brushes.CornflowerBlue : Brushes.Beige, e.Bounds);

            e.Graphics.DrawLine(Pens.Black, e.Bounds.X, e.Bounds.Y, e.Bounds.X + e.Bounds.Width, e.Bounds.Y);

            //            e.Graphics.DrawImage(ItemImage, e.Bounds.X + margin.Left, e.Bounds.Y + margin.Top, imageSize.Width,
            //                imageSize.Height);

            var titleBounds = new Rectangle(e.Bounds.X + margin.Horizontal + 0,
                e.Bounds.Y + margin.Top,
                e.Bounds.Width - margin.Right - 0 - margin.Horizontal,
                (int)titleFont.GetHeight() + 2);

            var detailBounds = new Rectangle(e.Bounds.X + margin.Horizontal + 0,
                e.Bounds.Y + (int)titleFont.GetHeight() + 2 + margin.Vertical + margin.Top,
                e.Bounds.Width - margin.Right - 0 - margin.Horizontal,
                e.Bounds.Height - margin.Bottom - (int)titleFont.GetHeight() - 2 - margin.Vertical - margin.Top);

            var fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Near;
            fmt.LineAlignment = StringAlignment.Near;

            e.Graphics.DrawString(Title, titleFont, Brushes.Black, titleBounds, fmt);

            if (IsLeft)
            {
                fmt.Alignment = StringAlignment.Far;
                fmt.LineAlignment = StringAlignment.Far;
            }

            e.Graphics.DrawString(Details, detailsFont, Brushes.Black, detailBounds, fmt);

            e.DrawFocusRectangle();
        }
    }
}