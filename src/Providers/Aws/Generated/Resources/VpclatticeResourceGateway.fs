namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpclatticeResourceGatewayState<'Name, 'SubnetIds, 'VpcId> = { assignments: ResizeArray<aws.VpclatticeResourceGateway.VpclatticeResourceGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_resource_gateway">aws_vpclattice_resource_gateway</a>.
    /// </summary>
    type VpclatticeResourceGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpclatticeResourceGatewayState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VpclatticeResourceGatewayState<Missing, Missing, Missing>)

        member _.Zero(()) : VpclatticeResourceGatewayState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VpclatticeResourceGatewayState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_resource_gateway#name-1">VpclatticeResourceGateway#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VpclatticeResourceGatewayState<Missing, 'SubnetIds, 'VpcId>, value: string) : VpclatticeResourceGatewayState<Present, 'SubnetIds, 'VpcId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VpclatticeResourceGatewayState<Present, 'SubnetIds, 'VpcId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_resource_gateway#subnet_ids-1">VpclatticeResourceGateway#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: VpclatticeResourceGatewayState<'Name, Missing, 'VpcId>, value: seq<string>) : VpclatticeResourceGatewayState<'Name, Present, 'VpcId> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : VpclatticeResourceGatewayState<'Name, Present, 'VpcId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_resource_gateway#vpc_id-1">VpclatticeResourceGateway#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: VpclatticeResourceGatewayState<'Name, 'SubnetIds, Missing>, value: string) : VpclatticeResourceGatewayState<'Name, 'SubnetIds, Present> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            ({ assignments = state.assignments } : VpclatticeResourceGatewayState<'Name, 'SubnetIds, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_resource_gateway#ip_address_type-1">VpclatticeResourceGateway#ip_address_type</a>.
        /// </summary>
        [<CustomOperation "ip_address_type">]
        member _.IpAddressType(state: VpclatticeResourceGatewayState<'Name, 'SubnetIds, 'VpcId>, value: string) : VpclatticeResourceGatewayState<'Name, 'SubnetIds, 'VpcId> =
            state.assignments.Add(fun config -> config.IpAddressType <- value)
            state : VpclatticeResourceGatewayState<'Name, 'SubnetIds, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_resource_gateway#security_group_ids-1">VpclatticeResourceGateway#security_group_ids</a>.
        /// </summary>
        [<CustomOperation "security_group_ids">]
        member _.SecurityGroupIds(state: VpclatticeResourceGatewayState<'Name, 'SubnetIds, 'VpcId>, value: seq<string>) : VpclatticeResourceGatewayState<'Name, 'SubnetIds, 'VpcId> =
            state.assignments.Add(fun config -> config.SecurityGroupIds <- (value |> Seq.toArray))
            state : VpclatticeResourceGatewayState<'Name, 'SubnetIds, 'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_resource_gateway#tags-1">VpclatticeResourceGateway#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpclatticeResourceGatewayState<'Name, 'SubnetIds, 'VpcId>, value: seq<string * string>) : VpclatticeResourceGatewayState<'Name, 'SubnetIds, 'VpcId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpclatticeResourceGatewayState<'Name, 'SubnetIds, 'VpcId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_resource_gateway#timeouts-1">VpclatticeResourceGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpclatticeResourceGatewayState<'Name, 'SubnetIds, 'VpcId>, value: aws.VpclatticeResourceGateway.VpclatticeResourceGatewayTimeouts) : VpclatticeResourceGatewayState<'Name, 'SubnetIds, 'VpcId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpclatticeResourceGatewayState<'Name, 'SubnetIds, 'VpcId>

        member _.Run(state: VpclatticeResourceGatewayState<Present, Present, Present>) : aws.VpclatticeResourceGateway.VpclatticeResourceGateway =
            let config = aws.VpclatticeResourceGateway.VpclatticeResourceGatewayConfig()
            for setter in state.assignments do
                setter config
            aws.VpclatticeResourceGateway.VpclatticeResourceGateway(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpclatticeResourceGateway: missing required arguments. Must call: name, subnet_ids, vpc_id.", 9999, IsError = true)>]
        member _.Run(_: VpclatticeResourceGatewayState<_, _, _>) : aws.VpclatticeResourceGateway.VpclatticeResourceGateway =
            Unchecked.defaultof<aws.VpclatticeResourceGateway.VpclatticeResourceGateway>
