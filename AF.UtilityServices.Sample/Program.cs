using Architecture.Foundation.UtilityServices;

namespace AF.UtilityServices.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var encryptVal = AFUtility.UtilityService.Encrypt("EncryptValue");
            var decryptVal = AFUtility.UtilityService.Dycrypt(encryptVal);
        }
    }
}
