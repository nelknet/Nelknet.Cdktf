using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksAccessPolicyAssociation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.eksAccessPolicyAssociation.EksAccessPolicyAssociationAccessScope")]
    public class EksAccessPolicyAssociationAccessScope : aws.EksAccessPolicyAssociation.IEksAccessPolicyAssociationAccessScope
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_access_policy_association#type EksAccessPolicyAssociation#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_access_policy_association#namespaces EksAccessPolicyAssociation#namespaces}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namespaces", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Namespaces
        {
            get;
            set;
        }
    }
}
