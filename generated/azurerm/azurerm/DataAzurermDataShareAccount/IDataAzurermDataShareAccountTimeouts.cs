using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDataShareAccount
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDataShareAccountTimeouts), fullyQualifiedName: "azurerm.dataAzurermDataShareAccount.DataAzurermDataShareAccountTimeouts")]
    public interface IDataAzurermDataShareAccountTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_account#read DataAzurermDataShareAccount#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDataShareAccountTimeouts), fullyQualifiedName: "azurerm.dataAzurermDataShareAccount.DataAzurermDataShareAccountTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDataShareAccount.IDataAzurermDataShareAccountTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_account#read DataAzurermDataShareAccount#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
