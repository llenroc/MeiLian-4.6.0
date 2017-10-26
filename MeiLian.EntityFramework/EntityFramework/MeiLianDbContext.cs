using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using MeiLian.Authorization.Roles;
using MeiLian.Authorization.Users;
using MeiLian.Chat;
using MeiLian.Friendships;
using MeiLian.MultiTenancy;
using MeiLian.Storage;
using MeiLian.PaymentCompany;

namespace MeiLian.EntityFramework
{
    /* Constructors of this DbContext is important and each one has it's own use case.
     * - Default constructor is used by EF tooling on design time.
     * - constructor(nameOrConnectionString) is used by ABP on runtime.
     * - constructor(existingConnection) is used by unit tests.
     * - constructor(existingConnection,contextOwnsConnection) can be used by ABP if DbContextEfTransactionStrategy is used.
     * See http://www.aspnetboilerplate.com/Pages/Documents/EntityFramework-Integration for more.
     */

    public class MeiLianDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        /* Define an IDbSet for each entity of the application */

        public virtual IDbSet<BinaryObject> BinaryObjects { get; set; }

        public virtual IDbSet<Friendship> Friendships { get; set; }

        public virtual IDbSet<ChatMessage> ChatMessages { get; set; }

        public virtual IDbSet<PaymentCompanyEntity> PaymentCompany { get; set; }

        public MeiLianDbContext()
            : base("Default")
        {
            
        }

        public MeiLianDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        public MeiLianDbContext(DbConnection existingConnection)
           : base(existingConnection, false)
        {

        }

        public MeiLianDbContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}

