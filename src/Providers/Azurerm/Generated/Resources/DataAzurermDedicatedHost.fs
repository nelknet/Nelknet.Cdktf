namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDedicatedHostState<'DedicatedHostGroupName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermDedicatedHost.DataAzurermDedicatedHostConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dedicated_host">azurerm_dedicated_host</a>.
    /// </summary>
    type DataAzurermDedicatedHostBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDedicatedHostState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDedicatedHostState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermDedicatedHostState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDedicatedHostState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dedicated_host#dedicated_host_group_name-1">DataAzurermDedicatedHost#dedicated_host_group_name</a>.
        /// </summary>
        [<CustomOperation "dedicated_host_group_name">]
        member _.DedicatedHostGroupName(state: DataAzurermDedicatedHostState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataAzurermDedicatedHostState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DedicatedHostGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermDedicatedHostState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dedicated_host#name-1">DataAzurermDedicatedHost#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDedicatedHostState<'DedicatedHostGroupName, Missing, 'ResourceGroupName>, value: string) : DataAzurermDedicatedHostState<'DedicatedHostGroupName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDedicatedHostState<'DedicatedHostGroupName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dedicated_host#resource_group_name-1">DataAzurermDedicatedHost#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermDedicatedHostState<'DedicatedHostGroupName, 'Name, Missing>, value: string) : DataAzurermDedicatedHostState<'DedicatedHostGroupName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermDedicatedHostState<'DedicatedHostGroupName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dedicated_host#id-1">DataAzurermDedicatedHost#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDedicatedHostState<'DedicatedHostGroupName, 'Name, 'ResourceGroupName>, value: string) : DataAzurermDedicatedHostState<'DedicatedHostGroupName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDedicatedHostState<'DedicatedHostGroupName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dedicated_host#timeouts-1">DataAzurermDedicatedHost#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDedicatedHostState<'DedicatedHostGroupName, 'Name, 'ResourceGroupName>, value: azurerm.DataAzurermDedicatedHost.DataAzurermDedicatedHostTimeouts) : DataAzurermDedicatedHostState<'DedicatedHostGroupName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDedicatedHostState<'DedicatedHostGroupName, 'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermDedicatedHostState<Present, Present, Present>) : azurerm.DataAzurermDedicatedHost.DataAzurermDedicatedHost =
            let config = azurerm.DataAzurermDedicatedHost.DataAzurermDedicatedHostConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDedicatedHost.DataAzurermDedicatedHost(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDedicatedHost: missing required arguments. Must call: dedicated_host_group_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDedicatedHostState<_, _, _>) : azurerm.DataAzurermDedicatedHost.DataAzurermDedicatedHost =
            Unchecked.defaultof<azurerm.DataAzurermDedicatedHost.DataAzurermDedicatedHost>
