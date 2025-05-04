namespace Business.Helper;

public static class HashHelper
{
    public static string GetHash(string input)
    {
        return BCrypt.Net.BCrypt.HashPassword(input);
    }
}