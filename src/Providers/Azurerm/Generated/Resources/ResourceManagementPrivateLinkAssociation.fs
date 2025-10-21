namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ResourceManagementPrivateLinkAssociationState<'ManagementGroupId, 'PublicNetworkAccessEnabled, 'ResourceManagementPrivateLinkId> = { assignments: ResizeArray<azurerm.ResourceManagementPrivateLinkAssociation.ResourceManagementPrivateLinkAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_management_private_link_association">azurerm_resource_management_private_link_association</a>.
    /// </summary>
    type ResourceManagementPrivateLinkAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ResourceManagementPrivateLinkAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourceManagementPrivateLinkAssociationState<Missing, Missing, Missing>)

        member _.Zero(()) : ResourceManagementPrivateLinkAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourceManagementPrivateLinkAssociationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_management_private_link_association#management_group_id-1">ResourceManagementPrivateLinkAssociation#management_group_id</a>.
        /// </summary>
        [<CustomOperation "management_group_id">]
        member _.ManagementGroupId(state: ResourceManagementPrivateLinkAssociationState<Missing, 'PublicNetworkAccessEnabled, 'ResourceManagementPrivateLinkId>, value: string) : ResourceManagementPrivateLinkAssociationState<Present, 'PublicNetworkAccessEnabled, 'ResourceManagementPrivateLinkId> =
            state.assignments.Add(fun config -> config.ManagementGroupId <- value)
            ({ assignments = state.assignments } : ResourceManagementPrivateLinkAssociationState<Present, 'PublicNetworkAccessEnabled, 'ResourceManagementPrivateLinkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_management_private_link_association#public_network_access_enabled-1">ResourceManagementPrivateLinkAssociation#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: ResourceManagementPrivateLinkAssociationState<'ManagementGroupId, Missing, 'ResourceManagementPrivateLinkId>, value: bool) : ResourceManagementPrivateLinkAssociationState<'ManagementGroupId, Present, 'ResourceManagementPrivateLinkId> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            ({ assignments = state.assignments } : ResourceManagementPrivateLinkAssociationState<'ManagementGroupId, Present, 'ResourceManagementPrivateLinkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_management_private_link_association#public_network_access_enabled-1">ResourceManagementPrivateLinkAssociation#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: ResourceManagementPrivateLinkAssociationState<'ManagementGroupId, Missing, 'ResourceManagementPrivateLinkId>, value: HashiCorp.Cdktf.IResolvable) : ResourceManagementPrivateLinkAssociationState<'ManagementGroupId, Present, 'ResourceManagementPrivateLinkId> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            ({ assignments = state.assignments } : ResourceManagementPrivateLinkAssociationState<'ManagementGroupId, Present, 'ResourceManagementPrivateLinkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_management_private_link_association#resource_management_private_link_id-1">ResourceManagementPrivateLinkAssociation#resource_management_private_link_id</a>.
        /// </summary>
        [<CustomOperation "resource_management_private_link_id">]
        member _.ResourceManagementPrivateLinkId(state: ResourceManagementPrivateLinkAssociationState<'ManagementGroupId, 'PublicNetworkAccessEnabled, Missing>, value: string) : ResourceManagementPrivateLinkAssociationState<'ManagementGroupId, 'PublicNetworkAccessEnabled, Present> =
            state.assignments.Add(fun config -> config.ResourceManagementPrivateLinkId <- value)
            ({ assignments = state.assignments } : ResourceManagementPrivateLinkAssociationState<'ManagementGroupId, 'PublicNetworkAccessEnabled, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_management_private_link_association#id-1">ResourceManagementPrivateLinkAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ResourceManagementPrivateLinkAssociationState<'ManagementGroupId, 'PublicNetworkAccessEnabled, 'ResourceManagementPrivateLinkId>, value: string) : ResourceManagementPrivateLinkAssociationState<'ManagementGroupId, 'PublicNetworkAccessEnabled, 'ResourceManagementPrivateLinkId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ResourceManagementPrivateLinkAssociationState<'ManagementGroupId, 'PublicNetworkAccessEnabled, 'ResourceManagementPrivateLinkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_management_private_link_association#name-1">ResourceManagementPrivateLinkAssociation#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ResourceManagementPrivateLinkAssociationState<'ManagementGroupId, 'PublicNetworkAccessEnabled, 'ResourceManagementPrivateLinkId>, value: string) : ResourceManagementPrivateLinkAssociationState<'ManagementGroupId, 'PublicNetworkAccessEnabled, 'ResourceManagementPrivateLinkId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : ResourceManagementPrivateLinkAssociationState<'ManagementGroupId, 'PublicNetworkAccessEnabled, 'ResourceManagementPrivateLinkId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_management_private_link_association#timeouts-1">ResourceManagementPrivateLinkAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ResourceManagementPrivateLinkAssociationState<'ManagementGroupId, 'PublicNetworkAccessEnabled, 'ResourceManagementPrivateLinkId>, value: azurerm.ResourceManagementPrivateLinkAssociation.ResourceManagementPrivateLinkAssociationTimeouts) : ResourceManagementPrivateLinkAssociationState<'ManagementGroupId, 'PublicNetworkAccessEnabled, 'ResourceManagementPrivateLinkId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ResourceManagementPrivateLinkAssociationState<'ManagementGroupId, 'PublicNetworkAccessEnabled, 'ResourceManagementPrivateLinkId>

        member _.Run(state: ResourceManagementPrivateLinkAssociationState<Present, Present, Present>) : azurerm.ResourceManagementPrivateLinkAssociation.ResourceManagementPrivateLinkAssociation =
            let config = azurerm.ResourceManagementPrivateLinkAssociation.ResourceManagementPrivateLinkAssociationConfig()
            for setter in state.assignments do
                setter config
            azurerm.ResourceManagementPrivateLinkAssociation.ResourceManagementPrivateLinkAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.resourceManagementPrivateLinkAssociation: missing required arguments. Must call: management_group_id, public_network_access_enabled, resource_management_private_link_id.", 9999, IsError = true)>]
        member _.Run(_: ResourceManagementPrivateLinkAssociationState<_, _, _>) : azurerm.ResourceManagementPrivateLinkAssociation.ResourceManagementPrivateLinkAssociation =
            Unchecked.defaultof<azurerm.ResourceManagementPrivateLinkAssociation.ResourceManagementPrivateLinkAssociation>
