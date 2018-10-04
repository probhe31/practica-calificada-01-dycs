using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;
using Practica1.Common.Application;

namespace Practica1.Common.Infraestructure.Persistence.NHibernate
{
    public class TableNameConvention : IClassConvention
    {
        public void Apply(IClassInstance instance)
        {
            instance.Table(Util.getTableName(instance.EntityType.Name));
        }
    }
}
