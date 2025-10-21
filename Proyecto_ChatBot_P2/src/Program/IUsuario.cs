namespace DefaultNamespace;

public interface IUsuario
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public List<string> Inbox { get; set; }
    public List<string> HistoryMsg{ get; set; }
    public Tuple <string, string> Contact { get; set; }
}