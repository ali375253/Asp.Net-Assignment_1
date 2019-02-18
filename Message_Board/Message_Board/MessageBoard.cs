using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Message_Board
{
    public class MessageBoard : IMessage_Board
    {
        public MessageBoard(MessageBoardDbContext Db)
        {
            this.Db = Db;
        }

        public IEnumerable<Message> GetMessages()
        {
            return from msg in Db.Messages
                   select msg;
        }

        public Message AddMessage(Message message)
        {
            Db.Add(message);
            Commit();
            return message;
        }

        public Like AddLike(Like like)
        {
            Db.Add(like);
            Commit();
            return like;
        }

        public Comment AddComment(Comment Comment)
        {
            Db.Add(Comment);
            Commit();
            return Comment;
        }

        public int Commit()
        {
            return Db.SaveChanges();
        }

        public IQueryable<Timeline> Timeline()
        {
            //var query = from msg in Db.Messages
            //            join like in Db.Likes on msg.Id equals like.MessageId
            //            join cmt in Db.Comments on msg.Id equals cmt.MessageId
            //            select new Timeline
            //            {
            //                MessageId = msg.Id,
            //                MessageContent = msg.Content,
            //                Likes = Db.Likes.Count(l => l.MessageId == msg.Id),
            //                Comments = Db.Comments.Count(c => c.MessageId == msg.Id)
            //            };
            var query = from msg in Db.Messages
                        join like in Db.Likes on msg.Id equals like.MessageId 
                        into tmp
                        from ml in tmp.DefaultIfEmpty() 
                        join cmt in Db.Comments on ml.Id equals cmt.MessageId
                        into temp
                        from t in temp.DefaultIfEmpty()
                        select new Timeline
                        {
                            MessageId = msg.Id,
                            MessageContent = msg.Content,
                            Likes = ml != null ? Db.Likes.Count(l => l.MessageId == msg.Id) : 0,
                            Comments = ml != null ? Db.Comments.Count(c => c.MessageId == msg.Id) : 0
                        };
            var query2 = query.GroupBy(x => x.MessageId, (key, group) => group.First());
            return query2;
        }

        public IEnumerable<Comment> GetComments(int messageId)
        {
            return from c in Db.Comments
                   where c.MessageId == messageId
                   select c;
        }
        private readonly MessageBoardDbContext Db;
    }
}
