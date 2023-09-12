using PortsShop.Domain.Untils;

namespace PortsShop.Domain.Validation;

public class PersonValidation
{
    public static bool ValidateCPF(string cpf)
    {
        cpf = cpf.Replace(".", "").Replace("-", "");

        if (cpf.Length != 11 || !DataUtils.IsAllDigits(cpf))
        {
            return false;
        }

        int[] digits = cpf.Select(c => int.Parse(c.ToString())).ToArray();
        int sum1 = 0;
        int sum2 = 0;

        for (int i = 0; i < 9; i++)
        {
            sum1 += digits[i] * (10 - i);
            sum2 += digits[i] * (11 - i);
        }

        int remainder1 = (sum1 % 11);
        int remainder2 = (sum2 % 11);

        if (remainder1 < 2)
        {
            if (digits[9] != 0)
            {
                return false;
            }
        }
        else if (digits[9] != 11 - remainder1)
        {
            return false;
        }

        if (remainder2 < 2)
        {
            if (digits[10] != 0)
            {
                return false;
            }
        }
        else if (digits[10] != 11 - remainder2)
        {
            return false;
        }
        return true;
    }

    public static bool IsOlderThan16(DateTime birthday)
    {
        DateTime currentDate = DateTime.Now;
        int age = currentDate.Year - birthday.Year;

        if (currentDate.Month < birthday.Month || (currentDate.Month == birthday.Month && currentDate.Day < birthday.Day))
        {
            age--;
        }

        return age >= 16;
    }
   

}
