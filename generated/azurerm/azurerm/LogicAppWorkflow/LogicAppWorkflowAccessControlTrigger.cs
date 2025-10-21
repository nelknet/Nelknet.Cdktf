using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LogicAppWorkflow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlTrigger")]
    public class LogicAppWorkflowAccessControlTrigger : azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlTrigger
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#allowed_caller_ip_address_range LogicAppWorkflow#allowed_caller_ip_address_range}.</summary>
        [JsiiProperty(name: "allowedCallerIpAddressRange", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AllowedCallerIpAddressRange
        {
            get;
            set;
        }

        private object? _openAuthenticationPolicy;

        /// <summary>open_authentication_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#open_authentication_policy LogicAppWorkflow#open_authentication_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "openAuthenticationPolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlTriggerOpenAuthenticationPolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OpenAuthenticationPolicy
        {
            get => _openAuthenticationPolicy;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlTriggerOpenAuthenticationPolicy[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlTriggerOpenAuthenticationPolicy).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _openAuthenticationPolicy = value;
            }
        }
    }
}
