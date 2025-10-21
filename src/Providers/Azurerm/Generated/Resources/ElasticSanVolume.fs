namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ElasticSanVolumeState<'Name, 'SizeInGib, 'VolumeGroupId> = { assignments: ResizeArray<azurerm.ElasticSanVolume.ElasticSanVolumeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san_volume">azurerm_elastic_san_volume</a>.
    /// </summary>
    type ElasticSanVolumeBuilder(logicalId: string) =
        member _.Yield(_: unit) : ElasticSanVolumeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticSanVolumeState<Missing, Missing, Missing>)

        member _.Zero(()) : ElasticSanVolumeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticSanVolumeState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san_volume#name-1">ElasticSanVolume#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ElasticSanVolumeState<Missing, 'SizeInGib, 'VolumeGroupId>, value: string) : ElasticSanVolumeState<Present, 'SizeInGib, 'VolumeGroupId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ElasticSanVolumeState<Present, 'SizeInGib, 'VolumeGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san_volume#size_in_gib-1">ElasticSanVolume#size_in_gib</a>.
        /// </summary>
        [<CustomOperation "size_in_gib">]
        member _.SizeInGib(state: ElasticSanVolumeState<'Name, Missing, 'VolumeGroupId>, value: double) : ElasticSanVolumeState<'Name, Present, 'VolumeGroupId> =
            state.assignments.Add(fun config -> config.SizeInGib <- value)
            ({ assignments = state.assignments } : ElasticSanVolumeState<'Name, Present, 'VolumeGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san_volume#volume_group_id-1">ElasticSanVolume#volume_group_id</a>.
        /// </summary>
        [<CustomOperation "volume_group_id">]
        member _.VolumeGroupId(state: ElasticSanVolumeState<'Name, 'SizeInGib, Missing>, value: string) : ElasticSanVolumeState<'Name, 'SizeInGib, Present> =
            state.assignments.Add(fun config -> config.VolumeGroupId <- value)
            ({ assignments = state.assignments } : ElasticSanVolumeState<'Name, 'SizeInGib, Present>)

        /// <summary>
        /// create_source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san_volume#create_source-1">ElasticSanVolume#create_source</a>
        /// </summary>
        [<CustomOperation "create_source">]
        member _.CreateSource(state: ElasticSanVolumeState<'Name, 'SizeInGib, 'VolumeGroupId>, value: azurerm.ElasticSanVolume.ElasticSanVolumeCreateSource) : ElasticSanVolumeState<'Name, 'SizeInGib, 'VolumeGroupId> =
            state.assignments.Add(fun config -> config.CreateSource <- value)
            state : ElasticSanVolumeState<'Name, 'SizeInGib, 'VolumeGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san_volume#id-1">ElasticSanVolume#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ElasticSanVolumeState<'Name, 'SizeInGib, 'VolumeGroupId>, value: string) : ElasticSanVolumeState<'Name, 'SizeInGib, 'VolumeGroupId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ElasticSanVolumeState<'Name, 'SizeInGib, 'VolumeGroupId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san_volume#timeouts-1">ElasticSanVolume#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ElasticSanVolumeState<'Name, 'SizeInGib, 'VolumeGroupId>, value: azurerm.ElasticSanVolume.ElasticSanVolumeTimeouts) : ElasticSanVolumeState<'Name, 'SizeInGib, 'VolumeGroupId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ElasticSanVolumeState<'Name, 'SizeInGib, 'VolumeGroupId>

        member _.Run(state: ElasticSanVolumeState<Present, Present, Present>) : azurerm.ElasticSanVolume.ElasticSanVolume =
            let config = azurerm.ElasticSanVolume.ElasticSanVolumeConfig()
            for setter in state.assignments do
                setter config
            azurerm.ElasticSanVolume.ElasticSanVolume(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.elasticSanVolume: missing required arguments. Must call: name, size_in_gib, volume_group_id.", 9999, IsError = true)>]
        member _.Run(_: ElasticSanVolumeState<_, _, _>) : azurerm.ElasticSanVolume.ElasticSanVolume =
            Unchecked.defaultof<azurerm.ElasticSanVolume.ElasticSanVolume>
