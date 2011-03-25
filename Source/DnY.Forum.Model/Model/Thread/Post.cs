namespace DnY.Forum.Domain.Model
{
    using System;
    using Infrastructure.Builders;

    /// <summary>
    /// ��
    /// </summary>
    public class Post
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
        public string Content { get; set; }

        /// <summary>
        /// �ۼ���
        /// </summary>
        public User Writer { get; set; }

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
        /// <param name="content">����</param>
        /// <param name="writer">�ۼ���</param>
        public Post(string title, string content, User writer)
        {
            if (string.IsNullOrEmpty(title))
                throw new ArgumentNullException(title, "���� ������ �ݵ�� �����ؾ� �մϴ�.");

            if (string.IsNullOrEmpty(content))
                throw new ArgumentNullException(content, "���� ������ �ݵ�� �����ؾ� �մϴ�.");

            if (content.Length < 10)
                throw new ArgumentException("���� ������ 10�� �̻��̾�� �մϴ�.");


            // TODO : ORM �����, �����Ǿ�� �մϴ�.
            Id = Guid.NewGuid();

            Title = title;
            Content = content;
            Writer = writer;

            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;

            if (obj is Forum)
            {
                return false;
            }

            return Id.Equals(((Post)obj).Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return ToStringBuilder.ReflectionToString(this);
        }
    }
}