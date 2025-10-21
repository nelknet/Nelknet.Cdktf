namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ManagedApplicationDefinition.ManagedApplicationDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application_definition">azurerm_managed_application_definition</a>.
    /// </summary>
    type ManagedApplicationDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : ManagedApplicationDefinitionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ManagedApplicationDefinitionState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ManagedApplicationDefinitionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ManagedApplicationDefinitionState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application_definition#display_name-1">ManagedApplicationDefinition#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: ManagedApplicationDefinitionState<Missing, 'Location, 'LockLevel, 'Name, 'ResourceGroupName>, value: string) : ManagedApplicationDefinitionState<Present, 'Location, 'LockLevel, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : ManagedApplicationDefinitionState<Present, 'Location, 'LockLevel, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application_definition#location-1">ManagedApplicationDefinition#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ManagedApplicationDefinitionState<'DisplayName, Missing, 'LockLevel, 'Name, 'ResourceGroupName>, value: string) : ManagedApplicationDefinitionState<'DisplayName, Present, 'LockLevel, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ManagedApplicationDefinitionState<'DisplayName, Present, 'LockLevel, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application_definition#lock_level-1">ManagedApplicationDefinition#lock_level</a>.
        /// </summary>
        [<CustomOperation "lock_level">]
        member _.LockLevel(state: ManagedApplicationDefinitionState<'DisplayName, 'Location, Missing, 'Name, 'ResourceGroupName>, value: string) : ManagedApplicationDefinitionState<'DisplayName, 'Location, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LockLevel <- value)
            ({ assignments = state.assignments } : ManagedApplicationDefinitionState<'DisplayName, 'Location, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application_definition#name-1">ManagedApplicationDefinition#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, Missing, 'ResourceGroupName>, value: string) : ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application_definition#resource_group_name-1">ManagedApplicationDefinition#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, Missing>, value: string) : ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, Present>)

        /// <summary>
        /// authorization block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application_definition#authorization-1">ManagedApplicationDefinition#authorization</a> Accepts: azurerm.IResolvable | azurerm.ManagedApplicationDefinition.ManagedApplicationDefinitionAuthorization[]
        /// </summary>
        [<CustomOperation "authorization">]
        member _.Authorization(state: ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Authorization <- value)
            state : ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application_definition#create_ui_definition-1">ManagedApplicationDefinition#create_ui_definition</a>.
        /// </summary>
        [<CustomOperation "create_ui_definition">]
        member _.CreateUiDefinition(state: ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName>, value: string) : ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CreateUiDefinition <- value)
            state : ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application_definition#description-1">ManagedApplicationDefinition#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName>, value: string) : ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application_definition#id-1">ManagedApplicationDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName>, value: string) : ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application_definition#main_template-1">ManagedApplicationDefinition#main_template</a>.
        /// </summary>
        [<CustomOperation "main_template">]
        member _.MainTemplate(state: ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName>, value: string) : ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MainTemplate <- value)
            state : ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application_definition#package_enabled-1">ManagedApplicationDefinition#package_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "package_enabled">]
        member _.PackageEnabled(state: ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName>, value: bool) : ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PackageEnabled <- value)
            state : ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application_definition#package_enabled-1">ManagedApplicationDefinition#package_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "package_enabled">]
        member _.PackageEnabled(state: ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PackageEnabled <- value)
            state : ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application_definition#package_file_uri-1">ManagedApplicationDefinition#package_file_uri</a>.
        /// </summary>
        [<CustomOperation "package_file_uri">]
        member _.PackageFileUri(state: ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName>, value: string) : ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PackageFileUri <- value)
            state : ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application_definition#tags-1">ManagedApplicationDefinition#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName>, value: seq<string * string>) : ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_application_definition#timeouts-1">ManagedApplicationDefinition#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName>, value: azurerm.ManagedApplicationDefinition.ManagedApplicationDefinitionTimeouts) : ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ManagedApplicationDefinitionState<'DisplayName, 'Location, 'LockLevel, 'Name, 'ResourceGroupName>

        member _.Run(state: ManagedApplicationDefinitionState<Present, Present, Present, Present, Present>) : azurerm.ManagedApplicationDefinition.ManagedApplicationDefinition =
            let config = azurerm.ManagedApplicationDefinition.ManagedApplicationDefinitionConfig()
            for setter in state.assignments do
                setter config
            azurerm.ManagedApplicationDefinition.ManagedApplicationDefinition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.managedApplicationDefinition: missing required arguments. Must call: display_name, location, lock_level, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ManagedApplicationDefinitionState<_, _, _, _, _>) : azurerm.ManagedApplicationDefinition.ManagedApplicationDefinition =
            Unchecked.defaultof<azurerm.ManagedApplicationDefinition.ManagedApplicationDefinition>
