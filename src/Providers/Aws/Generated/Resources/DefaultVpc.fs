namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DefaultVpcState = { assignments: ResizeArray<aws.DefaultVpc.DefaultVpcConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_vpc">aws_default_vpc</a>.
    /// </summary>
    type DefaultVpcBuilder(logicalId: string) =
        member _.Yield(_: unit) : DefaultVpcState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DefaultVpcState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_vpc#assign_generated_ipv6_cidr_block-1">DefaultVpc#assign_generated_ipv6_cidr_block</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "assign_generated_ipv6_cidr_block">]
        member _.AssignGeneratedIpv6CidrBlock(state: DefaultVpcState, value: bool) : DefaultVpcState =
            state.assignments.Add(fun config -> config.AssignGeneratedIpv6CidrBlock <- value)
            state : DefaultVpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_vpc#assign_generated_ipv6_cidr_block-1">DefaultVpc#assign_generated_ipv6_cidr_block</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "assign_generated_ipv6_cidr_block">]
        member _.AssignGeneratedIpv6CidrBlock(state: DefaultVpcState, value: HashiCorp.Cdktf.IResolvable) : DefaultVpcState =
            state.assignments.Add(fun config -> config.AssignGeneratedIpv6CidrBlock <- value)
            state : DefaultVpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_vpc#enable_dns_hostnames-1">DefaultVpc#enable_dns_hostnames</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_dns_hostnames">]
        member _.EnableDnsHostnames(state: DefaultVpcState, value: bool) : DefaultVpcState =
            state.assignments.Add(fun config -> config.EnableDnsHostnames <- value)
            state : DefaultVpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_vpc#enable_dns_hostnames-1">DefaultVpc#enable_dns_hostnames</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_dns_hostnames">]
        member _.EnableDnsHostnames(state: DefaultVpcState, value: HashiCorp.Cdktf.IResolvable) : DefaultVpcState =
            state.assignments.Add(fun config -> config.EnableDnsHostnames <- value)
            state : DefaultVpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_vpc#enable_dns_support-1">DefaultVpc#enable_dns_support</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_dns_support">]
        member _.EnableDnsSupport(state: DefaultVpcState, value: bool) : DefaultVpcState =
            state.assignments.Add(fun config -> config.EnableDnsSupport <- value)
            state : DefaultVpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_vpc#enable_dns_support-1">DefaultVpc#enable_dns_support</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_dns_support">]
        member _.EnableDnsSupport(state: DefaultVpcState, value: HashiCorp.Cdktf.IResolvable) : DefaultVpcState =
            state.assignments.Add(fun config -> config.EnableDnsSupport <- value)
            state : DefaultVpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_vpc#enable_network_address_usage_metrics-1">DefaultVpc#enable_network_address_usage_metrics</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_network_address_usage_metrics">]
        member _.EnableNetworkAddressUsageMetrics(state: DefaultVpcState, value: bool) : DefaultVpcState =
            state.assignments.Add(fun config -> config.EnableNetworkAddressUsageMetrics <- value)
            state : DefaultVpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_vpc#enable_network_address_usage_metrics-1">DefaultVpc#enable_network_address_usage_metrics</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_network_address_usage_metrics">]
        member _.EnableNetworkAddressUsageMetrics(state: DefaultVpcState, value: HashiCorp.Cdktf.IResolvable) : DefaultVpcState =
            state.assignments.Add(fun config -> config.EnableNetworkAddressUsageMetrics <- value)
            state : DefaultVpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_vpc#force_destroy-1">DefaultVpc#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: DefaultVpcState, value: bool) : DefaultVpcState =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : DefaultVpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_vpc#force_destroy-1">DefaultVpc#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: DefaultVpcState, value: HashiCorp.Cdktf.IResolvable) : DefaultVpcState =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : DefaultVpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_vpc#id-1">DefaultVpc#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DefaultVpcState, value: string) : DefaultVpcState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DefaultVpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_vpc#ipv6_cidr_block-1">DefaultVpc#ipv6_cidr_block</a>.
        /// </summary>
        [<CustomOperation "ipv6_cidr_block">]
        member _.Ipv6CidrBlock(state: DefaultVpcState, value: string) : DefaultVpcState =
            state.assignments.Add(fun config -> config.Ipv6CidrBlock <- value)
            state : DefaultVpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_vpc#ipv6_cidr_block_network_border_group-1">DefaultVpc#ipv6_cidr_block_network_border_group</a>.
        /// </summary>
        [<CustomOperation "ipv6_cidr_block_network_border_group">]
        member _.Ipv6CidrBlockNetworkBorderGroup(state: DefaultVpcState, value: string) : DefaultVpcState =
            state.assignments.Add(fun config -> config.Ipv6CidrBlockNetworkBorderGroup <- value)
            state : DefaultVpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_vpc#ipv6_ipam_pool_id-1">DefaultVpc#ipv6_ipam_pool_id</a>.
        /// </summary>
        [<CustomOperation "ipv6_ipam_pool_id">]
        member _.Ipv6IpamPoolId(state: DefaultVpcState, value: string) : DefaultVpcState =
            state.assignments.Add(fun config -> config.Ipv6IpamPoolId <- value)
            state : DefaultVpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_vpc#ipv6_netmask_length-1">DefaultVpc#ipv6_netmask_length</a>.
        /// </summary>
        [<CustomOperation "ipv6_netmask_length">]
        member _.Ipv6NetmaskLength(state: DefaultVpcState, value: double) : DefaultVpcState =
            state.assignments.Add(fun config -> config.Ipv6NetmaskLength <- value)
            state : DefaultVpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_vpc#tags-1">DefaultVpc#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DefaultVpcState, value: seq<string * string>) : DefaultVpcState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DefaultVpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_vpc#tags_all-1">DefaultVpc#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DefaultVpcState, value: seq<string * string>) : DefaultVpcState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DefaultVpcState

        member _.Run(state: DefaultVpcState) : aws.DefaultVpc.DefaultVpc =
            let config = aws.DefaultVpc.DefaultVpcConfig()
            for setter in state.assignments do
                setter config
            aws.DefaultVpc.DefaultVpc(StackContext.get (), logicalId, config)
