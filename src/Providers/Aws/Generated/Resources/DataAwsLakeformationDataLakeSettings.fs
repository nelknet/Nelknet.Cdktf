namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLakeformationDataLakeSettingsState = { assignments: ResizeArray<aws.DataAwsLakeformationDataLakeSettings.DataAwsLakeformationDataLakeSettingsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_data_lake_settings">aws_lakeformation_data_lake_settings</a>.
    /// </summary>
    type DataAwsLakeformationDataLakeSettingsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLakeformationDataLakeSettingsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsLakeformationDataLakeSettingsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_data_lake_settings#catalog_id-1">DataAwsLakeformationDataLakeSettings#catalog_id</a>.
        /// </summary>
        [<CustomOperation "catalog_id">]
        member _.CatalogId(state: DataAwsLakeformationDataLakeSettingsState, value: string) : DataAwsLakeformationDataLakeSettingsState =
            state.assignments.Add(fun config -> config.CatalogId <- value)
            state : DataAwsLakeformationDataLakeSettingsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_data_lake_settings#id-1">DataAwsLakeformationDataLakeSettings#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLakeformationDataLakeSettingsState, value: string) : DataAwsLakeformationDataLakeSettingsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLakeformationDataLakeSettingsState

        member _.Run(state: DataAwsLakeformationDataLakeSettingsState) : aws.DataAwsLakeformationDataLakeSettings.DataAwsLakeformationDataLakeSettings =
            let config = aws.DataAwsLakeformationDataLakeSettings.DataAwsLakeformationDataLakeSettingsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLakeformationDataLakeSettings.DataAwsLakeformationDataLakeSettings(StackContext.get (), logicalId, config)
