using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheContentDepartment.Models.Contracts;
using TheContentDepartment.Repositories.Contracts;

namespace TheContentDepartment.Repositories
{
    public class MemberRepository : IRepository<ITeamMember>
    {
        private List<ITeamMember> teamMembers = new List<ITeamMember>();
        public IReadOnlyCollection<ITeamMember> Models
        {
            get
            {
                return this.teamMembers.AsReadOnly();
            }
        }

        public void Add(ITeamMember model)
        {
            this.teamMembers.Add(model);
        }

        public ITeamMember TakeOne(string modelName)
        {
            return this.teamMembers.FirstOrDefault(x => x.Name == modelName);
        }
    }
}
