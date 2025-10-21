using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OamLink
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.oamLink.OamLinkLinkConfigurationLogGroupConfiguration")]
    public class OamLinkLinkConfigurationLogGroupConfiguration : aws.OamLink.IOamLinkLinkConfigurationLogGroupConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_link#filter OamLink#filter}.</summary>
        [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}")]
        public string Filter
        {
            get;
            set;
        }
    }
}
