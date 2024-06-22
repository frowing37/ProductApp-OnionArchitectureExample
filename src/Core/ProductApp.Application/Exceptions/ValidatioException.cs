namespace ProductApp.Application.Exceptions;

public class ValidatioException : Exception
{
    public ValidatioException() : this("Validation error occurred") { }
    
    public ValidatioException(string Message) : base(Message) { }
    
    public ValidatioException(Exception ex) : this(ex.Message) { }
}