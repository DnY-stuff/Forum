namespace DnY.Forum.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using Infrastructure.Builders;

    /// <summary>
    /// 포럼
    /// </summary>
    public class Forum
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
        /// 설명
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 사회자
        /// </summary>
        public IList<User> Moderators { get; set; }

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
        /// <param name="moderators">사회자</param>
        /// <param name="description">설명</param>
        public Forum(string title, IList<User> moderators, string description)
        {
            if (string.IsNullOrEmpty(title))
                throw new ArgumentNullException("title", "포럼의 제목은 반드시 존재해야 합니다.");

            if (moderators == null || moderators.Count == 0)
                throw new ArgumentException("포럼의 사회자는 적어도 한명 이상 존재해야 합니다.");


            // TODO : ORM 연계시, 수정되어야 합니다.
            Id = Guid.NewGuid();

            Title = title;
            Description = description;
            Moderators = moderators;

            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
        }

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="title">제목</param>
        /// <param name="moderators">사회자</param>
        public Forum(string title, IList<User> moderators) : this(title, moderators, string.Empty)
        {
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

            return Id.Equals(((Forum)obj).Id);
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