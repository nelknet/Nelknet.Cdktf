namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53CidrLocationState<'CidrBlocks, 'CidrCollectionId, 'Name> = { assignments: ResizeArray<aws.Route53CidrLocation.Route53CidrLocationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_cidr_location">aws_route53_cidr_location</a>.
    /// </summary>
    type Route53CidrLocationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53CidrLocationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53CidrLocationState<Missing, Missing, Missing>)

        member _.Zero(()) : Route53CidrLocationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53CidrLocationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_cidr_location#cidr_blocks-1">Route53CidrLocation#cidr_blocks</a>.
        /// </summary>
        [<CustomOperation "cidr_blocks">]
        member _.CidrBlocks(state: Route53CidrLocationState<Missing, 'CidrCollectionId, 'Name>, value: seq<string>) : Route53CidrLocationState<Present, 'CidrCollectionId, 'Name> =
            state.assignments.Add(fun config -> config.CidrBlocks <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : Route53CidrLocationState<Present, 'CidrCollectionId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_cidr_location#cidr_collection_id-1">Route53CidrLocation#cidr_collection_id</a>.
        /// </summary>
        [<CustomOperation "cidr_collection_id">]
        member _.CidrCollectionId(state: Route53CidrLocationState<'CidrBlocks, Missing, 'Name>, value: string) : Route53CidrLocationState<'CidrBlocks, Present, 'Name> =
            state.assignments.Add(fun config -> config.CidrCollectionId <- value)
            ({ assignments = state.assignments } : Route53CidrLocationState<'CidrBlocks, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_cidr_location#name-1">Route53CidrLocation#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Route53CidrLocationState<'CidrBlocks, 'CidrCollectionId, Missing>, value: string) : Route53CidrLocationState<'CidrBlocks, 'CidrCollectionId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Route53CidrLocationState<'CidrBlocks, 'CidrCollectionId, Present>)

        member _.Run(state: Route53CidrLocationState<Present, Present, Present>) : aws.Route53CidrLocation.Route53CidrLocation =
            let config = aws.Route53CidrLocation.Route53CidrLocationConfig()
            for setter in state.assignments do
                setter config
            aws.Route53CidrLocation.Route53CidrLocation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53CidrLocation: missing required arguments. Must call: cidr_blocks, cidr_collection_id, name.", 9999, IsError = true)>]
        member _.Run(_: Route53CidrLocationState<_, _, _>) : aws.Route53CidrLocation.Route53CidrLocation =
            Unchecked.defaultof<aws.Route53CidrLocation.Route53CidrLocation>
