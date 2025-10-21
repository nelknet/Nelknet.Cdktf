namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name> = { assignments: ResizeArray<aws.QuicksightDataSet.QuicksightDataSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set">aws_quicksight_data_set</a>.
    /// </summary>
    type QuicksightDataSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : QuicksightDataSetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightDataSetState<Missing, Missing, Missing>)

        member _.Zero(()) : QuicksightDataSetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightDataSetState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#data_set_id-1">QuicksightDataSet#data_set_id</a>.
        /// </summary>
        [<CustomOperation "data_set_id">]
        member _.DataSetId(state: QuicksightDataSetState<Missing, 'ImportMode, 'Name>, value: string) : QuicksightDataSetState<Present, 'ImportMode, 'Name> =
            state.assignments.Add(fun config -> config.DataSetId <- value)
            ({ assignments = state.assignments } : QuicksightDataSetState<Present, 'ImportMode, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#import_mode-1">QuicksightDataSet#import_mode</a>.
        /// </summary>
        [<CustomOperation "import_mode">]
        member _.ImportMode(state: QuicksightDataSetState<'DataSetId, Missing, 'Name>, value: string) : QuicksightDataSetState<'DataSetId, Present, 'Name> =
            state.assignments.Add(fun config -> config.ImportMode <- value)
            ({ assignments = state.assignments } : QuicksightDataSetState<'DataSetId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#name-1">QuicksightDataSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: QuicksightDataSetState<'DataSetId, 'ImportMode, Missing>, value: string) : QuicksightDataSetState<'DataSetId, 'ImportMode, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : QuicksightDataSetState<'DataSetId, 'ImportMode, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#aws_account_id-1">QuicksightDataSet#aws_account_id</a>.
        /// </summary>
        [<CustomOperation "aws_account_id">]
        member _.AwsAccountId(state: QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name>, value: string) : QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name> =
            state.assignments.Add(fun config -> config.AwsAccountId <- value)
            state : QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name>

        /// <summary>
        /// column_groups block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#column_groups-1">QuicksightDataSet#column_groups</a> Accepts: aws.IResolvable | aws.QuicksightDataSet.QuicksightDataSetColumnGroups[]
        /// </summary>
        [<CustomOperation "column_groups">]
        member _.ColumnGroups(state: QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name>, value: HashiCorp.Cdktf.IResolvable) : QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name> =
            state.assignments.Add(fun config -> config.ColumnGroups <- value)
            state : QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name>

        /// <summary>
        /// column_level_permission_rules block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#column_level_permission_rules-1">QuicksightDataSet#column_level_permission_rules</a> Accepts: aws.IResolvable | aws.QuicksightDataSet.QuicksightDataSetColumnLevelPermissionRules[]
        /// </summary>
        [<CustomOperation "column_level_permission_rules">]
        member _.ColumnLevelPermissionRules(state: QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name>, value: HashiCorp.Cdktf.IResolvable) : QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name> =
            state.assignments.Add(fun config -> config.ColumnLevelPermissionRules <- value)
            state : QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name>

        /// <summary>
        /// data_set_usage_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#data_set_usage_configuration-1">QuicksightDataSet#data_set_usage_configuration</a>
        /// </summary>
        [<CustomOperation "data_set_usage_configuration">]
        member _.DataSetUsageConfiguration(state: QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name>, value: aws.QuicksightDataSet.QuicksightDataSetDataSetUsageConfiguration) : QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name> =
            state.assignments.Add(fun config -> config.DataSetUsageConfiguration <- value)
            state : QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name>

        /// <summary>
        /// field_folders block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#field_folders-1">QuicksightDataSet#field_folders</a> Accepts: aws.IResolvable | aws.QuicksightDataSet.QuicksightDataSetFieldFolders[]
        /// </summary>
        [<CustomOperation "field_folders">]
        member _.FieldFolders(state: QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name>, value: HashiCorp.Cdktf.IResolvable) : QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name> =
            state.assignments.Add(fun config -> config.FieldFolders <- value)
            state : QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#id-1">QuicksightDataSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name>, value: string) : QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name>

        /// <summary>
        /// logical_table_map block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#logical_table_map-1">QuicksightDataSet#logical_table_map</a> Accepts: aws.IResolvable | aws.QuicksightDataSet.QuicksightDataSetLogicalTableMap[]
        /// </summary>
        [<CustomOperation "logical_table_map">]
        member _.LogicalTableMap(state: QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name>, value: HashiCorp.Cdktf.IResolvable) : QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name> =
            state.assignments.Add(fun config -> config.LogicalTableMap <- value)
            state : QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name>

        /// <summary>
        /// permissions block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#permissions-1">QuicksightDataSet#permissions</a> Accepts: aws.IResolvable | aws.QuicksightDataSet.QuicksightDataSetPermissions[]
        /// </summary>
        [<CustomOperation "permissions">]
        member _.Permissions(state: QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name>, value: HashiCorp.Cdktf.IResolvable) : QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name> =
            state.assignments.Add(fun config -> config.Permissions <- value)
            state : QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name>

        /// <summary>
        /// physical_table_map block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#physical_table_map-1">QuicksightDataSet#physical_table_map</a> Accepts: aws.IResolvable | aws.QuicksightDataSet.QuicksightDataSetPhysicalTableMap[]
        /// </summary>
        [<CustomOperation "physical_table_map">]
        member _.PhysicalTableMap(state: QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name>, value: HashiCorp.Cdktf.IResolvable) : QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name> =
            state.assignments.Add(fun config -> config.PhysicalTableMap <- value)
            state : QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name>

        /// <summary>
        /// refresh_properties block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#refresh_properties-1">QuicksightDataSet#refresh_properties</a>
        /// </summary>
        [<CustomOperation "refresh_properties">]
        member _.RefreshProperties(state: QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name>, value: aws.QuicksightDataSet.QuicksightDataSetRefreshProperties) : QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name> =
            state.assignments.Add(fun config -> config.RefreshProperties <- value)
            state : QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name>

        /// <summary>
        /// row_level_permission_data_set block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#row_level_permission_data_set-1">QuicksightDataSet#row_level_permission_data_set</a>
        /// </summary>
        [<CustomOperation "row_level_permission_data_set">]
        member _.RowLevelPermissionDataSet(state: QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name>, value: aws.QuicksightDataSet.QuicksightDataSetRowLevelPermissionDataSet) : QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name> =
            state.assignments.Add(fun config -> config.RowLevelPermissionDataSet <- value)
            state : QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name>

        /// <summary>
        /// row_level_permission_tag_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#row_level_permission_tag_configuration-1">QuicksightDataSet#row_level_permission_tag_configuration</a>
        /// </summary>
        [<CustomOperation "row_level_permission_tag_configuration">]
        member _.RowLevelPermissionTagConfiguration(state: QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name>, value: aws.QuicksightDataSet.QuicksightDataSetRowLevelPermissionTagConfiguration) : QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name> =
            state.assignments.Add(fun config -> config.RowLevelPermissionTagConfiguration <- value)
            state : QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#tags-1">QuicksightDataSet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name>, value: seq<string * string>) : QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#tags_all-1">QuicksightDataSet#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name>, value: seq<string * string>) : QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : QuicksightDataSetState<'DataSetId, 'ImportMode, 'Name>

        member _.Run(state: QuicksightDataSetState<Present, Present, Present>) : aws.QuicksightDataSet.QuicksightDataSet =
            let config = aws.QuicksightDataSet.QuicksightDataSetConfig()
            for setter in state.assignments do
                setter config
            aws.QuicksightDataSet.QuicksightDataSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.quicksightDataSet: missing required arguments. Must call: data_set_id, import_mode, name.", 9999, IsError = true)>]
        member _.Run(_: QuicksightDataSetState<_, _, _>) : aws.QuicksightDataSet.QuicksightDataSet =
            Unchecked.defaultof<aws.QuicksightDataSet.QuicksightDataSet>
