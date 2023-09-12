namespace PortsShop.Domain.Untils;

public static class DataUtils
{
    public static bool IsAllDigits(string input)
    {
        foreach (char c in input)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }
        return true;
    }
}
