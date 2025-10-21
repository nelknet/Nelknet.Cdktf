namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsServicecatalogProvisioningArtifactsState<'ProductId> = { assignments: ResizeArray<aws.DataAwsServicecatalogProvisioningArtifacts.DataAwsServicecatalogProvisioningArtifactsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_provisioning_artifacts">aws_servicecatalog_provisioning_artifacts</a>.
    /// </summary>
    type DataAwsServicecatalogProvisioningArtifactsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsServicecatalogProvisioningArtifactsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsServicecatalogProvisioningArtifactsState<Missing>)

        member _.Zero(()) : DataAwsServicecatalogProvisioningArtifactsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsServicecatalogProvisioningArtifactsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_provisioning_artifacts#product_id-1">DataAwsServicecatalogProvisioningArtifacts#product_id</a>.
        /// </summary>
        [<CustomOperation "product_id">]
        member _.ProductId(state: DataAwsServicecatalogProvisioningArtifactsState<Missing>, value: string) : DataAwsServicecatalogProvisioningArtifactsState<Present> =
            state.assignments.Add(fun config -> config.ProductId <- value)
            ({ assignments = state.assignments } : DataAwsServicecatalogProvisioningArtifactsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_provisioning_artifacts#accept_language-1">DataAwsServicecatalogProvisioningArtifacts#accept_language</a>.
        /// </summary>
        [<CustomOperation "accept_language">]
        member _.AcceptLanguage(state: DataAwsServicecatalogProvisioningArtifactsState<'ProductId>, value: string) : DataAwsServicecatalogProvisioningArtifactsState<'ProductId> =
            state.assignments.Add(fun config -> config.AcceptLanguage <- value)
            state : DataAwsServicecatalogProvisioningArtifactsState<'ProductId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_provisioning_artifacts#id-1">DataAwsServicecatalogProvisioningArtifacts#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsServicecatalogProvisioningArtifactsState<'ProductId>, value: string) : DataAwsServicecatalogProvisioningArtifactsState<'ProductId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsServicecatalogProvisioningArtifactsState<'ProductId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_provisioning_artifacts#timeouts-1">DataAwsServicecatalogProvisioningArtifacts#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsServicecatalogProvisioningArtifactsState<'ProductId>, value: aws.DataAwsServicecatalogProvisioningArtifacts.DataAwsServicecatalogProvisioningArtifactsTimeouts) : DataAwsServicecatalogProvisioningArtifactsState<'ProductId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsServicecatalogProvisioningArtifactsState<'ProductId>

        member _.Run(state: DataAwsServicecatalogProvisioningArtifactsState<Present>) : aws.DataAwsServicecatalogProvisioningArtifacts.DataAwsServicecatalogProvisioningArtifacts =
            let config = aws.DataAwsServicecatalogProvisioningArtifacts.DataAwsServicecatalogProvisioningArtifactsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsServicecatalogProvisioningArtifacts.DataAwsServicecatalogProvisioningArtifacts(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsServicecatalogProvisioningArtifacts: missing required arguments. Must call: product_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsServicecatalogProvisioningArtifactsState<_>) : aws.DataAwsServicecatalogProvisioningArtifacts.DataAwsServicecatalogProvisioningArtifacts =
            Unchecked.defaultof<aws.DataAwsServicecatalogProvisioningArtifacts.DataAwsServicecatalogProvisioningArtifacts>
