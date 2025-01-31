using ControleTarefas.Domain.Common;
using ControleTarefas.Domain.Enums;

namespace ControleTarefas.Domain.Entities;

public sealed class Tarefa : BaseEntity
{
    public string Titulo { get; set; }
    public string? Descricao { get; set; }
    public StatusTarefa Status { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime? DataAlteracao { get; set; }
    public DateTime? DataConclusao { get; set; }

    public void AtualizarTitulo(string novoTitulo)
    {
        Titulo = novoTitulo;
        DataAlteracao = DateTime.Now;
    }

    public void AtualizarDescricao(string novaDescricao)
    {
        Descricao = novaDescricao;
        DataAlteracao = DateTime.Now;
    }

    public void AtualizarStatus(StatusTarefa novoStatus)
    {
        Status = novoStatus;
        DataAlteracao = DateTime.Now;
    }

    public void AtualizarDataConclusao(DateTime? novaDataConclusao)
    {
        DataConclusao = novaDataConclusao;
        DataAlteracao = DateTime.Now;
    }

    public void AtualizarDataCriacao(DateTime novaDataCriacao)
    {
        DataCriacao = novaDataCriacao;
        DataAlteracao = DateTime.Now;
    }

    public void AtualizarDataAlteracao(DateTime? novaDataAlteracao)
    {
        DataAlteracao = novaDataAlteracao;
        DataAlteracao = DateTime.Now;
    }
}