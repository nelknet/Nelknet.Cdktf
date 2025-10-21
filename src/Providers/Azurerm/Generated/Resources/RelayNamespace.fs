namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RelayNamespaceState<'Location, 'Name, 'ResourceGroupName, 'SkuName> = { assignments: ResizeArray<azurerm.RelayNamespace.RelayNamespaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_namespace">azurerm_relay_namespace</a>.
    /// </summary>
    type RelayNamespaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : RelayNamespaceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RelayNamespaceState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : RelayNamespaceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RelayNamespaceState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_namespace#location-1">RelayNamespace#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: RelayNamespaceState<Missing, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : RelayNamespaceState<Present, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : RelayNamespaceState<Present, 'Name, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_namespace#name-1">RelayNamespace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RelayNamespaceState<'Location, Missing, 'ResourceGroupName, 'SkuName>, value: string) : RelayNamespaceState<'Location, Present, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RelayNamespaceState<'Location, Present, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_namespace#resource_group_name-1">RelayNamespace#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: RelayNamespaceState<'Location, 'Name, Missing, 'SkuName>, value: string) : RelayNamespaceState<'Location, 'Name, Present, 'SkuName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : RelayNamespaceState<'Location, 'Name, Present, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_namespace#sku_name-1">RelayNamespace#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: RelayNamespaceState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : RelayNamespaceState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : RelayNamespaceState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_namespace#id-1">RelayNamespace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RelayNamespaceState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : RelayNamespaceState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RelayNamespaceState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_namespace#tags-1">RelayNamespace#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RelayNamespaceState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: seq<string * string>) : RelayNamespaceState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RelayNamespaceState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_namespace#timeouts-1">RelayNamespace#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RelayNamespaceState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: azurerm.RelayNamespace.RelayNamespaceTimeouts) : RelayNamespaceState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RelayNamespaceState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        member _.Run(state: RelayNamespaceState<Present, Present, Present, Present>) : azurerm.RelayNamespace.RelayNamespace =
            let config = azurerm.RelayNamespace.RelayNamespaceConfig()
            for setter in state.assignments do
                setter config
            azurerm.RelayNamespace.RelayNamespace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.relayNamespace: missing required arguments. Must call: location, name, resource_group_name, sku_name.", 9999, IsError = true)>]
        member _.Run(_: RelayNamespaceState<_, _, _, _>) : azurerm.RelayNamespace.RelayNamespace =
            Unchecked.defaultof<azurerm.RelayNamespace.RelayNamespace>
