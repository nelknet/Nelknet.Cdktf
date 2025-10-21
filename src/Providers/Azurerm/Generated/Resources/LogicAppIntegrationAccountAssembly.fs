namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogicAppIntegrationAccountAssemblyState<'AssemblyName, 'IntegrationAccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.LogicAppIntegrationAccountAssembly.LogicAppIntegrationAccountAssemblyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_assembly">azurerm_logic_app_integration_account_assembly</a>.
    /// </summary>
    type LogicAppIntegrationAccountAssemblyBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogicAppIntegrationAccountAssemblyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppIntegrationAccountAssemblyState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LogicAppIntegrationAccountAssemblyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppIntegrationAccountAssemblyState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_assembly#assembly_name-1">LogicAppIntegrationAccountAssembly#assembly_name</a>.
        /// </summary>
        [<CustomOperation "assembly_name">]
        member _.AssemblyName(state: LogicAppIntegrationAccountAssemblyState<Missing, 'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountAssemblyState<Present, 'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AssemblyName <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountAssemblyState<Present, 'IntegrationAccountName, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_assembly#integration_account_name-1">LogicAppIntegrationAccountAssembly#integration_account_name</a>.
        /// </summary>
        [<CustomOperation "integration_account_name">]
        member _.IntegrationAccountName(state: LogicAppIntegrationAccountAssemblyState<'AssemblyName, Missing, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountAssemblyState<'AssemblyName, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IntegrationAccountName <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountAssemblyState<'AssemblyName, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_assembly#name-1">LogicAppIntegrationAccountAssembly#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LogicAppIntegrationAccountAssemblyState<'AssemblyName, 'IntegrationAccountName, Missing, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountAssemblyState<'AssemblyName, 'IntegrationAccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountAssemblyState<'AssemblyName, 'IntegrationAccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_assembly#resource_group_name-1">LogicAppIntegrationAccountAssembly#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LogicAppIntegrationAccountAssemblyState<'AssemblyName, 'IntegrationAccountName, 'Name, Missing>, value: string) : LogicAppIntegrationAccountAssemblyState<'AssemblyName, 'IntegrationAccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountAssemblyState<'AssemblyName, 'IntegrationAccountName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_assembly#assembly_version-1">LogicAppIntegrationAccountAssembly#assembly_version</a>.
        /// </summary>
        [<CustomOperation "assembly_version">]
        member _.AssemblyVersion(state: LogicAppIntegrationAccountAssemblyState<'AssemblyName, 'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountAssemblyState<'AssemblyName, 'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AssemblyVersion <- value)
            state : LogicAppIntegrationAccountAssemblyState<'AssemblyName, 'IntegrationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_assembly#content-1">LogicAppIntegrationAccountAssembly#content</a>.
        /// </summary>
        [<CustomOperation "content">]
        member _.Content(state: LogicAppIntegrationAccountAssemblyState<'AssemblyName, 'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountAssemblyState<'AssemblyName, 'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Content <- value)
            state : LogicAppIntegrationAccountAssemblyState<'AssemblyName, 'IntegrationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_assembly#content_link_uri-1">LogicAppIntegrationAccountAssembly#content_link_uri</a>.
        /// </summary>
        [<CustomOperation "content_link_uri">]
        member _.ContentLinkUri(state: LogicAppIntegrationAccountAssemblyState<'AssemblyName, 'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountAssemblyState<'AssemblyName, 'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ContentLinkUri <- value)
            state : LogicAppIntegrationAccountAssemblyState<'AssemblyName, 'IntegrationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_assembly#id-1">LogicAppIntegrationAccountAssembly#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogicAppIntegrationAccountAssemblyState<'AssemblyName, 'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountAssemblyState<'AssemblyName, 'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogicAppIntegrationAccountAssemblyState<'AssemblyName, 'IntegrationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_assembly#metadata-1">LogicAppIntegrationAccountAssembly#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: LogicAppIntegrationAccountAssemblyState<'AssemblyName, 'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: seq<string * string>) : LogicAppIntegrationAccountAssemblyState<'AssemblyName, 'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Metadata <- dict value)
            state : LogicAppIntegrationAccountAssemblyState<'AssemblyName, 'IntegrationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_assembly#timeouts-1">LogicAppIntegrationAccountAssembly#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogicAppIntegrationAccountAssemblyState<'AssemblyName, 'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: azurerm.LogicAppIntegrationAccountAssembly.LogicAppIntegrationAccountAssemblyTimeouts) : LogicAppIntegrationAccountAssemblyState<'AssemblyName, 'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogicAppIntegrationAccountAssemblyState<'AssemblyName, 'IntegrationAccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: LogicAppIntegrationAccountAssemblyState<Present, Present, Present, Present>) : azurerm.LogicAppIntegrationAccountAssembly.LogicAppIntegrationAccountAssembly =
            let config = azurerm.LogicAppIntegrationAccountAssembly.LogicAppIntegrationAccountAssemblyConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogicAppIntegrationAccountAssembly.LogicAppIntegrationAccountAssembly(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logicAppIntegrationAccountAssembly: missing required arguments. Must call: assembly_name, integration_account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: LogicAppIntegrationAccountAssemblyState<_, _, _, _>) : azurerm.LogicAppIntegrationAccountAssembly.LogicAppIntegrationAccountAssembly =
            Unchecked.defaultof<azurerm.LogicAppIntegrationAccountAssembly.LogicAppIntegrationAccountAssembly>
