namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MobileNetworkSimState<'AuthenticationKey, 'IntegratedCircuitCardIdentifier, 'InternationalMobileSubscriberIdentity, 'MobileNetworkSimGroupId, 'Name, 'OperatorKeyCode> = { assignments: ResizeArray<azurerm.MobileNetworkSim.MobileNetworkSimConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim">azurerm_mobile_network_sim</a>.
    /// </summary>
    type MobileNetworkSimBuilder(logicalId: string) =
        member _.Yield(_: unit) : MobileNetworkSimState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MobileNetworkSimState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MobileNetworkSimState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MobileNetworkSimState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim#authentication_key-1">MobileNetworkSim#authentication_key</a>.
        /// </summary>
        [<CustomOperation "authentication_key">]
        member _.AuthenticationKey(state: MobileNetworkSimState<Missing, 'IntegratedCircuitCardIdentifier, 'InternationalMobileSubscriberIdentity, 'MobileNetworkSimGroupId, 'Name, 'OperatorKeyCode>, value: string) : MobileNetworkSimState<Present, 'IntegratedCircuitCardIdentifier, 'InternationalMobileSubscriberIdentity, 'MobileNetworkSimGroupId, 'Name, 'OperatorKeyCode> =
            state.assignments.Add(fun config -> config.AuthenticationKey <- value)
            ({ assignments = state.assignments } : MobileNetworkSimState<Present, 'IntegratedCircuitCardIdentifier, 'InternationalMobileSubscriberIdentity, 'MobileNetworkSimGroupId, 'Name, 'OperatorKeyCode>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim#integrated_circuit_card_identifier-1">MobileNetworkSim#integrated_circuit_card_identifier</a>.
        /// </summary>
        [<CustomOperation "integrated_circuit_card_identifier">]
        member _.IntegratedCircuitCardIdentifier(state: MobileNetworkSimState<'AuthenticationKey, Missing, 'InternationalMobileSubscriberIdentity, 'MobileNetworkSimGroupId, 'Name, 'OperatorKeyCode>, value: string) : MobileNetworkSimState<'AuthenticationKey, Present, 'InternationalMobileSubscriberIdentity, 'MobileNetworkSimGroupId, 'Name, 'OperatorKeyCode> =
            state.assignments.Add(fun config -> config.IntegratedCircuitCardIdentifier <- value)
            ({ assignments = state.assignments } : MobileNetworkSimState<'AuthenticationKey, Present, 'InternationalMobileSubscriberIdentity, 'MobileNetworkSimGroupId, 'Name, 'OperatorKeyCode>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim#international_mobile_subscriber_identity-1">MobileNetworkSim#international_mobile_subscriber_identity</a>.
        /// </summary>
        [<CustomOperation "international_mobile_subscriber_identity">]
        member _.InternationalMobileSubscriberIdentity(state: MobileNetworkSimState<'AuthenticationKey, 'IntegratedCircuitCardIdentifier, Missing, 'MobileNetworkSimGroupId, 'Name, 'OperatorKeyCode>, value: string) : MobileNetworkSimState<'AuthenticationKey, 'IntegratedCircuitCardIdentifier, Present, 'MobileNetworkSimGroupId, 'Name, 'OperatorKeyCode> =
            state.assignments.Add(fun config -> config.InternationalMobileSubscriberIdentity <- value)
            ({ assignments = state.assignments } : MobileNetworkSimState<'AuthenticationKey, 'IntegratedCircuitCardIdentifier, Present, 'MobileNetworkSimGroupId, 'Name, 'OperatorKeyCode>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim#mobile_network_sim_group_id-1">MobileNetworkSim#mobile_network_sim_group_id</a>.
        /// </summary>
        [<CustomOperation "mobile_network_sim_group_id">]
        member _.MobileNetworkSimGroupId(state: MobileNetworkSimState<'AuthenticationKey, 'IntegratedCircuitCardIdentifier, 'InternationalMobileSubscriberIdentity, Missing, 'Name, 'OperatorKeyCode>, value: string) : MobileNetworkSimState<'AuthenticationKey, 'IntegratedCircuitCardIdentifier, 'InternationalMobileSubscriberIdentity, Present, 'Name, 'OperatorKeyCode> =
            state.assignments.Add(fun config -> config.MobileNetworkSimGroupId <- value)
            ({ assignments = state.assignments } : MobileNetworkSimState<'AuthenticationKey, 'IntegratedCircuitCardIdentifier, 'InternationalMobileSubscriberIdentity, Present, 'Name, 'OperatorKeyCode>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim#name-1">MobileNetworkSim#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MobileNetworkSimState<'AuthenticationKey, 'IntegratedCircuitCardIdentifier, 'InternationalMobileSubscriberIdentity, 'MobileNetworkSimGroupId, Missing, 'OperatorKeyCode>, value: string) : MobileNetworkSimState<'AuthenticationKey, 'IntegratedCircuitCardIdentifier, 'InternationalMobileSubscriberIdentity, 'MobileNetworkSimGroupId, Present, 'OperatorKeyCode> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MobileNetworkSimState<'AuthenticationKey, 'IntegratedCircuitCardIdentifier, 'InternationalMobileSubscriberIdentity, 'MobileNetworkSimGroupId, Present, 'OperatorKeyCode>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim#operator_key_code-1">MobileNetworkSim#operator_key_code</a>.
        /// </summary>
        [<CustomOperation "operator_key_code">]
        member _.OperatorKeyCode(state: MobileNetworkSimState<'AuthenticationKey, 'IntegratedCircuitCardIdentifier, 'InternationalMobileSubscriberIdentity, 'MobileNetworkSimGroupId, 'Name, Missing>, value: string) : MobileNetworkSimState<'AuthenticationKey, 'IntegratedCircuitCardIdentifier, 'InternationalMobileSubscriberIdentity, 'MobileNetworkSimGroupId, 'Name, Present> =
            state.assignments.Add(fun config -> config.OperatorKeyCode <- value)
            ({ assignments = state.assignments } : MobileNetworkSimState<'AuthenticationKey, 'IntegratedCircuitCardIdentifier, 'InternationalMobileSubscriberIdentity, 'MobileNetworkSimGroupId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim#device_type-1">MobileNetworkSim#device_type</a>.
        /// </summary>
        [<CustomOperation "device_type">]
        member _.DeviceType(state: MobileNetworkSimState<'AuthenticationKey, 'IntegratedCircuitCardIdentifier, 'InternationalMobileSubscriberIdentity, 'MobileNetworkSimGroupId, 'Name, 'OperatorKeyCode>, value: string) : MobileNetworkSimState<'AuthenticationKey, 'IntegratedCircuitCardIdentifier, 'InternationalMobileSubscriberIdentity, 'MobileNetworkSimGroupId, 'Name, 'OperatorKeyCode> =
            state.assignments.Add(fun config -> config.DeviceType <- value)
            state : MobileNetworkSimState<'AuthenticationKey, 'IntegratedCircuitCardIdentifier, 'InternationalMobileSubscriberIdentity, 'MobileNetworkSimGroupId, 'Name, 'OperatorKeyCode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim#id-1">MobileNetworkSim#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MobileNetworkSimState<'AuthenticationKey, 'IntegratedCircuitCardIdentifier, 'InternationalMobileSubscriberIdentity, 'MobileNetworkSimGroupId, 'Name, 'OperatorKeyCode>, value: string) : MobileNetworkSimState<'AuthenticationKey, 'IntegratedCircuitCardIdentifier, 'InternationalMobileSubscriberIdentity, 'MobileNetworkSimGroupId, 'Name, 'OperatorKeyCode> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MobileNetworkSimState<'AuthenticationKey, 'IntegratedCircuitCardIdentifier, 'InternationalMobileSubscriberIdentity, 'MobileNetworkSimGroupId, 'Name, 'OperatorKeyCode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim#sim_policy_id-1">MobileNetworkSim#sim_policy_id</a>.
        /// </summary>
        [<CustomOperation "sim_policy_id">]
        member _.SimPolicyId(state: MobileNetworkSimState<'AuthenticationKey, 'IntegratedCircuitCardIdentifier, 'InternationalMobileSubscriberIdentity, 'MobileNetworkSimGroupId, 'Name, 'OperatorKeyCode>, value: string) : MobileNetworkSimState<'AuthenticationKey, 'IntegratedCircuitCardIdentifier, 'InternationalMobileSubscriberIdentity, 'MobileNetworkSimGroupId, 'Name, 'OperatorKeyCode> =
            state.assignments.Add(fun config -> config.SimPolicyId <- value)
            state : MobileNetworkSimState<'AuthenticationKey, 'IntegratedCircuitCardIdentifier, 'InternationalMobileSubscriberIdentity, 'MobileNetworkSimGroupId, 'Name, 'OperatorKeyCode>

        /// <summary>
        /// static_ip_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim#static_ip_configuration-1">MobileNetworkSim#static_ip_configuration</a> Accepts: azurerm.IResolvable | azurerm.MobileNetworkSim.MobileNetworkSimStaticIpConfiguration[]
        /// </summary>
        [<CustomOperation "static_ip_configuration">]
        member _.StaticIpConfiguration(state: MobileNetworkSimState<'AuthenticationKey, 'IntegratedCircuitCardIdentifier, 'InternationalMobileSubscriberIdentity, 'MobileNetworkSimGroupId, 'Name, 'OperatorKeyCode>, value: HashiCorp.Cdktf.IResolvable) : MobileNetworkSimState<'AuthenticationKey, 'IntegratedCircuitCardIdentifier, 'InternationalMobileSubscriberIdentity, 'MobileNetworkSimGroupId, 'Name, 'OperatorKeyCode> =
            state.assignments.Add(fun config -> config.StaticIpConfiguration <- value)
            state : MobileNetworkSimState<'AuthenticationKey, 'IntegratedCircuitCardIdentifier, 'InternationalMobileSubscriberIdentity, 'MobileNetworkSimGroupId, 'Name, 'OperatorKeyCode>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim#timeouts-1">MobileNetworkSim#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MobileNetworkSimState<'AuthenticationKey, 'IntegratedCircuitCardIdentifier, 'InternationalMobileSubscriberIdentity, 'MobileNetworkSimGroupId, 'Name, 'OperatorKeyCode>, value: azurerm.MobileNetworkSim.MobileNetworkSimTimeouts) : MobileNetworkSimState<'AuthenticationKey, 'IntegratedCircuitCardIdentifier, 'InternationalMobileSubscriberIdentity, 'MobileNetworkSimGroupId, 'Name, 'OperatorKeyCode> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MobileNetworkSimState<'AuthenticationKey, 'IntegratedCircuitCardIdentifier, 'InternationalMobileSubscriberIdentity, 'MobileNetworkSimGroupId, 'Name, 'OperatorKeyCode>

        member _.Run(state: MobileNetworkSimState<Present, Present, Present, Present, Present, Present>) : azurerm.MobileNetworkSim.MobileNetworkSim =
            let config = azurerm.MobileNetworkSim.MobileNetworkSimConfig()
            for setter in state.assignments do
                setter config
            azurerm.MobileNetworkSim.MobileNetworkSim(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mobileNetworkSim: missing required arguments. Must call: authentication_key, integrated_circuit_card_identifier, international_mobile_subscriber_identity, mobile_network_sim_group_id, name, operator_key_code.", 9999, IsError = true)>]
        member _.Run(_: MobileNetworkSimState<_, _, _, _, _, _>) : azurerm.MobileNetworkSim.MobileNetworkSim =
            Unchecked.defaultof<azurerm.MobileNetworkSim.MobileNetworkSim>
