namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudApplicationLiveViewState<'Name, 'SpringCloudServiceId> = { assignments: ResizeArray<azurerm.SpringCloudApplicationLiveView.SpringCloudApplicationLiveViewConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_application_live_view">azurerm_spring_cloud_application_live_view</a>.
    /// </summary>
    type SpringCloudApplicationLiveViewBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudApplicationLiveViewState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudApplicationLiveViewState<Missing, Missing>)

        member _.Zero(()) : SpringCloudApplicationLiveViewState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudApplicationLiveViewState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_application_live_view#name-1">SpringCloudApplicationLiveView#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudApplicationLiveViewState<Missing, 'SpringCloudServiceId>, value: string) : SpringCloudApplicationLiveViewState<Present, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudApplicationLiveViewState<Present, 'SpringCloudServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_application_live_view#spring_cloud_service_id-1">SpringCloudApplicationLiveView#spring_cloud_service_id</a>.
        /// </summary>
        [<CustomOperation "spring_cloud_service_id">]
        member _.SpringCloudServiceId(state: SpringCloudApplicationLiveViewState<'Name, Missing>, value: string) : SpringCloudApplicationLiveViewState<'Name, Present> =
            state.assignments.Add(fun config -> config.SpringCloudServiceId <- value)
            ({ assignments = state.assignments } : SpringCloudApplicationLiveViewState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_application_live_view#id-1">SpringCloudApplicationLiveView#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudApplicationLiveViewState<'Name, 'SpringCloudServiceId>, value: string) : SpringCloudApplicationLiveViewState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudApplicationLiveViewState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_application_live_view#timeouts-1">SpringCloudApplicationLiveView#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudApplicationLiveViewState<'Name, 'SpringCloudServiceId>, value: azurerm.SpringCloudApplicationLiveView.SpringCloudApplicationLiveViewTimeouts) : SpringCloudApplicationLiveViewState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudApplicationLiveViewState<'Name, 'SpringCloudServiceId>

        member _.Run(state: SpringCloudApplicationLiveViewState<Present, Present>) : azurerm.SpringCloudApplicationLiveView.SpringCloudApplicationLiveView =
            let config = azurerm.SpringCloudApplicationLiveView.SpringCloudApplicationLiveViewConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudApplicationLiveView.SpringCloudApplicationLiveView(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudApplicationLiveView: missing required arguments. Must call: name, spring_cloud_service_id.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudApplicationLiveViewState<_, _>) : azurerm.SpringCloudApplicationLiveView.SpringCloudApplicationLiveView =
            Unchecked.defaultof<azurerm.SpringCloudApplicationLiveView.SpringCloudApplicationLiveView>
