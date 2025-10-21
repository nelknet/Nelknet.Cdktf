namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StreamAnalyticsOutputSynapseState<'Database, 'Name, 'Password, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table, 'User> = { assignments: ResizeArray<azurerm.StreamAnalyticsOutputSynapse.StreamAnalyticsOutputSynapseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_synapse">azurerm_stream_analytics_output_synapse</a>.
    /// </summary>
    type StreamAnalyticsOutputSynapseBuilder(logicalId: string) =
        member _.Yield(_: unit) : StreamAnalyticsOutputSynapseState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsOutputSynapseState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StreamAnalyticsOutputSynapseState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsOutputSynapseState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_synapse#database-1">StreamAnalyticsOutputSynapse#database</a>.
        /// </summary>
        [<CustomOperation "database">]
        member _.Database(state: StreamAnalyticsOutputSynapseState<Missing, 'Name, 'Password, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table, 'User>, value: string) : StreamAnalyticsOutputSynapseState<Present, 'Name, 'Password, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table, 'User> =
            state.assignments.Add(fun config -> config.Database <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputSynapseState<Present, 'Name, 'Password, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table, 'User>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_synapse#name-1">StreamAnalyticsOutputSynapse#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StreamAnalyticsOutputSynapseState<'Database, Missing, 'Password, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table, 'User>, value: string) : StreamAnalyticsOutputSynapseState<'Database, Present, 'Password, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table, 'User> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputSynapseState<'Database, Present, 'Password, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table, 'User>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_synapse#password-1">StreamAnalyticsOutputSynapse#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: StreamAnalyticsOutputSynapseState<'Database, 'Name, Missing, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table, 'User>, value: string) : StreamAnalyticsOutputSynapseState<'Database, 'Name, Present, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table, 'User> =
            state.assignments.Add(fun config -> config.Password <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputSynapseState<'Database, 'Name, Present, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table, 'User>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_synapse#resource_group_name-1">StreamAnalyticsOutputSynapse#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: StreamAnalyticsOutputSynapseState<'Database, 'Name, 'Password, Missing, 'Server, 'StreamAnalyticsJobName, 'Table, 'User>, value: string) : StreamAnalyticsOutputSynapseState<'Database, 'Name, 'Password, Present, 'Server, 'StreamAnalyticsJobName, 'Table, 'User> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputSynapseState<'Database, 'Name, 'Password, Present, 'Server, 'StreamAnalyticsJobName, 'Table, 'User>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_synapse#server-1">StreamAnalyticsOutputSynapse#server</a>.
        /// </summary>
        [<CustomOperation "server">]
        member _.Server(state: StreamAnalyticsOutputSynapseState<'Database, 'Name, 'Password, 'ResourceGroupName, Missing, 'StreamAnalyticsJobName, 'Table, 'User>, value: string) : StreamAnalyticsOutputSynapseState<'Database, 'Name, 'Password, 'ResourceGroupName, Present, 'StreamAnalyticsJobName, 'Table, 'User> =
            state.assignments.Add(fun config -> config.Server <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputSynapseState<'Database, 'Name, 'Password, 'ResourceGroupName, Present, 'StreamAnalyticsJobName, 'Table, 'User>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_synapse#stream_analytics_job_name-1">StreamAnalyticsOutputSynapse#stream_analytics_job_name</a>.
        /// </summary>
        [<CustomOperation "stream_analytics_job_name">]
        member _.StreamAnalyticsJobName(state: StreamAnalyticsOutputSynapseState<'Database, 'Name, 'Password, 'ResourceGroupName, 'Server, Missing, 'Table, 'User>, value: string) : StreamAnalyticsOutputSynapseState<'Database, 'Name, 'Password, 'ResourceGroupName, 'Server, Present, 'Table, 'User> =
            state.assignments.Add(fun config -> config.StreamAnalyticsJobName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputSynapseState<'Database, 'Name, 'Password, 'ResourceGroupName, 'Server, Present, 'Table, 'User>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_synapse#table-1">StreamAnalyticsOutputSynapse#table</a>.
        /// </summary>
        [<CustomOperation "table">]
        member _.Table(state: StreamAnalyticsOutputSynapseState<'Database, 'Name, 'Password, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, Missing, 'User>, value: string) : StreamAnalyticsOutputSynapseState<'Database, 'Name, 'Password, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, Present, 'User> =
            state.assignments.Add(fun config -> config.Table <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputSynapseState<'Database, 'Name, 'Password, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, Present, 'User>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_synapse#user-1">StreamAnalyticsOutputSynapse#user</a>.
        /// </summary>
        [<CustomOperation "user">]
        member _.User(state: StreamAnalyticsOutputSynapseState<'Database, 'Name, 'Password, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table, Missing>, value: string) : StreamAnalyticsOutputSynapseState<'Database, 'Name, 'Password, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table, Present> =
            state.assignments.Add(fun config -> config.User <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputSynapseState<'Database, 'Name, 'Password, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_synapse#id-1">StreamAnalyticsOutputSynapse#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StreamAnalyticsOutputSynapseState<'Database, 'Name, 'Password, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table, 'User>, value: string) : StreamAnalyticsOutputSynapseState<'Database, 'Name, 'Password, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table, 'User> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StreamAnalyticsOutputSynapseState<'Database, 'Name, 'Password, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table, 'User>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_synapse#timeouts-1">StreamAnalyticsOutputSynapse#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StreamAnalyticsOutputSynapseState<'Database, 'Name, 'Password, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table, 'User>, value: azurerm.StreamAnalyticsOutputSynapse.StreamAnalyticsOutputSynapseTimeouts) : StreamAnalyticsOutputSynapseState<'Database, 'Name, 'Password, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table, 'User> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StreamAnalyticsOutputSynapseState<'Database, 'Name, 'Password, 'ResourceGroupName, 'Server, 'StreamAnalyticsJobName, 'Table, 'User>

        member _.Run(state: StreamAnalyticsOutputSynapseState<Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.StreamAnalyticsOutputSynapse.StreamAnalyticsOutputSynapse =
            let config = azurerm.StreamAnalyticsOutputSynapse.StreamAnalyticsOutputSynapseConfig()
            for setter in state.assignments do
                setter config
            azurerm.StreamAnalyticsOutputSynapse.StreamAnalyticsOutputSynapse(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.streamAnalyticsOutputSynapse: missing required arguments. Must call: database, name, password, resource_group_name, server, stream_analytics_job_name, table, user.", 9999, IsError = true)>]
        member _.Run(_: StreamAnalyticsOutputSynapseState<_, _, _, _, _, _, _, _>) : azurerm.StreamAnalyticsOutputSynapse.StreamAnalyticsOutputSynapse =
            Unchecked.defaultof<azurerm.StreamAnalyticsOutputSynapse.StreamAnalyticsOutputSynapse>
