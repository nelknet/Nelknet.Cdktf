using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageShare
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.storageShare.StorageShareAcl")]
    public class StorageShareAcl : azurerm.StorageShare.IStorageShareAcl
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share#id StorageShare#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public string Id
        {
            get;
            set;
        }

        private object? _accessPolicy;

        /// <summary>access_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_share#access_policy StorageShare#access_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessPolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.storageShare.StorageShareAclAccessPolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AccessPolicy
        {
            get => _accessPolicy;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.StorageShare.IStorageShareAclAccessPolicy[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.StorageShare.IStorageShareAclAccessPolicy).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _accessPolicy = value;
            }
        }
    }
}
