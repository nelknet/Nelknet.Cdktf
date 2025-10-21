namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RdsIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn> = { assignments: ResizeArray<aws.RdsIntegration.RdsIntegrationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_integration">aws_rds_integration</a>.
    /// </summary>
    type RdsIntegrationBuilder(logicalId: string) =
        member _.Yield(_: unit) : RdsIntegrationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RdsIntegrationState<Missing, Missing, Missing>)

        member _.Zero(()) : RdsIntegrationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RdsIntegrationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_integration#integration_name-1">RdsIntegration#integration_name</a>.
        /// </summary>
        [<CustomOperation "integration_name">]
        member _.IntegrationName(state: RdsIntegrationState<Missing, 'SourceArn, 'TargetArn>, value: string) : RdsIntegrationState<Present, 'SourceArn, 'TargetArn> =
            state.assignments.Add(fun config -> config.IntegrationName <- value)
            ({ assignments = state.assignments } : RdsIntegrationState<Present, 'SourceArn, 'TargetArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_integration#source_arn-1">RdsIntegration#source_arn</a>.
        /// </summary>
        [<CustomOperation "source_arn">]
        member _.SourceArn(state: RdsIntegrationState<'IntegrationName, Missing, 'TargetArn>, value: string) : RdsIntegrationState<'IntegrationName, Present, 'TargetArn> =
            state.assignments.Add(fun config -> config.SourceArn <- value)
            ({ assignments = state.assignments } : RdsIntegrationState<'IntegrationName, Present, 'TargetArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_integration#target_arn-1">RdsIntegration#target_arn</a>.
        /// </summary>
        [<CustomOperation "target_arn">]
        member _.TargetArn(state: RdsIntegrationState<'IntegrationName, 'SourceArn, Missing>, value: string) : RdsIntegrationState<'IntegrationName, 'SourceArn, Present> =
            state.assignments.Add(fun config -> config.TargetArn <- value)
            ({ assignments = state.assignments } : RdsIntegrationState<'IntegrationName, 'SourceArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_integration#additional_encryption_context-1">RdsIntegration#additional_encryption_context</a>.
        /// </summary>
        [<CustomOperation "additional_encryption_context">]
        member _.AdditionalEncryptionContext(state: RdsIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn>, value: seq<string * string>) : RdsIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn> =
            state.assignments.Add(fun config -> config.AdditionalEncryptionContext <- dict value)
            state : RdsIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_integration#data_filter-1">RdsIntegration#data_filter</a>.
        /// </summary>
        [<CustomOperation "data_filter">]
        member _.DataFilter(state: RdsIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn>, value: string) : RdsIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn> =
            state.assignments.Add(fun config -> config.DataFilter <- value)
            state : RdsIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_integration#kms_key_id-1">RdsIntegration#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: RdsIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn>, value: string) : RdsIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : RdsIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_integration#tags-1">RdsIntegration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RdsIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn>, value: seq<string * string>) : RdsIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RdsIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_integration#timeouts-1">RdsIntegration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RdsIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn>, value: aws.RdsIntegration.RdsIntegrationTimeouts) : RdsIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RdsIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn>

        member _.Run(state: RdsIntegrationState<Present, Present, Present>) : aws.RdsIntegration.RdsIntegration =
            let config = aws.RdsIntegration.RdsIntegrationConfig()
            for setter in state.assignments do
                setter config
            aws.RdsIntegration.RdsIntegration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.rdsIntegration: missing required arguments. Must call: integration_name, source_arn, target_arn.", 9999, IsError = true)>]
        member _.Run(_: RdsIntegrationState<_, _, _>) : aws.RdsIntegration.RdsIntegration =
            Unchecked.defaultof<aws.RdsIntegration.RdsIntegration>
