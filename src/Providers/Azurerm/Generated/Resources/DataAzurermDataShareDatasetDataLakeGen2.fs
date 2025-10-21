namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDataShareDatasetDataLakeGen2State<'Name, 'ShareId> = { assignments: ResizeArray<azurerm.DataAzurermDataShareDatasetDataLakeGen2.DataAzurermDataShareDatasetDataLakeGen2Config -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_dataset_data_lake_gen2">azurerm_data_share_dataset_data_lake_gen2</a>.
    /// </summary>
    type DataAzurermDataShareDatasetDataLakeGen2Builder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDataShareDatasetDataLakeGen2State<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDataShareDatasetDataLakeGen2State<Missing, Missing>)

        member _.Zero(()) : DataAzurermDataShareDatasetDataLakeGen2State<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDataShareDatasetDataLakeGen2State<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_dataset_data_lake_gen2#name-1">DataAzurermDataShareDatasetDataLakeGen2#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDataShareDatasetDataLakeGen2State<Missing, 'ShareId>, value: string) : DataAzurermDataShareDatasetDataLakeGen2State<Present, 'ShareId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDataShareDatasetDataLakeGen2State<Present, 'ShareId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_dataset_data_lake_gen2#share_id-1">DataAzurermDataShareDatasetDataLakeGen2#share_id</a>.
        /// </summary>
        [<CustomOperation "share_id">]
        member _.ShareId(state: DataAzurermDataShareDatasetDataLakeGen2State<'Name, Missing>, value: string) : DataAzurermDataShareDatasetDataLakeGen2State<'Name, Present> =
            state.assignments.Add(fun config -> config.ShareId <- value)
            ({ assignments = state.assignments } : DataAzurermDataShareDatasetDataLakeGen2State<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_dataset_data_lake_gen2#id-1">DataAzurermDataShareDatasetDataLakeGen2#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDataShareDatasetDataLakeGen2State<'Name, 'ShareId>, value: string) : DataAzurermDataShareDatasetDataLakeGen2State<'Name, 'ShareId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDataShareDatasetDataLakeGen2State<'Name, 'ShareId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_dataset_data_lake_gen2#timeouts-1">DataAzurermDataShareDatasetDataLakeGen2#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDataShareDatasetDataLakeGen2State<'Name, 'ShareId>, value: azurerm.DataAzurermDataShareDatasetDataLakeGen2.DataAzurermDataShareDatasetDataLakeGen2Timeouts) : DataAzurermDataShareDatasetDataLakeGen2State<'Name, 'ShareId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDataShareDatasetDataLakeGen2State<'Name, 'ShareId>

        member _.Run(state: DataAzurermDataShareDatasetDataLakeGen2State<Present, Present>) : azurerm.DataAzurermDataShareDatasetDataLakeGen2.DataAzurermDataShareDatasetDataLakeGen2 =
            let config = azurerm.DataAzurermDataShareDatasetDataLakeGen2.DataAzurermDataShareDatasetDataLakeGen2Config()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDataShareDatasetDataLakeGen2.DataAzurermDataShareDatasetDataLakeGen2(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDataShareDatasetDataLakeGen2: missing required arguments. Must call: name, share_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDataShareDatasetDataLakeGen2State<_, _>) : azurerm.DataAzurermDataShareDatasetDataLakeGen2.DataAzurermDataShareDatasetDataLakeGen2 =
            Unchecked.defaultof<azurerm.DataAzurermDataShareDatasetDataLakeGen2.DataAzurermDataShareDatasetDataLakeGen2>
