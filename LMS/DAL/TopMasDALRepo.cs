using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TopMasDALRepo : ITopMasDALRepo<TopicMaster>
    {
        public bool TopMasDelete(TopicMaster topMas)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.TopicMasters.Where(x => x.TopicName ==topMas.TopicName).FirstOrDefault();
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

        public TopicMaster TopMasGet(TopicMaster topMas)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.TopicMasters.Where(x => x.TopicName == TopicName).FirstOrDefault();
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
                    var user = dbContext.TopicMasters.TOPICMASTER_ALL();
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

        public bool TopMasInsert(TopicMaster topMas)
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
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool TopMasUpdate(TopicMaster topMas)
        {
            try
            {
                using (LMSEntities dbContext = new LMSEntities())
                {
                    var user = dbContext.TopicMasters.Where(x => x.TopicName == topMas.TopicName).FirstOrDefault();
                    if (user != null)
                    {
                        String newTopicName = topMas.TopicName;
                        String newSubjectId = topMas.SubjectId;
                        String newChapterName = topMas.ChapterName;
                        String newLastUpdateOn = topMas.LastUpdateOn;
                        String newContentUrl = topMas.ContentUrl;

                        dbContext.TOPICMASTER_UPDATE(newTopicName, newSubjectId, newChapterName, newLastUpdateOn, newContentUrl);
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
