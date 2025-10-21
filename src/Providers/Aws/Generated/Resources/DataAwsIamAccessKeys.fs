namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsIamAccessKeysState<'User> = { assignments: ResizeArray<aws.DataAwsIamAccessKeys.DataAwsIamAccessKeysConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_access_keys">aws_iam_access_keys</a>.
    /// </summary>
    type DataAwsIamAccessKeysBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsIamAccessKeysState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsIamAccessKeysState<Missing>)

        member _.Zero(()) : DataAwsIamAccessKeysState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsIamAccessKeysState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_access_keys#user-1">DataAwsIamAccessKeys#user</a>.
        /// </summary>
        [<CustomOperation "user">]
        member _.User(state: DataAwsIamAccessKeysState<Missing>, value: string) : DataAwsIamAccessKeysState<Present> =
            state.assignments.Add(fun config -> config.User <- value)
            ({ assignments = state.assignments } : DataAwsIamAccessKeysState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_access_keys#id-1">DataAwsIamAccessKeys#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsIamAccessKeysState<'User>, value: string) : DataAwsIamAccessKeysState<'User> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsIamAccessKeysState<'User>

        member _.Run(state: DataAwsIamAccessKeysState<Present>) : aws.DataAwsIamAccessKeys.DataAwsIamAccessKeys =
            let config = aws.DataAwsIamAccessKeys.DataAwsIamAccessKeysConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsIamAccessKeys.DataAwsIamAccessKeys(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsIamAccessKeys: missing required arguments. Must call: user.", 9999, IsError = true)>]
        member _.Run(_: DataAwsIamAccessKeysState<_>) : aws.DataAwsIamAccessKeys.DataAwsIamAccessKeys =
            Unchecked.defaultof<aws.DataAwsIamAccessKeys.DataAwsIamAccessKeys>
