namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLakeformationPermissionsState<'Principal> = { assignments: ResizeArray<aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissionsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions">aws_lakeformation_permissions</a>.
    /// </summary>
    type DataAwsLakeformationPermissionsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLakeformationPermissionsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLakeformationPermissionsState<Missing>)

        member _.Zero(()) : DataAwsLakeformationPermissionsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLakeformationPermissionsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#principal-1">DataAwsLakeformationPermissions#principal</a>.
        /// </summary>
        [<CustomOperation "principal">]
        member _.Principal(state: DataAwsLakeformationPermissionsState<Missing>, value: string) : DataAwsLakeformationPermissionsState<Present> =
            state.assignments.Add(fun config -> config.Principal <- value)
            ({ assignments = state.assignments } : DataAwsLakeformationPermissionsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#catalog_id-1">DataAwsLakeformationPermissions#catalog_id</a>.
        /// </summary>
        [<CustomOperation "catalog_id">]
        member _.CatalogId(state: DataAwsLakeformationPermissionsState<'Principal>, value: string) : DataAwsLakeformationPermissionsState<'Principal> =
            state.assignments.Add(fun config -> config.CatalogId <- value)
            state : DataAwsLakeformationPermissionsState<'Principal>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#catalog_resource-1">DataAwsLakeformationPermissions#catalog_resource</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "catalog_resource">]
        member _.CatalogResource(state: DataAwsLakeformationPermissionsState<'Principal>, value: bool) : DataAwsLakeformationPermissionsState<'Principal> =
            state.assignments.Add(fun config -> config.CatalogResource <- value)
            state : DataAwsLakeformationPermissionsState<'Principal>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#catalog_resource-1">DataAwsLakeformationPermissions#catalog_resource</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "catalog_resource">]
        member _.CatalogResource(state: DataAwsLakeformationPermissionsState<'Principal>, value: HashiCorp.Cdktf.IResolvable) : DataAwsLakeformationPermissionsState<'Principal> =
            state.assignments.Add(fun config -> config.CatalogResource <- value)
            state : DataAwsLakeformationPermissionsState<'Principal>

        /// <summary>
        /// database block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#database-1">DataAwsLakeformationPermissions#database</a>
        /// </summary>
        [<CustomOperation "database">]
        member _.Database(state: DataAwsLakeformationPermissionsState<'Principal>, value: aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissionsDatabase) : DataAwsLakeformationPermissionsState<'Principal> =
            state.assignments.Add(fun config -> config.Database <- value)
            state : DataAwsLakeformationPermissionsState<'Principal>

        /// <summary>
        /// data_cells_filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#data_cells_filter-1">DataAwsLakeformationPermissions#data_cells_filter</a>
        /// </summary>
        [<CustomOperation "data_cells_filter">]
        member _.DataCellsFilter(state: DataAwsLakeformationPermissionsState<'Principal>, value: aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissionsDataCellsFilter) : DataAwsLakeformationPermissionsState<'Principal> =
            state.assignments.Add(fun config -> config.DataCellsFilter <- value)
            state : DataAwsLakeformationPermissionsState<'Principal>

        /// <summary>
        /// data_location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#data_location-1">DataAwsLakeformationPermissions#data_location</a>
        /// </summary>
        [<CustomOperation "data_location">]
        member _.DataLocation(state: DataAwsLakeformationPermissionsState<'Principal>, value: aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissionsDataLocation) : DataAwsLakeformationPermissionsState<'Principal> =
            state.assignments.Add(fun config -> config.DataLocation <- value)
            state : DataAwsLakeformationPermissionsState<'Principal>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#id-1">DataAwsLakeformationPermissions#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLakeformationPermissionsState<'Principal>, value: string) : DataAwsLakeformationPermissionsState<'Principal> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLakeformationPermissionsState<'Principal>

        /// <summary>
        /// lf_tag block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#lf_tag-1">DataAwsLakeformationPermissions#lf_tag</a>
        /// </summary>
        [<CustomOperation "lf_tag">]
        member _.LfTag(state: DataAwsLakeformationPermissionsState<'Principal>, value: aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissionsLfTag) : DataAwsLakeformationPermissionsState<'Principal> =
            state.assignments.Add(fun config -> config.LfTag <- value)
            state : DataAwsLakeformationPermissionsState<'Principal>

        /// <summary>
        /// lf_tag_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#lf_tag_policy-1">DataAwsLakeformationPermissions#lf_tag_policy</a>
        /// </summary>
        [<CustomOperation "lf_tag_policy">]
        member _.LfTagPolicy(state: DataAwsLakeformationPermissionsState<'Principal>, value: aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissionsLfTagPolicy) : DataAwsLakeformationPermissionsState<'Principal> =
            state.assignments.Add(fun config -> config.LfTagPolicy <- value)
            state : DataAwsLakeformationPermissionsState<'Principal>

        /// <summary>
        /// table block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#table-1">DataAwsLakeformationPermissions#table</a>
        /// </summary>
        [<CustomOperation "table">]
        member _.Table(state: DataAwsLakeformationPermissionsState<'Principal>, value: aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissionsTable) : DataAwsLakeformationPermissionsState<'Principal> =
            state.assignments.Add(fun config -> config.Table <- value)
            state : DataAwsLakeformationPermissionsState<'Principal>

        /// <summary>
        /// table_with_columns block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#table_with_columns-1">DataAwsLakeformationPermissions#table_with_columns</a>
        /// </summary>
        [<CustomOperation "table_with_columns">]
        member _.TableWithColumns(state: DataAwsLakeformationPermissionsState<'Principal>, value: aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissionsTableWithColumns) : DataAwsLakeformationPermissionsState<'Principal> =
            state.assignments.Add(fun config -> config.TableWithColumns <- value)
            state : DataAwsLakeformationPermissionsState<'Principal>

        member _.Run(state: DataAwsLakeformationPermissionsState<Present>) : aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissions =
            let config = aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissionsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissions(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsLakeformationPermissions: missing required arguments. Must call: principal.", 9999, IsError = true)>]
        member _.Run(_: DataAwsLakeformationPermissionsState<_>) : aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissions =
            Unchecked.defaultof<aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissions>
