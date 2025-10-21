using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveInputSecurityGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveInputSecurityGroup.MedialiveInputSecurityGroupWhitelistRules")]
    public class MedialiveInputSecurityGroupWhitelistRules : aws.MedialiveInputSecurityGroup.IMedialiveInputSecurityGroupWhitelistRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input_security_group#cidr MedialiveInputSecurityGroup#cidr}.</summary>
        [JsiiProperty(name: "cidr", typeJson: "{\"primitive\":\"string\"}")]
        public string Cidr
        {
            get;
            set;
        }
    }
}
