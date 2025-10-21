using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DatadogMonitor
{
    [JsiiInterface(nativeType: typeof(IDatadogMonitorIdentity), fullyQualifiedName: "azurerm.datadogMonitor.DatadogMonitorIdentity")]
    public interface IDatadogMonitorIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor#type DatadogMonitor#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatadogMonitorIdentity), fullyQualifiedName: "azurerm.datadogMonitor.DatadogMonitorIdentity")]
        internal sealed class _Proxy : DeputyBase, azurerm.DatadogMonitor.IDatadogMonitorIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor#type DatadogMonitor#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
