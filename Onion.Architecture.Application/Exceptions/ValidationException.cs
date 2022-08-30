using FluentValidation.Results;

namespace Onion.Architecture.Application.Exceptions
{
    public class ValidationException : Exception
    {
        public IEnumerable<string> Erros { get; }

        public ValidationException() : base("Se han producido uno o más error de validación")
        {
            Erros = new List<string>();
        }

        public ValidationException(IEnumerable<ValidationFailure> failures) : this()
        {
            foreach (var failure in failures)
            {
                Erros.Append(failure.ErrorMessage);
            }
        }

    }
}
