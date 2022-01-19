using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LearnerProDALRepo : ILearnerProDALRepo<LearnerProfile>
    {
        public bool LearnerProDelete(LearnerProfile learnerPro)
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

        public LearnerProfile LearnerProGet(LearnerProfile learnerPro)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.LearnerProfiles.Where(x => x.Email == email).FirstOrDefault();
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
                    var user = dbContext.LearnerProfiles.LEARNPROF_ALL();
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

        public bool LearnerProInsert(LearnerProfile learnerPro)
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
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool LearnerProUpdate(LearnerProfile learnerPro)
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
                        String newLastName = learnerPro.DOB;
                        String newLastName = learnerPro.Gender;
                        String newLastName = learnerPro.Remarks;
                        String newUserPassword = learnerPro.UserPassword;
                        String newLastName = learnerPro.User_Status;

                        dbContext.LEARNPROF_UPDATE(newEmail, newFirstName, newLastName, newDOB, newGender, newRemarks, newUserPassword, newUser_Status);
                        dbContext.SaveChanges();
                        return true;
                    }
                    else
                        return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
