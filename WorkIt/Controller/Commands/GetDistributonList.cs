using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkIt.Model;
using WorkIt.View;

namespace WorkIt.Controller.Commands
{
    class GetDistributonList : ACommand
    {
        public GetDistributonList(IView view, IModel model)
        {
            base.m_view = view;
            base.m_model = model;
        }

        public override void DoCommand(string[] args)
        {
            List<string> list = m_model.GetDistributionList();
            m_view.SetDistributionList(list);
        }
    }
}
