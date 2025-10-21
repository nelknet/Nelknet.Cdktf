namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DynamodbResourcePolicyState<'Policy, 'ResourceArn> = { assignments: ResizeArray<aws.DynamodbResourcePolicy.DynamodbResourcePolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_resource_policy">aws_dynamodb_resource_policy</a>.
    /// </summary>
    type DynamodbResourcePolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DynamodbResourcePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DynamodbResourcePolicyState<Missing, Missing>)

        member _.Zero(()) : DynamodbResourcePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DynamodbResourcePolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_resource_policy#policy-1">DynamodbResourcePolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: DynamodbResourcePolicyState<Missing, 'ResourceArn>, value: string) : DynamodbResourcePolicyState<Present, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : DynamodbResourcePolicyState<Present, 'ResourceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_resource_policy#resource_arn-1">DynamodbResourcePolicy#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: DynamodbResourcePolicyState<'Policy, Missing>, value: string) : DynamodbResourcePolicyState<'Policy, Present> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : DynamodbResourcePolicyState<'Policy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_resource_policy#confirm_remove_self_resource_access-1">DynamodbResourcePolicy#confirm_remove_self_resource_access</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "confirm_remove_self_resource_access">]
        member _.ConfirmRemoveSelfResourceAccess(state: DynamodbResourcePolicyState<'Policy, 'ResourceArn>, value: bool) : DynamodbResourcePolicyState<'Policy, 'ResourceArn> =
            state.assignments.Add(fun config -> config.ConfirmRemoveSelfResourceAccess <- value)
            state : DynamodbResourcePolicyState<'Policy, 'ResourceArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_resource_policy#confirm_remove_self_resource_access-1">DynamodbResourcePolicy#confirm_remove_self_resource_access</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "confirm_remove_self_resource_access">]
        member _.ConfirmRemoveSelfResourceAccess(state: DynamodbResourcePolicyState<'Policy, 'ResourceArn>, value: HashiCorp.Cdktf.IResolvable) : DynamodbResourcePolicyState<'Policy, 'ResourceArn> =
            state.assignments.Add(fun config -> config.ConfirmRemoveSelfResourceAccess <- value)
            state : DynamodbResourcePolicyState<'Policy, 'ResourceArn>

        member _.Run(state: DynamodbResourcePolicyState<Present, Present>) : aws.DynamodbResourcePolicy.DynamodbResourcePolicy =
            let config = aws.DynamodbResourcePolicy.DynamodbResourcePolicyConfig()
            for setter in state.assignments do
                setter config
            aws.DynamodbResourcePolicy.DynamodbResourcePolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dynamodbResourcePolicy: missing required arguments. Must call: policy, resource_arn.", 9999, IsError = true)>]
        member _.Run(_: DynamodbResourcePolicyState<_, _>) : aws.DynamodbResourcePolicy.DynamodbResourcePolicy =
            Unchecked.defaultof<aws.DynamodbResourcePolicy.DynamodbResourcePolicy>
