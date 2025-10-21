namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamAccountAliasState<'AccountAlias> = { assignments: ResizeArray<aws.IamAccountAlias.IamAccountAliasConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_account_alias">aws_iam_account_alias</a>.
    /// </summary>
    type IamAccountAliasBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamAccountAliasState<Missing> =
            ({ assignments = ResizeArray() } : IamAccountAliasState<Missing>)

        member _.Zero(()) : IamAccountAliasState<Missing> =
            ({ assignments = ResizeArray() } : IamAccountAliasState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_account_alias#account_alias-1">IamAccountAlias#account_alias</a>.
        /// </summary>
        [<CustomOperation "account_alias">]
        member _.AccountAlias(state: IamAccountAliasState<Missing>, value: string) : IamAccountAliasState<Present> =
            state.assignments.Add(fun config -> config.AccountAlias <- value)
            ({ assignments = state.assignments } : IamAccountAliasState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_account_alias#id-1">IamAccountAlias#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IamAccountAliasState<'AccountAlias>, value: string) : IamAccountAliasState<'AccountAlias> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IamAccountAliasState<'AccountAlias>

        member _.Run(state: IamAccountAliasState<Present>) : aws.IamAccountAlias.IamAccountAlias =
            let config = aws.IamAccountAlias.IamAccountAliasConfig()
            for setter in state.assignments do
                setter config
            aws.IamAccountAlias.IamAccountAlias(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamAccountAlias: missing required arguments. Must call: account_alias.", 9999, IsError = true)>]
        member _.Run(_: IamAccountAliasState<_>) : aws.IamAccountAlias.IamAccountAlias =
            Unchecked.defaultof<aws.IamAccountAlias.IamAccountAlias>
