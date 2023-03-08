using Abp.Dependency;
using GraphQL.Types;
using GraphQL.Utilities;
using ProjectDemo.Queries.Container;
using System;

namespace ProjectDemo.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IServiceProvider provider) :
            base(provider)
        {
            Query = provider.GetRequiredService<QueryContainer>();
        }
    }
}