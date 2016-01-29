using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace TestLib
{
    public class MembershipMemberTests
    {
        [Test]
        public void IfUserNotFound_ThrowArgumentException()
        {
            var databaseContext = new Mock<IDataBaseContent>();
            databaseContext
                .Setup(x => x.Query<User>())
                .Returns(new List<User>().AsQueryable());
            var membershpService=new MembershipService(databaseContext.Object);
            Assert.Throws<ArgumentException>(() => membershpService.FindContextUser(1));
        }
    }
}
