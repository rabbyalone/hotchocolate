using HotChocolate.Types;

namespace HotChocolate.Integration.ArgumentValidation
{
    public class ExecuteArgumentValidationDirectiveType
        : DirectiveType
    {
        protected override void Configure(IDirectiveTypeDescriptor descriptor)
        {
            descriptor.Name("executeValidation");
            descriptor.Location(Types.DirectiveLocation.Object);
            descriptor.OnBeforeInvokeResolver<ExecuteArgumentValidationMiddleware>(
                t => t.Validate(default));
        }
    }
}
