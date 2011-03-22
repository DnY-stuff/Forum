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
        /// ������
        /// </summary>
        /// <param name="forumService">Implementation of <see cref="IForumService"/></param>
        public PostController(IForumService forumService)
        {
            ForumService = forumService;
        }

        /// <summary>
        /// ���� �����մϴ�.
        /// </summary>
        /// <param name="postId">�� Id</param>
        /// <returns></returns>
        public ActionResult Edit(Guid postId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ���� �����մϴ�.
        /// </summary>
        /// <param name="postId">�� Id</param>
        /// <param name="title">����</param>
        /// <param name="content">����</param>
        /// <returns></returns>
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(Guid postId, string title, string content)
        {
            throw new NotImplementedException();
        }
    }
}