namespace DnY.Forum.Application
{
    using Domain.Model;

    /// <summary>
    /// ���Ѱ��� ���񽺸� �����մϴ�.
    /// </summary>
    public interface IAuthorityService
    {
        /// <summary>
        /// ����ڰ� �����ڱ����� ������ �ִ��� Ȯ���Ѵ�.
        /// </summary>
        /// <param name="member">���</param>
        /// <returns>�����ڱ��� ��������</returns>
        bool HasAdministratorLevel(Member member);

        /// <summary>
        /// ����ڰ� �����ڱ����� ������ �ִ��� Ȯ���Ѵ�.
        /// </summary>
        /// <param name="member">���</param>
        /// <returns>�����ڱ��� ��������</returns>
        bool HasModeratorLevel(Member member);

        /// <summary>
        /// ����ڰ� ��������� ������ �ִ��� Ȯ���Ѵ�.
        /// </summary>
        /// <param name="member">���</param>
        /// <returns>������� ��������</returns>
        bool HasMemberLevel(Member member);
    }
}