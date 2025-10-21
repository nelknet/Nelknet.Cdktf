namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRedshiftDataSharesState = { assignments: ResizeArray<aws.DataAwsRedshiftDataShares.DataAwsRedshiftDataSharesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_data_shares">aws_redshift_data_shares</a>.
    /// </summary>
    type DataAwsRedshiftDataSharesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRedshiftDataSharesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsRedshiftDataSharesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// data_shares block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_data_shares#data_shares-1">DataAwsRedshiftDataShares#data_shares</a> Accepts: aws.IResolvable | aws.DataAwsRedshiftDataShares.DataAwsRedshiftDataSharesDataShares[]
        /// </summary>
        [<CustomOperation "data_shares">]
        member _.DataShares(state: DataAwsRedshiftDataSharesState, value: HashiCorp.Cdktf.IResolvable) : DataAwsRedshiftDataSharesState =
            state.assignments.Add(fun config -> config.DataShares <- value)
            state : DataAwsRedshiftDataSharesState

        member _.Run(state: DataAwsRedshiftDataSharesState) : aws.DataAwsRedshiftDataShares.DataAwsRedshiftDataShares =
            let config = aws.DataAwsRedshiftDataShares.DataAwsRedshiftDataSharesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRedshiftDataShares.DataAwsRedshiftDataShares(StackContext.get (), logicalId, config)
