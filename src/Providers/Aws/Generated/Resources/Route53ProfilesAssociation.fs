namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53ProfilesAssociationState<'Name, 'ProfileId, 'ResourceId> = { assignments: ResizeArray<aws.Route53ProfilesAssociation.Route53ProfilesAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53profiles_association">aws_route53profiles_association</a>.
    /// </summary>
    type Route53ProfilesAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53ProfilesAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53ProfilesAssociationState<Missing, Missing, Missing>)

        member _.Zero(()) : Route53ProfilesAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53ProfilesAssociationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53profiles_association#name-1">Route53ProfilesAssociation#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Route53ProfilesAssociationState<Missing, 'ProfileId, 'ResourceId>, value: string) : Route53ProfilesAssociationState<Present, 'ProfileId, 'ResourceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Route53ProfilesAssociationState<Present, 'ProfileId, 'ResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53profiles_association#profile_id-1">Route53ProfilesAssociation#profile_id</a>.
        /// </summary>
        [<CustomOperation "profile_id">]
        member _.ProfileId(state: Route53ProfilesAssociationState<'Name, Missing, 'ResourceId>, value: string) : Route53ProfilesAssociationState<'Name, Present, 'ResourceId> =
            state.assignments.Add(fun config -> config.ProfileId <- value)
            ({ assignments = state.assignments } : Route53ProfilesAssociationState<'Name, Present, 'ResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53profiles_association#resource_id-1">Route53ProfilesAssociation#resource_id</a>.
        /// </summary>
        [<CustomOperation "resource_id">]
        member _.ResourceId(state: Route53ProfilesAssociationState<'Name, 'ProfileId, Missing>, value: string) : Route53ProfilesAssociationState<'Name, 'ProfileId, Present> =
            state.assignments.Add(fun config -> config.ResourceId <- value)
            ({ assignments = state.assignments } : Route53ProfilesAssociationState<'Name, 'ProfileId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53profiles_association#tags-1">Route53ProfilesAssociation#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Route53ProfilesAssociationState<'Name, 'ProfileId, 'ResourceId>, value: seq<string * string>) : Route53ProfilesAssociationState<'Name, 'ProfileId, 'ResourceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Route53ProfilesAssociationState<'Name, 'ProfileId, 'ResourceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53profiles_association#timeouts-1">Route53ProfilesAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Route53ProfilesAssociationState<'Name, 'ProfileId, 'ResourceId>, value: aws.Route53ProfilesAssociation.Route53ProfilesAssociationTimeouts) : Route53ProfilesAssociationState<'Name, 'ProfileId, 'ResourceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Route53ProfilesAssociationState<'Name, 'ProfileId, 'ResourceId>

        member _.Run(state: Route53ProfilesAssociationState<Present, Present, Present>) : aws.Route53ProfilesAssociation.Route53ProfilesAssociation =
            let config = aws.Route53ProfilesAssociation.Route53ProfilesAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.Route53ProfilesAssociation.Route53ProfilesAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53ProfilesAssociation: missing required arguments. Must call: name, profile_id, resource_id.", 9999, IsError = true)>]
        member _.Run(_: Route53ProfilesAssociationState<_, _, _>) : aws.Route53ProfilesAssociation.Route53ProfilesAssociation =
            Unchecked.defaultof<aws.Route53ProfilesAssociation.Route53ProfilesAssociation>
