

public abstract class CustomException : Exception
{
    public string Code {get;}

    protected CustomException(string code, string message) : base(message)
    {
        Code = code;
    }

}

//Specific Faillures

public sealed class NotFoundException : CustomException
{
    public NotFoundException(string resource, object key, string? message = null)
    : base ($"{resource}-not-found", message ?? $"No  {resource} found with id {key}")
    {
        
    }
    
}

public sealed class BusinessRuleViolationException: CustomException
{
    public BusinessRuleViolationException(string rule, string message)
    : base(rule, message)
    {
        
    }
}

public sealed class AlreadyExistsException: CustomException
{
    public AlreadyExistsException(string code, string message)
    : base( code ,message )
    {
        
    }
}

public sealed class IdempotencyKeyReusedException : CustomException
{
    public string IdempotencyKey { get; }
 
    public IdempotencyKeyReusedException(string idempotencyKey)
        : base("idempotency-key-reused",
               $"Idempotency-Key '{idempotencyKey}' was already used for a different request. Use a new key for a new operation.")
    {
        IdempotencyKey = idempotencyKey;
    }
}

public sealed class IdempotencyKeyInProgressException : CustomException
{
    public string IdempotencyKey { get; }
 
    public IdempotencyKeyInProgressException(string idempotencyKey)
        : base("idempotency-key-in-progress",
               $"A request with Idempotency-Key '{idempotencyKey}' is still being processed. Retry shortly.")
    {
        IdempotencyKey = idempotencyKey;
    }
}