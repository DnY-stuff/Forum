using System;
using System.Collections.Generic;

namespace DnY.Forum.Domain.Model
{
    public class Thread
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public Post OriginalPost { get; set; }
        public IList<Post> Replies { get; set; }
        public Forum CurrentForum { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}