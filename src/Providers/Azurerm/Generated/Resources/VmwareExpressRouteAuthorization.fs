namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VmwareExpressRouteAuthorizationState<'Name, 'PrivateCloudId> = { assignments: ResizeArray<azurerm.VmwareExpressRouteAuthorization.VmwareExpressRouteAuthorizationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_express_route_authorization">azurerm_vmware_express_route_authorization</a>.
    /// </summary>
    type VmwareExpressRouteAuthorizationBuilder(logicalId: string) =
        member _.Yield(_: unit) : VmwareExpressRouteAuthorizationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VmwareExpressRouteAuthorizationState<Missing, Missing>)

        member _.Zero(()) : VmwareExpressRouteAuthorizationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VmwareExpressRouteAuthorizationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_express_route_authorization#name-1">VmwareExpressRouteAuthorization#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VmwareExpressRouteAuthorizationState<Missing, 'PrivateCloudId>, value: string) : VmwareExpressRouteAuthorizationState<Present, 'PrivateCloudId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VmwareExpressRouteAuthorizationState<Present, 'PrivateCloudId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_express_route_authorization#private_cloud_id-1">VmwareExpressRouteAuthorization#private_cloud_id</a>.
        /// </summary>
        [<CustomOperation "private_cloud_id">]
        member _.PrivateCloudId(state: VmwareExpressRouteAuthorizationState<'Name, Missing>, value: string) : VmwareExpressRouteAuthorizationState<'Name, Present> =
            state.assignments.Add(fun config -> config.PrivateCloudId <- value)
            ({ assignments = state.assignments } : VmwareExpressRouteAuthorizationState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_express_route_authorization#id-1">VmwareExpressRouteAuthorization#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VmwareExpressRouteAuthorizationState<'Name, 'PrivateCloudId>, value: string) : VmwareExpressRouteAuthorizationState<'Name, 'PrivateCloudId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VmwareExpressRouteAuthorizationState<'Name, 'PrivateCloudId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_express_route_authorization#timeouts-1">VmwareExpressRouteAuthorization#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VmwareExpressRouteAuthorizationState<'Name, 'PrivateCloudId>, value: azurerm.VmwareExpressRouteAuthorization.VmwareExpressRouteAuthorizationTimeouts) : VmwareExpressRouteAuthorizationState<'Name, 'PrivateCloudId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VmwareExpressRouteAuthorizationState<'Name, 'PrivateCloudId>

        member _.Run(state: VmwareExpressRouteAuthorizationState<Present, Present>) : azurerm.VmwareExpressRouteAuthorization.VmwareExpressRouteAuthorization =
            let config = azurerm.VmwareExpressRouteAuthorization.VmwareExpressRouteAuthorizationConfig()
            for setter in state.assignments do
                setter config
            azurerm.VmwareExpressRouteAuthorization.VmwareExpressRouteAuthorization(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.vmwareExpressRouteAuthorization: missing required arguments. Must call: name, private_cloud_id.", 9999, IsError = true)>]
        member _.Run(_: VmwareExpressRouteAuthorizationState<_, _>) : azurerm.VmwareExpressRouteAuthorization.VmwareExpressRouteAuthorization =
            Unchecked.defaultof<azurerm.VmwareExpressRouteAuthorization.VmwareExpressRouteAuthorization>
