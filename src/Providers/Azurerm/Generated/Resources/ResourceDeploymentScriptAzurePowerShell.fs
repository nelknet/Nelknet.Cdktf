namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> = { assignments: ResizeArray<azurerm.ResourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShellConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_power_shell">azurerm_resource_deployment_script_azure_power_shell</a>.
    /// </summary>
    type ResourceDeploymentScriptAzurePowerShellBuilder(logicalId: string) =
        member _.Yield(_: unit) : ResourceDeploymentScriptAzurePowerShellState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourceDeploymentScriptAzurePowerShellState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ResourceDeploymentScriptAzurePowerShellState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourceDeploymentScriptAzurePowerShellState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_power_shell#location-1">ResourceDeploymentScriptAzurePowerShell#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ResourceDeploymentScriptAzurePowerShellState<Missing, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: string) : ResourceDeploymentScriptAzurePowerShellState<Present, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ResourceDeploymentScriptAzurePowerShellState<Present, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_power_shell#name-1">ResourceDeploymentScriptAzurePowerShell#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ResourceDeploymentScriptAzurePowerShellState<'Location, Missing, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: string) : ResourceDeploymentScriptAzurePowerShellState<'Location, Present, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ResourceDeploymentScriptAzurePowerShellState<'Location, Present, 'ResourceGroupName, 'RetentionInterval, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_power_shell#resource_group_name-1">ResourceDeploymentScriptAzurePowerShell#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, Missing, 'RetentionInterval, 'Version>, value: string) : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, Present, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, Present, 'RetentionInterval, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_power_shell#retention_interval-1">ResourceDeploymentScriptAzurePowerShell#retention_interval</a>.
        /// </summary>
        [<CustomOperation "retention_interval">]
        member _.RetentionInterval(state: ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, Missing, 'Version>, value: string) : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, Present, 'Version> =
            state.assignments.Add(fun config -> config.RetentionInterval <- value)
            ({ assignments = state.assignments } : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, Present, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_power_shell#version-1">ResourceDeploymentScriptAzurePowerShell#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, Missing>, value: string) : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, Present> =
            state.assignments.Add(fun config -> config.Version <- value)
            ({ assignments = state.assignments } : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_power_shell#cleanup_preference-1">ResourceDeploymentScriptAzurePowerShell#cleanup_preference</a>.
        /// </summary>
        [<CustomOperation "cleanup_preference">]
        member _.CleanupPreference(state: ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: string) : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.CleanupPreference <- value)
            state : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_power_shell#command_line-1">ResourceDeploymentScriptAzurePowerShell#command_line</a>.
        /// </summary>
        [<CustomOperation "command_line">]
        member _.CommandLine(state: ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: string) : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.CommandLine <- value)
            state : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>

        /// <summary>
        /// container block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_power_shell#container-1">ResourceDeploymentScriptAzurePowerShell#container</a>
        /// </summary>
        [<CustomOperation "container">]
        member _.Container(state: ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: azurerm.ResourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShellContainer) : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.Container <- value)
            state : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>

        /// <summary>
        /// environment_variable block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_power_shell#environment_variable-1">ResourceDeploymentScriptAzurePowerShell#environment_variable</a> Accepts: azurerm.IResolvable | azurerm.ResourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShellEnvironmentVariable[]
        /// </summary>
        [<CustomOperation "environment_variable">]
        member _.EnvironmentVariable(state: ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: HashiCorp.Cdktf.IResolvable) : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.EnvironmentVariable <- value)
            state : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_power_shell#force_update_tag-1">ResourceDeploymentScriptAzurePowerShell#force_update_tag</a>.
        /// </summary>
        [<CustomOperation "force_update_tag">]
        member _.ForceUpdateTag(state: ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: string) : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.ForceUpdateTag <- value)
            state : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_power_shell#id-1">ResourceDeploymentScriptAzurePowerShell#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: string) : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_power_shell#identity-1">ResourceDeploymentScriptAzurePowerShell#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: azurerm.ResourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShellIdentity) : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_power_shell#primary_script_uri-1">ResourceDeploymentScriptAzurePowerShell#primary_script_uri</a>.
        /// </summary>
        [<CustomOperation "primary_script_uri">]
        member _.PrimaryScriptUri(state: ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: string) : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.PrimaryScriptUri <- value)
            state : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_power_shell#script_content-1">ResourceDeploymentScriptAzurePowerShell#script_content</a>.
        /// </summary>
        [<CustomOperation "script_content">]
        member _.ScriptContent(state: ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: string) : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.ScriptContent <- value)
            state : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>

        /// <summary>
        /// storage_account block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_power_shell#storage_account-1">ResourceDeploymentScriptAzurePowerShell#storage_account</a>
        /// </summary>
        [<CustomOperation "storage_account">]
        member _.StorageAccount(state: ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: azurerm.ResourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShellStorageAccount) : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.StorageAccount <- value)
            state : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_power_shell#supporting_script_uris-1">ResourceDeploymentScriptAzurePowerShell#supporting_script_uris</a>.
        /// </summary>
        [<CustomOperation "supporting_script_uris">]
        member _.SupportingScriptUris(state: ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: seq<string>) : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.SupportingScriptUris <- (value |> Seq.toArray))
            state : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_power_shell#tags-1">ResourceDeploymentScriptAzurePowerShell#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: seq<string * string>) : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_power_shell#timeout-1">ResourceDeploymentScriptAzurePowerShell#timeout</a>.
        /// </summary>
        [<CustomOperation "timeout">]
        member _.Timeout(state: ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: string) : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.Timeout <- value)
            state : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_power_shell#timeouts-1">ResourceDeploymentScriptAzurePowerShell#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: azurerm.ResourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShellTimeouts) : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ResourceDeploymentScriptAzurePowerShellState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>

        member _.Run(state: ResourceDeploymentScriptAzurePowerShellState<Present, Present, Present, Present, Present>) : azurerm.ResourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShell =
            let config = azurerm.ResourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShellConfig()
            for setter in state.assignments do
                setter config
            azurerm.ResourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShell(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.resourceDeploymentScriptAzurePowerShell: missing required arguments. Must call: location, name, resource_group_name, retention_interval, version.", 9999, IsError = true)>]
        member _.Run(_: ResourceDeploymentScriptAzurePowerShellState<_, _, _, _, _>) : azurerm.ResourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShell =
            Unchecked.defaultof<azurerm.ResourceDeploymentScriptAzurePowerShell.ResourceDeploymentScriptAzurePowerShell>
