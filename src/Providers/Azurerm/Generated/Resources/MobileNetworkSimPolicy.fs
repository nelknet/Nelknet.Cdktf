namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MobileNetworkSimPolicyState<'DefaultSliceId, 'Location, 'MobileNetworkId, 'Name, 'Slice, 'UserEquipmentAggregateMaximumBitRate> = { assignments: ResizeArray<azurerm.MobileNetworkSimPolicy.MobileNetworkSimPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy">azurerm_mobile_network_sim_policy</a>.
    /// </summary>
    type MobileNetworkSimPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : MobileNetworkSimPolicyState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MobileNetworkSimPolicyState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MobileNetworkSimPolicyState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MobileNetworkSimPolicyState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#default_slice_id-1">MobileNetworkSimPolicy#default_slice_id</a>.
        /// </summary>
        [<CustomOperation "default_slice_id">]
        member _.DefaultSliceId(state: MobileNetworkSimPolicyState<Missing, 'Location, 'MobileNetworkId, 'Name, 'Slice, 'UserEquipmentAggregateMaximumBitRate>, value: string) : MobileNetworkSimPolicyState<Present, 'Location, 'MobileNetworkId, 'Name, 'Slice, 'UserEquipmentAggregateMaximumBitRate> =
            state.assignments.Add(fun config -> config.DefaultSliceId <- value)
            ({ assignments = state.assignments } : MobileNetworkSimPolicyState<Present, 'Location, 'MobileNetworkId, 'Name, 'Slice, 'UserEquipmentAggregateMaximumBitRate>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#location-1">MobileNetworkSimPolicy#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MobileNetworkSimPolicyState<'DefaultSliceId, Missing, 'MobileNetworkId, 'Name, 'Slice, 'UserEquipmentAggregateMaximumBitRate>, value: string) : MobileNetworkSimPolicyState<'DefaultSliceId, Present, 'MobileNetworkId, 'Name, 'Slice, 'UserEquipmentAggregateMaximumBitRate> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MobileNetworkSimPolicyState<'DefaultSliceId, Present, 'MobileNetworkId, 'Name, 'Slice, 'UserEquipmentAggregateMaximumBitRate>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#mobile_network_id-1">MobileNetworkSimPolicy#mobile_network_id</a>.
        /// </summary>
        [<CustomOperation "mobile_network_id">]
        member _.MobileNetworkId(state: MobileNetworkSimPolicyState<'DefaultSliceId, 'Location, Missing, 'Name, 'Slice, 'UserEquipmentAggregateMaximumBitRate>, value: string) : MobileNetworkSimPolicyState<'DefaultSliceId, 'Location, Present, 'Name, 'Slice, 'UserEquipmentAggregateMaximumBitRate> =
            state.assignments.Add(fun config -> config.MobileNetworkId <- value)
            ({ assignments = state.assignments } : MobileNetworkSimPolicyState<'DefaultSliceId, 'Location, Present, 'Name, 'Slice, 'UserEquipmentAggregateMaximumBitRate>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#name-1">MobileNetworkSimPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MobileNetworkSimPolicyState<'DefaultSliceId, 'Location, 'MobileNetworkId, Missing, 'Slice, 'UserEquipmentAggregateMaximumBitRate>, value: string) : MobileNetworkSimPolicyState<'DefaultSliceId, 'Location, 'MobileNetworkId, Present, 'Slice, 'UserEquipmentAggregateMaximumBitRate> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MobileNetworkSimPolicyState<'DefaultSliceId, 'Location, 'MobileNetworkId, Present, 'Slice, 'UserEquipmentAggregateMaximumBitRate>)

        /// <summary>
        /// slice block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#slice-1">MobileNetworkSimPolicy#slice</a> Accepts: azurerm.IResolvable | azurerm.MobileNetworkSimPolicy.MobileNetworkSimPolicySlice[]
        /// </summary>
        [<CustomOperation "slice">]
        member _.Slice(state: MobileNetworkSimPolicyState<'DefaultSliceId, 'Location, 'MobileNetworkId, 'Name, Missing, 'UserEquipmentAggregateMaximumBitRate>, value: HashiCorp.Cdktf.IResolvable) : MobileNetworkSimPolicyState<'DefaultSliceId, 'Location, 'MobileNetworkId, 'Name, Present, 'UserEquipmentAggregateMaximumBitRate> =
            state.assignments.Add(fun config -> config.Slice <- value)
            ({ assignments = state.assignments } : MobileNetworkSimPolicyState<'DefaultSliceId, 'Location, 'MobileNetworkId, 'Name, Present, 'UserEquipmentAggregateMaximumBitRate>)

        /// <summary>
        /// user_equipment_aggregate_maximum_bit_rate block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#user_equipment_aggregate_maximum_bit_rate-1">MobileNetworkSimPolicy#user_equipment_aggregate_maximum_bit_rate</a>
        /// </summary>
        [<CustomOperation "user_equipment_aggregate_maximum_bit_rate">]
        member _.UserEquipmentAggregateMaximumBitRate(state: MobileNetworkSimPolicyState<'DefaultSliceId, 'Location, 'MobileNetworkId, 'Name, 'Slice, Missing>, value: azurerm.MobileNetworkSimPolicy.MobileNetworkSimPolicyUserEquipmentAggregateMaximumBitRate) : MobileNetworkSimPolicyState<'DefaultSliceId, 'Location, 'MobileNetworkId, 'Name, 'Slice, Present> =
            state.assignments.Add(fun config -> config.UserEquipmentAggregateMaximumBitRate <- value)
            ({ assignments = state.assignments } : MobileNetworkSimPolicyState<'DefaultSliceId, 'Location, 'MobileNetworkId, 'Name, 'Slice, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#id-1">MobileNetworkSimPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MobileNetworkSimPolicyState<'DefaultSliceId, 'Location, 'MobileNetworkId, 'Name, 'Slice, 'UserEquipmentAggregateMaximumBitRate>, value: string) : MobileNetworkSimPolicyState<'DefaultSliceId, 'Location, 'MobileNetworkId, 'Name, 'Slice, 'UserEquipmentAggregateMaximumBitRate> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MobileNetworkSimPolicyState<'DefaultSliceId, 'Location, 'MobileNetworkId, 'Name, 'Slice, 'UserEquipmentAggregateMaximumBitRate>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#rat_frequency_selection_priority_index-1">MobileNetworkSimPolicy#rat_frequency_selection_priority_index</a>.
        /// </summary>
        [<CustomOperation "rat_frequency_selection_priority_index">]
        member _.RatFrequencySelectionPriorityIndex(state: MobileNetworkSimPolicyState<'DefaultSliceId, 'Location, 'MobileNetworkId, 'Name, 'Slice, 'UserEquipmentAggregateMaximumBitRate>, value: double) : MobileNetworkSimPolicyState<'DefaultSliceId, 'Location, 'MobileNetworkId, 'Name, 'Slice, 'UserEquipmentAggregateMaximumBitRate> =
            state.assignments.Add(fun config -> config.RatFrequencySelectionPriorityIndex <- value)
            state : MobileNetworkSimPolicyState<'DefaultSliceId, 'Location, 'MobileNetworkId, 'Name, 'Slice, 'UserEquipmentAggregateMaximumBitRate>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#registration_timer_in_seconds-1">MobileNetworkSimPolicy#registration_timer_in_seconds</a>.
        /// </summary>
        [<CustomOperation "registration_timer_in_seconds">]
        member _.RegistrationTimerInSeconds(state: MobileNetworkSimPolicyState<'DefaultSliceId, 'Location, 'MobileNetworkId, 'Name, 'Slice, 'UserEquipmentAggregateMaximumBitRate>, value: double) : MobileNetworkSimPolicyState<'DefaultSliceId, 'Location, 'MobileNetworkId, 'Name, 'Slice, 'UserEquipmentAggregateMaximumBitRate> =
            state.assignments.Add(fun config -> config.RegistrationTimerInSeconds <- value)
            state : MobileNetworkSimPolicyState<'DefaultSliceId, 'Location, 'MobileNetworkId, 'Name, 'Slice, 'UserEquipmentAggregateMaximumBitRate>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#tags-1">MobileNetworkSimPolicy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MobileNetworkSimPolicyState<'DefaultSliceId, 'Location, 'MobileNetworkId, 'Name, 'Slice, 'UserEquipmentAggregateMaximumBitRate>, value: seq<string * string>) : MobileNetworkSimPolicyState<'DefaultSliceId, 'Location, 'MobileNetworkId, 'Name, 'Slice, 'UserEquipmentAggregateMaximumBitRate> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MobileNetworkSimPolicyState<'DefaultSliceId, 'Location, 'MobileNetworkId, 'Name, 'Slice, 'UserEquipmentAggregateMaximumBitRate>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#timeouts-1">MobileNetworkSimPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MobileNetworkSimPolicyState<'DefaultSliceId, 'Location, 'MobileNetworkId, 'Name, 'Slice, 'UserEquipmentAggregateMaximumBitRate>, value: azurerm.MobileNetworkSimPolicy.MobileNetworkSimPolicyTimeouts) : MobileNetworkSimPolicyState<'DefaultSliceId, 'Location, 'MobileNetworkId, 'Name, 'Slice, 'UserEquipmentAggregateMaximumBitRate> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MobileNetworkSimPolicyState<'DefaultSliceId, 'Location, 'MobileNetworkId, 'Name, 'Slice, 'UserEquipmentAggregateMaximumBitRate>

        member _.Run(state: MobileNetworkSimPolicyState<Present, Present, Present, Present, Present, Present>) : azurerm.MobileNetworkSimPolicy.MobileNetworkSimPolicy =
            let config = azurerm.MobileNetworkSimPolicy.MobileNetworkSimPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.MobileNetworkSimPolicy.MobileNetworkSimPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mobileNetworkSimPolicy: missing required arguments. Must call: default_slice_id, location, mobile_network_id, name, slice, user_equipment_aggregate_maximum_bit_rate.", 9999, IsError = true)>]
        member _.Run(_: MobileNetworkSimPolicyState<_, _, _, _, _, _>) : azurerm.MobileNetworkSimPolicy.MobileNetworkSimPolicy =
            Unchecked.defaultof<azurerm.MobileNetworkSimPolicy.MobileNetworkSimPolicy>
