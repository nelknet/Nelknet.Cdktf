using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ResiliencehubResiliencyPolicy
{
    [JsiiByValue(fqn: "aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyRegion")]
    public class ResiliencehubResiliencyPolicyPolicyRegion : aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyRegion
    {
        /// <summary>Recovery Point Objective (RPO) as a Go duration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#rpo ResiliencehubResiliencyPolicy#rpo}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rpo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Rpo
        {
            get;
            set;
        }

        /// <summary>Recovery Time Objective (RTO) as a Go duration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#rto ResiliencehubResiliencyPolicy#rto}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rto", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Rto
        {
            get;
            set;
        }
    }
}
