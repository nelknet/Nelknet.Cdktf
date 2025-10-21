using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FmsPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.fmsPolicy.FmsPolicySecurityServicePolicyData")]
    public class FmsPolicySecurityServicePolicyData : aws.FmsPolicy.IFmsPolicySecurityServicePolicyData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#type FmsPolicy#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#managed_service_data FmsPolicy#managed_service_data}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "managedServiceData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ManagedServiceData
        {
            get;
            set;
        }

        /// <summary>policy_option block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#policy_option FmsPolicy#policy_option}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "policyOption", typeJson: "{\"fqn\":\"aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOption\"}", isOptional: true)]
        public aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOption? PolicyOption
        {
            get;
            set;
        }
    }
}
