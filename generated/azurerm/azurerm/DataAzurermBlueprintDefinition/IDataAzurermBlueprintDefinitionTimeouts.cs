using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermBlueprintDefinition
{
    [JsiiInterface(nativeType: typeof(IDataAzurermBlueprintDefinitionTimeouts), fullyQualifiedName: "azurerm.dataAzurermBlueprintDefinition.DataAzurermBlueprintDefinitionTimeouts")]
    public interface IDataAzurermBlueprintDefinitionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/blueprint_definition#read DataAzurermBlueprintDefinition#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermBlueprintDefinitionTimeouts), fullyQualifiedName: "azurerm.dataAzurermBlueprintDefinition.DataAzurermBlueprintDefinitionTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermBlueprintDefinition.IDataAzurermBlueprintDefinitionTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/blueprint_definition#read DataAzurermBlueprintDefinition#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
