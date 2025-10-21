namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCurReportDefinitionState<'ReportName> = { assignments: ResizeArray<aws.DataAwsCurReportDefinition.DataAwsCurReportDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cur_report_definition">aws_cur_report_definition</a>.
    /// </summary>
    type DataAwsCurReportDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCurReportDefinitionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCurReportDefinitionState<Missing>)

        member _.Zero(()) : DataAwsCurReportDefinitionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCurReportDefinitionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cur_report_definition#report_name-1">DataAwsCurReportDefinition#report_name</a>.
        /// </summary>
        [<CustomOperation "report_name">]
        member _.ReportName(state: DataAwsCurReportDefinitionState<Missing>, value: string) : DataAwsCurReportDefinitionState<Present> =
            state.assignments.Add(fun config -> config.ReportName <- value)
            ({ assignments = state.assignments } : DataAwsCurReportDefinitionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cur_report_definition#id-1">DataAwsCurReportDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCurReportDefinitionState<'ReportName>, value: string) : DataAwsCurReportDefinitionState<'ReportName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCurReportDefinitionState<'ReportName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cur_report_definition#tags-1">DataAwsCurReportDefinition#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsCurReportDefinitionState<'ReportName>, value: seq<string * string>) : DataAwsCurReportDefinitionState<'ReportName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsCurReportDefinitionState<'ReportName>

        member _.Run(state: DataAwsCurReportDefinitionState<Present>) : aws.DataAwsCurReportDefinition.DataAwsCurReportDefinition =
            let config = aws.DataAwsCurReportDefinition.DataAwsCurReportDefinitionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCurReportDefinition.DataAwsCurReportDefinition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCurReportDefinition: missing required arguments. Must call: report_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCurReportDefinitionState<_>) : aws.DataAwsCurReportDefinition.DataAwsCurReportDefinition =
            Unchecked.defaultof<aws.DataAwsCurReportDefinition.DataAwsCurReportDefinition>
