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
        /// <param name="user">�����</param>
        /// <returns>�����ڱ��� ��������</returns>
        bool HasAdministratorLevel(User user);

        /// <summary>
        /// ����ڰ� �����ڱ����� ������ �ִ��� Ȯ���Ѵ�.
        /// </summary>
        /// <param name="user">�����</param>
        /// <returns>�����ڱ��� ��������</returns>
        bool HasModeratorLevel(User user);

        /// <summary>
        /// ����ڰ� ��������� ������ �ִ��� Ȯ���Ѵ�.
        /// </summary>
        /// <param name="user">�����</param>
        /// <returns>������� ��������</returns>
        bool HasMemberLevel(User user);
    }
}