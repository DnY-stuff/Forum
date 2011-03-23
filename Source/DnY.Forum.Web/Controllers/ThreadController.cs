namespace DnY.Forum.Web.Controllers
{
    using System;
    using System.Web.Mvc;
    using Application;

    /// <summary>
    /// Thread Controller
    /// </summary>
    public class ThreadController : Controller
    {
        /// <summary>
        /// Implementation of <see cref="IForumService"/>
        /// </summary>
        protected IForumService ForumService { get; private set; }

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="forumService">Implementation of <see cref="IForumService"/></param>
        public ThreadController(IForumService forumService)
        {
            ForumService = forumService;
        }

        /// <summary>
        /// 글타래정보를 표시합니다.
        /// </summary>
        /// <param name="threadId">글타래 Id</param>
        /// <returns></returns>
        public ActionResult Index(Guid threadId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 새로운 글타래를 생성합니다.
        /// </summary>
        /// <param name="forumId">포럼 Id</param>
        /// <returns></returns>
        public ActionResult Create(Guid forumId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 새로운 글타래를 생성합니다.
        /// </summary>
        /// <param name="forumId">포럼Id</param>
        /// <param name="title">제목</param>
        /// <param name="content">본문</param>
        /// <param name="description">설명</param>
        /// <returns></returns>
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(Guid forumId, string title, string content, string description)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 글타래에 답변합니다.
        /// </summary>
        /// <param name="threadId">글타래 Id</param>
        /// <returns></returns>
        public ActionResult Reply(Guid threadId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 글타래에 답변합니다.
        /// </summary>
        /// <param name="threadId">글타래 Id</param>
        /// <param name="title">제목</param>
        /// <param name="content">본문</param>
        /// <returns></returns>
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Reply(Guid threadId, string title, string content)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 글타래를 원하는 포럼으로 이동시킵니다.
        /// </summary>
        /// <param name="threadId">글타래 Id</param>
        /// <param name="forumId">포럼 Id</param>
        /// <returns></returns>
        public ActionResult Move(Guid threadId, Guid forumId)
        {
            throw new NotImplementedException();
        }
    }
}