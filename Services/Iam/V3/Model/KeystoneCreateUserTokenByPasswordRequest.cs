using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class KeystoneCreateUserTokenByPasswordRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("nocatalog", IsQuery = true)]
        [JsonProperty("nocatalog", NullValueHandling = NullValueHandling.Ignore)]
        public string Nocatalog { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public KeystoneCreateUserTokenByPasswordRequestBody Body { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeystoneCreateUserTokenByPasswordRequest {\n");
            sb.Append("  nocatalog: ").Append(Nocatalog).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KeystoneCreateUserTokenByPasswordRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KeystoneCreateUserTokenByPasswordRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Nocatalog == input.Nocatalog ||
                    (this.Nocatalog != null &&
                    this.Nocatalog.Equals(input.Nocatalog))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Nocatalog != null)
                    hashCode = hashCode * 59 + this.Nocatalog.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
