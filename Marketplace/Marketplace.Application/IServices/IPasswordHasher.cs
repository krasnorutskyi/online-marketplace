namespace Marketplace.Application.IServices;

public interface IPasswordHasher
{
    string PasswordHash(string password);
    bool Check(string password, string passwordHash);
}