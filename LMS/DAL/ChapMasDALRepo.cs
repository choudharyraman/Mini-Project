using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChapMasDALRepo : IChapMasDALRepo<ChapterMaster>
    {
        public string ChapterName { get; private set; }

        public bool ChapMasDelete(ChapterMaster chapMas)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.ChapterMasters.Where(x => x.ChapterName == chapMas.ChapterName).FirstOrDefault();
                    if (user != null)
                    {
                        dbContext.CHAPTERMASTER_DELETE(chapMas.ChapterName);
                        dbContext.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public ICollection<ChapterMaster> ChapMasGetAll()
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.ChapterMasters.CHAPTERMASTER_ALL();
                    if (user != null)
                    {
                        return user;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public ChapterMaster ChapMasGetUser(int email)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.ChapterMasters.Where(x => x.ChapterName == ChapterName).FirstOrDefault();
                    if (user != null)
                    {
                        return user;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool ChapMasInsert(ChapterMaster chapMas)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    dbContext.CHAPTERMASTER_INSERT(chapMas.ChapterName, chapMas.SubjectId, chapMas.LastUpdatedOn);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ChapMasUpdate(ChapterMaster chapMas)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.ChapterMasters.Where(x => x.ChapterName == chapMas.ChapterName).FirstOrDefault();
                    if (user != null)
                    {
                        String newChapterName = chapMas.ChapterName;
                        string newSubjectId = chapMas.SubjectId;
                        String newLastUpdatedOn = chapMas.LastUpdatedOn;

                        dbContext.CHAPTERMASTER_UPDATE(newChapterName, newSubjectId, newLastUpdatedOn);
                        dbContext.SaveChanges();
                        return true;
                    }
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
