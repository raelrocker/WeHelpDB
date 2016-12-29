using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WeHelpDB.Mapping.Interfaces;

namespace WeHelpDB.Context
{
    public class WeHelpContext : DbContext
    {
        #region Construtor
        public WeHelpContext()
            : base ("name=WeHelpDB")
        {
            Database.SetInitializer(new Initializer<WeHelpContext>());
        }
        #endregion

        #region Mapping configuration
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Mapping database
            // Get all classes that implement IMapping interface
            var typesToMapping = (from x in Assembly.GetExecutingAssembly().GetTypes()
                                  where x.IsClass && typeof(IMapping).IsAssignableFrom(x)
                                  select x).ToList();

            foreach (var mapping in typesToMapping)
            {
                dynamic mappingClass = Activator.CreateInstance(mapping);
                modelBuilder.Configurations.Add(mappingClass);
            }

            base.OnModelCreating(modelBuilder);

        }
        #endregion
    }
}
