using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPolicyDefinitionBuiltIn
{
    [JsiiInterface(nativeType: typeof(IDataAzurermPolicyDefinitionBuiltInTimeouts), fullyQualifiedName: "azurerm.dataAzurermPolicyDefinitionBuiltIn.DataAzurermPolicyDefinitionBuiltInTimeouts")]
    public interface IDataAzurermPolicyDefinitionBuiltInTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_definition_built_in#read DataAzurermPolicyDefinitionBuiltIn#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermPolicyDefinitionBuiltInTimeouts), fullyQualifiedName: "azurerm.dataAzurermPolicyDefinitionBuiltIn.DataAzurermPolicyDefinitionBuiltInTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermPolicyDefinitionBuiltIn.IDataAzurermPolicyDefinitionBuiltInTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_definition_built_in#read DataAzurermPolicyDefinitionBuiltIn#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
