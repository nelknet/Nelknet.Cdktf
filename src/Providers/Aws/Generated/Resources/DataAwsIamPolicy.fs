namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsIamPolicyState = { assignments: ResizeArray<aws.DataAwsIamPolicy.DataAwsIamPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy">aws_iam_policy</a>.
    /// </summary>
    type DataAwsIamPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsIamPolicyState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsIamPolicyState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy#arn-1">DataAwsIamPolicy#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsIamPolicyState, value: string) : DataAwsIamPolicyState =
            state.assignments.Add(fun config -> config.Arn <- value)
            state : DataAwsIamPolicyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy#id-1">DataAwsIamPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsIamPolicyState, value: string) : DataAwsIamPolicyState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsIamPolicyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy#name-1">DataAwsIamPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsIamPolicyState, value: string) : DataAwsIamPolicyState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsIamPolicyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy#path_prefix-1">DataAwsIamPolicy#path_prefix</a>.
        /// </summary>
        [<CustomOperation "path_prefix">]
        member _.PathPrefix(state: DataAwsIamPolicyState, value: string) : DataAwsIamPolicyState =
            state.assignments.Add(fun config -> config.PathPrefix <- value)
            state : DataAwsIamPolicyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy#tags-1">DataAwsIamPolicy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsIamPolicyState, value: seq<string * string>) : DataAwsIamPolicyState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsIamPolicyState

        member _.Run(state: DataAwsIamPolicyState) : aws.DataAwsIamPolicy.DataAwsIamPolicy =
            let config = aws.DataAwsIamPolicy.DataAwsIamPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsIamPolicy.DataAwsIamPolicy(StackContext.get (), logicalId, config)
