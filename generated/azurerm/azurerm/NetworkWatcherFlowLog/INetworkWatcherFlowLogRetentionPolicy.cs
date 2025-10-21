using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkWatcherFlowLog
{
    [JsiiInterface(nativeType: typeof(INetworkWatcherFlowLogRetentionPolicy), fullyQualifiedName: "azurerm.networkWatcherFlowLog.NetworkWatcherFlowLogRetentionPolicy")]
    public interface INetworkWatcherFlowLogRetentionPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_watcher_flow_log#days NetworkWatcherFlowLog#days}.</summary>
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}")]
        double Days
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_watcher_flow_log#enabled NetworkWatcherFlowLog#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkWatcherFlowLogRetentionPolicy), fullyQualifiedName: "azurerm.networkWatcherFlowLog.NetworkWatcherFlowLogRetentionPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetworkWatcherFlowLog.INetworkWatcherFlowLogRetentionPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_watcher_flow_log#days NetworkWatcherFlowLog#days}.</summary>
            [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}")]
            public double Days
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_watcher_flow_log#enabled NetworkWatcherFlowLog#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
