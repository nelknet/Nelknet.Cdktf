namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudApiPortalState<'Name, 'SpringCloudServiceId> = { assignments: ResizeArray<azurerm.SpringCloudApiPortal.SpringCloudApiPortalConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_api_portal">azurerm_spring_cloud_api_portal</a>.
    /// </summary>
    type SpringCloudApiPortalBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudApiPortalState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudApiPortalState<Missing, Missing>)

        member _.Zero(()) : SpringCloudApiPortalState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudApiPortalState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_api_portal#name-1">SpringCloudApiPortal#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudApiPortalState<Missing, 'SpringCloudServiceId>, value: string) : SpringCloudApiPortalState<Present, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudApiPortalState<Present, 'SpringCloudServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_api_portal#spring_cloud_service_id-1">SpringCloudApiPortal#spring_cloud_service_id</a>.
        /// </summary>
        [<CustomOperation "spring_cloud_service_id">]
        member _.SpringCloudServiceId(state: SpringCloudApiPortalState<'Name, Missing>, value: string) : SpringCloudApiPortalState<'Name, Present> =
            state.assignments.Add(fun config -> config.SpringCloudServiceId <- value)
            ({ assignments = state.assignments } : SpringCloudApiPortalState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_api_portal#api_try_out_enabled-1">SpringCloudApiPortal#api_try_out_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "api_try_out_enabled">]
        member _.ApiTryOutEnabled(state: SpringCloudApiPortalState<'Name, 'SpringCloudServiceId>, value: bool) : SpringCloudApiPortalState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.ApiTryOutEnabled <- value)
            state : SpringCloudApiPortalState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_api_portal#api_try_out_enabled-1">SpringCloudApiPortal#api_try_out_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "api_try_out_enabled">]
        member _.ApiTryOutEnabled(state: SpringCloudApiPortalState<'Name, 'SpringCloudServiceId>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudApiPortalState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.ApiTryOutEnabled <- value)
            state : SpringCloudApiPortalState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_api_portal#gateway_ids-1">SpringCloudApiPortal#gateway_ids</a>.
        /// </summary>
        [<CustomOperation "gateway_ids">]
        member _.GatewayIds(state: SpringCloudApiPortalState<'Name, 'SpringCloudServiceId>, value: seq<string>) : SpringCloudApiPortalState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.GatewayIds <- (value |> Seq.toArray))
            state : SpringCloudApiPortalState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_api_portal#https_only_enabled-1">SpringCloudApiPortal#https_only_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only_enabled">]
        member _.HttpsOnlyEnabled(state: SpringCloudApiPortalState<'Name, 'SpringCloudServiceId>, value: bool) : SpringCloudApiPortalState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.HttpsOnlyEnabled <- value)
            state : SpringCloudApiPortalState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_api_portal#https_only_enabled-1">SpringCloudApiPortal#https_only_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only_enabled">]
        member _.HttpsOnlyEnabled(state: SpringCloudApiPortalState<'Name, 'SpringCloudServiceId>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudApiPortalState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.HttpsOnlyEnabled <- value)
            state : SpringCloudApiPortalState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_api_portal#id-1">SpringCloudApiPortal#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudApiPortalState<'Name, 'SpringCloudServiceId>, value: string) : SpringCloudApiPortalState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudApiPortalState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_api_portal#instance_count-1">SpringCloudApiPortal#instance_count</a>.
        /// </summary>
        [<CustomOperation "instance_count">]
        member _.InstanceCount(state: SpringCloudApiPortalState<'Name, 'SpringCloudServiceId>, value: double) : SpringCloudApiPortalState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.InstanceCount <- value)
            state : SpringCloudApiPortalState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_api_portal#public_network_access_enabled-1">SpringCloudApiPortal#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: SpringCloudApiPortalState<'Name, 'SpringCloudServiceId>, value: bool) : SpringCloudApiPortalState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : SpringCloudApiPortalState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_api_portal#public_network_access_enabled-1">SpringCloudApiPortal#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: SpringCloudApiPortalState<'Name, 'SpringCloudServiceId>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudApiPortalState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : SpringCloudApiPortalState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// sso block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_api_portal#sso-1">SpringCloudApiPortal#sso</a>
        /// </summary>
        [<CustomOperation "sso">]
        member _.Sso(state: SpringCloudApiPortalState<'Name, 'SpringCloudServiceId>, value: azurerm.SpringCloudApiPortal.SpringCloudApiPortalSso) : SpringCloudApiPortalState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Sso <- value)
            state : SpringCloudApiPortalState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_api_portal#timeouts-1">SpringCloudApiPortal#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudApiPortalState<'Name, 'SpringCloudServiceId>, value: azurerm.SpringCloudApiPortal.SpringCloudApiPortalTimeouts) : SpringCloudApiPortalState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudApiPortalState<'Name, 'SpringCloudServiceId>

        member _.Run(state: SpringCloudApiPortalState<Present, Present>) : azurerm.SpringCloudApiPortal.SpringCloudApiPortal =
            let config = azurerm.SpringCloudApiPortal.SpringCloudApiPortalConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudApiPortal.SpringCloudApiPortal(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudApiPortal: missing required arguments. Must call: name, spring_cloud_service_id.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudApiPortalState<_, _>) : azurerm.SpringCloudApiPortal.SpringCloudApiPortal =
            Unchecked.defaultof<azurerm.SpringCloudApiPortal.SpringCloudApiPortal>
