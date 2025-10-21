using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightIamPolicyAssignment
{
    [JsiiInterface(nativeType: typeof(IQuicksightIamPolicyAssignmentIdentities), fullyQualifiedName: "aws.quicksightIamPolicyAssignment.QuicksightIamPolicyAssignmentIdentities")]
    public interface IQuicksightIamPolicyAssignmentIdentities
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_iam_policy_assignment#group QuicksightIamPolicyAssignment#group}.</summary>
        [JsiiProperty(name: "group", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Group
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_iam_policy_assignment#user QuicksightIamPolicyAssignment#user}.</summary>
        [JsiiProperty(name: "user", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? User
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightIamPolicyAssignmentIdentities), fullyQualifiedName: "aws.quicksightIamPolicyAssignment.QuicksightIamPolicyAssignmentIdentities")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightIamPolicyAssignment.IQuicksightIamPolicyAssignmentIdentities
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_iam_policy_assignment#group QuicksightIamPolicyAssignment#group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "group", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Group
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_iam_policy_assignment#user QuicksightIamPolicyAssignment#user}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "user", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? User
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
