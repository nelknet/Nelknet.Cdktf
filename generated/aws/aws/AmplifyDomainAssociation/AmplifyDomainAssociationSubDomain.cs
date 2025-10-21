using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AmplifyDomainAssociation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.amplifyDomainAssociation.AmplifyDomainAssociationSubDomain")]
    public class AmplifyDomainAssociationSubDomain : aws.AmplifyDomainAssociation.IAmplifyDomainAssociationSubDomain
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_domain_association#branch_name AmplifyDomainAssociation#branch_name}.</summary>
        [JsiiProperty(name: "branchName", typeJson: "{\"primitive\":\"string\"}")]
        public string BranchName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_domain_association#prefix AmplifyDomainAssociation#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public string Prefix
        {
            get;
            set;
        }
    }
}
