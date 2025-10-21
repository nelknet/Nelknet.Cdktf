namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2TransitGatewayMulticastDomainState = { assignments: ResizeArray<aws.DataAwsEc2TransitGatewayMulticastDomain.DataAwsEc2TransitGatewayMulticastDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_multicast_domain">aws_ec2_transit_gateway_multicast_domain</a>.
    /// </summary>
    type DataAwsEc2TransitGatewayMulticastDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2TransitGatewayMulticastDomainState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2TransitGatewayMulticastDomainState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_multicast_domain#filter-1">DataAwsEc2TransitGatewayMulticastDomain#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2TransitGatewayMulticastDomain.DataAwsEc2TransitGatewayMulticastDomainFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2TransitGatewayMulticastDomainState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2TransitGatewayMulticastDomainState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2TransitGatewayMulticastDomainState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_multicast_domain#id-1">DataAwsEc2TransitGatewayMulticastDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2TransitGatewayMulticastDomainState, value: string) : DataAwsEc2TransitGatewayMulticastDomainState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2TransitGatewayMulticastDomainState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_multicast_domain#tags-1">DataAwsEc2TransitGatewayMulticastDomain#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2TransitGatewayMulticastDomainState, value: seq<string * string>) : DataAwsEc2TransitGatewayMulticastDomainState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2TransitGatewayMulticastDomainState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_multicast_domain#timeouts-1">DataAwsEc2TransitGatewayMulticastDomain#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2TransitGatewayMulticastDomainState, value: aws.DataAwsEc2TransitGatewayMulticastDomain.DataAwsEc2TransitGatewayMulticastDomainTimeouts) : DataAwsEc2TransitGatewayMulticastDomainState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2TransitGatewayMulticastDomainState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_multicast_domain#transit_gateway_multicast_domain_id-1">DataAwsEc2TransitGatewayMulticastDomain#transit_gateway_multicast_domain_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_multicast_domain_id">]
        member _.TransitGatewayMulticastDomainId(state: DataAwsEc2TransitGatewayMulticastDomainState, value: string) : DataAwsEc2TransitGatewayMulticastDomainState =
            state.assignments.Add(fun config -> config.TransitGatewayMulticastDomainId <- value)
            state : DataAwsEc2TransitGatewayMulticastDomainState

        member _.Run(state: DataAwsEc2TransitGatewayMulticastDomainState) : aws.DataAwsEc2TransitGatewayMulticastDomain.DataAwsEc2TransitGatewayMulticastDomain =
            let config = aws.DataAwsEc2TransitGatewayMulticastDomain.DataAwsEc2TransitGatewayMulticastDomainConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2TransitGatewayMulticastDomain.DataAwsEc2TransitGatewayMulticastDomain(StackContext.get (), logicalId, config)
