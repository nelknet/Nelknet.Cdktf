using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ChimesdkvoiceSipRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.chimesdkvoiceSipRule.ChimesdkvoiceSipRuleTargetApplications")]
    public class ChimesdkvoiceSipRuleTargetApplications : aws.ChimesdkvoiceSipRule.IChimesdkvoiceSipRuleTargetApplications
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_sip_rule#aws_region ChimesdkvoiceSipRule#aws_region}.</summary>
        [JsiiProperty(name: "awsRegion", typeJson: "{\"primitive\":\"string\"}")]
        public string AwsRegion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_sip_rule#priority ChimesdkvoiceSipRule#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public double Priority
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_sip_rule#sip_media_application_id ChimesdkvoiceSipRule#sip_media_application_id}.</summary>
        [JsiiProperty(name: "sipMediaApplicationId", typeJson: "{\"primitive\":\"string\"}")]
        public string SipMediaApplicationId
        {
            get;
            set;
        }
    }
}
