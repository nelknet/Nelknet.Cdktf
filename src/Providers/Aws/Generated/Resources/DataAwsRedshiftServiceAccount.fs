namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRedshiftServiceAccountState = { assignments: ResizeArray<aws.DataAwsRedshiftServiceAccount.DataAwsRedshiftServiceAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_service_account">aws_redshift_service_account</a>.
    /// </summary>
    type DataAwsRedshiftServiceAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRedshiftServiceAccountState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsRedshiftServiceAccountState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_service_account#id-1">DataAwsRedshiftServiceAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRedshiftServiceAccountState, value: string) : DataAwsRedshiftServiceAccountState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRedshiftServiceAccountState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_service_account#region-1">DataAwsRedshiftServiceAccount#region</a>.
        /// </summary>
        [<CustomOperation "region">]
        member _.Region(state: DataAwsRedshiftServiceAccountState, value: string) : DataAwsRedshiftServiceAccountState =
            state.assignments.Add(fun config -> config.Region <- value)
            state : DataAwsRedshiftServiceAccountState

        member _.Run(state: DataAwsRedshiftServiceAccountState) : aws.DataAwsRedshiftServiceAccount.DataAwsRedshiftServiceAccount =
            let config = aws.DataAwsRedshiftServiceAccount.DataAwsRedshiftServiceAccountConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRedshiftServiceAccount.DataAwsRedshiftServiceAccount(StackContext.get (), logicalId, config)
