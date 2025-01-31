using FluentValidation;

namespace CleanArchitecture.Application.UseCases.GetByIdTarefa;

public class GetByIdTarefaValidator : AbstractValidator<GetByIdTarefaRequest>
{
    public GetByIdTarefaValidator()
    {
        //sem validação    
    }
}
