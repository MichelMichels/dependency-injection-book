using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExample
{
    public class SecureMessageWriter : IMessageWriter
    {
        private readonly IMessageWriter writer;
        private readonly IIdentity identity;

        public SecureMessageWriter(IMessageWriter writer, IIdentity identity)
        {
            this.writer = writer ?? throw new ArgumentNullException(nameof(writer));
            this.identity = identity ?? throw new ArgumentNullException(nameof(identity));
        }

        public void Write(string message)
        {
            if(identity.IsAuthenticated)
            {
                writer.Write(message);
            }
        }
    }
}
