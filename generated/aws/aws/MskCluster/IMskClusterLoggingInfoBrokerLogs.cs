using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiInterface(nativeType: typeof(IMskClusterLoggingInfoBrokerLogs), fullyQualifiedName: "aws.mskCluster.MskClusterLoggingInfoBrokerLogs")]
    public interface IMskClusterLoggingInfoBrokerLogs
    {
        /// <summary>cloudwatch_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#cloudwatch_logs MskCluster#cloudwatch_logs}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfoBrokerLogsCloudwatchLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskCluster.IMskClusterLoggingInfoBrokerLogsCloudwatchLogs? CloudwatchLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>firehose block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#firehose MskCluster#firehose}
        /// </remarks>
        [JsiiProperty(name: "firehose", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfoBrokerLogsFirehose\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskCluster.IMskClusterLoggingInfoBrokerLogsFirehose? Firehose
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#s3 MskCluster#s3}
        /// </remarks>
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfoBrokerLogsS3\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskCluster.IMskClusterLoggingInfoBrokerLogsS3? S3
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterLoggingInfoBrokerLogs), fullyQualifiedName: "aws.mskCluster.MskClusterLoggingInfoBrokerLogs")]
        internal sealed class _Proxy : DeputyBase, aws.MskCluster.IMskClusterLoggingInfoBrokerLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cloudwatch_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#cloudwatch_logs MskCluster#cloudwatch_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfoBrokerLogsCloudwatchLogs\"}", isOptional: true)]
            public aws.MskCluster.IMskClusterLoggingInfoBrokerLogsCloudwatchLogs? CloudwatchLogs
            {
                get => GetInstanceProperty<aws.MskCluster.IMskClusterLoggingInfoBrokerLogsCloudwatchLogs?>();
            }

            /// <summary>firehose block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#firehose MskCluster#firehose}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "firehose", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfoBrokerLogsFirehose\"}", isOptional: true)]
            public aws.MskCluster.IMskClusterLoggingInfoBrokerLogsFirehose? Firehose
            {
                get => GetInstanceProperty<aws.MskCluster.IMskClusterLoggingInfoBrokerLogsFirehose?>();
            }

            /// <summary>s3 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#s3 MskCluster#s3}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterLoggingInfoBrokerLogsS3\"}", isOptional: true)]
            public aws.MskCluster.IMskClusterLoggingInfoBrokerLogsS3? S3
            {
                get => GetInstanceProperty<aws.MskCluster.IMskClusterLoggingInfoBrokerLogsS3?>();
            }
        }
    }
}
