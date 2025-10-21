namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatabricksAccessConnectorState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DatabricksAccessConnector.DatabricksAccessConnectorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_access_connector">azurerm_databricks_access_connector</a>.
    /// </summary>
    type DatabricksAccessConnectorBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatabricksAccessConnectorState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatabricksAccessConnectorState<Missing, Missing, Missing>)

        member _.Zero(()) : DatabricksAccessConnectorState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatabricksAccessConnectorState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_access_connector#location-1">DatabricksAccessConnector#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DatabricksAccessConnectorState<Missing, 'Name, 'ResourceGroupName>, value: string) : DatabricksAccessConnectorState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DatabricksAccessConnectorState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_access_connector#name-1">DatabricksAccessConnector#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DatabricksAccessConnectorState<'Location, Missing, 'ResourceGroupName>, value: string) : DatabricksAccessConnectorState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DatabricksAccessConnectorState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_access_connector#resource_group_name-1">DatabricksAccessConnector#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DatabricksAccessConnectorState<'Location, 'Name, Missing>, value: string) : DatabricksAccessConnectorState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DatabricksAccessConnectorState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_access_connector#id-1">DatabricksAccessConnector#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DatabricksAccessConnectorState<'Location, 'Name, 'ResourceGroupName>, value: string) : DatabricksAccessConnectorState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DatabricksAccessConnectorState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_access_connector#identity-1">DatabricksAccessConnector#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: DatabricksAccessConnectorState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.DatabricksAccessConnector.DatabricksAccessConnectorIdentity) : DatabricksAccessConnectorState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : DatabricksAccessConnectorState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_access_connector#tags-1">DatabricksAccessConnector#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DatabricksAccessConnectorState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : DatabricksAccessConnectorState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DatabricksAccessConnectorState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_access_connector#timeouts-1">DatabricksAccessConnector#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DatabricksAccessConnectorState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.DatabricksAccessConnector.DatabricksAccessConnectorTimeouts) : DatabricksAccessConnectorState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DatabricksAccessConnectorState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: DatabricksAccessConnectorState<Present, Present, Present>) : azurerm.DatabricksAccessConnector.DatabricksAccessConnector =
            let config = azurerm.DatabricksAccessConnector.DatabricksAccessConnectorConfig()
            for setter in state.assignments do
                setter config
            azurerm.DatabricksAccessConnector.DatabricksAccessConnector(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.databricksAccessConnector: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DatabricksAccessConnectorState<_, _, _>) : azurerm.DatabricksAccessConnector.DatabricksAccessConnector =
            Unchecked.defaultof<azurerm.DatabricksAccessConnector.DatabricksAccessConnector>
