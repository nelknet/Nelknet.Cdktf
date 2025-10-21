namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcEndpointServiceState<'AcceptanceRequired> = { assignments: ResizeArray<aws.VpcEndpointService.VpcEndpointServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_service">aws_vpc_endpoint_service</a>.
    /// </summary>
    type VpcEndpointServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcEndpointServiceState<Missing> =
            ({ assignments = ResizeArray() } : VpcEndpointServiceState<Missing>)

        member _.Zero(()) : VpcEndpointServiceState<Missing> =
            ({ assignments = ResizeArray() } : VpcEndpointServiceState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_service#acceptance_required-1">VpcEndpointService#acceptance_required</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "acceptance_required">]
        member _.AcceptanceRequired(state: VpcEndpointServiceState<Missing>, value: bool) : VpcEndpointServiceState<Present> =
            state.assignments.Add(fun config -> config.AcceptanceRequired <- value)
            ({ assignments = state.assignments } : VpcEndpointServiceState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_service#acceptance_required-1">VpcEndpointService#acceptance_required</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "acceptance_required">]
        member _.AcceptanceRequired(state: VpcEndpointServiceState<Missing>, value: HashiCorp.Cdktf.IResolvable) : VpcEndpointServiceState<Present> =
            state.assignments.Add(fun config -> config.AcceptanceRequired <- value)
            ({ assignments = state.assignments } : VpcEndpointServiceState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_service#allowed_principals-1">VpcEndpointService#allowed_principals</a>.
        /// </summary>
        [<CustomOperation "allowed_principals">]
        member _.AllowedPrincipals(state: VpcEndpointServiceState<'AcceptanceRequired>, value: seq<string>) : VpcEndpointServiceState<'AcceptanceRequired> =
            state.assignments.Add(fun config -> config.AllowedPrincipals <- (value |> Seq.toArray))
            state : VpcEndpointServiceState<'AcceptanceRequired>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_service#gateway_load_balancer_arns-1">VpcEndpointService#gateway_load_balancer_arns</a>.
        /// </summary>
        [<CustomOperation "gateway_load_balancer_arns">]
        member _.GatewayLoadBalancerArns(state: VpcEndpointServiceState<'AcceptanceRequired>, value: seq<string>) : VpcEndpointServiceState<'AcceptanceRequired> =
            state.assignments.Add(fun config -> config.GatewayLoadBalancerArns <- (value |> Seq.toArray))
            state : VpcEndpointServiceState<'AcceptanceRequired>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_service#id-1">VpcEndpointService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpcEndpointServiceState<'AcceptanceRequired>, value: string) : VpcEndpointServiceState<'AcceptanceRequired> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpcEndpointServiceState<'AcceptanceRequired>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_service#network_load_balancer_arns-1">VpcEndpointService#network_load_balancer_arns</a>.
        /// </summary>
        [<CustomOperation "network_load_balancer_arns">]
        member _.NetworkLoadBalancerArns(state: VpcEndpointServiceState<'AcceptanceRequired>, value: seq<string>) : VpcEndpointServiceState<'AcceptanceRequired> =
            state.assignments.Add(fun config -> config.NetworkLoadBalancerArns <- (value |> Seq.toArray))
            state : VpcEndpointServiceState<'AcceptanceRequired>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_service#private_dns_name-1">VpcEndpointService#private_dns_name</a>.
        /// </summary>
        [<CustomOperation "private_dns_name">]
        member _.PrivateDnsName(state: VpcEndpointServiceState<'AcceptanceRequired>, value: string) : VpcEndpointServiceState<'AcceptanceRequired> =
            state.assignments.Add(fun config -> config.PrivateDnsName <- value)
            state : VpcEndpointServiceState<'AcceptanceRequired>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_service#supported_ip_address_types-1">VpcEndpointService#supported_ip_address_types</a>.
        /// </summary>
        [<CustomOperation "supported_ip_address_types">]
        member _.SupportedIpAddressTypes(state: VpcEndpointServiceState<'AcceptanceRequired>, value: seq<string>) : VpcEndpointServiceState<'AcceptanceRequired> =
            state.assignments.Add(fun config -> config.SupportedIpAddressTypes <- (value |> Seq.toArray))
            state : VpcEndpointServiceState<'AcceptanceRequired>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_service#supported_regions-1">VpcEndpointService#supported_regions</a>.
        /// </summary>
        [<CustomOperation "supported_regions">]
        member _.SupportedRegions(state: VpcEndpointServiceState<'AcceptanceRequired>, value: seq<string>) : VpcEndpointServiceState<'AcceptanceRequired> =
            state.assignments.Add(fun config -> config.SupportedRegions <- (value |> Seq.toArray))
            state : VpcEndpointServiceState<'AcceptanceRequired>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_service#tags-1">VpcEndpointService#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpcEndpointServiceState<'AcceptanceRequired>, value: seq<string * string>) : VpcEndpointServiceState<'AcceptanceRequired> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpcEndpointServiceState<'AcceptanceRequired>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_service#tags_all-1">VpcEndpointService#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: VpcEndpointServiceState<'AcceptanceRequired>, value: seq<string * string>) : VpcEndpointServiceState<'AcceptanceRequired> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : VpcEndpointServiceState<'AcceptanceRequired>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_service#timeouts-1">VpcEndpointService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpcEndpointServiceState<'AcceptanceRequired>, value: aws.VpcEndpointService.VpcEndpointServiceTimeouts) : VpcEndpointServiceState<'AcceptanceRequired> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpcEndpointServiceState<'AcceptanceRequired>

        member _.Run(state: VpcEndpointServiceState<Present>) : aws.VpcEndpointService.VpcEndpointService =
            let config = aws.VpcEndpointService.VpcEndpointServiceConfig()
            for setter in state.assignments do
                setter config
            aws.VpcEndpointService.VpcEndpointService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcEndpointService: missing required arguments. Must call: acceptance_required.", 9999, IsError = true)>]
        member _.Run(_: VpcEndpointServiceState<_>) : aws.VpcEndpointService.VpcEndpointService =
            Unchecked.defaultof<aws.VpcEndpointService.VpcEndpointService>
