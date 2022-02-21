using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatModelsTest.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public string MessageBody { get; set; }
        public int ChatId { get; set; } //klucz obcy do klasy Chat
        public string FromUser { get; set; } //klucz obcy do klasy ApplicationUser
        public DateTime MessageDtTm { get; set; }

        public ApplicationUser User { get; set; }
        public Chat Chat { get; set; }
    }
}
