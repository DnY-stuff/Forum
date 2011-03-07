using System;
using System.Collections.Generic;

namespace DnY.Forum.Domain.Model
{
    public class Forum
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public IList<Member> Moderators { get; set; }
    }
}