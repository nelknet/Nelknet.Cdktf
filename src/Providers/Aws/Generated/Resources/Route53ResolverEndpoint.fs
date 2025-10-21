namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53ResolverEndpointState<'Direction, 'IpAddress, 'SecurityGroupIds> = { assignments: ResizeArray<aws.Route53ResolverEndpoint.Route53ResolverEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_endpoint">aws_route53_resolver_endpoint</a>.
    /// </summary>
    type Route53ResolverEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53ResolverEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53ResolverEndpointState<Missing, Missing, Missing>)

        member _.Zero(()) : Route53ResolverEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53ResolverEndpointState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_endpoint#direction-1">Route53ResolverEndpoint#direction</a>.
        /// </summary>
        [<CustomOperation "direction">]
        member _.Direction(state: Route53ResolverEndpointState<Missing, 'IpAddress, 'SecurityGroupIds>, value: string) : Route53ResolverEndpointState<Present, 'IpAddress, 'SecurityGroupIds> =
            state.assignments.Add(fun config -> config.Direction <- value)
            ({ assignments = state.assignments } : Route53ResolverEndpointState<Present, 'IpAddress, 'SecurityGroupIds>)

        /// <summary>
        /// ip_address block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_endpoint#ip_address-1">Route53ResolverEndpoint#ip_address</a> Accepts: aws.IResolvable | aws.Route53ResolverEndpoint.Route53ResolverEndpointIpAddress[]
        /// </summary>
        [<CustomOperation "ip_address">]
        member _.IpAddress(state: Route53ResolverEndpointState<'Direction, Missing, 'SecurityGroupIds>, value: HashiCorp.Cdktf.IResolvable) : Route53ResolverEndpointState<'Direction, Present, 'SecurityGroupIds> =
            state.assignments.Add(fun config -> config.IpAddress <- value)
            ({ assignments = state.assignments } : Route53ResolverEndpointState<'Direction, Present, 'SecurityGroupIds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_endpoint#security_group_ids-1">Route53ResolverEndpoint#security_group_ids</a>.
        /// </summary>
        [<CustomOperation "security_group_ids">]
        member _.SecurityGroupIds(state: Route53ResolverEndpointState<'Direction, 'IpAddress, Missing>, value: seq<string>) : Route53ResolverEndpointState<'Direction, 'IpAddress, Present> =
            state.assignments.Add(fun config -> config.SecurityGroupIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : Route53ResolverEndpointState<'Direction, 'IpAddress, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_endpoint#id-1">Route53ResolverEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53ResolverEndpointState<'Direction, 'IpAddress, 'SecurityGroupIds>, value: string) : Route53ResolverEndpointState<'Direction, 'IpAddress, 'SecurityGroupIds> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53ResolverEndpointState<'Direction, 'IpAddress, 'SecurityGroupIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_endpoint#name-1">Route53ResolverEndpoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Route53ResolverEndpointState<'Direction, 'IpAddress, 'SecurityGroupIds>, value: string) : Route53ResolverEndpointState<'Direction, 'IpAddress, 'SecurityGroupIds> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : Route53ResolverEndpointState<'Direction, 'IpAddress, 'SecurityGroupIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_endpoint#protocols-1">Route53ResolverEndpoint#protocols</a>.
        /// </summary>
        [<CustomOperation "protocols">]
        member _.Protocols(state: Route53ResolverEndpointState<'Direction, 'IpAddress, 'SecurityGroupIds>, value: seq<string>) : Route53ResolverEndpointState<'Direction, 'IpAddress, 'SecurityGroupIds> =
            state.assignments.Add(fun config -> config.Protocols <- (value |> Seq.toArray))
            state : Route53ResolverEndpointState<'Direction, 'IpAddress, 'SecurityGroupIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_endpoint#resolver_endpoint_type-1">Route53ResolverEndpoint#resolver_endpoint_type</a>.
        /// </summary>
        [<CustomOperation "resolver_endpoint_type">]
        member _.ResolverEndpointType(state: Route53ResolverEndpointState<'Direction, 'IpAddress, 'SecurityGroupIds>, value: string) : Route53ResolverEndpointState<'Direction, 'IpAddress, 'SecurityGroupIds> =
            state.assignments.Add(fun config -> config.ResolverEndpointType <- value)
            state : Route53ResolverEndpointState<'Direction, 'IpAddress, 'SecurityGroupIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_endpoint#tags-1">Route53ResolverEndpoint#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Route53ResolverEndpointState<'Direction, 'IpAddress, 'SecurityGroupIds>, value: seq<string * string>) : Route53ResolverEndpointState<'Direction, 'IpAddress, 'SecurityGroupIds> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Route53ResolverEndpointState<'Direction, 'IpAddress, 'SecurityGroupIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_endpoint#tags_all-1">Route53ResolverEndpoint#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Route53ResolverEndpointState<'Direction, 'IpAddress, 'SecurityGroupIds>, value: seq<string * string>) : Route53ResolverEndpointState<'Direction, 'IpAddress, 'SecurityGroupIds> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Route53ResolverEndpointState<'Direction, 'IpAddress, 'SecurityGroupIds>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_resolver_endpoint#timeouts-1">Route53ResolverEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Route53ResolverEndpointState<'Direction, 'IpAddress, 'SecurityGroupIds>, value: aws.Route53ResolverEndpoint.Route53ResolverEndpointTimeouts) : Route53ResolverEndpointState<'Direction, 'IpAddress, 'SecurityGroupIds> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Route53ResolverEndpointState<'Direction, 'IpAddress, 'SecurityGroupIds>

        member _.Run(state: Route53ResolverEndpointState<Present, Present, Present>) : aws.Route53ResolverEndpoint.Route53ResolverEndpoint =
            let config = aws.Route53ResolverEndpoint.Route53ResolverEndpointConfig()
            for setter in state.assignments do
                setter config
            aws.Route53ResolverEndpoint.Route53ResolverEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53ResolverEndpoint: missing required arguments. Must call: direction, ip_address, security_group_ids.", 9999, IsError = true)>]
        member _.Run(_: Route53ResolverEndpointState<_, _, _>) : aws.Route53ResolverEndpoint.Route53ResolverEndpoint =
            Unchecked.defaultof<aws.Route53ResolverEndpoint.Route53ResolverEndpoint>
