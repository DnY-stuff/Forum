namespace DnY.Forum.Application
{
    using System;
    using System.Collections.Generic;
    using Domain.Model;

    public class ForumService : IForumService
    {
        protected IForumRepository _forumRepository { get; set; }
        protected IUserRepository UserRepository { get; set; }
        protected IAuthorityService _authorityService { get; set; }

        public ForumService(IForumRepository forumRepository,
                            IUserRepository userRepository,
                            IAuthorityService authorityService)
        {
            _forumRepository = forumRepository;
            UserRepository = userRepository;
            _authorityService = authorityService;
        }

        #region Implementation of IForumService

        /// <summary>
        /// 새로운 포럼을 생성합니다.
        /// </summary>
        /// <param name="creator">생성자</param>
        /// <param name="title">제목</param>
        /// <param name="description">설명</param>
        /// <returns>생성된 포럼</returns>
        public Forum CreateForum(User creator, string title, string description)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 포럼을 삭제합니다.
        /// </summary>
        /// <param name="eraser">삭제자</param>
        /// <param name="forumId">포럼 Id</param>
        public void DeleteForum(User eraser, Guid forumId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 모든 포럼을 조회합니다.
        /// </summary>
        /// <returns>조회된 포럼 목록</returns>
        public IList<Forum> FindAllForum()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 해당 포럼의 모든 글타래를 조회합니다.
        /// </summary>
        /// <param name="forum">포럼</param>
        /// <returns>조회된 글타래 목록</returns>
        public IList<Thread> FindAllThreadByForum(Forum forum)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 해당 글타래를 조회합니다.
        /// </summary>
        /// <param name="threadId">글타래 Id</param>
        /// <returns>조회된 글타래</returns>
        public Thread FindThreadById(Guid threadId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 새로운 글타래를 생성합니다.
        /// </summary>
        /// <param name="creator">생성자</param>
        /// <param name="forum">소속포럼</param>
        /// <param name="title">제목</param>
        /// <param name="content">본문</param>
        /// <param name="description">설명</param>
        /// <returns>생성된 글타래</returns>
        public Thread CreateNewThread(User creator, Forum forum, string title, string content, string description)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 글타래에 답변합니다.
        /// </summary>
        /// <param name="replier">답변자</param>
        /// <param name="thread">글타래</param>
        /// <param name="title">제목</param>
        /// <param name="content">본문</param>
        /// <returns>글타래</returns>
        public Thread ReplyThread(User replier, Thread thread, string title, string content)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 글을 수정합니다.
        /// </summary>
        /// <param name="modifier">수정자</param>
        /// <param name="thread">소속글타래</param>
        /// <param name="postId">글 Id</param>
        /// <param name="title">제목</param>
        /// <param name="content">본문</param>
        /// <returns>글타래</returns>
        public Thread ModifyPost(User modifier, Thread thread, Guid postId, string title, string content)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 글타래를 원하는 포럼으로 이동시킵니다.
        /// </summary>
        /// <param name="moderator">중재자</param>
        /// <param name="thread">글타래</param>
        /// <param name="forumToMove">이동시킬 포럼</param>
        public void MoveThreadToForum(User moderator, Thread thread, Forum forumToMove)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}