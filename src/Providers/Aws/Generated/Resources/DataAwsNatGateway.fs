namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsNatGatewayState = { assignments: ResizeArray<aws.DataAwsNatGateway.DataAwsNatGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/nat_gateway">aws_nat_gateway</a>.
    /// </summary>
    type DataAwsNatGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsNatGatewayState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsNatGatewayState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/nat_gateway#filter-1">DataAwsNatGateway#filter</a> Accepts: aws.IResolvable | aws.DataAwsNatGateway.DataAwsNatGatewayFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsNatGatewayState, value: HashiCorp.Cdktf.IResolvable) : DataAwsNatGatewayState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsNatGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/nat_gateway#id-1">DataAwsNatGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsNatGatewayState, value: string) : DataAwsNatGatewayState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsNatGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/nat_gateway#state-1">DataAwsNatGateway#state</a>.
        /// </summary>
        [<CustomOperation "state">]
        member _.State(state: DataAwsNatGatewayState, value: string) : DataAwsNatGatewayState =
            state.assignments.Add(fun config -> config.State <- value)
            state : DataAwsNatGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/nat_gateway#subnet_id-1">DataAwsNatGateway#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: DataAwsNatGatewayState, value: string) : DataAwsNatGatewayState =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            state : DataAwsNatGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/nat_gateway#tags-1">DataAwsNatGateway#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsNatGatewayState, value: seq<string * string>) : DataAwsNatGatewayState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsNatGatewayState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/nat_gateway#timeouts-1">DataAwsNatGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsNatGatewayState, value: aws.DataAwsNatGateway.DataAwsNatGatewayTimeouts) : DataAwsNatGatewayState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsNatGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/nat_gateway#vpc_id-1">DataAwsNatGateway#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: DataAwsNatGatewayState, value: string) : DataAwsNatGatewayState =
            state.assignments.Add(fun config -> config.VpcId <- value)
            state : DataAwsNatGatewayState

        member _.Run(state: DataAwsNatGatewayState) : aws.DataAwsNatGateway.DataAwsNatGateway =
            let config = aws.DataAwsNatGateway.DataAwsNatGatewayConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsNatGateway.DataAwsNatGateway(StackContext.get (), logicalId, config)
