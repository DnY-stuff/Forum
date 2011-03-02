namespace DnY.Forum.Persistence.NHibernate
{
    using Rhino.Commons;

    /// <summary>
    /// Functionality common to all Hibernate repositories.
    /// </summary>
    public abstract class HibernateRepository<T> : NHRepository<T> { }
}