namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ServerContext : DbContext
    {
        public ServerContext()
            : base("name=ServerContext")
        {
        }
    }

}