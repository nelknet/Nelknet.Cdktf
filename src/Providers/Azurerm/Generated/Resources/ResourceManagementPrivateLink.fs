namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ResourceManagementPrivateLinkState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ResourceManagementPrivateLink.ResourceManagementPrivateLinkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_management_private_link">azurerm_resource_management_private_link</a>.
    /// </summary>
    type ResourceManagementPrivateLinkBuilder(logicalId: string) =
        member _.Yield(_: unit) : ResourceManagementPrivateLinkState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourceManagementPrivateLinkState<Missing, Missing, Missing>)

        member _.Zero(()) : ResourceManagementPrivateLinkState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourceManagementPrivateLinkState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_management_private_link#location-1">ResourceManagementPrivateLink#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ResourceManagementPrivateLinkState<Missing, 'Name, 'ResourceGroupName>, value: string) : ResourceManagementPrivateLinkState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ResourceManagementPrivateLinkState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_management_private_link#name-1">ResourceManagementPrivateLink#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ResourceManagementPrivateLinkState<'Location, Missing, 'ResourceGroupName>, value: string) : ResourceManagementPrivateLinkState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ResourceManagementPrivateLinkState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_management_private_link#resource_group_name-1">ResourceManagementPrivateLink#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ResourceManagementPrivateLinkState<'Location, 'Name, Missing>, value: string) : ResourceManagementPrivateLinkState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ResourceManagementPrivateLinkState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_management_private_link#id-1">ResourceManagementPrivateLink#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ResourceManagementPrivateLinkState<'Location, 'Name, 'ResourceGroupName>, value: string) : ResourceManagementPrivateLinkState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ResourceManagementPrivateLinkState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_management_private_link#timeouts-1">ResourceManagementPrivateLink#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ResourceManagementPrivateLinkState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.ResourceManagementPrivateLink.ResourceManagementPrivateLinkTimeouts) : ResourceManagementPrivateLinkState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ResourceManagementPrivateLinkState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: ResourceManagementPrivateLinkState<Present, Present, Present>) : azurerm.ResourceManagementPrivateLink.ResourceManagementPrivateLink =
            let config = azurerm.ResourceManagementPrivateLink.ResourceManagementPrivateLinkConfig()
            for setter in state.assignments do
                setter config
            azurerm.ResourceManagementPrivateLink.ResourceManagementPrivateLink(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.resourceManagementPrivateLink: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ResourceManagementPrivateLinkState<_, _, _>) : azurerm.ResourceManagementPrivateLink.ResourceManagementPrivateLink =
            Unchecked.defaultof<azurerm.ResourceManagementPrivateLink.ResourceManagementPrivateLink>
