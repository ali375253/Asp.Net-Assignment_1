using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Message_Board.Pages.MessageBoard
{
    public class AddCommentModel : PageModel
    {
        private readonly IMessage_Board MessageBoard;
        private readonly IHtmlHelper htmlHelper;

        //[BindProperty]
        //public Comment Comment { get; set; }
        [TempData]
        public string Msg { get; set; }

        public AddCommentModel(IMessage_Board MessageBoard, IHtmlHelper htmlHelper)
        {
            this.MessageBoard = MessageBoard;
            this.htmlHelper = htmlHelper;
        }
        public IActionResult OnGet(string Content,int messageId)
        {
            if (Content != null)
            {
                Comment comment = new Comment();
                comment.Content = Content;
                comment.MessageId = messageId;
                MessageBoard.AddComment(comment);
                TempData["Msg"] = "Comment saved!";
                return RedirectToPage("./Timeline");
            }
            return Page();
        }
    }
}