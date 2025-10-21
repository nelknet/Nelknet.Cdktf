namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsApigatewayv2ExportState<'ApiId, 'OutputType, 'Specification> = { assignments: ResizeArray<aws.DataAwsApigatewayv2Export.DataAwsApigatewayv2ExportConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/apigatewayv2_export">aws_apigatewayv2_export</a>.
    /// </summary>
    type DataAwsApigatewayv2ExportBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsApigatewayv2ExportState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsApigatewayv2ExportState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAwsApigatewayv2ExportState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsApigatewayv2ExportState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/apigatewayv2_export#api_id-1">DataAwsApigatewayv2Export#api_id</a>.
        /// </summary>
        [<CustomOperation "api_id">]
        member _.ApiId(state: DataAwsApigatewayv2ExportState<Missing, 'OutputType, 'Specification>, value: string) : DataAwsApigatewayv2ExportState<Present, 'OutputType, 'Specification> =
            state.assignments.Add(fun config -> config.ApiId <- value)
            ({ assignments = state.assignments } : DataAwsApigatewayv2ExportState<Present, 'OutputType, 'Specification>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/apigatewayv2_export#output_type-1">DataAwsApigatewayv2Export#output_type</a>.
        /// </summary>
        [<CustomOperation "output_type">]
        member _.OutputType(state: DataAwsApigatewayv2ExportState<'ApiId, Missing, 'Specification>, value: string) : DataAwsApigatewayv2ExportState<'ApiId, Present, 'Specification> =
            state.assignments.Add(fun config -> config.OutputType <- value)
            ({ assignments = state.assignments } : DataAwsApigatewayv2ExportState<'ApiId, Present, 'Specification>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/apigatewayv2_export#specification-1">DataAwsApigatewayv2Export#specification</a>.
        /// </summary>
        [<CustomOperation "specification">]
        member _.Specification(state: DataAwsApigatewayv2ExportState<'ApiId, 'OutputType, Missing>, value: string) : DataAwsApigatewayv2ExportState<'ApiId, 'OutputType, Present> =
            state.assignments.Add(fun config -> config.Specification <- value)
            ({ assignments = state.assignments } : DataAwsApigatewayv2ExportState<'ApiId, 'OutputType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/apigatewayv2_export#export_version-1">DataAwsApigatewayv2Export#export_version</a>.
        /// </summary>
        [<CustomOperation "export_version">]
        member _.ExportVersion(state: DataAwsApigatewayv2ExportState<'ApiId, 'OutputType, 'Specification>, value: string) : DataAwsApigatewayv2ExportState<'ApiId, 'OutputType, 'Specification> =
            state.assignments.Add(fun config -> config.ExportVersion <- value)
            state : DataAwsApigatewayv2ExportState<'ApiId, 'OutputType, 'Specification>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/apigatewayv2_export#id-1">DataAwsApigatewayv2Export#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsApigatewayv2ExportState<'ApiId, 'OutputType, 'Specification>, value: string) : DataAwsApigatewayv2ExportState<'ApiId, 'OutputType, 'Specification> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsApigatewayv2ExportState<'ApiId, 'OutputType, 'Specification>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/apigatewayv2_export#include_extensions-1">DataAwsApigatewayv2Export#include_extensions</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_extensions">]
        member _.IncludeExtensions(state: DataAwsApigatewayv2ExportState<'ApiId, 'OutputType, 'Specification>, value: bool) : DataAwsApigatewayv2ExportState<'ApiId, 'OutputType, 'Specification> =
            state.assignments.Add(fun config -> config.IncludeExtensions <- value)
            state : DataAwsApigatewayv2ExportState<'ApiId, 'OutputType, 'Specification>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/apigatewayv2_export#include_extensions-1">DataAwsApigatewayv2Export#include_extensions</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_extensions">]
        member _.IncludeExtensions(state: DataAwsApigatewayv2ExportState<'ApiId, 'OutputType, 'Specification>, value: HashiCorp.Cdktf.IResolvable) : DataAwsApigatewayv2ExportState<'ApiId, 'OutputType, 'Specification> =
            state.assignments.Add(fun config -> config.IncludeExtensions <- value)
            state : DataAwsApigatewayv2ExportState<'ApiId, 'OutputType, 'Specification>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/apigatewayv2_export#stage_name-1">DataAwsApigatewayv2Export#stage_name</a>.
        /// </summary>
        [<CustomOperation "stage_name">]
        member _.StageName(state: DataAwsApigatewayv2ExportState<'ApiId, 'OutputType, 'Specification>, value: string) : DataAwsApigatewayv2ExportState<'ApiId, 'OutputType, 'Specification> =
            state.assignments.Add(fun config -> config.StageName <- value)
            state : DataAwsApigatewayv2ExportState<'ApiId, 'OutputType, 'Specification>

        member _.Run(state: DataAwsApigatewayv2ExportState<Present, Present, Present>) : aws.DataAwsApigatewayv2Export.DataAwsApigatewayv2Export =
            let config = aws.DataAwsApigatewayv2Export.DataAwsApigatewayv2ExportConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsApigatewayv2Export.DataAwsApigatewayv2Export(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsApigatewayv2Export: missing required arguments. Must call: api_id, output_type, specification.", 9999, IsError = true)>]
        member _.Run(_: DataAwsApigatewayv2ExportState<_, _, _>) : aws.DataAwsApigatewayv2Export.DataAwsApigatewayv2Export =
            Unchecked.defaultof<aws.DataAwsApigatewayv2Export.DataAwsApigatewayv2Export>
