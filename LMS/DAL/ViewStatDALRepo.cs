using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ViewStatDALRepo : IViewStatDALRepo<ViewStatu>
    {
        public Boolean ViewStatDelete(ViewStatu viewStat)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.ViewStatus.Where(x => x.ID == viewStat.ID).FirstOrDefault();
                    if (user != null)
                    {
                        dbContext.VIEWSTATUS_DELETE(viewStat.ID);
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

        public ViewStatu ViewStatGet(Int32 id)
        {
            throw new NotImplementedException();
        }

        public ViewStatu ViewStatGet(ViewStatu viewStat)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.ViewStatus.Where(x => x.ID == viewStat.ID).FirstOrDefault();
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

        public ICollection<ViewStatu> ViewStatGetAll()
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.ViewStatus_ALL();
                    if (user != null)
                    {
                        return (ICollection<ViewStatu>)user;
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

        public Boolean ViewStatInsert(ViewStatu viewStat)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    dbContext.VIEWSTATUS_INSERT(viewStat.ID, viewStat.LearnerEmailId, viewStat.SubjectId, viewStat.ChapterName, viewStat.TopicName, viewStat.ViewTime, viewStat.Comments);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception )
            {
                return false;
            }
        }

        public Boolean ViewStatUpdate(ViewStatu viewStat)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.ViewStatus.Where(x => x.ID == viewStat.ID).FirstOrDefault();
                    if (user != null)
                    {
                        int newID = viewStat.ID;
                        String newLearnerEmailId = viewStat.LearnerEmailId;
                        int newSubjectId = viewStat.SubjectId;
                        String newChapterName = viewStat.ChapterName;
                        String newTopicName = viewStat.TopicName;
                        DateTime newViewTime = viewStat.ViewTime;
                        String newComments = viewStat.Comments;

                        dbContext.VIEWSTATUS_UPDATE(newID, newLearnerEmailId, newSubjectId, newChapterName, newTopicName, newViewTime, newComments);
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
