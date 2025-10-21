namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FmsAdminAccountState = { assignments: ResizeArray<aws.FmsAdminAccount.FmsAdminAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_admin_account">aws_fms_admin_account</a>.
    /// </summary>
    type FmsAdminAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : FmsAdminAccountState =
            { assignments = ResizeArray() }

        member _.Zero(()) : FmsAdminAccountState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_admin_account#account_id-1">FmsAdminAccount#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: FmsAdminAccountState, value: string) : FmsAdminAccountState =
            state.assignments.Add(fun config -> config.AccountId <- value)
            state : FmsAdminAccountState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_admin_account#id-1">FmsAdminAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FmsAdminAccountState, value: string) : FmsAdminAccountState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FmsAdminAccountState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_admin_account#timeouts-1">FmsAdminAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FmsAdminAccountState, value: aws.FmsAdminAccount.FmsAdminAccountTimeouts) : FmsAdminAccountState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FmsAdminAccountState

        member _.Run(state: FmsAdminAccountState) : aws.FmsAdminAccount.FmsAdminAccount =
            let config = aws.FmsAdminAccount.FmsAdminAccountConfig()
            for setter in state.assignments do
                setter config
            aws.FmsAdminAccount.FmsAdminAccount(StackContext.get (), logicalId, config)
