using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdminRegDALRepo : IAdminRegDALRepo<AdminRegistration>
    {
        public bool AdminRegDelete(AdminRegistration adminReg)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.AdminRegistrations.Where(x => x.email == adminReg.email).FirstOrDefault();
                    if (user != null)
                    {
                        dbContext.ADMINREG_DELETE(adminReg.email);
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

        public AdminRegistration AdminRegGetUser(string email)
        {
            throw new NotImplementedException();
        }

        public ICollection<AdminRegistration> AdminRegGetAll()
        {
           try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.ADMINREG_ALL();
                    if (user != null)
                    {
                        return (ICollection < AdminRegistration >) user;
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

        public AdminRegistration AdminRegGetUser(int email)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.AdminRegistrations.Where(x => x.Email == email).FirstOrDefault();
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

        public bool AdminRegInsert(AdminRegistration adminReg)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    dbContext.ADMINREG_INSERT(adminReg.email, adminReg.first_name, adminReg.last_name, adminReg.AdminPassword);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception )
            {
                return false;
            }

        }

        public bool AdminRegUpdate(AdminRegistration adminReg)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.AdminRegistrations.Where(x => x.email == adminReg.email).FirstOrDefault();
                    if (user != null)
                    {
                        String newEmail = adminReg.email;
                        String newFirstName = adminReg.first_name;
                        String newLastName = adminReg.last_name;
                        String newPassword = adminReg.AdminPassword;

                        dbContext.ADMINREG_UPDATE(newEmail, newFirstName, newLastName, newPassword);
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
