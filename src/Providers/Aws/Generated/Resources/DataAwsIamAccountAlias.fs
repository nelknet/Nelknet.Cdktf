namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsIamAccountAliasState = { assignments: ResizeArray<aws.DataAwsIamAccountAlias.DataAwsIamAccountAliasConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_account_alias">aws_iam_account_alias</a>.
    /// </summary>
    type DataAwsIamAccountAliasBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsIamAccountAliasState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsIamAccountAliasState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_account_alias#id-1">DataAwsIamAccountAlias#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsIamAccountAliasState, value: string) : DataAwsIamAccountAliasState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsIamAccountAliasState

        member _.Run(state: DataAwsIamAccountAliasState) : aws.DataAwsIamAccountAlias.DataAwsIamAccountAlias =
            let config = aws.DataAwsIamAccountAlias.DataAwsIamAccountAliasConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsIamAccountAlias.DataAwsIamAccountAlias(StackContext.get (), logicalId, config)
