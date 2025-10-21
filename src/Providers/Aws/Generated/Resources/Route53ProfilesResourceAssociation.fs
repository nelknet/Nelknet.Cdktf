namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53ProfilesResourceAssociationState<'Name, 'ProfileId, 'ResourceArn> = { assignments: ResizeArray<aws.Route53ProfilesResourceAssociation.Route53ProfilesResourceAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53profiles_resource_association">aws_route53profiles_resource_association</a>.
    /// </summary>
    type Route53ProfilesResourceAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53ProfilesResourceAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53ProfilesResourceAssociationState<Missing, Missing, Missing>)

        member _.Zero(()) : Route53ProfilesResourceAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53ProfilesResourceAssociationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53profiles_resource_association#name-1">Route53ProfilesResourceAssociation#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Route53ProfilesResourceAssociationState<Missing, 'ProfileId, 'ResourceArn>, value: string) : Route53ProfilesResourceAssociationState<Present, 'ProfileId, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Route53ProfilesResourceAssociationState<Present, 'ProfileId, 'ResourceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53profiles_resource_association#profile_id-1">Route53ProfilesResourceAssociation#profile_id</a>.
        /// </summary>
        [<CustomOperation "profile_id">]
        member _.ProfileId(state: Route53ProfilesResourceAssociationState<'Name, Missing, 'ResourceArn>, value: string) : Route53ProfilesResourceAssociationState<'Name, Present, 'ResourceArn> =
            state.assignments.Add(fun config -> config.ProfileId <- value)
            ({ assignments = state.assignments } : Route53ProfilesResourceAssociationState<'Name, Present, 'ResourceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53profiles_resource_association#resource_arn-1">Route53ProfilesResourceAssociation#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: Route53ProfilesResourceAssociationState<'Name, 'ProfileId, Missing>, value: string) : Route53ProfilesResourceAssociationState<'Name, 'ProfileId, Present> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : Route53ProfilesResourceAssociationState<'Name, 'ProfileId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53profiles_resource_association#resource_properties-1">Route53ProfilesResourceAssociation#resource_properties</a>.
        /// </summary>
        [<CustomOperation "resource_properties">]
        member _.ResourceProperties(state: Route53ProfilesResourceAssociationState<'Name, 'ProfileId, 'ResourceArn>, value: string) : Route53ProfilesResourceAssociationState<'Name, 'ProfileId, 'ResourceArn> =
            state.assignments.Add(fun config -> config.ResourceProperties <- value)
            state : Route53ProfilesResourceAssociationState<'Name, 'ProfileId, 'ResourceArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53profiles_resource_association#timeouts-1">Route53ProfilesResourceAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Route53ProfilesResourceAssociationState<'Name, 'ProfileId, 'ResourceArn>, value: aws.Route53ProfilesResourceAssociation.Route53ProfilesResourceAssociationTimeouts) : Route53ProfilesResourceAssociationState<'Name, 'ProfileId, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Route53ProfilesResourceAssociationState<'Name, 'ProfileId, 'ResourceArn>

        member _.Run(state: Route53ProfilesResourceAssociationState<Present, Present, Present>) : aws.Route53ProfilesResourceAssociation.Route53ProfilesResourceAssociation =
            let config = aws.Route53ProfilesResourceAssociation.Route53ProfilesResourceAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.Route53ProfilesResourceAssociation.Route53ProfilesResourceAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53ProfilesResourceAssociation: missing required arguments. Must call: name, profile_id, resource_arn.", 9999, IsError = true)>]
        member _.Run(_: Route53ProfilesResourceAssociationState<_, _, _>) : aws.Route53ProfilesResourceAssociation.Route53ProfilesResourceAssociation =
            Unchecked.defaultof<aws.Route53ProfilesResourceAssociation.Route53ProfilesResourceAssociation>
