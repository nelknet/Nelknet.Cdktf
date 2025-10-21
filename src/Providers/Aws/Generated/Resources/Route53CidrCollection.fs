namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53CidrCollectionState<'Name> = { assignments: ResizeArray<aws.Route53CidrCollection.Route53CidrCollectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_cidr_collection">aws_route53_cidr_collection</a>.
    /// </summary>
    type Route53CidrCollectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53CidrCollectionState<Missing> =
            ({ assignments = ResizeArray() } : Route53CidrCollectionState<Missing>)

        member _.Zero(()) : Route53CidrCollectionState<Missing> =
            ({ assignments = ResizeArray() } : Route53CidrCollectionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_cidr_collection#name-1">Route53CidrCollection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Route53CidrCollectionState<Missing>, value: string) : Route53CidrCollectionState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Route53CidrCollectionState<Present>)

        member _.Run(state: Route53CidrCollectionState<Present>) : aws.Route53CidrCollection.Route53CidrCollection =
            let config = aws.Route53CidrCollection.Route53CidrCollectionConfig()
            for setter in state.assignments do
                setter config
            aws.Route53CidrCollection.Route53CidrCollection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53CidrCollection: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: Route53CidrCollectionState<_>) : aws.Route53CidrCollection.Route53CidrCollection =
            Unchecked.defaultof<aws.Route53CidrCollection.Route53CidrCollection>
