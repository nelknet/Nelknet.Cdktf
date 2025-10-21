using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPolicyAssignment
{
    [JsiiByValue(fqn: "azurerm.dataAzurermPolicyAssignment.DataAzurermPolicyAssignmentTimeouts")]
    public class DataAzurermPolicyAssignmentTimeouts : azurerm.DataAzurermPolicyAssignment.IDataAzurermPolicyAssignmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_assignment#read DataAzurermPolicyAssignment#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
