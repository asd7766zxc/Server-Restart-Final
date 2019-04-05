using System.Security;

namespace Server_Restart_Final
{
    public interface IHavePassword
    {
        SecureString SecurePassword { get; }
    }
}