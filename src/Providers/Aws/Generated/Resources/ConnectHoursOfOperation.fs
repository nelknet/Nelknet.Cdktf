namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConnectHoursOfOperationState<'Config, 'InstanceId, 'Name, 'TimeZone> = { assignments: ResizeArray<aws.ConnectHoursOfOperation.ConnectHoursOfOperationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_hours_of_operation">aws_connect_hours_of_operation</a>.
    /// </summary>
    type ConnectHoursOfOperationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConnectHoursOfOperationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectHoursOfOperationState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ConnectHoursOfOperationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectHoursOfOperationState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_hours_of_operation#config-1">ConnectHoursOfOperation#config</a> Accepts: aws.IResolvable | aws.ConnectHoursOfOperation.ConnectHoursOfOperationConfigA[]
        /// </summary>
        [<CustomOperation "config">]
        member _.Config(state: ConnectHoursOfOperationState<Missing, 'InstanceId, 'Name, 'TimeZone>, value: HashiCorp.Cdktf.IResolvable) : ConnectHoursOfOperationState<Present, 'InstanceId, 'Name, 'TimeZone> =
            state.assignments.Add(fun config -> config.Config <- value)
            ({ assignments = state.assignments } : ConnectHoursOfOperationState<Present, 'InstanceId, 'Name, 'TimeZone>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_hours_of_operation#instance_id-1">ConnectHoursOfOperation#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: ConnectHoursOfOperationState<'Config, Missing, 'Name, 'TimeZone>, value: string) : ConnectHoursOfOperationState<'Config, Present, 'Name, 'TimeZone> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : ConnectHoursOfOperationState<'Config, Present, 'Name, 'TimeZone>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_hours_of_operation#name-1">ConnectHoursOfOperation#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ConnectHoursOfOperationState<'Config, 'InstanceId, Missing, 'TimeZone>, value: string) : ConnectHoursOfOperationState<'Config, 'InstanceId, Present, 'TimeZone> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ConnectHoursOfOperationState<'Config, 'InstanceId, Present, 'TimeZone>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_hours_of_operation#time_zone-1">ConnectHoursOfOperation#time_zone</a>.
        /// </summary>
        [<CustomOperation "time_zone">]
        member _.TimeZone(state: ConnectHoursOfOperationState<'Config, 'InstanceId, 'Name, Missing>, value: string) : ConnectHoursOfOperationState<'Config, 'InstanceId, 'Name, Present> =
            state.assignments.Add(fun config -> config.TimeZone <- value)
            ({ assignments = state.assignments } : ConnectHoursOfOperationState<'Config, 'InstanceId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_hours_of_operation#description-1">ConnectHoursOfOperation#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ConnectHoursOfOperationState<'Config, 'InstanceId, 'Name, 'TimeZone>, value: string) : ConnectHoursOfOperationState<'Config, 'InstanceId, 'Name, 'TimeZone> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ConnectHoursOfOperationState<'Config, 'InstanceId, 'Name, 'TimeZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_hours_of_operation#id-1">ConnectHoursOfOperation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConnectHoursOfOperationState<'Config, 'InstanceId, 'Name, 'TimeZone>, value: string) : ConnectHoursOfOperationState<'Config, 'InstanceId, 'Name, 'TimeZone> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConnectHoursOfOperationState<'Config, 'InstanceId, 'Name, 'TimeZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_hours_of_operation#tags-1">ConnectHoursOfOperation#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ConnectHoursOfOperationState<'Config, 'InstanceId, 'Name, 'TimeZone>, value: seq<string * string>) : ConnectHoursOfOperationState<'Config, 'InstanceId, 'Name, 'TimeZone> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ConnectHoursOfOperationState<'Config, 'InstanceId, 'Name, 'TimeZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_hours_of_operation#tags_all-1">ConnectHoursOfOperation#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ConnectHoursOfOperationState<'Config, 'InstanceId, 'Name, 'TimeZone>, value: seq<string * string>) : ConnectHoursOfOperationState<'Config, 'InstanceId, 'Name, 'TimeZone> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ConnectHoursOfOperationState<'Config, 'InstanceId, 'Name, 'TimeZone>

        member _.Run(state: ConnectHoursOfOperationState<Present, Present, Present, Present>) : aws.ConnectHoursOfOperation.ConnectHoursOfOperation =
            let config = aws.ConnectHoursOfOperation.ConnectHoursOfOperationConfig()
            for setter in state.assignments do
                setter config
            aws.ConnectHoursOfOperation.ConnectHoursOfOperation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.connectHoursOfOperation: missing required arguments. Must call: config, instance_id, name, time_zone.", 9999, IsError = true)>]
        member _.Run(_: ConnectHoursOfOperationState<_, _, _, _>) : aws.ConnectHoursOfOperation.ConnectHoursOfOperation =
            Unchecked.defaultof<aws.ConnectHoursOfOperation.ConnectHoursOfOperation>
