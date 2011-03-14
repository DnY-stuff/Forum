using System;
using DnY.Forum.Domain.Model;

namespace DnY.Forum.Application
{
    public class AuthorityService : IAuthorityService
    {
        #region Implementation of IAuthorityService

        /// <summary>
        /// ����ڰ� �����ڱ����� ������ �ִ��� Ȯ���Ѵ�.
        /// </summary>
        /// <param name="user">�����</param>
        /// <returns>�����ڱ��� ��������</returns>
        public bool HasAdministratorLevel(Member user)
        {
            if (user == null)
                throw new ArgumentNullException("user", "������ Ȯ���Ϸ��� ����������� �־����� �մϴ�.");

            return user.Type.HasFlag(MemberType.Administrator);
        }

        /// <summary>
        /// ����ڰ� �����ڱ����� ������ �ִ��� Ȯ���Ѵ�.
        /// </summary>
        /// <param name="user">�����</param>
        /// <returns>�����ڱ��� ��������</returns>
        public bool HasModeratorLevel(Member user)
        {
            if (user == null)
                throw new ArgumentNullException("user", "������ Ȯ���Ϸ��� ����������� �־����� �մϴ�.");

            return user.Type.HasFlag(MemberType.Moderator);
        }

        /// <summary>
        /// ����ڰ� ��������� ������ �ִ��� Ȯ���Ѵ�.
        /// </summary>
        /// <param name="user">�����</param>
        /// <returns>������� ��������</returns>
        public bool HasMemberLevel(Member user)
        {
            if (user == null)
                throw new ArgumentNullException("user", "������ Ȯ���Ϸ��� ����������� �־����� �մϴ�.");

            return user.Type.HasFlag(MemberType.Member);
        }

        #endregion
    }
}