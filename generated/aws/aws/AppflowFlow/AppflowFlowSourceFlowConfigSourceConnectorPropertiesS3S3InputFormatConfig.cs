using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiByValue(fqn: "aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfig")]
    public class AppflowFlowSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfig : aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorPropertiesS3S3InputFormatConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#s3_input_file_type AppflowFlow#s3_input_file_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3InputFileType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3InputFileType
        {
            get;
            set;
        }
    }
}
