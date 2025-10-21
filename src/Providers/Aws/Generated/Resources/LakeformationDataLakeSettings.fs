namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LakeformationDataLakeSettingsState = { assignments: ResizeArray<aws.LakeformationDataLakeSettings.LakeformationDataLakeSettingsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_lake_settings">aws_lakeformation_data_lake_settings</a>.
    /// </summary>
    type LakeformationDataLakeSettingsBuilder(logicalId: string) =
        member _.Yield(_: unit) : LakeformationDataLakeSettingsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : LakeformationDataLakeSettingsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_lake_settings#admins-1">LakeformationDataLakeSettings#admins</a>.
        /// </summary>
        [<CustomOperation "admins">]
        member _.Admins(state: LakeformationDataLakeSettingsState, value: seq<string>) : LakeformationDataLakeSettingsState =
            state.assignments.Add(fun config -> config.Admins <- (value |> Seq.toArray))
            state : LakeformationDataLakeSettingsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_lake_settings#allow_external_data_filtering-1">LakeformationDataLakeSettings#allow_external_data_filtering</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_external_data_filtering">]
        member _.AllowExternalDataFiltering(state: LakeformationDataLakeSettingsState, value: bool) : LakeformationDataLakeSettingsState =
            state.assignments.Add(fun config -> config.AllowExternalDataFiltering <- value)
            state : LakeformationDataLakeSettingsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_lake_settings#allow_external_data_filtering-1">LakeformationDataLakeSettings#allow_external_data_filtering</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_external_data_filtering">]
        member _.AllowExternalDataFiltering(state: LakeformationDataLakeSettingsState, value: HashiCorp.Cdktf.IResolvable) : LakeformationDataLakeSettingsState =
            state.assignments.Add(fun config -> config.AllowExternalDataFiltering <- value)
            state : LakeformationDataLakeSettingsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_lake_settings#allow_full_table_external_data_access-1">LakeformationDataLakeSettings#allow_full_table_external_data_access</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_full_table_external_data_access">]
        member _.AllowFullTableExternalDataAccess(state: LakeformationDataLakeSettingsState, value: bool) : LakeformationDataLakeSettingsState =
            state.assignments.Add(fun config -> config.AllowFullTableExternalDataAccess <- value)
            state : LakeformationDataLakeSettingsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_lake_settings#allow_full_table_external_data_access-1">LakeformationDataLakeSettings#allow_full_table_external_data_access</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_full_table_external_data_access">]
        member _.AllowFullTableExternalDataAccess(state: LakeformationDataLakeSettingsState, value: HashiCorp.Cdktf.IResolvable) : LakeformationDataLakeSettingsState =
            state.assignments.Add(fun config -> config.AllowFullTableExternalDataAccess <- value)
            state : LakeformationDataLakeSettingsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_lake_settings#authorized_session_tag_value_list-1">LakeformationDataLakeSettings#authorized_session_tag_value_list</a>.
        /// </summary>
        [<CustomOperation "authorized_session_tag_value_list">]
        member _.AuthorizedSessionTagValueList(state: LakeformationDataLakeSettingsState, value: seq<string>) : LakeformationDataLakeSettingsState =
            state.assignments.Add(fun config -> config.AuthorizedSessionTagValueList <- (value |> Seq.toArray))
            state : LakeformationDataLakeSettingsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_lake_settings#catalog_id-1">LakeformationDataLakeSettings#catalog_id</a>.
        /// </summary>
        [<CustomOperation "catalog_id">]
        member _.CatalogId(state: LakeformationDataLakeSettingsState, value: string) : LakeformationDataLakeSettingsState =
            state.assignments.Add(fun config -> config.CatalogId <- value)
            state : LakeformationDataLakeSettingsState

        /// <summary>
        /// create_database_default_permissions block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_lake_settings#create_database_default_permissions-1">LakeformationDataLakeSettings#create_database_default_permissions</a> Accepts: aws.IResolvable | aws.LakeformationDataLakeSettings.LakeformationDataLakeSettingsCreateDatabaseDefaultPermissions[]
        /// </summary>
        [<CustomOperation "create_database_default_permissions">]
        member _.CreateDatabaseDefaultPermissions(state: LakeformationDataLakeSettingsState, value: HashiCorp.Cdktf.IResolvable) : LakeformationDataLakeSettingsState =
            state.assignments.Add(fun config -> config.CreateDatabaseDefaultPermissions <- value)
            state : LakeformationDataLakeSettingsState

        /// <summary>
        /// create_table_default_permissions block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_lake_settings#create_table_default_permissions-1">LakeformationDataLakeSettings#create_table_default_permissions</a> Accepts: aws.IResolvable | aws.LakeformationDataLakeSettings.LakeformationDataLakeSettingsCreateTableDefaultPermissions[]
        /// </summary>
        [<CustomOperation "create_table_default_permissions">]
        member _.CreateTableDefaultPermissions(state: LakeformationDataLakeSettingsState, value: HashiCorp.Cdktf.IResolvable) : LakeformationDataLakeSettingsState =
            state.assignments.Add(fun config -> config.CreateTableDefaultPermissions <- value)
            state : LakeformationDataLakeSettingsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_lake_settings#external_data_filtering_allow_list-1">LakeformationDataLakeSettings#external_data_filtering_allow_list</a>.
        /// </summary>
        [<CustomOperation "external_data_filtering_allow_list">]
        member _.ExternalDataFilteringAllowList(state: LakeformationDataLakeSettingsState, value: seq<string>) : LakeformationDataLakeSettingsState =
            state.assignments.Add(fun config -> config.ExternalDataFilteringAllowList <- (value |> Seq.toArray))
            state : LakeformationDataLakeSettingsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_lake_settings#id-1">LakeformationDataLakeSettings#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LakeformationDataLakeSettingsState, value: string) : LakeformationDataLakeSettingsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LakeformationDataLakeSettingsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_lake_settings#parameters-1">LakeformationDataLakeSettings#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: LakeformationDataLakeSettingsState, value: seq<string * string>) : LakeformationDataLakeSettingsState =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : LakeformationDataLakeSettingsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_lake_settings#read_only_admins-1">LakeformationDataLakeSettings#read_only_admins</a>.
        /// </summary>
        [<CustomOperation "read_only_admins">]
        member _.ReadOnlyAdmins(state: LakeformationDataLakeSettingsState, value: seq<string>) : LakeformationDataLakeSettingsState =
            state.assignments.Add(fun config -> config.ReadOnlyAdmins <- (value |> Seq.toArray))
            state : LakeformationDataLakeSettingsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_lake_settings#trusted_resource_owners-1">LakeformationDataLakeSettings#trusted_resource_owners</a>.
        /// </summary>
        [<CustomOperation "trusted_resource_owners">]
        member _.TrustedResourceOwners(state: LakeformationDataLakeSettingsState, value: seq<string>) : LakeformationDataLakeSettingsState =
            state.assignments.Add(fun config -> config.TrustedResourceOwners <- (value |> Seq.toArray))
            state : LakeformationDataLakeSettingsState

        member _.Run(state: LakeformationDataLakeSettingsState) : aws.LakeformationDataLakeSettings.LakeformationDataLakeSettings =
            let config = aws.LakeformationDataLakeSettings.LakeformationDataLakeSettingsConfig()
            for setter in state.assignments do
                setter config
            aws.LakeformationDataLakeSettings.LakeformationDataLakeSettings(StackContext.get (), logicalId, config)
