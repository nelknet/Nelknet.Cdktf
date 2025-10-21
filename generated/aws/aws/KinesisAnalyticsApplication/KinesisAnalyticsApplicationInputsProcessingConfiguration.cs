using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KinesisAnalyticsApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationInputsProcessingConfiguration")]
    public class KinesisAnalyticsApplicationInputsProcessingConfiguration : aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationInputsProcessingConfiguration
    {
        /// <summary>lambda block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_analytics_application#lambda KinesisAnalyticsApplication#lambda}
        /// </remarks>
        [JsiiProperty(name: "lambda", typeJson: "{\"fqn\":\"aws.kinesisAnalyticsApplication.KinesisAnalyticsApplicationInputsProcessingConfigurationLambda\"}")]
        public aws.KinesisAnalyticsApplication.IKinesisAnalyticsApplicationInputsProcessingConfigurationLambda Lambda
        {
            get;
            set;
        }
    }
}
