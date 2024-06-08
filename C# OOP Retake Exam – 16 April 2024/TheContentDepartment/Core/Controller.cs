using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheContentDepartment.Core.Contracts;
using TheContentDepartment.Models;
using TheContentDepartment.Repositories;

namespace TheContentDepartment.Core
{
    public class Controller : IController
    {
        private ResourceRepository resources = new ResourceRepository();
        private MemberRepository members = new MemberRepository();
        public string ApproveResource(string resourceName, bool isApprovedByTeamLead)
        {
            throw new NotImplementedException();
        }

        public string CreateResource(string resourceType, string resourceName, string path)
        {
            throw new NotImplementedException();
        }

        public string DepartmentReport()
        {
            throw new NotImplementedException();
        }

        public string JoinTeam(string memberType, string memberName, string path)
        {
            throw new NotImplementedException();
        }

        public string LogTesting(string memberName)
        {
            throw new NotImplementedException();
        }
    }
}
