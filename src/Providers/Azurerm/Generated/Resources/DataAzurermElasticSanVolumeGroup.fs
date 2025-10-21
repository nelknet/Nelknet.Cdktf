namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermElasticSanVolumeGroupState<'ElasticSanId, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermElasticSanVolumeGroup.DataAzurermElasticSanVolumeGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_san_volume_group">azurerm_elastic_san_volume_group</a>.
    /// </summary>
    type DataAzurermElasticSanVolumeGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermElasticSanVolumeGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermElasticSanVolumeGroupState<Missing, Missing>)

        member _.Zero(()) : DataAzurermElasticSanVolumeGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermElasticSanVolumeGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_san_volume_group#elastic_san_id-1">DataAzurermElasticSanVolumeGroup#elastic_san_id</a>.
        /// </summary>
        [<CustomOperation "elastic_san_id">]
        member _.ElasticSanId(state: DataAzurermElasticSanVolumeGroupState<Missing, 'Name>, value: string) : DataAzurermElasticSanVolumeGroupState<Present, 'Name> =
            state.assignments.Add(fun config -> config.ElasticSanId <- value)
            ({ assignments = state.assignments } : DataAzurermElasticSanVolumeGroupState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_san_volume_group#name-1">DataAzurermElasticSanVolumeGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermElasticSanVolumeGroupState<'ElasticSanId, Missing>, value: string) : DataAzurermElasticSanVolumeGroupState<'ElasticSanId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermElasticSanVolumeGroupState<'ElasticSanId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_san_volume_group#id-1">DataAzurermElasticSanVolumeGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermElasticSanVolumeGroupState<'ElasticSanId, 'Name>, value: string) : DataAzurermElasticSanVolumeGroupState<'ElasticSanId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermElasticSanVolumeGroupState<'ElasticSanId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_san_volume_group#timeouts-1">DataAzurermElasticSanVolumeGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermElasticSanVolumeGroupState<'ElasticSanId, 'Name>, value: azurerm.DataAzurermElasticSanVolumeGroup.DataAzurermElasticSanVolumeGroupTimeouts) : DataAzurermElasticSanVolumeGroupState<'ElasticSanId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermElasticSanVolumeGroupState<'ElasticSanId, 'Name>

        member _.Run(state: DataAzurermElasticSanVolumeGroupState<Present, Present>) : azurerm.DataAzurermElasticSanVolumeGroup.DataAzurermElasticSanVolumeGroup =
            let config = azurerm.DataAzurermElasticSanVolumeGroup.DataAzurermElasticSanVolumeGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermElasticSanVolumeGroup.DataAzurermElasticSanVolumeGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermElasticSanVolumeGroup: missing required arguments. Must call: elastic_san_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermElasticSanVolumeGroupState<_, _>) : azurerm.DataAzurermElasticSanVolumeGroup.DataAzurermElasticSanVolumeGroup =
            Unchecked.defaultof<azurerm.DataAzurermElasticSanVolumeGroup.DataAzurermElasticSanVolumeGroup>
