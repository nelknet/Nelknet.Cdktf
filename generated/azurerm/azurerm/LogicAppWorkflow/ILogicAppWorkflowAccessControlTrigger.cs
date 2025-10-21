using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LogicAppWorkflow
{
    [JsiiInterface(nativeType: typeof(ILogicAppWorkflowAccessControlTrigger), fullyQualifiedName: "azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlTrigger")]
    public interface ILogicAppWorkflowAccessControlTrigger
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#allowed_caller_ip_address_range LogicAppWorkflow#allowed_caller_ip_address_range}.</summary>
        [JsiiProperty(name: "allowedCallerIpAddressRange", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AllowedCallerIpAddressRange
        {
            get;
        }

        /// <summary>open_authentication_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#open_authentication_policy LogicAppWorkflow#open_authentication_policy}
        /// </remarks>
        [JsiiProperty(name: "openAuthenticationPolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlTriggerOpenAuthenticationPolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OpenAuthenticationPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILogicAppWorkflowAccessControlTrigger), fullyQualifiedName: "azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlTrigger")]
        internal sealed class _Proxy : DeputyBase, azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlTrigger
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#allowed_caller_ip_address_range LogicAppWorkflow#allowed_caller_ip_address_range}.</summary>
            [JsiiProperty(name: "allowedCallerIpAddressRange", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AllowedCallerIpAddressRange
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>open_authentication_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#open_authentication_policy LogicAppWorkflow#open_authentication_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "openAuthenticationPolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlTriggerOpenAuthenticationPolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OpenAuthenticationPolicy
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
