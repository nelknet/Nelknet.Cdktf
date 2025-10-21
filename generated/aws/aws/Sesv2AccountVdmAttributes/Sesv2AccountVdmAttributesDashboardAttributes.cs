using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2AccountVdmAttributes
{
    [JsiiByValue(fqn: "aws.sesv2AccountVdmAttributes.Sesv2AccountVdmAttributesDashboardAttributes")]
    public class Sesv2AccountVdmAttributesDashboardAttributes : aws.Sesv2AccountVdmAttributes.ISesv2AccountVdmAttributesDashboardAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_account_vdm_attributes#engagement_metrics Sesv2AccountVdmAttributes#engagement_metrics}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "engagementMetrics", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EngagementMetrics
        {
            get;
            set;
        }
    }
}
