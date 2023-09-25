﻿using PortsShop.Infra.Data.Context;
using System.Security.Cryptography;
using System.Text;

namespace iSAGAAPI.Services;

public static class CriptografyService
{
    public static string criptografyPassword(string password)
    {
        var md5 = MD5.Create();
        byte[] inputBytes = Encoding.ASCII.GetBytes(password);
        byte[] hashBytes = md5.ComputeHash(inputBytes);
        string passwordEncripto = Convert.ToHexString(hashBytes);

        return passwordEncripto;
    }

    public static string encodedBasic(string userName, string password)
    {

        string encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1")
                                       .GetBytes(userName + ":" + password));
        return encoded;
    }
}
