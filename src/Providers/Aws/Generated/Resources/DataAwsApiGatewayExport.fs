namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsApiGatewayExportState<'ExportType, 'RestApiId, 'StageName> = { assignments: ResizeArray<aws.DataAwsApiGatewayExport.DataAwsApiGatewayExportConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_export">aws_api_gateway_export</a>.
    /// </summary>
    type DataAwsApiGatewayExportBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsApiGatewayExportState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsApiGatewayExportState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAwsApiGatewayExportState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsApiGatewayExportState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_export#export_type-1">DataAwsApiGatewayExport#export_type</a>.
        /// </summary>
        [<CustomOperation "export_type">]
        member _.ExportType(state: DataAwsApiGatewayExportState<Missing, 'RestApiId, 'StageName>, value: string) : DataAwsApiGatewayExportState<Present, 'RestApiId, 'StageName> =
            state.assignments.Add(fun config -> config.ExportType <- value)
            ({ assignments = state.assignments } : DataAwsApiGatewayExportState<Present, 'RestApiId, 'StageName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_export#rest_api_id-1">DataAwsApiGatewayExport#rest_api_id</a>.
        /// </summary>
        [<CustomOperation "rest_api_id">]
        member _.RestApiId(state: DataAwsApiGatewayExportState<'ExportType, Missing, 'StageName>, value: string) : DataAwsApiGatewayExportState<'ExportType, Present, 'StageName> =
            state.assignments.Add(fun config -> config.RestApiId <- value)
            ({ assignments = state.assignments } : DataAwsApiGatewayExportState<'ExportType, Present, 'StageName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_export#stage_name-1">DataAwsApiGatewayExport#stage_name</a>.
        /// </summary>
        [<CustomOperation "stage_name">]
        member _.StageName(state: DataAwsApiGatewayExportState<'ExportType, 'RestApiId, Missing>, value: string) : DataAwsApiGatewayExportState<'ExportType, 'RestApiId, Present> =
            state.assignments.Add(fun config -> config.StageName <- value)
            ({ assignments = state.assignments } : DataAwsApiGatewayExportState<'ExportType, 'RestApiId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_export#accepts-1">DataAwsApiGatewayExport#accepts</a>.
        /// </summary>
        [<CustomOperation "accepts">]
        member _.Accepts(state: DataAwsApiGatewayExportState<'ExportType, 'RestApiId, 'StageName>, value: string) : DataAwsApiGatewayExportState<'ExportType, 'RestApiId, 'StageName> =
            state.assignments.Add(fun config -> config.Accepts <- value)
            state : DataAwsApiGatewayExportState<'ExportType, 'RestApiId, 'StageName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_export#id-1">DataAwsApiGatewayExport#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsApiGatewayExportState<'ExportType, 'RestApiId, 'StageName>, value: string) : DataAwsApiGatewayExportState<'ExportType, 'RestApiId, 'StageName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsApiGatewayExportState<'ExportType, 'RestApiId, 'StageName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_export#parameters-1">DataAwsApiGatewayExport#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataAwsApiGatewayExportState<'ExportType, 'RestApiId, 'StageName>, value: seq<string * string>) : DataAwsApiGatewayExportState<'ExportType, 'RestApiId, 'StageName> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataAwsApiGatewayExportState<'ExportType, 'RestApiId, 'StageName>

        member _.Run(state: DataAwsApiGatewayExportState<Present, Present, Present>) : aws.DataAwsApiGatewayExport.DataAwsApiGatewayExport =
            let config = aws.DataAwsApiGatewayExport.DataAwsApiGatewayExportConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsApiGatewayExport.DataAwsApiGatewayExport(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsApiGatewayExport: missing required arguments. Must call: export_type, rest_api_id, stage_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsApiGatewayExportState<_, _, _>) : aws.DataAwsApiGatewayExport.DataAwsApiGatewayExport =
            Unchecked.defaultof<aws.DataAwsApiGatewayExport.DataAwsApiGatewayExport>
