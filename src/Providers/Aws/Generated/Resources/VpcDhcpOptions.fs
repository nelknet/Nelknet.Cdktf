namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcDhcpOptionsState = { assignments: ResizeArray<aws.VpcDhcpOptions.VpcDhcpOptionsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_dhcp_options">aws_vpc_dhcp_options</a>.
    /// </summary>
    type VpcDhcpOptionsBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcDhcpOptionsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : VpcDhcpOptionsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_dhcp_options#domain_name-1">VpcDhcpOptions#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: VpcDhcpOptionsState, value: string) : VpcDhcpOptionsState =
            state.assignments.Add(fun config -> config.DomainName <- value)
            state : VpcDhcpOptionsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_dhcp_options#domain_name_servers-1">VpcDhcpOptions#domain_name_servers</a>.
        /// </summary>
        [<CustomOperation "domain_name_servers">]
        member _.DomainNameServers(state: VpcDhcpOptionsState, value: seq<string>) : VpcDhcpOptionsState =
            state.assignments.Add(fun config -> config.DomainNameServers <- (value |> Seq.toArray))
            state : VpcDhcpOptionsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_dhcp_options#id-1">VpcDhcpOptions#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpcDhcpOptionsState, value: string) : VpcDhcpOptionsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpcDhcpOptionsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_dhcp_options#ipv6_address_preferred_lease_time-1">VpcDhcpOptions#ipv6_address_preferred_lease_time</a>.
        /// </summary>
        [<CustomOperation "ipv6_address_preferred_lease_time">]
        member _.Ipv6AddressPreferredLeaseTime(state: VpcDhcpOptionsState, value: string) : VpcDhcpOptionsState =
            state.assignments.Add(fun config -> config.Ipv6AddressPreferredLeaseTime <- value)
            state : VpcDhcpOptionsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_dhcp_options#netbios_name_servers-1">VpcDhcpOptions#netbios_name_servers</a>.
        /// </summary>
        [<CustomOperation "netbios_name_servers">]
        member _.NetbiosNameServers(state: VpcDhcpOptionsState, value: seq<string>) : VpcDhcpOptionsState =
            state.assignments.Add(fun config -> config.NetbiosNameServers <- (value |> Seq.toArray))
            state : VpcDhcpOptionsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_dhcp_options#netbios_node_type-1">VpcDhcpOptions#netbios_node_type</a>.
        /// </summary>
        [<CustomOperation "netbios_node_type">]
        member _.NetbiosNodeType(state: VpcDhcpOptionsState, value: string) : VpcDhcpOptionsState =
            state.assignments.Add(fun config -> config.NetbiosNodeType <- value)
            state : VpcDhcpOptionsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_dhcp_options#ntp_servers-1">VpcDhcpOptions#ntp_servers</a>.
        /// </summary>
        [<CustomOperation "ntp_servers">]
        member _.NtpServers(state: VpcDhcpOptionsState, value: seq<string>) : VpcDhcpOptionsState =
            state.assignments.Add(fun config -> config.NtpServers <- (value |> Seq.toArray))
            state : VpcDhcpOptionsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_dhcp_options#tags-1">VpcDhcpOptions#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpcDhcpOptionsState, value: seq<string * string>) : VpcDhcpOptionsState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpcDhcpOptionsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_dhcp_options#tags_all-1">VpcDhcpOptions#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: VpcDhcpOptionsState, value: seq<string * string>) : VpcDhcpOptionsState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : VpcDhcpOptionsState

        member _.Run(state: VpcDhcpOptionsState) : aws.VpcDhcpOptions.VpcDhcpOptions =
            let config = aws.VpcDhcpOptions.VpcDhcpOptionsConfig()
            for setter in state.assignments do
                setter config
            aws.VpcDhcpOptions.VpcDhcpOptions(StackContext.get (), logicalId, config)
