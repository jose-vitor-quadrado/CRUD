namespace Blog;

public static class Configuration
{
    public static string JwtKey = "MWFhZTYyYmItODAyOS00M2M1LWJlZmMtZTU1ZjNkNDgyMThk";
    public static string ApiKeyName = "api_key";
    public static string ApiKey = "curso_api_IlTevUM/z0ey3NwCV/unWg==";
    public static SmtpConfiguration Smtp = new();

    public class SmtpConfiguration
    {
        public string Host { get; set; } = string.Empty;
        public int Post { get; set; } = 25;
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}