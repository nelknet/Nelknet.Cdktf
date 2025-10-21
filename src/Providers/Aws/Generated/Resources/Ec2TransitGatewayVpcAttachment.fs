namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId> = { assignments: ResizeArray<aws.Ec2TransitGatewayVpcAttachment.Ec2TransitGatewayVpcAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_vpc_attachment">aws_ec2_transit_gateway_vpc_attachment</a>.
    /// </summary>
    type Ec2TransitGatewayVpcAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2TransitGatewayVpcAttachmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayVpcAttachmentState<Missing, Missing, Missing>)

        member _.Zero(()) : Ec2TransitGatewayVpcAttachmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayVpcAttachmentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_vpc_attachment#subnet_ids-1">Ec2TransitGatewayVpcAttachment#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: Ec2TransitGatewayVpcAttachmentState<Missing, 'TransitGatewayId, 'VpcId>, value: seq<string>) : Ec2TransitGatewayVpcAttachmentState<Present, 'TransitGatewayId, 'VpcId> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : Ec2TransitGatewayVpcAttachmentState<Present, 'TransitGatewayId, 'VpcId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_vpc_attachment#transit_gateway_id-1">Ec2TransitGatewayVpcAttachment#transit_gateway_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_id">]
        member _.TransitGatewayId(state: Ec2TransitGatewayVpcAttachmentState<'SubnetIds, Missing, 'VpcId>, value: string) : Ec2TransitGatewayVpcAttachmentState<'SubnetIds, Present, 'VpcId> =
            state.assignments.Add(fun config -> config.TransitGatewayId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayVpcAttachmentState<'SubnetIds, Present, 'VpcId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_vpc_attachment#vpc_id-1">Ec2TransitGatewayVpcAttachment#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, Missing>, value: string) : Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, Present> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_vpc_attachment#appliance_mode_support-1">Ec2TransitGatewayVpcAttachment#appliance_mode_support</a>.
        /// </summary>
        [<CustomOperation "appliance_mode_support">]
        member _.ApplianceModeSupport(state: Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId>, value: string) : Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId> =
            state.assignments.Add(fun config -> config.ApplianceModeSupport <- value)
            state : Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_vpc_attachment#dns_support-1">Ec2TransitGatewayVpcAttachment#dns_support</a>.
        /// </summary>
        [<CustomOperation "dns_support">]
        member _.DnsSupport(state: Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId>, value: string) : Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId> =
            state.assignments.Add(fun config -> config.DnsSupport <- value)
            state : Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_vpc_attachment#id-1">Ec2TransitGatewayVpcAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId>, value: string) : Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_vpc_attachment#ipv6_support-1">Ec2TransitGatewayVpcAttachment#ipv6_support</a>.
        /// </summary>
        [<CustomOperation "ipv6_support">]
        member _.Ipv6Support(state: Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId>, value: string) : Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId> =
            state.assignments.Add(fun config -> config.Ipv6Support <- value)
            state : Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_vpc_attachment#security_group_referencing_support-1">Ec2TransitGatewayVpcAttachment#security_group_referencing_support</a>.
        /// </summary>
        [<CustomOperation "security_group_referencing_support">]
        member _.SecurityGroupReferencingSupport(state: Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId>, value: string) : Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId> =
            state.assignments.Add(fun config -> config.SecurityGroupReferencingSupport <- value)
            state : Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_vpc_attachment#tags-1">Ec2TransitGatewayVpcAttachment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId>, value: seq<string * string>) : Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_vpc_attachment#tags_all-1">Ec2TransitGatewayVpcAttachment#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId>, value: seq<string * string>) : Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_vpc_attachment#transit_gateway_default_route_table_association-1">Ec2TransitGatewayVpcAttachment#transit_gateway_default_route_table_association</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "transit_gateway_default_route_table_association">]
        member _.TransitGatewayDefaultRouteTableAssociation(state: Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId>, value: bool) : Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId> =
            state.assignments.Add(fun config -> config.TransitGatewayDefaultRouteTableAssociation <- value)
            state : Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_vpc_attachment#transit_gateway_default_route_table_association-1">Ec2TransitGatewayVpcAttachment#transit_gateway_default_route_table_association</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "transit_gateway_default_route_table_association">]
        member _.TransitGatewayDefaultRouteTableAssociation(state: Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId>, value: HashiCorp.Cdktf.IResolvable) : Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId> =
            state.assignments.Add(fun config -> config.TransitGatewayDefaultRouteTableAssociation <- value)
            state : Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_vpc_attachment#transit_gateway_default_route_table_propagation-1">Ec2TransitGatewayVpcAttachment#transit_gateway_default_route_table_propagation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "transit_gateway_default_route_table_propagation">]
        member _.TransitGatewayDefaultRouteTablePropagation(state: Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId>, value: bool) : Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId> =
            state.assignments.Add(fun config -> config.TransitGatewayDefaultRouteTablePropagation <- value)
            state : Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_vpc_attachment#transit_gateway_default_route_table_propagation-1">Ec2TransitGatewayVpcAttachment#transit_gateway_default_route_table_propagation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "transit_gateway_default_route_table_propagation">]
        member _.TransitGatewayDefaultRouteTablePropagation(state: Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId>, value: HashiCorp.Cdktf.IResolvable) : Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId> =
            state.assignments.Add(fun config -> config.TransitGatewayDefaultRouteTablePropagation <- value)
            state : Ec2TransitGatewayVpcAttachmentState<'SubnetIds, 'TransitGatewayId, 'VpcId>

        member _.Run(state: Ec2TransitGatewayVpcAttachmentState<Present, Present, Present>) : aws.Ec2TransitGatewayVpcAttachment.Ec2TransitGatewayVpcAttachment =
            let config = aws.Ec2TransitGatewayVpcAttachment.Ec2TransitGatewayVpcAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2TransitGatewayVpcAttachment.Ec2TransitGatewayVpcAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2TransitGatewayVpcAttachment: missing required arguments. Must call: subnet_ids, transit_gateway_id, vpc_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2TransitGatewayVpcAttachmentState<_, _, _>) : aws.Ec2TransitGatewayVpcAttachment.Ec2TransitGatewayVpcAttachment =
            Unchecked.defaultof<aws.Ec2TransitGatewayVpcAttachment.Ec2TransitGatewayVpcAttachment>
