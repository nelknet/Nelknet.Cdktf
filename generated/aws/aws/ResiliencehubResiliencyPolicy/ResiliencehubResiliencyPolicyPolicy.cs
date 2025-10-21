using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ResiliencehubResiliencyPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicy")]
    public class ResiliencehubResiliencyPolicyPolicy : aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicy
    {
        /// <summary>az block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#az ResiliencehubResiliencyPolicy#az}
        /// </remarks>
        [JsiiProperty(name: "az", typeJson: "{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyAz\"}")]
        public aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyAz Az
        {
            get;
            set;
        }

        /// <summary>hardware block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#hardware ResiliencehubResiliencyPolicy#hardware}
        /// </remarks>
        [JsiiProperty(name: "hardware", typeJson: "{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyHardware\"}")]
        public aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyHardware Hardware
        {
            get;
            set;
        }

        /// <summary>software block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#software ResiliencehubResiliencyPolicy#software}
        /// </remarks>
        [JsiiProperty(name: "softwareAttribute", typeJson: "{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicySoftware\"}")]
        public aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicySoftware SoftwareAttribute
        {
            get;
            set;
        }

        /// <summary>region block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#region ResiliencehubResiliencyPolicy#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyRegion\"}", isOptional: true)]
        public aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyRegion? Region
        {
            get;
            set;
        }
    }
}
