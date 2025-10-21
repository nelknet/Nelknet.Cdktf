using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfig")]
    public class AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfig : aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfig
    {
        /// <summary>prefix_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#prefix_config AppflowFlow#prefix_config}
        /// </remarks>
        [JsiiProperty(name: "prefixConfig", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfigPrefixConfig\"}")]
        public aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfigPrefixConfig PrefixConfig
        {
            get;
            set;
        }

        /// <summary>aggregation_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#aggregation_config AppflowFlow#aggregation_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "aggregationConfig", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfigAggregationConfig\"}", isOptional: true)]
        public aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesUpsolverS3OutputFormatConfigAggregationConfig? AggregationConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#file_type AppflowFlow#file_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fileType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FileType
        {
            get;
            set;
        }
    }
}
