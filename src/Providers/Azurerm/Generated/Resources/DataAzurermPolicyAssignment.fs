namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPolicyAssignmentState<'Name, 'ScopeId> = { assignments: ResizeArray<azurerm.DataAzurermPolicyAssignment.DataAzurermPolicyAssignmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_assignment">azurerm_policy_assignment</a>.
    /// </summary>
    type DataAzurermPolicyAssignmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPolicyAssignmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPolicyAssignmentState<Missing, Missing>)

        member _.Zero(()) : DataAzurermPolicyAssignmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPolicyAssignmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_assignment#name-1">DataAzurermPolicyAssignment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermPolicyAssignmentState<Missing, 'ScopeId>, value: string) : DataAzurermPolicyAssignmentState<Present, 'ScopeId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermPolicyAssignmentState<Present, 'ScopeId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_assignment#scope_id-1">DataAzurermPolicyAssignment#scope_id</a>.
        /// </summary>
        [<CustomOperation "scope_id">]
        member _.ScopeId(state: DataAzurermPolicyAssignmentState<'Name, Missing>, value: string) : DataAzurermPolicyAssignmentState<'Name, Present> =
            state.assignments.Add(fun config -> config.ScopeId <- value)
            ({ assignments = state.assignments } : DataAzurermPolicyAssignmentState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_assignment#id-1">DataAzurermPolicyAssignment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPolicyAssignmentState<'Name, 'ScopeId>, value: string) : DataAzurermPolicyAssignmentState<'Name, 'ScopeId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPolicyAssignmentState<'Name, 'ScopeId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_assignment#timeouts-1">DataAzurermPolicyAssignment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPolicyAssignmentState<'Name, 'ScopeId>, value: azurerm.DataAzurermPolicyAssignment.DataAzurermPolicyAssignmentTimeouts) : DataAzurermPolicyAssignmentState<'Name, 'ScopeId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPolicyAssignmentState<'Name, 'ScopeId>

        member _.Run(state: DataAzurermPolicyAssignmentState<Present, Present>) : azurerm.DataAzurermPolicyAssignment.DataAzurermPolicyAssignment =
            let config = azurerm.DataAzurermPolicyAssignment.DataAzurermPolicyAssignmentConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPolicyAssignment.DataAzurermPolicyAssignment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermPolicyAssignment: missing required arguments. Must call: name, scope_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermPolicyAssignmentState<_, _>) : azurerm.DataAzurermPolicyAssignment.DataAzurermPolicyAssignment =
            Unchecked.defaultof<azurerm.DataAzurermPolicyAssignment.DataAzurermPolicyAssignment>
