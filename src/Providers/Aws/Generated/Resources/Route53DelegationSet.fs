namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53DelegationSetState = { assignments: ResizeArray<aws.Route53DelegationSet.Route53DelegationSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_delegation_set">aws_route53_delegation_set</a>.
    /// </summary>
    type Route53DelegationSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53DelegationSetState =
            { assignments = ResizeArray() }

        member _.Zero(()) : Route53DelegationSetState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_delegation_set#id-1">Route53DelegationSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53DelegationSetState, value: string) : Route53DelegationSetState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53DelegationSetState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_delegation_set#reference_name-1">Route53DelegationSet#reference_name</a>.
        /// </summary>
        [<CustomOperation "reference_name">]
        member _.ReferenceName(state: Route53DelegationSetState, value: string) : Route53DelegationSetState =
            state.assignments.Add(fun config -> config.ReferenceName <- value)
            state : Route53DelegationSetState

        member _.Run(state: Route53DelegationSetState) : aws.Route53DelegationSet.Route53DelegationSet =
            let config = aws.Route53DelegationSet.Route53DelegationSetConfig()
            for setter in state.assignments do
                setter config
            aws.Route53DelegationSet.Route53DelegationSet(StackContext.get (), logicalId, config)
