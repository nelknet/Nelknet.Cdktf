namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Inspector2DelegatedAdminAccountState<'AccountId> = { assignments: ResizeArray<aws.Inspector2DelegatedAdminAccount.Inspector2DelegatedAdminAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_delegated_admin_account">aws_inspector2_delegated_admin_account</a>.
    /// </summary>
    type Inspector2DelegatedAdminAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : Inspector2DelegatedAdminAccountState<Missing> =
            ({ assignments = ResizeArray() } : Inspector2DelegatedAdminAccountState<Missing>)

        member _.Zero(()) : Inspector2DelegatedAdminAccountState<Missing> =
            ({ assignments = ResizeArray() } : Inspector2DelegatedAdminAccountState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_delegated_admin_account#account_id-1">Inspector2DelegatedAdminAccount#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: Inspector2DelegatedAdminAccountState<Missing>, value: string) : Inspector2DelegatedAdminAccountState<Present> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            ({ assignments = state.assignments } : Inspector2DelegatedAdminAccountState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_delegated_admin_account#id-1">Inspector2DelegatedAdminAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Inspector2DelegatedAdminAccountState<'AccountId>, value: string) : Inspector2DelegatedAdminAccountState<'AccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Inspector2DelegatedAdminAccountState<'AccountId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_delegated_admin_account#timeouts-1">Inspector2DelegatedAdminAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Inspector2DelegatedAdminAccountState<'AccountId>, value: aws.Inspector2DelegatedAdminAccount.Inspector2DelegatedAdminAccountTimeouts) : Inspector2DelegatedAdminAccountState<'AccountId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Inspector2DelegatedAdminAccountState<'AccountId>

        member _.Run(state: Inspector2DelegatedAdminAccountState<Present>) : aws.Inspector2DelegatedAdminAccount.Inspector2DelegatedAdminAccount =
            let config = aws.Inspector2DelegatedAdminAccount.Inspector2DelegatedAdminAccountConfig()
            for setter in state.assignments do
                setter config
            aws.Inspector2DelegatedAdminAccount.Inspector2DelegatedAdminAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.inspector2DelegatedAdminAccount: missing required arguments. Must call: account_id.", 9999, IsError = true)>]
        member _.Run(_: Inspector2DelegatedAdminAccountState<_>) : aws.Inspector2DelegatedAdminAccount.Inspector2DelegatedAdminAccount =
            Unchecked.defaultof<aws.Inspector2DelegatedAdminAccount.Inspector2DelegatedAdminAccount>
