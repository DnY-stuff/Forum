using System;
using System.Collections.Generic;
using DnY.Forum.Domain.Model;

namespace DnY.Forum.Application
{
    public class ForumService : IForumService
    {
        #region Implementation of IForumService

        /// <summary>
        /// ���ο� ������ �����մϴ�.
        /// </summary>
        /// <param name="creator">������</param>
        /// <param name="title">����</param>
        /// <param name="description">����</param>
        /// <returns>������ ����</returns>
        public Domain.Model.Forum CreateForum(Member creator, string title, string description)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ������ �����մϴ�.
        /// </summary>
        /// <param name="eraser">������</param>
        /// <param name="forumId">���� Id</param>
        public void DeleteForum(Member eraser, Guid forumId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ��� ������ ��ȸ�մϴ�.
        /// </summary>
        /// <returns>��ȸ�� ���� ���</returns>
        public IList<Domain.Model.Forum> FindAllForum()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// �ش� ������ ��� ��Ÿ���� ��ȸ�մϴ�.
        /// </summary>
        /// <param name="forum">����</param>
        /// <returns>��ȸ�� ��Ÿ�� ���</returns>
        public IList<Thread> FindAllThreadByForum(Domain.Model.Forum forum)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// �ش� ��Ÿ���� ��ȸ�մϴ�.
        /// </summary>
        /// <param name="threadId">��Ÿ�� Id</param>
        /// <returns>��ȸ�� ��Ÿ��</returns>
        public Thread FindThreadById(Guid threadId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ���ο� ��Ÿ���� �����մϴ�.
        /// </summary>
        /// <param name="creator">������</param>
        /// <param name="forum">�Ҽ�����</param>
        /// <param name="title">����</param>
        /// <param name="content">����</param>
        /// <param name="description">����</param>
        /// <returns>������ ��Ÿ��</returns>
        public Thread CreateNewThread(Member creator, Domain.Model.Forum forum, string title, string content, string description)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ��Ÿ���� �亯�մϴ�.
        /// </summary>
        /// <param name="replier">�亯��</param>
        /// <param name="thread">��Ÿ��</param>
        /// <param name="title">����</param>
        /// <param name="content">����</param>
        /// <returns>��Ÿ��</returns>
        public Thread ReplyThread(Member replier, Thread thread, string title, string content)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ���� �����մϴ�.
        /// </summary>
        /// <param name="modifier">������</param>
        /// <param name="thread">�Ҽӱ�Ÿ��</param>
        /// <param name="postId">�� Id</param>
        /// <param name="title">����</param>
        /// <param name="content">����</param>
        /// <returns>��Ÿ��</returns>
        public Thread ModifyPost(Member modifier, Thread thread, Guid postId, string title, string content)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ��Ÿ���� ���ϴ� �������� �̵���ŵ�ϴ�.
        /// </summary>
        /// <param name="moderator">������</param>
        /// <param name="thread">��Ÿ��</param>
        /// <param name="forumToMove">�̵���ų ����</param>
        public void MoveThreadToForum(Member moderator, Thread thread, Domain.Model.Forum forumToMove)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}