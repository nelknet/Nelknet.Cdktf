namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecurityCenterSubscriptionPricingState<'Tier> = { assignments: ResizeArray<azurerm.SecurityCenterSubscriptionPricing.SecurityCenterSubscriptionPricingConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_subscription_pricing">azurerm_security_center_subscription_pricing</a>.
    /// </summary>
    type SecurityCenterSubscriptionPricingBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecurityCenterSubscriptionPricingState<Missing> =
            ({ assignments = ResizeArray() } : SecurityCenterSubscriptionPricingState<Missing>)

        member _.Zero(()) : SecurityCenterSubscriptionPricingState<Missing> =
            ({ assignments = ResizeArray() } : SecurityCenterSubscriptionPricingState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_subscription_pricing#tier-1">SecurityCenterSubscriptionPricing#tier</a>.
        /// </summary>
        [<CustomOperation "tier">]
        member _.Tier(state: SecurityCenterSubscriptionPricingState<Missing>, value: string) : SecurityCenterSubscriptionPricingState<Present> =
            state.assignments.Add(fun config -> config.Tier <- value)
            ({ assignments = state.assignments } : SecurityCenterSubscriptionPricingState<Present>)

        /// <summary>
        /// extension block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_subscription_pricing#extension-1">SecurityCenterSubscriptionPricing#extension</a> Accepts: azurerm.IResolvable | azurerm.SecurityCenterSubscriptionPricing.SecurityCenterSubscriptionPricingExtension[]
        /// </summary>
        [<CustomOperation "extension">]
        member _.Extension(state: SecurityCenterSubscriptionPricingState<'Tier>, value: HashiCorp.Cdktf.IResolvable) : SecurityCenterSubscriptionPricingState<'Tier> =
            state.assignments.Add(fun config -> config.Extension <- value)
            state : SecurityCenterSubscriptionPricingState<'Tier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_subscription_pricing#id-1">SecurityCenterSubscriptionPricing#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SecurityCenterSubscriptionPricingState<'Tier>, value: string) : SecurityCenterSubscriptionPricingState<'Tier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SecurityCenterSubscriptionPricingState<'Tier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_subscription_pricing#resource_type-1">SecurityCenterSubscriptionPricing#resource_type</a>.
        /// </summary>
        [<CustomOperation "resource_type">]
        member _.ResourceType(state: SecurityCenterSubscriptionPricingState<'Tier>, value: string) : SecurityCenterSubscriptionPricingState<'Tier> =
            state.assignments.Add(fun config -> config.ResourceType <- value)
            state : SecurityCenterSubscriptionPricingState<'Tier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_subscription_pricing#subplan-1">SecurityCenterSubscriptionPricing#subplan</a>.
        /// </summary>
        [<CustomOperation "subplan">]
        member _.Subplan(state: SecurityCenterSubscriptionPricingState<'Tier>, value: string) : SecurityCenterSubscriptionPricingState<'Tier> =
            state.assignments.Add(fun config -> config.Subplan <- value)
            state : SecurityCenterSubscriptionPricingState<'Tier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_subscription_pricing#timeouts-1">SecurityCenterSubscriptionPricing#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SecurityCenterSubscriptionPricingState<'Tier>, value: azurerm.SecurityCenterSubscriptionPricing.SecurityCenterSubscriptionPricingTimeouts) : SecurityCenterSubscriptionPricingState<'Tier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SecurityCenterSubscriptionPricingState<'Tier>

        member _.Run(state: SecurityCenterSubscriptionPricingState<Present>) : azurerm.SecurityCenterSubscriptionPricing.SecurityCenterSubscriptionPricing =
            let config = azurerm.SecurityCenterSubscriptionPricing.SecurityCenterSubscriptionPricingConfig()
            for setter in state.assignments do
                setter config
            azurerm.SecurityCenterSubscriptionPricing.SecurityCenterSubscriptionPricing(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.securityCenterSubscriptionPricing: missing required arguments. Must call: tier.", 9999, IsError = true)>]
        member _.Run(_: SecurityCenterSubscriptionPricingState<_>) : azurerm.SecurityCenterSubscriptionPricing.SecurityCenterSubscriptionPricing =
            Unchecked.defaultof<azurerm.SecurityCenterSubscriptionPricing.SecurityCenterSubscriptionPricing>
