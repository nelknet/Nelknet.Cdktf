namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GlueDataCatalogEncryptionSettingsState<'DataCatalogEncryptionSettings> = { assignments: ResizeArray<aws.GlueDataCatalogEncryptionSettings.GlueDataCatalogEncryptionSettingsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_data_catalog_encryption_settings">aws_glue_data_catalog_encryption_settings</a>.
    /// </summary>
    type GlueDataCatalogEncryptionSettingsBuilder(logicalId: string) =
        member _.Yield(_: unit) : GlueDataCatalogEncryptionSettingsState<Missing> =
            ({ assignments = ResizeArray() } : GlueDataCatalogEncryptionSettingsState<Missing>)

        member _.Zero(()) : GlueDataCatalogEncryptionSettingsState<Missing> =
            ({ assignments = ResizeArray() } : GlueDataCatalogEncryptionSettingsState<Missing>)

        /// <summary>
        /// data_catalog_encryption_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_data_catalog_encryption_settings#data_catalog_encryption_settings-1">GlueDataCatalogEncryptionSettings#data_catalog_encryption_settings</a>
        /// </summary>
        [<CustomOperation "data_catalog_encryption_settings">]
        member _.DataCatalogEncryptionSettings(state: GlueDataCatalogEncryptionSettingsState<Missing>, value: aws.GlueDataCatalogEncryptionSettings.GlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettings) : GlueDataCatalogEncryptionSettingsState<Present> =
            state.assignments.Add(fun config -> config.DataCatalogEncryptionSettings <- value)
            ({ assignments = state.assignments } : GlueDataCatalogEncryptionSettingsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_data_catalog_encryption_settings#catalog_id-1">GlueDataCatalogEncryptionSettings#catalog_id</a>.
        /// </summary>
        [<CustomOperation "catalog_id">]
        member _.CatalogId(state: GlueDataCatalogEncryptionSettingsState<'DataCatalogEncryptionSettings>, value: string) : GlueDataCatalogEncryptionSettingsState<'DataCatalogEncryptionSettings> =
            state.assignments.Add(fun config -> config.CatalogId <- value)
            state : GlueDataCatalogEncryptionSettingsState<'DataCatalogEncryptionSettings>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_data_catalog_encryption_settings#id-1">GlueDataCatalogEncryptionSettings#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GlueDataCatalogEncryptionSettingsState<'DataCatalogEncryptionSettings>, value: string) : GlueDataCatalogEncryptionSettingsState<'DataCatalogEncryptionSettings> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GlueDataCatalogEncryptionSettingsState<'DataCatalogEncryptionSettings>

        member _.Run(state: GlueDataCatalogEncryptionSettingsState<Present>) : aws.GlueDataCatalogEncryptionSettings.GlueDataCatalogEncryptionSettings =
            let config = aws.GlueDataCatalogEncryptionSettings.GlueDataCatalogEncryptionSettingsConfig()
            for setter in state.assignments do
                setter config
            aws.GlueDataCatalogEncryptionSettings.GlueDataCatalogEncryptionSettings(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.glueDataCatalogEncryptionSettings: missing required arguments. Must call: data_catalog_encryption_settings.", 9999, IsError = true)>]
        member _.Run(_: GlueDataCatalogEncryptionSettingsState<_>) : aws.GlueDataCatalogEncryptionSettings.GlueDataCatalogEncryptionSettings =
            Unchecked.defaultof<aws.GlueDataCatalogEncryptionSettings.GlueDataCatalogEncryptionSettings>
