using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrBlockPublicAccessConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.emrBlockPublicAccessConfiguration.EmrBlockPublicAccessConfigurationPermittedPublicSecurityGroupRuleRange")]
    public class EmrBlockPublicAccessConfigurationPermittedPublicSecurityGroupRuleRange : aws.EmrBlockPublicAccessConfiguration.IEmrBlockPublicAccessConfigurationPermittedPublicSecurityGroupRuleRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_block_public_access_configuration#max_range EmrBlockPublicAccessConfiguration#max_range}.</summary>
        [JsiiProperty(name: "maxRange", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxRange
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_block_public_access_configuration#min_range EmrBlockPublicAccessConfiguration#min_range}.</summary>
        [JsiiProperty(name: "minRange", typeJson: "{\"primitive\":\"number\"}")]
        public double MinRange
        {
            get;
            set;
        }
    }
}
