namespace Domain.Models;

public class Match
{
    private Match(int id, Guid userId)
    {
        Id = id;
        UserId = userId;
    }
    
    public int Id { get; private set; }
    public int Hight_Point { get; private set; }
    
    public Guid UserId { get; private set; }
    public User? User { get; private set; }
    
    public static (Portfolio portfolio, string Error) Create(Guid id, string name, Guid userId)
    {
        var error = string.Empty;

        if (string.IsNullOrEmpty(name) ||  name.Length > max_name_lenght)
        {
            error = "Title can not be empty or longer then 50 symbols";
        }
        
        var portfolio = new Portfolio(id, name, userId);

        return (portfolio, error);
    }
}