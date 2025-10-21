namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow">azurerm_data_factory_flowlet_data_flow</a>.
    /// </summary>
    type DataFactoryFlowletDataFlowBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryFlowletDataFlowState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryFlowletDataFlowState<Missing, Missing>)

        member _.Zero(()) : DataFactoryFlowletDataFlowState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryFlowletDataFlowState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#data_factory_id-1">DataFactoryFlowletDataFlow#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryFlowletDataFlowState<Missing, 'Name>, value: string) : DataFactoryFlowletDataFlowState<Present, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryFlowletDataFlowState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#name-1">DataFactoryFlowletDataFlow#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryFlowletDataFlowState<'DataFactoryId, Missing>, value: string) : DataFactoryFlowletDataFlowState<'DataFactoryId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryFlowletDataFlowState<'DataFactoryId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#annotations-1">DataFactoryFlowletDataFlow#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name>, value: seq<string>) : DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#description-1">DataFactoryFlowletDataFlow#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name>, value: string) : DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#folder-1">DataFactoryFlowletDataFlow#folder</a>.
        /// </summary>
        [<CustomOperation "folder">]
        member _.Folder(state: DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name>, value: string) : DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Folder <- value)
            state : DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#id-1">DataFactoryFlowletDataFlow#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name>, value: string) : DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#script-1">DataFactoryFlowletDataFlow#script</a>.
        /// </summary>
        [<CustomOperation "script">]
        member _.Script(state: DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name>, value: string) : DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Script <- value)
            state : DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#script_lines-1">DataFactoryFlowletDataFlow#script_lines</a>.
        /// </summary>
        [<CustomOperation "script_lines">]
        member _.ScriptLines(state: DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name>, value: seq<string>) : DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.ScriptLines <- (value |> Seq.toArray))
            state : DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name>

        /// <summary>
        /// sink block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#sink-1">DataFactoryFlowletDataFlow#sink</a> Accepts: azurerm.IResolvable | azurerm.DataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSink[]
        /// </summary>
        [<CustomOperation "sink">]
        member _.Sink(state: DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Sink <- value)
            state : DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name>

        /// <summary>
        /// source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#source-1">DataFactoryFlowletDataFlow#source</a> Accepts: azurerm.IResolvable | azurerm.DataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSource[]
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Source <- value)
            state : DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#timeouts-1">DataFactoryFlowletDataFlow#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name>, value: azurerm.DataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowTimeouts) : DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name>

        /// <summary>
        /// transformation block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#transformation-1">DataFactoryFlowletDataFlow#transformation</a> Accepts: azurerm.IResolvable | azurerm.DataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowTransformation[]
        /// </summary>
        [<CustomOperation "transformation">]
        member _.Transformation(state: DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Transformation <- value)
            state : DataFactoryFlowletDataFlowState<'DataFactoryId, 'Name>

        member _.Run(state: DataFactoryFlowletDataFlowState<Present, Present>) : azurerm.DataFactoryFlowletDataFlow.DataFactoryFlowletDataFlow =
            let config = azurerm.DataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryFlowletDataFlow.DataFactoryFlowletDataFlow(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryFlowletDataFlow: missing required arguments. Must call: data_factory_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryFlowletDataFlowState<_, _>) : azurerm.DataFactoryFlowletDataFlow.DataFactoryFlowletDataFlow =
            Unchecked.defaultof<azurerm.DataFactoryFlowletDataFlow.DataFactoryFlowletDataFlow>
