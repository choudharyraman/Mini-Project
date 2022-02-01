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

        public SubjectMaster SubMasGet(Int32 subid)
        {
            throw new NotImplementedException();
        }

        public SubjectMaster SubMasGet(SubjectMaster subMas)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.SubjectMasters.Where(x => x.SubjectId == subMas.SubjectId).FirstOrDefault();
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
                    var user = dbContext.SUBMASTER_ALL();
                    if (user != null)
                    {
                        return (ICollection<SubjectMaster>)user;
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
                    dbContext.SUBMASTER_INSERT(subMas.SubjectId, subMas.SubjectName, subMas.LastUpdateOn, subMas.Domain);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception )
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
                        int newSubjectId = subMas.SubjectId;
                        String newSubjectName = subMas.SubjectName;
                        DateTime newLastUpdatedOn = subMas.LastUpdateOn;
                        String newDomain = subMas.Domain;

                        dbContext.SUBMASTER_UPDATE(newSubjectId, newSubjectName, newLastUpdatedOn, newDomain);
                        dbContext.SaveChanges();
                        return true;
                    }
                    else
                        return false;
                }
            }
            catch (Exception )
            {
                return false;
            }
        }

    }
}
