namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsIamPrincipalPolicySimulationState<'ActionNames, 'PolicySourceArn> = { assignments: ResizeArray<aws.DataAwsIamPrincipalPolicySimulation.DataAwsIamPrincipalPolicySimulationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation">aws_iam_principal_policy_simulation</a>.
    /// </summary>
    type DataAwsIamPrincipalPolicySimulationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsIamPrincipalPolicySimulationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsIamPrincipalPolicySimulationState<Missing, Missing>)

        member _.Zero(()) : DataAwsIamPrincipalPolicySimulationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsIamPrincipalPolicySimulationState<Missing, Missing>)

        /// <summary>
        /// One or more names of actions, like "iam:CreateUser", that should be included in the simulation. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#action_names-1">DataAwsIamPrincipalPolicySimulation#action_names</a>
        /// </summary>
        [<CustomOperation "action_names">]
        member _.ActionNames(state: DataAwsIamPrincipalPolicySimulationState<Missing, 'PolicySourceArn>, value: seq<string>) : DataAwsIamPrincipalPolicySimulationState<Present, 'PolicySourceArn> =
            state.assignments.Add(fun config -> config.ActionNames <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DataAwsIamPrincipalPolicySimulationState<Present, 'PolicySourceArn>)

        /// <summary>
        /// ARN of the principal (e.g. user, role) whose existing configured access policies will be used as the basis for the simulation. If you specify a role ARN here, you can also set caller_arn to simulate a particular user acting with the given role. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#policy_source_arn-1">DataAwsIamPrincipalPolicySimulation#policy_source_arn</a>
        /// </summary>
        [<CustomOperation "policy_source_arn">]
        member _.PolicySourceArn(state: DataAwsIamPrincipalPolicySimulationState<'ActionNames, Missing>, value: string) : DataAwsIamPrincipalPolicySimulationState<'ActionNames, Present> =
            state.assignments.Add(fun config -> config.PolicySourceArn <- value)
            ({ assignments = state.assignments } : DataAwsIamPrincipalPolicySimulationState<'ActionNames, Present>)

        /// <summary>
        /// Additional principal-based policies to use in the simulation. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#additional_policies_json-1">DataAwsIamPrincipalPolicySimulation#additional_policies_json</a>
        /// </summary>
        [<CustomOperation "additional_policies_json">]
        member _.AdditionalPoliciesJson(state: DataAwsIamPrincipalPolicySimulationState<'ActionNames, 'PolicySourceArn>, value: seq<string>) : DataAwsIamPrincipalPolicySimulationState<'ActionNames, 'PolicySourceArn> =
            state.assignments.Add(fun config -> config.AdditionalPoliciesJson <- (value |> Seq.toArray))
            state : DataAwsIamPrincipalPolicySimulationState<'ActionNames, 'PolicySourceArn>

        /// <summary>
        /// ARN of a user to use as the caller of the simulated requests. If not specified, defaults to the principal specified in policy_source_arn, if it is a user ARN. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#caller_arn-1">DataAwsIamPrincipalPolicySimulation#caller_arn</a>
        /// </summary>
        [<CustomOperation "caller_arn">]
        member _.CallerArn(state: DataAwsIamPrincipalPolicySimulationState<'ActionNames, 'PolicySourceArn>, value: string) : DataAwsIamPrincipalPolicySimulationState<'ActionNames, 'PolicySourceArn> =
            state.assignments.Add(fun config -> config.CallerArn <- value)
            state : DataAwsIamPrincipalPolicySimulationState<'ActionNames, 'PolicySourceArn>

        /// <summary>
        /// context block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#context-1">DataAwsIamPrincipalPolicySimulation#context</a> Accepts: aws.IResolvable | aws.DataAwsIamPrincipalPolicySimulation.DataAwsIamPrincipalPolicySimulationContext[]
        /// </summary>
        [<CustomOperation "context">]
        member _.Context(state: DataAwsIamPrincipalPolicySimulationState<'ActionNames, 'PolicySourceArn>, value: HashiCorp.Cdktf.IResolvable) : DataAwsIamPrincipalPolicySimulationState<'ActionNames, 'PolicySourceArn> =
            state.assignments.Add(fun config -> config.Context <- value)
            state : DataAwsIamPrincipalPolicySimulationState<'ActionNames, 'PolicySourceArn>

        /// <summary>
        /// Additional permission boundary policies to use in the simulation. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#permissions_boundary_policies_json-1">DataAwsIamPrincipalPolicySimulation#permissions_boundary_policies_json</a>
        /// </summary>
        [<CustomOperation "permissions_boundary_policies_json">]
        member _.PermissionsBoundaryPoliciesJson(state: DataAwsIamPrincipalPolicySimulationState<'ActionNames, 'PolicySourceArn>, value: seq<string>) : DataAwsIamPrincipalPolicySimulationState<'ActionNames, 'PolicySourceArn> =
            state.assignments.Add(fun config -> config.PermissionsBoundaryPoliciesJson <- (value |> Seq.toArray))
            state : DataAwsIamPrincipalPolicySimulationState<'ActionNames, 'PolicySourceArn>

        /// <summary>
        /// ARNs of specific resources to use as the targets of the specified actions during simulation. If not specified, the simulator assumes "*" which represents general access across all resources. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#resource_arns-1">DataAwsIamPrincipalPolicySimulation#resource_arns</a>
        /// </summary>
        [<CustomOperation "resource_arns">]
        member _.ResourceArns(state: DataAwsIamPrincipalPolicySimulationState<'ActionNames, 'PolicySourceArn>, value: seq<string>) : DataAwsIamPrincipalPolicySimulationState<'ActionNames, 'PolicySourceArn> =
            state.assignments.Add(fun config -> config.ResourceArns <- (value |> Seq.toArray))
            state : DataAwsIamPrincipalPolicySimulationState<'ActionNames, 'PolicySourceArn>

        /// <summary>
        /// Specifies the type of simulation to run. Some API operations need a particular resource handling option in order to produce a correct reesult. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#resource_handling_option-1">DataAwsIamPrincipalPolicySimulation#resource_handling_option</a>
        /// </summary>
        [<CustomOperation "resource_handling_option">]
        member _.ResourceHandlingOption(state: DataAwsIamPrincipalPolicySimulationState<'ActionNames, 'PolicySourceArn>, value: string) : DataAwsIamPrincipalPolicySimulationState<'ActionNames, 'PolicySourceArn> =
            state.assignments.Add(fun config -> config.ResourceHandlingOption <- value)
            state : DataAwsIamPrincipalPolicySimulationState<'ActionNames, 'PolicySourceArn>

        /// <summary>
        /// An AWS account ID to use as the simulated owner for any resource whose ARN does not include a specific owner account ID. Defaults to the account given as part of caller_arn. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#resource_owner_account_id-1">DataAwsIamPrincipalPolicySimulation#resource_owner_account_id</a>
        /// </summary>
        [<CustomOperation "resource_owner_account_id">]
        member _.ResourceOwnerAccountId(state: DataAwsIamPrincipalPolicySimulationState<'ActionNames, 'PolicySourceArn>, value: string) : DataAwsIamPrincipalPolicySimulationState<'ActionNames, 'PolicySourceArn> =
            state.assignments.Add(fun config -> config.ResourceOwnerAccountId <- value)
            state : DataAwsIamPrincipalPolicySimulationState<'ActionNames, 'PolicySourceArn>

        /// <summary>
        /// A resource policy to associate with all of the target resources for simulation purposes. The policy simulator does not automatically retrieve resource-level policies, so if a resource policy is crucial to your test then you must specify here the same policy document associated with your target resource(s). Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#resource_policy_json-1">DataAwsIamPrincipalPolicySimulation#resource_policy_json</a>
        /// </summary>
        [<CustomOperation "resource_policy_json">]
        member _.ResourcePolicyJson(state: DataAwsIamPrincipalPolicySimulationState<'ActionNames, 'PolicySourceArn>, value: string) : DataAwsIamPrincipalPolicySimulationState<'ActionNames, 'PolicySourceArn> =
            state.assignments.Add(fun config -> config.ResourcePolicyJson <- value)
            state : DataAwsIamPrincipalPolicySimulationState<'ActionNames, 'PolicySourceArn>

        member _.Run(state: DataAwsIamPrincipalPolicySimulationState<Present, Present>) : aws.DataAwsIamPrincipalPolicySimulation.DataAwsIamPrincipalPolicySimulation =
            let config = aws.DataAwsIamPrincipalPolicySimulation.DataAwsIamPrincipalPolicySimulationConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsIamPrincipalPolicySimulation.DataAwsIamPrincipalPolicySimulation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsIamPrincipalPolicySimulation: missing required arguments. Must call: action_names, policy_source_arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsIamPrincipalPolicySimulationState<_, _>) : aws.DataAwsIamPrincipalPolicySimulation.DataAwsIamPrincipalPolicySimulation =
            Unchecked.defaultof<aws.DataAwsIamPrincipalPolicySimulation.DataAwsIamPrincipalPolicySimulation>
