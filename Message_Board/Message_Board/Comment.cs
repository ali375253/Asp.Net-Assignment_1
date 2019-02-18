using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Message_Board
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int MessageId { get; set; }
    }
}
