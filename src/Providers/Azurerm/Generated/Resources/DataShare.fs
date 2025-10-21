namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataShareState<'AccountId, 'Kind, 'Name> = { assignments: ResizeArray<azurerm.DataShare.DataShareConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share">azurerm_data_share</a>.
    /// </summary>
    type DataShareBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataShareState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataShareState<Missing, Missing, Missing>)

        member _.Zero(()) : DataShareState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataShareState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share#account_id-1">DataShare#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: DataShareState<Missing, 'Kind, 'Name>, value: string) : DataShareState<Present, 'Kind, 'Name> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            ({ assignments = state.assignments } : DataShareState<Present, 'Kind, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share#kind-1">DataShare#kind</a>.
        /// </summary>
        [<CustomOperation "kind">]
        member _.Kind(state: DataShareState<'AccountId, Missing, 'Name>, value: string) : DataShareState<'AccountId, Present, 'Name> =
            state.assignments.Add(fun config -> config.Kind <- value)
            ({ assignments = state.assignments } : DataShareState<'AccountId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share#name-1">DataShare#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataShareState<'AccountId, 'Kind, Missing>, value: string) : DataShareState<'AccountId, 'Kind, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataShareState<'AccountId, 'Kind, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share#description-1">DataShare#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataShareState<'AccountId, 'Kind, 'Name>, value: string) : DataShareState<'AccountId, 'Kind, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataShareState<'AccountId, 'Kind, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share#id-1">DataShare#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataShareState<'AccountId, 'Kind, 'Name>, value: string) : DataShareState<'AccountId, 'Kind, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataShareState<'AccountId, 'Kind, 'Name>

        /// <summary>
        /// snapshot_schedule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share#snapshot_schedule-1">DataShare#snapshot_schedule</a>
        /// </summary>
        [<CustomOperation "snapshot_schedule">]
        member _.SnapshotSchedule(state: DataShareState<'AccountId, 'Kind, 'Name>, value: azurerm.DataShare.DataShareSnapshotSchedule) : DataShareState<'AccountId, 'Kind, 'Name> =
            state.assignments.Add(fun config -> config.SnapshotSchedule <- value)
            state : DataShareState<'AccountId, 'Kind, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share#terms-1">DataShare#terms</a>.
        /// </summary>
        [<CustomOperation "terms">]
        member _.Terms(state: DataShareState<'AccountId, 'Kind, 'Name>, value: string) : DataShareState<'AccountId, 'Kind, 'Name> =
            state.assignments.Add(fun config -> config.Terms <- value)
            state : DataShareState<'AccountId, 'Kind, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share#timeouts-1">DataShare#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataShareState<'AccountId, 'Kind, 'Name>, value: azurerm.DataShare.DataShareTimeouts) : DataShareState<'AccountId, 'Kind, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataShareState<'AccountId, 'Kind, 'Name>

        member _.Run(state: DataShareState<Present, Present, Present>) : azurerm.DataShare.DataShare =
            let config = azurerm.DataShare.DataShareConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataShare.DataShare(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataShare: missing required arguments. Must call: account_id, kind, name.", 9999, IsError = true)>]
        member _.Run(_: DataShareState<_, _, _>) : azurerm.DataShare.DataShare =
            Unchecked.defaultof<azurerm.DataShare.DataShare>
