using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageManagementPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.storageManagementPolicy.StorageManagementPolicyRule")]
    public class StorageManagementPolicyRule : azurerm.StorageManagementPolicy.IStorageManagementPolicyRule
    {
        /// <summary>actions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#actions StorageManagementPolicy#actions}
        /// </remarks>
        [JsiiProperty(name: "actions", typeJson: "{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleActions\"}")]
        public azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleActions Actions
        {
            get;
            set;
        }

        private object _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#enabled StorageManagementPolicy#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object Enabled
        {
            get => _enabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        /// <summary>filters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#filters StorageManagementPolicy#filters}
        /// </remarks>
        [JsiiProperty(name: "filters", typeJson: "{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleFilters\"}")]
        public azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleFilters Filters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#name StorageManagementPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
