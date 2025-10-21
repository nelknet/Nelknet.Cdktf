namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IothubDeviceUpdateInstanceState<'DeviceUpdateAccountId, 'IothubId, 'Name> = { assignments: ResizeArray<azurerm.IothubDeviceUpdateInstance.IothubDeviceUpdateInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_device_update_instance">azurerm_iothub_device_update_instance</a>.
    /// </summary>
    type IothubDeviceUpdateInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : IothubDeviceUpdateInstanceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubDeviceUpdateInstanceState<Missing, Missing, Missing>)

        member _.Zero(()) : IothubDeviceUpdateInstanceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubDeviceUpdateInstanceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_device_update_instance#device_update_account_id-1">IothubDeviceUpdateInstance#device_update_account_id</a>.
        /// </summary>
        [<CustomOperation "device_update_account_id">]
        member _.DeviceUpdateAccountId(state: IothubDeviceUpdateInstanceState<Missing, 'IothubId, 'Name>, value: string) : IothubDeviceUpdateInstanceState<Present, 'IothubId, 'Name> =
            state.assignments.Add(fun config -> config.DeviceUpdateAccountId <- value)
            ({ assignments = state.assignments } : IothubDeviceUpdateInstanceState<Present, 'IothubId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_device_update_instance#iothub_id-1">IothubDeviceUpdateInstance#iothub_id</a>.
        /// </summary>
        [<CustomOperation "iothub_id">]
        member _.IothubId(state: IothubDeviceUpdateInstanceState<'DeviceUpdateAccountId, Missing, 'Name>, value: string) : IothubDeviceUpdateInstanceState<'DeviceUpdateAccountId, Present, 'Name> =
            state.assignments.Add(fun config -> config.IothubId <- value)
            ({ assignments = state.assignments } : IothubDeviceUpdateInstanceState<'DeviceUpdateAccountId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_device_update_instance#name-1">IothubDeviceUpdateInstance#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IothubDeviceUpdateInstanceState<'DeviceUpdateAccountId, 'IothubId, Missing>, value: string) : IothubDeviceUpdateInstanceState<'DeviceUpdateAccountId, 'IothubId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IothubDeviceUpdateInstanceState<'DeviceUpdateAccountId, 'IothubId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_device_update_instance#diagnostic_enabled-1">IothubDeviceUpdateInstance#diagnostic_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "diagnostic_enabled">]
        member _.DiagnosticEnabled(state: IothubDeviceUpdateInstanceState<'DeviceUpdateAccountId, 'IothubId, 'Name>, value: bool) : IothubDeviceUpdateInstanceState<'DeviceUpdateAccountId, 'IothubId, 'Name> =
            state.assignments.Add(fun config -> config.DiagnosticEnabled <- value)
            state : IothubDeviceUpdateInstanceState<'DeviceUpdateAccountId, 'IothubId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_device_update_instance#diagnostic_enabled-1">IothubDeviceUpdateInstance#diagnostic_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "diagnostic_enabled">]
        member _.DiagnosticEnabled(state: IothubDeviceUpdateInstanceState<'DeviceUpdateAccountId, 'IothubId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : IothubDeviceUpdateInstanceState<'DeviceUpdateAccountId, 'IothubId, 'Name> =
            state.assignments.Add(fun config -> config.DiagnosticEnabled <- value)
            state : IothubDeviceUpdateInstanceState<'DeviceUpdateAccountId, 'IothubId, 'Name>

        /// <summary>
        /// diagnostic_storage_account block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_device_update_instance#diagnostic_storage_account-1">IothubDeviceUpdateInstance#diagnostic_storage_account</a>
        /// </summary>
        [<CustomOperation "diagnostic_storage_account">]
        member _.DiagnosticStorageAccount(state: IothubDeviceUpdateInstanceState<'DeviceUpdateAccountId, 'IothubId, 'Name>, value: azurerm.IothubDeviceUpdateInstance.IothubDeviceUpdateInstanceDiagnosticStorageAccount) : IothubDeviceUpdateInstanceState<'DeviceUpdateAccountId, 'IothubId, 'Name> =
            state.assignments.Add(fun config -> config.DiagnosticStorageAccount <- value)
            state : IothubDeviceUpdateInstanceState<'DeviceUpdateAccountId, 'IothubId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_device_update_instance#id-1">IothubDeviceUpdateInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IothubDeviceUpdateInstanceState<'DeviceUpdateAccountId, 'IothubId, 'Name>, value: string) : IothubDeviceUpdateInstanceState<'DeviceUpdateAccountId, 'IothubId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IothubDeviceUpdateInstanceState<'DeviceUpdateAccountId, 'IothubId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_device_update_instance#tags-1">IothubDeviceUpdateInstance#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IothubDeviceUpdateInstanceState<'DeviceUpdateAccountId, 'IothubId, 'Name>, value: seq<string * string>) : IothubDeviceUpdateInstanceState<'DeviceUpdateAccountId, 'IothubId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IothubDeviceUpdateInstanceState<'DeviceUpdateAccountId, 'IothubId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_device_update_instance#timeouts-1">IothubDeviceUpdateInstance#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IothubDeviceUpdateInstanceState<'DeviceUpdateAccountId, 'IothubId, 'Name>, value: azurerm.IothubDeviceUpdateInstance.IothubDeviceUpdateInstanceTimeouts) : IothubDeviceUpdateInstanceState<'DeviceUpdateAccountId, 'IothubId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IothubDeviceUpdateInstanceState<'DeviceUpdateAccountId, 'IothubId, 'Name>

        member _.Run(state: IothubDeviceUpdateInstanceState<Present, Present, Present>) : azurerm.IothubDeviceUpdateInstance.IothubDeviceUpdateInstance =
            let config = azurerm.IothubDeviceUpdateInstance.IothubDeviceUpdateInstanceConfig()
            for setter in state.assignments do
                setter config
            azurerm.IothubDeviceUpdateInstance.IothubDeviceUpdateInstance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.iothubDeviceUpdateInstance: missing required arguments. Must call: device_update_account_id, iothub_id, name.", 9999, IsError = true)>]
        member _.Run(_: IothubDeviceUpdateInstanceState<_, _, _>) : azurerm.IothubDeviceUpdateInstance.IothubDeviceUpdateInstance =
            Unchecked.defaultof<azurerm.IothubDeviceUpdateInstance.IothubDeviceUpdateInstance>
