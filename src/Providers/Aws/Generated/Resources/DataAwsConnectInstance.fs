namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsConnectInstanceState = { assignments: ResizeArray<aws.DataAwsConnectInstance.DataAwsConnectInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_instance">aws_connect_instance</a>.
    /// </summary>
    type DataAwsConnectInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsConnectInstanceState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsConnectInstanceState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_instance#id-1">DataAwsConnectInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsConnectInstanceState, value: string) : DataAwsConnectInstanceState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsConnectInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_instance#instance_alias-1">DataAwsConnectInstance#instance_alias</a>.
        /// </summary>
        [<CustomOperation "instance_alias">]
        member _.InstanceAlias(state: DataAwsConnectInstanceState, value: string) : DataAwsConnectInstanceState =
            state.assignments.Add(fun config -> config.InstanceAlias <- value)
            state : DataAwsConnectInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_instance#instance_id-1">DataAwsConnectInstance#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: DataAwsConnectInstanceState, value: string) : DataAwsConnectInstanceState =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            state : DataAwsConnectInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_instance#tags-1">DataAwsConnectInstance#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsConnectInstanceState, value: seq<string * string>) : DataAwsConnectInstanceState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsConnectInstanceState

        member _.Run(state: DataAwsConnectInstanceState) : aws.DataAwsConnectInstance.DataAwsConnectInstance =
            let config = aws.DataAwsConnectInstance.DataAwsConnectInstanceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsConnectInstance.DataAwsConnectInstance(StackContext.get (), logicalId, config)
