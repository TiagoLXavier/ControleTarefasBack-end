using FluentValidation;

namespace ControleTarefas.Application.UseCases.CreateTarefa;

public sealed class CreateTarefaValidator : AbstractValidator<CreateTarefaRequest>
{
    public CreateTarefaValidator()
    {
        RuleFor(x => x.Titulo)
             .NotEmpty().WithMessage("O título da tarefa é obrigatório.")
             .MaximumLength(100).WithMessage("O título da tarefa deve ter no máximo 100 caracteres.");
    }
}
