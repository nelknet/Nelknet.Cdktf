namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudDevToolPortalState<'Name, 'SpringCloudServiceId> = { assignments: ResizeArray<azurerm.SpringCloudDevToolPortal.SpringCloudDevToolPortalConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_dev_tool_portal">azurerm_spring_cloud_dev_tool_portal</a>.
    /// </summary>
    type SpringCloudDevToolPortalBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudDevToolPortalState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudDevToolPortalState<Missing, Missing>)

        member _.Zero(()) : SpringCloudDevToolPortalState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudDevToolPortalState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_dev_tool_portal#name-1">SpringCloudDevToolPortal#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudDevToolPortalState<Missing, 'SpringCloudServiceId>, value: string) : SpringCloudDevToolPortalState<Present, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudDevToolPortalState<Present, 'SpringCloudServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_dev_tool_portal#spring_cloud_service_id-1">SpringCloudDevToolPortal#spring_cloud_service_id</a>.
        /// </summary>
        [<CustomOperation "spring_cloud_service_id">]
        member _.SpringCloudServiceId(state: SpringCloudDevToolPortalState<'Name, Missing>, value: string) : SpringCloudDevToolPortalState<'Name, Present> =
            state.assignments.Add(fun config -> config.SpringCloudServiceId <- value)
            ({ assignments = state.assignments } : SpringCloudDevToolPortalState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_dev_tool_portal#application_accelerator_enabled-1">SpringCloudDevToolPortal#application_accelerator_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "application_accelerator_enabled">]
        member _.ApplicationAcceleratorEnabled(state: SpringCloudDevToolPortalState<'Name, 'SpringCloudServiceId>, value: bool) : SpringCloudDevToolPortalState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.ApplicationAcceleratorEnabled <- value)
            state : SpringCloudDevToolPortalState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_dev_tool_portal#application_accelerator_enabled-1">SpringCloudDevToolPortal#application_accelerator_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "application_accelerator_enabled">]
        member _.ApplicationAcceleratorEnabled(state: SpringCloudDevToolPortalState<'Name, 'SpringCloudServiceId>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudDevToolPortalState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.ApplicationAcceleratorEnabled <- value)
            state : SpringCloudDevToolPortalState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_dev_tool_portal#application_live_view_enabled-1">SpringCloudDevToolPortal#application_live_view_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "application_live_view_enabled">]
        member _.ApplicationLiveViewEnabled(state: SpringCloudDevToolPortalState<'Name, 'SpringCloudServiceId>, value: bool) : SpringCloudDevToolPortalState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.ApplicationLiveViewEnabled <- value)
            state : SpringCloudDevToolPortalState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_dev_tool_portal#application_live_view_enabled-1">SpringCloudDevToolPortal#application_live_view_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "application_live_view_enabled">]
        member _.ApplicationLiveViewEnabled(state: SpringCloudDevToolPortalState<'Name, 'SpringCloudServiceId>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudDevToolPortalState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.ApplicationLiveViewEnabled <- value)
            state : SpringCloudDevToolPortalState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_dev_tool_portal#id-1">SpringCloudDevToolPortal#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudDevToolPortalState<'Name, 'SpringCloudServiceId>, value: string) : SpringCloudDevToolPortalState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudDevToolPortalState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_dev_tool_portal#public_network_access_enabled-1">SpringCloudDevToolPortal#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: SpringCloudDevToolPortalState<'Name, 'SpringCloudServiceId>, value: bool) : SpringCloudDevToolPortalState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : SpringCloudDevToolPortalState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_dev_tool_portal#public_network_access_enabled-1">SpringCloudDevToolPortal#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: SpringCloudDevToolPortalState<'Name, 'SpringCloudServiceId>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudDevToolPortalState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : SpringCloudDevToolPortalState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// sso block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_dev_tool_portal#sso-1">SpringCloudDevToolPortal#sso</a>
        /// </summary>
        [<CustomOperation "sso">]
        member _.Sso(state: SpringCloudDevToolPortalState<'Name, 'SpringCloudServiceId>, value: azurerm.SpringCloudDevToolPortal.SpringCloudDevToolPortalSso) : SpringCloudDevToolPortalState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Sso <- value)
            state : SpringCloudDevToolPortalState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_dev_tool_portal#timeouts-1">SpringCloudDevToolPortal#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudDevToolPortalState<'Name, 'SpringCloudServiceId>, value: azurerm.SpringCloudDevToolPortal.SpringCloudDevToolPortalTimeouts) : SpringCloudDevToolPortalState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudDevToolPortalState<'Name, 'SpringCloudServiceId>

        member _.Run(state: SpringCloudDevToolPortalState<Present, Present>) : azurerm.SpringCloudDevToolPortal.SpringCloudDevToolPortal =
            let config = azurerm.SpringCloudDevToolPortal.SpringCloudDevToolPortalConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudDevToolPortal.SpringCloudDevToolPortal(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudDevToolPortal: missing required arguments. Must call: name, spring_cloud_service_id.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudDevToolPortalState<_, _>) : azurerm.SpringCloudDevToolPortal.SpringCloudDevToolPortal =
            Unchecked.defaultof<azurerm.SpringCloudDevToolPortal.SpringCloudDevToolPortal>
