namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcIpamPoolCidrState<'IpamPoolId> = { assignments: ResizeArray<aws.VpcIpamPoolCidr.VpcIpamPoolCidrConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool_cidr">aws_vpc_ipam_pool_cidr</a>.
    /// </summary>
    type VpcIpamPoolCidrBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcIpamPoolCidrState<Missing> =
            ({ assignments = ResizeArray() } : VpcIpamPoolCidrState<Missing>)

        member _.Zero(()) : VpcIpamPoolCidrState<Missing> =
            ({ assignments = ResizeArray() } : VpcIpamPoolCidrState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool_cidr#ipam_pool_id-1">VpcIpamPoolCidr#ipam_pool_id</a>.
        /// </summary>
        [<CustomOperation "ipam_pool_id">]
        member _.IpamPoolId(state: VpcIpamPoolCidrState<Missing>, value: string) : VpcIpamPoolCidrState<Present> =
            state.assignments.Add(fun config -> config.IpamPoolId <- value)
            ({ assignments = state.assignments } : VpcIpamPoolCidrState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool_cidr#cidr-1">VpcIpamPoolCidr#cidr</a>.
        /// </summary>
        [<CustomOperation "cidr">]
        member _.Cidr(state: VpcIpamPoolCidrState<'IpamPoolId>, value: string) : VpcIpamPoolCidrState<'IpamPoolId> =
            state.assignments.Add(fun config -> config.Cidr <- value)
            state : VpcIpamPoolCidrState<'IpamPoolId>

        /// <summary>
        /// cidr_authorization_context block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool_cidr#cidr_authorization_context-1">VpcIpamPoolCidr#cidr_authorization_context</a>
        /// </summary>
        [<CustomOperation "cidr_authorization_context">]
        member _.CidrAuthorizationContext(state: VpcIpamPoolCidrState<'IpamPoolId>, value: aws.VpcIpamPoolCidr.VpcIpamPoolCidrCidrAuthorizationContext) : VpcIpamPoolCidrState<'IpamPoolId> =
            state.assignments.Add(fun config -> config.CidrAuthorizationContext <- value)
            state : VpcIpamPoolCidrState<'IpamPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool_cidr#id-1">VpcIpamPoolCidr#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpcIpamPoolCidrState<'IpamPoolId>, value: string) : VpcIpamPoolCidrState<'IpamPoolId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpcIpamPoolCidrState<'IpamPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool_cidr#netmask_length-1">VpcIpamPoolCidr#netmask_length</a>.
        /// </summary>
        [<CustomOperation "netmask_length">]
        member _.NetmaskLength(state: VpcIpamPoolCidrState<'IpamPoolId>, value: double) : VpcIpamPoolCidrState<'IpamPoolId> =
            state.assignments.Add(fun config -> config.NetmaskLength <- value)
            state : VpcIpamPoolCidrState<'IpamPoolId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool_cidr#timeouts-1">VpcIpamPoolCidr#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpcIpamPoolCidrState<'IpamPoolId>, value: aws.VpcIpamPoolCidr.VpcIpamPoolCidrTimeouts) : VpcIpamPoolCidrState<'IpamPoolId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpcIpamPoolCidrState<'IpamPoolId>

        member _.Run(state: VpcIpamPoolCidrState<Present>) : aws.VpcIpamPoolCidr.VpcIpamPoolCidr =
            let config = aws.VpcIpamPoolCidr.VpcIpamPoolCidrConfig()
            for setter in state.assignments do
                setter config
            aws.VpcIpamPoolCidr.VpcIpamPoolCidr(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcIpamPoolCidr: missing required arguments. Must call: ipam_pool_id.", 9999, IsError = true)>]
        member _.Run(_: VpcIpamPoolCidrState<_>) : aws.VpcIpamPoolCidr.VpcIpamPoolCidr =
            Unchecked.defaultof<aws.VpcIpamPoolCidr.VpcIpamPoolCidr>
