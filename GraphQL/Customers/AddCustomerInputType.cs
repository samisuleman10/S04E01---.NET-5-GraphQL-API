using HotChocolate.Types;

namespace CommanderGQL.GraphQL.Customers
{
    public class AddCustomerInputType : InputObjectType<AddCustomerInput>
    {
        protected override void Configure(IInputObjectTypeDescriptor<AddCustomerInput> descriptor)
        {
            descriptor.Description("Represents the input to add for a customer.");

            descriptor
                .Field(c => c.Email)
                .Description("Represents the how-to for the command.");
            descriptor
                .Field(c => c.Name)
                .Description("Represents the command line.");
            descriptor
                .Field(c => c.Code)
                .Description("Represents the unique ID of the platform which the command belongs.");
            descriptor
                .Field(c => c.DateAndTime)
                .Description("Time stamp");

            descriptor
                .Field(c => c.IsBlocked)
                .Description("blocked");

            base.Configure(descriptor);

        }
    }
}