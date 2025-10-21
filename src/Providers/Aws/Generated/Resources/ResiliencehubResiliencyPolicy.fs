namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ResiliencehubResiliencyPolicyState<'Name, 'Tier> = { assignments: ResizeArray<aws.ResiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy">aws_resiliencehub_resiliency_policy</a>.
    /// </summary>
    type ResiliencehubResiliencyPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : ResiliencehubResiliencyPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ResiliencehubResiliencyPolicyState<Missing, Missing>)

        member _.Zero(()) : ResiliencehubResiliencyPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ResiliencehubResiliencyPolicyState<Missing, Missing>)

        /// <summary>
        /// The name of the policy. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#name-1">ResiliencehubResiliencyPolicy#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ResiliencehubResiliencyPolicyState<Missing, 'Tier>, value: string) : ResiliencehubResiliencyPolicyState<Present, 'Tier> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ResiliencehubResiliencyPolicyState<Present, 'Tier>)

        /// <summary>
        /// The tier for the resiliency policy, ranging from the highest severity (MissionCritical) to lowest (NonCritical). Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#tier-1">ResiliencehubResiliencyPolicy#tier</a>
        /// </summary>
        [<CustomOperation "tier">]
        member _.Tier(state: ResiliencehubResiliencyPolicyState<'Name, Missing>, value: string) : ResiliencehubResiliencyPolicyState<'Name, Present> =
            state.assignments.Add(fun config -> config.Tier <- value)
            ({ assignments = state.assignments } : ResiliencehubResiliencyPolicyState<'Name, Present>)

        /// <summary>
        /// Specifies a high-level geographical location constraint for where resilience policy data can be stored. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#data_location_constraint-1">ResiliencehubResiliencyPolicy#data_location_constraint</a>
        /// </summary>
        [<CustomOperation "data_location_constraint">]
        member _.DataLocationConstraint(state: ResiliencehubResiliencyPolicyState<'Name, 'Tier>, value: string) : ResiliencehubResiliencyPolicyState<'Name, 'Tier> =
            state.assignments.Add(fun config -> config.DataLocationConstraint <- value)
            state : ResiliencehubResiliencyPolicyState<'Name, 'Tier>

        /// <summary>
        /// The description for the policy. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#description-1">ResiliencehubResiliencyPolicy#description</a>
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ResiliencehubResiliencyPolicyState<'Name, 'Tier>, value: string) : ResiliencehubResiliencyPolicyState<'Name, 'Tier> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ResiliencehubResiliencyPolicyState<'Name, 'Tier>

        /// <summary>
        /// policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#policy-1">ResiliencehubResiliencyPolicy#policy</a>
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: ResiliencehubResiliencyPolicyState<'Name, 'Tier>, value: aws.ResiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicy) : ResiliencehubResiliencyPolicyState<'Name, 'Tier> =
            state.assignments.Add(fun config -> config.Policy <- value)
            state : ResiliencehubResiliencyPolicyState<'Name, 'Tier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#tags-1">ResiliencehubResiliencyPolicy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ResiliencehubResiliencyPolicyState<'Name, 'Tier>, value: seq<string * string>) : ResiliencehubResiliencyPolicyState<'Name, 'Tier> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ResiliencehubResiliencyPolicyState<'Name, 'Tier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#timeouts-1">ResiliencehubResiliencyPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ResiliencehubResiliencyPolicyState<'Name, 'Tier>, value: aws.ResiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyTimeouts) : ResiliencehubResiliencyPolicyState<'Name, 'Tier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ResiliencehubResiliencyPolicyState<'Name, 'Tier>

        member _.Run(state: ResiliencehubResiliencyPolicyState<Present, Present>) : aws.ResiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicy =
            let config = aws.ResiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.ResiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.resiliencehubResiliencyPolicy: missing required arguments. Must call: name, tier.", 9999, IsError = true)>]
        member _.Run(_: ResiliencehubResiliencyPolicyState<_, _>) : aws.ResiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicy =
            Unchecked.defaultof<aws.ResiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicy>
