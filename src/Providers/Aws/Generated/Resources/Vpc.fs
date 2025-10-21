namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcState = { assignments: ResizeArray<aws.Vpc.VpcConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc">aws_vpc</a>.
    /// </summary>
    type VpcBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcState =
            { assignments = ResizeArray() }

        member _.Zero(()) : VpcState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc#assign_generated_ipv6_cidr_block-1">Vpc#assign_generated_ipv6_cidr_block</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "assign_generated_ipv6_cidr_block">]
        member _.AssignGeneratedIpv6CidrBlock(state: VpcState, value: bool) : VpcState =
            state.assignments.Add(fun config -> config.AssignGeneratedIpv6CidrBlock <- value)
            state : VpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc#assign_generated_ipv6_cidr_block-1">Vpc#assign_generated_ipv6_cidr_block</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "assign_generated_ipv6_cidr_block">]
        member _.AssignGeneratedIpv6CidrBlock(state: VpcState, value: HashiCorp.Cdktf.IResolvable) : VpcState =
            state.assignments.Add(fun config -> config.AssignGeneratedIpv6CidrBlock <- value)
            state : VpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc#cidr_block-1">Vpc#cidr_block</a>.
        /// </summary>
        [<CustomOperation "cidr_block">]
        member _.CidrBlock(state: VpcState, value: string) : VpcState =
            state.assignments.Add(fun config -> config.CidrBlock <- value)
            state : VpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc#enable_dns_hostnames-1">Vpc#enable_dns_hostnames</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_dns_hostnames">]
        member _.EnableDnsHostnames(state: VpcState, value: bool) : VpcState =
            state.assignments.Add(fun config -> config.EnableDnsHostnames <- value)
            state : VpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc#enable_dns_hostnames-1">Vpc#enable_dns_hostnames</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_dns_hostnames">]
        member _.EnableDnsHostnames(state: VpcState, value: HashiCorp.Cdktf.IResolvable) : VpcState =
            state.assignments.Add(fun config -> config.EnableDnsHostnames <- value)
            state : VpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc#enable_dns_support-1">Vpc#enable_dns_support</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_dns_support">]
        member _.EnableDnsSupport(state: VpcState, value: bool) : VpcState =
            state.assignments.Add(fun config -> config.EnableDnsSupport <- value)
            state : VpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc#enable_dns_support-1">Vpc#enable_dns_support</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_dns_support">]
        member _.EnableDnsSupport(state: VpcState, value: HashiCorp.Cdktf.IResolvable) : VpcState =
            state.assignments.Add(fun config -> config.EnableDnsSupport <- value)
            state : VpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc#enable_network_address_usage_metrics-1">Vpc#enable_network_address_usage_metrics</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_network_address_usage_metrics">]
        member _.EnableNetworkAddressUsageMetrics(state: VpcState, value: bool) : VpcState =
            state.assignments.Add(fun config -> config.EnableNetworkAddressUsageMetrics <- value)
            state : VpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc#enable_network_address_usage_metrics-1">Vpc#enable_network_address_usage_metrics</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_network_address_usage_metrics">]
        member _.EnableNetworkAddressUsageMetrics(state: VpcState, value: HashiCorp.Cdktf.IResolvable) : VpcState =
            state.assignments.Add(fun config -> config.EnableNetworkAddressUsageMetrics <- value)
            state : VpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc#id-1">Vpc#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpcState, value: string) : VpcState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc#instance_tenancy-1">Vpc#instance_tenancy</a>.
        /// </summary>
        [<CustomOperation "instance_tenancy">]
        member _.InstanceTenancy(state: VpcState, value: string) : VpcState =
            state.assignments.Add(fun config -> config.InstanceTenancy <- value)
            state : VpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc#ipv4_ipam_pool_id-1">Vpc#ipv4_ipam_pool_id</a>.
        /// </summary>
        [<CustomOperation "ipv4_ipam_pool_id">]
        member _.Ipv4IpamPoolId(state: VpcState, value: string) : VpcState =
            state.assignments.Add(fun config -> config.Ipv4IpamPoolId <- value)
            state : VpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc#ipv4_netmask_length-1">Vpc#ipv4_netmask_length</a>.
        /// </summary>
        [<CustomOperation "ipv4_netmask_length">]
        member _.Ipv4NetmaskLength(state: VpcState, value: double) : VpcState =
            state.assignments.Add(fun config -> config.Ipv4NetmaskLength <- value)
            state : VpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc#ipv6_cidr_block-1">Vpc#ipv6_cidr_block</a>.
        /// </summary>
        [<CustomOperation "ipv6_cidr_block">]
        member _.Ipv6CidrBlock(state: VpcState, value: string) : VpcState =
            state.assignments.Add(fun config -> config.Ipv6CidrBlock <- value)
            state : VpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc#ipv6_cidr_block_network_border_group-1">Vpc#ipv6_cidr_block_network_border_group</a>.
        /// </summary>
        [<CustomOperation "ipv6_cidr_block_network_border_group">]
        member _.Ipv6CidrBlockNetworkBorderGroup(state: VpcState, value: string) : VpcState =
            state.assignments.Add(fun config -> config.Ipv6CidrBlockNetworkBorderGroup <- value)
            state : VpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc#ipv6_ipam_pool_id-1">Vpc#ipv6_ipam_pool_id</a>.
        /// </summary>
        [<CustomOperation "ipv6_ipam_pool_id">]
        member _.Ipv6IpamPoolId(state: VpcState, value: string) : VpcState =
            state.assignments.Add(fun config -> config.Ipv6IpamPoolId <- value)
            state : VpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc#ipv6_netmask_length-1">Vpc#ipv6_netmask_length</a>.
        /// </summary>
        [<CustomOperation "ipv6_netmask_length">]
        member _.Ipv6NetmaskLength(state: VpcState, value: double) : VpcState =
            state.assignments.Add(fun config -> config.Ipv6NetmaskLength <- value)
            state : VpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc#tags-1">Vpc#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpcState, value: seq<string * string>) : VpcState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc#tags_all-1">Vpc#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: VpcState, value: seq<string * string>) : VpcState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : VpcState

        member _.Run(state: VpcState) : aws.Vpc.Vpc =
            let config = aws.Vpc.VpcConfig()
            for setter in state.assignments do
                setter config
            aws.Vpc.Vpc(StackContext.get (), logicalId, config)
