using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX
{

    internal class Document : IStorage, IEncryptable
    {
        public void Read(string fileName)
        {
            throw new NotImplementedException();
        }

        public void Write(string fileName)
        {
            throw new NotImplementedException();
        }

        void IEncryptable.Decrypt()
        {
            throw new NotImplementedException();
        }

        void IEncryptable.Encrypt()
        {
            throw new NotImplementedException();
        }


    }
}
