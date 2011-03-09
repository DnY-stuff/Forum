using System;
using System.Collections.Generic;

namespace DnY.Forum.Domain.Model
{
    public interface IMemberRepository
    {
        Member Find(Guid id);
        IList<Member> FindAll();
        void Store(Member member);
    }
}