namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermMssqlElasticpoolState<'Name, 'ResourceGroupName, 'ServerName> = { assignments: ResizeArray<azurerm.DataAzurermMssqlElasticpool.DataAzurermMssqlElasticpoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_elasticpool">azurerm_mssql_elasticpool</a>.
    /// </summary>
    type DataAzurermMssqlElasticpoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermMssqlElasticpoolState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMssqlElasticpoolState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermMssqlElasticpoolState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMssqlElasticpoolState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_elasticpool#name-1">DataAzurermMssqlElasticpool#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermMssqlElasticpoolState<Missing, 'ResourceGroupName, 'ServerName>, value: string) : DataAzurermMssqlElasticpoolState<Present, 'ResourceGroupName, 'ServerName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermMssqlElasticpoolState<Present, 'ResourceGroupName, 'ServerName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_elasticpool#resource_group_name-1">DataAzurermMssqlElasticpool#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermMssqlElasticpoolState<'Name, Missing, 'ServerName>, value: string) : DataAzurermMssqlElasticpoolState<'Name, Present, 'ServerName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermMssqlElasticpoolState<'Name, Present, 'ServerName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_elasticpool#server_name-1">DataAzurermMssqlElasticpool#server_name</a>.
        /// </summary>
        [<CustomOperation "server_name">]
        member _.ServerName(state: DataAzurermMssqlElasticpoolState<'Name, 'ResourceGroupName, Missing>, value: string) : DataAzurermMssqlElasticpoolState<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ServerName <- value)
            ({ assignments = state.assignments } : DataAzurermMssqlElasticpoolState<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_elasticpool#id-1">DataAzurermMssqlElasticpool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermMssqlElasticpoolState<'Name, 'ResourceGroupName, 'ServerName>, value: string) : DataAzurermMssqlElasticpoolState<'Name, 'ResourceGroupName, 'ServerName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermMssqlElasticpoolState<'Name, 'ResourceGroupName, 'ServerName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_elasticpool#timeouts-1">DataAzurermMssqlElasticpool#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermMssqlElasticpoolState<'Name, 'ResourceGroupName, 'ServerName>, value: azurerm.DataAzurermMssqlElasticpool.DataAzurermMssqlElasticpoolTimeouts) : DataAzurermMssqlElasticpoolState<'Name, 'ResourceGroupName, 'ServerName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermMssqlElasticpoolState<'Name, 'ResourceGroupName, 'ServerName>

        member _.Run(state: DataAzurermMssqlElasticpoolState<Present, Present, Present>) : azurerm.DataAzurermMssqlElasticpool.DataAzurermMssqlElasticpool =
            let config = azurerm.DataAzurermMssqlElasticpool.DataAzurermMssqlElasticpoolConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermMssqlElasticpool.DataAzurermMssqlElasticpool(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermMssqlElasticpool: missing required arguments. Must call: name, resource_group_name, server_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermMssqlElasticpoolState<_, _, _>) : azurerm.DataAzurermMssqlElasticpool.DataAzurermMssqlElasticpool =
            Unchecked.defaultof<azurerm.DataAzurermMssqlElasticpool.DataAzurermMssqlElasticpool>
