using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpointConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationShadowProductionVariantsCoreDumpConfig")]
    public class SagemakerEndpointConfigurationShadowProductionVariantsCoreDumpConfig : aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationShadowProductionVariantsCoreDumpConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#destination_s3_uri SagemakerEndpointConfiguration#destination_s3_uri}.</summary>
        [JsiiProperty(name: "destinationS3Uri", typeJson: "{\"primitive\":\"string\"}")]
        public string DestinationS3Uri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#kms_key_id SagemakerEndpointConfiguration#kms_key_id}.</summary>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public string KmsKeyId
        {
            get;
            set;
        }
    }
}
