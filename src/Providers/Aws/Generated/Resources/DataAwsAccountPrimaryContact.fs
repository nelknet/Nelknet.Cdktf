namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsAccountPrimaryContactState = { assignments: ResizeArray<aws.DataAwsAccountPrimaryContact.DataAwsAccountPrimaryContactConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/account_primary_contact">aws_account_primary_contact</a>.
    /// </summary>
    type DataAwsAccountPrimaryContactBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsAccountPrimaryContactState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsAccountPrimaryContactState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/account_primary_contact#account_id-1">DataAwsAccountPrimaryContact#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: DataAwsAccountPrimaryContactState, value: string) : DataAwsAccountPrimaryContactState =
            state.assignments.Add(fun config -> config.AccountId <- value)
            state : DataAwsAccountPrimaryContactState

        member _.Run(state: DataAwsAccountPrimaryContactState) : aws.DataAwsAccountPrimaryContact.DataAwsAccountPrimaryContact =
            let config = aws.DataAwsAccountPrimaryContact.DataAwsAccountPrimaryContactConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsAccountPrimaryContact.DataAwsAccountPrimaryContact(StackContext.get (), logicalId, config)
