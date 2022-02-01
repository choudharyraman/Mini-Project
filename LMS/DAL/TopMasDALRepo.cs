using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TopMasDALRepo : ITopMasDALRepo<TopicMaster>
    {
        public Boolean TopMasDelete(TopicMaster topMas)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.TopicMasters.Where(x => x.TopicName == topMas.TopicName).FirstOrDefault();
                    if (user != null)
                    {
                        dbContext.TOPICMASTER_DELETE(topMas.TopicName);
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

        public TopicMaster TopMasGet(String tname)
        {
            throw new NotImplementedException();
        }

        public TopicMaster TopMasGet(TopicMaster topMas)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.TopicMasters.Where(x => x.TopicName == topMas.TopicName).FirstOrDefault();
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

        public ICollection<TopicMaster> TopMasGetAll()
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.TOPICMASTER_ALL().ToList();
                    if (user != null)
                    {
                        return (ICollection<TopicMaster>)user;
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

        public Boolean TopMasInsert(TopicMaster topMas)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    dbContext.TOPICMASTER_INSERT(topMas.TopicName, topMas.SubjectId, topMas.ChapterName, topMas.LastUpdateOn, topMas.ContentUrl);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception )
            {
                return false;
            }
        }

        public Boolean TopMasUpdate(TopicMaster topMas)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.TopicMasters.Where(x => x.TopicName == topMas.TopicName).FirstOrDefault();
                    if (user != null)
                    {
                        String newTopicName = topMas.TopicName;
                        int newSubjectId = topMas.SubjectId;
                        String newChapterName = topMas.ChapterName;
                        DateTime newLastUpdateOn = topMas.LastUpdateOn;
                        String newContentUrl = topMas.ContentUrl;

                        dbContext.TOPICMASTER_UPDATE(newTopicName, newSubjectId, newChapterName, newLastUpdateOn, newContentUrl);
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
