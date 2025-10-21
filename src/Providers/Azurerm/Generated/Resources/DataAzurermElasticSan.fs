namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermElasticSanState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermElasticSan.DataAzurermElasticSanConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_san">azurerm_elastic_san</a>.
    /// </summary>
    type DataAzurermElasticSanBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermElasticSanState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermElasticSanState<Missing, Missing>)

        member _.Zero(()) : DataAzurermElasticSanState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermElasticSanState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_san#name-1">DataAzurermElasticSan#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermElasticSanState<Missing, 'ResourceGroupName>, value: string) : DataAzurermElasticSanState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermElasticSanState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_san#resource_group_name-1">DataAzurermElasticSan#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermElasticSanState<'Name, Missing>, value: string) : DataAzurermElasticSanState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermElasticSanState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_san#id-1">DataAzurermElasticSan#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermElasticSanState<'Name, 'ResourceGroupName>, value: string) : DataAzurermElasticSanState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermElasticSanState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_san#timeouts-1">DataAzurermElasticSan#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermElasticSanState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermElasticSan.DataAzurermElasticSanTimeouts) : DataAzurermElasticSanState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermElasticSanState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermElasticSanState<Present, Present>) : azurerm.DataAzurermElasticSan.DataAzurermElasticSan =
            let config = azurerm.DataAzurermElasticSan.DataAzurermElasticSanConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermElasticSan.DataAzurermElasticSan(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermElasticSan: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermElasticSanState<_, _>) : azurerm.DataAzurermElasticSan.DataAzurermElasticSan =
            Unchecked.defaultof<azurerm.DataAzurermElasticSan.DataAzurermElasticSan>
