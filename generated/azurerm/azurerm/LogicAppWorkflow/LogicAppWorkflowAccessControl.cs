using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LogicAppWorkflow
{
    [JsiiByValue(fqn: "azurerm.logicAppWorkflow.LogicAppWorkflowAccessControl")]
    public class LogicAppWorkflowAccessControl : azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControl
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#action LogicAppWorkflow#action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlAction\"}", isOptional: true)]
        public azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlAction? Action
        {
            get;
            set;
        }

        /// <summary>content block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#content LogicAppWorkflow#content}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "content", typeJson: "{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlContent\"}", isOptional: true)]
        public azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlContent? Content
        {
            get;
            set;
        }

        /// <summary>trigger block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#trigger LogicAppWorkflow#trigger}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trigger", typeJson: "{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlTrigger\"}", isOptional: true)]
        public azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlTrigger? Trigger
        {
            get;
            set;
        }

        /// <summary>workflow_management block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#workflow_management LogicAppWorkflow#workflow_management}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workflowManagement", typeJson: "{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlWorkflowManagement\"}", isOptional: true)]
        public azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlWorkflowManagement? WorkflowManagement
        {
            get;
            set;
        }
    }
}
