using Berger.Extensions.System;

namespace Berger.Extensions.Globalization
{
    public class Currency : ICode
    {
        #region Properties
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Symbol { get; set; } = string.Empty;
        public string Format { get; set; }
        public decimal Rate { get; set; }
        public int Digits { get; set; }
        public int Sorting { get; set; }
        public bool Paypal { get; set; }
        public bool Stripe { get; set; }
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