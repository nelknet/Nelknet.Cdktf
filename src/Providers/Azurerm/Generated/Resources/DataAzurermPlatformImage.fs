namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPlatformImageState<'Location, 'Offer, 'Publisher, 'Sku> = { assignments: ResizeArray<azurerm.DataAzurermPlatformImage.DataAzurermPlatformImageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/platform_image">azurerm_platform_image</a>.
    /// </summary>
    type DataAzurermPlatformImageBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPlatformImageState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPlatformImageState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermPlatformImageState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPlatformImageState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/platform_image#location-1">DataAzurermPlatformImage#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DataAzurermPlatformImageState<Missing, 'Offer, 'Publisher, 'Sku>, value: string) : DataAzurermPlatformImageState<Present, 'Offer, 'Publisher, 'Sku> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DataAzurermPlatformImageState<Present, 'Offer, 'Publisher, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/platform_image#offer-1">DataAzurermPlatformImage#offer</a>.
        /// </summary>
        [<CustomOperation "offer">]
        member _.Offer(state: DataAzurermPlatformImageState<'Location, Missing, 'Publisher, 'Sku>, value: string) : DataAzurermPlatformImageState<'Location, Present, 'Publisher, 'Sku> =
            state.assignments.Add(fun config -> config.Offer <- value)
            ({ assignments = state.assignments } : DataAzurermPlatformImageState<'Location, Present, 'Publisher, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/platform_image#publisher-1">DataAzurermPlatformImage#publisher</a>.
        /// </summary>
        [<CustomOperation "publisher">]
        member _.Publisher(state: DataAzurermPlatformImageState<'Location, 'Offer, Missing, 'Sku>, value: string) : DataAzurermPlatformImageState<'Location, 'Offer, Present, 'Sku> =
            state.assignments.Add(fun config -> config.Publisher <- value)
            ({ assignments = state.assignments } : DataAzurermPlatformImageState<'Location, 'Offer, Present, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/platform_image#sku-1">DataAzurermPlatformImage#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: DataAzurermPlatformImageState<'Location, 'Offer, 'Publisher, Missing>, value: string) : DataAzurermPlatformImageState<'Location, 'Offer, 'Publisher, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : DataAzurermPlatformImageState<'Location, 'Offer, 'Publisher, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/platform_image#id-1">DataAzurermPlatformImage#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPlatformImageState<'Location, 'Offer, 'Publisher, 'Sku>, value: string) : DataAzurermPlatformImageState<'Location, 'Offer, 'Publisher, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPlatformImageState<'Location, 'Offer, 'Publisher, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/platform_image#timeouts-1">DataAzurermPlatformImage#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPlatformImageState<'Location, 'Offer, 'Publisher, 'Sku>, value: azurerm.DataAzurermPlatformImage.DataAzurermPlatformImageTimeouts) : DataAzurermPlatformImageState<'Location, 'Offer, 'Publisher, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPlatformImageState<'Location, 'Offer, 'Publisher, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/platform_image#version-1">DataAzurermPlatformImage#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: DataAzurermPlatformImageState<'Location, 'Offer, 'Publisher, 'Sku>, value: string) : DataAzurermPlatformImageState<'Location, 'Offer, 'Publisher, 'Sku> =
            state.assignments.Add(fun config -> config.Version <- value)
            state : DataAzurermPlatformImageState<'Location, 'Offer, 'Publisher, 'Sku>

        member _.Run(state: DataAzurermPlatformImageState<Present, Present, Present, Present>) : azurerm.DataAzurermPlatformImage.DataAzurermPlatformImage =
            let config = azurerm.DataAzurermPlatformImage.DataAzurermPlatformImageConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPlatformImage.DataAzurermPlatformImage(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermPlatformImage: missing required arguments. Must call: location, offer, publisher, sku.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermPlatformImageState<_, _, _, _>) : azurerm.DataAzurermPlatformImage.DataAzurermPlatformImage =
            Unchecked.defaultof<azurerm.DataAzurermPlatformImage.DataAzurermPlatformImage>
