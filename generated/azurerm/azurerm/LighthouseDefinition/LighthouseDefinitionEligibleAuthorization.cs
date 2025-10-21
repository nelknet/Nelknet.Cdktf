using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LighthouseDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.lighthouseDefinition.LighthouseDefinitionEligibleAuthorization")]
    public class LighthouseDefinitionEligibleAuthorization : azurerm.LighthouseDefinition.ILighthouseDefinitionEligibleAuthorization
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_definition#principal_id LighthouseDefinition#principal_id}.</summary>
        [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}")]
        public string PrincipalId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_definition#role_definition_id LighthouseDefinition#role_definition_id}.</summary>
        [JsiiProperty(name: "roleDefinitionId", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleDefinitionId
        {
            get;
            set;
        }

        /// <summary>just_in_time_access_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_definition#just_in_time_access_policy LighthouseDefinition#just_in_time_access_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "justInTimeAccessPolicy", typeJson: "{\"fqn\":\"azurerm.lighthouseDefinition.LighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicy\"}", isOptional: true)]
        public azurerm.LighthouseDefinition.ILighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicy? JustInTimeAccessPolicy
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
