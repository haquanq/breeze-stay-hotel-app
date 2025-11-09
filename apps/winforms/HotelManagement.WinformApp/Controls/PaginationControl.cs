using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Controls
{
    public partial class PaginationControl : UserControl
    {
        private int _totalPages;
        public int TotalPages
        {
            get { return _totalPages; }
            set
            {
                _totalPages = value;
                HandlePaginationChange();
            }
        }
        public int CurrentPage { get; set; } = 1;

        public event EventHandler OnPaginationChange;

        public PaginationControl()
        {
            InitializeComponent();

            btnPage1.Click += HandlePageNumberClick;
            btnPage2.Click += HandlePageNumberClick;
            btnPage3.Click += HandlePageNumberClick;
            btnPage4.Click += HandlePageNumberClick;
            btnPage5.Click += HandlePageNumberClick;
            btnPage6.Click += HandlePageNumberClick;
            btnPage7.Click += HandlePageNumberClick;
            btnPage8.Click += HandlePageNumberClick;

            btnPageNext.Click += HandlePageNumberClick;
            btnPagePrev.Click += HandlePageNumberClick;
        }

        private void HandlePageNumberClick(object s, EventArgs e)
        {
            Button currButton = (Button)s;

            if (currButton.Text == "<")
            {
                if (CurrentPage == 1) return;
                CurrentPage--;
            }
            else if (currButton.Text == ">")
            {
                if (CurrentPage == TotalPages) return;
                CurrentPage++;
            }
            else
            {
                CurrentPage = Convert.ToInt32(currButton.Text);
            }

            OnPaginationChange?.Invoke(s, EventArgs.Empty);
            HandlePaginationChange();
        }

        private void HandlePaginationChange()
        {
            btnPage2.Visible = 2 <= TotalPages;
            btnPage3.Visible = 3 <= TotalPages;
            btnPage4.Visible = 4 <= TotalPages;
            btnPage5.Visible = 5 <= TotalPages;
            btnPage6.Visible = 6 <= TotalPages;
            btnPage7.Visible = 7 <= TotalPages;
            btnPage8.Visible = 8 <= TotalPages;

            bool farFromLeft = CurrentPage - 1 >= 5;
            bool farFromRight = TotalPages - CurrentPage >= 5;

            if (farFromRight)
            {
                if (btnPage7.Enabled && TotalPages > 8)
                {
                    btnPage7.Text = "--";
                    btnPage7.Enabled = false;
                    btnPage8.Text = (TotalPages - 0).ToString();
                }
            }
            else
            {
                btnPage3.Text = (TotalPages - 5).ToString();
                btnPage4.Text = (TotalPages - 4).ToString();
                btnPage5.Text = (TotalPages - 3).ToString();
                btnPage6.Text = (TotalPages - 2).ToString();
                btnPage7.Text = (TotalPages - 1).ToString();
                btnPage7.Enabled = true;
                btnPage8.Text = TotalPages.ToString();
            }

            if (farFromLeft)
            {
                if (btnPage2.Enabled && TotalPages > 8)
                {
                    btnPage2.Text = "--";
                    btnPage2.Enabled = false;
                }
            }
            else
            {
                btnPage2.Text = "2";
                btnPage2.Enabled = true;
                btnPage3.Text = "3";
                btnPage4.Text = "4";
                btnPage5.Text = "5";
                btnPage6.Text = "6";
                btnPage8.Text = TotalPages.ToString();
                if (TotalPages <= 8)
                {
                    btnPage7.Text = "7";
                }
            }

            if (farFromLeft && farFromRight)
            {
                btnPage3.Text = (CurrentPage - 1).ToString();
                btnPage4.Text = (CurrentPage - 0).ToString();
                btnPage5.Text = (CurrentPage + 1).ToString();
                btnPage6.Text = (CurrentPage + 2).ToString();
                btnPage8.Text = TotalPages.ToString();
            }

            foreach (Button currButton in fpnPaginationMenu.Controls)
            {
                if (int.TryParse(currButton.Text, out int val) && val == CurrentPage)
                {
                    currButton.ForeColor = Color.White;
                    currButton.BackColor = Color.SteelBlue;
                    continue;
                }
                currButton.ForeColor = Color.FromArgb(38, 38, 38);
                currButton.BackColor = Color.Gainsboro;
            }
        }
    }
}
