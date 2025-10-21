namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2LocalGatewaysState = { assignments: ResizeArray<aws.DataAwsEc2LocalGateways.DataAwsEc2LocalGatewaysConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateways">aws_ec2_local_gateways</a>.
    /// </summary>
    type DataAwsEc2LocalGatewaysBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2LocalGatewaysState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2LocalGatewaysState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateways#filter-1">DataAwsEc2LocalGateways#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2LocalGateways.DataAwsEc2LocalGatewaysFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2LocalGatewaysState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2LocalGatewaysState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2LocalGatewaysState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateways#id-1">DataAwsEc2LocalGateways#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2LocalGatewaysState, value: string) : DataAwsEc2LocalGatewaysState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2LocalGatewaysState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateways#tags-1">DataAwsEc2LocalGateways#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2LocalGatewaysState, value: seq<string * string>) : DataAwsEc2LocalGatewaysState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2LocalGatewaysState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateways#timeouts-1">DataAwsEc2LocalGateways#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2LocalGatewaysState, value: aws.DataAwsEc2LocalGateways.DataAwsEc2LocalGatewaysTimeouts) : DataAwsEc2LocalGatewaysState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2LocalGatewaysState

        member _.Run(state: DataAwsEc2LocalGatewaysState) : aws.DataAwsEc2LocalGateways.DataAwsEc2LocalGateways =
            let config = aws.DataAwsEc2LocalGateways.DataAwsEc2LocalGatewaysConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2LocalGateways.DataAwsEc2LocalGateways(StackContext.get (), logicalId, config)
