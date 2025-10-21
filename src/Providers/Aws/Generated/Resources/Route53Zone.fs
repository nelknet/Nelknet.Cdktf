namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53ZoneState<'Name> = { assignments: ResizeArray<aws.Route53Zone.Route53ZoneConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_zone">aws_route53_zone</a>.
    /// </summary>
    type Route53ZoneBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53ZoneState<Missing> =
            ({ assignments = ResizeArray() } : Route53ZoneState<Missing>)

        member _.Zero(()) : Route53ZoneState<Missing> =
            ({ assignments = ResizeArray() } : Route53ZoneState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_zone#name-1">Route53Zone#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Route53ZoneState<Missing>, value: string) : Route53ZoneState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Route53ZoneState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_zone#comment-1">Route53Zone#comment</a>.
        /// </summary>
        [<CustomOperation "comment">]
        member _.Comment(state: Route53ZoneState<'Name>, value: string) : Route53ZoneState<'Name> =
            state.assignments.Add(fun config -> config.Comment <- value)
            state : Route53ZoneState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_zone#delegation_set_id-1">Route53Zone#delegation_set_id</a>.
        /// </summary>
        [<CustomOperation "delegation_set_id">]
        member _.DelegationSetId(state: Route53ZoneState<'Name>, value: string) : Route53ZoneState<'Name> =
            state.assignments.Add(fun config -> config.DelegationSetId <- value)
            state : Route53ZoneState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_zone#force_destroy-1">Route53Zone#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: Route53ZoneState<'Name>, value: bool) : Route53ZoneState<'Name> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : Route53ZoneState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_zone#force_destroy-1">Route53Zone#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: Route53ZoneState<'Name>, value: HashiCorp.Cdktf.IResolvable) : Route53ZoneState<'Name> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : Route53ZoneState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_zone#id-1">Route53Zone#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53ZoneState<'Name>, value: string) : Route53ZoneState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53ZoneState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_zone#tags-1">Route53Zone#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Route53ZoneState<'Name>, value: seq<string * string>) : Route53ZoneState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Route53ZoneState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_zone#tags_all-1">Route53Zone#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Route53ZoneState<'Name>, value: seq<string * string>) : Route53ZoneState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Route53ZoneState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_zone#timeouts-1">Route53Zone#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Route53ZoneState<'Name>, value: aws.Route53Zone.Route53ZoneTimeouts) : Route53ZoneState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Route53ZoneState<'Name>

        /// <summary>
        /// vpc block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_zone#vpc-1">Route53Zone#vpc</a> Accepts: aws.IResolvable | aws.Route53Zone.Route53ZoneVpc[]
        /// </summary>
        [<CustomOperation "vpc">]
        member _.Vpc(state: Route53ZoneState<'Name>, value: HashiCorp.Cdktf.IResolvable) : Route53ZoneState<'Name> =
            state.assignments.Add(fun config -> config.Vpc <- value)
            state : Route53ZoneState<'Name>

        member _.Run(state: Route53ZoneState<Present>) : aws.Route53Zone.Route53Zone =
            let config = aws.Route53Zone.Route53ZoneConfig()
            for setter in state.assignments do
                setter config
            aws.Route53Zone.Route53Zone(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53Zone: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: Route53ZoneState<_>) : aws.Route53Zone.Route53Zone =
            Unchecked.defaultof<aws.Route53Zone.Route53Zone>
