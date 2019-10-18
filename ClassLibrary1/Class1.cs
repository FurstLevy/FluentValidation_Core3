using FluentValidation;

namespace ClassLibrary1
{
    public class Class1 : AbstractValidator<Class1>
    {
        public string Name { get; set; }

        private void ValidateName()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("Name can't be empty.");
        }
    }
}
