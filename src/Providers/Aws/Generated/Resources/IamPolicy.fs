namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamPolicyState<'Policy> = { assignments: ResizeArray<aws.IamPolicy.IamPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_policy">aws_iam_policy</a>.
    /// </summary>
    type IamPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamPolicyState<Missing> =
            ({ assignments = ResizeArray() } : IamPolicyState<Missing>)

        member _.Zero(()) : IamPolicyState<Missing> =
            ({ assignments = ResizeArray() } : IamPolicyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_policy#policy-1">IamPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: IamPolicyState<Missing>, value: string) : IamPolicyState<Present> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : IamPolicyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_policy#description-1">IamPolicy#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: IamPolicyState<'Policy>, value: string) : IamPolicyState<'Policy> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : IamPolicyState<'Policy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_policy#id-1">IamPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IamPolicyState<'Policy>, value: string) : IamPolicyState<'Policy> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IamPolicyState<'Policy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_policy#name-1">IamPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IamPolicyState<'Policy>, value: string) : IamPolicyState<'Policy> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : IamPolicyState<'Policy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_policy#name_prefix-1">IamPolicy#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: IamPolicyState<'Policy>, value: string) : IamPolicyState<'Policy> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : IamPolicyState<'Policy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_policy#path-1">IamPolicy#path</a>.
        /// </summary>
        [<CustomOperation "path">]
        member _.Path(state: IamPolicyState<'Policy>, value: string) : IamPolicyState<'Policy> =
            state.assignments.Add(fun config -> config.Path <- value)
            state : IamPolicyState<'Policy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_policy#tags-1">IamPolicy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IamPolicyState<'Policy>, value: seq<string * string>) : IamPolicyState<'Policy> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IamPolicyState<'Policy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_policy#tags_all-1">IamPolicy#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: IamPolicyState<'Policy>, value: seq<string * string>) : IamPolicyState<'Policy> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : IamPolicyState<'Policy>

        member _.Run(state: IamPolicyState<Present>) : aws.IamPolicy.IamPolicy =
            let config = aws.IamPolicy.IamPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.IamPolicy.IamPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamPolicy: missing required arguments. Must call: policy.", 9999, IsError = true)>]
        member _.Run(_: IamPolicyState<_>) : aws.IamPolicy.IamPolicy =
            Unchecked.defaultof<aws.IamPolicy.IamPolicy>
