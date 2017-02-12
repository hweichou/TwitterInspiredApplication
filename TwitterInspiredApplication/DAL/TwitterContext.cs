using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using TwitterInspiredApplication.Models;

namespace TwitterInspiredApplication.DAL
{
    public class TwitterContext : DbContext
    {
        public TwitterContext()
            :base("TwitterInspiredDB")
            //:base(GetEntityConnectionString())
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Tweet> Tweet { get; set; }
        public DbSet<Mention> Mention { get; set; }
        public DbSet<Reply> Reply { get; set; }
        public DbSet<UserFollow> UserFollow { get; set; }
        public DbSet<Hashtag> Hashtag { get; set; }
        public DbSet<HashtagRelation> HashtagRelation { get; set; }
        public DbSet<ReplyNotification> ReplyNotification { get; set; }
        public DbSet<TweetNotification> TweetNotification { get; set; }

        /**
        public static string GetEntityConnectionString()
        {
            string connectionString = new SqlConnectionStringBuilder
            {
                InitialCatalog = "TwitterDB",
                DataSource = "hweichou.database.windows.net",
                IntegratedSecurity = false,
                UserID = "hweichou",
                Password = "Weichou299331",
                MultipleActiveResultSets = true,
                PersistSecurityInfo = true,
            }.ConnectionString;
            return connectionString;
        }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<TwitterContext>(null);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            // ------- Primary Keys ----------- //
            modelBuilder.Entity<User>().HasKey(x => x.uid);
            modelBuilder.Entity<Tweet>().HasKey(x => x.tid);
            modelBuilder.Entity<Mention>().HasKey(x => x.mid);
            modelBuilder.Entity<Reply>().HasKey(x => x.rid);
            modelBuilder.Entity<ReplyNotification>().HasKey(x => x.rnid);
            modelBuilder.Entity<UserFollow>().HasKey(x => x.id);
            modelBuilder.Entity<Hashtag>().HasKey(x => x.hid);
            modelBuilder.Entity<HashtagRelation>().HasKey(x => x.hrid);
            modelBuilder.Entity<TweetNotification>().HasKey(x => x.tnid);

            // ------- Foreign Keys ----------- //
            modelBuilder.Entity<UserFollow>()
                .HasRequired(a => a.MainUser)
                .WithMany(b => b.FollowBy)
                .HasForeignKey(c => c.uid);

            modelBuilder.Entity<UserFollow>()
                .HasRequired(a => a.FollowingUser)
                .WithMany(b => b.Following)
                .HasForeignKey(c => c.followId);

            modelBuilder.Entity<Tweet>()
                .HasRequired(a => a.TweetUser)
                .WithMany(b => b.UserTweet)
                .HasForeignKey(c => c.uid);

            modelBuilder.Entity<Mention>()
                .HasRequired(a => a.MentionedUser)
                .WithMany(b => b.UserMention)
                .HasForeignKey(c => c.uid);

            modelBuilder.Entity<Mention>()
                .HasRequired(a => a.MentionedTweet)
                .WithMany(b => b.MentionTweet)
                .HasForeignKey(c => c.tid);

            modelBuilder.Entity<TweetNotification>()
                .HasRequired(a => a.NotifyTweet)
                .WithMany(b => b.TweetNotify)
                .HasForeignKey(c => c.tid);

            modelBuilder.Entity<TweetNotification>()
                .HasRequired(a => a.NotifyUser)
                .WithMany(b => b.UserNotify)
                .HasForeignKey(c => c.uid);

            modelBuilder.Entity<Reply>()
                .HasRequired(a => a.ReplyTweet)
                .WithMany(b => b.TweetReply)
                .HasForeignKey(c => c.tid);

            modelBuilder.Entity<ReplyNotification>()
                .HasRequired(a => a.NotifyReply)
                .WithMany(b => b.ReplyNotify)
                .HasForeignKey(c => c.rid);

            modelBuilder.Entity<ReplyNotification>()
                .HasRequired(a => a.NotifyUser)
                .WithMany(b => b.UserRNotify)
                .HasForeignKey(c => c.uid);

            modelBuilder.Entity<HashtagRelation>()
                .HasRequired(a => a.RelationHash)
                .WithMany(b => b.HashtagR)
                .HasForeignKey(c => c.tagid);

            modelBuilder.Entity<HashtagRelation>()
                .HasRequired(a => a.RelationTweet)
                .WithMany(b => b.TweetRelation)
                .HasForeignKey(c => c.tid);

          

            var typesToRegister = from t in Assembly.GetExecutingAssembly().GetTypes()
                                  where !string.IsNullOrEmpty(t.Namespace) &&
                                        t.BaseType != null
                                        && t.BaseType.BaseType != null
                                        && t.BaseType.BaseType.IsGenericType
                                  let genericType = t.BaseType.BaseType.GetGenericTypeDefinition()
                                  where genericType == typeof(EntityTypeConfiguration<>) || genericType == typeof(ComplexTypeConfiguration<>)
                                  select t;

            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }

            base.OnModelCreating(modelBuilder);
        }
    **/

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }

}


