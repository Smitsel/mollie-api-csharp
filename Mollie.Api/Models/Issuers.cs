using System.Collections.Generic;

namespace Mollie.Api.Models
{
    /// <summary>
    /// Ideal issuer set
    /// </summary>
    public class Issuers : BaseList
    {
        public List<Issuer> data { get; set; }
    }
}