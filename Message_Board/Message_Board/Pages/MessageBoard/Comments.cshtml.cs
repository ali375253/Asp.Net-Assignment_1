using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Message_Board.Pages.MessageBoard
{
    public class CommentsModel : PageModel
    {
        public CommentsModel(IMessage_Board messageBoard)
        {
            this.MessageBoard = messageBoard;
        }
        public void OnGet(int messageId)
        {
            Comments = MessageBoard.GetComments(messageId);
        }
        public IEnumerable<Comment> Comments { get; set; }
        private readonly IMessage_Board MessageBoard;
    }
}