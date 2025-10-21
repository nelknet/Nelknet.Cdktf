namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ContainerRegistryAgentPoolState<'ContainerRegistryName, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ContainerRegistryAgentPool.ContainerRegistryAgentPoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_agent_pool">azurerm_container_registry_agent_pool</a>.
    /// </summary>
    type ContainerRegistryAgentPoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : ContainerRegistryAgentPoolState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerRegistryAgentPoolState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ContainerRegistryAgentPoolState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerRegistryAgentPoolState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_agent_pool#container_registry_name-1">ContainerRegistryAgentPool#container_registry_name</a>.
        /// </summary>
        [<CustomOperation "container_registry_name">]
        member _.ContainerRegistryName(state: ContainerRegistryAgentPoolState<Missing, 'Location, 'Name, 'ResourceGroupName>, value: string) : ContainerRegistryAgentPoolState<Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ContainerRegistryName <- value)
            ({ assignments = state.assignments } : ContainerRegistryAgentPoolState<Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_agent_pool#location-1">ContainerRegistryAgentPool#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ContainerRegistryAgentPoolState<'ContainerRegistryName, Missing, 'Name, 'ResourceGroupName>, value: string) : ContainerRegistryAgentPoolState<'ContainerRegistryName, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ContainerRegistryAgentPoolState<'ContainerRegistryName, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_agent_pool#name-1">ContainerRegistryAgentPool#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ContainerRegistryAgentPoolState<'ContainerRegistryName, 'Location, Missing, 'ResourceGroupName>, value: string) : ContainerRegistryAgentPoolState<'ContainerRegistryName, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ContainerRegistryAgentPoolState<'ContainerRegistryName, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_agent_pool#resource_group_name-1">ContainerRegistryAgentPool#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ContainerRegistryAgentPoolState<'ContainerRegistryName, 'Location, 'Name, Missing>, value: string) : ContainerRegistryAgentPoolState<'ContainerRegistryName, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ContainerRegistryAgentPoolState<'ContainerRegistryName, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_agent_pool#id-1">ContainerRegistryAgentPool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ContainerRegistryAgentPoolState<'ContainerRegistryName, 'Location, 'Name, 'ResourceGroupName>, value: string) : ContainerRegistryAgentPoolState<'ContainerRegistryName, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ContainerRegistryAgentPoolState<'ContainerRegistryName, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_agent_pool#instance_count-1">ContainerRegistryAgentPool#instance_count</a>.
        /// </summary>
        [<CustomOperation "instance_count">]
        member _.InstanceCount(state: ContainerRegistryAgentPoolState<'ContainerRegistryName, 'Location, 'Name, 'ResourceGroupName>, value: double) : ContainerRegistryAgentPoolState<'ContainerRegistryName, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InstanceCount <- value)
            state : ContainerRegistryAgentPoolState<'ContainerRegistryName, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_agent_pool#tags-1">ContainerRegistryAgentPool#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ContainerRegistryAgentPoolState<'ContainerRegistryName, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : ContainerRegistryAgentPoolState<'ContainerRegistryName, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ContainerRegistryAgentPoolState<'ContainerRegistryName, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_agent_pool#tier-1">ContainerRegistryAgentPool#tier</a>.
        /// </summary>
        [<CustomOperation "tier">]
        member _.Tier(state: ContainerRegistryAgentPoolState<'ContainerRegistryName, 'Location, 'Name, 'ResourceGroupName>, value: string) : ContainerRegistryAgentPoolState<'ContainerRegistryName, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tier <- value)
            state : ContainerRegistryAgentPoolState<'ContainerRegistryName, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_agent_pool#timeouts-1">ContainerRegistryAgentPool#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ContainerRegistryAgentPoolState<'ContainerRegistryName, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.ContainerRegistryAgentPool.ContainerRegistryAgentPoolTimeouts) : ContainerRegistryAgentPoolState<'ContainerRegistryName, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ContainerRegistryAgentPoolState<'ContainerRegistryName, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_agent_pool#virtual_network_subnet_id-1">ContainerRegistryAgentPool#virtual_network_subnet_id</a>.
        /// </summary>
        [<CustomOperation "virtual_network_subnet_id">]
        member _.VirtualNetworkSubnetId(state: ContainerRegistryAgentPoolState<'ContainerRegistryName, 'Location, 'Name, 'ResourceGroupName>, value: string) : ContainerRegistryAgentPoolState<'ContainerRegistryName, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.VirtualNetworkSubnetId <- value)
            state : ContainerRegistryAgentPoolState<'ContainerRegistryName, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: ContainerRegistryAgentPoolState<Present, Present, Present, Present>) : azurerm.ContainerRegistryAgentPool.ContainerRegistryAgentPool =
            let config = azurerm.ContainerRegistryAgentPool.ContainerRegistryAgentPoolConfig()
            for setter in state.assignments do
                setter config
            azurerm.ContainerRegistryAgentPool.ContainerRegistryAgentPool(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.containerRegistryAgentPool: missing required arguments. Must call: container_registry_name, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ContainerRegistryAgentPoolState<_, _, _, _>) : azurerm.ContainerRegistryAgentPool.ContainerRegistryAgentPool =
            Unchecked.defaultof<azurerm.ContainerRegistryAgentPool.ContainerRegistryAgentPool>
