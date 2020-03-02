using Webinar.Models;
using System.Collections.Generic;
using System.Linq;

namespace Webinar.Repository
{
    public static class ExtensionMethods
    {
        public static IEnumerable<tbUser> WithoutPasswords(this IEnumerable<tbUser> users)
        {
            return users.Select(x => x.WithoutPassword());
        }

        public static tbUser WithoutPassword(this tbUser user)
        {
            user.Password = null;
            return user;
        }
    }
}
