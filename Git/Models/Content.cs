using System;

namespace Git
{
    public class Content
    {
        public Guid ContentId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }

        public Content (string name)
        {
          ContentId = Guid.NewGuid();
          CreatedDate = DateTime.Now;
          Name = name;
        }
    }
}