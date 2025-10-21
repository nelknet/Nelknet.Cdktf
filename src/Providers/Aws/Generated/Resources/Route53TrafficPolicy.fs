namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53TrafficPolicyState<'Document, 'Name> = { assignments: ResizeArray<aws.Route53TrafficPolicy.Route53TrafficPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_traffic_policy">aws_route53_traffic_policy</a>.
    /// </summary>
    type Route53TrafficPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53TrafficPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53TrafficPolicyState<Missing, Missing>)

        member _.Zero(()) : Route53TrafficPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53TrafficPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_traffic_policy#document-1">Route53TrafficPolicy#document</a>.
        /// </summary>
        [<CustomOperation "document">]
        member _.Document(state: Route53TrafficPolicyState<Missing, 'Name>, value: string) : Route53TrafficPolicyState<Present, 'Name> =
            state.assignments.Add(fun config -> config.Document <- value)
            ({ assignments = state.assignments } : Route53TrafficPolicyState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_traffic_policy#name-1">Route53TrafficPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Route53TrafficPolicyState<'Document, Missing>, value: string) : Route53TrafficPolicyState<'Document, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Route53TrafficPolicyState<'Document, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_traffic_policy#comment-1">Route53TrafficPolicy#comment</a>.
        /// </summary>
        [<CustomOperation "comment">]
        member _.Comment(state: Route53TrafficPolicyState<'Document, 'Name>, value: string) : Route53TrafficPolicyState<'Document, 'Name> =
            state.assignments.Add(fun config -> config.Comment <- value)
            state : Route53TrafficPolicyState<'Document, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_traffic_policy#id-1">Route53TrafficPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53TrafficPolicyState<'Document, 'Name>, value: string) : Route53TrafficPolicyState<'Document, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53TrafficPolicyState<'Document, 'Name>

        member _.Run(state: Route53TrafficPolicyState<Present, Present>) : aws.Route53TrafficPolicy.Route53TrafficPolicy =
            let config = aws.Route53TrafficPolicy.Route53TrafficPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.Route53TrafficPolicy.Route53TrafficPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53TrafficPolicy: missing required arguments. Must call: document, name.", 9999, IsError = true)>]
        member _.Run(_: Route53TrafficPolicyState<_, _>) : aws.Route53TrafficPolicy.Route53TrafficPolicy =
            Unchecked.defaultof<aws.Route53TrafficPolicy.Route53TrafficPolicy>
