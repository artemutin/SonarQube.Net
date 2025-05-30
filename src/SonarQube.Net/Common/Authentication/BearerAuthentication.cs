namespace SonarQube.Net.Common.Authentication;

public class BearerAuthentication: AuthenticationMethod
{
    public BearerAuthentication(string token)
    {
        Token = token;
    }

    public string Token { get; }
}