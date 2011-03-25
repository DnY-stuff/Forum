using System;
using DnY.Forum.Domain.Model;

namespace DnY.Forum.Application
{
    public class AccountService : IAccountService
    {
        private IUserRepository UserRepository { get; set; }

        public AccountService(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        #region Implementation of IAccountService

        /// <summary>
        /// ���ο� ����ڸ� �����մϴ�.
        /// </summary>
        /// <param name="email">�̸����ּ�</param>
        /// <param name="password">�н�����</param>
        /// <param name="name">������̸�</param>
        /// <returns>������ �����</returns>
        public User CreateUser(string email, string password, string name)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ����ڸ� �����մϴ�.
        /// </summary>
        /// <param name="user">�����Ϸ��� �����</param>
        public void RemoveUser(User user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// �����̿� ������ ���� �����մϴ�.
        /// </summary>
        /// <remarks>Login Process�� �����մϴ�.</remarks>
        /// <param name="email">�̸����ּ�</param>
        /// <param name="password">�н�����</param>
        /// <returns>����� �����</returns>
        public User SignIn(string email, string password)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// �����̿� ������ ���� �����մϴ�.
        /// </summary>
        /// <param name="user">������ �����</param>
        /// <remarks>Logout Process�� �����մϴ�.</remarks>
        public void SignOut(User user)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}