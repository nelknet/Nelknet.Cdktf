using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VerifiedpermissionsPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.verifiedpermissionsPolicy.VerifiedpermissionsPolicyDefinitionStatic")]
    public class VerifiedpermissionsPolicyDefinitionStatic : aws.VerifiedpermissionsPolicy.IVerifiedpermissionsPolicyDefinitionStatic
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy#statement VerifiedpermissionsPolicy#statement}.</summary>
        [JsiiProperty(name: "statement", typeJson: "{\"primitive\":\"string\"}")]
        public string Statement
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy#description VerifiedpermissionsPolicy#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }
    }
}
