﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication2._0
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class Anviz_test_jose : DbContext
    {
        public Anviz_test_jose()
            : base("name=Anviz_test_jose")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AddTimeSet> AddTimeSets { get; set; }
        public DbSet<BasePara> BaseParas { get; set; }
        public DbSet<Checkinout> Checkinouts { get; set; }
        public DbSet<CheckLog> CheckLogs { get; set; }
        public DbSet<ClientSet> ClientSets { get; set; }
        public DbSet<DefineField> DefineFields { get; set; }
        public DbSet<Dept> Depts { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<LeaveClass> LeaveClasses { get; set; }
        public DbSet<MemStat> MemStats { get; set; }
        public DbSet<OPinfo> OPinfoes { get; set; }
        public DbSet<OPLog> OPLogs { get; set; }
        public DbSet<OutProg> OutProgs { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<SchTime> SchTimes { get; set; }
        public DbSet<StatItem> StatItems { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<T_Checkinout> T_Checkinout { get; set; }
        public DbSet<T_UpdateClient> T_UpdateClient { get; set; }
        public DbSet<TimeTable> TimeTables { get; set; }
        public DbSet<UserCtrLog> UserCtrLogs { get; set; }
        public DbSet<Userinfo> Userinfoes { get; set; }
        public DbSet<UserLeave> UserLeaves { get; set; }
        public DbSet<UserPower> UserPowers { get; set; }
        public DbSet<UserShift> UserShifts { get; set; }
        public DbSet<UserTempShift> UserTempShifts { get; set; }
        public DbSet<FingerClient> FingerClients { get; set; }
        public DbSet<Userinfo_BK> Userinfo_BK { get; set; }
        public DbSet<UserinfoBackup> UserinfoBackups { get; set; }
        public DbSet<V_Class> V_Class { get; set; }
        public DbSet<V_UserClient> V_UserClient { get; set; }
    
        public virtual ObjectResult<GetEmployes_Result> GetEmployes(Nullable<int> userid, string begindate)
        {
            var useridParameter = userid.HasValue ?
                new ObjectParameter("userid", userid) :
                new ObjectParameter("userid", typeof(int));
    
            var begindateParameter = begindate != null ?
                new ObjectParameter("begindate", begindate) :
                new ObjectParameter("begindate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetEmployes_Result>("GetEmployes", useridParameter, begindateParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_matrix_weekdays_Result> sp_matrix_weekdays(Nullable<int> idDepto, string begindate)
        {
            var idDeptoParameter = idDepto.HasValue ?
                new ObjectParameter("idDepto", idDepto) :
                new ObjectParameter("idDepto", typeof(int));
    
            var begindateParameter = begindate != null ?
                new ObjectParameter("begindate", begindate) :
                new ObjectParameter("begindate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_matrix_weekdays_Result>("sp_matrix_weekdays", idDeptoParameter, begindateParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
