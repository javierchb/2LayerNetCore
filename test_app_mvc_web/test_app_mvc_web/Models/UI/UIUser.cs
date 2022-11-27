namespace test_app_mvc_web.Models.UI
{
    public class UIUser
    {
        public UIUser()
        {
            ListUsers = new List<User>();
        }

        public List<User> ListUsers { get; set; }
    }
}
