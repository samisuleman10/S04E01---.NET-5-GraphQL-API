using HotChocolate.Types;

namespace CommanderGQL.GraphQL.Customers
{
    public class AddCustomerPayloadType : ObjectType<AddCustomerPayload>
    {
        protected override void Configure(IObjectTypeDescriptor<AddCustomerPayload> descriptor)
        {
            descriptor.Description("Represents the payload to return for an added platform.");

            descriptor
                .Field(p => p.customer)
                .Description("Represents the added platform.");

            base.Configure(descriptor);
        }
    }
}