using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksNodeGroup
{
    [JsiiInterface(nativeType: typeof(IEksNodeGroupRemoteAccess), fullyQualifiedName: "aws.eksNodeGroup.EksNodeGroupRemoteAccess")]
    public interface IEksNodeGroupRemoteAccess
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#ec2_ssh_key EksNodeGroup#ec2_ssh_key}.</summary>
        [JsiiProperty(name: "ec2SshKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ec2SshKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#source_security_group_ids EksNodeGroup#source_security_group_ids}.</summary>
        [JsiiProperty(name: "sourceSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SourceSecurityGroupIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksNodeGroupRemoteAccess), fullyQualifiedName: "aws.eksNodeGroup.EksNodeGroupRemoteAccess")]
        internal sealed class _Proxy : DeputyBase, aws.EksNodeGroup.IEksNodeGroupRemoteAccess
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#ec2_ssh_key EksNodeGroup#ec2_ssh_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ec2SshKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ec2SshKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#source_security_group_ids EksNodeGroup#source_security_group_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SourceSecurityGroupIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
