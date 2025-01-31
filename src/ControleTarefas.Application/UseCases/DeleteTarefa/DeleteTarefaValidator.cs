using FluentValidation;

namespace ControleTarefas.Application.UseCases.CreateTarefa;

public sealed class DeleteTarefaValidator : AbstractValidator<DeleteTarefaRequest>
{
    public DeleteTarefaValidator()
    {
        RuleFor(x => x.Id).GreaterThan(0);
    }
}
