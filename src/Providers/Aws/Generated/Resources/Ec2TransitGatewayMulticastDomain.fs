namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2TransitGatewayMulticastDomainState<'TransitGatewayId> = { assignments: ResizeArray<aws.Ec2TransitGatewayMulticastDomain.Ec2TransitGatewayMulticastDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_multicast_domain">aws_ec2_transit_gateway_multicast_domain</a>.
    /// </summary>
    type Ec2TransitGatewayMulticastDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2TransitGatewayMulticastDomainState<Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayMulticastDomainState<Missing>)

        member _.Zero(()) : Ec2TransitGatewayMulticastDomainState<Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayMulticastDomainState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_multicast_domain#transit_gateway_id-1">Ec2TransitGatewayMulticastDomain#transit_gateway_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_id">]
        member _.TransitGatewayId(state: Ec2TransitGatewayMulticastDomainState<Missing>, value: string) : Ec2TransitGatewayMulticastDomainState<Present> =
            state.assignments.Add(fun config -> config.TransitGatewayId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayMulticastDomainState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_multicast_domain#auto_accept_shared_associations-1">Ec2TransitGatewayMulticastDomain#auto_accept_shared_associations</a>.
        /// </summary>
        [<CustomOperation "auto_accept_shared_associations">]
        member _.AutoAcceptSharedAssociations(state: Ec2TransitGatewayMulticastDomainState<'TransitGatewayId>, value: string) : Ec2TransitGatewayMulticastDomainState<'TransitGatewayId> =
            state.assignments.Add(fun config -> config.AutoAcceptSharedAssociations <- value)
            state : Ec2TransitGatewayMulticastDomainState<'TransitGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_multicast_domain#id-1">Ec2TransitGatewayMulticastDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2TransitGatewayMulticastDomainState<'TransitGatewayId>, value: string) : Ec2TransitGatewayMulticastDomainState<'TransitGatewayId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2TransitGatewayMulticastDomainState<'TransitGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_multicast_domain#igmpv2_support-1">Ec2TransitGatewayMulticastDomain#igmpv2_support</a>.
        /// </summary>
        [<CustomOperation "igmpv2_support">]
        member _.Igmpv2Support(state: Ec2TransitGatewayMulticastDomainState<'TransitGatewayId>, value: string) : Ec2TransitGatewayMulticastDomainState<'TransitGatewayId> =
            state.assignments.Add(fun config -> config.Igmpv2Support <- value)
            state : Ec2TransitGatewayMulticastDomainState<'TransitGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_multicast_domain#static_sources_support-1">Ec2TransitGatewayMulticastDomain#static_sources_support</a>.
        /// </summary>
        [<CustomOperation "static_sources_support">]
        member _.StaticSourcesSupport(state: Ec2TransitGatewayMulticastDomainState<'TransitGatewayId>, value: string) : Ec2TransitGatewayMulticastDomainState<'TransitGatewayId> =
            state.assignments.Add(fun config -> config.StaticSourcesSupport <- value)
            state : Ec2TransitGatewayMulticastDomainState<'TransitGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_multicast_domain#tags-1">Ec2TransitGatewayMulticastDomain#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Ec2TransitGatewayMulticastDomainState<'TransitGatewayId>, value: seq<string * string>) : Ec2TransitGatewayMulticastDomainState<'TransitGatewayId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Ec2TransitGatewayMulticastDomainState<'TransitGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_multicast_domain#tags_all-1">Ec2TransitGatewayMulticastDomain#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Ec2TransitGatewayMulticastDomainState<'TransitGatewayId>, value: seq<string * string>) : Ec2TransitGatewayMulticastDomainState<'TransitGatewayId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Ec2TransitGatewayMulticastDomainState<'TransitGatewayId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_multicast_domain#timeouts-1">Ec2TransitGatewayMulticastDomain#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Ec2TransitGatewayMulticastDomainState<'TransitGatewayId>, value: aws.Ec2TransitGatewayMulticastDomain.Ec2TransitGatewayMulticastDomainTimeouts) : Ec2TransitGatewayMulticastDomainState<'TransitGatewayId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Ec2TransitGatewayMulticastDomainState<'TransitGatewayId>

        member _.Run(state: Ec2TransitGatewayMulticastDomainState<Present>) : aws.Ec2TransitGatewayMulticastDomain.Ec2TransitGatewayMulticastDomain =
            let config = aws.Ec2TransitGatewayMulticastDomain.Ec2TransitGatewayMulticastDomainConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2TransitGatewayMulticastDomain.Ec2TransitGatewayMulticastDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2TransitGatewayMulticastDomain: missing required arguments. Must call: transit_gateway_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2TransitGatewayMulticastDomainState<_>) : aws.Ec2TransitGatewayMulticastDomain.Ec2TransitGatewayMulticastDomain =
            Unchecked.defaultof<aws.Ec2TransitGatewayMulticastDomain.Ec2TransitGatewayMulticastDomain>
