namespace DnY.Forum.Infrastructure.Persistence.NHibernate
{
    using DnY.Forum.Persistence.NHibernate;
    using Rhino.Commons;
    using Rhino.Commons.ForTesting;
    using Machine.Specifications;
    //using DnY.Forum.Domain.Model;

    public abstract class with_nhibernate_sqlite<T> : DatabaseTestFixtureBase
    {
        Establish context = () =>
                                {
                                    MappingInfo from = MappingInfo.From(typeof(T).Assembly,
                                                                        typeof(HibernateRepository<>).Assembly);

                                    IntializeNHibernateAndIoC(PersistenceFramwork, RhinoContainerConfig,
                                                              DatabaseEngine.SQLite, from);

                                    CurrentContext.CreateUnitOfWork();
                                };

        Cleanup after = () => CurrentContext.DisposeUnitOfWork();
        
        
        private static string RhinoContainerConfig
        {
            get { return "nh-windsor.boo"; }
        }

        private static PersistenceFramework PersistenceFramwork
        {
            get { return PersistenceFramework.NHibernate; }
        }
    }
}