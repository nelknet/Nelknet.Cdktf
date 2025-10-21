using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KinesisAnalyticsApplication
{
    [JsiiByValue(fqn: "aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationInputsStartingPositionConfiguration")]
    public class KinesisAnalyticsApplicationInputsStartingPositionConfiguration : aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationInputsStartingPositionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#starting_position KinesisAnalyticsApplication#starting_position}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startingPosition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StartingPosition
        {
            get;
            set;
        }
    }
}
