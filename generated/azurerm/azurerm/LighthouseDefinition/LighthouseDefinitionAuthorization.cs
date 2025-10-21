using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LighthouseDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.lighthouseDefinition.LighthouseDefinitionAuthorization")]
    public class LighthouseDefinitionAuthorization : azurerm.LighthouseDefinition.ILighthouseDefinitionAuthorization
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_definition#delegated_role_definition_ids LighthouseDefinition#delegated_role_definition_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delegatedRoleDefinitionIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DelegatedRoleDefinitionIds
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
