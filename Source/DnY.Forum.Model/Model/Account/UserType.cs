namespace DnY.Forum.Domain.Model
{
    using System;

    /// <summary>
    /// 사용자 타입
    /// </summary>
    [Flags]
    public enum UserType
    {
        /// <summary>
        /// 손님
        /// </summary>
        Guest = 0x0001,
        /// <summary>
        /// 멤버
        /// </summary>
        Member = Guest | 0x0002,
        /// <summary>
        /// 사회자
        /// </summary>
        Moderator =  Member | 0x0004,
        /// <summary>
        /// 관리자
        /// </summary>
        Administrator = Moderator | 0x0008,
    }
}