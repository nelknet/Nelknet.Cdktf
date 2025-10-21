using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermManagedApi
{
    [JsiiInterface(nativeType: typeof(IDataAzurermManagedApiTimeouts), fullyQualifiedName: "azurerm.dataAzurermManagedApi.DataAzurermManagedApiTimeouts")]
    public interface IDataAzurermManagedApiTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/managed_api#read DataAzurermManagedApi#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermManagedApiTimeouts), fullyQualifiedName: "azurerm.dataAzurermManagedApi.DataAzurermManagedApiTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermManagedApi.IDataAzurermManagedApiTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/managed_api#read DataAzurermManagedApi#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
