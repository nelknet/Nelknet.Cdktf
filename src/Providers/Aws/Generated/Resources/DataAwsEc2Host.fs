namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2HostState = { assignments: ResizeArray<aws.DataAwsEc2Host.DataAwsEc2HostConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_host">aws_ec2_host</a>.
    /// </summary>
    type DataAwsEc2HostBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2HostState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2HostState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_host#filter-1">DataAwsEc2Host#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2Host.DataAwsEc2HostFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2HostState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2HostState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2HostState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_host#host_id-1">DataAwsEc2Host#host_id</a>.
        /// </summary>
        [<CustomOperation "host_id">]
        member _.HostId(state: DataAwsEc2HostState, value: string) : DataAwsEc2HostState =
            state.assignments.Add(fun config -> config.HostId <- value)
            state : DataAwsEc2HostState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_host#id-1">DataAwsEc2Host#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2HostState, value: string) : DataAwsEc2HostState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2HostState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_host#tags-1">DataAwsEc2Host#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2HostState, value: seq<string * string>) : DataAwsEc2HostState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2HostState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_host#timeouts-1">DataAwsEc2Host#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2HostState, value: aws.DataAwsEc2Host.DataAwsEc2HostTimeouts) : DataAwsEc2HostState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2HostState

        member _.Run(state: DataAwsEc2HostState) : aws.DataAwsEc2Host.DataAwsEc2Host =
            let config = aws.DataAwsEc2Host.DataAwsEc2HostConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2Host.DataAwsEc2Host(StackContext.get (), logicalId, config)
