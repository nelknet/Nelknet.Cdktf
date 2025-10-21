namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ShieldProactiveEngagementState<'Enabled> = { assignments: ResizeArray<aws.ShieldProactiveEngagement.ShieldProactiveEngagementConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_proactive_engagement">aws_shield_proactive_engagement</a>.
    /// </summary>
    type ShieldProactiveEngagementBuilder(logicalId: string) =
        member _.Yield(_: unit) : ShieldProactiveEngagementState<Missing> =
            ({ assignments = ResizeArray() } : ShieldProactiveEngagementState<Missing>)

        member _.Zero(()) : ShieldProactiveEngagementState<Missing> =
            ({ assignments = ResizeArray() } : ShieldProactiveEngagementState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_proactive_engagement#enabled-1">ShieldProactiveEngagement#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: ShieldProactiveEngagementState<Missing>, value: bool) : ShieldProactiveEngagementState<Present> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : ShieldProactiveEngagementState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_proactive_engagement#enabled-1">ShieldProactiveEngagement#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: ShieldProactiveEngagementState<Missing>, value: HashiCorp.Cdktf.IResolvable) : ShieldProactiveEngagementState<Present> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : ShieldProactiveEngagementState<Present>)

        /// <summary>
        /// emergency_contact block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_proactive_engagement#emergency_contact-1">ShieldProactiveEngagement#emergency_contact</a> Accepts: aws.IResolvable | aws.ShieldProactiveEngagement.ShieldProactiveEngagementEmergencyContact[]
        /// </summary>
        [<CustomOperation "emergency_contact">]
        member _.EmergencyContact(state: ShieldProactiveEngagementState<'Enabled>, value: HashiCorp.Cdktf.IResolvable) : ShieldProactiveEngagementState<'Enabled> =
            state.assignments.Add(fun config -> config.EmergencyContact <- value)
            state : ShieldProactiveEngagementState<'Enabled>

        member _.Run(state: ShieldProactiveEngagementState<Present>) : aws.ShieldProactiveEngagement.ShieldProactiveEngagement =
            let config = aws.ShieldProactiveEngagement.ShieldProactiveEngagementConfig()
            for setter in state.assignments do
                setter config
            aws.ShieldProactiveEngagement.ShieldProactiveEngagement(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.shieldProactiveEngagement: missing required arguments. Must call: enabled.", 9999, IsError = true)>]
        member _.Run(_: ShieldProactiveEngagementState<_>) : aws.ShieldProactiveEngagement.ShieldProactiveEngagement =
            Unchecked.defaultof<aws.ShieldProactiveEngagement.ShieldProactiveEngagement>
