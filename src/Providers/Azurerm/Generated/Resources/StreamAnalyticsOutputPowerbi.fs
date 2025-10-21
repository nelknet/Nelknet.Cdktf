namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StreamAnalyticsOutputPowerbiState<'Dataset, 'GroupId, 'GroupName, 'Name, 'StreamAnalyticsJobId, 'Table> = { assignments: ResizeArray<azurerm.StreamAnalyticsOutputPowerbi.StreamAnalyticsOutputPowerbiConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_powerbi">azurerm_stream_analytics_output_powerbi</a>.
    /// </summary>
    type StreamAnalyticsOutputPowerbiBuilder(logicalId: string) =
        member _.Yield(_: unit) : StreamAnalyticsOutputPowerbiState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsOutputPowerbiState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StreamAnalyticsOutputPowerbiState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsOutputPowerbiState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_powerbi#dataset-1">StreamAnalyticsOutputPowerbi#dataset</a>.
        /// </summary>
        [<CustomOperation "dataset">]
        member _.Dataset(state: StreamAnalyticsOutputPowerbiState<Missing, 'GroupId, 'GroupName, 'Name, 'StreamAnalyticsJobId, 'Table>, value: string) : StreamAnalyticsOutputPowerbiState<Present, 'GroupId, 'GroupName, 'Name, 'StreamAnalyticsJobId, 'Table> =
            state.assignments.Add(fun config -> config.Dataset <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputPowerbiState<Present, 'GroupId, 'GroupName, 'Name, 'StreamAnalyticsJobId, 'Table>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_powerbi#group_id-1">StreamAnalyticsOutputPowerbi#group_id</a>.
        /// </summary>
        [<CustomOperation "group_id">]
        member _.GroupId(state: StreamAnalyticsOutputPowerbiState<'Dataset, Missing, 'GroupName, 'Name, 'StreamAnalyticsJobId, 'Table>, value: string) : StreamAnalyticsOutputPowerbiState<'Dataset, Present, 'GroupName, 'Name, 'StreamAnalyticsJobId, 'Table> =
            state.assignments.Add(fun config -> config.GroupId <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputPowerbiState<'Dataset, Present, 'GroupName, 'Name, 'StreamAnalyticsJobId, 'Table>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_powerbi#group_name-1">StreamAnalyticsOutputPowerbi#group_name</a>.
        /// </summary>
        [<CustomOperation "group_name">]
        member _.GroupName(state: StreamAnalyticsOutputPowerbiState<'Dataset, 'GroupId, Missing, 'Name, 'StreamAnalyticsJobId, 'Table>, value: string) : StreamAnalyticsOutputPowerbiState<'Dataset, 'GroupId, Present, 'Name, 'StreamAnalyticsJobId, 'Table> =
            state.assignments.Add(fun config -> config.GroupName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputPowerbiState<'Dataset, 'GroupId, Present, 'Name, 'StreamAnalyticsJobId, 'Table>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_powerbi#name-1">StreamAnalyticsOutputPowerbi#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StreamAnalyticsOutputPowerbiState<'Dataset, 'GroupId, 'GroupName, Missing, 'StreamAnalyticsJobId, 'Table>, value: string) : StreamAnalyticsOutputPowerbiState<'Dataset, 'GroupId, 'GroupName, Present, 'StreamAnalyticsJobId, 'Table> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputPowerbiState<'Dataset, 'GroupId, 'GroupName, Present, 'StreamAnalyticsJobId, 'Table>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_powerbi#stream_analytics_job_id-1">StreamAnalyticsOutputPowerbi#stream_analytics_job_id</a>.
        /// </summary>
        [<CustomOperation "stream_analytics_job_id">]
        member _.StreamAnalyticsJobId(state: StreamAnalyticsOutputPowerbiState<'Dataset, 'GroupId, 'GroupName, 'Name, Missing, 'Table>, value: string) : StreamAnalyticsOutputPowerbiState<'Dataset, 'GroupId, 'GroupName, 'Name, Present, 'Table> =
            state.assignments.Add(fun config -> config.StreamAnalyticsJobId <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputPowerbiState<'Dataset, 'GroupId, 'GroupName, 'Name, Present, 'Table>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_powerbi#table-1">StreamAnalyticsOutputPowerbi#table</a>.
        /// </summary>
        [<CustomOperation "table">]
        member _.Table(state: StreamAnalyticsOutputPowerbiState<'Dataset, 'GroupId, 'GroupName, 'Name, 'StreamAnalyticsJobId, Missing>, value: string) : StreamAnalyticsOutputPowerbiState<'Dataset, 'GroupId, 'GroupName, 'Name, 'StreamAnalyticsJobId, Present> =
            state.assignments.Add(fun config -> config.Table <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputPowerbiState<'Dataset, 'GroupId, 'GroupName, 'Name, 'StreamAnalyticsJobId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_powerbi#id-1">StreamAnalyticsOutputPowerbi#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StreamAnalyticsOutputPowerbiState<'Dataset, 'GroupId, 'GroupName, 'Name, 'StreamAnalyticsJobId, 'Table>, value: string) : StreamAnalyticsOutputPowerbiState<'Dataset, 'GroupId, 'GroupName, 'Name, 'StreamAnalyticsJobId, 'Table> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StreamAnalyticsOutputPowerbiState<'Dataset, 'GroupId, 'GroupName, 'Name, 'StreamAnalyticsJobId, 'Table>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_powerbi#timeouts-1">StreamAnalyticsOutputPowerbi#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StreamAnalyticsOutputPowerbiState<'Dataset, 'GroupId, 'GroupName, 'Name, 'StreamAnalyticsJobId, 'Table>, value: azurerm.StreamAnalyticsOutputPowerbi.StreamAnalyticsOutputPowerbiTimeouts) : StreamAnalyticsOutputPowerbiState<'Dataset, 'GroupId, 'GroupName, 'Name, 'StreamAnalyticsJobId, 'Table> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StreamAnalyticsOutputPowerbiState<'Dataset, 'GroupId, 'GroupName, 'Name, 'StreamAnalyticsJobId, 'Table>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_powerbi#token_user_display_name-1">StreamAnalyticsOutputPowerbi#token_user_display_name</a>.
        /// </summary>
        [<CustomOperation "token_user_display_name">]
        member _.TokenUserDisplayName(state: StreamAnalyticsOutputPowerbiState<'Dataset, 'GroupId, 'GroupName, 'Name, 'StreamAnalyticsJobId, 'Table>, value: string) : StreamAnalyticsOutputPowerbiState<'Dataset, 'GroupId, 'GroupName, 'Name, 'StreamAnalyticsJobId, 'Table> =
            state.assignments.Add(fun config -> config.TokenUserDisplayName <- value)
            state : StreamAnalyticsOutputPowerbiState<'Dataset, 'GroupId, 'GroupName, 'Name, 'StreamAnalyticsJobId, 'Table>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_powerbi#token_user_principal_name-1">StreamAnalyticsOutputPowerbi#token_user_principal_name</a>.
        /// </summary>
        [<CustomOperation "token_user_principal_name">]
        member _.TokenUserPrincipalName(state: StreamAnalyticsOutputPowerbiState<'Dataset, 'GroupId, 'GroupName, 'Name, 'StreamAnalyticsJobId, 'Table>, value: string) : StreamAnalyticsOutputPowerbiState<'Dataset, 'GroupId, 'GroupName, 'Name, 'StreamAnalyticsJobId, 'Table> =
            state.assignments.Add(fun config -> config.TokenUserPrincipalName <- value)
            state : StreamAnalyticsOutputPowerbiState<'Dataset, 'GroupId, 'GroupName, 'Name, 'StreamAnalyticsJobId, 'Table>

        member _.Run(state: StreamAnalyticsOutputPowerbiState<Present, Present, Present, Present, Present, Present>) : azurerm.StreamAnalyticsOutputPowerbi.StreamAnalyticsOutputPowerbi =
            let config = azurerm.StreamAnalyticsOutputPowerbi.StreamAnalyticsOutputPowerbiConfig()
            for setter in state.assignments do
                setter config
            azurerm.StreamAnalyticsOutputPowerbi.StreamAnalyticsOutputPowerbi(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.streamAnalyticsOutputPowerbi: missing required arguments. Must call: dataset, group_id, group_name, name, stream_analytics_job_id, table.", 9999, IsError = true)>]
        member _.Run(_: StreamAnalyticsOutputPowerbiState<_, _, _, _, _, _>) : azurerm.StreamAnalyticsOutputPowerbi.StreamAnalyticsOutputPowerbi =
            Unchecked.defaultof<azurerm.StreamAnalyticsOutputPowerbi.StreamAnalyticsOutputPowerbi>
