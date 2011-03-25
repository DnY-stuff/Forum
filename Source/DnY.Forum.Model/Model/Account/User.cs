namespace DnY.Forum.Domain.Model
{
    using System;
    using Infrastructure.Builders;

    /// <summary>
    /// �����
    /// </summary>
    public class User
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; private set; }
        
        /// <summary>
        /// �̸���
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// �н�����
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// �����Ÿ��
        /// </summary>
        public UserType Type { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public DateTime UpdateDate { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public User(string emailaddress, string password, string name)
        {
            if (string.IsNullOrEmpty(emailaddress))
                throw new ArgumentNullException("emailaddress", "����ڴ� �ݵ�� �̸����ּҰ� �䱸�˴ϴ�.");

            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException("password", "����ڴ� �ݵ�� ��й�ȣ�� �䱸�˴ϴ�.");

            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name", "����ڴ� �ݵ�� ������ �䱸�˴ϴ�.");


            // TODO : ORM �����, �����Ǿ�� �մϴ�.
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
            // TODO : EqualsBuilder�� �����Ͽ� ȣ���� ��
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
            // TODO : HashCodeBuilder�� �����Ͽ� ȣ���� ��
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return ToStringBuilder.ReflectionToString(this);
        }
    }
}