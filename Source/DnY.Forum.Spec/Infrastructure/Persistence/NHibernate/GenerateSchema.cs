using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace DnY.Forum.Infrastructure.Persistence.NHibernate
{
    using Machine.Specifications;
    using Log;
    using Sample;

    [Tags("Setup", "Persistence")]
    public class when_given_models_and_mapping_infos
    {
        Establish context = () =>
        {
            cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(Product).Assembly);
        };

        It should_generate_schema = () => new SchemaExport(cfg).Execute(true, true, false, false);

        private readonly static ILog logger = LogFactory.GetSpecificationLogger();
        private static Configuration cfg;
    }
}