namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicecatalogBudgetResourceAssociationState<'BudgetName, 'ResourceId> = { assignments: ResizeArray<aws.ServicecatalogBudgetResourceAssociation.ServicecatalogBudgetResourceAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_budget_resource_association">aws_servicecatalog_budget_resource_association</a>.
    /// </summary>
    type ServicecatalogBudgetResourceAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicecatalogBudgetResourceAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogBudgetResourceAssociationState<Missing, Missing>)

        member _.Zero(()) : ServicecatalogBudgetResourceAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogBudgetResourceAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_budget_resource_association#budget_name-1">ServicecatalogBudgetResourceAssociation#budget_name</a>.
        /// </summary>
        [<CustomOperation "budget_name">]
        member _.BudgetName(state: ServicecatalogBudgetResourceAssociationState<Missing, 'ResourceId>, value: string) : ServicecatalogBudgetResourceAssociationState<Present, 'ResourceId> =
            state.assignments.Add(fun config -> config.BudgetName <- value)
            ({ assignments = state.assignments } : ServicecatalogBudgetResourceAssociationState<Present, 'ResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_budget_resource_association#resource_id-1">ServicecatalogBudgetResourceAssociation#resource_id</a>.
        /// </summary>
        [<CustomOperation "resource_id">]
        member _.ResourceId(state: ServicecatalogBudgetResourceAssociationState<'BudgetName, Missing>, value: string) : ServicecatalogBudgetResourceAssociationState<'BudgetName, Present> =
            state.assignments.Add(fun config -> config.ResourceId <- value)
            ({ assignments = state.assignments } : ServicecatalogBudgetResourceAssociationState<'BudgetName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_budget_resource_association#id-1">ServicecatalogBudgetResourceAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServicecatalogBudgetResourceAssociationState<'BudgetName, 'ResourceId>, value: string) : ServicecatalogBudgetResourceAssociationState<'BudgetName, 'ResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServicecatalogBudgetResourceAssociationState<'BudgetName, 'ResourceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_budget_resource_association#timeouts-1">ServicecatalogBudgetResourceAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ServicecatalogBudgetResourceAssociationState<'BudgetName, 'ResourceId>, value: aws.ServicecatalogBudgetResourceAssociation.ServicecatalogBudgetResourceAssociationTimeouts) : ServicecatalogBudgetResourceAssociationState<'BudgetName, 'ResourceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ServicecatalogBudgetResourceAssociationState<'BudgetName, 'ResourceId>

        member _.Run(state: ServicecatalogBudgetResourceAssociationState<Present, Present>) : aws.ServicecatalogBudgetResourceAssociation.ServicecatalogBudgetResourceAssociation =
            let config = aws.ServicecatalogBudgetResourceAssociation.ServicecatalogBudgetResourceAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.ServicecatalogBudgetResourceAssociation.ServicecatalogBudgetResourceAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.servicecatalogBudgetResourceAssociation: missing required arguments. Must call: budget_name, resource_id.", 9999, IsError = true)>]
        member _.Run(_: ServicecatalogBudgetResourceAssociationState<_, _>) : aws.ServicecatalogBudgetResourceAssociation.ServicecatalogBudgetResourceAssociation =
            Unchecked.defaultof<aws.ServicecatalogBudgetResourceAssociation.ServicecatalogBudgetResourceAssociation>
