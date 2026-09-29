public class Member{
    public  Guid Id {get; private set;}
    public string Name { get; private set; }
     public const int MaxFullNameLength = 150;

    

    public Member(Guid Id, string Name ){

        this.Id = Id;
        this.Name= Name;

    }

    private static string validateName(string? name)
    {

        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name is required.", nameof(name));
        var trimmed = name.Trim();

        if (trimmed.Length > MaxFullNameLength)
            throw new ArgumentException($"Full name cannot exceed {MaxFullNameLength} characters.", nameof(name));

        return trimmed;
    }

}