using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedApplicationDefinition
{
    [JsiiInterface(nativeType: typeof(IManagedApplicationDefinitionAuthorization), fullyQualifiedName: "azurerm.managedApplicationDefinition.ManagedApplicationDefinitionAuthorization")]
    public interface IManagedApplicationDefinitionAuthorization
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application_definition#role_definition_id ManagedApplicationDefinition#role_definition_id}.</summary>
        [JsiiProperty(name: "roleDefinitionId", typeJson: "{\"primitive\":\"string\"}")]
        string RoleDefinitionId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application_definition#service_principal_id ManagedApplicationDefinition#service_principal_id}.</summary>
        [JsiiProperty(name: "servicePrincipalId", typeJson: "{\"primitive\":\"string\"}")]
        string ServicePrincipalId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedApplicationDefinitionAuthorization), fullyQualifiedName: "azurerm.managedApplicationDefinition.ManagedApplicationDefinitionAuthorization")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagedApplicationDefinition.IManagedApplicationDefinitionAuthorization
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application_definition#role_definition_id ManagedApplicationDefinition#role_definition_id}.</summary>
            [JsiiProperty(name: "roleDefinitionId", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleDefinitionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application_definition#service_principal_id ManagedApplicationDefinition#service_principal_id}.</summary>
            [JsiiProperty(name: "servicePrincipalId", typeJson: "{\"primitive\":\"string\"}")]
            public string ServicePrincipalId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
