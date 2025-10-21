namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EventhubClusterState<'Location, 'Name, 'ResourceGroupName, 'SkuName> = { assignments: ResizeArray<azurerm.EventhubCluster.EventhubClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_cluster">azurerm_eventhub_cluster</a>.
    /// </summary>
    type EventhubClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : EventhubClusterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EventhubClusterState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : EventhubClusterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EventhubClusterState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_cluster#location-1">EventhubCluster#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: EventhubClusterState<Missing, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : EventhubClusterState<Present, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : EventhubClusterState<Present, 'Name, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_cluster#name-1">EventhubCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EventhubClusterState<'Location, Missing, 'ResourceGroupName, 'SkuName>, value: string) : EventhubClusterState<'Location, Present, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EventhubClusterState<'Location, Present, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_cluster#resource_group_name-1">EventhubCluster#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: EventhubClusterState<'Location, 'Name, Missing, 'SkuName>, value: string) : EventhubClusterState<'Location, 'Name, Present, 'SkuName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : EventhubClusterState<'Location, 'Name, Present, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_cluster#sku_name-1">EventhubCluster#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: EventhubClusterState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : EventhubClusterState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : EventhubClusterState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_cluster#id-1">EventhubCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EventhubClusterState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : EventhubClusterState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EventhubClusterState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_cluster#tags-1">EventhubCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EventhubClusterState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: seq<string * string>) : EventhubClusterState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EventhubClusterState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_cluster#timeouts-1">EventhubCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EventhubClusterState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: azurerm.EventhubCluster.EventhubClusterTimeouts) : EventhubClusterState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EventhubClusterState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        member _.Run(state: EventhubClusterState<Present, Present, Present, Present>) : azurerm.EventhubCluster.EventhubCluster =
            let config = azurerm.EventhubCluster.EventhubClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.EventhubCluster.EventhubCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.eventhubCluster: missing required arguments. Must call: location, name, resource_group_name, sku_name.", 9999, IsError = true)>]
        member _.Run(_: EventhubClusterState<_, _, _, _>) : azurerm.EventhubCluster.EventhubCluster =
            Unchecked.defaultof<azurerm.EventhubCluster.EventhubCluster>
