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

            MenuItem editAuthorMenuItem = new MenuItem("Редактировать");
            editAuthorMenuItem.Click += EditAuthorMenuItemOnClick;
            MenuItem deleteAuthorMenuItem = new MenuItem("Удалить");
            deleteAuthorMenuItem.Click += DeleteAuthorMenuItemOnClick;
            ContextMenu authorContextMenu = new ContextMenu(new[]
            {
                editAuthorMenuItem,
                deleteAuthorMenuItem
            });
            AuthorsListBox.ContextMenu = authorContextMenu;

            MenuItem editPublisherMenuItem = new MenuItem("Редактировать");
            editPublisherMenuItem.Click += EditPublisherMenuItemOnClick;
            MenuItem deletePublisherMenuItem = new MenuItem("Удалить");
            deletePublisherMenuItem.Click += DeletePublisherMenuItemOnClick;
            ContextMenu publisherContextMenu = new ContextMenu(new[]
            {
                editPublisherMenuItem,
                deletePublisherMenuItem
            });
            PublishersListBox.ContextMenu = publisherContextMenu;

            MenuItem editPlaceMenuItem = new MenuItem("Редактировать");
            editPlaceMenuItem.Click += EditPlaceMenuItemOnClick;
            MenuItem deletePlaceMenuItem = new MenuItem("Удалить");
            deletePlaceMenuItem.Click += DeletePlaceMenuItemOnClick;
            ContextMenu placeContextMenu = new ContextMenu(new[]
            {
                editPlaceMenuItem,
                deletePlaceMenuItem
            });
            PlacesListBox.ContextMenu = placeContextMenu;

            MenuItem editUsageCategoryMenuItem = new MenuItem("Редактировать");
            editUsageCategoryMenuItem.Click += EditUsageCategoryMenuItemOnClick;
            MenuItem deleteUsageCategoryMenuItem = new MenuItem("Удалить");
            deleteUsageCategoryMenuItem.Click += DeleteUsageCategoryMenuItemOnClick;
            ContextMenu usageCategoryContextMenu = new ContextMenu(new []
            {
                editUsageCategoryMenuItem,
                deleteUsageCategoryMenuItem
            });
            UsageCategoriesListBox.ContextMenu = usageCategoryContextMenu;
        }

        private void ShowBooksForm_Load(object sender, EventArgs e)
        {
            AuthorsListBox.DataSource = new AuthorDao().GetList();
            PublishersListBox.DataSource = new PublisherDao().GetList();
            PlacesListBox.DataSource = new PlaceDao().GetList();
            UsageCategoriesListBox.DataSource = new UsageCategoryDao().GetList();
        }

        private void AddAuthorButton_Click(object sender, EventArgs e)
        {
            TextDialog textDialog = new TextDialog();
            textDialog.FormText = "Создание автора";
            textDialog.ShowDialog(this);
            if (textDialog.OkResult)
            {
                Author author = new Author();
                author.Name = textDialog.EditedText;
                AuthorDao authorDao = new AuthorDao();
                authorDao.Insert(author);
                AuthorsListBox.DataSource = authorDao.GetList();
            }
        }

        private void EditAuthorMenuItemOnClick(object sender, EventArgs eventArgs)
        {
            int clickedIndex = AuthorsListBox.ContextMenuItemIndex;
            Author author = (Author)AuthorsListBox.Items[clickedIndex];
            TextDialog textDialog = new TextDialog();
            textDialog.EditedText = author.Name;
            textDialog.FormText = "Редактирование автора";
            textDialog.ShowDialog(this);
            if (textDialog.OkResult)
            {
                author.Name = textDialog.EditedText;
                AuthorDao authorDao = new AuthorDao();
                authorDao.Update(author);
                AuthorsListBox.DataSource = authorDao.GetList();
            }
        }

        private void DeleteAuthorMenuItemOnClick(object sender, EventArgs eventArgs)
        {
            int clickedIndex = AuthorsListBox.ContextMenuItemIndex;
            Author author = (Author)AuthorsListBox.Items[clickedIndex];
            DialogResult dialogResult = MessageBox.Show(this,
                "Вы уверены, что хотите удалить автора \"" + author.Name + "\"?",
                "Удаление автора",
                MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                AuthorDao authorDao = new AuthorDao();
                authorDao.Delete(author);
                AuthorsListBox.DataSource = authorDao.GetList();
            }
        }

        private void AddPublisherButton_Click(object sender, EventArgs e)
        {
            TextDialog textDialog = new TextDialog();
            textDialog.FormText = "Создание издательства";
            textDialog.ShowDialog(this);
            if (textDialog.OkResult)
            {
                Publisher publisher = new Publisher();
                publisher.Name = textDialog.EditedText;
                PublisherDao publisherDao = new PublisherDao();
                publisherDao.Insert(publisher);
                PublishersListBox.DataSource = publisherDao.GetList();
            }
        }

        private void EditPublisherMenuItemOnClick(object sender, EventArgs eventArgs)
        {
            int clickedIndex = PublishersListBox.ContextMenuItemIndex;
            Publisher publisher = (Publisher)PublishersListBox.Items[clickedIndex];
            TextDialog textDialog = new TextDialog();
            textDialog.FormText = "Редактирование издательства";
            textDialog.EditedText = publisher.Name;
            textDialog.ShowDialog(this);
            if (textDialog.OkResult)
            {
                publisher.Name = textDialog.EditedText;
                PublisherDao publisherDao = new PublisherDao();
                publisherDao.Update(publisher);
                PublishersListBox.DataSource = publisherDao.GetList();
            }
        }

        private void DeletePublisherMenuItemOnClick(object sender, EventArgs eventArgs)
        {
            
        }

        private void EditPlaceMenuItemOnClick(object sender, EventArgs eventArgs)
        {

        }

        private void DeletePlaceMenuItemOnClick(object sender, EventArgs eventArgs)
        {

        }

        private void EditUsageCategoryMenuItemOnClick(object sender, EventArgs eventArgs)
        {

        }

        private void DeleteUsageCategoryMenuItemOnClick(object sender, EventArgs eventArgs)
        {

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