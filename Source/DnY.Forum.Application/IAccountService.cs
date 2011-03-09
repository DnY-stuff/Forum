using System;
using DnY.Forum.Domain.Model;

namespace DnY.Forum.Application
{
    /// <summary>
    /// �������� ���񽺸� �����մϴ�.
    /// </summary>
    public interface IAccountService
    {
        /// <summary>
        /// ���ο� ������ �����մϴ�.
        /// </summary>
        /// <param name="email">�̸����ּ�</param>
        /// <param name="password">�н�����</param>
        /// <param name="name">�����̸�</param>
        /// <returns>������ ���� </returns>
        Member CreateAccount(string email, string password, string name);

        /// <summary>
        /// ������ �����մϴ�.
        /// </summary>
        /// <param name="member">�����Ϸ��� ����</param>
        void RemoveAccount(Member member);

        /// <summary>
        /// �����̿� ������ ���� �����մϴ�.
        /// </summary>
        /// <remarks>Login Process�� �����մϴ�.</remarks>
        /// <param name="email">�̸����ּ�</param>
        /// <param name="password">�н�����</param>
        /// <returns>����� ����</returns>
        Member SignIn(string email, string password);

        /// <summary>
        /// �����̿� ������ ���� �����մϴ�.
        /// </summary>
        /// <param name="member">������ ����</param>
        /// <remarks>Logout Process�� �����մϴ�.</remarks>
        void SignOut(Member member);
    }
}