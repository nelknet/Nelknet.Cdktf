using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerWorkteam
{
    [JsiiByValue(fqn: "aws.sagemakerWorkteam.SagemakerWorkteamWorkerAccessConfigurationS3Presign")]
    public class SagemakerWorkteamWorkerAccessConfigurationS3Presign : aws.SagemakerWorkteam.ISagemakerWorkteamWorkerAccessConfigurationS3Presign
    {
        /// <summary>iam_policy_constraints block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam#iam_policy_constraints SagemakerWorkteam#iam_policy_constraints}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "iamPolicyConstraints", typeJson: "{\"fqn\":\"aws.sagemakerWorkteam.SagemakerWorkteamWorkerAccessConfigurationS3PresignIamPolicyConstraints\"}", isOptional: true)]
        public aws.SagemakerWorkteam.ISagemakerWorkteamWorkerAccessConfigurationS3PresignIamPolicyConstraints? IamPolicyConstraints
        {
            get;
            set;
        }
    }
}
