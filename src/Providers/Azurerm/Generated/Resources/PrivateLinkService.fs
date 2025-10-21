namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, 'NatIpConfiguration, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.PrivateLinkService.PrivateLinkServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_link_service">azurerm_private_link_service</a>.
    /// </summary>
    type PrivateLinkServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : PrivateLinkServiceState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateLinkServiceState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PrivateLinkServiceState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateLinkServiceState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_link_service#load_balancer_frontend_ip_configuration_ids-1">PrivateLinkService#load_balancer_frontend_ip_configuration_ids</a>.
        /// </summary>
        [<CustomOperation "load_balancer_frontend_ip_configuration_ids">]
        member _.LoadBalancerFrontendIpConfigurationIds(state: PrivateLinkServiceState<Missing, 'Location, 'Name, 'NatIpConfiguration, 'ResourceGroupName>, value: seq<string>) : PrivateLinkServiceState<Present, 'Location, 'Name, 'NatIpConfiguration, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LoadBalancerFrontendIpConfigurationIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : PrivateLinkServiceState<Present, 'Location, 'Name, 'NatIpConfiguration, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_link_service#location-1">PrivateLinkService#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, Missing, 'Name, 'NatIpConfiguration, 'ResourceGroupName>, value: string) : PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, Present, 'Name, 'NatIpConfiguration, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, Present, 'Name, 'NatIpConfiguration, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_link_service#name-1">PrivateLinkService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, Missing, 'NatIpConfiguration, 'ResourceGroupName>, value: string) : PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, Present, 'NatIpConfiguration, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, Present, 'NatIpConfiguration, 'ResourceGroupName>)

        /// <summary>
        /// nat_ip_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_link_service#nat_ip_configuration-1">PrivateLinkService#nat_ip_configuration</a> Accepts: azurerm.IResolvable | azurerm.PrivateLinkService.PrivateLinkServiceNatIpConfiguration[]
        /// </summary>
        [<CustomOperation "nat_ip_configuration">]
        member _.NatIpConfiguration(state: PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, Missing, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NatIpConfiguration <- value)
            ({ assignments = state.assignments } : PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_link_service#resource_group_name-1">PrivateLinkService#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, 'NatIpConfiguration, Missing>, value: string) : PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, 'NatIpConfiguration, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, 'NatIpConfiguration, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_link_service#auto_approval_subscription_ids-1">PrivateLinkService#auto_approval_subscription_ids</a>.
        /// </summary>
        [<CustomOperation "auto_approval_subscription_ids">]
        member _.AutoApprovalSubscriptionIds(state: PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, 'NatIpConfiguration, 'ResourceGroupName>, value: seq<string>) : PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, 'NatIpConfiguration, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutoApprovalSubscriptionIds <- (value |> Seq.toArray))
            state : PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, 'NatIpConfiguration, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_link_service#enable_proxy_protocol-1">PrivateLinkService#enable_proxy_protocol</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_proxy_protocol">]
        member _.EnableProxyProtocol(state: PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, 'NatIpConfiguration, 'ResourceGroupName>, value: bool) : PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, 'NatIpConfiguration, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EnableProxyProtocol <- value)
            state : PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, 'NatIpConfiguration, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_link_service#enable_proxy_protocol-1">PrivateLinkService#enable_proxy_protocol</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_proxy_protocol">]
        member _.EnableProxyProtocol(state: PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, 'NatIpConfiguration, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, 'NatIpConfiguration, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EnableProxyProtocol <- value)
            state : PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, 'NatIpConfiguration, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_link_service#fqdns-1">PrivateLinkService#fqdns</a>.
        /// </summary>
        [<CustomOperation "fqdns">]
        member _.Fqdns(state: PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, 'NatIpConfiguration, 'ResourceGroupName>, value: seq<string>) : PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, 'NatIpConfiguration, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Fqdns <- (value |> Seq.toArray))
            state : PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, 'NatIpConfiguration, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_link_service#id-1">PrivateLinkService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, 'NatIpConfiguration, 'ResourceGroupName>, value: string) : PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, 'NatIpConfiguration, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, 'NatIpConfiguration, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_link_service#tags-1">PrivateLinkService#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, 'NatIpConfiguration, 'ResourceGroupName>, value: seq<string * string>) : PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, 'NatIpConfiguration, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, 'NatIpConfiguration, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_link_service#timeouts-1">PrivateLinkService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, 'NatIpConfiguration, 'ResourceGroupName>, value: azurerm.PrivateLinkService.PrivateLinkServiceTimeouts) : PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, 'NatIpConfiguration, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, 'NatIpConfiguration, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_link_service#visibility_subscription_ids-1">PrivateLinkService#visibility_subscription_ids</a>.
        /// </summary>
        [<CustomOperation "visibility_subscription_ids">]
        member _.VisibilitySubscriptionIds(state: PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, 'NatIpConfiguration, 'ResourceGroupName>, value: seq<string>) : PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, 'NatIpConfiguration, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.VisibilitySubscriptionIds <- (value |> Seq.toArray))
            state : PrivateLinkServiceState<'LoadBalancerFrontendIpConfigurationIds, 'Location, 'Name, 'NatIpConfiguration, 'ResourceGroupName>

        member _.Run(state: PrivateLinkServiceState<Present, Present, Present, Present, Present>) : azurerm.PrivateLinkService.PrivateLinkService =
            let config = azurerm.PrivateLinkService.PrivateLinkServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.PrivateLinkService.PrivateLinkService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.privateLinkService: missing required arguments. Must call: load_balancer_frontend_ip_configuration_ids, location, name, nat_ip_configuration, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: PrivateLinkServiceState<_, _, _, _, _>) : azurerm.PrivateLinkService.PrivateLinkService =
            Unchecked.defaultof<azurerm.PrivateLinkService.PrivateLinkService>
