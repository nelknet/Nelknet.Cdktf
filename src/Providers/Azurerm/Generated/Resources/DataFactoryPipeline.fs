namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryPipelineState<'DataFactoryId, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryPipeline.DataFactoryPipelineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_pipeline">azurerm_data_factory_pipeline</a>.
    /// </summary>
    type DataFactoryPipelineBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryPipelineState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryPipelineState<Missing, Missing>)

        member _.Zero(()) : DataFactoryPipelineState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryPipelineState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_pipeline#data_factory_id-1">DataFactoryPipeline#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryPipelineState<Missing, 'Name>, value: string) : DataFactoryPipelineState<Present, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryPipelineState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_pipeline#name-1">DataFactoryPipeline#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryPipelineState<'DataFactoryId, Missing>, value: string) : DataFactoryPipelineState<'DataFactoryId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryPipelineState<'DataFactoryId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_pipeline#activities_json-1">DataFactoryPipeline#activities_json</a>.
        /// </summary>
        [<CustomOperation "activities_json">]
        member _.ActivitiesJson(state: DataFactoryPipelineState<'DataFactoryId, 'Name>, value: string) : DataFactoryPipelineState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.ActivitiesJson <- value)
            state : DataFactoryPipelineState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_pipeline#annotations-1">DataFactoryPipeline#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryPipelineState<'DataFactoryId, 'Name>, value: seq<string>) : DataFactoryPipelineState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryPipelineState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_pipeline#concurrency-1">DataFactoryPipeline#concurrency</a>.
        /// </summary>
        [<CustomOperation "concurrency">]
        member _.Concurrency(state: DataFactoryPipelineState<'DataFactoryId, 'Name>, value: double) : DataFactoryPipelineState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Concurrency <- value)
            state : DataFactoryPipelineState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_pipeline#description-1">DataFactoryPipeline#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryPipelineState<'DataFactoryId, 'Name>, value: string) : DataFactoryPipelineState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryPipelineState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_pipeline#folder-1">DataFactoryPipeline#folder</a>.
        /// </summary>
        [<CustomOperation "folder">]
        member _.Folder(state: DataFactoryPipelineState<'DataFactoryId, 'Name>, value: string) : DataFactoryPipelineState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Folder <- value)
            state : DataFactoryPipelineState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_pipeline#id-1">DataFactoryPipeline#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryPipelineState<'DataFactoryId, 'Name>, value: string) : DataFactoryPipelineState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryPipelineState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_pipeline#moniter_metrics_after_duration-1">DataFactoryPipeline#moniter_metrics_after_duration</a>.
        /// </summary>
        [<CustomOperation "moniter_metrics_after_duration">]
        member _.MoniterMetricsAfterDuration(state: DataFactoryPipelineState<'DataFactoryId, 'Name>, value: string) : DataFactoryPipelineState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.MoniterMetricsAfterDuration <- value)
            state : DataFactoryPipelineState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_pipeline#parameters-1">DataFactoryPipeline#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryPipelineState<'DataFactoryId, 'Name>, value: seq<string * string>) : DataFactoryPipelineState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryPipelineState<'DataFactoryId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_pipeline#timeouts-1">DataFactoryPipeline#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryPipelineState<'DataFactoryId, 'Name>, value: azurerm.DataFactoryPipeline.DataFactoryPipelineTimeouts) : DataFactoryPipelineState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryPipelineState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_pipeline#variables-1">DataFactoryPipeline#variables</a>.
        /// </summary>
        [<CustomOperation "variables">]
        member _.Variables(state: DataFactoryPipelineState<'DataFactoryId, 'Name>, value: seq<string * string>) : DataFactoryPipelineState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Variables <- dict value)
            state : DataFactoryPipelineState<'DataFactoryId, 'Name>

        member _.Run(state: DataFactoryPipelineState<Present, Present>) : azurerm.DataFactoryPipeline.DataFactoryPipeline =
            let config = azurerm.DataFactoryPipeline.DataFactoryPipelineConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryPipeline.DataFactoryPipeline(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryPipeline: missing required arguments. Must call: data_factory_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryPipelineState<_, _>) : azurerm.DataFactoryPipeline.DataFactoryPipeline =
            Unchecked.defaultof<azurerm.DataFactoryPipeline.DataFactoryPipeline>
