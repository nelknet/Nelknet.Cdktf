namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkInterfaceState<'SubnetId> = { assignments: ResizeArray<aws.NetworkInterface.NetworkInterfaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface">aws_network_interface</a>.
    /// </summary>
    type NetworkInterfaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkInterfaceState<Missing> =
            ({ assignments = ResizeArray() } : NetworkInterfaceState<Missing>)

        member _.Zero(()) : NetworkInterfaceState<Missing> =
            ({ assignments = ResizeArray() } : NetworkInterfaceState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface#subnet_id-1">NetworkInterface#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: NetworkInterfaceState<Missing>, value: string) : NetworkInterfaceState<Present> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : NetworkInterfaceState<Present>)

        /// <summary>
        /// attachment block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface#attachment-1">NetworkInterface#attachment</a> Accepts: aws.IResolvable | aws.NetworkInterface.NetworkInterfaceAttachment[]
        /// </summary>
        [<CustomOperation "attachment">]
        member _.Attachment(state: NetworkInterfaceState<'SubnetId>, value: HashiCorp.Cdktf.IResolvable) : NetworkInterfaceState<'SubnetId> =
            state.assignments.Add(fun config -> config.Attachment <- value)
            state : NetworkInterfaceState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface#description-1">NetworkInterface#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: NetworkInterfaceState<'SubnetId>, value: string) : NetworkInterfaceState<'SubnetId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : NetworkInterfaceState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface#enable_primary_ipv6-1">NetworkInterface#enable_primary_ipv6</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_primary_ipv6">]
        member _.EnablePrimaryIpv6(state: NetworkInterfaceState<'SubnetId>, value: bool) : NetworkInterfaceState<'SubnetId> =
            state.assignments.Add(fun config -> config.EnablePrimaryIpv6 <- value)
            state : NetworkInterfaceState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface#enable_primary_ipv6-1">NetworkInterface#enable_primary_ipv6</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_primary_ipv6">]
        member _.EnablePrimaryIpv6(state: NetworkInterfaceState<'SubnetId>, value: HashiCorp.Cdktf.IResolvable) : NetworkInterfaceState<'SubnetId> =
            state.assignments.Add(fun config -> config.EnablePrimaryIpv6 <- value)
            state : NetworkInterfaceState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface#id-1">NetworkInterface#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkInterfaceState<'SubnetId>, value: string) : NetworkInterfaceState<'SubnetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkInterfaceState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface#interface_type-1">NetworkInterface#interface_type</a>.
        /// </summary>
        [<CustomOperation "interface_type">]
        member _.InterfaceType(state: NetworkInterfaceState<'SubnetId>, value: string) : NetworkInterfaceState<'SubnetId> =
            state.assignments.Add(fun config -> config.InterfaceType <- value)
            state : NetworkInterfaceState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface#ipv4_prefix_count-1">NetworkInterface#ipv4_prefix_count</a>.
        /// </summary>
        [<CustomOperation "ipv4_prefix_count">]
        member _.Ipv4PrefixCount(state: NetworkInterfaceState<'SubnetId>, value: double) : NetworkInterfaceState<'SubnetId> =
            state.assignments.Add(fun config -> config.Ipv4PrefixCount <- value)
            state : NetworkInterfaceState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface#ipv4_prefixes-1">NetworkInterface#ipv4_prefixes</a>.
        /// </summary>
        [<CustomOperation "ipv4_prefixes">]
        member _.Ipv4Prefixes(state: NetworkInterfaceState<'SubnetId>, value: seq<string>) : NetworkInterfaceState<'SubnetId> =
            state.assignments.Add(fun config -> config.Ipv4Prefixes <- (value |> Seq.toArray))
            state : NetworkInterfaceState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface#ipv6_address_count-1">NetworkInterface#ipv6_address_count</a>.
        /// </summary>
        [<CustomOperation "ipv6_address_count">]
        member _.Ipv6AddressCount(state: NetworkInterfaceState<'SubnetId>, value: double) : NetworkInterfaceState<'SubnetId> =
            state.assignments.Add(fun config -> config.Ipv6AddressCount <- value)
            state : NetworkInterfaceState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface#ipv6_addresses-1">NetworkInterface#ipv6_addresses</a>.
        /// </summary>
        [<CustomOperation "ipv6_addresses">]
        member _.Ipv6Addresses(state: NetworkInterfaceState<'SubnetId>, value: seq<string>) : NetworkInterfaceState<'SubnetId> =
            state.assignments.Add(fun config -> config.Ipv6Addresses <- (value |> Seq.toArray))
            state : NetworkInterfaceState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface#ipv6_address_list-1">NetworkInterface#ipv6_address_list</a>.
        /// </summary>
        [<CustomOperation "ipv6_address_list">]
        member _.Ipv6AddressList(state: NetworkInterfaceState<'SubnetId>, value: seq<string>) : NetworkInterfaceState<'SubnetId> =
            state.assignments.Add(fun config -> config.Ipv6AddressList <- (value |> Seq.toArray))
            state : NetworkInterfaceState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface#ipv6_address_list_enabled-1">NetworkInterface#ipv6_address_list_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ipv6_address_list_enabled">]
        member _.Ipv6AddressListEnabled(state: NetworkInterfaceState<'SubnetId>, value: bool) : NetworkInterfaceState<'SubnetId> =
            state.assignments.Add(fun config -> config.Ipv6AddressListEnabled <- value)
            state : NetworkInterfaceState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface#ipv6_address_list_enabled-1">NetworkInterface#ipv6_address_list_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ipv6_address_list_enabled">]
        member _.Ipv6AddressListEnabled(state: NetworkInterfaceState<'SubnetId>, value: HashiCorp.Cdktf.IResolvable) : NetworkInterfaceState<'SubnetId> =
            state.assignments.Add(fun config -> config.Ipv6AddressListEnabled <- value)
            state : NetworkInterfaceState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface#ipv6_prefix_count-1">NetworkInterface#ipv6_prefix_count</a>.
        /// </summary>
        [<CustomOperation "ipv6_prefix_count">]
        member _.Ipv6PrefixCount(state: NetworkInterfaceState<'SubnetId>, value: double) : NetworkInterfaceState<'SubnetId> =
            state.assignments.Add(fun config -> config.Ipv6PrefixCount <- value)
            state : NetworkInterfaceState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface#ipv6_prefixes-1">NetworkInterface#ipv6_prefixes</a>.
        /// </summary>
        [<CustomOperation "ipv6_prefixes">]
        member _.Ipv6Prefixes(state: NetworkInterfaceState<'SubnetId>, value: seq<string>) : NetworkInterfaceState<'SubnetId> =
            state.assignments.Add(fun config -> config.Ipv6Prefixes <- (value |> Seq.toArray))
            state : NetworkInterfaceState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface#private_ip-1">NetworkInterface#private_ip</a>.
        /// </summary>
        [<CustomOperation "private_ip">]
        member _.PrivateIp(state: NetworkInterfaceState<'SubnetId>, value: string) : NetworkInterfaceState<'SubnetId> =
            state.assignments.Add(fun config -> config.PrivateIp <- value)
            state : NetworkInterfaceState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface#private_ip_list-1">NetworkInterface#private_ip_list</a>.
        /// </summary>
        [<CustomOperation "private_ip_list">]
        member _.PrivateIpList(state: NetworkInterfaceState<'SubnetId>, value: seq<string>) : NetworkInterfaceState<'SubnetId> =
            state.assignments.Add(fun config -> config.PrivateIpList <- (value |> Seq.toArray))
            state : NetworkInterfaceState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface#private_ip_list_enabled-1">NetworkInterface#private_ip_list_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "private_ip_list_enabled">]
        member _.PrivateIpListEnabled(state: NetworkInterfaceState<'SubnetId>, value: bool) : NetworkInterfaceState<'SubnetId> =
            state.assignments.Add(fun config -> config.PrivateIpListEnabled <- value)
            state : NetworkInterfaceState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface#private_ip_list_enabled-1">NetworkInterface#private_ip_list_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "private_ip_list_enabled">]
        member _.PrivateIpListEnabled(state: NetworkInterfaceState<'SubnetId>, value: HashiCorp.Cdktf.IResolvable) : NetworkInterfaceState<'SubnetId> =
            state.assignments.Add(fun config -> config.PrivateIpListEnabled <- value)
            state : NetworkInterfaceState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface#private_ips-1">NetworkInterface#private_ips</a>.
        /// </summary>
        [<CustomOperation "private_ips">]
        member _.PrivateIps(state: NetworkInterfaceState<'SubnetId>, value: seq<string>) : NetworkInterfaceState<'SubnetId> =
            state.assignments.Add(fun config -> config.PrivateIps <- (value |> Seq.toArray))
            state : NetworkInterfaceState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface#private_ips_count-1">NetworkInterface#private_ips_count</a>.
        /// </summary>
        [<CustomOperation "private_ips_count">]
        member _.PrivateIpsCount(state: NetworkInterfaceState<'SubnetId>, value: double) : NetworkInterfaceState<'SubnetId> =
            state.assignments.Add(fun config -> config.PrivateIpsCount <- value)
            state : NetworkInterfaceState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface#security_groups-1">NetworkInterface#security_groups</a>.
        /// </summary>
        [<CustomOperation "security_groups">]
        member _.SecurityGroups(state: NetworkInterfaceState<'SubnetId>, value: seq<string>) : NetworkInterfaceState<'SubnetId> =
            state.assignments.Add(fun config -> config.SecurityGroups <- (value |> Seq.toArray))
            state : NetworkInterfaceState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface#source_dest_check-1">NetworkInterface#source_dest_check</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "source_dest_check">]
        member _.SourceDestCheck(state: NetworkInterfaceState<'SubnetId>, value: bool) : NetworkInterfaceState<'SubnetId> =
            state.assignments.Add(fun config -> config.SourceDestCheck <- value)
            state : NetworkInterfaceState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface#source_dest_check-1">NetworkInterface#source_dest_check</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "source_dest_check">]
        member _.SourceDestCheck(state: NetworkInterfaceState<'SubnetId>, value: HashiCorp.Cdktf.IResolvable) : NetworkInterfaceState<'SubnetId> =
            state.assignments.Add(fun config -> config.SourceDestCheck <- value)
            state : NetworkInterfaceState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface#tags-1">NetworkInterface#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkInterfaceState<'SubnetId>, value: seq<string * string>) : NetworkInterfaceState<'SubnetId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkInterfaceState<'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface#tags_all-1">NetworkInterface#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: NetworkInterfaceState<'SubnetId>, value: seq<string * string>) : NetworkInterfaceState<'SubnetId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : NetworkInterfaceState<'SubnetId>

        member _.Run(state: NetworkInterfaceState<Present>) : aws.NetworkInterface.NetworkInterface =
            let config = aws.NetworkInterface.NetworkInterfaceConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkInterface.NetworkInterface(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkInterface: missing required arguments. Must call: subnet_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkInterfaceState<_>) : aws.NetworkInterface.NetworkInterface =
            Unchecked.defaultof<aws.NetworkInterface.NetworkInterface>
