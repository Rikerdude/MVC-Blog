using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repoblog.Models.BaseModels;
using Repoblog.Models.ViewModels;

namespace Repoblog.Factories
{
    public class PostFac : AutoFac<Post>
    {
        BilledeFac bil = new BilledeFac();
        public List<BlogIndex> GetIndexData()
        {
            List<BlogIndex> listblogIndex = new List<BlogIndex>();
            foreach (var post in GetAll())
            {
                BlogIndex blogIndex = new BlogIndex();
                blogIndex.Post = post;
                blogIndex.Billeder = bil.GetBy("PostID", post.ID);
                listblogIndex.Add(blogIndex);
            }

            return listblogIndex;
        } 
    }
}
