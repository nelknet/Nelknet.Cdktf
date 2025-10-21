namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn> = { assignments: ResizeArray<aws.RedshiftIntegration.RedshiftIntegrationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_integration">aws_redshift_integration</a>.
    /// </summary>
    type RedshiftIntegrationBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftIntegrationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftIntegrationState<Missing, Missing, Missing>)

        member _.Zero(()) : RedshiftIntegrationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftIntegrationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_integration#integration_name-1">RedshiftIntegration#integration_name</a>.
        /// </summary>
        [<CustomOperation "integration_name">]
        member _.IntegrationName(state: RedshiftIntegrationState<Missing, 'SourceArn, 'TargetArn>, value: string) : RedshiftIntegrationState<Present, 'SourceArn, 'TargetArn> =
            state.assignments.Add(fun config -> config.IntegrationName <- value)
            ({ assignments = state.assignments } : RedshiftIntegrationState<Present, 'SourceArn, 'TargetArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_integration#source_arn-1">RedshiftIntegration#source_arn</a>.
        /// </summary>
        [<CustomOperation "source_arn">]
        member _.SourceArn(state: RedshiftIntegrationState<'IntegrationName, Missing, 'TargetArn>, value: string) : RedshiftIntegrationState<'IntegrationName, Present, 'TargetArn> =
            state.assignments.Add(fun config -> config.SourceArn <- value)
            ({ assignments = state.assignments } : RedshiftIntegrationState<'IntegrationName, Present, 'TargetArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_integration#target_arn-1">RedshiftIntegration#target_arn</a>.
        /// </summary>
        [<CustomOperation "target_arn">]
        member _.TargetArn(state: RedshiftIntegrationState<'IntegrationName, 'SourceArn, Missing>, value: string) : RedshiftIntegrationState<'IntegrationName, 'SourceArn, Present> =
            state.assignments.Add(fun config -> config.TargetArn <- value)
            ({ assignments = state.assignments } : RedshiftIntegrationState<'IntegrationName, 'SourceArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_integration#additional_encryption_context-1">RedshiftIntegration#additional_encryption_context</a>.
        /// </summary>
        [<CustomOperation "additional_encryption_context">]
        member _.AdditionalEncryptionContext(state: RedshiftIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn>, value: seq<string * string>) : RedshiftIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn> =
            state.assignments.Add(fun config -> config.AdditionalEncryptionContext <- dict value)
            state : RedshiftIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_integration#description-1">RedshiftIntegration#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: RedshiftIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn>, value: string) : RedshiftIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : RedshiftIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_integration#kms_key_id-1">RedshiftIntegration#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: RedshiftIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn>, value: string) : RedshiftIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : RedshiftIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_integration#tags-1">RedshiftIntegration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RedshiftIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn>, value: seq<string * string>) : RedshiftIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RedshiftIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_integration#timeouts-1">RedshiftIntegration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RedshiftIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn>, value: aws.RedshiftIntegration.RedshiftIntegrationTimeouts) : RedshiftIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RedshiftIntegrationState<'IntegrationName, 'SourceArn, 'TargetArn>

        member _.Run(state: RedshiftIntegrationState<Present, Present, Present>) : aws.RedshiftIntegration.RedshiftIntegration =
            let config = aws.RedshiftIntegration.RedshiftIntegrationConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftIntegration.RedshiftIntegration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftIntegration: missing required arguments. Must call: integration_name, source_arn, target_arn.", 9999, IsError = true)>]
        member _.Run(_: RedshiftIntegrationState<_, _, _>) : aws.RedshiftIntegration.RedshiftIntegration =
            Unchecked.defaultof<aws.RedshiftIntegration.RedshiftIntegration>
