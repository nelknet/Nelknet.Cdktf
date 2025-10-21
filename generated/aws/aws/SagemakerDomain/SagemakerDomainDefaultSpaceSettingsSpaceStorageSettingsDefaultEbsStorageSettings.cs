using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerDomain.SagemakerDomainDefaultSpaceSettingsSpaceStorageSettingsDefaultEbsStorageSettings")]
    public class SagemakerDomainDefaultSpaceSettingsSpaceStorageSettingsDefaultEbsStorageSettings : aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettingsSpaceStorageSettingsDefaultEbsStorageSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#default_ebs_volume_size_in_gb SagemakerDomain#default_ebs_volume_size_in_gb}.</summary>
        [JsiiProperty(name: "defaultEbsVolumeSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public double DefaultEbsVolumeSizeInGb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#maximum_ebs_volume_size_in_gb SagemakerDomain#maximum_ebs_volume_size_in_gb}.</summary>
        [JsiiProperty(name: "maximumEbsVolumeSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public double MaximumEbsVolumeSizeInGb
        {
            get;
            set;
        }
    }
}
