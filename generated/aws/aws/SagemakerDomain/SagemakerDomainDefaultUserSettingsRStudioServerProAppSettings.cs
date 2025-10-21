using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiByValue(fqn: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsRStudioServerProAppSettings")]
    public class SagemakerDomainDefaultUserSettingsRStudioServerProAppSettings : aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsRStudioServerProAppSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#access_status SagemakerDomain#access_status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accessStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessStatus
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#user_group SagemakerDomain#user_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserGroup
        {
            get;
            set;
        }
    }
}
