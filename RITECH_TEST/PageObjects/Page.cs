using RITECH_TEST.WrapperFactory;
using OpenQA.Selenium.Support.PageObjects;

namespace RITECH_TEST.PageObjects
{
    public static class Page
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(BrowserFactory.Driver, page);
            return page;
        }

        public static HomePage Home
        {
            get { return GetPage<HomePage>(); }
        }

        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }

        public static EditBook editBook
        {
            get { return GetPage<EditBook>(); }
        }

        public static BookManagement bookManagement
        {
            get { return GetPage<BookManagement>(); }
        }

        public static CreateBook createBook
        {
            get { return GetPage<CreateBook>(); }
        }

        public static CreateAuthor createAuthor
        {
            get { return GetPage<CreateAuthor>(); }
        }
        
        public static AuthorManagement authorManagement
        {
            get { return GetPage<AuthorManagement>(); }
        }
        
    }
}