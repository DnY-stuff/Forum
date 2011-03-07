using System.Collections.Generic;

namespace DnY.Forum.Domain.Model
{
    public interface IMemberRepository
    {
        Member Find(Email email);
        IList<Member> FindAll();
        void Store(Member member);
    }
}