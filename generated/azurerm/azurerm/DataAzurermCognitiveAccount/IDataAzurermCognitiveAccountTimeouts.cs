using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermCognitiveAccount
{
    [JsiiInterface(nativeType: typeof(IDataAzurermCognitiveAccountTimeouts), fullyQualifiedName: "azurerm.dataAzurermCognitiveAccount.DataAzurermCognitiveAccountTimeouts")]
    public interface IDataAzurermCognitiveAccountTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cognitive_account#read DataAzurermCognitiveAccount#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermCognitiveAccountTimeouts), fullyQualifiedName: "azurerm.dataAzurermCognitiveAccount.DataAzurermCognitiveAccountTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermCognitiveAccount.IDataAzurermCognitiveAccountTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cognitive_account#read DataAzurermCognitiveAccount#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
