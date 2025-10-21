namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IothubDeviceUpdateAccountState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.IothubDeviceUpdateAccount.IothubDeviceUpdateAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_device_update_account">azurerm_iothub_device_update_account</a>.
    /// </summary>
    type IothubDeviceUpdateAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : IothubDeviceUpdateAccountState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubDeviceUpdateAccountState<Missing, Missing, Missing>)

        member _.Zero(()) : IothubDeviceUpdateAccountState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubDeviceUpdateAccountState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_device_update_account#location-1">IothubDeviceUpdateAccount#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: IothubDeviceUpdateAccountState<Missing, 'Name, 'ResourceGroupName>, value: string) : IothubDeviceUpdateAccountState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : IothubDeviceUpdateAccountState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_device_update_account#name-1">IothubDeviceUpdateAccount#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IothubDeviceUpdateAccountState<'Location, Missing, 'ResourceGroupName>, value: string) : IothubDeviceUpdateAccountState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IothubDeviceUpdateAccountState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_device_update_account#resource_group_name-1">IothubDeviceUpdateAccount#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: IothubDeviceUpdateAccountState<'Location, 'Name, Missing>, value: string) : IothubDeviceUpdateAccountState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : IothubDeviceUpdateAccountState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_device_update_account#id-1">IothubDeviceUpdateAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IothubDeviceUpdateAccountState<'Location, 'Name, 'ResourceGroupName>, value: string) : IothubDeviceUpdateAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IothubDeviceUpdateAccountState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_device_update_account#identity-1">IothubDeviceUpdateAccount#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: IothubDeviceUpdateAccountState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.IothubDeviceUpdateAccount.IothubDeviceUpdateAccountIdentity) : IothubDeviceUpdateAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : IothubDeviceUpdateAccountState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_device_update_account#public_network_access_enabled-1">IothubDeviceUpdateAccount#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: IothubDeviceUpdateAccountState<'Location, 'Name, 'ResourceGroupName>, value: bool) : IothubDeviceUpdateAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : IothubDeviceUpdateAccountState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_device_update_account#public_network_access_enabled-1">IothubDeviceUpdateAccount#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: IothubDeviceUpdateAccountState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : IothubDeviceUpdateAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : IothubDeviceUpdateAccountState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_device_update_account#sku-1">IothubDeviceUpdateAccount#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: IothubDeviceUpdateAccountState<'Location, 'Name, 'ResourceGroupName>, value: string) : IothubDeviceUpdateAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Sku <- value)
            state : IothubDeviceUpdateAccountState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_device_update_account#tags-1">IothubDeviceUpdateAccount#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IothubDeviceUpdateAccountState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : IothubDeviceUpdateAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IothubDeviceUpdateAccountState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_device_update_account#timeouts-1">IothubDeviceUpdateAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IothubDeviceUpdateAccountState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.IothubDeviceUpdateAccount.IothubDeviceUpdateAccountTimeouts) : IothubDeviceUpdateAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IothubDeviceUpdateAccountState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: IothubDeviceUpdateAccountState<Present, Present, Present>) : azurerm.IothubDeviceUpdateAccount.IothubDeviceUpdateAccount =
            let config = azurerm.IothubDeviceUpdateAccount.IothubDeviceUpdateAccountConfig()
            for setter in state.assignments do
                setter config
            azurerm.IothubDeviceUpdateAccount.IothubDeviceUpdateAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.iothubDeviceUpdateAccount: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: IothubDeviceUpdateAccountState<_, _, _>) : azurerm.IothubDeviceUpdateAccount.IothubDeviceUpdateAccount =
            Unchecked.defaultof<azurerm.IothubDeviceUpdateAccount.IothubDeviceUpdateAccount>
