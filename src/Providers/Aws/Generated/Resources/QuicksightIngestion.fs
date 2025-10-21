namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type QuicksightIngestionState<'DataSetId, 'IngestionId, 'IngestionType> = { assignments: ResizeArray<aws.QuicksightIngestion.QuicksightIngestionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_ingestion">aws_quicksight_ingestion</a>.
    /// </summary>
    type QuicksightIngestionBuilder(logicalId: string) =
        member _.Yield(_: unit) : QuicksightIngestionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightIngestionState<Missing, Missing, Missing>)

        member _.Zero(()) : QuicksightIngestionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightIngestionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_ingestion#data_set_id-1">QuicksightIngestion#data_set_id</a>.
        /// </summary>
        [<CustomOperation "data_set_id">]
        member _.DataSetId(state: QuicksightIngestionState<Missing, 'IngestionId, 'IngestionType>, value: string) : QuicksightIngestionState<Present, 'IngestionId, 'IngestionType> =
            state.assignments.Add(fun config -> config.DataSetId <- value)
            ({ assignments = state.assignments } : QuicksightIngestionState<Present, 'IngestionId, 'IngestionType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_ingestion#ingestion_id-1">QuicksightIngestion#ingestion_id</a>.
        /// </summary>
        [<CustomOperation "ingestion_id">]
        member _.IngestionId(state: QuicksightIngestionState<'DataSetId, Missing, 'IngestionType>, value: string) : QuicksightIngestionState<'DataSetId, Present, 'IngestionType> =
            state.assignments.Add(fun config -> config.IngestionId <- value)
            ({ assignments = state.assignments } : QuicksightIngestionState<'DataSetId, Present, 'IngestionType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_ingestion#ingestion_type-1">QuicksightIngestion#ingestion_type</a>.
        /// </summary>
        [<CustomOperation "ingestion_type">]
        member _.IngestionType(state: QuicksightIngestionState<'DataSetId, 'IngestionId, Missing>, value: string) : QuicksightIngestionState<'DataSetId, 'IngestionId, Present> =
            state.assignments.Add(fun config -> config.IngestionType <- value)
            ({ assignments = state.assignments } : QuicksightIngestionState<'DataSetId, 'IngestionId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_ingestion#aws_account_id-1">QuicksightIngestion#aws_account_id</a>.
        /// </summary>
        [<CustomOperation "aws_account_id">]
        member _.AwsAccountId(state: QuicksightIngestionState<'DataSetId, 'IngestionId, 'IngestionType>, value: string) : QuicksightIngestionState<'DataSetId, 'IngestionId, 'IngestionType> =
            state.assignments.Add(fun config -> config.AwsAccountId <- value)
            state : QuicksightIngestionState<'DataSetId, 'IngestionId, 'IngestionType>

        member _.Run(state: QuicksightIngestionState<Present, Present, Present>) : aws.QuicksightIngestion.QuicksightIngestion =
            let config = aws.QuicksightIngestion.QuicksightIngestionConfig()
            for setter in state.assignments do
                setter config
            aws.QuicksightIngestion.QuicksightIngestion(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.quicksightIngestion: missing required arguments. Must call: data_set_id, ingestion_id, ingestion_type.", 9999, IsError = true)>]
        member _.Run(_: QuicksightIngestionState<_, _, _>) : aws.QuicksightIngestion.QuicksightIngestion =
            Unchecked.defaultof<aws.QuicksightIngestion.QuicksightIngestion>
