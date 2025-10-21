namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamUserPolicyState<'Policy, 'User> = { assignments: ResizeArray<aws.IamUserPolicy.IamUserPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_policy">aws_iam_user_policy</a>.
    /// </summary>
    type IamUserPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamUserPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamUserPolicyState<Missing, Missing>)

        member _.Zero(()) : IamUserPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamUserPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_policy#policy-1">IamUserPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: IamUserPolicyState<Missing, 'User>, value: string) : IamUserPolicyState<Present, 'User> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : IamUserPolicyState<Present, 'User>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_policy#user-1">IamUserPolicy#user</a>.
        /// </summary>
        [<CustomOperation "user">]
        member _.User(state: IamUserPolicyState<'Policy, Missing>, value: string) : IamUserPolicyState<'Policy, Present> =
            state.assignments.Add(fun config -> config.User <- value)
            ({ assignments = state.assignments } : IamUserPolicyState<'Policy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_policy#id-1">IamUserPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IamUserPolicyState<'Policy, 'User>, value: string) : IamUserPolicyState<'Policy, 'User> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IamUserPolicyState<'Policy, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_policy#name-1">IamUserPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IamUserPolicyState<'Policy, 'User>, value: string) : IamUserPolicyState<'Policy, 'User> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : IamUserPolicyState<'Policy, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_policy#name_prefix-1">IamUserPolicy#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: IamUserPolicyState<'Policy, 'User>, value: string) : IamUserPolicyState<'Policy, 'User> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : IamUserPolicyState<'Policy, 'User>

        member _.Run(state: IamUserPolicyState<Present, Present>) : aws.IamUserPolicy.IamUserPolicy =
            let config = aws.IamUserPolicy.IamUserPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.IamUserPolicy.IamUserPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamUserPolicy: missing required arguments. Must call: policy, user.", 9999, IsError = true)>]
        member _.Run(_: IamUserPolicyState<_, _>) : aws.IamUserPolicy.IamUserPolicy =
            Unchecked.defaultof<aws.IamUserPolicy.IamUserPolicy>
