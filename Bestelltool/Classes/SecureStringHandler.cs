using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Bestelltool.Classes
{
    /// <summary>
    /// Helper class to handle SecureStrings
    /// </summary>
    internal static class SecureStringHandler
    {
        /// <summary>
        /// Returns a string obtained from a SecureString
        /// </summary>
        /// <param name="securestring"></param>
        /// <returns></returns>
        public static string SecureStringToString(SecureString securestring)
        {
            IntPtr valuePtr = IntPtr.Zero;
            try
            {
                valuePtr = Marshal.SecureStringToGlobalAllocUnicode(securestring);
                return Marshal.PtrToStringUni(valuePtr);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(valuePtr);
            }
        }

        /// <summary>
        /// Converts a string to a Securestring
        /// </summary>
        /// <param name="secure"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static void StringToSecureString(ref SecureString secure, string value)
        {
            secure = new SecureString();
            foreach (char c in value.ToCharArray())
            {
                secure.AppendChar(c);
            }
        }
    }
}