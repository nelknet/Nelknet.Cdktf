namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NatGatewayState<'SubnetId> = { assignments: ResizeArray<aws.NatGateway.NatGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/nat_gateway">aws_nat_gateway</a>.
    /// </summary>
    type NatGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : NatGatewayState<Missing> =
            ({ assignments = ResizeArray() } : NatGatewayState<Missing>)

        member _.Zero(()) : NatGatewayState<Missing> =
            ({ assignments = ResizeArray() } : NatGatewayState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/nat_gateway#subnet_id-1">NatGateway#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: NatGatewayState<Missing>, value: string) : NatGatewayState<Present> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : NatGatewayState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/nat_gateway#allocation_id-1">NatGateway#allocation_id</a>.
        /// </summary>
        [<CustomOperation "allocation_id">]
        member _.AllocationId(state: NatGatewayState<'SubnetId>, value: string) : NatGatewayState<'SubnetId> =
            state.assignments.Add(fun config -> config.AllocationId <- value)
            state : NatGatewayState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/nat_gateway#connectivity_type-1">NatGateway#connectivity_type</a>.
        /// </summary>
        [<CustomOperation "connectivity_type">]
        member _.ConnectivityType(state: NatGatewayState<'SubnetId>, value: string) : NatGatewayState<'SubnetId> =
            state.assignments.Add(fun config -> config.ConnectivityType <- value)
            state : NatGatewayState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/nat_gateway#id-1">NatGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NatGatewayState<'SubnetId>, value: string) : NatGatewayState<'SubnetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NatGatewayState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/nat_gateway#private_ip-1">NatGateway#private_ip</a>.
        /// </summary>
        [<CustomOperation "private_ip">]
        member _.PrivateIp(state: NatGatewayState<'SubnetId>, value: string) : NatGatewayState<'SubnetId> =
            state.assignments.Add(fun config -> config.PrivateIp <- value)
            state : NatGatewayState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/nat_gateway#secondary_allocation_ids-1">NatGateway#secondary_allocation_ids</a>.
        /// </summary>
        [<CustomOperation "secondary_allocation_ids">]
        member _.SecondaryAllocationIds(state: NatGatewayState<'SubnetId>, value: seq<string>) : NatGatewayState<'SubnetId> =
            state.assignments.Add(fun config -> config.SecondaryAllocationIds <- (value |> Seq.toArray))
            state : NatGatewayState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/nat_gateway#secondary_private_ip_address_count-1">NatGateway#secondary_private_ip_address_count</a>.
        /// </summary>
        [<CustomOperation "secondary_private_ip_address_count">]
        member _.SecondaryPrivateIpAddressCount(state: NatGatewayState<'SubnetId>, value: double) : NatGatewayState<'SubnetId> =
            state.assignments.Add(fun config -> config.SecondaryPrivateIpAddressCount <- value)
            state : NatGatewayState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/nat_gateway#secondary_private_ip_addresses-1">NatGateway#secondary_private_ip_addresses</a>.
        /// </summary>
        [<CustomOperation "secondary_private_ip_addresses">]
        member _.SecondaryPrivateIpAddresses(state: NatGatewayState<'SubnetId>, value: seq<string>) : NatGatewayState<'SubnetId> =
            state.assignments.Add(fun config -> config.SecondaryPrivateIpAddresses <- (value |> Seq.toArray))
            state : NatGatewayState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/nat_gateway#tags-1">NatGateway#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NatGatewayState<'SubnetId>, value: seq<string * string>) : NatGatewayState<'SubnetId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NatGatewayState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/nat_gateway#tags_all-1">NatGateway#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: NatGatewayState<'SubnetId>, value: seq<string * string>) : NatGatewayState<'SubnetId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : NatGatewayState<'SubnetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/nat_gateway#timeouts-1">NatGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NatGatewayState<'SubnetId>, value: aws.NatGateway.NatGatewayTimeouts) : NatGatewayState<'SubnetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NatGatewayState<'SubnetId>

        member _.Run(state: NatGatewayState<Present>) : aws.NatGateway.NatGateway =
            let config = aws.NatGateway.NatGatewayConfig()
            for setter in state.assignments do
                setter config
            aws.NatGateway.NatGateway(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.natGateway: missing required arguments. Must call: subnet_id.", 9999, IsError = true)>]
        member _.Run(_: NatGatewayState<_>) : aws.NatGateway.NatGateway =
            Unchecked.defaultof<aws.NatGateway.NatGateway>
