namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsMqBrokerEngineTypesState = { assignments: ResizeArray<aws.DataAwsMqBrokerEngineTypes.DataAwsMqBrokerEngineTypesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/mq_broker_engine_types">aws_mq_broker_engine_types</a>.
    /// </summary>
    type DataAwsMqBrokerEngineTypesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsMqBrokerEngineTypesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsMqBrokerEngineTypesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/mq_broker_engine_types#engine_type-1">DataAwsMqBrokerEngineTypes#engine_type</a>.
        /// </summary>
        [<CustomOperation "engine_type">]
        member _.EngineType(state: DataAwsMqBrokerEngineTypesState, value: string) : DataAwsMqBrokerEngineTypesState =
            state.assignments.Add(fun config -> config.EngineType <- value)
            state : DataAwsMqBrokerEngineTypesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/mq_broker_engine_types#id-1">DataAwsMqBrokerEngineTypes#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsMqBrokerEngineTypesState, value: string) : DataAwsMqBrokerEngineTypesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsMqBrokerEngineTypesState

        member _.Run(state: DataAwsMqBrokerEngineTypesState) : aws.DataAwsMqBrokerEngineTypes.DataAwsMqBrokerEngineTypes =
            let config = aws.DataAwsMqBrokerEngineTypes.DataAwsMqBrokerEngineTypesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsMqBrokerEngineTypes.DataAwsMqBrokerEngineTypes(StackContext.get (), logicalId, config)
