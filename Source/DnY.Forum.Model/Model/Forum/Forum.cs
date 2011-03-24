namespace DnY.Forum.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using Infrastructure.Builders;

    /// <summary>
    /// ����
    /// </summary>
    public class Forum
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// ����
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// ��ȸ��
        /// </summary>
        public IList<Member> Moderators { get; set; }

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
        /// <param name="title">����</param>
        /// <param name="moderators">��ȸ��</param>
        /// <param name="description">����</param>
        public Forum(string title, IList<Member> moderators, string description)
        {
            if (string.IsNullOrEmpty(title))
                throw new ArgumentNullException("title", "������ ������ �ݵ�� �����ؾ� �մϴ�.");

            if (moderators == null || moderators.Count == 0)
                throw new ArgumentException("������ ��ȸ�ڴ� ��� �Ѹ� �̻� �����ؾ� �մϴ�.");


            // TODO : ORM �����, �����Ǿ�� �մϴ�.
            Id = Guid.NewGuid();

            Title = title;
            Description = description;
            Moderators = moderators;

            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
        }

        /// <summary>
        /// ������
        /// </summary>
        /// <param name="title">����</param>
        /// <param name="moderators">��ȸ��</param>
        public Forum(string title, IList<Member> moderators) : this(title, moderators, string.Empty)
        {
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

            return Id.Equals(((Forum)obj).Id);
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