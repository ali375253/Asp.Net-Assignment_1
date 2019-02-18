using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Message_Board
{
    public interface IMessage_Board
    {
        IEnumerable<Message> GetMessages();
        Message AddMessage(Message newMessage);
        Like AddLike(Like like);
        Comment AddComment(Comment comment);
        IQueryable<Timeline> Timeline();
        IEnumerable<Comment> GetComments(int messageId);
        //int GetLikesById(int MessageId);
        //int GetCommentsById(int MessageId);
        int Commit();
    }
}
