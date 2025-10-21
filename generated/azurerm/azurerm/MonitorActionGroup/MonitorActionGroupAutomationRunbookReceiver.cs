using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorActionGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.monitorActionGroup.MonitorActionGroupAutomationRunbookReceiver")]
    public class MonitorActionGroupAutomationRunbookReceiver : azurerm.MonitorActionGroup.IMonitorActionGroupAutomationRunbookReceiver
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#automation_account_id MonitorActionGroup#automation_account_id}.</summary>
        [JsiiProperty(name: "automationAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public string AutomationAccountId
        {
            get;
            set;
        }

        private object _isGlobalRunbook;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#is_global_runbook MonitorActionGroup#is_global_runbook}.</summary>
        [JsiiProperty(name: "isGlobalRunbook", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object IsGlobalRunbook
        {
            get => _isGlobalRunbook;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isGlobalRunbook = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#name MonitorActionGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#runbook_name MonitorActionGroup#runbook_name}.</summary>
        [JsiiProperty(name: "runbookName", typeJson: "{\"primitive\":\"string\"}")]
        public string RunbookName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#service_uri MonitorActionGroup#service_uri}.</summary>
        [JsiiProperty(name: "serviceUri", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceUri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#webhook_resource_id MonitorActionGroup#webhook_resource_id}.</summary>
        [JsiiProperty(name: "webhookResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public string WebhookResourceId
        {
            get;
            set;
        }

        private object? _useCommonAlertSchema;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#use_common_alert_schema MonitorActionGroup#use_common_alert_schema}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "useCommonAlertSchema", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? UseCommonAlertSchema
        {
            get => _useCommonAlertSchema;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _useCommonAlertSchema = value;
            }
        }
    }
}
