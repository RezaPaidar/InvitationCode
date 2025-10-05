using System;

namespace invitationCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("📨 Friendly Invitation Codes:\n");

            for (int i = 1; i <= 5; i++)
            {
                string code = InvitationCodeGenerator.GenerateFriendlyCode(true, (1,1));
                Console.WriteLine($"Code {i}: {code}");
            }

            Console.WriteLine("\n✅ Press any key to exit...");
            Console.ReadKey();
        }
    }
}