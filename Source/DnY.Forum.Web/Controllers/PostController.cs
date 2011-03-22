namespace DnY.Forum.Web.Controllers
{
    using System;
    using System.Web.Mvc;
    using Application;

    /// <summary>
    /// Post Controller
    /// </summary>
    public class PostController : Controller
    {
        /// <summary>
        /// Implementation of <see cref="IForumService"/>
        /// </summary>
        protected IForumService ForumService { get; private set; }

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="forumService">Implementation of <see cref="IForumService"/></param>
        public PostController(IForumService forumService)
        {
            ForumService = forumService;
        }

        /// <summary>
        /// 글을 수정합니다.
        /// </summary>
        /// <param name="postId">글 Id</param>
        /// <returns></returns>
        public ActionResult Edit(Guid postId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 글을 수정합니다.
        /// </summary>
        /// <param name="postId">글 Id</param>
        /// <param name="title">제목</param>
        /// <param name="content">내용</param>
        /// <returns></returns>
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(Guid postId, string title, string content)
        {
            throw new NotImplementedException();
        }
    }
}