using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
    public class Client
    {
        public int ClientId { get; set; }
        public int ExtraOptionId { get; set; }
        public virtual ExtraOption ExtraOption { get; set; }
        public int SubscriptionId { get; set; }
        public virtual Subscription Subscription { get; set; }
        public string ClientName { get; set; }
        public string PhoneNumber { get; set; }
        public Client()
        {

        }

        public Client(int clientId, int extraOptionId, int subscriptionId, string clientName, string phoneNumber)
        {
            ClientId = clientId;
            ExtraOptionId = extraOptionId;
            SubscriptionId = subscriptionId;
            ClientName = clientName;
            PhoneNumber = phoneNumber;
        }

    }
}
