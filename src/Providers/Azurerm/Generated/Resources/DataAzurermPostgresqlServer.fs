namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPostgresqlServerState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermPostgresqlServer.DataAzurermPostgresqlServerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/postgresql_server">azurerm_postgresql_server</a>.
    /// </summary>
    type DataAzurermPostgresqlServerBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPostgresqlServerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPostgresqlServerState<Missing, Missing>)

        member _.Zero(()) : DataAzurermPostgresqlServerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPostgresqlServerState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/postgresql_server#name-1">DataAzurermPostgresqlServer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermPostgresqlServerState<Missing, 'ResourceGroupName>, value: string) : DataAzurermPostgresqlServerState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermPostgresqlServerState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/postgresql_server#resource_group_name-1">DataAzurermPostgresqlServer#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermPostgresqlServerState<'Name, Missing>, value: string) : DataAzurermPostgresqlServerState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermPostgresqlServerState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/postgresql_server#id-1">DataAzurermPostgresqlServer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPostgresqlServerState<'Name, 'ResourceGroupName>, value: string) : DataAzurermPostgresqlServerState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPostgresqlServerState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/postgresql_server#timeouts-1">DataAzurermPostgresqlServer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPostgresqlServerState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermPostgresqlServer.DataAzurermPostgresqlServerTimeouts) : DataAzurermPostgresqlServerState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPostgresqlServerState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermPostgresqlServerState<Present, Present>) : azurerm.DataAzurermPostgresqlServer.DataAzurermPostgresqlServer =
            let config = azurerm.DataAzurermPostgresqlServer.DataAzurermPostgresqlServerConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPostgresqlServer.DataAzurermPostgresqlServer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermPostgresqlServer: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermPostgresqlServerState<_, _>) : azurerm.DataAzurermPostgresqlServer.DataAzurermPostgresqlServer =
            Unchecked.defaultof<azurerm.DataAzurermPostgresqlServer.DataAzurermPostgresqlServer>
