namespace Business.Helper;

public static class HashHelper
{
    public static string GetHash(string input)
    {
        return BCrypt.Net.BCrypt.HashPassword(input);
    }

    public static bool VerifyHash(string input, string storedHash)
    {
        return BCrypt.Net.BCrypt.Verify(input, storedHash);

    }
}