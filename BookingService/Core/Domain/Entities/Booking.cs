namespace Domain;

public class Booking : Base
{
    public Booking()
    {
        this.Status = Status.Created;
    }

    public DateTime PlacedAt { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    private Status Status { get; set; }

    public Status CurrentStatus { get { return this.Status; } }

    public void ChangeState(Actions action)
    {
        //Definindo regra de negócios para alteração de status
        this.Status = (this.Status, action) switch
        {
            (Status.Created, Actions.Pay) => Status.Paid, //Reserva criada e quero pagar => status muda para pago
            (Status.Created, Actions.Cancel) => Status.Canceled, //Reserva criada e quero cancelar => status muda para cancelado
            (Status.Paid, Actions.Finish) => Status.Finished, //Reserva paga e quero finalizar => status muda para finalizado
            (Status.Paid, Actions.Refund) => Status.Refounded, //Reserva paga e quero dinheiro de volta => status muda para reembolsado
            (Status.Canceled, Actions.Reopen) => Status.Created, //Reserva cancelada e quero reabrir => status muda para reaberto
            _ => this.Status //Nenhum dos cenários acima, apenas retorna o status
        };
    }
}
