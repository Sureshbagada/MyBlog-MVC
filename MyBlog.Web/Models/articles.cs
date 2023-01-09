namespace MyBlog.Web.Models
{
    public class articles : Common
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public int user_id { get; set; }
        public int categoryid { get; set; }

    }
}
