namespace Domain;

public enum Actions
{
    Pay = 0,
    Finish = 1, //After pay and use
    Cancel = 2, //Can never be paid
    Refund = 3, //Paid then refund
    Reopen = 4 //Canceled
}
