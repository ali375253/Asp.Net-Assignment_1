using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Message_Board.Pages.MessageBoard
{
    public class AddMessageModel : PageModel
    {
        private readonly IMessage_Board MessageBoard;
        private readonly IHtmlHelper htmlHelper;

        [BindProperty]
        public Message Message { get; set; }
        [TempData]
        public string Msg { get; set; }

        public AddMessageModel(IMessage_Board MessageBoard, IHtmlHelper htmlHelper)
        {
            this.MessageBoard = MessageBoard;
            this.htmlHelper = htmlHelper;
        }

        public IActionResult OnPost()
        {
            MessageBoard.AddMessage(Message);
            MessageBoard.Commit();
            TempData["Msg"] = "Restaurant saved!";
            return RedirectToPage("./Timeline");
        }
    }
}