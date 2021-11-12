using System.Linq;
using CommanderGQL.Data;
using CommanderGQL.Models;
using HotChocolate;
using HotChocolate.Types;

namespace CommanderGQL.GraphQL.Customers
{
    public class CustomerType : ObjectType<Customer>
    {
        protected override void Configure(IObjectTypeDescriptor<Customer> descriptor)
        {
            descriptor.Description("Represents any software or service that has a command line interface.");

            descriptor
                .Field(p => p.Id)
                .Description("Represents the unique ID for the platform.");

            descriptor
                .Field(p => p.Name)
                .Description("Represents the name for the platform.");

            descriptor
                .Field(p => p.Email)
                .Description("Represents the name for the platform.");

            descriptor
                .Field(p => p.Code)
                .Description("Represents the name for the platform.");

            descriptor
                .Field(p => p.DateAndTime)
                .Description("Represents the name for the platform.");

            descriptor
                .Field(p => p.IsBlocked)
                .Description("Represents the name for the platform.");

        }
    }
}