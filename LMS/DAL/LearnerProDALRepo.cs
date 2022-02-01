using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LearnerProDALRepo : ILearnerProDALRepo<LearnerProfile>
    {
        public Boolean LearnerProDelete(LearnerProfile learnerPro)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.LearnerProfiles.Where(x => x.Email == learnerPro.Email).FirstOrDefault();
                    if (user != null)
                    {
                        dbContext.LEARNPROF_DELETE(learnerPro.Email);
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

        public LearnerProfile LearnerProGet(String email)
        {
            throw new NotImplementedException();
        }

        public LearnerProfile LearnerProGet(LearnerProfile learnerPro)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.LearnerProfiles.Where(x => x.Email == learnerPro.Email).FirstOrDefault();
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

        public ICollection<LearnerProfile> LearnerProGetAll()
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.LEARNPROF_ALL().ToList();
                    if (user != null)
                    {
                        return (ICollection<LearnerProfile>)user;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception )
            {
                return null;
            }
        }

        public Boolean LearnerProInsert(LearnerProfile learnerPro)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    dbContext.LEARNPROF_INSERT(learnerPro.Email, learnerPro.FirstName, learnerPro.LastName, learnerPro.DOB, learnerPro.Gender, learnerPro.Remarks, learnerPro.UserPassword, learnerPro.User_Status);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception )
            {
                return false;
            }
        }

        public Boolean LearnerProUpdate(LearnerProfile learnerPro)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.LearnerProfiles.Where(x => x.Email == learnerPro.Email).FirstOrDefault();
                    if (user != null)
                    {
                        String newEmail = learnerPro.Email;
                        String newFirstName = learnerPro.FirstName;
                        String newLastName = learnerPro.LastName;
                        var newDOB = learnerPro.DOB;
                        String newGender = learnerPro.Gender;
                        String newRemarks = learnerPro.Remarks;
                        String newUserPassword = learnerPro.UserPassword;
                        String newUserStatus = learnerPro.User_Status;

                        dbContext.LEARNPROF_UPDATE(newEmail, newFirstName, newLastName, newDOB, newGender, newRemarks, newUserPassword, newUserStatus);
                        dbContext.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception )
            {
                return false;
            }
        }

    }
}
