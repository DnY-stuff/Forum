namespace DnY.Forum.Infrastructure.Persistence.NHibernate.Sample
{
    using System;

    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public bool Discontinued { get; set; }
    }
}