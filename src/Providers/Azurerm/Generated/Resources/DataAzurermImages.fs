namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermImagesState<'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermImages.DataAzurermImagesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/images">azurerm_images</a>.
    /// </summary>
    type DataAzurermImagesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermImagesState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermImagesState<Missing>)

        member _.Zero(()) : DataAzurermImagesState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermImagesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/images#resource_group_name-1">DataAzurermImages#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermImagesState<Missing>, value: string) : DataAzurermImagesState<Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermImagesState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/images#id-1">DataAzurermImages#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermImagesState<'ResourceGroupName>, value: string) : DataAzurermImagesState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermImagesState<'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/images#tags_filter-1">DataAzurermImages#tags_filter</a>.
        /// </summary>
        [<CustomOperation "tags_filter">]
        member _.TagsFilter(state: DataAzurermImagesState<'ResourceGroupName>, value: seq<string * string>) : DataAzurermImagesState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.TagsFilter <- dict value)
            state : DataAzurermImagesState<'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/images#timeouts-1">DataAzurermImages#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermImagesState<'ResourceGroupName>, value: azurerm.DataAzurermImages.DataAzurermImagesTimeouts) : DataAzurermImagesState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermImagesState<'ResourceGroupName>

        member _.Run(state: DataAzurermImagesState<Present>) : azurerm.DataAzurermImages.DataAzurermImages =
            let config = azurerm.DataAzurermImages.DataAzurermImagesConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermImages.DataAzurermImages(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermImages: missing required arguments. Must call: resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermImagesState<_>) : azurerm.DataAzurermImages.DataAzurermImages =
            Unchecked.defaultof<azurerm.DataAzurermImages.DataAzurermImages>
