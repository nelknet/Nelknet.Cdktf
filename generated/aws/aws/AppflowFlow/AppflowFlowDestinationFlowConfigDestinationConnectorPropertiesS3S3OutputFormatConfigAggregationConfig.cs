using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiByValue(fqn: "aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigAggregationConfig")]
    public class AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigAggregationConfig : aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigAggregationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#aggregation_type AppflowFlow#aggregation_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "aggregationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AggregationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#target_file_size AppflowFlow#target_file_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetFileSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TargetFileSize
        {
            get;
            set;
        }
    }
}
