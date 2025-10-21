namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GlueCatalogDatabaseState<'Name> = { assignments: ResizeArray<aws.GlueCatalogDatabase.GlueCatalogDatabaseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_database">aws_glue_catalog_database</a>.
    /// </summary>
    type GlueCatalogDatabaseBuilder(logicalId: string) =
        member _.Yield(_: unit) : GlueCatalogDatabaseState<Missing> =
            ({ assignments = ResizeArray() } : GlueCatalogDatabaseState<Missing>)

        member _.Zero(()) : GlueCatalogDatabaseState<Missing> =
            ({ assignments = ResizeArray() } : GlueCatalogDatabaseState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_database#name-1">GlueCatalogDatabase#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GlueCatalogDatabaseState<Missing>, value: string) : GlueCatalogDatabaseState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GlueCatalogDatabaseState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_database#catalog_id-1">GlueCatalogDatabase#catalog_id</a>.
        /// </summary>
        [<CustomOperation "catalog_id">]
        member _.CatalogId(state: GlueCatalogDatabaseState<'Name>, value: string) : GlueCatalogDatabaseState<'Name> =
            state.assignments.Add(fun config -> config.CatalogId <- value)
            state : GlueCatalogDatabaseState<'Name>

        /// <summary>
        /// create_table_default_permission block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_database#create_table_default_permission-1">GlueCatalogDatabase#create_table_default_permission</a> Accepts: aws.IResolvable | aws.GlueCatalogDatabase.GlueCatalogDatabaseCreateTableDefaultPermission[]
        /// </summary>
        [<CustomOperation "create_table_default_permission">]
        member _.CreateTableDefaultPermission(state: GlueCatalogDatabaseState<'Name>, value: HashiCorp.Cdktf.IResolvable) : GlueCatalogDatabaseState<'Name> =
            state.assignments.Add(fun config -> config.CreateTableDefaultPermission <- value)
            state : GlueCatalogDatabaseState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_database#description-1">GlueCatalogDatabase#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: GlueCatalogDatabaseState<'Name>, value: string) : GlueCatalogDatabaseState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : GlueCatalogDatabaseState<'Name>

        /// <summary>
        /// federated_database block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_database#federated_database-1">GlueCatalogDatabase#federated_database</a>
        /// </summary>
        [<CustomOperation "federated_database">]
        member _.FederatedDatabase(state: GlueCatalogDatabaseState<'Name>, value: aws.GlueCatalogDatabase.GlueCatalogDatabaseFederatedDatabase) : GlueCatalogDatabaseState<'Name> =
            state.assignments.Add(fun config -> config.FederatedDatabase <- value)
            state : GlueCatalogDatabaseState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_database#id-1">GlueCatalogDatabase#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GlueCatalogDatabaseState<'Name>, value: string) : GlueCatalogDatabaseState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GlueCatalogDatabaseState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_database#location_uri-1">GlueCatalogDatabase#location_uri</a>.
        /// </summary>
        [<CustomOperation "location_uri">]
        member _.LocationUri(state: GlueCatalogDatabaseState<'Name>, value: string) : GlueCatalogDatabaseState<'Name> =
            state.assignments.Add(fun config -> config.LocationUri <- value)
            state : GlueCatalogDatabaseState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_database#parameters-1">GlueCatalogDatabase#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: GlueCatalogDatabaseState<'Name>, value: seq<string * string>) : GlueCatalogDatabaseState<'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : GlueCatalogDatabaseState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_database#tags-1">GlueCatalogDatabase#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GlueCatalogDatabaseState<'Name>, value: seq<string * string>) : GlueCatalogDatabaseState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GlueCatalogDatabaseState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_database#tags_all-1">GlueCatalogDatabase#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: GlueCatalogDatabaseState<'Name>, value: seq<string * string>) : GlueCatalogDatabaseState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : GlueCatalogDatabaseState<'Name>

        /// <summary>
        /// target_database block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_database#target_database-1">GlueCatalogDatabase#target_database</a>
        /// </summary>
        [<CustomOperation "target_database">]
        member _.TargetDatabase(state: GlueCatalogDatabaseState<'Name>, value: aws.GlueCatalogDatabase.GlueCatalogDatabaseTargetDatabase) : GlueCatalogDatabaseState<'Name> =
            state.assignments.Add(fun config -> config.TargetDatabase <- value)
            state : GlueCatalogDatabaseState<'Name>

        member _.Run(state: GlueCatalogDatabaseState<Present>) : aws.GlueCatalogDatabase.GlueCatalogDatabase =
            let config = aws.GlueCatalogDatabase.GlueCatalogDatabaseConfig()
            for setter in state.assignments do
                setter config
            aws.GlueCatalogDatabase.GlueCatalogDatabase(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.glueCatalogDatabase: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: GlueCatalogDatabaseState<_>) : aws.GlueCatalogDatabase.GlueCatalogDatabase =
            Unchecked.defaultof<aws.GlueCatalogDatabase.GlueCatalogDatabase>
