namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit> = { assignments: ResizeArray<aws.CurReportDefinition.CurReportDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cur_report_definition">aws_cur_report_definition</a>.
    /// </summary>
    type CurReportDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : CurReportDefinitionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CurReportDefinitionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CurReportDefinitionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CurReportDefinitionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cur_report_definition#additional_schema_elements-1">CurReportDefinition#additional_schema_elements</a>.
        /// </summary>
        [<CustomOperation "additional_schema_elements">]
        member _.AdditionalSchemaElements(state: CurReportDefinitionState<Missing, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit>, value: seq<string>) : CurReportDefinitionState<Present, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit> =
            state.assignments.Add(fun config -> config.AdditionalSchemaElements <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : CurReportDefinitionState<Present, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cur_report_definition#compression-1">CurReportDefinition#compression</a>.
        /// </summary>
        [<CustomOperation "compression">]
        member _.Compression(state: CurReportDefinitionState<'AdditionalSchemaElements, Missing, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit>, value: string) : CurReportDefinitionState<'AdditionalSchemaElements, Present, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit> =
            state.assignments.Add(fun config -> config.Compression <- value)
            ({ assignments = state.assignments } : CurReportDefinitionState<'AdditionalSchemaElements, Present, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cur_report_definition#format-1">CurReportDefinition#format</a>.
        /// </summary>
        [<CustomOperation "format">]
        member _.Format(state: CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, Missing, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit>, value: string) : CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, Present, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit> =
            state.assignments.Add(fun config -> config.Format <- value)
            ({ assignments = state.assignments } : CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, Present, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cur_report_definition#report_name-1">CurReportDefinition#report_name</a>.
        /// </summary>
        [<CustomOperation "report_name">]
        member _.ReportName(state: CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, Missing, 'S3Bucket, 'S3Region, 'TimeUnit>, value: string) : CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, Present, 'S3Bucket, 'S3Region, 'TimeUnit> =
            state.assignments.Add(fun config -> config.ReportName <- value)
            ({ assignments = state.assignments } : CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, Present, 'S3Bucket, 'S3Region, 'TimeUnit>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cur_report_definition#s3_bucket-1">CurReportDefinition#s3_bucket</a>.
        /// </summary>
        [<CustomOperation "s3_bucket">]
        member _.S3Bucket(state: CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, Missing, 'S3Region, 'TimeUnit>, value: string) : CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, Present, 'S3Region, 'TimeUnit> =
            state.assignments.Add(fun config -> config.S3Bucket <- value)
            ({ assignments = state.assignments } : CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, Present, 'S3Region, 'TimeUnit>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cur_report_definition#s3_region-1">CurReportDefinition#s3_region</a>.
        /// </summary>
        [<CustomOperation "s3_region">]
        member _.S3Region(state: CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, Missing, 'TimeUnit>, value: string) : CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, Present, 'TimeUnit> =
            state.assignments.Add(fun config -> config.S3Region <- value)
            ({ assignments = state.assignments } : CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, Present, 'TimeUnit>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cur_report_definition#time_unit-1">CurReportDefinition#time_unit</a>.
        /// </summary>
        [<CustomOperation "time_unit">]
        member _.TimeUnit(state: CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, Missing>, value: string) : CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, Present> =
            state.assignments.Add(fun config -> config.TimeUnit <- value)
            ({ assignments = state.assignments } : CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cur_report_definition#additional_artifacts-1">CurReportDefinition#additional_artifacts</a>.
        /// </summary>
        [<CustomOperation "additional_artifacts">]
        member _.AdditionalArtifacts(state: CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit>, value: seq<string>) : CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit> =
            state.assignments.Add(fun config -> config.AdditionalArtifacts <- (value |> Seq.toArray))
            state : CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cur_report_definition#id-1">CurReportDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit>, value: string) : CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cur_report_definition#refresh_closed_reports-1">CurReportDefinition#refresh_closed_reports</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "refresh_closed_reports">]
        member _.RefreshClosedReports(state: CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit>, value: bool) : CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit> =
            state.assignments.Add(fun config -> config.RefreshClosedReports <- value)
            state : CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cur_report_definition#refresh_closed_reports-1">CurReportDefinition#refresh_closed_reports</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "refresh_closed_reports">]
        member _.RefreshClosedReports(state: CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit>, value: HashiCorp.Cdktf.IResolvable) : CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit> =
            state.assignments.Add(fun config -> config.RefreshClosedReports <- value)
            state : CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cur_report_definition#report_versioning-1">CurReportDefinition#report_versioning</a>.
        /// </summary>
        [<CustomOperation "report_versioning">]
        member _.ReportVersioning(state: CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit>, value: string) : CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit> =
            state.assignments.Add(fun config -> config.ReportVersioning <- value)
            state : CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cur_report_definition#s3_prefix-1">CurReportDefinition#s3_prefix</a>.
        /// </summary>
        [<CustomOperation "s3_prefix">]
        member _.S3Prefix(state: CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit>, value: string) : CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit> =
            state.assignments.Add(fun config -> config.S3Prefix <- value)
            state : CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cur_report_definition#tags-1">CurReportDefinition#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit>, value: seq<string * string>) : CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cur_report_definition#tags_all-1">CurReportDefinition#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit>, value: seq<string * string>) : CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CurReportDefinitionState<'AdditionalSchemaElements, 'Compression, 'Format, 'ReportName, 'S3Bucket, 'S3Region, 'TimeUnit>

        member _.Run(state: CurReportDefinitionState<Present, Present, Present, Present, Present, Present, Present>) : aws.CurReportDefinition.CurReportDefinition =
            let config = aws.CurReportDefinition.CurReportDefinitionConfig()
            for setter in state.assignments do
                setter config
            aws.CurReportDefinition.CurReportDefinition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.curReportDefinition: missing required arguments. Must call: additional_schema_elements, compression, format, report_name, s3_bucket, s3_region, time_unit.", 9999, IsError = true)>]
        member _.Run(_: CurReportDefinitionState<_, _, _, _, _, _, _>) : aws.CurReportDefinition.CurReportDefinition =
            Unchecked.defaultof<aws.CurReportDefinition.CurReportDefinition>
