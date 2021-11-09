namespace CommanderGQL.GraphQL.Customers
{
    public record AddCustomerInput(string Email, string Name,int Code,  string DateAndTime, bool IsBlocked );
}