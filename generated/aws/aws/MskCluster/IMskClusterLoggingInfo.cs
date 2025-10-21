using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiInterface(nativeType: typeof(IMskClusterLoggingInfo), fullyQualifiedName: "aws.mskCluster.MskClusterLoggingInfo")]
    public interface IMskClusterLoggingInfo
    {
        /// <summary>broker_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#broker_logs MskCluster#broker_logs}
        /// </remarks>
        [JsiiProperty(name: "brokerLogs", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfoBrokerLogs\"}")]
        aws.MskCluster.IMskClusterLoggingInfoBrokerLogs BrokerLogs
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterLoggingInfo), fullyQualifiedName: "aws.mskCluster.MskClusterLoggingInfo")]
        internal sealed class _Proxy : DeputyBase, aws.MskCluster.IMskClusterLoggingInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>broker_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#broker_logs MskCluster#broker_logs}
            /// </remarks>
            [JsiiProperty(name: "brokerLogs", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfoBrokerLogs\"}")]
            public aws.MskCluster.IMskClusterLoggingInfoBrokerLogs BrokerLogs
            {
                get => GetInstanceProperty<aws.MskCluster.IMskClusterLoggingInfoBrokerLogs>()!;
            }
        }
    }
}
