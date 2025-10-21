using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermSourceControlToken
{
    [JsiiInterface(nativeType: typeof(IDataAzurermSourceControlTokenTimeouts), fullyQualifiedName: "azurerm.dataAzurermSourceControlToken.DataAzurermSourceControlTokenTimeouts")]
    public interface IDataAzurermSourceControlTokenTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/source_control_token#read DataAzurermSourceControlToken#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermSourceControlTokenTimeouts), fullyQualifiedName: "azurerm.dataAzurermSourceControlToken.DataAzurermSourceControlTokenTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermSourceControlToken.IDataAzurermSourceControlTokenTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/source_control_token#read DataAzurermSourceControlToken#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
