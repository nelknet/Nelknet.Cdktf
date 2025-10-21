namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IotSecurityDeviceGroupState<'IothubId, 'Name> = { assignments: ResizeArray<azurerm.IotSecurityDeviceGroup.IotSecurityDeviceGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_device_group">azurerm_iot_security_device_group</a>.
    /// </summary>
    type IotSecurityDeviceGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : IotSecurityDeviceGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IotSecurityDeviceGroupState<Missing, Missing>)

        member _.Zero(()) : IotSecurityDeviceGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IotSecurityDeviceGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_device_group#iothub_id-1">IotSecurityDeviceGroup#iothub_id</a>.
        /// </summary>
        [<CustomOperation "iothub_id">]
        member _.IothubId(state: IotSecurityDeviceGroupState<Missing, 'Name>, value: string) : IotSecurityDeviceGroupState<Present, 'Name> =
            state.assignments.Add(fun config -> config.IothubId <- value)
            ({ assignments = state.assignments } : IotSecurityDeviceGroupState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_device_group#name-1">IotSecurityDeviceGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IotSecurityDeviceGroupState<'IothubId, Missing>, value: string) : IotSecurityDeviceGroupState<'IothubId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IotSecurityDeviceGroupState<'IothubId, Present>)

        /// <summary>
        /// allow_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_device_group#allow_rule-1">IotSecurityDeviceGroup#allow_rule</a>
        /// </summary>
        [<CustomOperation "allow_rule">]
        member _.AllowRule(state: IotSecurityDeviceGroupState<'IothubId, 'Name>, value: azurerm.IotSecurityDeviceGroup.IotSecurityDeviceGroupAllowRule) : IotSecurityDeviceGroupState<'IothubId, 'Name> =
            state.assignments.Add(fun config -> config.AllowRule <- value)
            state : IotSecurityDeviceGroupState<'IothubId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_device_group#id-1">IotSecurityDeviceGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IotSecurityDeviceGroupState<'IothubId, 'Name>, value: string) : IotSecurityDeviceGroupState<'IothubId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IotSecurityDeviceGroupState<'IothubId, 'Name>

        /// <summary>
        /// range_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_device_group#range_rule-1">IotSecurityDeviceGroup#range_rule</a> Accepts: azurerm.IResolvable | azurerm.IotSecurityDeviceGroup.IotSecurityDeviceGroupRangeRule[]
        /// </summary>
        [<CustomOperation "range_rule">]
        member _.RangeRule(state: IotSecurityDeviceGroupState<'IothubId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : IotSecurityDeviceGroupState<'IothubId, 'Name> =
            state.assignments.Add(fun config -> config.RangeRule <- value)
            state : IotSecurityDeviceGroupState<'IothubId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iot_security_device_group#timeouts-1">IotSecurityDeviceGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IotSecurityDeviceGroupState<'IothubId, 'Name>, value: azurerm.IotSecurityDeviceGroup.IotSecurityDeviceGroupTimeouts) : IotSecurityDeviceGroupState<'IothubId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IotSecurityDeviceGroupState<'IothubId, 'Name>

        member _.Run(state: IotSecurityDeviceGroupState<Present, Present>) : azurerm.IotSecurityDeviceGroup.IotSecurityDeviceGroup =
            let config = azurerm.IotSecurityDeviceGroup.IotSecurityDeviceGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.IotSecurityDeviceGroup.IotSecurityDeviceGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.iotSecurityDeviceGroup: missing required arguments. Must call: iothub_id, name.", 9999, IsError = true)>]
        member _.Run(_: IotSecurityDeviceGroupState<_, _>) : azurerm.IotSecurityDeviceGroup.IotSecurityDeviceGroup =
            Unchecked.defaultof<azurerm.IotSecurityDeviceGroup.IotSecurityDeviceGroup>
