namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRedshiftProducerDataSharesState<'ProducerArn> = { assignments: ResizeArray<aws.DataAwsRedshiftProducerDataShares.DataAwsRedshiftProducerDataSharesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_producer_data_shares">aws_redshift_producer_data_shares</a>.
    /// </summary>
    type DataAwsRedshiftProducerDataSharesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRedshiftProducerDataSharesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRedshiftProducerDataSharesState<Missing>)

        member _.Zero(()) : DataAwsRedshiftProducerDataSharesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRedshiftProducerDataSharesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_producer_data_shares#producer_arn-1">DataAwsRedshiftProducerDataShares#producer_arn</a>.
        /// </summary>
        [<CustomOperation "producer_arn">]
        member _.ProducerArn(state: DataAwsRedshiftProducerDataSharesState<Missing>, value: string) : DataAwsRedshiftProducerDataSharesState<Present> =
            state.assignments.Add(fun config -> config.ProducerArn <- value)
            ({ assignments = state.assignments } : DataAwsRedshiftProducerDataSharesState<Present>)

        /// <summary>
        /// data_shares block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_producer_data_shares#data_shares-1">DataAwsRedshiftProducerDataShares#data_shares</a> Accepts: aws.IResolvable | aws.DataAwsRedshiftProducerDataShares.DataAwsRedshiftProducerDataSharesDataShares[]
        /// </summary>
        [<CustomOperation "data_shares">]
        member _.DataShares(state: DataAwsRedshiftProducerDataSharesState<'ProducerArn>, value: HashiCorp.Cdktf.IResolvable) : DataAwsRedshiftProducerDataSharesState<'ProducerArn> =
            state.assignments.Add(fun config -> config.DataShares <- value)
            state : DataAwsRedshiftProducerDataSharesState<'ProducerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_producer_data_shares#status-1">DataAwsRedshiftProducerDataShares#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: DataAwsRedshiftProducerDataSharesState<'ProducerArn>, value: string) : DataAwsRedshiftProducerDataSharesState<'ProducerArn> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : DataAwsRedshiftProducerDataSharesState<'ProducerArn>

        member _.Run(state: DataAwsRedshiftProducerDataSharesState<Present>) : aws.DataAwsRedshiftProducerDataShares.DataAwsRedshiftProducerDataShares =
            let config = aws.DataAwsRedshiftProducerDataShares.DataAwsRedshiftProducerDataSharesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRedshiftProducerDataShares.DataAwsRedshiftProducerDataShares(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsRedshiftProducerDataShares: missing required arguments. Must call: producer_arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsRedshiftProducerDataSharesState<_>) : aws.DataAwsRedshiftProducerDataShares.DataAwsRedshiftProducerDataShares =
            Unchecked.defaultof<aws.DataAwsRedshiftProducerDataShares.DataAwsRedshiftProducerDataShares>
