namespace DnY.Forum.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using Infrastructure.Builders;

    /// <summary>
    /// ��Ÿ��
    /// </summary>
    public class Thread
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// ����
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// ���۱�
        /// </summary>
        public Post OriginalPost { get; set; }

        /// <summary>
        /// �亯
        /// </summary>
        public IList<Post> Replies { get; set; }

        /// <summary>
        /// �Ҽ�����
        /// </summary>
        public Forum CurrentForum { get; set; }

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
        /// <param name="orginalPost">���۱�</param>
        /// <param name="currentForum">�Ҽ�����</param>
        /// <param name="description">����</param>
        public Thread(Post orginalPost, Forum currentForum, string description)
        {
            if (orginalPost == null)
                throw new ArgumentNullException("orginalPost", "��Ÿ�� ������, ���۱� ������ �����ؾ� �մϴ�.");

            if (currentForum == null)
                throw new ArgumentNullException("currentForum", "��Ÿ�� ������, �Ҽ������� �����Ǿ�� �մϴ�.");


            // TODO : ORM �����, �����Ǿ�� �մϴ�.
            Id = Guid.NewGuid();

            OriginalPost = orginalPost;
            CurrentForum = currentForum;
            Description = description;

            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
        }

        /// <summary>
        /// ������
        /// </summary>
        /// <param name="orginalPost">���۱�</param>
        /// <param name="currentForum">�Ҽ�����</param>
        public Thread(Post orginalPost, Forum currentForum) : this(orginalPost, currentForum, string.Empty)
        {
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;

            if (obj is Forum)
            {
                return false;
            }

            return Id.Equals(((Thread)obj).Id);
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