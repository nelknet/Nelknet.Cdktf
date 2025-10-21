namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApplicationLoadBalancerState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ApplicationLoadBalancer.ApplicationLoadBalancerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_load_balancer">azurerm_application_load_balancer</a>.
    /// </summary>
    type ApplicationLoadBalancerBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApplicationLoadBalancerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApplicationLoadBalancerState<Missing, Missing, Missing>)

        member _.Zero(()) : ApplicationLoadBalancerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApplicationLoadBalancerState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_load_balancer#location-1">ApplicationLoadBalancer#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ApplicationLoadBalancerState<Missing, 'Name, 'ResourceGroupName>, value: string) : ApplicationLoadBalancerState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ApplicationLoadBalancerState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_load_balancer#name-1">ApplicationLoadBalancer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApplicationLoadBalancerState<'Location, Missing, 'ResourceGroupName>, value: string) : ApplicationLoadBalancerState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApplicationLoadBalancerState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_load_balancer#resource_group_name-1">ApplicationLoadBalancer#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApplicationLoadBalancerState<'Location, 'Name, Missing>, value: string) : ApplicationLoadBalancerState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApplicationLoadBalancerState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_load_balancer#id-1">ApplicationLoadBalancer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApplicationLoadBalancerState<'Location, 'Name, 'ResourceGroupName>, value: string) : ApplicationLoadBalancerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApplicationLoadBalancerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_load_balancer#tags-1">ApplicationLoadBalancer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ApplicationLoadBalancerState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : ApplicationLoadBalancerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ApplicationLoadBalancerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_load_balancer#timeouts-1">ApplicationLoadBalancer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApplicationLoadBalancerState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.ApplicationLoadBalancer.ApplicationLoadBalancerTimeouts) : ApplicationLoadBalancerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApplicationLoadBalancerState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: ApplicationLoadBalancerState<Present, Present, Present>) : azurerm.ApplicationLoadBalancer.ApplicationLoadBalancer =
            let config = azurerm.ApplicationLoadBalancer.ApplicationLoadBalancerConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApplicationLoadBalancer.ApplicationLoadBalancer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.applicationLoadBalancer: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApplicationLoadBalancerState<_, _, _>) : azurerm.ApplicationLoadBalancer.ApplicationLoadBalancer =
            Unchecked.defaultof<azurerm.ApplicationLoadBalancer.ApplicationLoadBalancer>
