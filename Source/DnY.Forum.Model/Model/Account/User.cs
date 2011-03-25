namespace DnY.Forum.Domain.Model
{
    using System;
    using Infrastructure.Builders;

    /// <summary>
    /// 사용자
    /// </summary>
    public class User
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; private set; }
        
        /// <summary>
        /// 이메일
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 패스워드
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 성명
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 사용자타입
        /// </summary>
        public UserType Type { get; set; }

        /// <summary>
        /// 생성일
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 수정일
        /// </summary>
        public DateTime UpdateDate { get; set; }

        /// <summary>
        /// 생성자
        /// </summary>
        public User(string emailaddress, string password, string name)
        {
            if (string.IsNullOrEmpty(emailaddress))
                throw new ArgumentNullException("emailaddress", "사용자는 반드시 이메일주소가 요구됩니다.");

            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException("password", "사용자는 반드시 비밀번호가 요구됩니다.");

            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name", "사용자는 반드시 성명이 요구됩니다.");


            // TODO : ORM 연계시, 수정되어야 합니다.
            Id = Guid.NewGuid();

            Email = emailaddress;
            Password = password;
            Name = name;
            Type = UserType.Member;

            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
        }

        public override bool Equals(object obj)
        {
            // TODO : EqualsBuilder를 구현하여 호출할 것
            if (this == obj)
                return true;

            if (obj is Forum)
            {
                return false;
            }

            return Id.Equals(((User)obj).Id);
        }

        public override int GetHashCode()
        {
            // TODO : HashCodeBuilder를 구현하여 호출할 것
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return ToStringBuilder.ReflectionToString(this);
        }
    }
}