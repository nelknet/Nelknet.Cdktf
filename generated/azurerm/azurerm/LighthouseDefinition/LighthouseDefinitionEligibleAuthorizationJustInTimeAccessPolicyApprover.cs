using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LighthouseDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.lighthouseDefinition.LighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicyApprover")]
    public class LighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicyApprover : azurerm.LighthouseDefinition.ILighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicyApprover
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_definition#principal_id LighthouseDefinition#principal_id}.</summary>
        [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}")]
        public string PrincipalId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_definition#principal_display_name LighthouseDefinition#principal_display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "principalDisplayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrincipalDisplayName
        {
            get;
            set;
        }
    }
}
