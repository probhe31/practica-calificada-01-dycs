using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;
using Practica1.Common.Application;

namespace Practica1.Common.Infraestructure.Persistence.NHibernate
{
    public class HiLoConvention : IIdConvention
    {
        public void Apply(IIdentityInstance instance)
        {
            var column = Util.getTableName(instance.EntityType.Name) + "_id";
            instance.Column(column);
            instance.GeneratedBy.Native();
            //instance.GeneratedBy.HiLo("ids", "next_high", "9", "entity_name = '" + instance.EntityType.Name + "'");
        }
    }
}
