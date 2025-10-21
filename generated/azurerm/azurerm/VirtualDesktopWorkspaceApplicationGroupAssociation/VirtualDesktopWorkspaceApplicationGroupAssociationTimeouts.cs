using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualDesktopWorkspaceApplicationGroupAssociation
{
    [JsiiByValue(fqn: "azurerm.virtualDesktopWorkspaceApplicationGroupAssociation.VirtualDesktopWorkspaceApplicationGroupAssociationTimeouts")]
    public class VirtualDesktopWorkspaceApplicationGroupAssociationTimeouts : azurerm.VirtualDesktopWorkspaceApplicationGroupAssociation.IVirtualDesktopWorkspaceApplicationGroupAssociationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_workspace_application_group_association#create VirtualDesktopWorkspaceApplicationGroupAssociation#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_workspace_application_group_association#delete VirtualDesktopWorkspaceApplicationGroupAssociation#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_workspace_application_group_association#read VirtualDesktopWorkspaceApplicationGroupAssociation#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
