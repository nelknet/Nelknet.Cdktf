using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    [JsiiByValue(fqn: "aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDelivery")]
    public class MskconnectConnectorLogDeliveryWorkerLogDelivery : aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDelivery
    {
        /// <summary>cloudwatch_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#cloudwatch_logs MskconnectConnector#cloudwatch_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryCloudwatchLogs\"}", isOptional: true)]
        public aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDeliveryCloudwatchLogs? CloudwatchLogs
        {
            get;
            set;
        }

        /// <summary>firehose block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#firehose MskconnectConnector#firehose}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "firehose", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryFirehose\"}", isOptional: true)]
        public aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDeliveryFirehose? Firehose
        {
            get;
            set;
        }

        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#s3 MskconnectConnector#s3}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorLogDeliveryWorkerLogDeliveryS3\"}", isOptional: true)]
        public aws.MskconnectConnector.IMskconnectConnectorLogDeliveryWorkerLogDeliveryS3? S3
        {
            get;
            set;
        }
    }
}
