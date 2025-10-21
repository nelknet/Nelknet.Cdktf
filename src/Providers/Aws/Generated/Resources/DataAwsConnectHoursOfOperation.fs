namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsConnectHoursOfOperationState<'InstanceId> = { assignments: ResizeArray<aws.DataAwsConnectHoursOfOperation.DataAwsConnectHoursOfOperationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_hours_of_operation">aws_connect_hours_of_operation</a>.
    /// </summary>
    type DataAwsConnectHoursOfOperationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsConnectHoursOfOperationState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsConnectHoursOfOperationState<Missing>)

        member _.Zero(()) : DataAwsConnectHoursOfOperationState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsConnectHoursOfOperationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_hours_of_operation#instance_id-1">DataAwsConnectHoursOfOperation#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: DataAwsConnectHoursOfOperationState<Missing>, value: string) : DataAwsConnectHoursOfOperationState<Present> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : DataAwsConnectHoursOfOperationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_hours_of_operation#hours_of_operation_id-1">DataAwsConnectHoursOfOperation#hours_of_operation_id</a>.
        /// </summary>
        [<CustomOperation "hours_of_operation_id">]
        member _.HoursOfOperationId(state: DataAwsConnectHoursOfOperationState<'InstanceId>, value: string) : DataAwsConnectHoursOfOperationState<'InstanceId> =
            state.assignments.Add(fun config -> config.HoursOfOperationId <- value)
            state : DataAwsConnectHoursOfOperationState<'InstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_hours_of_operation#id-1">DataAwsConnectHoursOfOperation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsConnectHoursOfOperationState<'InstanceId>, value: string) : DataAwsConnectHoursOfOperationState<'InstanceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsConnectHoursOfOperationState<'InstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_hours_of_operation#name-1">DataAwsConnectHoursOfOperation#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsConnectHoursOfOperationState<'InstanceId>, value: string) : DataAwsConnectHoursOfOperationState<'InstanceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsConnectHoursOfOperationState<'InstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_hours_of_operation#tags-1">DataAwsConnectHoursOfOperation#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsConnectHoursOfOperationState<'InstanceId>, value: seq<string * string>) : DataAwsConnectHoursOfOperationState<'InstanceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsConnectHoursOfOperationState<'InstanceId>

        member _.Run(state: DataAwsConnectHoursOfOperationState<Present>) : aws.DataAwsConnectHoursOfOperation.DataAwsConnectHoursOfOperation =
            let config = aws.DataAwsConnectHoursOfOperation.DataAwsConnectHoursOfOperationConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsConnectHoursOfOperation.DataAwsConnectHoursOfOperation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsConnectHoursOfOperation: missing required arguments. Must call: instance_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsConnectHoursOfOperationState<_>) : aws.DataAwsConnectHoursOfOperation.DataAwsConnectHoursOfOperation =
            Unchecked.defaultof<aws.DataAwsConnectHoursOfOperation.DataAwsConnectHoursOfOperation>
