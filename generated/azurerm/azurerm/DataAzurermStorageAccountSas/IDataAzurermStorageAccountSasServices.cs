using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStorageAccountSas
{
    [JsiiInterface(nativeType: typeof(IDataAzurermStorageAccountSasServices), fullyQualifiedName: "azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSasServices")]
    public interface IDataAzurermStorageAccountSasServices
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas#blob DataAzurermStorageAccountSas#blob}.</summary>
        [JsiiProperty(name: "blob", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Blob
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas#file DataAzurermStorageAccountSas#file}.</summary>
        [JsiiProperty(name: "file", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object File
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas#queue DataAzurermStorageAccountSas#queue}.</summary>
        [JsiiProperty(name: "queue", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Queue
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas#table DataAzurermStorageAccountSas#table}.</summary>
        [JsiiProperty(name: "table", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Table
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermStorageAccountSasServices), fullyQualifiedName: "azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSasServices")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasServices
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas#blob DataAzurermStorageAccountSas#blob}.</summary>
            [JsiiProperty(name: "blob", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Blob
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas#file DataAzurermStorageAccountSas#file}.</summary>
            [JsiiProperty(name: "file", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object File
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas#queue DataAzurermStorageAccountSas#queue}.</summary>
            [JsiiProperty(name: "queue", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Queue
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas#table DataAzurermStorageAccountSas#table}.</summary>
            [JsiiProperty(name: "table", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Table
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
