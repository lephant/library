using System;
using System.Windows.Forms;

namespace library.Forms
{
    public partial class ShowBooksForm : Form
    {
        public ShowBooksForm()
        {
            InitializeComponent();
        }

        private void SearchFlowLayoutPanel_Resize(object sender, EventArgs e)
        {
            int authorsPaddings = AuthorsListBox.Margin.Left + AuthorsListBox.Margin.Right;
            int authorsWidth = SearchFlowLayoutPanel.Width - authorsPaddings;

            int publishersPaddings = PublishersListBox.Margin.Left + PublishersListBox.Margin.Right;
            int publishersWidth = SearchFlowLayoutPanel.Width - publishersPaddings;

            int placesPaddings = PlacesListBox.Margin.Left + PlacesListBox.Margin.Right;
            int placesWidth = SearchFlowLayoutPanel.Width - placesPaddings;

            int usageCategoriesPaddings = UsageCategoriesListBox.Margin.Left + UsageCategoriesListBox.Margin.Right;
            int usageCategoriesWidth = SearchFlowLayoutPanel.Width - usageCategoriesPaddings;

            AuthorsListBox.Width = authorsWidth;
            PublishersListBox.Width = publishersWidth;
            PlacesListBox.Width = placesWidth;
            UsageCategoriesListBox.Width = usageCategoriesWidth;
        }
    }
}
