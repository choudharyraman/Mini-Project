using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SubMasDALRepo : ISubMasDALRepo<SubjectMaster>
    {
        public bool SubMasDelete(SubjectMaster subMas)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.SubjectMasters.Where(x => x.SubjectId == subMas.SubjectId).FirstOrDefault();
                    if (user != null)
                    {
                        dbContext.SUBMASTER_DELETE(subMas.SubjectId);
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

        public SubjectMaster SubMasGet(SubjectMaster)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.SubjectMasters.Where(x => x.SubjectId == SubjectId).FirstOrDefault();
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

        public ICollection<SubjectMaster> SubMasGetAll()
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.SubjectMasters.SUBMASTER_ALL();
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

        public bool SubMasInsert(SubjectMaster subMas)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    dbContext.SUBMASTER_INSERT(subMas.SubjectId, subMas.SubjectName, subMas.LastUpdatedOn, subMas.Domain);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool SubMasUpdate(SubjectMaster subMas)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.SubjectMasters.Where(x => x.SubjectId == subMas.SubjectId).FirstOrDefault();
                    if (user != null)
                    {
                        String newSubjectId = subMas.SubjectId;
                        String newSubjectName = subMas.SubjectName;
                        String newLastUpdatedOn = subMas.LastUpdatedOn;
                        String newDomain = subMas.Domain;

                        dbContext.SUBMASTER_UPDATE(newSubjectId, newSubjectName, newLastUpdatedOn, newDomain);
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
