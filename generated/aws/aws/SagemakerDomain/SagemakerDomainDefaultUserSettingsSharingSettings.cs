using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiByValue(fqn: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsSharingSettings")]
    public class SagemakerDomainDefaultUserSettingsSharingSettings : aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsSharingSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#notebook_output_option SagemakerDomain#notebook_output_option}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notebookOutputOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NotebookOutputOption
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#s3_kms_key_id SagemakerDomain#s3_kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3KmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3KmsKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#s3_output_path SagemakerDomain#s3_output_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3OutputPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3OutputPath
        {
            get;
            set;
        }
    }
}
