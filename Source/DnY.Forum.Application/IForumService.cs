namespace DnY.Forum.Application
{
    using System;
    using System.Collections.Generic;
    using Domain.Model;

    /// <summary>
    /// 포럼관련 서비스를 제공합니다.
    /// </summary>
    public interface IForumService
    {
        /// <summary>
        /// 새로운 포럼을 생성합니다.
        /// </summary>
        /// <param name="creator">생성자</param>
        /// <param name="title">제목</param>
        /// <param name="description">설명</param>
        /// <returns>생성된 포럼</returns>
        Forum CreateForum(User creator, string title, string description);

        /// <summary>
        /// 포럼을 삭제합니다.
        /// </summary>
        /// <param name="eraser">삭제자</param>
        /// <param name="forumId">포럼 Id</param>
        void DeleteForum(User eraser, Guid forumId);

        /// <summary>
        /// 모든 포럼을 조회합니다.
        /// </summary>
        /// <returns>조회된 포럼 목록</returns>
        IList<Forum> FindAllForum();

        /// <summary>
        /// 해당 포럼의 모든 글타래를 조회합니다.
        /// </summary>
        /// <param name="forum">포럼</param>
        /// <returns>조회된 글타래 목록</returns>
        IList<Thread> FindAllThreadByForum(Forum forum);

        /// <summary>
        /// 해당 글타래를 조회합니다.
        /// </summary>
        /// <param name="threadId">글타래 Id</param>
        /// <returns>조회된 글타래</returns>
        Thread FindThreadById(Guid threadId);

        /// <summary>
        /// 새로운 글타래를 생성합니다.
        /// </summary>
        /// <param name="creator">생성자</param>
        /// <param name="forum">소속포럼</param>
        /// <param name="title">제목</param>
        /// <param name="content">본문</param>
        /// <param name="description">설명</param>
        /// <returns>생성된 글타래</returns>
        Thread CreateNewThread(User creator, Forum forum, string title, string content, string description);

        /// <summary>
        /// 글타래에 답변합니다.
        /// </summary>
        /// <param name="replier">답변자</param>
        /// <param name="thread">글타래</param>
        /// <param name="title">제목</param>
        /// <param name="content">본문</param>
        /// <returns>글타래</returns>
        Thread ReplyThread(User replier, Thread thread, string title, string content);

        /// <summary>
        /// 글을 수정합니다.
        /// </summary>
        /// <param name="modifier">수정자</param>
        /// <param name="thread">소속글타래</param>
        /// <param name="postId">글 Id</param>
        /// <param name="title">제목</param>
        /// <param name="content">본문</param>
        /// <returns>글타래</returns>
        Thread ModifyPost(User modifier, Thread thread, Guid postId, string title, string content);

        /// <summary>
        /// 글타래를 원하는 포럼으로 이동시킵니다.
        /// </summary>
        /// <param name="moderator">중재자</param>
        /// <param name="thread">글타래</param>
        /// <param name="forumToMove">이동시킬 포럼</param>
        void MoveThreadToForum(User moderator, Thread thread, Forum forumToMove);
    }
}