using Northwind.Entities;

namespace Northwind.Builders
{
    public class UserBuilder
    {
        private string _userName = "dbr";
        private byte[] _passwordHash = new byte[] { 1, 2, 3 };

        public UserBuilder WithUserName(string userName)
        {
            _userName = userName;
            return this;
        }

        public UserBuilder WithPasswordHash(byte[] passwordHash)
        {
            _passwordHash = passwordHash;
            return this;
        }

        public User Build()
        {
            return new User(_userName, _passwordHash);
        }
    }
}