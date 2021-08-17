using System;

namespace Wrench.Domain.Entities
{
    public class ChatConversa
    {
        public int IdChatConversa { get; set; }
        public int IdChat { get; set; }
        public Guid De { get; set; }
        public Guid Para { get; set; }
        public string Mensagem { get; set; }
        public DateTime EnviadoEm { get; set; }

        public Chat Chat { get; set; }
    }
}