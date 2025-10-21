using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiInterface(nativeType: typeof(IMskClusterOpenMonitoring), fullyQualifiedName: "aws.mskCluster.MskClusterOpenMonitoring")]
    public interface IMskClusterOpenMonitoring
    {
        /// <summary>prometheus block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#prometheus MskCluster#prometheus}
        /// </remarks>
        [JsiiProperty(name: "prometheus", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterOpenMonitoringPrometheus\"}")]
        aws.MskCluster.IMskClusterOpenMonitoringPrometheus Prometheus
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterOpenMonitoring), fullyQualifiedName: "aws.mskCluster.MskClusterOpenMonitoring")]
        internal sealed class _Proxy : DeputyBase, aws.MskCluster.IMskClusterOpenMonitoring
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>prometheus block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#prometheus MskCluster#prometheus}
            /// </remarks>
            [JsiiProperty(name: "prometheus", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterOpenMonitoringPrometheus\"}")]
            public aws.MskCluster.IMskClusterOpenMonitoringPrometheus Prometheus
            {
                get => GetInstanceProperty<aws.MskCluster.IMskClusterOpenMonitoringPrometheus>()!;
            }
        }
    }
}
