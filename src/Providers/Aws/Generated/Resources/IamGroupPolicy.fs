namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamGroupPolicyState<'Group, 'Policy> = { assignments: ResizeArray<aws.IamGroupPolicy.IamGroupPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_group_policy">aws_iam_group_policy</a>.
    /// </summary>
    type IamGroupPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamGroupPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamGroupPolicyState<Missing, Missing>)

        member _.Zero(()) : IamGroupPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamGroupPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_group_policy#group-1">IamGroupPolicy#group</a>.
        /// </summary>
        [<CustomOperation "group">]
        member _.Group(state: IamGroupPolicyState<Missing, 'Policy>, value: string) : IamGroupPolicyState<Present, 'Policy> =
            state.assignments.Add(fun config -> config.Group <- value)
            ({ assignments = state.assignments } : IamGroupPolicyState<Present, 'Policy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_group_policy#policy-1">IamGroupPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: IamGroupPolicyState<'Group, Missing>, value: string) : IamGroupPolicyState<'Group, Present> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : IamGroupPolicyState<'Group, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_group_policy#id-1">IamGroupPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IamGroupPolicyState<'Group, 'Policy>, value: string) : IamGroupPolicyState<'Group, 'Policy> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IamGroupPolicyState<'Group, 'Policy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_group_policy#name-1">IamGroupPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IamGroupPolicyState<'Group, 'Policy>, value: string) : IamGroupPolicyState<'Group, 'Policy> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : IamGroupPolicyState<'Group, 'Policy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_group_policy#name_prefix-1">IamGroupPolicy#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: IamGroupPolicyState<'Group, 'Policy>, value: string) : IamGroupPolicyState<'Group, 'Policy> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : IamGroupPolicyState<'Group, 'Policy>

        member _.Run(state: IamGroupPolicyState<Present, Present>) : aws.IamGroupPolicy.IamGroupPolicy =
            let config = aws.IamGroupPolicy.IamGroupPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.IamGroupPolicy.IamGroupPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamGroupPolicy: missing required arguments. Must call: group, policy.", 9999, IsError = true)>]
        member _.Run(_: IamGroupPolicyState<_, _>) : aws.IamGroupPolicy.IamGroupPolicy =
            Unchecked.defaultof<aws.IamGroupPolicy.IamGroupPolicy>
