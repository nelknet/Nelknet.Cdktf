namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermWebPubsubPrivateLinkResourceState<'WebPubsubId> = { assignments: ResizeArray<azurerm.DataAzurermWebPubsubPrivateLinkResource.DataAzurermWebPubsubPrivateLinkResourceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/web_pubsub_private_link_resource">azurerm_web_pubsub_private_link_resource</a>.
    /// </summary>
    type DataAzurermWebPubsubPrivateLinkResourceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermWebPubsubPrivateLinkResourceState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermWebPubsubPrivateLinkResourceState<Missing>)

        member _.Zero(()) : DataAzurermWebPubsubPrivateLinkResourceState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermWebPubsubPrivateLinkResourceState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/web_pubsub_private_link_resource#web_pubsub_id-1">DataAzurermWebPubsubPrivateLinkResource#web_pubsub_id</a>.
        /// </summary>
        [<CustomOperation "web_pubsub_id">]
        member _.WebPubsubId(state: DataAzurermWebPubsubPrivateLinkResourceState<Missing>, value: string) : DataAzurermWebPubsubPrivateLinkResourceState<Present> =
            state.assignments.Add(fun config -> config.WebPubsubId <- value)
            ({ assignments = state.assignments } : DataAzurermWebPubsubPrivateLinkResourceState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/web_pubsub_private_link_resource#id-1">DataAzurermWebPubsubPrivateLinkResource#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermWebPubsubPrivateLinkResourceState<'WebPubsubId>, value: string) : DataAzurermWebPubsubPrivateLinkResourceState<'WebPubsubId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermWebPubsubPrivateLinkResourceState<'WebPubsubId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/web_pubsub_private_link_resource#timeouts-1">DataAzurermWebPubsubPrivateLinkResource#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermWebPubsubPrivateLinkResourceState<'WebPubsubId>, value: azurerm.DataAzurermWebPubsubPrivateLinkResource.DataAzurermWebPubsubPrivateLinkResourceTimeouts) : DataAzurermWebPubsubPrivateLinkResourceState<'WebPubsubId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermWebPubsubPrivateLinkResourceState<'WebPubsubId>

        member _.Run(state: DataAzurermWebPubsubPrivateLinkResourceState<Present>) : azurerm.DataAzurermWebPubsubPrivateLinkResource.DataAzurermWebPubsubPrivateLinkResource =
            let config = azurerm.DataAzurermWebPubsubPrivateLinkResource.DataAzurermWebPubsubPrivateLinkResourceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermWebPubsubPrivateLinkResource.DataAzurermWebPubsubPrivateLinkResource(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermWebPubsubPrivateLinkResource: missing required arguments. Must call: web_pubsub_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermWebPubsubPrivateLinkResourceState<_>) : azurerm.DataAzurermWebPubsubPrivateLinkResource.DataAzurermWebPubsubPrivateLinkResource =
            Unchecked.defaultof<azurerm.DataAzurermWebPubsubPrivateLinkResource.DataAzurermWebPubsubPrivateLinkResource>
