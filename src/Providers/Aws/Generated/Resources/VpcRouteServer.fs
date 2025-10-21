namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcRouteServerState<'AmazonSideAsn> = { assignments: ResizeArray<aws.VpcRouteServer.VpcRouteServerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server">aws_vpc_route_server</a>.
    /// </summary>
    type VpcRouteServerBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcRouteServerState<Missing> =
            ({ assignments = ResizeArray() } : VpcRouteServerState<Missing>)

        member _.Zero(()) : VpcRouteServerState<Missing> =
            ({ assignments = ResizeArray() } : VpcRouteServerState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server#amazon_side_asn-1">VpcRouteServer#amazon_side_asn</a>.
        /// </summary>
        [<CustomOperation "amazon_side_asn">]
        member _.AmazonSideAsn(state: VpcRouteServerState<Missing>, value: double) : VpcRouteServerState<Present> =
            state.assignments.Add(fun config -> config.AmazonSideAsn <- value)
            ({ assignments = state.assignments } : VpcRouteServerState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server#persist_routes-1">VpcRouteServer#persist_routes</a>.
        /// </summary>
        [<CustomOperation "persist_routes">]
        member _.PersistRoutes(state: VpcRouteServerState<'AmazonSideAsn>, value: string) : VpcRouteServerState<'AmazonSideAsn> =
            state.assignments.Add(fun config -> config.PersistRoutes <- value)
            state : VpcRouteServerState<'AmazonSideAsn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server#persist_routes_duration-1">VpcRouteServer#persist_routes_duration</a>.
        /// </summary>
        [<CustomOperation "persist_routes_duration">]
        member _.PersistRoutesDuration(state: VpcRouteServerState<'AmazonSideAsn>, value: double) : VpcRouteServerState<'AmazonSideAsn> =
            state.assignments.Add(fun config -> config.PersistRoutesDuration <- value)
            state : VpcRouteServerState<'AmazonSideAsn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server#sns_notifications_enabled-1">VpcRouteServer#sns_notifications_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "sns_notifications_enabled">]
        member _.SnsNotificationsEnabled(state: VpcRouteServerState<'AmazonSideAsn>, value: bool) : VpcRouteServerState<'AmazonSideAsn> =
            state.assignments.Add(fun config -> config.SnsNotificationsEnabled <- value)
            state : VpcRouteServerState<'AmazonSideAsn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server#sns_notifications_enabled-1">VpcRouteServer#sns_notifications_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "sns_notifications_enabled">]
        member _.SnsNotificationsEnabled(state: VpcRouteServerState<'AmazonSideAsn>, value: HashiCorp.Cdktf.IResolvable) : VpcRouteServerState<'AmazonSideAsn> =
            state.assignments.Add(fun config -> config.SnsNotificationsEnabled <- value)
            state : VpcRouteServerState<'AmazonSideAsn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server#tags-1">VpcRouteServer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpcRouteServerState<'AmazonSideAsn>, value: seq<string * string>) : VpcRouteServerState<'AmazonSideAsn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpcRouteServerState<'AmazonSideAsn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_route_server#timeouts-1">VpcRouteServer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpcRouteServerState<'AmazonSideAsn>, value: aws.VpcRouteServer.VpcRouteServerTimeouts) : VpcRouteServerState<'AmazonSideAsn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpcRouteServerState<'AmazonSideAsn>

        member _.Run(state: VpcRouteServerState<Present>) : aws.VpcRouteServer.VpcRouteServer =
            let config = aws.VpcRouteServer.VpcRouteServerConfig()
            for setter in state.assignments do
                setter config
            aws.VpcRouteServer.VpcRouteServer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcRouteServer: missing required arguments. Must call: amazon_side_asn.", 9999, IsError = true)>]
        member _.Run(_: VpcRouteServerState<_>) : aws.VpcRouteServer.VpcRouteServer =
            Unchecked.defaultof<aws.VpcRouteServer.VpcRouteServer>
