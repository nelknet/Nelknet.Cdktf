namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsGlobalacceleratorAcceleratorState = { assignments: ResizeArray<aws.DataAwsGlobalacceleratorAccelerator.DataAwsGlobalacceleratorAcceleratorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/globalaccelerator_accelerator">aws_globalaccelerator_accelerator</a>.
    /// </summary>
    type DataAwsGlobalacceleratorAcceleratorBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsGlobalacceleratorAcceleratorState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsGlobalacceleratorAcceleratorState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/globalaccelerator_accelerator#arn-1">DataAwsGlobalacceleratorAccelerator#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsGlobalacceleratorAcceleratorState, value: string) : DataAwsGlobalacceleratorAcceleratorState =
            state.assignments.Add(fun config -> config.Arn <- value)
            state : DataAwsGlobalacceleratorAcceleratorState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/globalaccelerator_accelerator#id-1">DataAwsGlobalacceleratorAccelerator#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsGlobalacceleratorAcceleratorState, value: string) : DataAwsGlobalacceleratorAcceleratorState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsGlobalacceleratorAcceleratorState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/globalaccelerator_accelerator#name-1">DataAwsGlobalacceleratorAccelerator#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsGlobalacceleratorAcceleratorState, value: string) : DataAwsGlobalacceleratorAcceleratorState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsGlobalacceleratorAcceleratorState

        member _.Run(state: DataAwsGlobalacceleratorAcceleratorState) : aws.DataAwsGlobalacceleratorAccelerator.DataAwsGlobalacceleratorAccelerator =
            let config = aws.DataAwsGlobalacceleratorAccelerator.DataAwsGlobalacceleratorAcceleratorConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsGlobalacceleratorAccelerator.DataAwsGlobalacceleratorAccelerator(StackContext.get (), logicalId, config)
