using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Message_Board.Pages.MessageBoard
{
    public class TimelineModel : PageModel
    {
        public TimelineModel(IMessage_Board messageBoard)
        {
            this.MessageBoard = messageBoard;
        }

        public IActionResult OnGet(int messageId)
        {
            if (messageId != 0)
            {
                Like like = new Like();
                like.MessageId = messageId;
                MessageBoard.AddLike(like);
                return RedirectToPage("./Timeline");
            }
            Messages=MessageBoard.GetMessages();
            Timeline = MessageBoard.Timeline();
            return Page();
        }
        public IEnumerable<Message> Messages { get; set; }
        
        [TempData]
        public string Msg { get; set; }
        [BindProperty]
        public Timeline Message { get; set; }
        public IQueryable<Timeline> Timeline { get; set; }
        private readonly IMessage_Board MessageBoard;
    }
}