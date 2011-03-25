using System;
using DnY.Forum.Domain.Model;

namespace DnY.Forum.Application
{
    /// <summary>
    /// 계정관련 서비스를 제공합니다.
    /// </summary>
    public interface IAccountService
    {
        /// <summary>
        /// 새로운 사용자를 생성합니다.
        /// </summary>
        /// <param name="email">이메일주소</param>
        /// <param name="password">패스워드</param>
        /// <param name="name">사용자이름</param>
        /// <returns>생성된 사용자</returns>
        User CreateUser(string email, string password, string name);

        /// <summary>
        /// 사용자를 삭제합니다.
        /// </summary>
        /// <param name="user">삭제하려는 사용자</param>
        void RemoveUser(User user);

        /// <summary>
        /// 포럼이용 시작을 위해 서명합니다.
        /// </summary>
        /// <remarks>Login Process와 동일합니다.</remarks>
        /// <param name="email">이메일주소</param>
        /// <param name="password">패스워드</param>
        /// <returns>서명된 사용자</returns>
        User SignIn(string email, string password);

        /// <summary>
        /// 포럼이용 중지를 위해 서명합니다.
        /// </summary>
        /// <param name="user">서명할 사용자</param>
        /// <remarks>Logout Process와 동일합니다.</remarks>
        void SignOut(User user);
    }
}