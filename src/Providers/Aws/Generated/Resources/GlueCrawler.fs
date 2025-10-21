namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GlueCrawlerState<'DatabaseName, 'Name, 'Role> = { assignments: ResizeArray<aws.GlueCrawler.GlueCrawlerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler">aws_glue_crawler</a>.
    /// </summary>
    type GlueCrawlerBuilder(logicalId: string) =
        member _.Yield(_: unit) : GlueCrawlerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GlueCrawlerState<Missing, Missing, Missing>)

        member _.Zero(()) : GlueCrawlerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GlueCrawlerState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#database_name-1">GlueCrawler#database_name</a>.
        /// </summary>
        [<CustomOperation "database_name">]
        member _.DatabaseName(state: GlueCrawlerState<Missing, 'Name, 'Role>, value: string) : GlueCrawlerState<Present, 'Name, 'Role> =
            state.assignments.Add(fun config -> config.DatabaseName <- value)
            ({ assignments = state.assignments } : GlueCrawlerState<Present, 'Name, 'Role>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#name-1">GlueCrawler#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GlueCrawlerState<'DatabaseName, Missing, 'Role>, value: string) : GlueCrawlerState<'DatabaseName, Present, 'Role> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GlueCrawlerState<'DatabaseName, Present, 'Role>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#role-1">GlueCrawler#role</a>.
        /// </summary>
        [<CustomOperation "role">]
        member _.Role(state: GlueCrawlerState<'DatabaseName, 'Name, Missing>, value: string) : GlueCrawlerState<'DatabaseName, 'Name, Present> =
            state.assignments.Add(fun config -> config.Role <- value)
            ({ assignments = state.assignments } : GlueCrawlerState<'DatabaseName, 'Name, Present>)

        /// <summary>
        /// catalog_target block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#catalog_target-1">GlueCrawler#catalog_target</a> Accepts: aws.IResolvable | aws.GlueCrawler.GlueCrawlerCatalogTarget[]
        /// </summary>
        [<CustomOperation "catalog_target">]
        member _.CatalogTarget(state: GlueCrawlerState<'DatabaseName, 'Name, 'Role>, value: HashiCorp.Cdktf.IResolvable) : GlueCrawlerState<'DatabaseName, 'Name, 'Role> =
            state.assignments.Add(fun config -> config.CatalogTarget <- value)
            state : GlueCrawlerState<'DatabaseName, 'Name, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#classifiers-1">GlueCrawler#classifiers</a>.
        /// </summary>
        [<CustomOperation "classifiers">]
        member _.Classifiers(state: GlueCrawlerState<'DatabaseName, 'Name, 'Role>, value: seq<string>) : GlueCrawlerState<'DatabaseName, 'Name, 'Role> =
            state.assignments.Add(fun config -> config.Classifiers <- (value |> Seq.toArray))
            state : GlueCrawlerState<'DatabaseName, 'Name, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#configuration-1">GlueCrawler#configuration</a>.
        /// </summary>
        [<CustomOperation "configuration">]
        member _.Configuration(state: GlueCrawlerState<'DatabaseName, 'Name, 'Role>, value: string) : GlueCrawlerState<'DatabaseName, 'Name, 'Role> =
            state.assignments.Add(fun config -> config.Configuration <- value)
            state : GlueCrawlerState<'DatabaseName, 'Name, 'Role>

        /// <summary>
        /// delta_target block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#delta_target-1">GlueCrawler#delta_target</a> Accepts: aws.IResolvable | aws.GlueCrawler.GlueCrawlerDeltaTarget[]
        /// </summary>
        [<CustomOperation "delta_target">]
        member _.DeltaTarget(state: GlueCrawlerState<'DatabaseName, 'Name, 'Role>, value: HashiCorp.Cdktf.IResolvable) : GlueCrawlerState<'DatabaseName, 'Name, 'Role> =
            state.assignments.Add(fun config -> config.DeltaTarget <- value)
            state : GlueCrawlerState<'DatabaseName, 'Name, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#description-1">GlueCrawler#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: GlueCrawlerState<'DatabaseName, 'Name, 'Role>, value: string) : GlueCrawlerState<'DatabaseName, 'Name, 'Role> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : GlueCrawlerState<'DatabaseName, 'Name, 'Role>

        /// <summary>
        /// dynamodb_target block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#dynamodb_target-1">GlueCrawler#dynamodb_target</a> Accepts: aws.IResolvable | aws.GlueCrawler.GlueCrawlerDynamodbTarget[]
        /// </summary>
        [<CustomOperation "dynamodb_target">]
        member _.DynamodbTarget(state: GlueCrawlerState<'DatabaseName, 'Name, 'Role>, value: HashiCorp.Cdktf.IResolvable) : GlueCrawlerState<'DatabaseName, 'Name, 'Role> =
            state.assignments.Add(fun config -> config.DynamodbTarget <- value)
            state : GlueCrawlerState<'DatabaseName, 'Name, 'Role>

        /// <summary>
        /// hudi_target block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#hudi_target-1">GlueCrawler#hudi_target</a> Accepts: aws.IResolvable | aws.GlueCrawler.GlueCrawlerHudiTarget[]
        /// </summary>
        [<CustomOperation "hudi_target">]
        member _.HudiTarget(state: GlueCrawlerState<'DatabaseName, 'Name, 'Role>, value: HashiCorp.Cdktf.IResolvable) : GlueCrawlerState<'DatabaseName, 'Name, 'Role> =
            state.assignments.Add(fun config -> config.HudiTarget <- value)
            state : GlueCrawlerState<'DatabaseName, 'Name, 'Role>

        /// <summary>
        /// iceberg_target block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#iceberg_target-1">GlueCrawler#iceberg_target</a> Accepts: aws.IResolvable | aws.GlueCrawler.GlueCrawlerIcebergTarget[]
        /// </summary>
        [<CustomOperation "iceberg_target">]
        member _.IcebergTarget(state: GlueCrawlerState<'DatabaseName, 'Name, 'Role>, value: HashiCorp.Cdktf.IResolvable) : GlueCrawlerState<'DatabaseName, 'Name, 'Role> =
            state.assignments.Add(fun config -> config.IcebergTarget <- value)
            state : GlueCrawlerState<'DatabaseName, 'Name, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#id-1">GlueCrawler#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GlueCrawlerState<'DatabaseName, 'Name, 'Role>, value: string) : GlueCrawlerState<'DatabaseName, 'Name, 'Role> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GlueCrawlerState<'DatabaseName, 'Name, 'Role>

        /// <summary>
        /// jdbc_target block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#jdbc_target-1">GlueCrawler#jdbc_target</a> Accepts: aws.IResolvable | aws.GlueCrawler.GlueCrawlerJdbcTarget[]
        /// </summary>
        [<CustomOperation "jdbc_target">]
        member _.JdbcTarget(state: GlueCrawlerState<'DatabaseName, 'Name, 'Role>, value: HashiCorp.Cdktf.IResolvable) : GlueCrawlerState<'DatabaseName, 'Name, 'Role> =
            state.assignments.Add(fun config -> config.JdbcTarget <- value)
            state : GlueCrawlerState<'DatabaseName, 'Name, 'Role>

        /// <summary>
        /// lake_formation_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#lake_formation_configuration-1">GlueCrawler#lake_formation_configuration</a>
        /// </summary>
        [<CustomOperation "lake_formation_configuration">]
        member _.LakeFormationConfiguration(state: GlueCrawlerState<'DatabaseName, 'Name, 'Role>, value: aws.GlueCrawler.GlueCrawlerLakeFormationConfiguration) : GlueCrawlerState<'DatabaseName, 'Name, 'Role> =
            state.assignments.Add(fun config -> config.LakeFormationConfiguration <- value)
            state : GlueCrawlerState<'DatabaseName, 'Name, 'Role>

        /// <summary>
        /// lineage_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#lineage_configuration-1">GlueCrawler#lineage_configuration</a>
        /// </summary>
        [<CustomOperation "lineage_configuration">]
        member _.LineageConfiguration(state: GlueCrawlerState<'DatabaseName, 'Name, 'Role>, value: aws.GlueCrawler.GlueCrawlerLineageConfiguration) : GlueCrawlerState<'DatabaseName, 'Name, 'Role> =
            state.assignments.Add(fun config -> config.LineageConfiguration <- value)
            state : GlueCrawlerState<'DatabaseName, 'Name, 'Role>

        /// <summary>
        /// mongodb_target block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#mongodb_target-1">GlueCrawler#mongodb_target</a> Accepts: aws.IResolvable | aws.GlueCrawler.GlueCrawlerMongodbTarget[]
        /// </summary>
        [<CustomOperation "mongodb_target">]
        member _.MongodbTarget(state: GlueCrawlerState<'DatabaseName, 'Name, 'Role>, value: HashiCorp.Cdktf.IResolvable) : GlueCrawlerState<'DatabaseName, 'Name, 'Role> =
            state.assignments.Add(fun config -> config.MongodbTarget <- value)
            state : GlueCrawlerState<'DatabaseName, 'Name, 'Role>

        /// <summary>
        /// recrawl_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#recrawl_policy-1">GlueCrawler#recrawl_policy</a>
        /// </summary>
        [<CustomOperation "recrawl_policy">]
        member _.RecrawlPolicy(state: GlueCrawlerState<'DatabaseName, 'Name, 'Role>, value: aws.GlueCrawler.GlueCrawlerRecrawlPolicy) : GlueCrawlerState<'DatabaseName, 'Name, 'Role> =
            state.assignments.Add(fun config -> config.RecrawlPolicy <- value)
            state : GlueCrawlerState<'DatabaseName, 'Name, 'Role>

        /// <summary>
        /// s3_target block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#s3_target-1">GlueCrawler#s3_target</a> Accepts: aws.IResolvable | aws.GlueCrawler.GlueCrawlerS3Target[]
        /// </summary>
        [<CustomOperation "s3_target">]
        member _.S3Target(state: GlueCrawlerState<'DatabaseName, 'Name, 'Role>, value: HashiCorp.Cdktf.IResolvable) : GlueCrawlerState<'DatabaseName, 'Name, 'Role> =
            state.assignments.Add(fun config -> config.S3Target <- value)
            state : GlueCrawlerState<'DatabaseName, 'Name, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#schedule-1">GlueCrawler#schedule</a>.
        /// </summary>
        [<CustomOperation "schedule">]
        member _.Schedule(state: GlueCrawlerState<'DatabaseName, 'Name, 'Role>, value: string) : GlueCrawlerState<'DatabaseName, 'Name, 'Role> =
            state.assignments.Add(fun config -> config.Schedule <- value)
            state : GlueCrawlerState<'DatabaseName, 'Name, 'Role>

        /// <summary>
        /// schema_change_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#schema_change_policy-1">GlueCrawler#schema_change_policy</a>
        /// </summary>
        [<CustomOperation "schema_change_policy">]
        member _.SchemaChangePolicy(state: GlueCrawlerState<'DatabaseName, 'Name, 'Role>, value: aws.GlueCrawler.GlueCrawlerSchemaChangePolicy) : GlueCrawlerState<'DatabaseName, 'Name, 'Role> =
            state.assignments.Add(fun config -> config.SchemaChangePolicy <- value)
            state : GlueCrawlerState<'DatabaseName, 'Name, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#security_configuration-1">GlueCrawler#security_configuration</a>.
        /// </summary>
        [<CustomOperation "security_configuration">]
        member _.SecurityConfiguration(state: GlueCrawlerState<'DatabaseName, 'Name, 'Role>, value: string) : GlueCrawlerState<'DatabaseName, 'Name, 'Role> =
            state.assignments.Add(fun config -> config.SecurityConfiguration <- value)
            state : GlueCrawlerState<'DatabaseName, 'Name, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#table_prefix-1">GlueCrawler#table_prefix</a>.
        /// </summary>
        [<CustomOperation "table_prefix">]
        member _.TablePrefix(state: GlueCrawlerState<'DatabaseName, 'Name, 'Role>, value: string) : GlueCrawlerState<'DatabaseName, 'Name, 'Role> =
            state.assignments.Add(fun config -> config.TablePrefix <- value)
            state : GlueCrawlerState<'DatabaseName, 'Name, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#tags-1">GlueCrawler#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GlueCrawlerState<'DatabaseName, 'Name, 'Role>, value: seq<string * string>) : GlueCrawlerState<'DatabaseName, 'Name, 'Role> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GlueCrawlerState<'DatabaseName, 'Name, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#tags_all-1">GlueCrawler#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: GlueCrawlerState<'DatabaseName, 'Name, 'Role>, value: seq<string * string>) : GlueCrawlerState<'DatabaseName, 'Name, 'Role> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : GlueCrawlerState<'DatabaseName, 'Name, 'Role>

        member _.Run(state: GlueCrawlerState<Present, Present, Present>) : aws.GlueCrawler.GlueCrawler =
            let config = aws.GlueCrawler.GlueCrawlerConfig()
            for setter in state.assignments do
                setter config
            aws.GlueCrawler.GlueCrawler(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.glueCrawler: missing required arguments. Must call: database_name, name, role.", 9999, IsError = true)>]
        member _.Run(_: GlueCrawlerState<_, _, _>) : aws.GlueCrawler.GlueCrawler =
            Unchecked.defaultof<aws.GlueCrawler.GlueCrawler>
