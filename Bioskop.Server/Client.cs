namespace Bioskop.Server
{
    public class Client
    {
        public int ClientId { get; set; }
        //public int ClientPort { get; set; }
        public string ClientIp { get; set; }

        public override string ToString()
        {
            return $"{ClientId}-  {5}";
        }
    }
}
