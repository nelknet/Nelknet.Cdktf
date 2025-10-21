namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LakeformationPermissionsState<'Permissions, 'Principal> = { assignments: ResizeArray<aws.LakeformationPermissions.LakeformationPermissionsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions">aws_lakeformation_permissions</a>.
    /// </summary>
    type LakeformationPermissionsBuilder(logicalId: string) =
        member _.Yield(_: unit) : LakeformationPermissionsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LakeformationPermissionsState<Missing, Missing>)

        member _.Zero(()) : LakeformationPermissionsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LakeformationPermissionsState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#permissions-1">LakeformationPermissions#permissions</a>.
        /// </summary>
        [<CustomOperation "permissions">]
        member _.Permissions(state: LakeformationPermissionsState<Missing, 'Principal>, value: seq<string>) : LakeformationPermissionsState<Present, 'Principal> =
            state.assignments.Add(fun config -> config.Permissions <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : LakeformationPermissionsState<Present, 'Principal>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#principal-1">LakeformationPermissions#principal</a>.
        /// </summary>
        [<CustomOperation "principal">]
        member _.Principal(state: LakeformationPermissionsState<'Permissions, Missing>, value: string) : LakeformationPermissionsState<'Permissions, Present> =
            state.assignments.Add(fun config -> config.Principal <- value)
            ({ assignments = state.assignments } : LakeformationPermissionsState<'Permissions, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#catalog_id-1">LakeformationPermissions#catalog_id</a>.
        /// </summary>
        [<CustomOperation "catalog_id">]
        member _.CatalogId(state: LakeformationPermissionsState<'Permissions, 'Principal>, value: string) : LakeformationPermissionsState<'Permissions, 'Principal> =
            state.assignments.Add(fun config -> config.CatalogId <- value)
            state : LakeformationPermissionsState<'Permissions, 'Principal>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#catalog_resource-1">LakeformationPermissions#catalog_resource</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "catalog_resource">]
        member _.CatalogResource(state: LakeformationPermissionsState<'Permissions, 'Principal>, value: bool) : LakeformationPermissionsState<'Permissions, 'Principal> =
            state.assignments.Add(fun config -> config.CatalogResource <- value)
            state : LakeformationPermissionsState<'Permissions, 'Principal>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#catalog_resource-1">LakeformationPermissions#catalog_resource</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "catalog_resource">]
        member _.CatalogResource(state: LakeformationPermissionsState<'Permissions, 'Principal>, value: HashiCorp.Cdktf.IResolvable) : LakeformationPermissionsState<'Permissions, 'Principal> =
            state.assignments.Add(fun config -> config.CatalogResource <- value)
            state : LakeformationPermissionsState<'Permissions, 'Principal>

        /// <summary>
        /// database block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#database-1">LakeformationPermissions#database</a>
        /// </summary>
        [<CustomOperation "database">]
        member _.Database(state: LakeformationPermissionsState<'Permissions, 'Principal>, value: aws.LakeformationPermissions.LakeformationPermissionsDatabase) : LakeformationPermissionsState<'Permissions, 'Principal> =
            state.assignments.Add(fun config -> config.Database <- value)
            state : LakeformationPermissionsState<'Permissions, 'Principal>

        /// <summary>
        /// data_cells_filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#data_cells_filter-1">LakeformationPermissions#data_cells_filter</a>
        /// </summary>
        [<CustomOperation "data_cells_filter">]
        member _.DataCellsFilter(state: LakeformationPermissionsState<'Permissions, 'Principal>, value: aws.LakeformationPermissions.LakeformationPermissionsDataCellsFilter) : LakeformationPermissionsState<'Permissions, 'Principal> =
            state.assignments.Add(fun config -> config.DataCellsFilter <- value)
            state : LakeformationPermissionsState<'Permissions, 'Principal>

        /// <summary>
        /// data_location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#data_location-1">LakeformationPermissions#data_location</a>
        /// </summary>
        [<CustomOperation "data_location">]
        member _.DataLocation(state: LakeformationPermissionsState<'Permissions, 'Principal>, value: aws.LakeformationPermissions.LakeformationPermissionsDataLocation) : LakeformationPermissionsState<'Permissions, 'Principal> =
            state.assignments.Add(fun config -> config.DataLocation <- value)
            state : LakeformationPermissionsState<'Permissions, 'Principal>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#id-1">LakeformationPermissions#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LakeformationPermissionsState<'Permissions, 'Principal>, value: string) : LakeformationPermissionsState<'Permissions, 'Principal> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LakeformationPermissionsState<'Permissions, 'Principal>

        /// <summary>
        /// lf_tag block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#lf_tag-1">LakeformationPermissions#lf_tag</a>
        /// </summary>
        [<CustomOperation "lf_tag">]
        member _.LfTag(state: LakeformationPermissionsState<'Permissions, 'Principal>, value: aws.LakeformationPermissions.LakeformationPermissionsLfTag) : LakeformationPermissionsState<'Permissions, 'Principal> =
            state.assignments.Add(fun config -> config.LfTag <- value)
            state : LakeformationPermissionsState<'Permissions, 'Principal>

        /// <summary>
        /// lf_tag_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#lf_tag_policy-1">LakeformationPermissions#lf_tag_policy</a>
        /// </summary>
        [<CustomOperation "lf_tag_policy">]
        member _.LfTagPolicy(state: LakeformationPermissionsState<'Permissions, 'Principal>, value: aws.LakeformationPermissions.LakeformationPermissionsLfTagPolicy) : LakeformationPermissionsState<'Permissions, 'Principal> =
            state.assignments.Add(fun config -> config.LfTagPolicy <- value)
            state : LakeformationPermissionsState<'Permissions, 'Principal>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#permissions_with_grant_option-1">LakeformationPermissions#permissions_with_grant_option</a>.
        /// </summary>
        [<CustomOperation "permissions_with_grant_option">]
        member _.PermissionsWithGrantOption(state: LakeformationPermissionsState<'Permissions, 'Principal>, value: seq<string>) : LakeformationPermissionsState<'Permissions, 'Principal> =
            state.assignments.Add(fun config -> config.PermissionsWithGrantOption <- (value |> Seq.toArray))
            state : LakeformationPermissionsState<'Permissions, 'Principal>

        /// <summary>
        /// table block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#table-1">LakeformationPermissions#table</a>
        /// </summary>
        [<CustomOperation "table">]
        member _.Table(state: LakeformationPermissionsState<'Permissions, 'Principal>, value: aws.LakeformationPermissions.LakeformationPermissionsTable) : LakeformationPermissionsState<'Permissions, 'Principal> =
            state.assignments.Add(fun config -> config.Table <- value)
            state : LakeformationPermissionsState<'Permissions, 'Principal>

        /// <summary>
        /// table_with_columns block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#table_with_columns-1">LakeformationPermissions#table_with_columns</a>
        /// </summary>
        [<CustomOperation "table_with_columns">]
        member _.TableWithColumns(state: LakeformationPermissionsState<'Permissions, 'Principal>, value: aws.LakeformationPermissions.LakeformationPermissionsTableWithColumns) : LakeformationPermissionsState<'Permissions, 'Principal> =
            state.assignments.Add(fun config -> config.TableWithColumns <- value)
            state : LakeformationPermissionsState<'Permissions, 'Principal>

        member _.Run(state: LakeformationPermissionsState<Present, Present>) : aws.LakeformationPermissions.LakeformationPermissions =
            let config = aws.LakeformationPermissions.LakeformationPermissionsConfig()
            for setter in state.assignments do
                setter config
            aws.LakeformationPermissions.LakeformationPermissions(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lakeformationPermissions: missing required arguments. Must call: permissions, principal.", 9999, IsError = true)>]
        member _.Run(_: LakeformationPermissionsState<_, _>) : aws.LakeformationPermissions.LakeformationPermissions =
            Unchecked.defaultof<aws.LakeformationPermissions.LakeformationPermissions>
