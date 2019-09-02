using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCodeConsoleApp
{
    public interface IBruteForce
    {
        string Name { get; }
        int MaxChars { get; }

        void Initialise(string password, int maxNumber);
        bool CheckPassword();
        void Run();
        void DisplayPassword();
    }
}
