using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IChapMasDALRepo<ChapterMaster>
    {
        bool ChapMasInsert(ChapterMaster chapMas);

        bool ChapMasDelete(ChapterMaster chapMas);

        bool ChapMasUpdate(ChapterMaster chapMas);

        ChapterMaster ChapMasGetUser(ChapterMaster chapMas);

        ICollection<ChapterMaster> ChapMasGetAll();
    }
}
