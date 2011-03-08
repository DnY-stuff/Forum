namespace DnY.Forum.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using Infrastructure.Builders;

    /// <summary>
    /// 글타래
    /// </summary>
    public class Thread
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// 설명
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 시작글
        /// </summary>
        public Post OriginalPost { get; set; }

        /// <summary>
        /// 답변
        /// </summary>
        public IList<Post> Replies { get; set; }

        /// <summary>
        /// 소속포럼
        /// </summary>
        public Forum CurrentForum { get; set; }

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
        /// <param name="orginalPost">시작글</param>
        /// <param name="currentForum">소속포럼</param>
        /// <param name="description">설명</param>
        public Thread(Post orginalPost, Forum currentForum, string description)
        {
            if (orginalPost == null)
                throw new ArgumentNullException("orginalPost", "글타래 생성시, 시작글 정보가 존재해야 합니다.");

            if (currentForum == null)
                throw new ArgumentNullException("currentForum", "글타래 생성시, 소속포럼이 제공되어야 합니다.");


            // TODO : ORM 연계시, 수정되어야 합니다.
            Id = Guid.NewGuid();

            OriginalPost = orginalPost;
            CurrentForum = currentForum;
            Description = description;

            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
        }

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="orginalPost">시작글</param>
        /// <param name="currentForum">소속포럼</param>
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