namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermElasticSanVolumeSnapshotState<'Name, 'VolumeGroupId> = { assignments: ResizeArray<azurerm.DataAzurermElasticSanVolumeSnapshot.DataAzurermElasticSanVolumeSnapshotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_san_volume_snapshot">azurerm_elastic_san_volume_snapshot</a>.
    /// </summary>
    type DataAzurermElasticSanVolumeSnapshotBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermElasticSanVolumeSnapshotState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermElasticSanVolumeSnapshotState<Missing, Missing>)

        member _.Zero(()) : DataAzurermElasticSanVolumeSnapshotState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermElasticSanVolumeSnapshotState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_san_volume_snapshot#name-1">DataAzurermElasticSanVolumeSnapshot#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermElasticSanVolumeSnapshotState<Missing, 'VolumeGroupId>, value: string) : DataAzurermElasticSanVolumeSnapshotState<Present, 'VolumeGroupId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermElasticSanVolumeSnapshotState<Present, 'VolumeGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_san_volume_snapshot#volume_group_id-1">DataAzurermElasticSanVolumeSnapshot#volume_group_id</a>.
        /// </summary>
        [<CustomOperation "volume_group_id">]
        member _.VolumeGroupId(state: DataAzurermElasticSanVolumeSnapshotState<'Name, Missing>, value: string) : DataAzurermElasticSanVolumeSnapshotState<'Name, Present> =
            state.assignments.Add(fun config -> config.VolumeGroupId <- value)
            ({ assignments = state.assignments } : DataAzurermElasticSanVolumeSnapshotState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_san_volume_snapshot#id-1">DataAzurermElasticSanVolumeSnapshot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermElasticSanVolumeSnapshotState<'Name, 'VolumeGroupId>, value: string) : DataAzurermElasticSanVolumeSnapshotState<'Name, 'VolumeGroupId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermElasticSanVolumeSnapshotState<'Name, 'VolumeGroupId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_san_volume_snapshot#timeouts-1">DataAzurermElasticSanVolumeSnapshot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermElasticSanVolumeSnapshotState<'Name, 'VolumeGroupId>, value: azurerm.DataAzurermElasticSanVolumeSnapshot.DataAzurermElasticSanVolumeSnapshotTimeouts) : DataAzurermElasticSanVolumeSnapshotState<'Name, 'VolumeGroupId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermElasticSanVolumeSnapshotState<'Name, 'VolumeGroupId>

        member _.Run(state: DataAzurermElasticSanVolumeSnapshotState<Present, Present>) : azurerm.DataAzurermElasticSanVolumeSnapshot.DataAzurermElasticSanVolumeSnapshot =
            let config = azurerm.DataAzurermElasticSanVolumeSnapshot.DataAzurermElasticSanVolumeSnapshotConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermElasticSanVolumeSnapshot.DataAzurermElasticSanVolumeSnapshot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermElasticSanVolumeSnapshot: missing required arguments. Must call: name, volume_group_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermElasticSanVolumeSnapshotState<_, _>) : azurerm.DataAzurermElasticSanVolumeSnapshot.DataAzurermElasticSanVolumeSnapshot =
            Unchecked.defaultof<azurerm.DataAzurermElasticSanVolumeSnapshot.DataAzurermElasticSanVolumeSnapshot>
