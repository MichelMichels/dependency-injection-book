using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExample
{
    public class Salutation
    {
        private readonly IMessageWriter _writer;

        public Salutation(IMessageWriter writer)
        {
            if(writer == null)
            {
                throw new NullReferenceException($"Argument 'writer' is null");
            }

            _writer = writer;
        }

        public void Exclaim()
        {
            _writer.Write("Hello DI!");
        }
    }
}
