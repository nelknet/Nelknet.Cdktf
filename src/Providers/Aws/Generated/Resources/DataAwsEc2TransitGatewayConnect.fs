namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2TransitGatewayConnectState = { assignments: ResizeArray<aws.DataAwsEc2TransitGatewayConnect.DataAwsEc2TransitGatewayConnectConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_connect">aws_ec2_transit_gateway_connect</a>.
    /// </summary>
    type DataAwsEc2TransitGatewayConnectBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2TransitGatewayConnectState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2TransitGatewayConnectState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_connect#filter-1">DataAwsEc2TransitGatewayConnect#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2TransitGatewayConnect.DataAwsEc2TransitGatewayConnectFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2TransitGatewayConnectState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2TransitGatewayConnectState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2TransitGatewayConnectState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_connect#id-1">DataAwsEc2TransitGatewayConnect#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2TransitGatewayConnectState, value: string) : DataAwsEc2TransitGatewayConnectState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2TransitGatewayConnectState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_connect#tags-1">DataAwsEc2TransitGatewayConnect#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2TransitGatewayConnectState, value: seq<string * string>) : DataAwsEc2TransitGatewayConnectState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2TransitGatewayConnectState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_connect#timeouts-1">DataAwsEc2TransitGatewayConnect#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2TransitGatewayConnectState, value: aws.DataAwsEc2TransitGatewayConnect.DataAwsEc2TransitGatewayConnectTimeouts) : DataAwsEc2TransitGatewayConnectState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2TransitGatewayConnectState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_connect#transit_gateway_connect_id-1">DataAwsEc2TransitGatewayConnect#transit_gateway_connect_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_connect_id">]
        member _.TransitGatewayConnectId(state: DataAwsEc2TransitGatewayConnectState, value: string) : DataAwsEc2TransitGatewayConnectState =
            state.assignments.Add(fun config -> config.TransitGatewayConnectId <- value)
            state : DataAwsEc2TransitGatewayConnectState

        member _.Run(state: DataAwsEc2TransitGatewayConnectState) : aws.DataAwsEc2TransitGatewayConnect.DataAwsEc2TransitGatewayConnect =
            let config = aws.DataAwsEc2TransitGatewayConnect.DataAwsEc2TransitGatewayConnectConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2TransitGatewayConnect.DataAwsEc2TransitGatewayConnect(StackContext.get (), logicalId, config)
