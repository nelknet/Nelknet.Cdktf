namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ExtendedCustomLocationState<'ClusterExtensionIds, 'HostResourceId, 'Location, 'Name, 'Namespace, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ExtendedCustomLocation.ExtendedCustomLocationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/extended_custom_location">azurerm_extended_custom_location</a>.
    /// </summary>
    type ExtendedCustomLocationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ExtendedCustomLocationState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ExtendedCustomLocationState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ExtendedCustomLocationState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ExtendedCustomLocationState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/extended_custom_location#cluster_extension_ids-1">ExtendedCustomLocation#cluster_extension_ids</a>.
        /// </summary>
        [<CustomOperation "cluster_extension_ids">]
        member _.ClusterExtensionIds(state: ExtendedCustomLocationState<Missing, 'HostResourceId, 'Location, 'Name, 'Namespace, 'ResourceGroupName>, value: seq<string>) : ExtendedCustomLocationState<Present, 'HostResourceId, 'Location, 'Name, 'Namespace, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClusterExtensionIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : ExtendedCustomLocationState<Present, 'HostResourceId, 'Location, 'Name, 'Namespace, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/extended_custom_location#host_resource_id-1">ExtendedCustomLocation#host_resource_id</a>.
        /// </summary>
        [<CustomOperation "host_resource_id">]
        member _.HostResourceId(state: ExtendedCustomLocationState<'ClusterExtensionIds, Missing, 'Location, 'Name, 'Namespace, 'ResourceGroupName>, value: string) : ExtendedCustomLocationState<'ClusterExtensionIds, Present, 'Location, 'Name, 'Namespace, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HostResourceId <- value)
            ({ assignments = state.assignments } : ExtendedCustomLocationState<'ClusterExtensionIds, Present, 'Location, 'Name, 'Namespace, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/extended_custom_location#location-1">ExtendedCustomLocation#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ExtendedCustomLocationState<'ClusterExtensionIds, 'HostResourceId, Missing, 'Name, 'Namespace, 'ResourceGroupName>, value: string) : ExtendedCustomLocationState<'ClusterExtensionIds, 'HostResourceId, Present, 'Name, 'Namespace, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ExtendedCustomLocationState<'ClusterExtensionIds, 'HostResourceId, Present, 'Name, 'Namespace, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/extended_custom_location#name-1">ExtendedCustomLocation#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ExtendedCustomLocationState<'ClusterExtensionIds, 'HostResourceId, 'Location, Missing, 'Namespace, 'ResourceGroupName>, value: string) : ExtendedCustomLocationState<'ClusterExtensionIds, 'HostResourceId, 'Location, Present, 'Namespace, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ExtendedCustomLocationState<'ClusterExtensionIds, 'HostResourceId, 'Location, Present, 'Namespace, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/extended_custom_location#namespace-1">ExtendedCustomLocation#namespace</a>.
        /// </summary>
        [<CustomOperation "namespace">]
        member _.Namespace(state: ExtendedCustomLocationState<'ClusterExtensionIds, 'HostResourceId, 'Location, 'Name, Missing, 'ResourceGroupName>, value: string) : ExtendedCustomLocationState<'ClusterExtensionIds, 'HostResourceId, 'Location, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Namespace <- value)
            ({ assignments = state.assignments } : ExtendedCustomLocationState<'ClusterExtensionIds, 'HostResourceId, 'Location, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/extended_custom_location#resource_group_name-1">ExtendedCustomLocation#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ExtendedCustomLocationState<'ClusterExtensionIds, 'HostResourceId, 'Location, 'Name, 'Namespace, Missing>, value: string) : ExtendedCustomLocationState<'ClusterExtensionIds, 'HostResourceId, 'Location, 'Name, 'Namespace, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ExtendedCustomLocationState<'ClusterExtensionIds, 'HostResourceId, 'Location, 'Name, 'Namespace, Present>)

        /// <summary>
        /// authentication block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/extended_custom_location#authentication-1">ExtendedCustomLocation#authentication</a>
        /// </summary>
        [<CustomOperation "authentication">]
        member _.Authentication(state: ExtendedCustomLocationState<'ClusterExtensionIds, 'HostResourceId, 'Location, 'Name, 'Namespace, 'ResourceGroupName>, value: azurerm.ExtendedCustomLocation.ExtendedCustomLocationAuthentication) : ExtendedCustomLocationState<'ClusterExtensionIds, 'HostResourceId, 'Location, 'Name, 'Namespace, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Authentication <- value)
            state : ExtendedCustomLocationState<'ClusterExtensionIds, 'HostResourceId, 'Location, 'Name, 'Namespace, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/extended_custom_location#display_name-1">ExtendedCustomLocation#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: ExtendedCustomLocationState<'ClusterExtensionIds, 'HostResourceId, 'Location, 'Name, 'Namespace, 'ResourceGroupName>, value: string) : ExtendedCustomLocationState<'ClusterExtensionIds, 'HostResourceId, 'Location, 'Name, 'Namespace, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : ExtendedCustomLocationState<'ClusterExtensionIds, 'HostResourceId, 'Location, 'Name, 'Namespace, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/extended_custom_location#host_type-1">ExtendedCustomLocation#host_type</a>.
        /// </summary>
        [<CustomOperation "host_type">]
        member _.HostType(state: ExtendedCustomLocationState<'ClusterExtensionIds, 'HostResourceId, 'Location, 'Name, 'Namespace, 'ResourceGroupName>, value: string) : ExtendedCustomLocationState<'ClusterExtensionIds, 'HostResourceId, 'Location, 'Name, 'Namespace, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HostType <- value)
            state : ExtendedCustomLocationState<'ClusterExtensionIds, 'HostResourceId, 'Location, 'Name, 'Namespace, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/extended_custom_location#id-1">ExtendedCustomLocation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ExtendedCustomLocationState<'ClusterExtensionIds, 'HostResourceId, 'Location, 'Name, 'Namespace, 'ResourceGroupName>, value: string) : ExtendedCustomLocationState<'ClusterExtensionIds, 'HostResourceId, 'Location, 'Name, 'Namespace, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ExtendedCustomLocationState<'ClusterExtensionIds, 'HostResourceId, 'Location, 'Name, 'Namespace, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/extended_custom_location#timeouts-1">ExtendedCustomLocation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ExtendedCustomLocationState<'ClusterExtensionIds, 'HostResourceId, 'Location, 'Name, 'Namespace, 'ResourceGroupName>, value: azurerm.ExtendedCustomLocation.ExtendedCustomLocationTimeouts) : ExtendedCustomLocationState<'ClusterExtensionIds, 'HostResourceId, 'Location, 'Name, 'Namespace, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ExtendedCustomLocationState<'ClusterExtensionIds, 'HostResourceId, 'Location, 'Name, 'Namespace, 'ResourceGroupName>

        member _.Run(state: ExtendedCustomLocationState<Present, Present, Present, Present, Present, Present>) : azurerm.ExtendedCustomLocation.ExtendedCustomLocation =
            let config = azurerm.ExtendedCustomLocation.ExtendedCustomLocationConfig()
            for setter in state.assignments do
                setter config
            azurerm.ExtendedCustomLocation.ExtendedCustomLocation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.extendedCustomLocation: missing required arguments. Must call: cluster_extension_ids, host_resource_id, location, name, namespace, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ExtendedCustomLocationState<_, _, _, _, _, _>) : azurerm.ExtendedCustomLocation.ExtendedCustomLocation =
            Unchecked.defaultof<azurerm.ExtendedCustomLocation.ExtendedCustomLocation>
