using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChapMasDALRepo : IChapMasDALRepo<ChapterMaster>
    {
     


        bool IChapMasDALRepo<ChapterMaster>.ChapMasDelete(ChapterMaster chapMas)
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
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ChapMasUpdate(ChapterMaster chapMas)
        {
            throw new NotImplementedException();
        }

        public bool ChapMasInsert(ChapterMaster chapMas)
        {
            throw new NotImplementedException();
        }

        public ChapterMaster ChapMasGet(string chapterName)
        {
            throw new NotImplementedException();
        }

        public ICollection<ChapterMaster> ChapMasGetAll()
        {
            throw new NotImplementedException();
        }

        public bool ChapMasDelete(ChapterMaster chapMas)
        {
            throw new NotImplementedException();
        }

        ICollection<ChapterMaster> IChapMasDALRepo<ChapterMaster>.ChapMasGetAll()
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.ChapterMaster_ALL();
                    if (user != null)
                    {
                        return (ICollection<ChapterMaster>)user;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        ChapterMaster IChapMasDALRepo<ChapterMaster>.ChapMasGetUser(ChapterMaster chapMas)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.ChapterMasters.Where(x => x.ChapterName == chapMas.ChapterName).FirstOrDefault();
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
            catch (Exception ex)
            {
                return null;
            }
        }

        bool IChapMasDALRepo<ChapterMaster>.ChapMasInsert(ChapterMaster chapMas)
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
            catch (Exception ex )
            {
                return false;
            }
        }

        bool IChapMasDALRepo<ChapterMaster>.ChapMasUpdate(ChapterMaster chapMas)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.ChapterMasters.Where(x => x.ChapterName == chapMas.ChapterName).FirstOrDefault();
                    if (user != null)
                    {
                        String newChapterName = chapMas.ChapterName;
                        int newSubjectId = chapMas.SubjectId;
                        DateTime newLastUpdatedOn = chapMas.LastUpdatedOn;

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

