using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerWorkteam
{
    [JsiiByValue(fqn: "aws.sagemakerWorkteam.SagemakerWorkteamWorkerAccessConfigurationS3PresignIamPolicyConstraints")]
    public class SagemakerWorkteamWorkerAccessConfigurationS3PresignIamPolicyConstraints : aws.SagemakerWorkteam.ISagemakerWorkteamWorkerAccessConfigurationS3PresignIamPolicyConstraints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam#source_ip SagemakerWorkteam#source_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceIp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam#vpc_source_ip SagemakerWorkteam#vpc_source_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcSourceIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VpcSourceIp
        {
            get;
            set;
        }
    }
}
