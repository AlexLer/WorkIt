using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkIt.Model
{
    public interface IModel
    {
        void AddMember(string[] args);
        void CheckClass(string args);

        List<string> GetDistributionList();
    }
}
