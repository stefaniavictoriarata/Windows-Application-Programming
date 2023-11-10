using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
    public class Subscription
    {
        public int SubscriptionId { get; set; }
        public int ExtraOptionId { get; set; }
        public virtual ExtraOption ExtraOption { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public Subscription()
        {

        }

        public Subscription(int subscriptionId, int extraOptionId, string name, float price)
        {
            SubscriptionId = subscriptionId;
            ExtraOptionId = extraOptionId;
            Name = name;
            Price = price;
        }
    }
}
