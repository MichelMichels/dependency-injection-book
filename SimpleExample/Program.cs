using Microsoft.Extensions.Configuration;
using SimpleExample;
using System.Security.Principal;

IMessageWriter writer = new SecureMessageWriter(
    new ConsoleMessageWriter(), 
    WindowsIdentity.GetCurrent());
var salutation = new Salutation(writer);
salutation.Exclaim();

Console.ReadLine();