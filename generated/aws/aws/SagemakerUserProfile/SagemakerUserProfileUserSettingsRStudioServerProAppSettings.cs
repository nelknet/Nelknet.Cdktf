using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerUserProfile
{
    [JsiiByValue(fqn: "aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsRStudioServerProAppSettings")]
    public class SagemakerUserProfileUserSettingsRStudioServerProAppSettings : aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsRStudioServerProAppSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#access_status SagemakerUserProfile#access_status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accessStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessStatus
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#user_group SagemakerUserProfile#user_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserGroup
        {
            get;
            set;
        }
    }
}
