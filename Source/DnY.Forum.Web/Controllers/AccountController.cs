namespace DnY.Forum.Web.Controllers
{
    using System;
    using System.Web.Mvc;
    using Application;

    /// <summary>
    /// Account Controller
    /// </summary>
    public class AccountController : Controller
    {
        /// <summary>
        /// Implementation of <see cref="IAccountService"/>
        /// </summary>
        protected IAccountService AccountService { get; private set; }

        /// <summary>
        /// ������
        /// </summary>
        /// <param name="accountService">Implementation of <see cref="IAccountService"/></param>
        public AccountController(IAccountService accountService)
        {
            AccountService = accountService;
        }

        /// <summary>
        /// ������ �����մϴ�.
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ������ �����մϴ�.
        /// </summary>
        /// <param name="email">�̸����ּ�</param>
        /// <param name="password">�н�����</param>
        /// <param name="name">�����̸�</param>
        /// <returns></returns>
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(string email, string password, string name)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ������ �����մϴ�.
        /// </summary>
        /// <param name="userId">����� Id</param>
        /// <returns></returns>
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Remove(Guid userId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// �α����մϴ�.
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// �α����մϴ�.
        /// </summary>
        /// <param name="email">�̸����ּ�</param>
        /// <param name="password">�н�����</param>
        /// <returns></returns>
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// �α׾ƿ��մϴ�.
        /// </summary>
        /// <returns></returns>
        public ActionResult Logout()
        {
            throw new NotImplementedException();
        }
    }
}