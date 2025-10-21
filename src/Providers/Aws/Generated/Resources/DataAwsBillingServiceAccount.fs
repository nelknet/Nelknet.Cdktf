namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsBillingServiceAccountState = { assignments: ResizeArray<aws.DataAwsBillingServiceAccount.DataAwsBillingServiceAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/billing_service_account">aws_billing_service_account</a>.
    /// </summary>
    type DataAwsBillingServiceAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsBillingServiceAccountState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsBillingServiceAccountState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/billing_service_account#id-1">DataAwsBillingServiceAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsBillingServiceAccountState, value: string) : DataAwsBillingServiceAccountState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsBillingServiceAccountState

        member _.Run(state: DataAwsBillingServiceAccountState) : aws.DataAwsBillingServiceAccount.DataAwsBillingServiceAccount =
            let config = aws.DataAwsBillingServiceAccount.DataAwsBillingServiceAccountConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsBillingServiceAccount.DataAwsBillingServiceAccount(StackContext.get (), logicalId, config)
