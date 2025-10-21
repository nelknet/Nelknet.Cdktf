using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPolicyAssignment
{
    [JsiiInterface(nativeType: typeof(IDataAzurermPolicyAssignmentTimeouts), fullyQualifiedName: "azurerm.dataAzurermPolicyAssignment.DataAzurermPolicyAssignmentTimeouts")]
    public interface IDataAzurermPolicyAssignmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_assignment#read DataAzurermPolicyAssignment#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermPolicyAssignmentTimeouts), fullyQualifiedName: "azurerm.dataAzurermPolicyAssignment.DataAzurermPolicyAssignmentTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermPolicyAssignment.IDataAzurermPolicyAssignmentTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_assignment#read DataAzurermPolicyAssignment#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
