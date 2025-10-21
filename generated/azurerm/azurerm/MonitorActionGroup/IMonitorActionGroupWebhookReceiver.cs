using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorActionGroup
{
    [JsiiInterface(nativeType: typeof(IMonitorActionGroupWebhookReceiver), fullyQualifiedName: "azurerm.monitorActionGroup.MonitorActionGroupWebhookReceiver")]
    public interface IMonitorActionGroupWebhookReceiver
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#name MonitorActionGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#service_uri MonitorActionGroup#service_uri}.</summary>
        [JsiiProperty(name: "serviceUri", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceUri
        {
            get;
        }

        /// <summary>aad_auth block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#aad_auth MonitorActionGroup#aad_auth}
        /// </remarks>
        [JsiiProperty(name: "aadAuth", typeJson: "{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupWebhookReceiverAadAuth\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MonitorActionGroup.IMonitorActionGroupWebhookReceiverAadAuth? AadAuth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#use_common_alert_schema MonitorActionGroup#use_common_alert_schema}.</summary>
        [JsiiProperty(name: "useCommonAlertSchema", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseCommonAlertSchema
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorActionGroupWebhookReceiver), fullyQualifiedName: "azurerm.monitorActionGroup.MonitorActionGroupWebhookReceiver")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorActionGroup.IMonitorActionGroupWebhookReceiver
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#name MonitorActionGroup#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#service_uri MonitorActionGroup#service_uri}.</summary>
            [JsiiProperty(name: "serviceUri", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceUri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>aad_auth block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#aad_auth MonitorActionGroup#aad_auth}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "aadAuth", typeJson: "{\"fqn\":\"azurerm.monitorActionGroup.MonitorActionGroupWebhookReceiverAadAuth\"}", isOptional: true)]
            public azurerm.MonitorActionGroup.IMonitorActionGroupWebhookReceiverAadAuth? AadAuth
            {
                get => GetInstanceProperty<azurerm.MonitorActionGroup.IMonitorActionGroupWebhookReceiverAadAuth?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#use_common_alert_schema MonitorActionGroup#use_common_alert_schema}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "useCommonAlertSchema", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UseCommonAlertSchema
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
