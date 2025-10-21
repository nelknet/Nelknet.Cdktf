namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CosmosdbTableState<'AccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.CosmosdbTable.CosmosdbTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_table">azurerm_cosmosdb_table</a>.
    /// </summary>
    type CosmosdbTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : CosmosdbTableState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbTableState<Missing, Missing, Missing>)

        member _.Zero(()) : CosmosdbTableState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbTableState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_table#account_name-1">CosmosdbTable#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: CosmosdbTableState<Missing, 'Name, 'ResourceGroupName>, value: string) : CosmosdbTableState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : CosmosdbTableState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_table#name-1">CosmosdbTable#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CosmosdbTableState<'AccountName, Missing, 'ResourceGroupName>, value: string) : CosmosdbTableState<'AccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CosmosdbTableState<'AccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_table#resource_group_name-1">CosmosdbTable#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: CosmosdbTableState<'AccountName, 'Name, Missing>, value: string) : CosmosdbTableState<'AccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : CosmosdbTableState<'AccountName, 'Name, Present>)

        /// <summary>
        /// autoscale_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_table#autoscale_settings-1">CosmosdbTable#autoscale_settings</a>
        /// </summary>
        [<CustomOperation "autoscale_settings">]
        member _.AutoscaleSettings(state: CosmosdbTableState<'AccountName, 'Name, 'ResourceGroupName>, value: azurerm.CosmosdbTable.CosmosdbTableAutoscaleSettings) : CosmosdbTableState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutoscaleSettings <- value)
            state : CosmosdbTableState<'AccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_table#id-1">CosmosdbTable#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CosmosdbTableState<'AccountName, 'Name, 'ResourceGroupName>, value: string) : CosmosdbTableState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CosmosdbTableState<'AccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_table#throughput-1">CosmosdbTable#throughput</a>.
        /// </summary>
        [<CustomOperation "throughput">]
        member _.Throughput(state: CosmosdbTableState<'AccountName, 'Name, 'ResourceGroupName>, value: double) : CosmosdbTableState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Throughput <- value)
            state : CosmosdbTableState<'AccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_table#timeouts-1">CosmosdbTable#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CosmosdbTableState<'AccountName, 'Name, 'ResourceGroupName>, value: azurerm.CosmosdbTable.CosmosdbTableTimeouts) : CosmosdbTableState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CosmosdbTableState<'AccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: CosmosdbTableState<Present, Present, Present>) : azurerm.CosmosdbTable.CosmosdbTable =
            let config = azurerm.CosmosdbTable.CosmosdbTableConfig()
            for setter in state.assignments do
                setter config
            azurerm.CosmosdbTable.CosmosdbTable(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cosmosdbTable: missing required arguments. Must call: account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: CosmosdbTableState<_, _, _>) : azurerm.CosmosdbTable.CosmosdbTable =
            Unchecked.defaultof<azurerm.CosmosdbTable.CosmosdbTable>
