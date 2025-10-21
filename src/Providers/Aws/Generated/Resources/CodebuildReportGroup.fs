namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodebuildReportGroupState<'ExportConfig, 'Name, 'Type> = { assignments: ResizeArray<aws.CodebuildReportGroup.CodebuildReportGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_report_group">aws_codebuild_report_group</a>.
    /// </summary>
    type CodebuildReportGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodebuildReportGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CodebuildReportGroupState<Missing, Missing, Missing>)

        member _.Zero(()) : CodebuildReportGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CodebuildReportGroupState<Missing, Missing, Missing>)

        /// <summary>
        /// export_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_report_group#export_config-1">CodebuildReportGroup#export_config</a>
        /// </summary>
        [<CustomOperation "export_config">]
        member _.ExportConfig(state: CodebuildReportGroupState<Missing, 'Name, 'Type>, value: aws.CodebuildReportGroup.CodebuildReportGroupExportConfig) : CodebuildReportGroupState<Present, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.ExportConfig <- value)
            ({ assignments = state.assignments } : CodebuildReportGroupState<Present, 'Name, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_report_group#name-1">CodebuildReportGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CodebuildReportGroupState<'ExportConfig, Missing, 'Type>, value: string) : CodebuildReportGroupState<'ExportConfig, Present, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CodebuildReportGroupState<'ExportConfig, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_report_group#type-1">CodebuildReportGroup#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: CodebuildReportGroupState<'ExportConfig, 'Name, Missing>, value: string) : CodebuildReportGroupState<'ExportConfig, 'Name, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : CodebuildReportGroupState<'ExportConfig, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_report_group#delete_reports-1">CodebuildReportGroup#delete_reports</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "delete_reports">]
        member _.DeleteReports(state: CodebuildReportGroupState<'ExportConfig, 'Name, 'Type>, value: bool) : CodebuildReportGroupState<'ExportConfig, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.DeleteReports <- value)
            state : CodebuildReportGroupState<'ExportConfig, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_report_group#delete_reports-1">CodebuildReportGroup#delete_reports</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "delete_reports">]
        member _.DeleteReports(state: CodebuildReportGroupState<'ExportConfig, 'Name, 'Type>, value: HashiCorp.Cdktf.IResolvable) : CodebuildReportGroupState<'ExportConfig, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.DeleteReports <- value)
            state : CodebuildReportGroupState<'ExportConfig, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_report_group#id-1">CodebuildReportGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CodebuildReportGroupState<'ExportConfig, 'Name, 'Type>, value: string) : CodebuildReportGroupState<'ExportConfig, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CodebuildReportGroupState<'ExportConfig, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_report_group#tags-1">CodebuildReportGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CodebuildReportGroupState<'ExportConfig, 'Name, 'Type>, value: seq<string * string>) : CodebuildReportGroupState<'ExportConfig, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CodebuildReportGroupState<'ExportConfig, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_report_group#tags_all-1">CodebuildReportGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CodebuildReportGroupState<'ExportConfig, 'Name, 'Type>, value: seq<string * string>) : CodebuildReportGroupState<'ExportConfig, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CodebuildReportGroupState<'ExportConfig, 'Name, 'Type>

        member _.Run(state: CodebuildReportGroupState<Present, Present, Present>) : aws.CodebuildReportGroup.CodebuildReportGroup =
            let config = aws.CodebuildReportGroup.CodebuildReportGroupConfig()
            for setter in state.assignments do
                setter config
            aws.CodebuildReportGroup.CodebuildReportGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codebuildReportGroup: missing required arguments. Must call: export_config, name, type.", 9999, IsError = true)>]
        member _.Run(_: CodebuildReportGroupState<_, _, _>) : aws.CodebuildReportGroup.CodebuildReportGroup =
            Unchecked.defaultof<aws.CodebuildReportGroup.CodebuildReportGroup>
