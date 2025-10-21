using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiByValue(fqn: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsModelRegisterSettings")]
    public class SagemakerDomainDefaultUserSettingsCanvasAppSettingsModelRegisterSettings : aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsModelRegisterSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#cross_account_model_register_role_arn SagemakerDomain#cross_account_model_register_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "crossAccountModelRegisterRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CrossAccountModelRegisterRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#status SagemakerDomain#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }
    }
}
