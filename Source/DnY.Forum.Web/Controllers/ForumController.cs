namespace DnY.Forum.Web.Controllers
{
    using System;
    using System.Web.Mvc;
    using Application;

    /// <summary>
    /// Forum Controller
    /// </summary>
    public class ForumController : Controller
    {
        /// <summary>
        /// Implementation of <see cref="IForumService"/>
        /// </summary>
        protected IForumService ForumService { get; private set; }

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="forumService">Implementation of <see cref="IForumService"/></param>
        public ForumController(IForumService forumService)
        {
            ForumService = forumService;
        }

        /// <summary>
        /// 새로운 포럼을 생성합니다.
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 새로운 포럼을 생성합니다.
        /// </summary>
        /// <param name="title">제목</param>
        /// <param name="description">설명</param>
        /// <returns></returns>
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(string title, string description)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 포럼을 삭제합니다.
        /// </summary>
        /// <param name="forumId">포럼 Id</param>
        /// <returns></returns>
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Delete(Guid forumId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 포럼목록을 표시합니다.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 포럼의 글타래목록을 표시합니다.
        /// </summary>
        /// <param name="forumId">포럼 Id</param>
        /// <returns></returns>
        public ActionResult Index(Guid forumId)
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
    }
}