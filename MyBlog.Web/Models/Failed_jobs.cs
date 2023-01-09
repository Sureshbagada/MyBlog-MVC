namespace MyBlog.Web.Models
{
    public class Failed_jobs : Common
    {
        public int Id { get; set; }
        public string Connection { get; set; }
        public string Queue { get; set; }
        public string Payload { get; set; }
        public string Exception { get; set; }
        public DateTime FailedDTStamp { get; set; }

    }
}
