namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermBastionHostState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermBastionHost.DataAzurermBastionHostConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/bastion_host">azurerm_bastion_host</a>.
    /// </summary>
    type DataAzurermBastionHostBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermBastionHostState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermBastionHostState<Missing, Missing>)

        member _.Zero(()) : DataAzurermBastionHostState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermBastionHostState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/bastion_host#name-1">DataAzurermBastionHost#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermBastionHostState<Missing, 'ResourceGroupName>, value: string) : DataAzurermBastionHostState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermBastionHostState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/bastion_host#resource_group_name-1">DataAzurermBastionHost#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermBastionHostState<'Name, Missing>, value: string) : DataAzurermBastionHostState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermBastionHostState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/bastion_host#id-1">DataAzurermBastionHost#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermBastionHostState<'Name, 'ResourceGroupName>, value: string) : DataAzurermBastionHostState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermBastionHostState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/bastion_host#timeouts-1">DataAzurermBastionHost#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermBastionHostState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermBastionHost.DataAzurermBastionHostTimeouts) : DataAzurermBastionHostState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermBastionHostState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermBastionHostState<Present, Present>) : azurerm.DataAzurermBastionHost.DataAzurermBastionHost =
            let config = azurerm.DataAzurermBastionHost.DataAzurermBastionHostConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermBastionHost.DataAzurermBastionHost(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermBastionHost: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermBastionHostState<_, _>) : azurerm.DataAzurermBastionHost.DataAzurermBastionHost =
            Unchecked.defaultof<azurerm.DataAzurermBastionHost.DataAzurermBastionHost>
