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
        /// ���ο� ����ڸ� �����մϴ�.
        /// </summary>
        /// <param name="email">�̸����ּ�</param>
        /// <param name="password">�н�����</param>
        /// <param name="name">������̸�</param>
        /// <returns>������ �����</returns>
        User CreateUser(string email, string password, string name);

        /// <summary>
        /// ����ڸ� �����մϴ�.
        /// </summary>
        /// <param name="user">�����Ϸ��� �����</param>
        void RemoveUser(User user);

        /// <summary>
        /// �����̿� ������ ���� �����մϴ�.
        /// </summary>
        /// <remarks>Login Process�� �����մϴ�.</remarks>
        /// <param name="email">�̸����ּ�</param>
        /// <param name="password">�н�����</param>
        /// <returns>����� �����</returns>
        User SignIn(string email, string password);

        /// <summary>
        /// �����̿� ������ ���� �����մϴ�.
        /// </summary>
        /// <param name="user">������ �����</param>
        /// <remarks>Logout Process�� �����մϴ�.</remarks>
        void SignOut(User user);
    }
}