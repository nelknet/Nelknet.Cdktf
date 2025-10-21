namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPostgresqlFlexibleServerState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermPostgresqlFlexibleServer.DataAzurermPostgresqlFlexibleServerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/postgresql_flexible_server">azurerm_postgresql_flexible_server</a>.
    /// </summary>
    type DataAzurermPostgresqlFlexibleServerBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPostgresqlFlexibleServerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPostgresqlFlexibleServerState<Missing, Missing>)

        member _.Zero(()) : DataAzurermPostgresqlFlexibleServerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPostgresqlFlexibleServerState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/postgresql_flexible_server#name-1">DataAzurermPostgresqlFlexibleServer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermPostgresqlFlexibleServerState<Missing, 'ResourceGroupName>, value: string) : DataAzurermPostgresqlFlexibleServerState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermPostgresqlFlexibleServerState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/postgresql_flexible_server#resource_group_name-1">DataAzurermPostgresqlFlexibleServer#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermPostgresqlFlexibleServerState<'Name, Missing>, value: string) : DataAzurermPostgresqlFlexibleServerState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermPostgresqlFlexibleServerState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/postgresql_flexible_server#id-1">DataAzurermPostgresqlFlexibleServer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPostgresqlFlexibleServerState<'Name, 'ResourceGroupName>, value: string) : DataAzurermPostgresqlFlexibleServerState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPostgresqlFlexibleServerState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/postgresql_flexible_server#timeouts-1">DataAzurermPostgresqlFlexibleServer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPostgresqlFlexibleServerState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermPostgresqlFlexibleServer.DataAzurermPostgresqlFlexibleServerTimeouts) : DataAzurermPostgresqlFlexibleServerState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPostgresqlFlexibleServerState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermPostgresqlFlexibleServerState<Present, Present>) : azurerm.DataAzurermPostgresqlFlexibleServer.DataAzurermPostgresqlFlexibleServer =
            let config = azurerm.DataAzurermPostgresqlFlexibleServer.DataAzurermPostgresqlFlexibleServerConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPostgresqlFlexibleServer.DataAzurermPostgresqlFlexibleServer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermPostgresqlFlexibleServer: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermPostgresqlFlexibleServerState<_, _>) : azurerm.DataAzurermPostgresqlFlexibleServer.DataAzurermPostgresqlFlexibleServer =
            Unchecked.defaultof<azurerm.DataAzurermPostgresqlFlexibleServer.DataAzurermPostgresqlFlexibleServer>
