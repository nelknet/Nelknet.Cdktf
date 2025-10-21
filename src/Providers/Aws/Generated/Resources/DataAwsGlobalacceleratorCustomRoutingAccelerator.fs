namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsGlobalacceleratorCustomRoutingAcceleratorState = { assignments: ResizeArray<aws.DataAwsGlobalacceleratorCustomRoutingAccelerator.DataAwsGlobalacceleratorCustomRoutingAcceleratorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/globalaccelerator_custom_routing_accelerator">aws_globalaccelerator_custom_routing_accelerator</a>.
    /// </summary>
    type DataAwsGlobalacceleratorCustomRoutingAcceleratorBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsGlobalacceleratorCustomRoutingAcceleratorState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsGlobalacceleratorCustomRoutingAcceleratorState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/globalaccelerator_custom_routing_accelerator#arn-1">DataAwsGlobalacceleratorCustomRoutingAccelerator#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsGlobalacceleratorCustomRoutingAcceleratorState, value: string) : DataAwsGlobalacceleratorCustomRoutingAcceleratorState =
            state.assignments.Add(fun config -> config.Arn <- value)
            state : DataAwsGlobalacceleratorCustomRoutingAcceleratorState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/globalaccelerator_custom_routing_accelerator#id-1">DataAwsGlobalacceleratorCustomRoutingAccelerator#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsGlobalacceleratorCustomRoutingAcceleratorState, value: string) : DataAwsGlobalacceleratorCustomRoutingAcceleratorState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsGlobalacceleratorCustomRoutingAcceleratorState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/globalaccelerator_custom_routing_accelerator#name-1">DataAwsGlobalacceleratorCustomRoutingAccelerator#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsGlobalacceleratorCustomRoutingAcceleratorState, value: string) : DataAwsGlobalacceleratorCustomRoutingAcceleratorState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsGlobalacceleratorCustomRoutingAcceleratorState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/globalaccelerator_custom_routing_accelerator#tags-1">DataAwsGlobalacceleratorCustomRoutingAccelerator#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsGlobalacceleratorCustomRoutingAcceleratorState, value: seq<string * string>) : DataAwsGlobalacceleratorCustomRoutingAcceleratorState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsGlobalacceleratorCustomRoutingAcceleratorState

        member _.Run(state: DataAwsGlobalacceleratorCustomRoutingAcceleratorState) : aws.DataAwsGlobalacceleratorCustomRoutingAccelerator.DataAwsGlobalacceleratorCustomRoutingAccelerator =
            let config = aws.DataAwsGlobalacceleratorCustomRoutingAccelerator.DataAwsGlobalacceleratorCustomRoutingAcceleratorConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsGlobalacceleratorCustomRoutingAccelerator.DataAwsGlobalacceleratorCustomRoutingAccelerator(StackContext.get (), logicalId, config)
