namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.LogicAppWorkflow.LogicAppWorkflowConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow">azurerm_logic_app_workflow</a>.
    /// </summary>
    type LogicAppWorkflowBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogicAppWorkflowState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppWorkflowState<Missing, Missing, Missing>)

        member _.Zero(()) : LogicAppWorkflowState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppWorkflowState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#location-1">LogicAppWorkflow#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: LogicAppWorkflowState<Missing, 'Name, 'ResourceGroupName>, value: string) : LogicAppWorkflowState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : LogicAppWorkflowState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#name-1">LogicAppWorkflow#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LogicAppWorkflowState<'Location, Missing, 'ResourceGroupName>, value: string) : LogicAppWorkflowState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LogicAppWorkflowState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#resource_group_name-1">LogicAppWorkflow#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LogicAppWorkflowState<'Location, 'Name, Missing>, value: string) : LogicAppWorkflowState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LogicAppWorkflowState<'Location, 'Name, Present>)

        /// <summary>
        /// access_control block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#access_control-1">LogicAppWorkflow#access_control</a>
        /// </summary>
        [<CustomOperation "access_control">]
        member _.AccessControl(state: LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.LogicAppWorkflow.LogicAppWorkflowAccessControl) : LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccessControl <- value)
            state : LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#enabled-1">LogicAppWorkflow#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName>, value: bool) : LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#enabled-1">LogicAppWorkflow#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#id-1">LogicAppWorkflow#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName>, value: string) : LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#identity-1">LogicAppWorkflow#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.LogicAppWorkflow.LogicAppWorkflowIdentity) : LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#integration_service_environment_id-1">LogicAppWorkflow#integration_service_environment_id</a>.
        /// </summary>
        [<CustomOperation "integration_service_environment_id">]
        member _.IntegrationServiceEnvironmentId(state: LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName>, value: string) : LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IntegrationServiceEnvironmentId <- value)
            state : LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#logic_app_integration_account_id-1">LogicAppWorkflow#logic_app_integration_account_id</a>.
        /// </summary>
        [<CustomOperation "logic_app_integration_account_id">]
        member _.LogicAppIntegrationAccountId(state: LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName>, value: string) : LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LogicAppIntegrationAccountId <- value)
            state : LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#parameters-1">LogicAppWorkflow#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#tags-1">LogicAppWorkflow#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#timeouts-1">LogicAppWorkflow#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.LogicAppWorkflow.LogicAppWorkflowTimeouts) : LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#workflow_parameters-1">LogicAppWorkflow#workflow_parameters</a>.
        /// </summary>
        [<CustomOperation "workflow_parameters">]
        member _.WorkflowParameters(state: LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.WorkflowParameters <- dict value)
            state : LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#workflow_schema-1">LogicAppWorkflow#workflow_schema</a>.
        /// </summary>
        [<CustomOperation "workflow_schema">]
        member _.WorkflowSchema(state: LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName>, value: string) : LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.WorkflowSchema <- value)
            state : LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_workflow#workflow_version-1">LogicAppWorkflow#workflow_version</a>.
        /// </summary>
        [<CustomOperation "workflow_version">]
        member _.WorkflowVersion(state: LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName>, value: string) : LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.WorkflowVersion <- value)
            state : LogicAppWorkflowState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: LogicAppWorkflowState<Present, Present, Present>) : azurerm.LogicAppWorkflow.LogicAppWorkflow =
            let config = azurerm.LogicAppWorkflow.LogicAppWorkflowConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogicAppWorkflow.LogicAppWorkflow(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logicAppWorkflow: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: LogicAppWorkflowState<_, _, _>) : azurerm.LogicAppWorkflow.LogicAppWorkflow =
            Unchecked.defaultof<azurerm.LogicAppWorkflow.LogicAppWorkflow>
