namespace DnY.Forum.Domain.Model
{
    using System;

    /// <summary>
    /// ����� Ÿ��
    /// </summary>
    [Flags]
    public enum UserType
    {
        /// <summary>
        /// �մ�
        /// </summary>
        Guest = 0x0001,
        /// <summary>
        /// ���
        /// </summary>
        Member = Guest | 0x0002,
        /// <summary>
        /// ��ȸ��
        /// </summary>
        Moderator =  Member | 0x0004,
        /// <summary>
        /// ������
        /// </summary>
        Administrator = Moderator | 0x0008,
    }
}