namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermStreamAnalyticsJobState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermStreamAnalyticsJob.DataAzurermStreamAnalyticsJobConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/stream_analytics_job">azurerm_stream_analytics_job</a>.
    /// </summary>
    type DataAzurermStreamAnalyticsJobBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermStreamAnalyticsJobState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStreamAnalyticsJobState<Missing, Missing>)

        member _.Zero(()) : DataAzurermStreamAnalyticsJobState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStreamAnalyticsJobState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/stream_analytics_job#name-1">DataAzurermStreamAnalyticsJob#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermStreamAnalyticsJobState<Missing, 'ResourceGroupName>, value: string) : DataAzurermStreamAnalyticsJobState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermStreamAnalyticsJobState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/stream_analytics_job#resource_group_name-1">DataAzurermStreamAnalyticsJob#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermStreamAnalyticsJobState<'Name, Missing>, value: string) : DataAzurermStreamAnalyticsJobState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermStreamAnalyticsJobState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/stream_analytics_job#id-1">DataAzurermStreamAnalyticsJob#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermStreamAnalyticsJobState<'Name, 'ResourceGroupName>, value: string) : DataAzurermStreamAnalyticsJobState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermStreamAnalyticsJobState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/stream_analytics_job#timeouts-1">DataAzurermStreamAnalyticsJob#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermStreamAnalyticsJobState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermStreamAnalyticsJob.DataAzurermStreamAnalyticsJobTimeouts) : DataAzurermStreamAnalyticsJobState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermStreamAnalyticsJobState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermStreamAnalyticsJobState<Present, Present>) : azurerm.DataAzurermStreamAnalyticsJob.DataAzurermStreamAnalyticsJob =
            let config = azurerm.DataAzurermStreamAnalyticsJob.DataAzurermStreamAnalyticsJobConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermStreamAnalyticsJob.DataAzurermStreamAnalyticsJob(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermStreamAnalyticsJob: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermStreamAnalyticsJobState<_, _>) : azurerm.DataAzurermStreamAnalyticsJob.DataAzurermStreamAnalyticsJob =
            Unchecked.defaultof<azurerm.DataAzurermStreamAnalyticsJob.DataAzurermStreamAnalyticsJob>
