namespace Berger.Extensions.Globalization
{
    public class Continent
    {
        #region Properties
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public List<Country> Countries { get; set; }
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