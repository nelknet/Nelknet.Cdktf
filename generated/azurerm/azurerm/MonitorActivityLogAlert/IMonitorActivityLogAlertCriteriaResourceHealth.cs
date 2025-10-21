using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorActivityLogAlert
{
    [JsiiInterface(nativeType: typeof(IMonitorActivityLogAlertCriteriaResourceHealth), fullyQualifiedName: "azurerm.monitorActivityLogAlert.MonitorActivityLogAlertCriteriaResourceHealth")]
    public interface IMonitorActivityLogAlertCriteriaResourceHealth
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#current MonitorActivityLogAlert#current}.</summary>
        [JsiiProperty(name: "current", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Current
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#previous MonitorActivityLogAlert#previous}.</summary>
        [JsiiProperty(name: "previous", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Previous
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#reason MonitorActivityLogAlert#reason}.</summary>
        [JsiiProperty(name: "reason", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Reason
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorActivityLogAlertCriteriaResourceHealth), fullyQualifiedName: "azurerm.monitorActivityLogAlert.MonitorActivityLogAlertCriteriaResourceHealth")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorActivityLogAlert.IMonitorActivityLogAlertCriteriaResourceHealth
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#current MonitorActivityLogAlert#current}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "current", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Current
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#previous MonitorActivityLogAlert#previous}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "previous", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Previous
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#reason MonitorActivityLogAlert#reason}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "reason", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Reason
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
