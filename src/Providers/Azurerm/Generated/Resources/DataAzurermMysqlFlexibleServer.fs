namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermMysqlFlexibleServerState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermMysqlFlexibleServer.DataAzurermMysqlFlexibleServerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mysql_flexible_server">azurerm_mysql_flexible_server</a>.
    /// </summary>
    type DataAzurermMysqlFlexibleServerBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermMysqlFlexibleServerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMysqlFlexibleServerState<Missing, Missing>)

        member _.Zero(()) : DataAzurermMysqlFlexibleServerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMysqlFlexibleServerState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mysql_flexible_server#name-1">DataAzurermMysqlFlexibleServer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermMysqlFlexibleServerState<Missing, 'ResourceGroupName>, value: string) : DataAzurermMysqlFlexibleServerState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermMysqlFlexibleServerState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mysql_flexible_server#resource_group_name-1">DataAzurermMysqlFlexibleServer#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermMysqlFlexibleServerState<'Name, Missing>, value: string) : DataAzurermMysqlFlexibleServerState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermMysqlFlexibleServerState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mysql_flexible_server#id-1">DataAzurermMysqlFlexibleServer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermMysqlFlexibleServerState<'Name, 'ResourceGroupName>, value: string) : DataAzurermMysqlFlexibleServerState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermMysqlFlexibleServerState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mysql_flexible_server#timeouts-1">DataAzurermMysqlFlexibleServer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermMysqlFlexibleServerState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermMysqlFlexibleServer.DataAzurermMysqlFlexibleServerTimeouts) : DataAzurermMysqlFlexibleServerState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermMysqlFlexibleServerState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermMysqlFlexibleServerState<Present, Present>) : azurerm.DataAzurermMysqlFlexibleServer.DataAzurermMysqlFlexibleServer =
            let config = azurerm.DataAzurermMysqlFlexibleServer.DataAzurermMysqlFlexibleServerConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermMysqlFlexibleServer.DataAzurermMysqlFlexibleServer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermMysqlFlexibleServer: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermMysqlFlexibleServerState<_, _>) : azurerm.DataAzurermMysqlFlexibleServer.DataAzurermMysqlFlexibleServer =
            Unchecked.defaultof<azurerm.DataAzurermMysqlFlexibleServer.DataAzurermMysqlFlexibleServer>
