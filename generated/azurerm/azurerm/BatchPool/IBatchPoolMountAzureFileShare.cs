using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiInterface(nativeType: typeof(IBatchPoolMountAzureFileShare), fullyQualifiedName: "azurerm.batchPool.BatchPoolMountAzureFileShare")]
    public interface IBatchPoolMountAzureFileShare
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#account_key BatchPool#account_key}.</summary>
        [JsiiProperty(name: "accountKey", typeJson: "{\"primitive\":\"string\"}")]
        string AccountKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#account_name BatchPool#account_name}.</summary>
        [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}")]
        string AccountName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#azure_file_url BatchPool#azure_file_url}.</summary>
        [JsiiProperty(name: "azureFileUrl", typeJson: "{\"primitive\":\"string\"}")]
        string AzureFileUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#relative_mount_path BatchPool#relative_mount_path}.</summary>
        [JsiiProperty(name: "relativeMountPath", typeJson: "{\"primitive\":\"string\"}")]
        string RelativeMountPath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#mount_options BatchPool#mount_options}.</summary>
        [JsiiProperty(name: "mountOptions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MountOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchPoolMountAzureFileShare), fullyQualifiedName: "azurerm.batchPool.BatchPoolMountAzureFileShare")]
        internal sealed class _Proxy : DeputyBase, azurerm.BatchPool.IBatchPoolMountAzureFileShare
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#account_key BatchPool#account_key}.</summary>
            [JsiiProperty(name: "accountKey", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#account_name BatchPool#account_name}.</summary>
            [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#azure_file_url BatchPool#azure_file_url}.</summary>
            [JsiiProperty(name: "azureFileUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string AzureFileUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#relative_mount_path BatchPool#relative_mount_path}.</summary>
            [JsiiProperty(name: "relativeMountPath", typeJson: "{\"primitive\":\"string\"}")]
            public string RelativeMountPath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#mount_options BatchPool#mount_options}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mountOptions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MountOptions
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
