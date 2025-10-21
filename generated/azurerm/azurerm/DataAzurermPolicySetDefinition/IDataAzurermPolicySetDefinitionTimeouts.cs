using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPolicySetDefinition
{
    [JsiiInterface(nativeType: typeof(IDataAzurermPolicySetDefinitionTimeouts), fullyQualifiedName: "azurerm.dataAzurermPolicySetDefinition.DataAzurermPolicySetDefinitionTimeouts")]
    public interface IDataAzurermPolicySetDefinitionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_set_definition#read DataAzurermPolicySetDefinition#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermPolicySetDefinitionTimeouts), fullyQualifiedName: "azurerm.dataAzurermPolicySetDefinition.DataAzurermPolicySetDefinitionTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermPolicySetDefinition.IDataAzurermPolicySetDefinitionTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_set_definition#read DataAzurermPolicySetDefinition#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
