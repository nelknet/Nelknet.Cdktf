namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApplicationLoadBalancerSubnetAssociationState<'ApplicationLoadBalancerId, 'Name, 'SubnetId> = { assignments: ResizeArray<azurerm.ApplicationLoadBalancerSubnetAssociation.ApplicationLoadBalancerSubnetAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_load_balancer_subnet_association">azurerm_application_load_balancer_subnet_association</a>.
    /// </summary>
    type ApplicationLoadBalancerSubnetAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApplicationLoadBalancerSubnetAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApplicationLoadBalancerSubnetAssociationState<Missing, Missing, Missing>)

        member _.Zero(()) : ApplicationLoadBalancerSubnetAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApplicationLoadBalancerSubnetAssociationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_load_balancer_subnet_association#application_load_balancer_id-1">ApplicationLoadBalancerSubnetAssociation#application_load_balancer_id</a>.
        /// </summary>
        [<CustomOperation "application_load_balancer_id">]
        member _.ApplicationLoadBalancerId(state: ApplicationLoadBalancerSubnetAssociationState<Missing, 'Name, 'SubnetId>, value: string) : ApplicationLoadBalancerSubnetAssociationState<Present, 'Name, 'SubnetId> =
            state.assignments.Add(fun config -> config.ApplicationLoadBalancerId <- value)
            ({ assignments = state.assignments } : ApplicationLoadBalancerSubnetAssociationState<Present, 'Name, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_load_balancer_subnet_association#name-1">ApplicationLoadBalancerSubnetAssociation#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApplicationLoadBalancerSubnetAssociationState<'ApplicationLoadBalancerId, Missing, 'SubnetId>, value: string) : ApplicationLoadBalancerSubnetAssociationState<'ApplicationLoadBalancerId, Present, 'SubnetId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApplicationLoadBalancerSubnetAssociationState<'ApplicationLoadBalancerId, Present, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_load_balancer_subnet_association#subnet_id-1">ApplicationLoadBalancerSubnetAssociation#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: ApplicationLoadBalancerSubnetAssociationState<'ApplicationLoadBalancerId, 'Name, Missing>, value: string) : ApplicationLoadBalancerSubnetAssociationState<'ApplicationLoadBalancerId, 'Name, Present> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : ApplicationLoadBalancerSubnetAssociationState<'ApplicationLoadBalancerId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_load_balancer_subnet_association#id-1">ApplicationLoadBalancerSubnetAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApplicationLoadBalancerSubnetAssociationState<'ApplicationLoadBalancerId, 'Name, 'SubnetId>, value: string) : ApplicationLoadBalancerSubnetAssociationState<'ApplicationLoadBalancerId, 'Name, 'SubnetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApplicationLoadBalancerSubnetAssociationState<'ApplicationLoadBalancerId, 'Name, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_load_balancer_subnet_association#tags-1">ApplicationLoadBalancerSubnetAssociation#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ApplicationLoadBalancerSubnetAssociationState<'ApplicationLoadBalancerId, 'Name, 'SubnetId>, value: seq<string * string>) : ApplicationLoadBalancerSubnetAssociationState<'ApplicationLoadBalancerId, 'Name, 'SubnetId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ApplicationLoadBalancerSubnetAssociationState<'ApplicationLoadBalancerId, 'Name, 'SubnetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_load_balancer_subnet_association#timeouts-1">ApplicationLoadBalancerSubnetAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApplicationLoadBalancerSubnetAssociationState<'ApplicationLoadBalancerId, 'Name, 'SubnetId>, value: azurerm.ApplicationLoadBalancerSubnetAssociation.ApplicationLoadBalancerSubnetAssociationTimeouts) : ApplicationLoadBalancerSubnetAssociationState<'ApplicationLoadBalancerId, 'Name, 'SubnetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApplicationLoadBalancerSubnetAssociationState<'ApplicationLoadBalancerId, 'Name, 'SubnetId>

        member _.Run(state: ApplicationLoadBalancerSubnetAssociationState<Present, Present, Present>) : azurerm.ApplicationLoadBalancerSubnetAssociation.ApplicationLoadBalancerSubnetAssociation =
            let config = azurerm.ApplicationLoadBalancerSubnetAssociation.ApplicationLoadBalancerSubnetAssociationConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApplicationLoadBalancerSubnetAssociation.ApplicationLoadBalancerSubnetAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.applicationLoadBalancerSubnetAssociation: missing required arguments. Must call: application_load_balancer_id, name, subnet_id.", 9999, IsError = true)>]
        member _.Run(_: ApplicationLoadBalancerSubnetAssociationState<_, _, _>) : azurerm.ApplicationLoadBalancerSubnetAssociation.ApplicationLoadBalancerSubnetAssociation =
            Unchecked.defaultof<azurerm.ApplicationLoadBalancerSubnetAssociation.ApplicationLoadBalancerSubnetAssociation>
