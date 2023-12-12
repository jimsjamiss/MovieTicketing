﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieTicketing.AppData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class db_movie_ticketingEntities3 : DbContext
    {
        public db_movie_ticketingEntities3()
            : base("name=db_movie_ticketingEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<empInfo> empInfo { get; set; }
        public DbSet<movieShows> movieShows { get; set; }
        public DbSet<movieTicketing> movieTicketing { get; set; }
        public DbSet<payment> payment { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<vw_browseMovies> vw_browseMovies { get; set; }
        public DbSet<vw_empList> vw_empList { get; set; }
        public DbSet<vw_list_movieShows> vw_list_movieShows { get; set; }
        public DbSet<vw_userList> vw_userList { get; set; }
    
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
    
        public virtual int sp_delete_movies(Nullable<int> id, string movieName, string movieDate, string movieHours, string movieGenre, Nullable<decimal> moviePrice)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var movieNameParameter = movieName != null ?
                new ObjectParameter("movieName", movieName) :
                new ObjectParameter("movieName", typeof(string));
    
            var movieDateParameter = movieDate != null ?
                new ObjectParameter("movieDate", movieDate) :
                new ObjectParameter("movieDate", typeof(string));
    
            var movieHoursParameter = movieHours != null ?
                new ObjectParameter("movieHours", movieHours) :
                new ObjectParameter("movieHours", typeof(string));
    
            var movieGenreParameter = movieGenre != null ?
                new ObjectParameter("movieGenre", movieGenre) :
                new ObjectParameter("movieGenre", typeof(string));
    
            var moviePriceParameter = moviePrice.HasValue ?
                new ObjectParameter("moviePrice", moviePrice) :
                new ObjectParameter("moviePrice", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_delete_movies", idParameter, movieNameParameter, movieDateParameter, movieHoursParameter, movieGenreParameter, moviePriceParameter);
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
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
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
    
        public virtual int sp_update_moviesInfo(Nullable<int> movieId, string movieName, string movieDate, string movieHours, string movieGenre, Nullable<decimal> moviePrice)
        {
            var movieIdParameter = movieId.HasValue ?
                new ObjectParameter("movieId", movieId) :
                new ObjectParameter("movieId", typeof(int));
    
            var movieNameParameter = movieName != null ?
                new ObjectParameter("movieName", movieName) :
                new ObjectParameter("movieName", typeof(string));
    
            var movieDateParameter = movieDate != null ?
                new ObjectParameter("movieDate", movieDate) :
                new ObjectParameter("movieDate", typeof(string));
    
            var movieHoursParameter = movieHours != null ?
                new ObjectParameter("movieHours", movieHours) :
                new ObjectParameter("movieHours", typeof(string));
    
            var movieGenreParameter = movieGenre != null ?
                new ObjectParameter("movieGenre", movieGenre) :
                new ObjectParameter("movieGenre", typeof(string));
    
            var moviePriceParameter = moviePrice.HasValue ?
                new ObjectParameter("moviePrice", moviePrice) :
                new ObjectParameter("moviePrice", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_update_moviesInfo", movieIdParameter, movieNameParameter, movieDateParameter, movieHoursParameter, movieGenreParameter, moviePriceParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int sp_createMovies(string movieName, string movieDate, string movieHours, string movieGenre, Nullable<decimal> moviePrice)
        {
            var movieNameParameter = movieName != null ?
                new ObjectParameter("movieName", movieName) :
                new ObjectParameter("movieName", typeof(string));
    
            var movieDateParameter = movieDate != null ?
                new ObjectParameter("movieDate", movieDate) :
                new ObjectParameter("movieDate", typeof(string));
    
            var movieHoursParameter = movieHours != null ?
                new ObjectParameter("movieHours", movieHours) :
                new ObjectParameter("movieHours", typeof(string));
    
            var movieGenreParameter = movieGenre != null ?
                new ObjectParameter("movieGenre", movieGenre) :
                new ObjectParameter("movieGenre", typeof(string));
    
            var moviePriceParameter = moviePrice.HasValue ?
                new ObjectParameter("moviePrice", moviePrice) :
                new ObjectParameter("moviePrice", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_createMovies", movieNameParameter, movieDateParameter, movieHoursParameter, movieGenreParameter, moviePriceParameter);
        }
    
        public virtual int sp_delete_user(Nullable<int> empId, string empName, string empAddress, string empRole)
        {
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("empId", empId) :
                new ObjectParameter("empId", typeof(int));
    
            var empNameParameter = empName != null ?
                new ObjectParameter("empName", empName) :
                new ObjectParameter("empName", typeof(string));
    
            var empAddressParameter = empAddress != null ?
                new ObjectParameter("empAddress", empAddress) :
                new ObjectParameter("empAddress", typeof(string));
    
            var empRoleParameter = empRole != null ?
                new ObjectParameter("empRole", empRole) :
                new ObjectParameter("empRole", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_delete_user", empIdParameter, empNameParameter, empAddressParameter, empRoleParameter);
        }
    
        public virtual int sp_updateUser(Nullable<int> empId, string empName, string empAddress, string empRole)
        {
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("empId", empId) :
                new ObjectParameter("empId", typeof(int));
    
            var empNameParameter = empName != null ?
                new ObjectParameter("empName", empName) :
                new ObjectParameter("empName", typeof(string));
    
            var empAddressParameter = empAddress != null ?
                new ObjectParameter("empAddress", empAddress) :
                new ObjectParameter("empAddress", typeof(string));
    
            var empRoleParameter = empRole != null ?
                new ObjectParameter("empRole", empRole) :
                new ObjectParameter("empRole", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_updateUser", empIdParameter, empNameParameter, empAddressParameter, empRoleParameter);
        }
    }
}
