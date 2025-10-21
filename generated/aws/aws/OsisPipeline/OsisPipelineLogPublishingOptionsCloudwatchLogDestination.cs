using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OsisPipeline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.osisPipeline.OsisPipelineLogPublishingOptionsCloudwatchLogDestination")]
    public class OsisPipelineLogPublishingOptionsCloudwatchLogDestination : aws.OsisPipeline.IOsisPipelineLogPublishingOptionsCloudwatchLogDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/osis_pipeline#log_group OsisPipeline#log_group}.</summary>
        [JsiiProperty(name: "logGroup", typeJson: "{\"primitive\":\"string\"}")]
        public string LogGroup
        {
            get;
            set;
        }
    }
}
