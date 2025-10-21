using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiInterface(nativeType: typeof(IBatchPoolDataDisks), fullyQualifiedName: "azurerm.batchPool.BatchPoolDataDisks")]
    public interface IBatchPoolDataDisks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#disk_size_gb BatchPool#disk_size_gb}.</summary>
        [JsiiProperty(name: "diskSizeGb", typeJson: "{\"primitive\":\"number\"}")]
        double DiskSizeGb
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#lun BatchPool#lun}.</summary>
        [JsiiProperty(name: "lun", typeJson: "{\"primitive\":\"number\"}")]
        double Lun
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#caching BatchPool#caching}.</summary>
        [JsiiProperty(name: "caching", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Caching
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#storage_account_type BatchPool#storage_account_type}.</summary>
        [JsiiProperty(name: "storageAccountType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageAccountType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchPoolDataDisks), fullyQualifiedName: "azurerm.batchPool.BatchPoolDataDisks")]
        internal sealed class _Proxy : DeputyBase, azurerm.BatchPool.IBatchPoolDataDisks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#disk_size_gb BatchPool#disk_size_gb}.</summary>
            [JsiiProperty(name: "diskSizeGb", typeJson: "{\"primitive\":\"number\"}")]
            public double DiskSizeGb
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#lun BatchPool#lun}.</summary>
            [JsiiProperty(name: "lun", typeJson: "{\"primitive\":\"number\"}")]
            public double Lun
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#caching BatchPool#caching}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "caching", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Caching
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#storage_account_type BatchPool#storage_account_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccountType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageAccountType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
