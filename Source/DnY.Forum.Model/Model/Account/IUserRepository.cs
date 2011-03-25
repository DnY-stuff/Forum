using System;
using System.Collections.Generic;

namespace DnY.Forum.Domain.Model
{
    public interface IUserRepository
    {
        User Find(Guid id);
        IList<User> FindAll();
        void Store(User user);
    }
}