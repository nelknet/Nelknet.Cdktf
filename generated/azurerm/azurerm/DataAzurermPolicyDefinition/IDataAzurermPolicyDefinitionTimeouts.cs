using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPolicyDefinition
{
    [JsiiInterface(nativeType: typeof(IDataAzurermPolicyDefinitionTimeouts), fullyQualifiedName: "azurerm.dataAzurermPolicyDefinition.DataAzurermPolicyDefinitionTimeouts")]
    public interface IDataAzurermPolicyDefinitionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_definition#read DataAzurermPolicyDefinition#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermPolicyDefinitionTimeouts), fullyQualifiedName: "azurerm.dataAzurermPolicyDefinition.DataAzurermPolicyDefinitionTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermPolicyDefinition.IDataAzurermPolicyDefinitionTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_definition#read DataAzurermPolicyDefinition#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
