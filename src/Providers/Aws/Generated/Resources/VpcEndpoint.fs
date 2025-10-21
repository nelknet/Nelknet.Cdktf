namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcEndpointState<'VpcId> = { assignments: ResizeArray<aws.VpcEndpoint.VpcEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint">aws_vpc_endpoint</a>.
    /// </summary>
    type VpcEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcEndpointState<Missing> =
            ({ assignments = ResizeArray() } : VpcEndpointState<Missing>)

        member _.Zero(()) : VpcEndpointState<Missing> =
            ({ assignments = ResizeArray() } : VpcEndpointState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint#vpc_id-1">VpcEndpoint#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: VpcEndpointState<Missing>, value: string) : VpcEndpointState<Present> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            ({ assignments = state.assignments } : VpcEndpointState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint#auto_accept-1">VpcEndpoint#auto_accept</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_accept">]
        member _.AutoAccept(state: VpcEndpointState<'VpcId>, value: bool) : VpcEndpointState<'VpcId> =
            state.assignments.Add(fun config -> config.AutoAccept <- value)
            state : VpcEndpointState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint#auto_accept-1">VpcEndpoint#auto_accept</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_accept">]
        member _.AutoAccept(state: VpcEndpointState<'VpcId>, value: HashiCorp.Cdktf.IResolvable) : VpcEndpointState<'VpcId> =
            state.assignments.Add(fun config -> config.AutoAccept <- value)
            state : VpcEndpointState<'VpcId>

        /// <summary>
        /// dns_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint#dns_options-1">VpcEndpoint#dns_options</a>
        /// </summary>
        [<CustomOperation "dns_options">]
        member _.DnsOptions(state: VpcEndpointState<'VpcId>, value: aws.VpcEndpoint.VpcEndpointDnsOptions) : VpcEndpointState<'VpcId> =
            state.assignments.Add(fun config -> config.DnsOptions <- value)
            state : VpcEndpointState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint#id-1">VpcEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpcEndpointState<'VpcId>, value: string) : VpcEndpointState<'VpcId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpcEndpointState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint#ip_address_type-1">VpcEndpoint#ip_address_type</a>.
        /// </summary>
        [<CustomOperation "ip_address_type">]
        member _.IpAddressType(state: VpcEndpointState<'VpcId>, value: string) : VpcEndpointState<'VpcId> =
            state.assignments.Add(fun config -> config.IpAddressType <- value)
            state : VpcEndpointState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint#policy-1">VpcEndpoint#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: VpcEndpointState<'VpcId>, value: string) : VpcEndpointState<'VpcId> =
            state.assignments.Add(fun config -> config.Policy <- value)
            state : VpcEndpointState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint#private_dns_enabled-1">VpcEndpoint#private_dns_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "private_dns_enabled">]
        member _.PrivateDnsEnabled(state: VpcEndpointState<'VpcId>, value: bool) : VpcEndpointState<'VpcId> =
            state.assignments.Add(fun config -> config.PrivateDnsEnabled <- value)
            state : VpcEndpointState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint#private_dns_enabled-1">VpcEndpoint#private_dns_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "private_dns_enabled">]
        member _.PrivateDnsEnabled(state: VpcEndpointState<'VpcId>, value: HashiCorp.Cdktf.IResolvable) : VpcEndpointState<'VpcId> =
            state.assignments.Add(fun config -> config.PrivateDnsEnabled <- value)
            state : VpcEndpointState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint#resource_configuration_arn-1">VpcEndpoint#resource_configuration_arn</a>.
        /// </summary>
        [<CustomOperation "resource_configuration_arn">]
        member _.ResourceConfigurationArn(state: VpcEndpointState<'VpcId>, value: string) : VpcEndpointState<'VpcId> =
            state.assignments.Add(fun config -> config.ResourceConfigurationArn <- value)
            state : VpcEndpointState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint#route_table_ids-1">VpcEndpoint#route_table_ids</a>.
        /// </summary>
        [<CustomOperation "route_table_ids">]
        member _.RouteTableIds(state: VpcEndpointState<'VpcId>, value: seq<string>) : VpcEndpointState<'VpcId> =
            state.assignments.Add(fun config -> config.RouteTableIds <- (value |> Seq.toArray))
            state : VpcEndpointState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint#security_group_ids-1">VpcEndpoint#security_group_ids</a>.
        /// </summary>
        [<CustomOperation "security_group_ids">]
        member _.SecurityGroupIds(state: VpcEndpointState<'VpcId>, value: seq<string>) : VpcEndpointState<'VpcId> =
            state.assignments.Add(fun config -> config.SecurityGroupIds <- (value |> Seq.toArray))
            state : VpcEndpointState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint#service_name-1">VpcEndpoint#service_name</a>.
        /// </summary>
        [<CustomOperation "service_name">]
        member _.ServiceName(state: VpcEndpointState<'VpcId>, value: string) : VpcEndpointState<'VpcId> =
            state.assignments.Add(fun config -> config.ServiceName <- value)
            state : VpcEndpointState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint#service_network_arn-1">VpcEndpoint#service_network_arn</a>.
        /// </summary>
        [<CustomOperation "service_network_arn">]
        member _.ServiceNetworkArn(state: VpcEndpointState<'VpcId>, value: string) : VpcEndpointState<'VpcId> =
            state.assignments.Add(fun config -> config.ServiceNetworkArn <- value)
            state : VpcEndpointState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint#service_region-1">VpcEndpoint#service_region</a>.
        /// </summary>
        [<CustomOperation "service_region">]
        member _.ServiceRegion(state: VpcEndpointState<'VpcId>, value: string) : VpcEndpointState<'VpcId> =
            state.assignments.Add(fun config -> config.ServiceRegion <- value)
            state : VpcEndpointState<'VpcId>

        /// <summary>
        /// subnet_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint#subnet_configuration-1">VpcEndpoint#subnet_configuration</a> Accepts: aws.IResolvable | aws.VpcEndpoint.VpcEndpointSubnetConfiguration[]
        /// </summary>
        [<CustomOperation "subnet_configuration">]
        member _.SubnetConfiguration(state: VpcEndpointState<'VpcId>, value: HashiCorp.Cdktf.IResolvable) : VpcEndpointState<'VpcId> =
            state.assignments.Add(fun config -> config.SubnetConfiguration <- value)
            state : VpcEndpointState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint#subnet_ids-1">VpcEndpoint#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: VpcEndpointState<'VpcId>, value: seq<string>) : VpcEndpointState<'VpcId> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            state : VpcEndpointState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint#tags-1">VpcEndpoint#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpcEndpointState<'VpcId>, value: seq<string * string>) : VpcEndpointState<'VpcId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpcEndpointState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint#tags_all-1">VpcEndpoint#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: VpcEndpointState<'VpcId>, value: seq<string * string>) : VpcEndpointState<'VpcId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : VpcEndpointState<'VpcId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint#timeouts-1">VpcEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpcEndpointState<'VpcId>, value: aws.VpcEndpoint.VpcEndpointTimeouts) : VpcEndpointState<'VpcId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpcEndpointState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint#vpc_endpoint_type-1">VpcEndpoint#vpc_endpoint_type</a>.
        /// </summary>
        [<CustomOperation "vpc_endpoint_type">]
        member _.VpcEndpointType(state: VpcEndpointState<'VpcId>, value: string) : VpcEndpointState<'VpcId> =
            state.assignments.Add(fun config -> config.VpcEndpointType <- value)
            state : VpcEndpointState<'VpcId>

        member _.Run(state: VpcEndpointState<Present>) : aws.VpcEndpoint.VpcEndpoint =
            let config = aws.VpcEndpoint.VpcEndpointConfig()
            for setter in state.assignments do
                setter config
            aws.VpcEndpoint.VpcEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcEndpoint: missing required arguments. Must call: vpc_id.", 9999, IsError = true)>]
        member _.Run(_: VpcEndpointState<_>) : aws.VpcEndpoint.VpcEndpoint =
            Unchecked.defaultof<aws.VpcEndpoint.VpcEndpoint>
