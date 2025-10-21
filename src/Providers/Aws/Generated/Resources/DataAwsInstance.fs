namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsInstanceState = { assignments: ResizeArray<aws.DataAwsInstance.DataAwsInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/instance">aws_instance</a>.
    /// </summary>
    type DataAwsInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsInstanceState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsInstanceState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/instance#get_password_data-1">DataAwsInstance#get_password_data</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "fetch_password_data">]
        member _.FetchPasswordData(state: DataAwsInstanceState, value: bool) : DataAwsInstanceState =
            state.assignments.Add(fun config -> config.FetchPasswordData <- value)
            state : DataAwsInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/instance#get_password_data-1">DataAwsInstance#get_password_data</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "fetch_password_data">]
        member _.FetchPasswordData(state: DataAwsInstanceState, value: HashiCorp.Cdktf.IResolvable) : DataAwsInstanceState =
            state.assignments.Add(fun config -> config.FetchPasswordData <- value)
            state : DataAwsInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/instance#get_user_data-1">DataAwsInstance#get_user_data</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "fetch_user_data">]
        member _.FetchUserData(state: DataAwsInstanceState, value: bool) : DataAwsInstanceState =
            state.assignments.Add(fun config -> config.FetchUserData <- value)
            state : DataAwsInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/instance#get_user_data-1">DataAwsInstance#get_user_data</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "fetch_user_data">]
        member _.FetchUserData(state: DataAwsInstanceState, value: HashiCorp.Cdktf.IResolvable) : DataAwsInstanceState =
            state.assignments.Add(fun config -> config.FetchUserData <- value)
            state : DataAwsInstanceState

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/instance#filter-1">DataAwsInstance#filter</a> Accepts: aws.IResolvable | aws.DataAwsInstance.DataAwsInstanceFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsInstanceState, value: HashiCorp.Cdktf.IResolvable) : DataAwsInstanceState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/instance#id-1">DataAwsInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsInstanceState, value: string) : DataAwsInstanceState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/instance#instance_id-1">DataAwsInstance#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: DataAwsInstanceState, value: string) : DataAwsInstanceState =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            state : DataAwsInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/instance#instance_tags-1">DataAwsInstance#instance_tags</a>.
        /// </summary>
        [<CustomOperation "instance_tags">]
        member _.InstanceTags(state: DataAwsInstanceState, value: seq<string * string>) : DataAwsInstanceState =
            state.assignments.Add(fun config -> config.InstanceTags <- dict value)
            state : DataAwsInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/instance#tags-1">DataAwsInstance#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsInstanceState, value: seq<string * string>) : DataAwsInstanceState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsInstanceState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/instance#timeouts-1">DataAwsInstance#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsInstanceState, value: aws.DataAwsInstance.DataAwsInstanceTimeouts) : DataAwsInstanceState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsInstanceState

        member _.Run(state: DataAwsInstanceState) : aws.DataAwsInstance.DataAwsInstance =
            let config = aws.DataAwsInstance.DataAwsInstanceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsInstance.DataAwsInstance(StackContext.get (), logicalId, config)
