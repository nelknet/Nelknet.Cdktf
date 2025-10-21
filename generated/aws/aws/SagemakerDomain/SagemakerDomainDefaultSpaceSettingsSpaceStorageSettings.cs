using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiByValue(fqn: "aws.sagemakerDomain.SagemakerDomainDefaultSpaceSettingsSpaceStorageSettings")]
    public class SagemakerDomainDefaultSpaceSettingsSpaceStorageSettings : aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettingsSpaceStorageSettings
    {
        /// <summary>default_ebs_storage_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#default_ebs_storage_settings SagemakerDomain#default_ebs_storage_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultEbsStorageSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultSpaceSettingsSpaceStorageSettingsDefaultEbsStorageSettings\"}", isOptional: true)]
        public aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettingsSpaceStorageSettingsDefaultEbsStorageSettings? DefaultEbsStorageSettings
        {
            get;
            set;
        }
    }
}
