using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerUserProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings")]
    public class SagemakerUserProfileUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings : aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsSpaceStorageSettingsDefaultEbsStorageSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#default_ebs_volume_size_in_gb SagemakerUserProfile#default_ebs_volume_size_in_gb}.</summary>
        [JsiiProperty(name: "defaultEbsVolumeSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public double DefaultEbsVolumeSizeInGb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#maximum_ebs_volume_size_in_gb SagemakerUserProfile#maximum_ebs_volume_size_in_gb}.</summary>
        [JsiiProperty(name: "maximumEbsVolumeSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public double MaximumEbsVolumeSizeInGb
        {
            get;
            set;
        }
    }
}
