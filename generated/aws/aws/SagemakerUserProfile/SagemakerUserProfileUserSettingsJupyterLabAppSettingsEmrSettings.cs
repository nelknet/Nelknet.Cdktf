using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerUserProfile
{
    [JsiiByValue(fqn: "aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsEmrSettings")]
    public class SagemakerUserProfileUserSettingsJupyterLabAppSettingsEmrSettings : aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettingsEmrSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#assumable_role_arns SagemakerUserProfile#assumable_role_arns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "assumableRoleArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AssumableRoleArns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#execution_role_arns SagemakerUserProfile#execution_role_arns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "executionRoleArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExecutionRoleArns
        {
            get;
            set;
        }
    }
}
