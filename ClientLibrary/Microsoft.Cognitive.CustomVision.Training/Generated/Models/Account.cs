// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Cognitive.CustomVision.Training.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a user account
    /// </summary>
    public partial class Account
    {
        /// <summary>
        /// Initializes a new instance of the Account class.
        /// </summary>
        public Account()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Account class.
        /// </summary>
        /// <param name="userName">Gets the name of the account owner</param>
        /// <param name="email">Gets the email associated with this
        /// account</param>
        /// <param name="keys">Gets the api keys associated with this
        /// account</param>
        /// <param name="quotas">Gets the quotas associated with this
        /// account</param>
        public Account(string userName = default(string), string email = default(string), ApiKeys keys = default(ApiKeys), AccountQuota quotas = default(AccountQuota))
        {
            UserName = userName;
            Email = email;
            Keys = keys;
            Quotas = quotas;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name of the account owner
        /// </summary>
        [JsonProperty(PropertyName = "UserName")]
        public string UserName { get; private set; }

        /// <summary>
        /// Gets the email associated with this account
        /// </summary>
        [JsonProperty(PropertyName = "Email")]
        public string Email { get; private set; }

        /// <summary>
        /// Gets the api keys associated with this account
        /// </summary>
        [JsonProperty(PropertyName = "Keys")]
        public ApiKeys Keys { get; private set; }

        /// <summary>
        /// Gets the quotas associated with this account
        /// </summary>
        [JsonProperty(PropertyName = "Quotas")]
        public AccountQuota Quotas { get; private set; }

    }
}
