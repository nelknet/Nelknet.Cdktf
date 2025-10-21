using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightIamPolicyAssignment
{
    [JsiiByValue(fqn: "aws.quicksightIamPolicyAssignment.QuicksightIamPolicyAssignmentIdentities")]
    public class QuicksightIamPolicyAssignmentIdentities : aws.QuicksightIamPolicyAssignment.IQuicksightIamPolicyAssignmentIdentities
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_iam_policy_assignment#group QuicksightIamPolicyAssignment#group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "group", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Group
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_iam_policy_assignment#user QuicksightIamPolicyAssignment#user}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "user", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? User
        {
            get;
            set;
        }
    }
}
