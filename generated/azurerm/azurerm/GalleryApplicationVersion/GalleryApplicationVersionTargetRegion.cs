using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.GalleryApplicationVersion
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.galleryApplicationVersion.GalleryApplicationVersionTargetRegion")]
    public class GalleryApplicationVersionTargetRegion : azurerm.GalleryApplicationVersion.IGalleryApplicationVersionTargetRegion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#name GalleryApplicationVersion#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#regional_replica_count GalleryApplicationVersion#regional_replica_count}.</summary>
        [JsiiProperty(name: "regionalReplicaCount", typeJson: "{\"primitive\":\"number\"}")]
        public double RegionalReplicaCount
        {
            get;
            set;
        }

        private object? _excludeFromLatest;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#exclude_from_latest GalleryApplicationVersion#exclude_from_latest}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludeFromLatest", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ExcludeFromLatest
        {
            get => _excludeFromLatest;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _excludeFromLatest = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#storage_account_type GalleryApplicationVersion#storage_account_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageAccountType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageAccountType
        {
            get;
            set;
        }
    }
}
