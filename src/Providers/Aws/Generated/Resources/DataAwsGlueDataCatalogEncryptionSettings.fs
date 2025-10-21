namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsGlueDataCatalogEncryptionSettingsState<'CatalogId> = { assignments: ResizeArray<aws.DataAwsGlueDataCatalogEncryptionSettings.DataAwsGlueDataCatalogEncryptionSettingsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_data_catalog_encryption_settings">aws_glue_data_catalog_encryption_settings</a>.
    /// </summary>
    type DataAwsGlueDataCatalogEncryptionSettingsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsGlueDataCatalogEncryptionSettingsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsGlueDataCatalogEncryptionSettingsState<Missing>)

        member _.Zero(()) : DataAwsGlueDataCatalogEncryptionSettingsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsGlueDataCatalogEncryptionSettingsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_data_catalog_encryption_settings#catalog_id-1">DataAwsGlueDataCatalogEncryptionSettings#catalog_id</a>.
        /// </summary>
        [<CustomOperation "catalog_id">]
        member _.CatalogId(state: DataAwsGlueDataCatalogEncryptionSettingsState<Missing>, value: string) : DataAwsGlueDataCatalogEncryptionSettingsState<Present> =
            state.assignments.Add(fun config -> config.CatalogId <- value)
            ({ assignments = state.assignments } : DataAwsGlueDataCatalogEncryptionSettingsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_data_catalog_encryption_settings#id-1">DataAwsGlueDataCatalogEncryptionSettings#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsGlueDataCatalogEncryptionSettingsState<'CatalogId>, value: string) : DataAwsGlueDataCatalogEncryptionSettingsState<'CatalogId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsGlueDataCatalogEncryptionSettingsState<'CatalogId>

        member _.Run(state: DataAwsGlueDataCatalogEncryptionSettingsState<Present>) : aws.DataAwsGlueDataCatalogEncryptionSettings.DataAwsGlueDataCatalogEncryptionSettings =
            let config = aws.DataAwsGlueDataCatalogEncryptionSettings.DataAwsGlueDataCatalogEncryptionSettingsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsGlueDataCatalogEncryptionSettings.DataAwsGlueDataCatalogEncryptionSettings(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsGlueDataCatalogEncryptionSettings: missing required arguments. Must call: catalog_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsGlueDataCatalogEncryptionSettingsState<_>) : aws.DataAwsGlueDataCatalogEncryptionSettings.DataAwsGlueDataCatalogEncryptionSettings =
            Unchecked.defaultof<aws.DataAwsGlueDataCatalogEncryptionSettings.DataAwsGlueDataCatalogEncryptionSettings>
