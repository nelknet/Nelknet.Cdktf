namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GlueCatalogTableOptimizerState<'CatalogId, 'DatabaseName, 'TableName, 'Type> = { assignments: ResizeArray<aws.GlueCatalogTableOptimizer.GlueCatalogTableOptimizerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table_optimizer">aws_glue_catalog_table_optimizer</a>.
    /// </summary>
    type GlueCatalogTableOptimizerBuilder(logicalId: string) =
        member _.Yield(_: unit) : GlueCatalogTableOptimizerState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GlueCatalogTableOptimizerState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : GlueCatalogTableOptimizerState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GlueCatalogTableOptimizerState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table_optimizer#catalog_id-1">GlueCatalogTableOptimizer#catalog_id</a>.
        /// </summary>
        [<CustomOperation "catalog_id">]
        member _.CatalogId(state: GlueCatalogTableOptimizerState<Missing, 'DatabaseName, 'TableName, 'Type>, value: string) : GlueCatalogTableOptimizerState<Present, 'DatabaseName, 'TableName, 'Type> =
            state.assignments.Add(fun config -> config.CatalogId <- value)
            ({ assignments = state.assignments } : GlueCatalogTableOptimizerState<Present, 'DatabaseName, 'TableName, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table_optimizer#database_name-1">GlueCatalogTableOptimizer#database_name</a>.
        /// </summary>
        [<CustomOperation "database_name">]
        member _.DatabaseName(state: GlueCatalogTableOptimizerState<'CatalogId, Missing, 'TableName, 'Type>, value: string) : GlueCatalogTableOptimizerState<'CatalogId, Present, 'TableName, 'Type> =
            state.assignments.Add(fun config -> config.DatabaseName <- value)
            ({ assignments = state.assignments } : GlueCatalogTableOptimizerState<'CatalogId, Present, 'TableName, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table_optimizer#table_name-1">GlueCatalogTableOptimizer#table_name</a>.
        /// </summary>
        [<CustomOperation "table_name">]
        member _.TableName(state: GlueCatalogTableOptimizerState<'CatalogId, 'DatabaseName, Missing, 'Type>, value: string) : GlueCatalogTableOptimizerState<'CatalogId, 'DatabaseName, Present, 'Type> =
            state.assignments.Add(fun config -> config.TableName <- value)
            ({ assignments = state.assignments } : GlueCatalogTableOptimizerState<'CatalogId, 'DatabaseName, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table_optimizer#type-1">GlueCatalogTableOptimizer#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: GlueCatalogTableOptimizerState<'CatalogId, 'DatabaseName, 'TableName, Missing>, value: string) : GlueCatalogTableOptimizerState<'CatalogId, 'DatabaseName, 'TableName, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : GlueCatalogTableOptimizerState<'CatalogId, 'DatabaseName, 'TableName, Present>)

        /// <summary>
        /// configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_catalog_table_optimizer#configuration-1">GlueCatalogTableOptimizer#configuration</a> Accepts: aws.IResolvable | aws.GlueCatalogTableOptimizer.GlueCatalogTableOptimizerConfiguration[]
        /// </summary>
        [<CustomOperation "configuration">]
        member _.Configuration(state: GlueCatalogTableOptimizerState<'CatalogId, 'DatabaseName, 'TableName, 'Type>, value: HashiCorp.Cdktf.IResolvable) : GlueCatalogTableOptimizerState<'CatalogId, 'DatabaseName, 'TableName, 'Type> =
            state.assignments.Add(fun config -> config.Configuration <- value)
            state : GlueCatalogTableOptimizerState<'CatalogId, 'DatabaseName, 'TableName, 'Type>

        member _.Run(state: GlueCatalogTableOptimizerState<Present, Present, Present, Present>) : aws.GlueCatalogTableOptimizer.GlueCatalogTableOptimizer =
            let config = aws.GlueCatalogTableOptimizer.GlueCatalogTableOptimizerConfig()
            for setter in state.assignments do
                setter config
            aws.GlueCatalogTableOptimizer.GlueCatalogTableOptimizer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.glueCatalogTableOptimizer: missing required arguments. Must call: catalog_id, database_name, table_name, type.", 9999, IsError = true)>]
        member _.Run(_: GlueCatalogTableOptimizerState<_, _, _, _>) : aws.GlueCatalogTableOptimizer.GlueCatalogTableOptimizer =
            Unchecked.defaultof<aws.GlueCatalogTableOptimizer.GlueCatalogTableOptimizer>
