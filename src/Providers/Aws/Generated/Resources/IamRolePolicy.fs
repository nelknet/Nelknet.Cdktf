namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamRolePolicyState<'Policy, 'Role> = { assignments: ResizeArray<aws.IamRolePolicy.IamRolePolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role_policy">aws_iam_role_policy</a>.
    /// </summary>
    type IamRolePolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamRolePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamRolePolicyState<Missing, Missing>)

        member _.Zero(()) : IamRolePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamRolePolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role_policy#policy-1">IamRolePolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: IamRolePolicyState<Missing, 'Role>, value: string) : IamRolePolicyState<Present, 'Role> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : IamRolePolicyState<Present, 'Role>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role_policy#role-1">IamRolePolicy#role</a>.
        /// </summary>
        [<CustomOperation "role">]
        member _.Role(state: IamRolePolicyState<'Policy, Missing>, value: string) : IamRolePolicyState<'Policy, Present> =
            state.assignments.Add(fun config -> config.Role <- value)
            ({ assignments = state.assignments } : IamRolePolicyState<'Policy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role_policy#id-1">IamRolePolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IamRolePolicyState<'Policy, 'Role>, value: string) : IamRolePolicyState<'Policy, 'Role> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IamRolePolicyState<'Policy, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role_policy#name-1">IamRolePolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IamRolePolicyState<'Policy, 'Role>, value: string) : IamRolePolicyState<'Policy, 'Role> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : IamRolePolicyState<'Policy, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_role_policy#name_prefix-1">IamRolePolicy#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: IamRolePolicyState<'Policy, 'Role>, value: string) : IamRolePolicyState<'Policy, 'Role> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : IamRolePolicyState<'Policy, 'Role>

        member _.Run(state: IamRolePolicyState<Present, Present>) : aws.IamRolePolicy.IamRolePolicy =
            let config = aws.IamRolePolicy.IamRolePolicyConfig()
            for setter in state.assignments do
                setter config
            aws.IamRolePolicy.IamRolePolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamRolePolicy: missing required arguments. Must call: policy, role.", 9999, IsError = true)>]
        member _.Run(_: IamRolePolicyState<_, _>) : aws.IamRolePolicy.IamRolePolicy =
            Unchecked.defaultof<aws.IamRolePolicy.IamRolePolicy>
