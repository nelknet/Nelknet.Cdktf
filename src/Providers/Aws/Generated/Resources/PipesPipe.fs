namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PipesPipeState<'RoleArn, 'Source, 'Target> = { assignments: ResizeArray<aws.PipesPipe.PipesPipeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe">aws_pipes_pipe</a>.
    /// </summary>
    type PipesPipeBuilder(logicalId: string) =
        member _.Yield(_: unit) : PipesPipeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PipesPipeState<Missing, Missing, Missing>)

        member _.Zero(()) : PipesPipeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PipesPipeState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#role_arn-1">PipesPipe#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: PipesPipeState<Missing, 'Source, 'Target>, value: string) : PipesPipeState<Present, 'Source, 'Target> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : PipesPipeState<Present, 'Source, 'Target>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#source-1">PipesPipe#source</a>.
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: PipesPipeState<'RoleArn, Missing, 'Target>, value: string) : PipesPipeState<'RoleArn, Present, 'Target> =
            state.assignments.Add(fun config -> config.Source <- value)
            ({ assignments = state.assignments } : PipesPipeState<'RoleArn, Present, 'Target>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#target-1">PipesPipe#target</a>.
        /// </summary>
        [<CustomOperation "target">]
        member _.Target(state: PipesPipeState<'RoleArn, 'Source, Missing>, value: string) : PipesPipeState<'RoleArn, 'Source, Present> =
            state.assignments.Add(fun config -> config.Target <- value)
            ({ assignments = state.assignments } : PipesPipeState<'RoleArn, 'Source, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#description-1">PipesPipe#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: PipesPipeState<'RoleArn, 'Source, 'Target>, value: string) : PipesPipeState<'RoleArn, 'Source, 'Target> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : PipesPipeState<'RoleArn, 'Source, 'Target>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#desired_state-1">PipesPipe#desired_state</a>.
        /// </summary>
        [<CustomOperation "desired_state">]
        member _.DesiredState(state: PipesPipeState<'RoleArn, 'Source, 'Target>, value: string) : PipesPipeState<'RoleArn, 'Source, 'Target> =
            state.assignments.Add(fun config -> config.DesiredState <- value)
            state : PipesPipeState<'RoleArn, 'Source, 'Target>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#enrichment-1">PipesPipe#enrichment</a>.
        /// </summary>
        [<CustomOperation "enrichment">]
        member _.Enrichment(state: PipesPipeState<'RoleArn, 'Source, 'Target>, value: string) : PipesPipeState<'RoleArn, 'Source, 'Target> =
            state.assignments.Add(fun config -> config.Enrichment <- value)
            state : PipesPipeState<'RoleArn, 'Source, 'Target>

        /// <summary>
        /// enrichment_parameters block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#enrichment_parameters-1">PipesPipe#enrichment_parameters</a>
        /// </summary>
        [<CustomOperation "enrichment_parameters">]
        member _.EnrichmentParameters(state: PipesPipeState<'RoleArn, 'Source, 'Target>, value: aws.PipesPipe.PipesPipeEnrichmentParameters) : PipesPipeState<'RoleArn, 'Source, 'Target> =
            state.assignments.Add(fun config -> config.EnrichmentParameters <- value)
            state : PipesPipeState<'RoleArn, 'Source, 'Target>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#id-1">PipesPipe#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PipesPipeState<'RoleArn, 'Source, 'Target>, value: string) : PipesPipeState<'RoleArn, 'Source, 'Target> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PipesPipeState<'RoleArn, 'Source, 'Target>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#kms_key_identifier-1">PipesPipe#kms_key_identifier</a>.
        /// </summary>
        [<CustomOperation "kms_key_identifier">]
        member _.KmsKeyIdentifier(state: PipesPipeState<'RoleArn, 'Source, 'Target>, value: string) : PipesPipeState<'RoleArn, 'Source, 'Target> =
            state.assignments.Add(fun config -> config.KmsKeyIdentifier <- value)
            state : PipesPipeState<'RoleArn, 'Source, 'Target>

        /// <summary>
        /// log_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#log_configuration-1">PipesPipe#log_configuration</a>
        /// </summary>
        [<CustomOperation "log_configuration">]
        member _.LogConfiguration(state: PipesPipeState<'RoleArn, 'Source, 'Target>, value: aws.PipesPipe.PipesPipeLogConfiguration) : PipesPipeState<'RoleArn, 'Source, 'Target> =
            state.assignments.Add(fun config -> config.LogConfiguration <- value)
            state : PipesPipeState<'RoleArn, 'Source, 'Target>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#name-1">PipesPipe#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PipesPipeState<'RoleArn, 'Source, 'Target>, value: string) : PipesPipeState<'RoleArn, 'Source, 'Target> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : PipesPipeState<'RoleArn, 'Source, 'Target>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#name_prefix-1">PipesPipe#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: PipesPipeState<'RoleArn, 'Source, 'Target>, value: string) : PipesPipeState<'RoleArn, 'Source, 'Target> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : PipesPipeState<'RoleArn, 'Source, 'Target>

        /// <summary>
        /// source_parameters block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#source_parameters-1">PipesPipe#source_parameters</a>
        /// </summary>
        [<CustomOperation "source_parameters">]
        member _.SourceParameters(state: PipesPipeState<'RoleArn, 'Source, 'Target>, value: aws.PipesPipe.PipesPipeSourceParameters) : PipesPipeState<'RoleArn, 'Source, 'Target> =
            state.assignments.Add(fun config -> config.SourceParameters <- value)
            state : PipesPipeState<'RoleArn, 'Source, 'Target>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#tags-1">PipesPipe#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PipesPipeState<'RoleArn, 'Source, 'Target>, value: seq<string * string>) : PipesPipeState<'RoleArn, 'Source, 'Target> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PipesPipeState<'RoleArn, 'Source, 'Target>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#tags_all-1">PipesPipe#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: PipesPipeState<'RoleArn, 'Source, 'Target>, value: seq<string * string>) : PipesPipeState<'RoleArn, 'Source, 'Target> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : PipesPipeState<'RoleArn, 'Source, 'Target>

        /// <summary>
        /// target_parameters block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#target_parameters-1">PipesPipe#target_parameters</a>
        /// </summary>
        [<CustomOperation "target_parameters">]
        member _.TargetParameters(state: PipesPipeState<'RoleArn, 'Source, 'Target>, value: aws.PipesPipe.PipesPipeTargetParameters) : PipesPipeState<'RoleArn, 'Source, 'Target> =
            state.assignments.Add(fun config -> config.TargetParameters <- value)
            state : PipesPipeState<'RoleArn, 'Source, 'Target>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#timeouts-1">PipesPipe#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PipesPipeState<'RoleArn, 'Source, 'Target>, value: aws.PipesPipe.PipesPipeTimeouts) : PipesPipeState<'RoleArn, 'Source, 'Target> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PipesPipeState<'RoleArn, 'Source, 'Target>

        member _.Run(state: PipesPipeState<Present, Present, Present>) : aws.PipesPipe.PipesPipe =
            let config = aws.PipesPipe.PipesPipeConfig()
            for setter in state.assignments do
                setter config
            aws.PipesPipe.PipesPipe(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.pipesPipe: missing required arguments. Must call: role_arn, source, target.", 9999, IsError = true)>]
        member _.Run(_: PipesPipeState<_, _, _>) : aws.PipesPipe.PipesPipe =
            Unchecked.defaultof<aws.PipesPipe.PipesPipe>
