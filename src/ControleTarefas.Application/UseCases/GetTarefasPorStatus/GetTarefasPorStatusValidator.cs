using FluentValidation;

namespace ControleTarefas.Application.UseCases.GetTarefasPorStatus;

public class GetTarefasPorStatusValidator : AbstractValidator<GetTarefasPorStatusRequest>
{
    public GetTarefasPorStatusValidator()
    {
        //sem validação    
    }
}
