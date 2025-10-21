using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedApplicationDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.managedApplicationDefinition.ManagedApplicationDefinitionAuthorization")]
    public class ManagedApplicationDefinitionAuthorization : azurerm.ManagedApplicationDefinition.IManagedApplicationDefinitionAuthorization
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application_definition#role_definition_id ManagedApplicationDefinition#role_definition_id}.</summary>
        [JsiiProperty(name: "roleDefinitionId", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleDefinitionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application_definition#service_principal_id ManagedApplicationDefinition#service_principal_id}.</summary>
        [JsiiProperty(name: "servicePrincipalId", typeJson: "{\"primitive\":\"string\"}")]
        public string ServicePrincipalId
        {
            get;
            set;
        }
    }
}
