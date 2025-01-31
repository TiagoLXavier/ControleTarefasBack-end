using FluentValidation;

namespace CleanArchitecture.Application.UseCases.UpdateUser;

public class UpdateTarefaValidator : AbstractValidator<UpdateTarefaRequest>
{
    public UpdateTarefaValidator()
    {
        RuleFor(x => x.Titulo)
            .NotEmpty().WithMessage("O título da tarefa é obrigatório.")
            .MaximumLength(100).WithMessage("O título da tarefa deve ter no máximo 100 caracteres.");

        RuleFor(x => x.Status)
            .IsInEnum().WithMessage("O status deve ser um valor válido: {EnumValues}");

        RuleFor(x => x.DataConclusao)
            .GreaterThan(x => x.DataCriacao)
            .WithMessage("A data de conclusão deve ser posterior à data de criação.");
    }
}