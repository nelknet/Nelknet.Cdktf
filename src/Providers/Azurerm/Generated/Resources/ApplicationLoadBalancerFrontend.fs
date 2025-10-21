namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApplicationLoadBalancerFrontendState<'ApplicationLoadBalancerId, 'Name> = { assignments: ResizeArray<azurerm.ApplicationLoadBalancerFrontend.ApplicationLoadBalancerFrontendConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_load_balancer_frontend">azurerm_application_load_balancer_frontend</a>.
    /// </summary>
    type ApplicationLoadBalancerFrontendBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApplicationLoadBalancerFrontendState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApplicationLoadBalancerFrontendState<Missing, Missing>)

        member _.Zero(()) : ApplicationLoadBalancerFrontendState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApplicationLoadBalancerFrontendState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_load_balancer_frontend#application_load_balancer_id-1">ApplicationLoadBalancerFrontend#application_load_balancer_id</a>.
        /// </summary>
        [<CustomOperation "application_load_balancer_id">]
        member _.ApplicationLoadBalancerId(state: ApplicationLoadBalancerFrontendState<Missing, 'Name>, value: string) : ApplicationLoadBalancerFrontendState<Present, 'Name> =
            state.assignments.Add(fun config -> config.ApplicationLoadBalancerId <- value)
            ({ assignments = state.assignments } : ApplicationLoadBalancerFrontendState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_load_balancer_frontend#name-1">ApplicationLoadBalancerFrontend#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApplicationLoadBalancerFrontendState<'ApplicationLoadBalancerId, Missing>, value: string) : ApplicationLoadBalancerFrontendState<'ApplicationLoadBalancerId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApplicationLoadBalancerFrontendState<'ApplicationLoadBalancerId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_load_balancer_frontend#id-1">ApplicationLoadBalancerFrontend#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApplicationLoadBalancerFrontendState<'ApplicationLoadBalancerId, 'Name>, value: string) : ApplicationLoadBalancerFrontendState<'ApplicationLoadBalancerId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApplicationLoadBalancerFrontendState<'ApplicationLoadBalancerId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_load_balancer_frontend#tags-1">ApplicationLoadBalancerFrontend#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ApplicationLoadBalancerFrontendState<'ApplicationLoadBalancerId, 'Name>, value: seq<string * string>) : ApplicationLoadBalancerFrontendState<'ApplicationLoadBalancerId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ApplicationLoadBalancerFrontendState<'ApplicationLoadBalancerId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_load_balancer_frontend#timeouts-1">ApplicationLoadBalancerFrontend#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApplicationLoadBalancerFrontendState<'ApplicationLoadBalancerId, 'Name>, value: azurerm.ApplicationLoadBalancerFrontend.ApplicationLoadBalancerFrontendTimeouts) : ApplicationLoadBalancerFrontendState<'ApplicationLoadBalancerId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApplicationLoadBalancerFrontendState<'ApplicationLoadBalancerId, 'Name>

        member _.Run(state: ApplicationLoadBalancerFrontendState<Present, Present>) : azurerm.ApplicationLoadBalancerFrontend.ApplicationLoadBalancerFrontend =
            let config = azurerm.ApplicationLoadBalancerFrontend.ApplicationLoadBalancerFrontendConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApplicationLoadBalancerFrontend.ApplicationLoadBalancerFrontend(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.applicationLoadBalancerFrontend: missing required arguments. Must call: application_load_balancer_id, name.", 9999, IsError = true)>]
        member _.Run(_: ApplicationLoadBalancerFrontendState<_, _>) : azurerm.ApplicationLoadBalancerFrontend.ApplicationLoadBalancerFrontend =
            Unchecked.defaultof<azurerm.ApplicationLoadBalancerFrontend.ApplicationLoadBalancerFrontend>
