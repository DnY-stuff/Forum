namespace DnY.Forum.Application
{
    using System;
    using System.Collections.Generic;
    using Domain.Model;

    /// <summary>
    /// �������� ���񽺸� �����մϴ�.
    /// </summary>
    public interface IForumService
    {
        /// <summary>
        /// ���ο� ������ �����մϴ�.
        /// </summary>
        /// <param name="creator">������</param>
        /// <param name="title">����</param>
        /// <param name="description">����</param>
        /// <returns>������ ����</returns>
        Forum CreateForum(User creator, string title, string description);

        /// <summary>
        /// ������ �����մϴ�.
        /// </summary>
        /// <param name="eraser">������</param>
        /// <param name="forumId">���� Id</param>
        void DeleteForum(User eraser, Guid forumId);

        /// <summary>
        /// ��� ������ ��ȸ�մϴ�.
        /// </summary>
        /// <returns>��ȸ�� ���� ���</returns>
        IList<Forum> FindAllForum();

        /// <summary>
        /// �ش� ������ ��� ��Ÿ���� ��ȸ�մϴ�.
        /// </summary>
        /// <param name="forum">����</param>
        /// <returns>��ȸ�� ��Ÿ�� ���</returns>
        IList<Thread> FindAllThreadByForum(Forum forum);

        /// <summary>
        /// �ش� ��Ÿ���� ��ȸ�մϴ�.
        /// </summary>
        /// <param name="threadId">��Ÿ�� Id</param>
        /// <returns>��ȸ�� ��Ÿ��</returns>
        Thread FindThreadById(Guid threadId);

        /// <summary>
        /// ���ο� ��Ÿ���� �����մϴ�.
        /// </summary>
        /// <param name="creator">������</param>
        /// <param name="forum">�Ҽ�����</param>
        /// <param name="title">����</param>
        /// <param name="content">����</param>
        /// <param name="description">����</param>
        /// <returns>������ ��Ÿ��</returns>
        Thread CreateNewThread(User creator, Forum forum, string title, string content, string description);

        /// <summary>
        /// ��Ÿ���� �亯�մϴ�.
        /// </summary>
        /// <param name="replier">�亯��</param>
        /// <param name="thread">��Ÿ��</param>
        /// <param name="title">����</param>
        /// <param name="content">����</param>
        /// <returns>��Ÿ��</returns>
        Thread ReplyThread(User replier, Thread thread, string title, string content);

        /// <summary>
        /// ���� �����մϴ�.
        /// </summary>
        /// <param name="modifier">������</param>
        /// <param name="thread">�Ҽӱ�Ÿ��</param>
        /// <param name="postId">�� Id</param>
        /// <param name="title">����</param>
        /// <param name="content">����</param>
        /// <returns>��Ÿ��</returns>
        Thread ModifyPost(User modifier, Thread thread, Guid postId, string title, string content);

        /// <summary>
        /// ��Ÿ���� ���ϴ� �������� �̵���ŵ�ϴ�.
        /// </summary>
        /// <param name="moderator">������</param>
        /// <param name="thread">��Ÿ��</param>
        /// <param name="forumToMove">�̵���ų ����</param>
        void MoveThreadToForum(User moderator, Thread thread, Forum forumToMove);
    }
}