using System;
using DnY.Forum.Domain.Model;

namespace DnY.Forum.Application
{
    public class AuthorityService : IAuthorityService
    {
        #region Implementation of IAuthorityService

        /// <summary>
        /// 사용자가 관리자권한을 가지고 있는지 확인한다.
        /// </summary>
        /// <param name="user">사용자</param>
        /// <returns>관리자권한 소유여부</returns>
        public bool HasAdministratorLevel(Member user)
        {
            if (user == null)
                throw new ArgumentNullException("user", "권한을 확인하려면 사용자정보가 주어져야 합니다.");

            return user.Type.HasFlag(MemberType.Administrator);
        }

        /// <summary>
        /// 사용자가 중재자권한을 가지고 있는지 확인한다.
        /// </summary>
        /// <param name="user">사용자</param>
        /// <returns>중재자권한 소유여부</returns>
        public bool HasModeratorLevel(Member user)
        {
            if (user == null)
                throw new ArgumentNullException("user", "권한을 확인하려면 사용자정보가 주어져야 합니다.");

            return user.Type.HasFlag(MemberType.Moderator);
        }

        /// <summary>
        /// 사용자가 멤버권한을 가지고 있는지 확인한다.
        /// </summary>
        /// <param name="user">사용자</param>
        /// <returns>멤버권한 소유여부</returns>
        public bool HasMemberLevel(Member user)
        {
            if (user == null)
                throw new ArgumentNullException("user", "권한을 확인하려면 사용자정보가 주어져야 합니다.");

            return user.Type.HasFlag(MemberType.Member);
        }

        #endregion
    }
}