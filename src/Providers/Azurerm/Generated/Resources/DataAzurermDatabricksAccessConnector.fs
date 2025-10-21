namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDatabricksAccessConnectorState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermDatabricksAccessConnector.DataAzurermDatabricksAccessConnectorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/databricks_access_connector">azurerm_databricks_access_connector</a>.
    /// </summary>
    type DataAzurermDatabricksAccessConnectorBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDatabricksAccessConnectorState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDatabricksAccessConnectorState<Missing, Missing>)

        member _.Zero(()) : DataAzurermDatabricksAccessConnectorState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDatabricksAccessConnectorState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/databricks_access_connector#name-1">DataAzurermDatabricksAccessConnector#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDatabricksAccessConnectorState<Missing, 'ResourceGroupName>, value: string) : DataAzurermDatabricksAccessConnectorState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDatabricksAccessConnectorState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/databricks_access_connector#resource_group_name-1">DataAzurermDatabricksAccessConnector#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermDatabricksAccessConnectorState<'Name, Missing>, value: string) : DataAzurermDatabricksAccessConnectorState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermDatabricksAccessConnectorState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/databricks_access_connector#id-1">DataAzurermDatabricksAccessConnector#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDatabricksAccessConnectorState<'Name, 'ResourceGroupName>, value: string) : DataAzurermDatabricksAccessConnectorState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDatabricksAccessConnectorState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/databricks_access_connector#timeouts-1">DataAzurermDatabricksAccessConnector#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDatabricksAccessConnectorState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermDatabricksAccessConnector.DataAzurermDatabricksAccessConnectorTimeouts) : DataAzurermDatabricksAccessConnectorState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDatabricksAccessConnectorState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermDatabricksAccessConnectorState<Present, Present>) : azurerm.DataAzurermDatabricksAccessConnector.DataAzurermDatabricksAccessConnector =
            let config = azurerm.DataAzurermDatabricksAccessConnector.DataAzurermDatabricksAccessConnectorConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDatabricksAccessConnector.DataAzurermDatabricksAccessConnector(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDatabricksAccessConnector: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDatabricksAccessConnectorState<_, _>) : azurerm.DataAzurermDatabricksAccessConnector.DataAzurermDatabricksAccessConnector =
            Unchecked.defaultof<azurerm.DataAzurermDatabricksAccessConnector.DataAzurermDatabricksAccessConnector>
