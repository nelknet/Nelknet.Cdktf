using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDataShare
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDataShareTimeouts), fullyQualifiedName: "azurerm.dataAzurermDataShare.DataAzurermDataShareTimeouts")]
    public interface IDataAzurermDataShareTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share#read DataAzurermDataShare#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDataShareTimeouts), fullyQualifiedName: "azurerm.dataAzurermDataShare.DataAzurermDataShareTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDataShare.IDataAzurermDataShareTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share#read DataAzurermDataShare#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
