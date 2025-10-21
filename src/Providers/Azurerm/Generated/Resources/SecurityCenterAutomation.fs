namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecurityCenterAutomationState<'Action, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Source> = { assignments: ResizeArray<azurerm.SecurityCenterAutomation.SecurityCenterAutomationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation">azurerm_security_center_automation</a>.
    /// </summary>
    type SecurityCenterAutomationBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecurityCenterAutomationState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SecurityCenterAutomationState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SecurityCenterAutomationState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SecurityCenterAutomationState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#action-1">SecurityCenterAutomation#action</a> Accepts: azurerm.IResolvable | azurerm.SecurityCenterAutomation.SecurityCenterAutomationAction[]
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: SecurityCenterAutomationState<Missing, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Source>, value: HashiCorp.Cdktf.IResolvable) : SecurityCenterAutomationState<Present, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Source> =
            state.assignments.Add(fun config -> config.Action <- value)
            ({ assignments = state.assignments } : SecurityCenterAutomationState<Present, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Source>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#location-1">SecurityCenterAutomation#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: SecurityCenterAutomationState<'Action, Missing, 'Name, 'ResourceGroupName, 'Scopes, 'Source>, value: string) : SecurityCenterAutomationState<'Action, Present, 'Name, 'ResourceGroupName, 'Scopes, 'Source> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : SecurityCenterAutomationState<'Action, Present, 'Name, 'ResourceGroupName, 'Scopes, 'Source>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#name-1">SecurityCenterAutomation#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SecurityCenterAutomationState<'Action, 'Location, Missing, 'ResourceGroupName, 'Scopes, 'Source>, value: string) : SecurityCenterAutomationState<'Action, 'Location, Present, 'ResourceGroupName, 'Scopes, 'Source> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SecurityCenterAutomationState<'Action, 'Location, Present, 'ResourceGroupName, 'Scopes, 'Source>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#resource_group_name-1">SecurityCenterAutomation#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: SecurityCenterAutomationState<'Action, 'Location, 'Name, Missing, 'Scopes, 'Source>, value: string) : SecurityCenterAutomationState<'Action, 'Location, 'Name, Present, 'Scopes, 'Source> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : SecurityCenterAutomationState<'Action, 'Location, 'Name, Present, 'Scopes, 'Source>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#scopes-1">SecurityCenterAutomation#scopes</a>.
        /// </summary>
        [<CustomOperation "scopes">]
        member _.Scopes(state: SecurityCenterAutomationState<'Action, 'Location, 'Name, 'ResourceGroupName, Missing, 'Source>, value: seq<string>) : SecurityCenterAutomationState<'Action, 'Location, 'Name, 'ResourceGroupName, Present, 'Source> =
            state.assignments.Add(fun config -> config.Scopes <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : SecurityCenterAutomationState<'Action, 'Location, 'Name, 'ResourceGroupName, Present, 'Source>)

        /// <summary>
        /// source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#source-1">SecurityCenterAutomation#source</a> Accepts: azurerm.IResolvable | azurerm.SecurityCenterAutomation.SecurityCenterAutomationSource[]
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: SecurityCenterAutomationState<'Action, 'Location, 'Name, 'ResourceGroupName, 'Scopes, Missing>, value: HashiCorp.Cdktf.IResolvable) : SecurityCenterAutomationState<'Action, 'Location, 'Name, 'ResourceGroupName, 'Scopes, Present> =
            state.assignments.Add(fun config -> config.Source <- value)
            ({ assignments = state.assignments } : SecurityCenterAutomationState<'Action, 'Location, 'Name, 'ResourceGroupName, 'Scopes, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#description-1">SecurityCenterAutomation#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SecurityCenterAutomationState<'Action, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Source>, value: string) : SecurityCenterAutomationState<'Action, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Source> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SecurityCenterAutomationState<'Action, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#enabled-1">SecurityCenterAutomation#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: SecurityCenterAutomationState<'Action, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Source>, value: bool) : SecurityCenterAutomationState<'Action, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Source> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : SecurityCenterAutomationState<'Action, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#enabled-1">SecurityCenterAutomation#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: SecurityCenterAutomationState<'Action, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Source>, value: HashiCorp.Cdktf.IResolvable) : SecurityCenterAutomationState<'Action, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Source> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : SecurityCenterAutomationState<'Action, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#id-1">SecurityCenterAutomation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SecurityCenterAutomationState<'Action, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Source>, value: string) : SecurityCenterAutomationState<'Action, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Source> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SecurityCenterAutomationState<'Action, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#tags-1">SecurityCenterAutomation#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SecurityCenterAutomationState<'Action, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Source>, value: seq<string * string>) : SecurityCenterAutomationState<'Action, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Source> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SecurityCenterAutomationState<'Action, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Source>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#timeouts-1">SecurityCenterAutomation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SecurityCenterAutomationState<'Action, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Source>, value: azurerm.SecurityCenterAutomation.SecurityCenterAutomationTimeouts) : SecurityCenterAutomationState<'Action, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Source> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SecurityCenterAutomationState<'Action, 'Location, 'Name, 'ResourceGroupName, 'Scopes, 'Source>

        member _.Run(state: SecurityCenterAutomationState<Present, Present, Present, Present, Present, Present>) : azurerm.SecurityCenterAutomation.SecurityCenterAutomation =
            let config = azurerm.SecurityCenterAutomation.SecurityCenterAutomationConfig()
            for setter in state.assignments do
                setter config
            azurerm.SecurityCenterAutomation.SecurityCenterAutomation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.securityCenterAutomation: missing required arguments. Must call: action, location, name, resource_group_name, scopes, source.", 9999, IsError = true)>]
        member _.Run(_: SecurityCenterAutomationState<_, _, _, _, _, _>) : azurerm.SecurityCenterAutomation.SecurityCenterAutomation =
            Unchecked.defaultof<azurerm.SecurityCenterAutomation.SecurityCenterAutomation>
