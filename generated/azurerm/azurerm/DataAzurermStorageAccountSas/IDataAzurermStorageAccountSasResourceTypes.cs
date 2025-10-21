using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStorageAccountSas
{
    [JsiiInterface(nativeType: typeof(IDataAzurermStorageAccountSasResourceTypes), fullyQualifiedName: "azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSasResourceTypes")]
    public interface IDataAzurermStorageAccountSasResourceTypes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas#container DataAzurermStorageAccountSas#container}.</summary>
        [JsiiProperty(name: "container", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Container
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas#object DataAzurermStorageAccountSas#object}.</summary>
        [JsiiProperty(name: "object", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Object
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas#service DataAzurermStorageAccountSas#service}.</summary>
        [JsiiProperty(name: "service", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Service
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermStorageAccountSasResourceTypes), fullyQualifiedName: "azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSasResourceTypes")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasResourceTypes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas#container DataAzurermStorageAccountSas#container}.</summary>
            [JsiiProperty(name: "container", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Container
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas#object DataAzurermStorageAccountSas#object}.</summary>
            [JsiiProperty(name: "object", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Object
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas#service DataAzurermStorageAccountSas#service}.</summary>
            [JsiiProperty(name: "service", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Service
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
