using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using FluentNHibernate.Mapping;
using Northwind.Entities;

namespace Northwind.FluentNHibernate.Overrides
{
    public class UserMappingOverride : IAutoMappingOverride<User>
    {
        public void Override(AutoMapping<User> mapping)
        {
            mapping.Cache.ReadWrite();

            mapping.Id(u => u.Id)
                .GeneratedBy.HiLo("100");

            mapping.Map(u => u.UserName)
                .Not.Nullable()
                .Length(20);

            mapping.Map(u => u.PasswordHash)
                .Not.Nullable();
        }
    }
}