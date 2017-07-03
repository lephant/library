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
            FillAuthorsList();
            FillPublishersList();
            FillPlacesList();
            FillUsageCategoryList();
        }

        private void FillAuthorsList()
        {
            AuthorDao authorDao = new AuthorDao();
            List<Author> list = authorDao.GetList();
            AuthorsListBox.DataSource = list;
        }

        private void FillPublishersList()
        {
            PublisherDao publisherDao = new PublisherDao();
            List<Publisher> list = publisherDao.GetList();
            PublishersListBox.DataSource = list;
        }

        private void FillPlacesList()
        {
            PlaceDao placeDao = new PlaceDao();
            List<Place> list = placeDao.GetList();
            PlacesListBox.DataSource = list;
        }

        private void FillUsageCategoryList()
        {
            UsageCategoryDao usageCategoryDao = new UsageCategoryDao();
            List<UsageCategory> list = usageCategoryDao.GetList();
            UsageCategoriesListBox.DataSource = list;
        }

        private void SearchFlowLayoutPanel_Resize(object sender, EventArgs e)
        {
            int searchStringPaddings = SearchStringTextBox.Margin.Left + SearchStringTextBox.Margin.Right;
            int searchStringWidth = SearchFlowLayoutPanel.Width - searchStringPaddings;

            int authorsPaddings = AuthorsListBox.Margin.Left + AuthorsListBox.Margin.Right;
            int authorsWidth = SearchFlowLayoutPanel.Width - authorsPaddings;

            int publishersPaddings = PublishersListBox.Margin.Left + PublishersListBox.Margin.Right;
            int publishersWidth = SearchFlowLayoutPanel.Width - publishersPaddings;

            int placesPaddings = PlacesListBox.Margin.Left + PlacesListBox.Margin.Right;
            int placesWidth = SearchFlowLayoutPanel.Width - placesPaddings;

            int usageCategoriesPaddings = UsageCategoriesListBox.Margin.Left + UsageCategoriesListBox.Margin.Right;
            int usageCategoriesWidth = SearchFlowLayoutPanel.Width - usageCategoriesPaddings;

            SearchStringTextBox.Width = searchStringWidth;
            AuthorsListBox.Width = authorsWidth;
            PublishersListBox.Width = publishersWidth;
            PlacesListBox.Width = placesWidth;
            UsageCategoriesListBox.Width = usageCategoriesWidth;
        }
    }
}