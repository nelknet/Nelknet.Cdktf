namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type QuicksightAnalysisState<'AnalysisId, 'Name> = { assignments: ResizeArray<aws.QuicksightAnalysis.QuicksightAnalysisConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis">aws_quicksight_analysis</a>.
    /// </summary>
    type QuicksightAnalysisBuilder(logicalId: string) =
        member _.Yield(_: unit) : QuicksightAnalysisState<Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightAnalysisState<Missing, Missing>)

        member _.Zero(()) : QuicksightAnalysisState<Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightAnalysisState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#analysis_id-1">QuicksightAnalysis#analysis_id</a>.
        /// </summary>
        [<CustomOperation "analysis_id">]
        member _.AnalysisId(state: QuicksightAnalysisState<Missing, 'Name>, value: string) : QuicksightAnalysisState<Present, 'Name> =
            state.assignments.Add(fun config -> config.AnalysisId <- value)
            ({ assignments = state.assignments } : QuicksightAnalysisState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#name-1">QuicksightAnalysis#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: QuicksightAnalysisState<'AnalysisId, Missing>, value: string) : QuicksightAnalysisState<'AnalysisId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : QuicksightAnalysisState<'AnalysisId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#aws_account_id-1">QuicksightAnalysis#aws_account_id</a>.
        /// </summary>
        [<CustomOperation "aws_account_id">]
        member _.AwsAccountId(state: QuicksightAnalysisState<'AnalysisId, 'Name>, value: string) : QuicksightAnalysisState<'AnalysisId, 'Name> =
            state.assignments.Add(fun config -> config.AwsAccountId <- value)
            state : QuicksightAnalysisState<'AnalysisId, 'Name>

        /// <summary>
        /// definition block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#definition-1">QuicksightAnalysis#definition</a>
        /// </summary>
        [<CustomOperation "definition">]
        member _.Definition(state: QuicksightAnalysisState<'AnalysisId, 'Name>, value: obj) : QuicksightAnalysisState<'AnalysisId, 'Name> =
            state.assignments.Add(fun config -> config.Definition <- value)
            state : QuicksightAnalysisState<'AnalysisId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#id-1">QuicksightAnalysis#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: QuicksightAnalysisState<'AnalysisId, 'Name>, value: string) : QuicksightAnalysisState<'AnalysisId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : QuicksightAnalysisState<'AnalysisId, 'Name>

        /// <summary>
        /// parameters block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#parameters-1">QuicksightAnalysis#parameters</a>
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: QuicksightAnalysisState<'AnalysisId, 'Name>, value: aws.QuicksightAnalysis.QuicksightAnalysisParameters) : QuicksightAnalysisState<'AnalysisId, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- value)
            state : QuicksightAnalysisState<'AnalysisId, 'Name>

        /// <summary>
        /// permissions block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#permissions-1">QuicksightAnalysis#permissions</a> Accepts: aws.IResolvable | aws.QuicksightAnalysis.QuicksightAnalysisPermissions[]
        /// </summary>
        [<CustomOperation "permissions">]
        member _.Permissions(state: QuicksightAnalysisState<'AnalysisId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : QuicksightAnalysisState<'AnalysisId, 'Name> =
            state.assignments.Add(fun config -> config.Permissions <- value)
            state : QuicksightAnalysisState<'AnalysisId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#recovery_window_in_days-1">QuicksightAnalysis#recovery_window_in_days</a>.
        /// </summary>
        [<CustomOperation "recovery_window_in_days">]
        member _.RecoveryWindowInDays(state: QuicksightAnalysisState<'AnalysisId, 'Name>, value: double) : QuicksightAnalysisState<'AnalysisId, 'Name> =
            state.assignments.Add(fun config -> config.RecoveryWindowInDays <- value)
            state : QuicksightAnalysisState<'AnalysisId, 'Name>

        /// <summary>
        /// source_entity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#source_entity-1">QuicksightAnalysis#source_entity</a>
        /// </summary>
        [<CustomOperation "source_entity">]
        member _.SourceEntity(state: QuicksightAnalysisState<'AnalysisId, 'Name>, value: aws.QuicksightAnalysis.QuicksightAnalysisSourceEntity) : QuicksightAnalysisState<'AnalysisId, 'Name> =
            state.assignments.Add(fun config -> config.SourceEntity <- value)
            state : QuicksightAnalysisState<'AnalysisId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#tags-1">QuicksightAnalysis#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: QuicksightAnalysisState<'AnalysisId, 'Name>, value: seq<string * string>) : QuicksightAnalysisState<'AnalysisId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : QuicksightAnalysisState<'AnalysisId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#tags_all-1">QuicksightAnalysis#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: QuicksightAnalysisState<'AnalysisId, 'Name>, value: seq<string * string>) : QuicksightAnalysisState<'AnalysisId, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : QuicksightAnalysisState<'AnalysisId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#theme_arn-1">QuicksightAnalysis#theme_arn</a>.
        /// </summary>
        [<CustomOperation "theme_arn">]
        member _.ThemeArn(state: QuicksightAnalysisState<'AnalysisId, 'Name>, value: string) : QuicksightAnalysisState<'AnalysisId, 'Name> =
            state.assignments.Add(fun config -> config.ThemeArn <- value)
            state : QuicksightAnalysisState<'AnalysisId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#timeouts-1">QuicksightAnalysis#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: QuicksightAnalysisState<'AnalysisId, 'Name>, value: aws.QuicksightAnalysis.QuicksightAnalysisTimeouts) : QuicksightAnalysisState<'AnalysisId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : QuicksightAnalysisState<'AnalysisId, 'Name>

        member _.Run(state: QuicksightAnalysisState<Present, Present>) : aws.QuicksightAnalysis.QuicksightAnalysis =
            let config = aws.QuicksightAnalysis.QuicksightAnalysisConfig()
            for setter in state.assignments do
                setter config
            aws.QuicksightAnalysis.QuicksightAnalysis(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.quicksightAnalysis: missing required arguments. Must call: analysis_id, name.", 9999, IsError = true)>]
        member _.Run(_: QuicksightAnalysisState<_, _>) : aws.QuicksightAnalysis.QuicksightAnalysis =
            Unchecked.defaultof<aws.QuicksightAnalysis.QuicksightAnalysis>
