using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksAddon
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.eksAddon.EksAddonPodIdentityAssociation")]
    public class EksAddonPodIdentityAssociation : aws.EksAddon.IEksAddonPodIdentityAssociation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_addon#role_arn EksAddon#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_addon#service_account EksAddon#service_account}.</summary>
        [JsiiProperty(name: "serviceAccount", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceAccount
        {
            get;
            set;
        }
    }
}
