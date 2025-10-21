using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SynapseWorkspace
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.synapseWorkspace.SynapseWorkspaceCustomerManagedKey")]
    public class SynapseWorkspaceCustomerManagedKey : azurerm.SynapseWorkspace.ISynapseWorkspaceCustomerManagedKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#key_versionless_id SynapseWorkspace#key_versionless_id}.</summary>
        [JsiiProperty(name: "keyVersionlessId", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyVersionlessId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#key_name SynapseWorkspace#key_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#user_assigned_identity_id SynapseWorkspace#user_assigned_identity_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserAssignedIdentityId
        {
            get;
            set;
        }
    }
}
