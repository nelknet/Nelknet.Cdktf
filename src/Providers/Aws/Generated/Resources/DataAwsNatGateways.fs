namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsNatGatewaysState = { assignments: ResizeArray<aws.DataAwsNatGateways.DataAwsNatGatewaysConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/nat_gateways">aws_nat_gateways</a>.
    /// </summary>
    type DataAwsNatGatewaysBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsNatGatewaysState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsNatGatewaysState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/nat_gateways#filter-1">DataAwsNatGateways#filter</a> Accepts: aws.IResolvable | aws.DataAwsNatGateways.DataAwsNatGatewaysFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsNatGatewaysState, value: HashiCorp.Cdktf.IResolvable) : DataAwsNatGatewaysState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsNatGatewaysState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/nat_gateways#id-1">DataAwsNatGateways#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsNatGatewaysState, value: string) : DataAwsNatGatewaysState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsNatGatewaysState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/nat_gateways#tags-1">DataAwsNatGateways#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsNatGatewaysState, value: seq<string * string>) : DataAwsNatGatewaysState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsNatGatewaysState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/nat_gateways#timeouts-1">DataAwsNatGateways#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsNatGatewaysState, value: aws.DataAwsNatGateways.DataAwsNatGatewaysTimeouts) : DataAwsNatGatewaysState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsNatGatewaysState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/nat_gateways#vpc_id-1">DataAwsNatGateways#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: DataAwsNatGatewaysState, value: string) : DataAwsNatGatewaysState =
            state.assignments.Add(fun config -> config.VpcId <- value)
            state : DataAwsNatGatewaysState

        member _.Run(state: DataAwsNatGatewaysState) : aws.DataAwsNatGateways.DataAwsNatGateways =
            let config = aws.DataAwsNatGateways.DataAwsNatGatewaysConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsNatGateways.DataAwsNatGateways(StackContext.get (), logicalId, config)
