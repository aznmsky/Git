using System;

namespace Git
{
    public class Subscription
    {
        public Guid SubscriptionId { get; set; }
        public DateTime CreatedDate { get; set; }

        public Subscription()
        {
            SubscriptionId = Guid.NewGuid();
            CreatedDate = DateTime.Now;
        }
    }
}