using System;

namespace Git
{
    public class Subscription
    {
        public Guid SubscriptionId { get; set; }
        public DateTime CreatedDate { get; set; }

        public Content Content { get; set; }

        public Subscription(Content content)
        {
            SubscriptionId = Guid.NewGuid();
            CreatedDate = DateTime.Now;
            Content = content;
        }
    }
}