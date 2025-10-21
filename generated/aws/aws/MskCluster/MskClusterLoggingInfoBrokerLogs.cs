using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiByValue(fqn: "aws.mskCluster.MskClusterLoggingInfoBrokerLogs")]
    public class MskClusterLoggingInfoBrokerLogs : aws.MskCluster.IMskClusterLoggingInfoBrokerLogs
    {
        /// <summary>cloudwatch_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#cloudwatch_logs MskCluster#cloudwatch_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfoBrokerLogsCloudwatchLogs\"}", isOptional: true)]
        public aws.MskCluster.IMskClusterLoggingInfoBrokerLogsCloudwatchLogs? CloudwatchLogs
        {
            get;
            set;
        }

        /// <summary>firehose block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#firehose MskCluster#firehose}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "firehose", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfoBrokerLogsFirehose\"}", isOptional: true)]
        public aws.MskCluster.IMskClusterLoggingInfoBrokerLogsFirehose? Firehose
        {
            get;
            set;
        }

        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#s3 MskCluster#s3}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfoBrokerLogsS3\"}", isOptional: true)]
        public aws.MskCluster.IMskClusterLoggingInfoBrokerLogsS3? S3
        {
            get;
            set;
        }
    }
}
