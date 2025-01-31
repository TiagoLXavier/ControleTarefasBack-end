using FluentValidation;

namespace ControleTarefas.Application.UseCases.GetAllTarefa;

public class GetAllTarefaValidator : AbstractValidator<GetAllTarefaRequest>
{
    public GetAllTarefaValidator()
    {
        //sem validação    
    }
}
