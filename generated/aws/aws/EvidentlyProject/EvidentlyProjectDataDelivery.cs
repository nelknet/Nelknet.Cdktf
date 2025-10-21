using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EvidentlyProject
{
    [JsiiByValue(fqn: "aws.evidentlyProject.EvidentlyProjectDataDelivery")]
    public class EvidentlyProjectDataDelivery : aws.EvidentlyProject.IEvidentlyProjectDataDelivery
    {
        /// <summary>cloudwatch_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_project#cloudwatch_logs EvidentlyProject#cloudwatch_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.evidentlyProject.EvidentlyProjectDataDeliveryCloudwatchLogs\"}", isOptional: true)]
        public aws.EvidentlyProject.IEvidentlyProjectDataDeliveryCloudwatchLogs? CloudwatchLogs
        {
            get;
            set;
        }

        /// <summary>s3_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_project#s3_destination EvidentlyProject#s3_destination}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Destination", typeJson: "{\"fqn\":\"aws.evidentlyProject.EvidentlyProjectDataDeliveryS3Destination\"}", isOptional: true)]
        public aws.EvidentlyProject.IEvidentlyProjectDataDeliveryS3Destination? S3Destination
        {
            get;
            set;
        }
    }
}
