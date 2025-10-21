namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudGatewayCustomDomainState<'Name, 'SpringCloudGatewayId> = { assignments: ResizeArray<azurerm.SpringCloudGatewayCustomDomain.SpringCloudGatewayCustomDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway_custom_domain">azurerm_spring_cloud_gateway_custom_domain</a>.
    /// </summary>
    type SpringCloudGatewayCustomDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudGatewayCustomDomainState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudGatewayCustomDomainState<Missing, Missing>)

        member _.Zero(()) : SpringCloudGatewayCustomDomainState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudGatewayCustomDomainState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway_custom_domain#name-1">SpringCloudGatewayCustomDomain#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudGatewayCustomDomainState<Missing, 'SpringCloudGatewayId>, value: string) : SpringCloudGatewayCustomDomainState<Present, 'SpringCloudGatewayId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudGatewayCustomDomainState<Present, 'SpringCloudGatewayId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway_custom_domain#spring_cloud_gateway_id-1">SpringCloudGatewayCustomDomain#spring_cloud_gateway_id</a>.
        /// </summary>
        [<CustomOperation "spring_cloud_gateway_id">]
        member _.SpringCloudGatewayId(state: SpringCloudGatewayCustomDomainState<'Name, Missing>, value: string) : SpringCloudGatewayCustomDomainState<'Name, Present> =
            state.assignments.Add(fun config -> config.SpringCloudGatewayId <- value)
            ({ assignments = state.assignments } : SpringCloudGatewayCustomDomainState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway_custom_domain#id-1">SpringCloudGatewayCustomDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudGatewayCustomDomainState<'Name, 'SpringCloudGatewayId>, value: string) : SpringCloudGatewayCustomDomainState<'Name, 'SpringCloudGatewayId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudGatewayCustomDomainState<'Name, 'SpringCloudGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway_custom_domain#thumbprint-1">SpringCloudGatewayCustomDomain#thumbprint</a>.
        /// </summary>
        [<CustomOperation "thumbprint">]
        member _.Thumbprint(state: SpringCloudGatewayCustomDomainState<'Name, 'SpringCloudGatewayId>, value: string) : SpringCloudGatewayCustomDomainState<'Name, 'SpringCloudGatewayId> =
            state.assignments.Add(fun config -> config.Thumbprint <- value)
            state : SpringCloudGatewayCustomDomainState<'Name, 'SpringCloudGatewayId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway_custom_domain#timeouts-1">SpringCloudGatewayCustomDomain#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudGatewayCustomDomainState<'Name, 'SpringCloudGatewayId>, value: azurerm.SpringCloudGatewayCustomDomain.SpringCloudGatewayCustomDomainTimeouts) : SpringCloudGatewayCustomDomainState<'Name, 'SpringCloudGatewayId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudGatewayCustomDomainState<'Name, 'SpringCloudGatewayId>

        member _.Run(state: SpringCloudGatewayCustomDomainState<Present, Present>) : azurerm.SpringCloudGatewayCustomDomain.SpringCloudGatewayCustomDomain =
            let config = azurerm.SpringCloudGatewayCustomDomain.SpringCloudGatewayCustomDomainConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudGatewayCustomDomain.SpringCloudGatewayCustomDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudGatewayCustomDomain: missing required arguments. Must call: name, spring_cloud_gateway_id.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudGatewayCustomDomainState<_, _>) : azurerm.SpringCloudGatewayCustomDomain.SpringCloudGatewayCustomDomain =
            Unchecked.defaultof<azurerm.SpringCloudGatewayCustomDomain.SpringCloudGatewayCustomDomain>
