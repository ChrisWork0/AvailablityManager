using System.Security.Cryptography;
using System.Text;

namespace AvailabilityManager.Helper;

public static class EncoderHelper
{
    public static string EncodeToSha256(string input)
    {
        var inputBytes = Encoding.UTF8.GetBytes(input);
        var hash = SHA256.HashData(inputBytes);
        return Convert.ToHexString(hash).ToLower();
    }
}