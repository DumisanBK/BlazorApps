namespace BancassuranceApi.Services
{
    public interface IBancaXmlSerializer
    {
        T Deserialize<T>(string xmlText);
        string Serialize<T>(T dataToSerialize);
    }
}