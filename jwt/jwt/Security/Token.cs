namespace jwt.Security
{
    public class Token
    {
        public string AccesToken { get; set; }
        public string RefreshToken { get; set; }
        public DateTime Expiration { get; set; }
    }
}
