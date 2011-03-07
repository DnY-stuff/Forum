using System;

namespace DnY.Forum.Domain.Model
{
    public interface IThreadRepository
    {
        Thread Find(Guid id);
        void Store(Thread thread);
    }
}