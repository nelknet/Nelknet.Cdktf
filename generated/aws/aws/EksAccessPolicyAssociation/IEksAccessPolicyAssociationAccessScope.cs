using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksAccessPolicyAssociation
{
    [JsiiInterface(nativeType: typeof(IEksAccessPolicyAssociationAccessScope), fullyQualifiedName: "aws.eksAccessPolicyAssociation.EksAccessPolicyAssociationAccessScope")]
    public interface IEksAccessPolicyAssociationAccessScope
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_access_policy_association#type EksAccessPolicyAssociation#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_access_policy_association#namespaces EksAccessPolicyAssociation#namespaces}.</summary>
        [JsiiProperty(name: "namespaces", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Namespaces
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksAccessPolicyAssociationAccessScope), fullyQualifiedName: "aws.eksAccessPolicyAssociation.EksAccessPolicyAssociationAccessScope")]
        internal sealed class _Proxy : DeputyBase, aws.EksAccessPolicyAssociation.IEksAccessPolicyAssociationAccessScope
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_access_policy_association#type EksAccessPolicyAssociation#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_access_policy_association#namespaces EksAccessPolicyAssociation#namespaces}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namespaces", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Namespaces
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
