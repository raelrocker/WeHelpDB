using System;

namespace WeHelpDB.Entities
{
    public class Ong
    {
        #region Constructor
        public Ong()
        {
            Address = new Address();
        }
        #endregion

        #region Properties
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public byte[] Photo { get; set; }
        public Address Address { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        #endregion

        #region Relationships
        public virtual User User { get; set; }
        #endregion
    }
}
