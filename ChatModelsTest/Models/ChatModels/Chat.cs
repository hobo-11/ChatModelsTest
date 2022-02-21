using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatModelsTest.Models
{
    public class Chat
    {
        public int ChatId { get; set; }
        public string? ChatName { get; set; }
        public ChatType ChatType { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; }
    }

    public enum ChatType
    {
        OneToOne,
        ManyPeople
    }
}
