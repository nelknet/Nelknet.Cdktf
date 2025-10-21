using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesRedshift")]
    public class AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesRedshift : aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesRedshift
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#intermediate_bucket_name AppflowFlow#intermediate_bucket_name}.</summary>
        [JsiiProperty(name: "intermediateBucketName", typeJson: "{\"primitive\":\"string\"}")]
        public string IntermediateBucketName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#object AppflowFlow#object}.</summary>
        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public string Object
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#bucket_prefix AppflowFlow#bucket_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bucketPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BucketPrefix
        {
            get;
            set;
        }

        /// <summary>error_handling_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#error_handling_config AppflowFlow#error_handling_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "errorHandlingConfig", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesRedshiftErrorHandlingConfig\"}", isOptional: true)]
        public aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesRedshiftErrorHandlingConfig? ErrorHandlingConfig
        {
            get;
            set;
        }
    }
}
