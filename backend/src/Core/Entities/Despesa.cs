namespace Core.Entities;

public class Despesa
{
    public Guid Id { get; init; } = Guid.CreateVersion7();
    public string Descricao { get; private set; } = string.Empty;
    public DateTime DataHora { get; private set; }
    public decimal Valor { get; private set; }
    public bool Pago { get; private set; } = false;

    protected Despesa() { }

    public Despesa(string descricao, DateTime dataHora, decimal valor, bool pago = false)
    {
        Descricao = descricao;
        DataHora = dataHora;
        Valor = valor;
        Pago = pago;
    }
    public void Update(string descricao, DateTime dataHora, decimal valor, bool pago = false)
    {
        Descricao = descricao;
        DataHora = dataHora;
        Valor = valor;
        Pago = pago;
    }
}
