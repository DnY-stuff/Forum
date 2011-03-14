namespace DnY.Forum.Application
{
    using Domain.Model;

    /// <summary>
    /// 권한관련 서비스를 제공합니다.
    /// </summary>
    public interface IAuthorityService
    {
        /// <summary>
        /// 사용자가 관리자권한을 가지고 있는지 확인한다.
        /// </summary>
        /// <param name="user">사용자</param>
        /// <returns>관리자권한 소유여부</returns>
        bool HasAdministratorLevel(Member user);

        /// <summary>
        /// 사용자가 중재자권한을 가지고 있는지 확인한다.
        /// </summary>
        /// <param name="user">사용자</param>
        /// <returns>중재자권한 소유여부</returns>
        bool HasModeratorLevel(Member user);

        /// <summary>
        /// 사용자가 멤버권한을 가지고 있는지 확인한다.
        /// </summary>
        /// <param name="user">사용자</param>
        /// <returns>멤버권한 소유여부</returns>
        bool HasMemberLevel(Member user);
    }
}