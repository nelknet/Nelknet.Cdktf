namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53ProfilesProfileState<'Name> = { assignments: ResizeArray<aws.Route53ProfilesProfile.Route53ProfilesProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53profiles_profile">aws_route53profiles_profile</a>.
    /// </summary>
    type Route53ProfilesProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53ProfilesProfileState<Missing> =
            ({ assignments = ResizeArray() } : Route53ProfilesProfileState<Missing>)

        member _.Zero(()) : Route53ProfilesProfileState<Missing> =
            ({ assignments = ResizeArray() } : Route53ProfilesProfileState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53profiles_profile#name-1">Route53ProfilesProfile#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Route53ProfilesProfileState<Missing>, value: string) : Route53ProfilesProfileState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Route53ProfilesProfileState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53profiles_profile#tags-1">Route53ProfilesProfile#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Route53ProfilesProfileState<'Name>, value: seq<string * string>) : Route53ProfilesProfileState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Route53ProfilesProfileState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53profiles_profile#timeouts-1">Route53ProfilesProfile#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Route53ProfilesProfileState<'Name>, value: aws.Route53ProfilesProfile.Route53ProfilesProfileTimeouts) : Route53ProfilesProfileState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Route53ProfilesProfileState<'Name>

        member _.Run(state: Route53ProfilesProfileState<Present>) : aws.Route53ProfilesProfile.Route53ProfilesProfile =
            let config = aws.Route53ProfilesProfile.Route53ProfilesProfileConfig()
            for setter in state.assignments do
                setter config
            aws.Route53ProfilesProfile.Route53ProfilesProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53ProfilesProfile: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: Route53ProfilesProfileState<_>) : aws.Route53ProfilesProfile.Route53ProfilesProfile =
            Unchecked.defaultof<aws.Route53ProfilesProfile.Route53ProfilesProfile>
