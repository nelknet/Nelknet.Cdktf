namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsServicecatalogLaunchPathsState<'ProductId> = { assignments: ResizeArray<aws.DataAwsServicecatalogLaunchPaths.DataAwsServicecatalogLaunchPathsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_launch_paths">aws_servicecatalog_launch_paths</a>.
    /// </summary>
    type DataAwsServicecatalogLaunchPathsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsServicecatalogLaunchPathsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsServicecatalogLaunchPathsState<Missing>)

        member _.Zero(()) : DataAwsServicecatalogLaunchPathsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsServicecatalogLaunchPathsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_launch_paths#product_id-1">DataAwsServicecatalogLaunchPaths#product_id</a>.
        /// </summary>
        [<CustomOperation "product_id">]
        member _.ProductId(state: DataAwsServicecatalogLaunchPathsState<Missing>, value: string) : DataAwsServicecatalogLaunchPathsState<Present> =
            state.assignments.Add(fun config -> config.ProductId <- value)
            ({ assignments = state.assignments } : DataAwsServicecatalogLaunchPathsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_launch_paths#accept_language-1">DataAwsServicecatalogLaunchPaths#accept_language</a>.
        /// </summary>
        [<CustomOperation "accept_language">]
        member _.AcceptLanguage(state: DataAwsServicecatalogLaunchPathsState<'ProductId>, value: string) : DataAwsServicecatalogLaunchPathsState<'ProductId> =
            state.assignments.Add(fun config -> config.AcceptLanguage <- value)
            state : DataAwsServicecatalogLaunchPathsState<'ProductId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_launch_paths#id-1">DataAwsServicecatalogLaunchPaths#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsServicecatalogLaunchPathsState<'ProductId>, value: string) : DataAwsServicecatalogLaunchPathsState<'ProductId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsServicecatalogLaunchPathsState<'ProductId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_launch_paths#timeouts-1">DataAwsServicecatalogLaunchPaths#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsServicecatalogLaunchPathsState<'ProductId>, value: aws.DataAwsServicecatalogLaunchPaths.DataAwsServicecatalogLaunchPathsTimeouts) : DataAwsServicecatalogLaunchPathsState<'ProductId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsServicecatalogLaunchPathsState<'ProductId>

        member _.Run(state: DataAwsServicecatalogLaunchPathsState<Present>) : aws.DataAwsServicecatalogLaunchPaths.DataAwsServicecatalogLaunchPaths =
            let config = aws.DataAwsServicecatalogLaunchPaths.DataAwsServicecatalogLaunchPathsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsServicecatalogLaunchPaths.DataAwsServicecatalogLaunchPaths(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsServicecatalogLaunchPaths: missing required arguments. Must call: product_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsServicecatalogLaunchPathsState<_>) : aws.DataAwsServicecatalogLaunchPaths.DataAwsServicecatalogLaunchPaths =
            Unchecked.defaultof<aws.DataAwsServicecatalogLaunchPaths.DataAwsServicecatalogLaunchPaths>
