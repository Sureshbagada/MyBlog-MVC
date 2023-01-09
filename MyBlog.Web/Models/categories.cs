using MessagePack;
using Microsoft.Build.Framework;

namespace MyBlog.Web.Models
{
    public class categories: Common
    {
   
        public int Id { get; set; }
        public string Name { get; set; }        

    }
}
