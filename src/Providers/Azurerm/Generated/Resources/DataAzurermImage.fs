namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermImageState<'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermImage.DataAzurermImageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/image">azurerm_image</a>.
    /// </summary>
    type DataAzurermImageBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermImageState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermImageState<Missing>)

        member _.Zero(()) : DataAzurermImageState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermImageState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/image#resource_group_name-1">DataAzurermImage#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermImageState<Missing>, value: string) : DataAzurermImageState<Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermImageState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/image#id-1">DataAzurermImage#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermImageState<'ResourceGroupName>, value: string) : DataAzurermImageState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermImageState<'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/image#name-1">DataAzurermImage#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermImageState<'ResourceGroupName>, value: string) : DataAzurermImageState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAzurermImageState<'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/image#name_regex-1">DataAzurermImage#name_regex</a>.
        /// </summary>
        [<CustomOperation "name_regex">]
        member _.NameRegex(state: DataAzurermImageState<'ResourceGroupName>, value: string) : DataAzurermImageState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NameRegex <- value)
            state : DataAzurermImageState<'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/image#sort_descending-1">DataAzurermImage#sort_descending</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "sort_descending">]
        member _.SortDescending(state: DataAzurermImageState<'ResourceGroupName>, value: bool) : DataAzurermImageState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SortDescending <- value)
            state : DataAzurermImageState<'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/image#sort_descending-1">DataAzurermImage#sort_descending</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "sort_descending">]
        member _.SortDescending(state: DataAzurermImageState<'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : DataAzurermImageState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SortDescending <- value)
            state : DataAzurermImageState<'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/image#timeouts-1">DataAzurermImage#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermImageState<'ResourceGroupName>, value: azurerm.DataAzurermImage.DataAzurermImageTimeouts) : DataAzurermImageState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermImageState<'ResourceGroupName>

        member _.Run(state: DataAzurermImageState<Present>) : azurerm.DataAzurermImage.DataAzurermImage =
            let config = azurerm.DataAzurermImage.DataAzurermImageConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermImage.DataAzurermImage(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermImage: missing required arguments. Must call: resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermImageState<_>) : azurerm.DataAzurermImage.DataAzurermImage =
            Unchecked.defaultof<azurerm.DataAzurermImage.DataAzurermImage>
