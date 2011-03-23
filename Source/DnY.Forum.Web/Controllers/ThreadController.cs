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
        /// ������
        /// </summary>
        /// <param name="forumService">Implementation of <see cref="IForumService"/></param>
        public ThreadController(IForumService forumService)
        {
            ForumService = forumService;
        }

        /// <summary>
        /// ��Ÿ�������� ǥ���մϴ�.
        /// </summary>
        /// <param name="threadId">��Ÿ�� Id</param>
        /// <returns></returns>
        public ActionResult Index(Guid threadId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ���ο� ��Ÿ���� �����մϴ�.
        /// </summary>
        /// <param name="forumId">���� Id</param>
        /// <returns></returns>
        public ActionResult Create(Guid forumId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ���ο� ��Ÿ���� �����մϴ�.
        /// </summary>
        /// <param name="forumId">����Id</param>
        /// <param name="title">����</param>
        /// <param name="content">����</param>
        /// <param name="description">����</param>
        /// <returns></returns>
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(Guid forumId, string title, string content, string description)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ��Ÿ���� �亯�մϴ�.
        /// </summary>
        /// <param name="threadId">��Ÿ�� Id</param>
        /// <returns></returns>
        public ActionResult Reply(Guid threadId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ��Ÿ���� �亯�մϴ�.
        /// </summary>
        /// <param name="threadId">��Ÿ�� Id</param>
        /// <param name="title">����</param>
        /// <param name="content">����</param>
        /// <returns></returns>
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Reply(Guid threadId, string title, string content)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ��Ÿ���� ���ϴ� �������� �̵���ŵ�ϴ�.
        /// </summary>
        /// <param name="threadId">��Ÿ�� Id</param>
        /// <param name="forumId">���� Id</param>
        /// <returns></returns>
        public ActionResult Move(Guid threadId, Guid forumId)
        {
            throw new NotImplementedException();
        }
    }
}