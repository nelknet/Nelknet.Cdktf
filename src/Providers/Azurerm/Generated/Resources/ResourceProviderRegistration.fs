namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ResourceProviderRegistrationState<'Name> = { assignments: ResizeArray<azurerm.ResourceProviderRegistration.ResourceProviderRegistrationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_provider_registration">azurerm_resource_provider_registration</a>.
    /// </summary>
    type ResourceProviderRegistrationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ResourceProviderRegistrationState<Missing> =
            ({ assignments = ResizeArray() } : ResourceProviderRegistrationState<Missing>)

        member _.Zero(()) : ResourceProviderRegistrationState<Missing> =
            ({ assignments = ResizeArray() } : ResourceProviderRegistrationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_provider_registration#name-1">ResourceProviderRegistration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ResourceProviderRegistrationState<Missing>, value: string) : ResourceProviderRegistrationState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ResourceProviderRegistrationState<Present>)

        /// <summary>
        /// feature block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_provider_registration#feature-1">ResourceProviderRegistration#feature</a> Accepts: azurerm.IResolvable | azurerm.ResourceProviderRegistration.ResourceProviderRegistrationFeature[]
        /// </summary>
        [<CustomOperation "feature">]
        member _.Feature(state: ResourceProviderRegistrationState<'Name>, value: HashiCorp.Cdktf.IResolvable) : ResourceProviderRegistrationState<'Name> =
            state.assignments.Add(fun config -> config.Feature <- value)
            state : ResourceProviderRegistrationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_provider_registration#id-1">ResourceProviderRegistration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ResourceProviderRegistrationState<'Name>, value: string) : ResourceProviderRegistrationState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ResourceProviderRegistrationState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_provider_registration#timeouts-1">ResourceProviderRegistration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ResourceProviderRegistrationState<'Name>, value: azurerm.ResourceProviderRegistration.ResourceProviderRegistrationTimeouts) : ResourceProviderRegistrationState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ResourceProviderRegistrationState<'Name>

        member _.Run(state: ResourceProviderRegistrationState<Present>) : azurerm.ResourceProviderRegistration.ResourceProviderRegistration =
            let config = azurerm.ResourceProviderRegistration.ResourceProviderRegistrationConfig()
            for setter in state.assignments do
                setter config
            azurerm.ResourceProviderRegistration.ResourceProviderRegistration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.resourceProviderRegistration: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: ResourceProviderRegistrationState<_>) : azurerm.ResourceProviderRegistration.ResourceProviderRegistration =
            Unchecked.defaultof<azurerm.ResourceProviderRegistration.ResourceProviderRegistration>
