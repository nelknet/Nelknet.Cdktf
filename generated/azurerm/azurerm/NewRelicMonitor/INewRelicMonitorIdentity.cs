using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NewRelicMonitor
{
    [JsiiInterface(nativeType: typeof(INewRelicMonitorIdentity), fullyQualifiedName: "azurerm.newRelicMonitor.NewRelicMonitorIdentity")]
    public interface INewRelicMonitorIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#type NewRelicMonitor#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INewRelicMonitorIdentity), fullyQualifiedName: "azurerm.newRelicMonitor.NewRelicMonitorIdentity")]
        internal sealed class _Proxy : DeputyBase, azurerm.NewRelicMonitor.INewRelicMonitorIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#type NewRelicMonitor#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
