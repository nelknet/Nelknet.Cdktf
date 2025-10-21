namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DefaultSubnetState<'AvailabilityZone> = { assignments: ResizeArray<aws.DefaultSubnet.DefaultSubnetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_subnet">aws_default_subnet</a>.
    /// </summary>
    type DefaultSubnetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DefaultSubnetState<Missing> =
            ({ assignments = ResizeArray() } : DefaultSubnetState<Missing>)

        member _.Zero(()) : DefaultSubnetState<Missing> =
            ({ assignments = ResizeArray() } : DefaultSubnetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_subnet#availability_zone-1">DefaultSubnet#availability_zone</a>.
        /// </summary>
        [<CustomOperation "availability_zone">]
        member _.AvailabilityZone(state: DefaultSubnetState<Missing>, value: string) : DefaultSubnetState<Present> =
            state.assignments.Add(fun config -> config.AvailabilityZone <- value)
            ({ assignments = state.assignments } : DefaultSubnetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_subnet#assign_ipv6_address_on_creation-1">DefaultSubnet#assign_ipv6_address_on_creation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "assign_ipv6_address_on_creation">]
        member _.AssignIpv6AddressOnCreation(state: DefaultSubnetState<'AvailabilityZone>, value: bool) : DefaultSubnetState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.AssignIpv6AddressOnCreation <- value)
            state : DefaultSubnetState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_subnet#assign_ipv6_address_on_creation-1">DefaultSubnet#assign_ipv6_address_on_creation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "assign_ipv6_address_on_creation">]
        member _.AssignIpv6AddressOnCreation(state: DefaultSubnetState<'AvailabilityZone>, value: HashiCorp.Cdktf.IResolvable) : DefaultSubnetState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.AssignIpv6AddressOnCreation <- value)
            state : DefaultSubnetState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_subnet#customer_owned_ipv4_pool-1">DefaultSubnet#customer_owned_ipv4_pool</a>.
        /// </summary>
        [<CustomOperation "customer_owned_ipv4_pool">]
        member _.CustomerOwnedIpv4Pool(state: DefaultSubnetState<'AvailabilityZone>, value: string) : DefaultSubnetState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.CustomerOwnedIpv4Pool <- value)
            state : DefaultSubnetState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_subnet#enable_dns64-1">DefaultSubnet#enable_dns64</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_dns64">]
        member _.EnableDns64(state: DefaultSubnetState<'AvailabilityZone>, value: bool) : DefaultSubnetState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.EnableDns64 <- value)
            state : DefaultSubnetState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_subnet#enable_dns64-1">DefaultSubnet#enable_dns64</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_dns64">]
        member _.EnableDns64(state: DefaultSubnetState<'AvailabilityZone>, value: HashiCorp.Cdktf.IResolvable) : DefaultSubnetState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.EnableDns64 <- value)
            state : DefaultSubnetState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_subnet#enable_resource_name_dns_aaaa_record_on_launch-1">DefaultSubnet#enable_resource_name_dns_aaaa_record_on_launch</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_resource_name_dns_aaaa_record_on_launch">]
        member _.EnableResourceNameDnsAaaaRecordOnLaunch(state: DefaultSubnetState<'AvailabilityZone>, value: bool) : DefaultSubnetState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.EnableResourceNameDnsAaaaRecordOnLaunch <- value)
            state : DefaultSubnetState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_subnet#enable_resource_name_dns_aaaa_record_on_launch-1">DefaultSubnet#enable_resource_name_dns_aaaa_record_on_launch</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_resource_name_dns_aaaa_record_on_launch">]
        member _.EnableResourceNameDnsAaaaRecordOnLaunch(state: DefaultSubnetState<'AvailabilityZone>, value: HashiCorp.Cdktf.IResolvable) : DefaultSubnetState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.EnableResourceNameDnsAaaaRecordOnLaunch <- value)
            state : DefaultSubnetState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_subnet#enable_resource_name_dns_a_record_on_launch-1">DefaultSubnet#enable_resource_name_dns_a_record_on_launch</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_resource_name_dns_a_record_on_launch">]
        member _.EnableResourceNameDnsARecordOnLaunch(state: DefaultSubnetState<'AvailabilityZone>, value: bool) : DefaultSubnetState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.EnableResourceNameDnsARecordOnLaunch <- value)
            state : DefaultSubnetState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_subnet#enable_resource_name_dns_a_record_on_launch-1">DefaultSubnet#enable_resource_name_dns_a_record_on_launch</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_resource_name_dns_a_record_on_launch">]
        member _.EnableResourceNameDnsARecordOnLaunch(state: DefaultSubnetState<'AvailabilityZone>, value: HashiCorp.Cdktf.IResolvable) : DefaultSubnetState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.EnableResourceNameDnsARecordOnLaunch <- value)
            state : DefaultSubnetState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_subnet#force_destroy-1">DefaultSubnet#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: DefaultSubnetState<'AvailabilityZone>, value: bool) : DefaultSubnetState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : DefaultSubnetState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_subnet#force_destroy-1">DefaultSubnet#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: DefaultSubnetState<'AvailabilityZone>, value: HashiCorp.Cdktf.IResolvable) : DefaultSubnetState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : DefaultSubnetState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_subnet#id-1">DefaultSubnet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DefaultSubnetState<'AvailabilityZone>, value: string) : DefaultSubnetState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DefaultSubnetState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_subnet#ipv6_cidr_block-1">DefaultSubnet#ipv6_cidr_block</a>.
        /// </summary>
        [<CustomOperation "ipv6_cidr_block">]
        member _.Ipv6CidrBlock(state: DefaultSubnetState<'AvailabilityZone>, value: string) : DefaultSubnetState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.Ipv6CidrBlock <- value)
            state : DefaultSubnetState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_subnet#ipv6_native-1">DefaultSubnet#ipv6_native</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ipv6_native">]
        member _.Ipv6Native(state: DefaultSubnetState<'AvailabilityZone>, value: bool) : DefaultSubnetState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.Ipv6Native <- value)
            state : DefaultSubnetState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_subnet#ipv6_native-1">DefaultSubnet#ipv6_native</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ipv6_native">]
        member _.Ipv6Native(state: DefaultSubnetState<'AvailabilityZone>, value: HashiCorp.Cdktf.IResolvable) : DefaultSubnetState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.Ipv6Native <- value)
            state : DefaultSubnetState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_subnet#map_customer_owned_ip_on_launch-1">DefaultSubnet#map_customer_owned_ip_on_launch</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "map_customer_owned_ip_on_launch">]
        member _.MapCustomerOwnedIpOnLaunch(state: DefaultSubnetState<'AvailabilityZone>, value: bool) : DefaultSubnetState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.MapCustomerOwnedIpOnLaunch <- value)
            state : DefaultSubnetState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_subnet#map_customer_owned_ip_on_launch-1">DefaultSubnet#map_customer_owned_ip_on_launch</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "map_customer_owned_ip_on_launch">]
        member _.MapCustomerOwnedIpOnLaunch(state: DefaultSubnetState<'AvailabilityZone>, value: HashiCorp.Cdktf.IResolvable) : DefaultSubnetState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.MapCustomerOwnedIpOnLaunch <- value)
            state : DefaultSubnetState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_subnet#map_public_ip_on_launch-1">DefaultSubnet#map_public_ip_on_launch</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "map_public_ip_on_launch">]
        member _.MapPublicIpOnLaunch(state: DefaultSubnetState<'AvailabilityZone>, value: bool) : DefaultSubnetState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.MapPublicIpOnLaunch <- value)
            state : DefaultSubnetState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_subnet#map_public_ip_on_launch-1">DefaultSubnet#map_public_ip_on_launch</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "map_public_ip_on_launch">]
        member _.MapPublicIpOnLaunch(state: DefaultSubnetState<'AvailabilityZone>, value: HashiCorp.Cdktf.IResolvable) : DefaultSubnetState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.MapPublicIpOnLaunch <- value)
            state : DefaultSubnetState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_subnet#private_dns_hostname_type_on_launch-1">DefaultSubnet#private_dns_hostname_type_on_launch</a>.
        /// </summary>
        [<CustomOperation "private_dns_hostname_type_on_launch">]
        member _.PrivateDnsHostnameTypeOnLaunch(state: DefaultSubnetState<'AvailabilityZone>, value: string) : DefaultSubnetState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.PrivateDnsHostnameTypeOnLaunch <- value)
            state : DefaultSubnetState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_subnet#tags-1">DefaultSubnet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DefaultSubnetState<'AvailabilityZone>, value: seq<string * string>) : DefaultSubnetState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DefaultSubnetState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_subnet#tags_all-1">DefaultSubnet#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DefaultSubnetState<'AvailabilityZone>, value: seq<string * string>) : DefaultSubnetState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DefaultSubnetState<'AvailabilityZone>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_subnet#timeouts-1">DefaultSubnet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DefaultSubnetState<'AvailabilityZone>, value: aws.DefaultSubnet.DefaultSubnetTimeouts) : DefaultSubnetState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DefaultSubnetState<'AvailabilityZone>

        member _.Run(state: DefaultSubnetState<Present>) : aws.DefaultSubnet.DefaultSubnet =
            let config = aws.DefaultSubnet.DefaultSubnetConfig()
            for setter in state.assignments do
                setter config
            aws.DefaultSubnet.DefaultSubnet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.defaultSubnet: missing required arguments. Must call: availability_zone.", 9999, IsError = true)>]
        member _.Run(_: DefaultSubnetState<_>) : aws.DefaultSubnet.DefaultSubnet =
            Unchecked.defaultof<aws.DefaultSubnet.DefaultSubnet>
