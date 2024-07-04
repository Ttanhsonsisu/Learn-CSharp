using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX
{
    public interface IStorage
    {
        void Read(string fileName);
        void Write(string fileName);
        
    }

    public interface IEncryptable
    {
        void Encrypt();
        void Decrypt();
    }

}
