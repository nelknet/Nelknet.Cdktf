using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksNodeGroup
{
    [JsiiByValue(fqn: "aws.eksNodeGroup.EksNodeGroupRemoteAccess")]
    public class EksNodeGroupRemoteAccess : aws.EksNodeGroup.IEksNodeGroupRemoteAccess
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#ec2_ssh_key EksNodeGroup#ec2_ssh_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ec2SshKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ec2SshKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#source_security_group_ids EksNodeGroup#source_security_group_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SourceSecurityGroupIds
        {
            get;
            set;
        }
    }
}
