using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    public class MembershipService
    {
        private readonly IDataBaseContent _context;

        public MembershipService(IDataBaseContent context)
        {
            _context = context;
        }

        public User FindContextUser(int userId)
        {
            User foundUser = _context.Query<User>().SingleOrDefault(x => x.Id == userId);
            return null;
        }
    }
}
