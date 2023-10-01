using Berger.Extensions.Base;

namespace Berger.Extensions.Globalization
{
    public class Country : IContinent, ICurrency, IActive, IGeolocation
    {
        #region Properties
        public Guid ContinentID { get; set; }
        public Continent Continent { get; set; }
        public Guid CurrencyID { get; set; }
        public Currency Currency { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Iso2 { get; set; } = string.Empty;
        public string Iso3 { get; set; } = string.Empty;
        public string Tld { get; set; } = string.Empty;
        public short? Prefix { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public int Sorting { get; set; }
        public bool Active { get; set; }
        #endregion

        #region Methods
        public void SetName(string name)
        {
            this.Name = name;
        }
        public void SetSlug(string slug)
        {
            this.Slug = slug;
        }
        #endregion
    }
}