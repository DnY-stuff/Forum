using System;
using System.Collections.Generic;

namespace DnY.Forum.Domain.Model
{
    public interface IForumRepository
    {
        Forum Find(Guid id);
        IList<Forum> FindAll();
        void Store(Forum forum);
    }
}