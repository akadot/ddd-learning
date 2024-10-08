namespace Application;

public enum ErrorCodes
{
    NOT_FOUND = 1,
    COULD_NOT_STORE_DATA = 2
}

public abstract class AbstractResponse
{
    public bool Success {get; set;}
    public string Message {get;set;} = null!;
    public ErrorCodes ErrorCode {get; set;}
}
