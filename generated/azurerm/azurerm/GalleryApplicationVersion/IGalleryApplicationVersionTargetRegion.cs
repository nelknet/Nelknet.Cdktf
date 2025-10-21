using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.GalleryApplicationVersion
{
    [JsiiInterface(nativeType: typeof(IGalleryApplicationVersionTargetRegion), fullyQualifiedName: "azurerm.galleryApplicationVersion.GalleryApplicationVersionTargetRegion")]
    public interface IGalleryApplicationVersionTargetRegion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#name GalleryApplicationVersion#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#regional_replica_count GalleryApplicationVersion#regional_replica_count}.</summary>
        [JsiiProperty(name: "regionalReplicaCount", typeJson: "{\"primitive\":\"number\"}")]
        double RegionalReplicaCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#exclude_from_latest GalleryApplicationVersion#exclude_from_latest}.</summary>
        [JsiiProperty(name: "excludeFromLatest", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExcludeFromLatest
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#storage_account_type GalleryApplicationVersion#storage_account_type}.</summary>
        [JsiiProperty(name: "storageAccountType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageAccountType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGalleryApplicationVersionTargetRegion), fullyQualifiedName: "azurerm.galleryApplicationVersion.GalleryApplicationVersionTargetRegion")]
        internal sealed class _Proxy : DeputyBase, azurerm.GalleryApplicationVersion.IGalleryApplicationVersionTargetRegion
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#name GalleryApplicationVersion#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#regional_replica_count GalleryApplicationVersion#regional_replica_count}.</summary>
            [JsiiProperty(name: "regionalReplicaCount", typeJson: "{\"primitive\":\"number\"}")]
            public double RegionalReplicaCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#exclude_from_latest GalleryApplicationVersion#exclude_from_latest}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludeFromLatest", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ExcludeFromLatest
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#storage_account_type GalleryApplicationVersion#storage_account_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccountType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageAccountType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
