using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiByValue(fqn: "aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigPrefixConfig")]
    public class AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigPrefixConfig : aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesS3S3OutputFormatConfigPrefixConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#prefix_format AppflowFlow#prefix_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "prefixFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrefixFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#prefix_hierarchy AppflowFlow#prefix_hierarchy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "prefixHierarchy", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PrefixHierarchy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#prefix_type AppflowFlow#prefix_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "prefixType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrefixType
        {
            get;
            set;
        }
    }
}
