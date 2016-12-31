namespace WeHelpDB.Entities
{
    /// <summary>
    /// Complex Type Address
    /// </summary>
    public class Address
    {
        #region Properties
        public string Street { get; set; }
        public string Complement { get; set; }
        public int? Number { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
        #endregion
    }
}
