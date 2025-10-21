using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SecurityCenterAssessment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.securityCenterAssessment.SecurityCenterAssessmentStatus")]
    public class SecurityCenterAssessmentStatus : azurerm.SecurityCenterAssessment.ISecurityCenterAssessmentStatus
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_assessment#code SecurityCenterAssessment#code}.</summary>
        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"string\"}")]
        public string Code
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_assessment#cause SecurityCenterAssessment#cause}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cause", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Cause
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_assessment#description SecurityCenterAssessment#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }
    }
}
