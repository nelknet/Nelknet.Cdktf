using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerUserProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCustomPosixUserConfig")]
    public class SagemakerUserProfileUserSettingsCustomPosixUserConfig : aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCustomPosixUserConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#gid SagemakerUserProfile#gid}.</summary>
        [JsiiProperty(name: "gid", typeJson: "{\"primitive\":\"number\"}")]
        public double Gid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#uid SagemakerUserProfile#uid}.</summary>
        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"number\"}")]
        public double Uid
        {
            get;
            set;
        }
    }
}
