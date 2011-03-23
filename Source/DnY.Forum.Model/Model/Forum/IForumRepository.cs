using System;
using System.Collections.Generic;

namespace DnY.Forum.Domain.Model
{
    public interface IForumRepository
    {
        Forum Find(Guid forumId);
        IList<Forum> FindAll();
        void Store(Forum forum);
        void Delete(Guid forumId);
    }
}