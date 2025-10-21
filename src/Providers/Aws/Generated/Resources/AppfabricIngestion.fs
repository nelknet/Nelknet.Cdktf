namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppfabricIngestionState<'App, 'AppBundleArn, 'IngestionType, 'TenantId> = { assignments: ResizeArray<aws.AppfabricIngestion.AppfabricIngestionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion">aws_appfabric_ingestion</a>.
    /// </summary>
    type AppfabricIngestionBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppfabricIngestionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppfabricIngestionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AppfabricIngestionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppfabricIngestionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion#app-1">AppfabricIngestion#app</a>.
        /// </summary>
        [<CustomOperation "app">]
        member _.App(state: AppfabricIngestionState<Missing, 'AppBundleArn, 'IngestionType, 'TenantId>, value: string) : AppfabricIngestionState<Present, 'AppBundleArn, 'IngestionType, 'TenantId> =
            state.assignments.Add(fun config -> config.App <- value)
            ({ assignments = state.assignments } : AppfabricIngestionState<Present, 'AppBundleArn, 'IngestionType, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion#app_bundle_arn-1">AppfabricIngestion#app_bundle_arn</a>.
        /// </summary>
        [<CustomOperation "app_bundle_arn">]
        member _.AppBundleArn(state: AppfabricIngestionState<'App, Missing, 'IngestionType, 'TenantId>, value: string) : AppfabricIngestionState<'App, Present, 'IngestionType, 'TenantId> =
            state.assignments.Add(fun config -> config.AppBundleArn <- value)
            ({ assignments = state.assignments } : AppfabricIngestionState<'App, Present, 'IngestionType, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion#ingestion_type-1">AppfabricIngestion#ingestion_type</a>.
        /// </summary>
        [<CustomOperation "ingestion_type">]
        member _.IngestionType(state: AppfabricIngestionState<'App, 'AppBundleArn, Missing, 'TenantId>, value: string) : AppfabricIngestionState<'App, 'AppBundleArn, Present, 'TenantId> =
            state.assignments.Add(fun config -> config.IngestionType <- value)
            ({ assignments = state.assignments } : AppfabricIngestionState<'App, 'AppBundleArn, Present, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion#tenant_id-1">AppfabricIngestion#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: AppfabricIngestionState<'App, 'AppBundleArn, 'IngestionType, Missing>, value: string) : AppfabricIngestionState<'App, 'AppBundleArn, 'IngestionType, Present> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            ({ assignments = state.assignments } : AppfabricIngestionState<'App, 'AppBundleArn, 'IngestionType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion#tags-1">AppfabricIngestion#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppfabricIngestionState<'App, 'AppBundleArn, 'IngestionType, 'TenantId>, value: seq<string * string>) : AppfabricIngestionState<'App, 'AppBundleArn, 'IngestionType, 'TenantId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppfabricIngestionState<'App, 'AppBundleArn, 'IngestionType, 'TenantId>

        member _.Run(state: AppfabricIngestionState<Present, Present, Present, Present>) : aws.AppfabricIngestion.AppfabricIngestion =
            let config = aws.AppfabricIngestion.AppfabricIngestionConfig()
            for setter in state.assignments do
                setter config
            aws.AppfabricIngestion.AppfabricIngestion(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appfabricIngestion: missing required arguments. Must call: app, app_bundle_arn, ingestion_type, tenant_id.", 9999, IsError = true)>]
        member _.Run(_: AppfabricIngestionState<_, _, _, _>) : aws.AppfabricIngestion.AppfabricIngestion =
            Unchecked.defaultof<aws.AppfabricIngestion.AppfabricIngestion>
