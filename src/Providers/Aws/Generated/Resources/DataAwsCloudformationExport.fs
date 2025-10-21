namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCloudformationExportState<'Name> = { assignments: ResizeArray<aws.DataAwsCloudformationExport.DataAwsCloudformationExportConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudformation_export">aws_cloudformation_export</a>.
    /// </summary>
    type DataAwsCloudformationExportBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCloudformationExportState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCloudformationExportState<Missing>)

        member _.Zero(()) : DataAwsCloudformationExportState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCloudformationExportState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudformation_export#name-1">DataAwsCloudformationExport#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsCloudformationExportState<Missing>, value: string) : DataAwsCloudformationExportState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsCloudformationExportState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudformation_export#id-1">DataAwsCloudformationExport#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCloudformationExportState<'Name>, value: string) : DataAwsCloudformationExportState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCloudformationExportState<'Name>

        member _.Run(state: DataAwsCloudformationExportState<Present>) : aws.DataAwsCloudformationExport.DataAwsCloudformationExport =
            let config = aws.DataAwsCloudformationExport.DataAwsCloudformationExportConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCloudformationExport.DataAwsCloudformationExport(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCloudformationExport: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCloudformationExportState<_>) : aws.DataAwsCloudformationExport.DataAwsCloudformationExport =
            Unchecked.defaultof<aws.DataAwsCloudformationExport.DataAwsCloudformationExport>
