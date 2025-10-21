namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ElasticSanState<'BaseSizeInTib, 'Location, 'Name, 'ResourceGroupName, 'Sku> = { assignments: ResizeArray<azurerm.ElasticSan.ElasticSanConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san">azurerm_elastic_san</a>.
    /// </summary>
    type ElasticSanBuilder(logicalId: string) =
        member _.Yield(_: unit) : ElasticSanState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticSanState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ElasticSanState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticSanState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san#base_size_in_tib-1">ElasticSan#base_size_in_tib</a>.
        /// </summary>
        [<CustomOperation "base_size_in_tib">]
        member _.BaseSizeInTib(state: ElasticSanState<Missing, 'Location, 'Name, 'ResourceGroupName, 'Sku>, value: double) : ElasticSanState<Present, 'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.BaseSizeInTib <- value)
            ({ assignments = state.assignments } : ElasticSanState<Present, 'Location, 'Name, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san#location-1">ElasticSan#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ElasticSanState<'BaseSizeInTib, Missing, 'Name, 'ResourceGroupName, 'Sku>, value: string) : ElasticSanState<'BaseSizeInTib, Present, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ElasticSanState<'BaseSizeInTib, Present, 'Name, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san#name-1">ElasticSan#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ElasticSanState<'BaseSizeInTib, 'Location, Missing, 'ResourceGroupName, 'Sku>, value: string) : ElasticSanState<'BaseSizeInTib, 'Location, Present, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ElasticSanState<'BaseSizeInTib, 'Location, Present, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san#resource_group_name-1">ElasticSan#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ElasticSanState<'BaseSizeInTib, 'Location, 'Name, Missing, 'Sku>, value: string) : ElasticSanState<'BaseSizeInTib, 'Location, 'Name, Present, 'Sku> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ElasticSanState<'BaseSizeInTib, 'Location, 'Name, Present, 'Sku>)

        /// <summary>
        /// sku block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san#sku-1">ElasticSan#sku</a>
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: ElasticSanState<'BaseSizeInTib, 'Location, 'Name, 'ResourceGroupName, Missing>, value: azurerm.ElasticSan.ElasticSanSku) : ElasticSanState<'BaseSizeInTib, 'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : ElasticSanState<'BaseSizeInTib, 'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san#extended_size_in_tib-1">ElasticSan#extended_size_in_tib</a>.
        /// </summary>
        [<CustomOperation "extended_size_in_tib">]
        member _.ExtendedSizeInTib(state: ElasticSanState<'BaseSizeInTib, 'Location, 'Name, 'ResourceGroupName, 'Sku>, value: double) : ElasticSanState<'BaseSizeInTib, 'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ExtendedSizeInTib <- value)
            state : ElasticSanState<'BaseSizeInTib, 'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san#id-1">ElasticSan#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ElasticSanState<'BaseSizeInTib, 'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : ElasticSanState<'BaseSizeInTib, 'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ElasticSanState<'BaseSizeInTib, 'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san#tags-1">ElasticSan#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ElasticSanState<'BaseSizeInTib, 'Location, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string * string>) : ElasticSanState<'BaseSizeInTib, 'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ElasticSanState<'BaseSizeInTib, 'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san#timeouts-1">ElasticSan#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ElasticSanState<'BaseSizeInTib, 'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.ElasticSan.ElasticSanTimeouts) : ElasticSanState<'BaseSizeInTib, 'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ElasticSanState<'BaseSizeInTib, 'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san#zones-1">ElasticSan#zones</a>.
        /// </summary>
        [<CustomOperation "zones">]
        member _.Zones(state: ElasticSanState<'BaseSizeInTib, 'Location, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string>) : ElasticSanState<'BaseSizeInTib, 'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Zones <- (value |> Seq.toArray))
            state : ElasticSanState<'BaseSizeInTib, 'Location, 'Name, 'ResourceGroupName, 'Sku>

        member _.Run(state: ElasticSanState<Present, Present, Present, Present, Present>) : azurerm.ElasticSan.ElasticSan =
            let config = azurerm.ElasticSan.ElasticSanConfig()
            for setter in state.assignments do
                setter config
            azurerm.ElasticSan.ElasticSan(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.elasticSan: missing required arguments. Must call: base_size_in_tib, location, name, resource_group_name, sku.", 9999, IsError = true)>]
        member _.Run(_: ElasticSanState<_, _, _, _, _>) : azurerm.ElasticSan.ElasticSan =
            Unchecked.defaultof<azurerm.ElasticSan.ElasticSan>
