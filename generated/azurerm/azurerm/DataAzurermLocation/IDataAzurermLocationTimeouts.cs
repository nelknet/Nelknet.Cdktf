using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermLocation
{
    [JsiiInterface(nativeType: typeof(IDataAzurermLocationTimeouts), fullyQualifiedName: "azurerm.dataAzurermLocation.DataAzurermLocationTimeouts")]
    public interface IDataAzurermLocationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/location#read DataAzurermLocation#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermLocationTimeouts), fullyQualifiedName: "azurerm.dataAzurermLocation.DataAzurermLocationTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermLocation.IDataAzurermLocationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/location#read DataAzurermLocation#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
