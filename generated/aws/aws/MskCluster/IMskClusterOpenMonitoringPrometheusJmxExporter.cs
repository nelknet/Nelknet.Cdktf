using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiInterface(nativeType: typeof(IMskClusterOpenMonitoringPrometheusJmxExporter), fullyQualifiedName: "aws.mskCluster.MskClusterOpenMonitoringPrometheusJmxExporter")]
    public interface IMskClusterOpenMonitoringPrometheusJmxExporter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#enabled_in_broker MskCluster#enabled_in_broker}.</summary>
        [JsiiProperty(name: "enabledInBroker", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object EnabledInBroker
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterOpenMonitoringPrometheusJmxExporter), fullyQualifiedName: "aws.mskCluster.MskClusterOpenMonitoringPrometheusJmxExporter")]
        internal sealed class _Proxy : DeputyBase, aws.MskCluster.IMskClusterOpenMonitoringPrometheusJmxExporter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#enabled_in_broker MskCluster#enabled_in_broker}.</summary>
            [JsiiProperty(name: "enabledInBroker", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object EnabledInBroker
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
