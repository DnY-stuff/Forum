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
        /// ������
        /// </summary>
        /// <param name="forumService">Implementation of <see cref="IForumService"/></param>
        public ForumController(IForumService forumService)
        {
            ForumService = forumService;
        }

        /// <summary>
        /// ���ο� ������ �����մϴ�.
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ���ο� ������ �����մϴ�.
        /// </summary>
        /// <param name="title">����</param>
        /// <param name="description">����</param>
        /// <returns></returns>
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(string title, string description)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ������ �����մϴ�.
        /// </summary>
        /// <param name="forumId">���� Id</param>
        /// <returns></returns>
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Delete(Guid forumId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ��������� ǥ���մϴ�.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ������ ��Ÿ������� ǥ���մϴ�.
        /// </summary>
        /// <param name="forumId">���� Id</param>
        /// <returns></returns>
        public ActionResult Details(Guid forumId)
        {
            throw new NotImplementedException();
        }
    }
}