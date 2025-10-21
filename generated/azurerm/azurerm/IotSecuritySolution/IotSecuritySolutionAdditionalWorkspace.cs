using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.IotSecuritySolution
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.iotSecuritySolution.IotSecuritySolutionAdditionalWorkspace")]
    public class IotSecuritySolutionAdditionalWorkspace : azurerm.IotSecuritySolution.IIotSecuritySolutionAdditionalWorkspace
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_solution#data_types IotSecuritySolution#data_types}.</summary>
        [JsiiProperty(name: "dataTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] DataTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_solution#workspace_id IotSecuritySolution#workspace_id}.</summary>
        [JsiiProperty(name: "workspaceId", typeJson: "{\"primitive\":\"string\"}")]
        public string WorkspaceId
        {
            get;
            set;
        }
    }
}
