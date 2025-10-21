using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RoleDefinition
{
    [JsiiByValue(fqn: "azurerm.roleDefinition.RoleDefinitionPermissions")]
    public class RoleDefinitionPermissions : azurerm.RoleDefinition.IRoleDefinitionPermissions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_definition#actions RoleDefinition#actions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "actions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Actions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_definition#data_actions RoleDefinition#data_actions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DataActions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_definition#not_actions RoleDefinition#not_actions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NotActions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_definition#not_data_actions RoleDefinition#not_data_actions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notDataActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NotDataActions
        {
            get;
            set;
        }
    }
}
