namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsInstancesState = { assignments: ResizeArray<aws.DataAwsInstances.DataAwsInstancesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/instances">aws_instances</a>.
    /// </summary>
    type DataAwsInstancesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsInstancesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsInstancesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/instances#filter-1">DataAwsInstances#filter</a> Accepts: aws.IResolvable | aws.DataAwsInstances.DataAwsInstancesFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsInstancesState, value: HashiCorp.Cdktf.IResolvable) : DataAwsInstancesState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsInstancesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/instances#id-1">DataAwsInstances#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsInstancesState, value: string) : DataAwsInstancesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsInstancesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/instances#instance_state_names-1">DataAwsInstances#instance_state_names</a>.
        /// </summary>
        [<CustomOperation "instance_state_names">]
        member _.InstanceStateNames(state: DataAwsInstancesState, value: seq<string>) : DataAwsInstancesState =
            state.assignments.Add(fun config -> config.InstanceStateNames <- (value |> Seq.toArray))
            state : DataAwsInstancesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/instances#instance_tags-1">DataAwsInstances#instance_tags</a>.
        /// </summary>
        [<CustomOperation "instance_tags">]
        member _.InstanceTags(state: DataAwsInstancesState, value: seq<string * string>) : DataAwsInstancesState =
            state.assignments.Add(fun config -> config.InstanceTags <- dict value)
            state : DataAwsInstancesState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/instances#timeouts-1">DataAwsInstances#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsInstancesState, value: aws.DataAwsInstances.DataAwsInstancesTimeouts) : DataAwsInstancesState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsInstancesState

        member _.Run(state: DataAwsInstancesState) : aws.DataAwsInstances.DataAwsInstances =
            let config = aws.DataAwsInstances.DataAwsInstancesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsInstances.DataAwsInstances(StackContext.get (), logicalId, config)
