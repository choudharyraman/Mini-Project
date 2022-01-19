using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ViewStatDALRepo : IViewStatDALRepo<ViewStatu>
    {
        public bool ViewStatDelete(ViewStatu viewStat)
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

        public ViewStatu ViewStatGet(ViewStatu viewStat)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.ViewStatus.Where(x => x.ID == ID).FirstOrDefault();
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
                    var user = dbContext.ViewStatus.VIEWSTATUS_ALL();
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

        public bool ViewStatInsert(ViewStatu viewStat)
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
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ViewStatUpdate(ViewStatu viewStat)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.ViewStatus.Where(x => x.ID == viewStat.ID).FirstOrDefault();
                    if (user != null)
                    {
                        String newID = viewStat.ID;
                        String newLearnerEmailId = viewStat.LearnerEmailId;
                        String newSubjectId = viewStat.SubjectId;
                        String newChapterName = viewStat.ChapterName;
                        String newTopicName = viewStat.TopicName;
                        String newViewTime = viewStat.ViewTime;
                        String newComments = viewStat.Comments;

                        dbContext.VIEWSTATUS_UPDATE(newID, newLearnerEmailId, newSubjectId, newChapterName, newTopicName, newViewTime, newComments);
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
