namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppfabricIngestionDestinationState<'AppBundleArn, 'IngestionArn> = { assignments: ResizeArray<aws.AppfabricIngestionDestination.AppfabricIngestionDestinationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion_destination">aws_appfabric_ingestion_destination</a>.
    /// </summary>
    type AppfabricIngestionDestinationBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppfabricIngestionDestinationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppfabricIngestionDestinationState<Missing, Missing>)

        member _.Zero(()) : AppfabricIngestionDestinationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppfabricIngestionDestinationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion_destination#app_bundle_arn-1">AppfabricIngestionDestination#app_bundle_arn</a>.
        /// </summary>
        [<CustomOperation "app_bundle_arn">]
        member _.AppBundleArn(state: AppfabricIngestionDestinationState<Missing, 'IngestionArn>, value: string) : AppfabricIngestionDestinationState<Present, 'IngestionArn> =
            state.assignments.Add(fun config -> config.AppBundleArn <- value)
            ({ assignments = state.assignments } : AppfabricIngestionDestinationState<Present, 'IngestionArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion_destination#ingestion_arn-1">AppfabricIngestionDestination#ingestion_arn</a>.
        /// </summary>
        [<CustomOperation "ingestion_arn">]
        member _.IngestionArn(state: AppfabricIngestionDestinationState<'AppBundleArn, Missing>, value: string) : AppfabricIngestionDestinationState<'AppBundleArn, Present> =
            state.assignments.Add(fun config -> config.IngestionArn <- value)
            ({ assignments = state.assignments } : AppfabricIngestionDestinationState<'AppBundleArn, Present>)

        /// <summary>
        /// destination_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion_destination#destination_configuration-1">AppfabricIngestionDestination#destination_configuration</a> Accepts: aws.IResolvable | aws.AppfabricIngestionDestination.AppfabricIngestionDestinationDestinationConfiguration[]
        /// </summary>
        [<CustomOperation "destination_configuration">]
        member _.DestinationConfiguration(state: AppfabricIngestionDestinationState<'AppBundleArn, 'IngestionArn>, value: HashiCorp.Cdktf.IResolvable) : AppfabricIngestionDestinationState<'AppBundleArn, 'IngestionArn> =
            state.assignments.Add(fun config -> config.DestinationConfiguration <- value)
            state : AppfabricIngestionDestinationState<'AppBundleArn, 'IngestionArn>

        /// <summary>
        /// processing_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion_destination#processing_configuration-1">AppfabricIngestionDestination#processing_configuration</a> Accepts: aws.IResolvable | aws.AppfabricIngestionDestination.AppfabricIngestionDestinationProcessingConfiguration[]
        /// </summary>
        [<CustomOperation "processing_configuration">]
        member _.ProcessingConfiguration(state: AppfabricIngestionDestinationState<'AppBundleArn, 'IngestionArn>, value: HashiCorp.Cdktf.IResolvable) : AppfabricIngestionDestinationState<'AppBundleArn, 'IngestionArn> =
            state.assignments.Add(fun config -> config.ProcessingConfiguration <- value)
            state : AppfabricIngestionDestinationState<'AppBundleArn, 'IngestionArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion_destination#tags-1">AppfabricIngestionDestination#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppfabricIngestionDestinationState<'AppBundleArn, 'IngestionArn>, value: seq<string * string>) : AppfabricIngestionDestinationState<'AppBundleArn, 'IngestionArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppfabricIngestionDestinationState<'AppBundleArn, 'IngestionArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion_destination#timeouts-1">AppfabricIngestionDestination#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AppfabricIngestionDestinationState<'AppBundleArn, 'IngestionArn>, value: aws.AppfabricIngestionDestination.AppfabricIngestionDestinationTimeouts) : AppfabricIngestionDestinationState<'AppBundleArn, 'IngestionArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AppfabricIngestionDestinationState<'AppBundleArn, 'IngestionArn>

        member _.Run(state: AppfabricIngestionDestinationState<Present, Present>) : aws.AppfabricIngestionDestination.AppfabricIngestionDestination =
            let config = aws.AppfabricIngestionDestination.AppfabricIngestionDestinationConfig()
            for setter in state.assignments do
                setter config
            aws.AppfabricIngestionDestination.AppfabricIngestionDestination(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appfabricIngestionDestination: missing required arguments. Must call: app_bundle_arn, ingestion_arn.", 9999, IsError = true)>]
        member _.Run(_: AppfabricIngestionDestinationState<_, _>) : aws.AppfabricIngestionDestination.AppfabricIngestionDestination =
            Unchecked.defaultof<aws.AppfabricIngestionDestination.AppfabricIngestionDestination>
