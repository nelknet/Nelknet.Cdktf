using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    [JsiiInterface(nativeType: typeof(IMskconnectConnectorLogDeliveryWorkerLogDelivery), fullyQualifiedName: "aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDelivery")]
    public interface IMskconnectConnectorLogDeliveryWorkerLogDelivery
    {
        /// <summary>cloudwatch_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#cloudwatch_logs MskconnectConnector#cloudwatch_logs}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryCloudwatchLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDeliveryCloudwatchLogs? CloudwatchLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>firehose block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#firehose MskconnectConnector#firehose}
        /// </remarks>
        [JsiiProperty(name: "firehose", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryFirehose\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDeliveryFirehose? Firehose
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#s3 MskconnectConnector#s3}
        /// </remarks>
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryS3\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDeliveryS3? S3
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskconnectConnectorLogDeliveryWorkerLogDelivery), fullyQualifiedName: "aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDelivery")]
        internal sealed class _Proxy : DeputyBase, aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDelivery
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cloudwatch_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#cloudwatch_logs MskconnectConnector#cloudwatch_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryCloudwatchLogs\"}", isOptional: true)]
            public aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDeliveryCloudwatchLogs? CloudwatchLogs
            {
                get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDeliveryCloudwatchLogs?>();
            }

            /// <summary>firehose block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#firehose MskconnectConnector#firehose}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "firehose", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryFirehose\"}", isOptional: true)]
            public aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDeliveryFirehose? Firehose
            {
                get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDeliveryFirehose?>();
            }

            /// <summary>s3 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#s3 MskconnectConnector#s3}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryS3\"}", isOptional: true)]
            public aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDeliveryS3? S3
            {
                get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDeliveryS3?>();
            }
        }
    }
}
