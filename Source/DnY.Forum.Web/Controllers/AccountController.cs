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
        /// 생성자
        /// </summary>
        /// <param name="accountService">Implementation of <see cref="IAccountService"/></param>
        public AccountController(IAccountService accountService)
        {
            AccountService = accountService;
        }

        /// <summary>
        /// 계정을 생성합니다.
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 계정을 생성합니다.
        /// </summary>
        /// <param name="email">이메일주소</param>
        /// <param name="password">패스워드</param>
        /// <param name="name">계정이름</param>
        /// <returns></returns>
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(string email, string password, string name)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 계정을 삭제합니다.
        /// </summary>
        /// <param name="userId">사용자 Id</param>
        /// <returns></returns>
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Remove(Guid userId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 로그인합니다.
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 로그인합니다.
        /// </summary>
        /// <param name="email">이메일주소</param>
        /// <param name="password">패스워드</param>
        /// <returns></returns>
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 로그아웃합니다.
        /// </summary>
        /// <returns></returns>
        public ActionResult Logout()
        {
            throw new NotImplementedException();
        }
    }
}