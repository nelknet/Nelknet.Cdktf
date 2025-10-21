using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LogicAppWorkflow
{
    [JsiiInterface(nativeType: typeof(ILogicAppWorkflowAccessControl), fullyQualifiedName: "azurerm.logicAppWorkflow.LogicAppWorkflowAccessControl")]
    public interface ILogicAppWorkflowAccessControl
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#action LogicAppWorkflow#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlAction? Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>content block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#content LogicAppWorkflow#content}
        /// </remarks>
        [JsiiProperty(name: "content", typeJson: "{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlContent\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlContent? Content
        {
            get
            {
                return null;
            }
        }

        /// <summary>trigger block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#trigger LogicAppWorkflow#trigger}
        /// </remarks>
        [JsiiProperty(name: "trigger", typeJson: "{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlTrigger\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlTrigger? Trigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>workflow_management block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#workflow_management LogicAppWorkflow#workflow_management}
        /// </remarks>
        [JsiiProperty(name: "workflowManagement", typeJson: "{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlWorkflowManagement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlWorkflowManagement? WorkflowManagement
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILogicAppWorkflowAccessControl), fullyQualifiedName: "azurerm.logicAppWorkflow.LogicAppWorkflowAccessControl")]
        internal sealed class _Proxy : DeputyBase, azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControl
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#action LogicAppWorkflow#action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlAction\"}", isOptional: true)]
            public azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlAction? Action
            {
                get => GetInstanceProperty<azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlAction?>();
            }

            /// <summary>content block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#content LogicAppWorkflow#content}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "content", typeJson: "{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlContent\"}", isOptional: true)]
            public azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlContent? Content
            {
                get => GetInstanceProperty<azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlContent?>();
            }

            /// <summary>trigger block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#trigger LogicAppWorkflow#trigger}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trigger", typeJson: "{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlTrigger\"}", isOptional: true)]
            public azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlTrigger? Trigger
            {
                get => GetInstanceProperty<azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlTrigger?>();
            }

            /// <summary>workflow_management block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#workflow_management LogicAppWorkflow#workflow_management}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workflowManagement", typeJson: "{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlWorkflowManagement\"}", isOptional: true)]
            public azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlWorkflowManagement? WorkflowManagement
            {
                get => GetInstanceProperty<azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlWorkflowManagement?>();
            }
        }
    }
}
