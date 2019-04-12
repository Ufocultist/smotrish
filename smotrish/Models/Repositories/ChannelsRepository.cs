using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace smotrish.Models.Repositories
{
    public class ChannelsRepository : Repository<Channel>
    {
        public List<Channel> GetByName(String name)
        {
            return DbSet.Where(a => a.Name.Contains(name)).ToList();
        }
    }
}