using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mskCluster.MskClusterLoggingInfo")]
    public class MskClusterLoggingInfo : aws.MskCluster.IMskClusterLoggingInfo
    {
        /// <summary>broker_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#broker_logs MskCluster#broker_logs}
        /// </remarks>
        [JsiiProperty(name: "brokerLogs", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfoBrokerLogs\"}")]
        public aws.MskCluster.IMskClusterLoggingInfoBrokerLogs BrokerLogs
        {
            get;
            set;
        }
    }
}
