using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 重装操作系统body体。
    /// </summary>
    public class ChangeServerOsWithCloudInitOption 
    {

        /// <summary>
        /// 云服务器管理员帐户的初始登录密码。  其中，Windows管理员帐户的用户名为Administrator。  建议密码复杂度如下：  - 长度为8-26位。 - 密码至少必须包含大写字母、小写字母、数字和特殊字符（!@$%^-_&#x3D;+[{}]:,./?）中的三种。  &gt; 说明： &gt;  - Windows云服务器的密码，不能包含用户名或用户名的逆序，不能包含用户名中超过两个连续字符的部分。 - 对于Linux弹性云服务器也可使用user_data字段实现密码注入，此时adminpass字段无效。 - adminpass和keyname不能同时有值。 - adminpass和keyname如果同时为空，此时，metadata中的user_data属性必须有值。 - 对于已安装Cloud-init的云服务器，使用adminpass字段切换操作系统时，系统如果提示您使用keypair方式切换操作系统，表示当前区域暂不支持使用密码方式。
        /// </summary>
        [JsonProperty("adminpass", NullValueHandling = NullValueHandling.Ignore)]
        public string Adminpass { get; set; }

        /// <summary>
        /// 密钥名称。
        /// </summary>
        [JsonProperty("keyname", NullValueHandling = NullValueHandling.Ignore)]
        public string Keyname { get; set; }

        /// <summary>
        /// 用户ID。 说明 如果使用秘钥方式切换操作系统，则该字段为必选字段。
        /// </summary>
        [JsonProperty("userid", NullValueHandling = NullValueHandling.Ignore)]
        public string Userid { get; set; }

        /// <summary>
        /// 切换系统所使用的新镜像的ID，格式为UUID。
        /// </summary>
        [JsonProperty("imageid", NullValueHandling = NullValueHandling.Ignore)]
        public string Imageid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public ChangeSeversOsMetadata Metadata { get; set; }

        /// <summary>
        /// 取值为withStopServer ，支持开机状态下切换弹性云服务器操作系统。 mode取值为withStopServer时，对开机状态的弹性云服务器执行切换操作系统操作，系统自动对云服务器先执行关机，再切换操作系统。
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeServerOsWithCloudInitOption {\n");
            sb.Append("  adminpass: ").Append(Adminpass).Append("\n");
            sb.Append("  keyname: ").Append(Keyname).Append("\n");
            sb.Append("  userid: ").Append(Userid).Append("\n");
            sb.Append("  imageid: ").Append(Imageid).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangeServerOsWithCloudInitOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangeServerOsWithCloudInitOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Adminpass == input.Adminpass ||
                    (this.Adminpass != null &&
                    this.Adminpass.Equals(input.Adminpass))
                ) && 
                (
                    this.Keyname == input.Keyname ||
                    (this.Keyname != null &&
                    this.Keyname.Equals(input.Keyname))
                ) && 
                (
                    this.Userid == input.Userid ||
                    (this.Userid != null &&
                    this.Userid.Equals(input.Userid))
                ) && 
                (
                    this.Imageid == input.Imageid ||
                    (this.Imageid != null &&
                    this.Imageid.Equals(input.Imageid))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
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
                if (this.Adminpass != null)
                    hashCode = hashCode * 59 + this.Adminpass.GetHashCode();
                if (this.Keyname != null)
                    hashCode = hashCode * 59 + this.Keyname.GetHashCode();
                if (this.Userid != null)
                    hashCode = hashCode * 59 + this.Userid.GetHashCode();
                if (this.Imageid != null)
                    hashCode = hashCode * 59 + this.Imageid.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                return hashCode;
            }
        }
    }
}
