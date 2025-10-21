namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryDataFlowState<'DataFactoryId, 'Name, 'Sink, 'Source> = { assignments: ResizeArray<azurerm.DataFactoryDataFlow.DataFactoryDataFlowConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow">azurerm_data_factory_data_flow</a>.
    /// </summary>
    type DataFactoryDataFlowBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryDataFlowState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryDataFlowState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryDataFlowState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryDataFlowState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#data_factory_id-1">DataFactoryDataFlow#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryDataFlowState<Missing, 'Name, 'Sink, 'Source>, value: string) : DataFactoryDataFlowState<Present, 'Name, 'Sink, 'Source> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryDataFlowState<Present, 'Name, 'Sink, 'Source>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#name-1">DataFactoryDataFlow#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryDataFlowState<'DataFactoryId, Missing, 'Sink, 'Source>, value: string) : DataFactoryDataFlowState<'DataFactoryId, Present, 'Sink, 'Source> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryDataFlowState<'DataFactoryId, Present, 'Sink, 'Source>)

        /// <summary>
        /// sink block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#sink-1">DataFactoryDataFlow#sink</a> Accepts: azurerm.IResolvable | azurerm.DataFactoryDataFlow.DataFactoryDataFlowSink[]
        /// </summary>
        [<CustomOperation "sink">]
        member _.Sink(state: DataFactoryDataFlowState<'DataFactoryId, 'Name, Missing, 'Source>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryDataFlowState<'DataFactoryId, 'Name, Present, 'Source> =
            state.assignments.Add(fun config -> config.Sink <- value)
            ({ assignments = state.assignments } : DataFactoryDataFlowState<'DataFactoryId, 'Name, Present, 'Source>)

        /// <summary>
        /// source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#source-1">DataFactoryDataFlow#source</a> Accepts: azurerm.IResolvable | azurerm.DataFactoryDataFlow.DataFactoryDataFlowSource[]
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: DataFactoryDataFlowState<'DataFactoryId, 'Name, 'Sink, Missing>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryDataFlowState<'DataFactoryId, 'Name, 'Sink, Present> =
            state.assignments.Add(fun config -> config.Source <- value)
            ({ assignments = state.assignments } : DataFactoryDataFlowState<'DataFactoryId, 'Name, 'Sink, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#annotations-1">DataFactoryDataFlow#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryDataFlowState<'DataFactoryId, 'Name, 'Sink, 'Source>, value: seq<string>) : DataFactoryDataFlowState<'DataFactoryId, 'Name, 'Sink, 'Source> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryDataFlowState<'DataFactoryId, 'Name, 'Sink, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#description-1">DataFactoryDataFlow#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryDataFlowState<'DataFactoryId, 'Name, 'Sink, 'Source>, value: string) : DataFactoryDataFlowState<'DataFactoryId, 'Name, 'Sink, 'Source> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryDataFlowState<'DataFactoryId, 'Name, 'Sink, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#folder-1">DataFactoryDataFlow#folder</a>.
        /// </summary>
        [<CustomOperation "folder">]
        member _.Folder(state: DataFactoryDataFlowState<'DataFactoryId, 'Name, 'Sink, 'Source>, value: string) : DataFactoryDataFlowState<'DataFactoryId, 'Name, 'Sink, 'Source> =
            state.assignments.Add(fun config -> config.Folder <- value)
            state : DataFactoryDataFlowState<'DataFactoryId, 'Name, 'Sink, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#id-1">DataFactoryDataFlow#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryDataFlowState<'DataFactoryId, 'Name, 'Sink, 'Source>, value: string) : DataFactoryDataFlowState<'DataFactoryId, 'Name, 'Sink, 'Source> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryDataFlowState<'DataFactoryId, 'Name, 'Sink, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#script-1">DataFactoryDataFlow#script</a>.
        /// </summary>
        [<CustomOperation "script">]
        member _.Script(state: DataFactoryDataFlowState<'DataFactoryId, 'Name, 'Sink, 'Source>, value: string) : DataFactoryDataFlowState<'DataFactoryId, 'Name, 'Sink, 'Source> =
            state.assignments.Add(fun config -> config.Script <- value)
            state : DataFactoryDataFlowState<'DataFactoryId, 'Name, 'Sink, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#script_lines-1">DataFactoryDataFlow#script_lines</a>.
        /// </summary>
        [<CustomOperation "script_lines">]
        member _.ScriptLines(state: DataFactoryDataFlowState<'DataFactoryId, 'Name, 'Sink, 'Source>, value: seq<string>) : DataFactoryDataFlowState<'DataFactoryId, 'Name, 'Sink, 'Source> =
            state.assignments.Add(fun config -> config.ScriptLines <- (value |> Seq.toArray))
            state : DataFactoryDataFlowState<'DataFactoryId, 'Name, 'Sink, 'Source>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#timeouts-1">DataFactoryDataFlow#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryDataFlowState<'DataFactoryId, 'Name, 'Sink, 'Source>, value: azurerm.DataFactoryDataFlow.DataFactoryDataFlowTimeouts) : DataFactoryDataFlowState<'DataFactoryId, 'Name, 'Sink, 'Source> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryDataFlowState<'DataFactoryId, 'Name, 'Sink, 'Source>

        /// <summary>
        /// transformation block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#transformation-1">DataFactoryDataFlow#transformation</a> Accepts: azurerm.IResolvable | azurerm.DataFactoryDataFlow.DataFactoryDataFlowTransformation[]
        /// </summary>
        [<CustomOperation "transformation">]
        member _.Transformation(state: DataFactoryDataFlowState<'DataFactoryId, 'Name, 'Sink, 'Source>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryDataFlowState<'DataFactoryId, 'Name, 'Sink, 'Source> =
            state.assignments.Add(fun config -> config.Transformation <- value)
            state : DataFactoryDataFlowState<'DataFactoryId, 'Name, 'Sink, 'Source>

        member _.Run(state: DataFactoryDataFlowState<Present, Present, Present, Present>) : azurerm.DataFactoryDataFlow.DataFactoryDataFlow =
            let config = azurerm.DataFactoryDataFlow.DataFactoryDataFlowConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryDataFlow.DataFactoryDataFlow(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryDataFlow: missing required arguments. Must call: data_factory_id, name, sink, source.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryDataFlowState<_, _, _, _>) : azurerm.DataFactoryDataFlow.DataFactoryDataFlow =
            Unchecked.defaultof<azurerm.DataFactoryDataFlow.DataFactoryDataFlow>
