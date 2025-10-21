namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermMssqlServerState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermMssqlServer.DataAzurermMssqlServerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_server">azurerm_mssql_server</a>.
    /// </summary>
    type DataAzurermMssqlServerBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermMssqlServerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMssqlServerState<Missing, Missing>)

        member _.Zero(()) : DataAzurermMssqlServerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMssqlServerState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_server#name-1">DataAzurermMssqlServer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermMssqlServerState<Missing, 'ResourceGroupName>, value: string) : DataAzurermMssqlServerState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermMssqlServerState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_server#resource_group_name-1">DataAzurermMssqlServer#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermMssqlServerState<'Name, Missing>, value: string) : DataAzurermMssqlServerState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermMssqlServerState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_server#id-1">DataAzurermMssqlServer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermMssqlServerState<'Name, 'ResourceGroupName>, value: string) : DataAzurermMssqlServerState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermMssqlServerState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_server#timeouts-1">DataAzurermMssqlServer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermMssqlServerState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermMssqlServer.DataAzurermMssqlServerTimeouts) : DataAzurermMssqlServerState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermMssqlServerState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermMssqlServerState<Present, Present>) : azurerm.DataAzurermMssqlServer.DataAzurermMssqlServer =
            let config = azurerm.DataAzurermMssqlServer.DataAzurermMssqlServerConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermMssqlServer.DataAzurermMssqlServer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermMssqlServer: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermMssqlServerState<_, _>) : azurerm.DataAzurermMssqlServer.DataAzurermMssqlServer =
            Unchecked.defaultof<azurerm.DataAzurermMssqlServer.DataAzurermMssqlServer>
