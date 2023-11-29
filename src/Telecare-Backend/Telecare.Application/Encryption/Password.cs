namespace Telecare.Application.Encryption
{
    public class Password
    {
        public static string HssingPassword(string password)
        {
            byte[] input = System.Text.Encoding.UTF8.GetBytes(password);

            long key = 116421312659916;

            foreach (byte b in input)
            {
                key = (key << 2) + b;
            }

            return key.ToString("X");
        }
    }
}
