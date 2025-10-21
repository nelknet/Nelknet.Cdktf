namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MssqlJobAgentState<'DatabaseId, 'Location, 'Name> = { assignments: ResizeArray<azurerm.MssqlJobAgent.MssqlJobAgentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_job_agent">azurerm_mssql_job_agent</a>.
    /// </summary>
    type MssqlJobAgentBuilder(logicalId: string) =
        member _.Yield(_: unit) : MssqlJobAgentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlJobAgentState<Missing, Missing, Missing>)

        member _.Zero(()) : MssqlJobAgentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlJobAgentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_job_agent#database_id-1">MssqlJobAgent#database_id</a>.
        /// </summary>
        [<CustomOperation "database_id">]
        member _.DatabaseId(state: MssqlJobAgentState<Missing, 'Location, 'Name>, value: string) : MssqlJobAgentState<Present, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.DatabaseId <- value)
            ({ assignments = state.assignments } : MssqlJobAgentState<Present, 'Location, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_job_agent#location-1">MssqlJobAgent#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MssqlJobAgentState<'DatabaseId, Missing, 'Name>, value: string) : MssqlJobAgentState<'DatabaseId, Present, 'Name> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MssqlJobAgentState<'DatabaseId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_job_agent#name-1">MssqlJobAgent#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MssqlJobAgentState<'DatabaseId, 'Location, Missing>, value: string) : MssqlJobAgentState<'DatabaseId, 'Location, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MssqlJobAgentState<'DatabaseId, 'Location, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_job_agent#id-1">MssqlJobAgent#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MssqlJobAgentState<'DatabaseId, 'Location, 'Name>, value: string) : MssqlJobAgentState<'DatabaseId, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MssqlJobAgentState<'DatabaseId, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_job_agent#tags-1">MssqlJobAgent#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MssqlJobAgentState<'DatabaseId, 'Location, 'Name>, value: seq<string * string>) : MssqlJobAgentState<'DatabaseId, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MssqlJobAgentState<'DatabaseId, 'Location, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_job_agent#timeouts-1">MssqlJobAgent#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MssqlJobAgentState<'DatabaseId, 'Location, 'Name>, value: azurerm.MssqlJobAgent.MssqlJobAgentTimeouts) : MssqlJobAgentState<'DatabaseId, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MssqlJobAgentState<'DatabaseId, 'Location, 'Name>

        member _.Run(state: MssqlJobAgentState<Present, Present, Present>) : azurerm.MssqlJobAgent.MssqlJobAgent =
            let config = azurerm.MssqlJobAgent.MssqlJobAgentConfig()
            for setter in state.assignments do
                setter config
            azurerm.MssqlJobAgent.MssqlJobAgent(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mssqlJobAgent: missing required arguments. Must call: database_id, location, name.", 9999, IsError = true)>]
        member _.Run(_: MssqlJobAgentState<_, _, _>) : azurerm.MssqlJobAgent.MssqlJobAgent =
            Unchecked.defaultof<azurerm.MssqlJobAgent.MssqlJobAgent>
