using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatModelsTest.Models
{
    public class ChatToUser
    {
        public int Id { get; set; }
        public int ChatId { get; set; } //klucz obcy do klasy Chat
        public string UserId { get; set; } //klusz obcy do klasy ApplicationUser

        public virtual ApplicationUser User { get; set; }
        public virtual Chat Chat { get; set; }
    }
}
