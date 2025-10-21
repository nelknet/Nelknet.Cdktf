namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MobileNetworkServiceState<'Location, 'MobileNetworkId, 'Name, 'PccRule, 'ServicePrecedence> = { assignments: ResizeArray<azurerm.MobileNetworkService.MobileNetworkServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service">azurerm_mobile_network_service</a>.
    /// </summary>
    type MobileNetworkServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : MobileNetworkServiceState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MobileNetworkServiceState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MobileNetworkServiceState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MobileNetworkServiceState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#location-1">MobileNetworkService#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MobileNetworkServiceState<Missing, 'MobileNetworkId, 'Name, 'PccRule, 'ServicePrecedence>, value: string) : MobileNetworkServiceState<Present, 'MobileNetworkId, 'Name, 'PccRule, 'ServicePrecedence> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MobileNetworkServiceState<Present, 'MobileNetworkId, 'Name, 'PccRule, 'ServicePrecedence>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#mobile_network_id-1">MobileNetworkService#mobile_network_id</a>.
        /// </summary>
        [<CustomOperation "mobile_network_id">]
        member _.MobileNetworkId(state: MobileNetworkServiceState<'Location, Missing, 'Name, 'PccRule, 'ServicePrecedence>, value: string) : MobileNetworkServiceState<'Location, Present, 'Name, 'PccRule, 'ServicePrecedence> =
            state.assignments.Add(fun config -> config.MobileNetworkId <- value)
            ({ assignments = state.assignments } : MobileNetworkServiceState<'Location, Present, 'Name, 'PccRule, 'ServicePrecedence>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#name-1">MobileNetworkService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MobileNetworkServiceState<'Location, 'MobileNetworkId, Missing, 'PccRule, 'ServicePrecedence>, value: string) : MobileNetworkServiceState<'Location, 'MobileNetworkId, Present, 'PccRule, 'ServicePrecedence> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MobileNetworkServiceState<'Location, 'MobileNetworkId, Present, 'PccRule, 'ServicePrecedence>)

        /// <summary>
        /// pcc_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#pcc_rule-1">MobileNetworkService#pcc_rule</a> Accepts: azurerm.IResolvable | azurerm.MobileNetworkService.MobileNetworkServicePccRule[]
        /// </summary>
        [<CustomOperation "pcc_rule">]
        member _.PccRule(state: MobileNetworkServiceState<'Location, 'MobileNetworkId, 'Name, Missing, 'ServicePrecedence>, value: HashiCorp.Cdktf.IResolvable) : MobileNetworkServiceState<'Location, 'MobileNetworkId, 'Name, Present, 'ServicePrecedence> =
            state.assignments.Add(fun config -> config.PccRule <- value)
            ({ assignments = state.assignments } : MobileNetworkServiceState<'Location, 'MobileNetworkId, 'Name, Present, 'ServicePrecedence>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#service_precedence-1">MobileNetworkService#service_precedence</a>.
        /// </summary>
        [<CustomOperation "service_precedence">]
        member _.ServicePrecedence(state: MobileNetworkServiceState<'Location, 'MobileNetworkId, 'Name, 'PccRule, Missing>, value: double) : MobileNetworkServiceState<'Location, 'MobileNetworkId, 'Name, 'PccRule, Present> =
            state.assignments.Add(fun config -> config.ServicePrecedence <- value)
            ({ assignments = state.assignments } : MobileNetworkServiceState<'Location, 'MobileNetworkId, 'Name, 'PccRule, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#id-1">MobileNetworkService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MobileNetworkServiceState<'Location, 'MobileNetworkId, 'Name, 'PccRule, 'ServicePrecedence>, value: string) : MobileNetworkServiceState<'Location, 'MobileNetworkId, 'Name, 'PccRule, 'ServicePrecedence> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MobileNetworkServiceState<'Location, 'MobileNetworkId, 'Name, 'PccRule, 'ServicePrecedence>

        /// <summary>
        /// service_qos_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#service_qos_policy-1">MobileNetworkService#service_qos_policy</a>
        /// </summary>
        [<CustomOperation "service_qos_policy">]
        member _.ServiceQosPolicy(state: MobileNetworkServiceState<'Location, 'MobileNetworkId, 'Name, 'PccRule, 'ServicePrecedence>, value: azurerm.MobileNetworkService.MobileNetworkServiceServiceQosPolicy) : MobileNetworkServiceState<'Location, 'MobileNetworkId, 'Name, 'PccRule, 'ServicePrecedence> =
            state.assignments.Add(fun config -> config.ServiceQosPolicy <- value)
            state : MobileNetworkServiceState<'Location, 'MobileNetworkId, 'Name, 'PccRule, 'ServicePrecedence>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#tags-1">MobileNetworkService#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MobileNetworkServiceState<'Location, 'MobileNetworkId, 'Name, 'PccRule, 'ServicePrecedence>, value: seq<string * string>) : MobileNetworkServiceState<'Location, 'MobileNetworkId, 'Name, 'PccRule, 'ServicePrecedence> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MobileNetworkServiceState<'Location, 'MobileNetworkId, 'Name, 'PccRule, 'ServicePrecedence>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#timeouts-1">MobileNetworkService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MobileNetworkServiceState<'Location, 'MobileNetworkId, 'Name, 'PccRule, 'ServicePrecedence>, value: azurerm.MobileNetworkService.MobileNetworkServiceTimeouts) : MobileNetworkServiceState<'Location, 'MobileNetworkId, 'Name, 'PccRule, 'ServicePrecedence> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MobileNetworkServiceState<'Location, 'MobileNetworkId, 'Name, 'PccRule, 'ServicePrecedence>

        member _.Run(state: MobileNetworkServiceState<Present, Present, Present, Present, Present>) : azurerm.MobileNetworkService.MobileNetworkService =
            let config = azurerm.MobileNetworkService.MobileNetworkServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.MobileNetworkService.MobileNetworkService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mobileNetworkService: missing required arguments. Must call: location, mobile_network_id, name, pcc_rule, service_precedence.", 9999, IsError = true)>]
        member _.Run(_: MobileNetworkServiceState<_, _, _, _, _>) : azurerm.MobileNetworkService.MobileNetworkService =
            Unchecked.defaultof<azurerm.MobileNetworkService.MobileNetworkService>
