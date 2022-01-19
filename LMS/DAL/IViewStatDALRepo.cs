using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IViewStatDALRepo<ViewStatu>
    {
        bool ViewStatInsert(ViewStatu viewStat);

        bool ViewStatUpdate(ViewStatu viewStat);

        bool ViewStatDelete(ViewStatu viewStat);

        ViewStatu ViewStatGet(ViewStatu viewStat);

        ICollection<ViewStatu> ViewStatGetAll();
    }
}
