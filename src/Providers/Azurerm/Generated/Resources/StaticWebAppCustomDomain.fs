namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StaticWebAppCustomDomainState<'DomainName, 'StaticWebAppId, 'ValidationType> = { assignments: ResizeArray<azurerm.StaticWebAppCustomDomain.StaticWebAppCustomDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app_custom_domain">azurerm_static_web_app_custom_domain</a>.
    /// </summary>
    type StaticWebAppCustomDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : StaticWebAppCustomDomainState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StaticWebAppCustomDomainState<Missing, Missing, Missing>)

        member _.Zero(()) : StaticWebAppCustomDomainState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StaticWebAppCustomDomainState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app_custom_domain#domain_name-1">StaticWebAppCustomDomain#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: StaticWebAppCustomDomainState<Missing, 'StaticWebAppId, 'ValidationType>, value: string) : StaticWebAppCustomDomainState<Present, 'StaticWebAppId, 'ValidationType> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : StaticWebAppCustomDomainState<Present, 'StaticWebAppId, 'ValidationType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app_custom_domain#static_web_app_id-1">StaticWebAppCustomDomain#static_web_app_id</a>.
        /// </summary>
        [<CustomOperation "static_web_app_id">]
        member _.StaticWebAppId(state: StaticWebAppCustomDomainState<'DomainName, Missing, 'ValidationType>, value: string) : StaticWebAppCustomDomainState<'DomainName, Present, 'ValidationType> =
            state.assignments.Add(fun config -> config.StaticWebAppId <- value)
            ({ assignments = state.assignments } : StaticWebAppCustomDomainState<'DomainName, Present, 'ValidationType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app_custom_domain#validation_type-1">StaticWebAppCustomDomain#validation_type</a>.
        /// </summary>
        [<CustomOperation "validation_type">]
        member _.ValidationType(state: StaticWebAppCustomDomainState<'DomainName, 'StaticWebAppId, Missing>, value: string) : StaticWebAppCustomDomainState<'DomainName, 'StaticWebAppId, Present> =
            state.assignments.Add(fun config -> config.ValidationType <- value)
            ({ assignments = state.assignments } : StaticWebAppCustomDomainState<'DomainName, 'StaticWebAppId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app_custom_domain#id-1">StaticWebAppCustomDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StaticWebAppCustomDomainState<'DomainName, 'StaticWebAppId, 'ValidationType>, value: string) : StaticWebAppCustomDomainState<'DomainName, 'StaticWebAppId, 'ValidationType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StaticWebAppCustomDomainState<'DomainName, 'StaticWebAppId, 'ValidationType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app_custom_domain#timeouts-1">StaticWebAppCustomDomain#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StaticWebAppCustomDomainState<'DomainName, 'StaticWebAppId, 'ValidationType>, value: azurerm.StaticWebAppCustomDomain.StaticWebAppCustomDomainTimeouts) : StaticWebAppCustomDomainState<'DomainName, 'StaticWebAppId, 'ValidationType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StaticWebAppCustomDomainState<'DomainName, 'StaticWebAppId, 'ValidationType>

        member _.Run(state: StaticWebAppCustomDomainState<Present, Present, Present>) : azurerm.StaticWebAppCustomDomain.StaticWebAppCustomDomain =
            let config = azurerm.StaticWebAppCustomDomain.StaticWebAppCustomDomainConfig()
            for setter in state.assignments do
                setter config
            azurerm.StaticWebAppCustomDomain.StaticWebAppCustomDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.staticWebAppCustomDomain: missing required arguments. Must call: domain_name, static_web_app_id, validation_type.", 9999, IsError = true)>]
        member _.Run(_: StaticWebAppCustomDomainState<_, _, _>) : azurerm.StaticWebAppCustomDomain.StaticWebAppCustomDomain =
            Unchecked.defaultof<azurerm.StaticWebAppCustomDomain.StaticWebAppCustomDomain>
