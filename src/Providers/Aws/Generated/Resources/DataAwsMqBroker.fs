namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsMqBrokerState = { assignments: ResizeArray<aws.DataAwsMqBroker.DataAwsMqBrokerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/mq_broker">aws_mq_broker</a>.
    /// </summary>
    type DataAwsMqBrokerBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsMqBrokerState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsMqBrokerState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/mq_broker#broker_id-1">DataAwsMqBroker#broker_id</a>.
        /// </summary>
        [<CustomOperation "broker_id">]
        member _.BrokerId(state: DataAwsMqBrokerState, value: string) : DataAwsMqBrokerState =
            state.assignments.Add(fun config -> config.BrokerId <- value)
            state : DataAwsMqBrokerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/mq_broker#broker_name-1">DataAwsMqBroker#broker_name</a>.
        /// </summary>
        [<CustomOperation "broker_name">]
        member _.BrokerName(state: DataAwsMqBrokerState, value: string) : DataAwsMqBrokerState =
            state.assignments.Add(fun config -> config.BrokerName <- value)
            state : DataAwsMqBrokerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/mq_broker#id-1">DataAwsMqBroker#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsMqBrokerState, value: string) : DataAwsMqBrokerState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsMqBrokerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/mq_broker#tags-1">DataAwsMqBroker#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsMqBrokerState, value: seq<string * string>) : DataAwsMqBrokerState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsMqBrokerState

        member _.Run(state: DataAwsMqBrokerState) : aws.DataAwsMqBroker.DataAwsMqBroker =
            let config = aws.DataAwsMqBroker.DataAwsMqBrokerConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsMqBroker.DataAwsMqBroker(StackContext.get (), logicalId, config)
