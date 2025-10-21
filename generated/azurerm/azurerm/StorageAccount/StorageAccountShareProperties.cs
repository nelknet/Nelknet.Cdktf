using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    [JsiiByValue(fqn: "azurerm.storageAccount.StorageAccountShareProperties")]
    public class StorageAccountShareProperties : azurerm.StorageAccount.IStorageAccountShareProperties
    {
        private object? _corsRule;

        /// <summary>cors_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#cors_rule StorageAccount#cors_rule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "corsRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.storageAccount.StorageAccountSharePropertiesCorsRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CorsRule
        {
            get => _corsRule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.StorageAccount.IStorageAccountSharePropertiesCorsRule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.StorageAccount.IStorageAccountSharePropertiesCorsRule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _corsRule = value;
            }
        }

        /// <summary>retention_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#retention_policy StorageAccount#retention_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retentionPolicy", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountSharePropertiesRetentionPolicy\"}", isOptional: true)]
        public azurerm.StorageAccount.IStorageAccountSharePropertiesRetentionPolicy? RetentionPolicy
        {
            get;
            set;
        }

        /// <summary>smb block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#smb StorageAccount#smb}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "smb", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountSharePropertiesSmb\"}", isOptional: true)]
        public azurerm.StorageAccount.IStorageAccountSharePropertiesSmb? Smb
        {
            get;
            set;
        }
    }
}
