namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SubnetState<'VpcId> = { assignments: ResizeArray<aws.Subnet.SubnetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/subnet">aws_subnet</a>.
    /// </summary>
    type SubnetBuilder(logicalId: string) =
        member _.Yield(_: unit) : SubnetState<Missing> =
            ({ assignments = ResizeArray() } : SubnetState<Missing>)

        member _.Zero(()) : SubnetState<Missing> =
            ({ assignments = ResizeArray() } : SubnetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/subnet#vpc_id-1">Subnet#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: SubnetState<Missing>, value: string) : SubnetState<Present> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            ({ assignments = state.assignments } : SubnetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/subnet#assign_ipv6_address_on_creation-1">Subnet#assign_ipv6_address_on_creation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "assign_ipv6_address_on_creation">]
        member _.AssignIpv6AddressOnCreation(state: SubnetState<'VpcId>, value: bool) : SubnetState<'VpcId> =
            state.assignments.Add(fun config -> config.AssignIpv6AddressOnCreation <- value)
            state : SubnetState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/subnet#assign_ipv6_address_on_creation-1">Subnet#assign_ipv6_address_on_creation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "assign_ipv6_address_on_creation">]
        member _.AssignIpv6AddressOnCreation(state: SubnetState<'VpcId>, value: HashiCorp.Cdktf.IResolvable) : SubnetState<'VpcId> =
            state.assignments.Add(fun config -> config.AssignIpv6AddressOnCreation <- value)
            state : SubnetState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/subnet#availability_zone-1">Subnet#availability_zone</a>.
        /// </summary>
        [<CustomOperation "availability_zone">]
        member _.AvailabilityZone(state: SubnetState<'VpcId>, value: string) : SubnetState<'VpcId> =
            state.assignments.Add(fun config -> config.AvailabilityZone <- value)
            state : SubnetState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/subnet#availability_zone_id-1">Subnet#availability_zone_id</a>.
        /// </summary>
        [<CustomOperation "availability_zone_id">]
        member _.AvailabilityZoneId(state: SubnetState<'VpcId>, value: string) : SubnetState<'VpcId> =
            state.assignments.Add(fun config -> config.AvailabilityZoneId <- value)
            state : SubnetState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/subnet#cidr_block-1">Subnet#cidr_block</a>.
        /// </summary>
        [<CustomOperation "cidr_block">]
        member _.CidrBlock(state: SubnetState<'VpcId>, value: string) : SubnetState<'VpcId> =
            state.assignments.Add(fun config -> config.CidrBlock <- value)
            state : SubnetState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/subnet#customer_owned_ipv4_pool-1">Subnet#customer_owned_ipv4_pool</a>.
        /// </summary>
        [<CustomOperation "customer_owned_ipv4_pool">]
        member _.CustomerOwnedIpv4Pool(state: SubnetState<'VpcId>, value: string) : SubnetState<'VpcId> =
            state.assignments.Add(fun config -> config.CustomerOwnedIpv4Pool <- value)
            state : SubnetState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/subnet#enable_dns64-1">Subnet#enable_dns64</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_dns64">]
        member _.EnableDns64(state: SubnetState<'VpcId>, value: bool) : SubnetState<'VpcId> =
            state.assignments.Add(fun config -> config.EnableDns64 <- value)
            state : SubnetState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/subnet#enable_dns64-1">Subnet#enable_dns64</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_dns64">]
        member _.EnableDns64(state: SubnetState<'VpcId>, value: HashiCorp.Cdktf.IResolvable) : SubnetState<'VpcId> =
            state.assignments.Add(fun config -> config.EnableDns64 <- value)
            state : SubnetState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/subnet#enable_lni_at_device_index-1">Subnet#enable_lni_at_device_index</a>.
        /// </summary>
        [<CustomOperation "enable_lni_at_device_index">]
        member _.EnableLniAtDeviceIndex(state: SubnetState<'VpcId>, value: double) : SubnetState<'VpcId> =
            state.assignments.Add(fun config -> config.EnableLniAtDeviceIndex <- value)
            state : SubnetState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/subnet#enable_resource_name_dns_aaaa_record_on_launch-1">Subnet#enable_resource_name_dns_aaaa_record_on_launch</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_resource_name_dns_aaaa_record_on_launch">]
        member _.EnableResourceNameDnsAaaaRecordOnLaunch(state: SubnetState<'VpcId>, value: bool) : SubnetState<'VpcId> =
            state.assignments.Add(fun config -> config.EnableResourceNameDnsAaaaRecordOnLaunch <- value)
            state : SubnetState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/subnet#enable_resource_name_dns_aaaa_record_on_launch-1">Subnet#enable_resource_name_dns_aaaa_record_on_launch</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_resource_name_dns_aaaa_record_on_launch">]
        member _.EnableResourceNameDnsAaaaRecordOnLaunch(state: SubnetState<'VpcId>, value: HashiCorp.Cdktf.IResolvable) : SubnetState<'VpcId> =
            state.assignments.Add(fun config -> config.EnableResourceNameDnsAaaaRecordOnLaunch <- value)
            state : SubnetState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/subnet#enable_resource_name_dns_a_record_on_launch-1">Subnet#enable_resource_name_dns_a_record_on_launch</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_resource_name_dns_a_record_on_launch">]
        member _.EnableResourceNameDnsARecordOnLaunch(state: SubnetState<'VpcId>, value: bool) : SubnetState<'VpcId> =
            state.assignments.Add(fun config -> config.EnableResourceNameDnsARecordOnLaunch <- value)
            state : SubnetState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/subnet#enable_resource_name_dns_a_record_on_launch-1">Subnet#enable_resource_name_dns_a_record_on_launch</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_resource_name_dns_a_record_on_launch">]
        member _.EnableResourceNameDnsARecordOnLaunch(state: SubnetState<'VpcId>, value: HashiCorp.Cdktf.IResolvable) : SubnetState<'VpcId> =
            state.assignments.Add(fun config -> config.EnableResourceNameDnsARecordOnLaunch <- value)
            state : SubnetState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/subnet#id-1">Subnet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SubnetState<'VpcId>, value: string) : SubnetState<'VpcId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SubnetState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/subnet#ipv6_cidr_block-1">Subnet#ipv6_cidr_block</a>.
        /// </summary>
        [<CustomOperation "ipv6_cidr_block">]
        member _.Ipv6CidrBlock(state: SubnetState<'VpcId>, value: string) : SubnetState<'VpcId> =
            state.assignments.Add(fun config -> config.Ipv6CidrBlock <- value)
            state : SubnetState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/subnet#ipv6_native-1">Subnet#ipv6_native</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ipv6_native">]
        member _.Ipv6Native(state: SubnetState<'VpcId>, value: bool) : SubnetState<'VpcId> =
            state.assignments.Add(fun config -> config.Ipv6Native <- value)
            state : SubnetState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/subnet#ipv6_native-1">Subnet#ipv6_native</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ipv6_native">]
        member _.Ipv6Native(state: SubnetState<'VpcId>, value: HashiCorp.Cdktf.IResolvable) : SubnetState<'VpcId> =
            state.assignments.Add(fun config -> config.Ipv6Native <- value)
            state : SubnetState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/subnet#map_customer_owned_ip_on_launch-1">Subnet#map_customer_owned_ip_on_launch</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "map_customer_owned_ip_on_launch">]
        member _.MapCustomerOwnedIpOnLaunch(state: SubnetState<'VpcId>, value: bool) : SubnetState<'VpcId> =
            state.assignments.Add(fun config -> config.MapCustomerOwnedIpOnLaunch <- value)
            state : SubnetState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/subnet#map_customer_owned_ip_on_launch-1">Subnet#map_customer_owned_ip_on_launch</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "map_customer_owned_ip_on_launch">]
        member _.MapCustomerOwnedIpOnLaunch(state: SubnetState<'VpcId>, value: HashiCorp.Cdktf.IResolvable) : SubnetState<'VpcId> =
            state.assignments.Add(fun config -> config.MapCustomerOwnedIpOnLaunch <- value)
            state : SubnetState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/subnet#map_public_ip_on_launch-1">Subnet#map_public_ip_on_launch</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "map_public_ip_on_launch">]
        member _.MapPublicIpOnLaunch(state: SubnetState<'VpcId>, value: bool) : SubnetState<'VpcId> =
            state.assignments.Add(fun config -> config.MapPublicIpOnLaunch <- value)
            state : SubnetState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/subnet#map_public_ip_on_launch-1">Subnet#map_public_ip_on_launch</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "map_public_ip_on_launch">]
        member _.MapPublicIpOnLaunch(state: SubnetState<'VpcId>, value: HashiCorp.Cdktf.IResolvable) : SubnetState<'VpcId> =
            state.assignments.Add(fun config -> config.MapPublicIpOnLaunch <- value)
            state : SubnetState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/subnet#outpost_arn-1">Subnet#outpost_arn</a>.
        /// </summary>
        [<CustomOperation "outpost_arn">]
        member _.OutpostArn(state: SubnetState<'VpcId>, value: string) : SubnetState<'VpcId> =
            state.assignments.Add(fun config -> config.OutpostArn <- value)
            state : SubnetState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/subnet#private_dns_hostname_type_on_launch-1">Subnet#private_dns_hostname_type_on_launch</a>.
        /// </summary>
        [<CustomOperation "private_dns_hostname_type_on_launch">]
        member _.PrivateDnsHostnameTypeOnLaunch(state: SubnetState<'VpcId>, value: string) : SubnetState<'VpcId> =
            state.assignments.Add(fun config -> config.PrivateDnsHostnameTypeOnLaunch <- value)
            state : SubnetState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/subnet#tags-1">Subnet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SubnetState<'VpcId>, value: seq<string * string>) : SubnetState<'VpcId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SubnetState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/subnet#tags_all-1">Subnet#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SubnetState<'VpcId>, value: seq<string * string>) : SubnetState<'VpcId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SubnetState<'VpcId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/subnet#timeouts-1">Subnet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SubnetState<'VpcId>, value: aws.Subnet.SubnetTimeouts) : SubnetState<'VpcId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SubnetState<'VpcId>

        member _.Run(state: SubnetState<Present>) : aws.Subnet.Subnet =
            let config = aws.Subnet.SubnetConfig()
            for setter in state.assignments do
                setter config
            aws.Subnet.Subnet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.subnet: missing required arguments. Must call: vpc_id.", 9999, IsError = true)>]
        member _.Run(_: SubnetState<_>) : aws.Subnet.Subnet =
            Unchecked.defaultof<aws.Subnet.Subnet>
