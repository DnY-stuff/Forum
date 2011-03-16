using System;
using DnY.Forum.Domain.Model;

namespace DnY.Forum.Application
{
    public class AccountService : IAccountService
    {
        private IMemberRepository _memberRepository { get; set; }

        public AccountService(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        #region Implementation of IAccountService

        /// <summary>
        /// ���ο� ������ �����մϴ�.
        /// </summary>
        /// <param name="email">�̸����ּ�</param>
        /// <param name="password">�н�����</param>
        /// <param name="name">�����̸�</param>
        /// <returns>������ ���� </returns>
        public Member CreateAccount(string email, string password, string name)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ������ �����մϴ�.
        /// </summary>
        /// <param name="member">�����Ϸ��� ����</param>
        public void RemoveAccount(Member member)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// �����̿� ������ ���� �����մϴ�.
        /// </summary>
        /// <remarks>Login Process�� �����մϴ�.</remarks>
        /// <param name="email">�̸����ּ�</param>
        /// <param name="password">�н�����</param>
        /// <returns>����� ����</returns>
        public Member SignIn(string email, string password)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// �����̿� ������ ���� �����մϴ�.
        /// </summary>
        /// <param name="member">������ ����</param>
        /// <remarks>Logout Process�� �����մϴ�.</remarks>
        public void SignOut(Member member)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}