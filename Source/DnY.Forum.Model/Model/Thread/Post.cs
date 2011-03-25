namespace DnY.Forum.Domain.Model
{
    using System;
    using Infrastructure.Builders;

    /// <summary>
    /// 글
    /// </summary>
    public class Post
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// 제목
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 본문
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 작성자
        /// </summary>
        public User Writer { get; set; }

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
        /// <param name="title">제목</param>
        /// <param name="content">본문</param>
        /// <param name="writer">작성자</param>
        public Post(string title, string content, User writer)
        {
            if (string.IsNullOrEmpty(title))
                throw new ArgumentNullException(title, "글의 제목은 반드시 존재해야 합니다.");

            if (string.IsNullOrEmpty(content))
                throw new ArgumentNullException(content, "글의 내용은 반드시 존재해야 합니다.");

            if (content.Length < 10)
                throw new ArgumentException("글의 내용은 10자 이상이어야 합니다.");


            // TODO : ORM 연계시, 수정되어야 합니다.
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