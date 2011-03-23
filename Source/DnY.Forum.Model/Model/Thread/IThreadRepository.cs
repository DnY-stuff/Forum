using System;
using System.Collections.Generic;

namespace DnY.Forum.Domain.Model
{
    public interface IThreadRepository
    {
        Thread Find(Guid threadId);
        void Store(Thread thread);
    }
}