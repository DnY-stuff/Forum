using System;

namespace DnY.Forum.Domain.Model
{
    public class Member
    {
        public Email Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        //public MemberType Type { get; set; }
        public DateTime CreateDate { get; set; }
    }
}