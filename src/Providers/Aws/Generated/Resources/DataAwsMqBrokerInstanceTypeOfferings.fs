namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsMqBrokerInstanceTypeOfferingsState = { assignments: ResizeArray<aws.DataAwsMqBrokerInstanceTypeOfferings.DataAwsMqBrokerInstanceTypeOfferingsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/mq_broker_instance_type_offerings">aws_mq_broker_instance_type_offerings</a>.
    /// </summary>
    type DataAwsMqBrokerInstanceTypeOfferingsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsMqBrokerInstanceTypeOfferingsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsMqBrokerInstanceTypeOfferingsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/mq_broker_instance_type_offerings#engine_type-1">DataAwsMqBrokerInstanceTypeOfferings#engine_type</a>.
        /// </summary>
        [<CustomOperation "engine_type">]
        member _.EngineType(state: DataAwsMqBrokerInstanceTypeOfferingsState, value: string) : DataAwsMqBrokerInstanceTypeOfferingsState =
            state.assignments.Add(fun config -> config.EngineType <- value)
            state : DataAwsMqBrokerInstanceTypeOfferingsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/mq_broker_instance_type_offerings#host_instance_type-1">DataAwsMqBrokerInstanceTypeOfferings#host_instance_type</a>.
        /// </summary>
        [<CustomOperation "host_instance_type">]
        member _.HostInstanceType(state: DataAwsMqBrokerInstanceTypeOfferingsState, value: string) : DataAwsMqBrokerInstanceTypeOfferingsState =
            state.assignments.Add(fun config -> config.HostInstanceType <- value)
            state : DataAwsMqBrokerInstanceTypeOfferingsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/mq_broker_instance_type_offerings#id-1">DataAwsMqBrokerInstanceTypeOfferings#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsMqBrokerInstanceTypeOfferingsState, value: string) : DataAwsMqBrokerInstanceTypeOfferingsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsMqBrokerInstanceTypeOfferingsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/mq_broker_instance_type_offerings#storage_type-1">DataAwsMqBrokerInstanceTypeOfferings#storage_type</a>.
        /// </summary>
        [<CustomOperation "storage_type">]
        member _.StorageType(state: DataAwsMqBrokerInstanceTypeOfferingsState, value: string) : DataAwsMqBrokerInstanceTypeOfferingsState =
            state.assignments.Add(fun config -> config.StorageType <- value)
            state : DataAwsMqBrokerInstanceTypeOfferingsState

        member _.Run(state: DataAwsMqBrokerInstanceTypeOfferingsState) : aws.DataAwsMqBrokerInstanceTypeOfferings.DataAwsMqBrokerInstanceTypeOfferings =
            let config = aws.DataAwsMqBrokerInstanceTypeOfferings.DataAwsMqBrokerInstanceTypeOfferingsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsMqBrokerInstanceTypeOfferings.DataAwsMqBrokerInstanceTypeOfferings(StackContext.get (), logicalId, config)
