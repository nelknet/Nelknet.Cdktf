namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LighthouseDefinitionState<'Authorization, 'ManagingTenantId, 'Name, 'Scope> = { assignments: ResizeArray<azurerm.LighthouseDefinition.LighthouseDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_definition">azurerm_lighthouse_definition</a>.
    /// </summary>
    type LighthouseDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : LighthouseDefinitionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LighthouseDefinitionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LighthouseDefinitionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LighthouseDefinitionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// authorization block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_definition#authorization-1">LighthouseDefinition#authorization</a> Accepts: azurerm.IResolvable | azurerm.LighthouseDefinition.LighthouseDefinitionAuthorization[]
        /// </summary>
        [<CustomOperation "authorization">]
        member _.Authorization(state: LighthouseDefinitionState<Missing, 'ManagingTenantId, 'Name, 'Scope>, value: HashiCorp.Cdktf.IResolvable) : LighthouseDefinitionState<Present, 'ManagingTenantId, 'Name, 'Scope> =
            state.assignments.Add(fun config -> config.Authorization <- value)
            ({ assignments = state.assignments } : LighthouseDefinitionState<Present, 'ManagingTenantId, 'Name, 'Scope>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_definition#managing_tenant_id-1">LighthouseDefinition#managing_tenant_id</a>.
        /// </summary>
        [<CustomOperation "managing_tenant_id">]
        member _.ManagingTenantId(state: LighthouseDefinitionState<'Authorization, Missing, 'Name, 'Scope>, value: string) : LighthouseDefinitionState<'Authorization, Present, 'Name, 'Scope> =
            state.assignments.Add(fun config -> config.ManagingTenantId <- value)
            ({ assignments = state.assignments } : LighthouseDefinitionState<'Authorization, Present, 'Name, 'Scope>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_definition#name-1">LighthouseDefinition#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LighthouseDefinitionState<'Authorization, 'ManagingTenantId, Missing, 'Scope>, value: string) : LighthouseDefinitionState<'Authorization, 'ManagingTenantId, Present, 'Scope> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LighthouseDefinitionState<'Authorization, 'ManagingTenantId, Present, 'Scope>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_definition#scope-1">LighthouseDefinition#scope</a>.
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: LighthouseDefinitionState<'Authorization, 'ManagingTenantId, 'Name, Missing>, value: string) : LighthouseDefinitionState<'Authorization, 'ManagingTenantId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Scope <- value)
            ({ assignments = state.assignments } : LighthouseDefinitionState<'Authorization, 'ManagingTenantId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_definition#description-1">LighthouseDefinition#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: LighthouseDefinitionState<'Authorization, 'ManagingTenantId, 'Name, 'Scope>, value: string) : LighthouseDefinitionState<'Authorization, 'ManagingTenantId, 'Name, 'Scope> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : LighthouseDefinitionState<'Authorization, 'ManagingTenantId, 'Name, 'Scope>

        /// <summary>
        /// eligible_authorization block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_definition#eligible_authorization-1">LighthouseDefinition#eligible_authorization</a> Accepts: azurerm.IResolvable | azurerm.LighthouseDefinition.LighthouseDefinitionEligibleAuthorization[]
        /// </summary>
        [<CustomOperation "eligible_authorization">]
        member _.EligibleAuthorization(state: LighthouseDefinitionState<'Authorization, 'ManagingTenantId, 'Name, 'Scope>, value: HashiCorp.Cdktf.IResolvable) : LighthouseDefinitionState<'Authorization, 'ManagingTenantId, 'Name, 'Scope> =
            state.assignments.Add(fun config -> config.EligibleAuthorization <- value)
            state : LighthouseDefinitionState<'Authorization, 'ManagingTenantId, 'Name, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_definition#id-1">LighthouseDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LighthouseDefinitionState<'Authorization, 'ManagingTenantId, 'Name, 'Scope>, value: string) : LighthouseDefinitionState<'Authorization, 'ManagingTenantId, 'Name, 'Scope> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LighthouseDefinitionState<'Authorization, 'ManagingTenantId, 'Name, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_definition#lighthouse_definition_id-1">LighthouseDefinition#lighthouse_definition_id</a>.
        /// </summary>
        [<CustomOperation "lighthouse_definition_id">]
        member _.LighthouseDefinitionId(state: LighthouseDefinitionState<'Authorization, 'ManagingTenantId, 'Name, 'Scope>, value: string) : LighthouseDefinitionState<'Authorization, 'ManagingTenantId, 'Name, 'Scope> =
            state.assignments.Add(fun config -> config.LighthouseDefinitionId <- value)
            state : LighthouseDefinitionState<'Authorization, 'ManagingTenantId, 'Name, 'Scope>

        /// <summary>
        /// plan block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_definition#plan-1">LighthouseDefinition#plan</a>
        /// </summary>
        [<CustomOperation "plan">]
        member _.Plan(state: LighthouseDefinitionState<'Authorization, 'ManagingTenantId, 'Name, 'Scope>, value: azurerm.LighthouseDefinition.LighthouseDefinitionPlan) : LighthouseDefinitionState<'Authorization, 'ManagingTenantId, 'Name, 'Scope> =
            state.assignments.Add(fun config -> config.Plan <- value)
            state : LighthouseDefinitionState<'Authorization, 'ManagingTenantId, 'Name, 'Scope>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_definition#timeouts-1">LighthouseDefinition#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LighthouseDefinitionState<'Authorization, 'ManagingTenantId, 'Name, 'Scope>, value: azurerm.LighthouseDefinition.LighthouseDefinitionTimeouts) : LighthouseDefinitionState<'Authorization, 'ManagingTenantId, 'Name, 'Scope> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LighthouseDefinitionState<'Authorization, 'ManagingTenantId, 'Name, 'Scope>

        member _.Run(state: LighthouseDefinitionState<Present, Present, Present, Present>) : azurerm.LighthouseDefinition.LighthouseDefinition =
            let config = azurerm.LighthouseDefinition.LighthouseDefinitionConfig()
            for setter in state.assignments do
                setter config
            azurerm.LighthouseDefinition.LighthouseDefinition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.lighthouseDefinition: missing required arguments. Must call: authorization, managing_tenant_id, name, scope.", 9999, IsError = true)>]
        member _.Run(_: LighthouseDefinitionState<_, _, _, _>) : azurerm.LighthouseDefinition.LighthouseDefinition =
            Unchecked.defaultof<azurerm.LighthouseDefinition.LighthouseDefinition>
