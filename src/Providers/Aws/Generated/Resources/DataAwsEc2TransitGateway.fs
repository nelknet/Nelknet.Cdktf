namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2TransitGatewayState = { assignments: ResizeArray<aws.DataAwsEc2TransitGateway.DataAwsEc2TransitGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway">aws_ec2_transit_gateway</a>.
    /// </summary>
    type DataAwsEc2TransitGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2TransitGatewayState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2TransitGatewayState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway#filter-1">DataAwsEc2TransitGateway#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2TransitGateway.DataAwsEc2TransitGatewayFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2TransitGatewayState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2TransitGatewayState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2TransitGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway#id-1">DataAwsEc2TransitGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2TransitGatewayState, value: string) : DataAwsEc2TransitGatewayState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2TransitGatewayState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway#tags-1">DataAwsEc2TransitGateway#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2TransitGatewayState, value: seq<string * string>) : DataAwsEc2TransitGatewayState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2TransitGatewayState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway#timeouts-1">DataAwsEc2TransitGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2TransitGatewayState, value: aws.DataAwsEc2TransitGateway.DataAwsEc2TransitGatewayTimeouts) : DataAwsEc2TransitGatewayState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2TransitGatewayState

        member _.Run(state: DataAwsEc2TransitGatewayState) : aws.DataAwsEc2TransitGateway.DataAwsEc2TransitGateway =
            let config = aws.DataAwsEc2TransitGateway.DataAwsEc2TransitGatewayConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2TransitGateway.DataAwsEc2TransitGateway(StackContext.get (), logicalId, config)
