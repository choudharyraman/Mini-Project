using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ViewStatBLL
    {
        ViewStatDALRepo viewStatDAL = new ViewStatDALRepo();

        public bool ViewStatDelete(ViewStatu viewStat)
        {
            return viewStatDAL.ViewStatDelete(viewStat);
        }

        public ViewStatu ViewStatGet(int id)
        {
            return viewStatDAL.ViewStatGet(id);
        }

        public ICollection<ViewStatu> ViewStatGetAll()
        {
            return viewStatDAL.ViewStatGetAll();
        }

        public bool ViewStatInsert(ViewStatu viewStat)
        {
            return viewStatDAL.ViewStatInsert(viewStat);
        }

        public bool ViewStatUpdate(ViewStatu viewStat)
        {
            return viewStatDAL.ViewStatUpdate(viewStat);
        }
    }
}
