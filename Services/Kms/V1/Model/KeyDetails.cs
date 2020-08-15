using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class KeyDetails 
    {
        /// <summary>
        /// 密钥来源，默认为“kms”，枚举如下：  - kms表示密钥材料由kms生成kms表示密钥材料由kms生成  - external表示密钥材料由外部导入
        /// </summary>
        /// <value>密钥来源，默认为“kms”，枚举如下：  - kms表示密钥材料由kms生成kms表示密钥材料由kms生成  - external表示密钥材料由外部导入</value>
        [JsonConverter(typeof(EnumClassConverter<OriginEnum>))]
        public class OriginEnum
        {
            /// <summary>
            /// Enum KMS for value: kms
            /// </summary>
            public static readonly OriginEnum KMS = new OriginEnum("kms");

            /// <summary>
            /// Enum EXTERNAL for value: external
            /// </summary>
            public static readonly OriginEnum EXTERNAL = new OriginEnum("external");

            public static readonly Dictionary<string, OriginEnum> StaticFields =
            new Dictionary<string, OriginEnum>()
            {
                {"kms", KMS},
                {"external", EXTERNAL},
            };

            private string Value;

            public OriginEnum(string Value)
            {
                this.Value = Value;
            }

            public static OriginEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
            {
                return this.Value;
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as OriginEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OriginEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(OriginEnum a, OriginEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(OriginEnum a, OriginEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 密钥ID。
        /// </summary>
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        /// <summary>
        /// 用户域ID。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 密钥别名。
        /// </summary>
        [JsonProperty("key_alias", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyAlias { get; set; }

        /// <summary>
        /// 密钥区域。
        /// </summary>
        [JsonProperty("realm", NullValueHandling = NullValueHandling.Ignore)]
        public string Realm { get; set; }

        /// <summary>
        /// 密钥描述。
        /// </summary>
        [JsonProperty("key_description", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyDescription { get; set; }

        /// <summary>
        /// 密钥创建时间，时间戳，即从1970年1月1日至该时间的总秒数。
        /// </summary>
        [JsonProperty("creation_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CreationDate { get; set; }

        /// <summary>
        /// 密钥计划删除时间，时间戳，即从1970年1月1日至该时间的总秒数。
        /// </summary>
        [JsonProperty("scheduled_deletion_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduledDeletionDate { get; set; }

        /// <summary>
        /// 密钥状态，满足正则匹配“^[1-5]{1}$”，枚举如下：  - “1”表示待激活状态  - “2”表示启用状态  - “3”表示禁用状态  - “4”表示计划删除状态  - “5”表示等待导入状态
        /// </summary>
        [JsonProperty("key_state", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyState { get; set; }

        /// <summary>
        /// 默认主密钥标识，默认主密钥标识为1，非默认标识为0。
        /// </summary>
        [JsonProperty("default_key_flag", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultKeyFlag { get; set; }

        /// <summary>
        /// 密钥类型。
        /// </summary>
        [JsonProperty("key_type", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyType { get; set; }

        /// <summary>
        /// 密钥材料失效时间，时间戳，即从1970年1月1日至该时间的总秒数。
        /// </summary>
        [JsonProperty("expiration_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpirationTime { get; set; }

        /// <summary>
        /// 密钥来源，默认为“kms”，枚举如下：  - kms表示密钥材料由kms生成kms表示密钥材料由kms生成  - external表示密钥材料由外部导入
        /// </summary>
        [JsonProperty("origin", NullValueHandling = NullValueHandling.Ignore)]
        public OriginEnum Origin { get; set; }
        /// <summary>
        /// 密钥轮换状态，默认为“false”，表示关闭密钥轮换功能。
        /// </summary>
        [JsonProperty("key_rotation_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyRotationEnabled { get; set; }

        /// <summary>
        /// 企业项目ID，默认为“0”。  - 对于开通企业项目的用户，表示资源处于默认企业项目下。  - 对于未开通企业项目的用户，表示资源未处于企业项目下。
        /// </summary>
        [JsonProperty("sys_enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SysEnterpriseProjectId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeyDetails {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  keyAlias: ").Append(KeyAlias).Append("\n");
            sb.Append("  realm: ").Append(Realm).Append("\n");
            sb.Append("  keyDescription: ").Append(KeyDescription).Append("\n");
            sb.Append("  creationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  scheduledDeletionDate: ").Append(ScheduledDeletionDate).Append("\n");
            sb.Append("  keyState: ").Append(KeyState).Append("\n");
            sb.Append("  defaultKeyFlag: ").Append(DefaultKeyFlag).Append("\n");
            sb.Append("  keyType: ").Append(KeyType).Append("\n");
            sb.Append("  expirationTime: ").Append(ExpirationTime).Append("\n");
            sb.Append("  origin: ").Append(Origin).Append("\n");
            sb.Append("  keyRotationEnabled: ").Append(KeyRotationEnabled).Append("\n");
            sb.Append("  sysEnterpriseProjectId: ").Append(SysEnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KeyDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KeyDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeyId == input.KeyId ||
                    (this.KeyId != null &&
                    this.KeyId.Equals(input.KeyId))
                ) && 
                (
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.KeyAlias == input.KeyAlias ||
                    (this.KeyAlias != null &&
                    this.KeyAlias.Equals(input.KeyAlias))
                ) && 
                (
                    this.Realm == input.Realm ||
                    (this.Realm != null &&
                    this.Realm.Equals(input.Realm))
                ) && 
                (
                    this.KeyDescription == input.KeyDescription ||
                    (this.KeyDescription != null &&
                    this.KeyDescription.Equals(input.KeyDescription))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.ScheduledDeletionDate == input.ScheduledDeletionDate ||
                    (this.ScheduledDeletionDate != null &&
                    this.ScheduledDeletionDate.Equals(input.ScheduledDeletionDate))
                ) && 
                (
                    this.KeyState == input.KeyState ||
                    (this.KeyState != null &&
                    this.KeyState.Equals(input.KeyState))
                ) && 
                (
                    this.DefaultKeyFlag == input.DefaultKeyFlag ||
                    (this.DefaultKeyFlag != null &&
                    this.DefaultKeyFlag.Equals(input.DefaultKeyFlag))
                ) && 
                (
                    this.KeyType == input.KeyType ||
                    (this.KeyType != null &&
                    this.KeyType.Equals(input.KeyType))
                ) && 
                (
                    this.ExpirationTime == input.ExpirationTime ||
                    (this.ExpirationTime != null &&
                    this.ExpirationTime.Equals(input.ExpirationTime))
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.KeyRotationEnabled == input.KeyRotationEnabled ||
                    (this.KeyRotationEnabled != null &&
                    this.KeyRotationEnabled.Equals(input.KeyRotationEnabled))
                ) && 
                (
                    this.SysEnterpriseProjectId == input.SysEnterpriseProjectId ||
                    (this.SysEnterpriseProjectId != null &&
                    this.SysEnterpriseProjectId.Equals(input.SysEnterpriseProjectId))
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
                if (this.KeyId != null)
                    hashCode = hashCode * 59 + this.KeyId.GetHashCode();
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.KeyAlias != null)
                    hashCode = hashCode * 59 + this.KeyAlias.GetHashCode();
                if (this.Realm != null)
                    hashCode = hashCode * 59 + this.Realm.GetHashCode();
                if (this.KeyDescription != null)
                    hashCode = hashCode * 59 + this.KeyDescription.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.ScheduledDeletionDate != null)
                    hashCode = hashCode * 59 + this.ScheduledDeletionDate.GetHashCode();
                if (this.KeyState != null)
                    hashCode = hashCode * 59 + this.KeyState.GetHashCode();
                if (this.DefaultKeyFlag != null)
                    hashCode = hashCode * 59 + this.DefaultKeyFlag.GetHashCode();
                if (this.KeyType != null)
                    hashCode = hashCode * 59 + this.KeyType.GetHashCode();
                if (this.ExpirationTime != null)
                    hashCode = hashCode * 59 + this.ExpirationTime.GetHashCode();
                if (this.Origin != null)
                    hashCode = hashCode * 59 + this.Origin.GetHashCode();
                if (this.KeyRotationEnabled != null)
                    hashCode = hashCode * 59 + this.KeyRotationEnabled.GetHashCode();
                if (this.SysEnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.SysEnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
