using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMapsAccount
{
    [JsiiInterface(nativeType: typeof(IDataAzurermMapsAccountTimeouts), fullyQualifiedName: "azurerm.dataAzurermMapsAccount.DataAzurermMapsAccountTimeouts")]
    public interface IDataAzurermMapsAccountTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/maps_account#read DataAzurermMapsAccount#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermMapsAccountTimeouts), fullyQualifiedName: "azurerm.dataAzurermMapsAccount.DataAzurermMapsAccountTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermMapsAccount.IDataAzurermMapsAccountTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/maps_account#read DataAzurermMapsAccount#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
