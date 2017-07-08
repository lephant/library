using System;
using System.Collections.Generic;
using System.Windows.Forms;
using library.DAO.Impl;
using library.Model;

namespace library.Forms
{
    public partial class ShowBooksForm : Form
    {
        public ShowBooksForm()
        {
            InitializeComponent();
        }

        private void ShowBooksForm_Load(object sender, EventArgs e)
        {
            AuthorsListBox.DataSource = new AuthorDao().GetList();
            PublishersListBox.DataSource = new PublisherDao().GetList();
            PlacesListBox.DataSource = new PlaceDao().GetList();
            UsageCategoriesListBox.DataSource = new UsageCategoryDao().GetList();
        }

        private void DelegateMouseEnterToPanel(object sender, EventArgs e)
        {
            SearchPanel.Focus();
        }

        private void SearchFlowLayoutPanel_Resize(object sender, EventArgs e)
        {
            int searchStringPaddings = SearchStringTextBox.Margin.Left + SearchStringTextBox.Margin.Right;
            int searchStringWidth = SearchFlowLayoutPanel.Width - searchStringPaddings;

            int authorsHeaderPaddings = AuthorsHeaderPanel.Margin.Left + AuthorsHeaderPanel.Margin.Right;
            int authorsHeaderWidth = SearchFlowLayoutPanel.Width - authorsHeaderPaddings;

            int authorsPaddings = AuthorsListBox.Margin.Left + AuthorsListBox.Margin.Right;
            int authorsWidth = SearchFlowLayoutPanel.Width - authorsPaddings;

            int publishersHeaderPaddings = PublishersHeaderPanel.Margin.Left + PublishersHeaderPanel.Margin.Right;
            int publishersHeaderWidth = SearchFlowLayoutPanel.Width - publishersHeaderPaddings;

            int publishersPaddings = PublishersListBox.Margin.Left + PublishersListBox.Margin.Right;
            int publishersWidth = SearchFlowLayoutPanel.Width - publishersPaddings;

            int placesHeaderPaddings = PlacesHeaderPanel.Margin.Left + PlacesHeaderPanel.Margin.Right;
            int placesHeaderWidth = SearchFlowLayoutPanel.Width - placesHeaderPaddings;

            int placesPaddings = PlacesListBox.Margin.Left + PlacesListBox.Margin.Right;
            int placesWidth = SearchFlowLayoutPanel.Width - placesPaddings;

            int usageCategoriesHeaderPaddings = UsageCategoriesHeaderPanel.Margin.Left + UsageCategoriesHeaderPanel.Margin.Right;
            int usageCategoriesHeaderWidth = SearchFlowLayoutPanel.Width - usageCategoriesHeaderPaddings;

            int usageCategoriesPaddings = UsageCategoriesListBox.Margin.Left + UsageCategoriesListBox.Margin.Right;
            int usageCategoriesWidth = SearchFlowLayoutPanel.Width - usageCategoriesPaddings;

            SearchStringTextBox.Width = searchStringWidth;
            AuthorsHeaderPanel.Width = authorsHeaderWidth;
            AuthorsListBox.Width = authorsWidth;
            PublishersHeaderPanel.Width = publishersHeaderWidth;
            PublishersListBox.Width = publishersWidth;
            PlacesHeaderPanel.Width = placesHeaderWidth;
            PlacesListBox.Width = placesWidth;
            UsageCategoriesHeaderPanel.Width = usageCategoriesHeaderWidth;
            UsageCategoriesListBox.Width = usageCategoriesWidth;
        }
    }
}