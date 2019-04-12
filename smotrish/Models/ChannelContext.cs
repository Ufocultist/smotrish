using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace smotrish.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ChannelContext : DbContext
    {
        public DbSet<Channel> Channels { get; set; }

        public ChannelContext()
        : base("sm_ent") { }
    }
    
}