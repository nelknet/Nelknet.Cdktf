using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AmplifyDomainAssociation
{
    [JsiiInterface(nativeType: typeof(IAmplifyDomainAssociationSubDomain), fullyQualifiedName: "aws.amplifyDomainAssociation.AmplifyDomainAssociationSubDomain")]
    public interface IAmplifyDomainAssociationSubDomain
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_domain_association#branch_name AmplifyDomainAssociation#branch_name}.</summary>
        [JsiiProperty(name: "branchName", typeJson: "{\"primitive\":\"string\"}")]
        string BranchName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_domain_association#prefix AmplifyDomainAssociation#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        string Prefix
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAmplifyDomainAssociationSubDomain), fullyQualifiedName: "aws.amplifyDomainAssociation.AmplifyDomainAssociationSubDomain")]
        internal sealed class _Proxy : DeputyBase, aws.AmplifyDomainAssociation.IAmplifyDomainAssociationSubDomain
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_domain_association#branch_name AmplifyDomainAssociation#branch_name}.</summary>
            [JsiiProperty(name: "branchName", typeJson: "{\"primitive\":\"string\"}")]
            public string BranchName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_domain_association#prefix AmplifyDomainAssociation#prefix}.</summary>
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
            public string Prefix
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
