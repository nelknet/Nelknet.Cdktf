using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LogicAppWorkflow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlAction")]
    public class LogicAppWorkflowAccessControlAction : azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#allowed_caller_ip_address_range LogicAppWorkflow#allowed_caller_ip_address_range}.</summary>
        [JsiiProperty(name: "allowedCallerIpAddressRange", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AllowedCallerIpAddressRange
        {
            get;
            set;
        }
    }
}
