namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> = { assignments: ResizeArray<azurerm.ResourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_cli">azurerm_resource_deployment_script_azure_cli</a>.
    /// </summary>
    type ResourceDeploymentScriptAzureCliBuilder(logicalId: string) =
        member _.Yield(_: unit) : ResourceDeploymentScriptAzureCliState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourceDeploymentScriptAzureCliState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ResourceDeploymentScriptAzureCliState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourceDeploymentScriptAzureCliState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_cli#location-1">ResourceDeploymentScriptAzureCli#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ResourceDeploymentScriptAzureCliState<Missing, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: string) : ResourceDeploymentScriptAzureCliState<Present, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ResourceDeploymentScriptAzureCliState<Present, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_cli#name-1">ResourceDeploymentScriptAzureCli#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ResourceDeploymentScriptAzureCliState<'Location, Missing, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: string) : ResourceDeploymentScriptAzureCliState<'Location, Present, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ResourceDeploymentScriptAzureCliState<'Location, Present, 'ResourceGroupName, 'RetentionInterval, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_cli#resource_group_name-1">ResourceDeploymentScriptAzureCli#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ResourceDeploymentScriptAzureCliState<'Location, 'Name, Missing, 'RetentionInterval, 'Version>, value: string) : ResourceDeploymentScriptAzureCliState<'Location, 'Name, Present, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ResourceDeploymentScriptAzureCliState<'Location, 'Name, Present, 'RetentionInterval, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_cli#retention_interval-1">ResourceDeploymentScriptAzureCli#retention_interval</a>.
        /// </summary>
        [<CustomOperation "retention_interval">]
        member _.RetentionInterval(state: ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, Missing, 'Version>, value: string) : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, Present, 'Version> =
            state.assignments.Add(fun config -> config.RetentionInterval <- value)
            ({ assignments = state.assignments } : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, Present, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_cli#version-1">ResourceDeploymentScriptAzureCli#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, Missing>, value: string) : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, Present> =
            state.assignments.Add(fun config -> config.Version <- value)
            ({ assignments = state.assignments } : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_cli#cleanup_preference-1">ResourceDeploymentScriptAzureCli#cleanup_preference</a>.
        /// </summary>
        [<CustomOperation "cleanup_preference">]
        member _.CleanupPreference(state: ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: string) : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.CleanupPreference <- value)
            state : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_cli#command_line-1">ResourceDeploymentScriptAzureCli#command_line</a>.
        /// </summary>
        [<CustomOperation "command_line">]
        member _.CommandLine(state: ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: string) : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.CommandLine <- value)
            state : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>

        /// <summary>
        /// container block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_cli#container-1">ResourceDeploymentScriptAzureCli#container</a>
        /// </summary>
        [<CustomOperation "container">]
        member _.Container(state: ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: azurerm.ResourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliContainer) : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.Container <- value)
            state : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>

        /// <summary>
        /// environment_variable block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_cli#environment_variable-1">ResourceDeploymentScriptAzureCli#environment_variable</a> Accepts: azurerm.IResolvable | azurerm.ResourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliEnvironmentVariable[]
        /// </summary>
        [<CustomOperation "environment_variable">]
        member _.EnvironmentVariable(state: ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: HashiCorp.Cdktf.IResolvable) : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.EnvironmentVariable <- value)
            state : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_cli#force_update_tag-1">ResourceDeploymentScriptAzureCli#force_update_tag</a>.
        /// </summary>
        [<CustomOperation "force_update_tag">]
        member _.ForceUpdateTag(state: ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: string) : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.ForceUpdateTag <- value)
            state : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_cli#id-1">ResourceDeploymentScriptAzureCli#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: string) : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_cli#identity-1">ResourceDeploymentScriptAzureCli#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: azurerm.ResourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliIdentity) : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_cli#primary_script_uri-1">ResourceDeploymentScriptAzureCli#primary_script_uri</a>.
        /// </summary>
        [<CustomOperation "primary_script_uri">]
        member _.PrimaryScriptUri(state: ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: string) : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.PrimaryScriptUri <- value)
            state : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_cli#script_content-1">ResourceDeploymentScriptAzureCli#script_content</a>.
        /// </summary>
        [<CustomOperation "script_content">]
        member _.ScriptContent(state: ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: string) : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.ScriptContent <- value)
            state : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>

        /// <summary>
        /// storage_account block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_cli#storage_account-1">ResourceDeploymentScriptAzureCli#storage_account</a>
        /// </summary>
        [<CustomOperation "storage_account">]
        member _.StorageAccount(state: ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: azurerm.ResourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliStorageAccount) : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.StorageAccount <- value)
            state : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_cli#supporting_script_uris-1">ResourceDeploymentScriptAzureCli#supporting_script_uris</a>.
        /// </summary>
        [<CustomOperation "supporting_script_uris">]
        member _.SupportingScriptUris(state: ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: seq<string>) : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.SupportingScriptUris <- (value |> Seq.toArray))
            state : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_cli#tags-1">ResourceDeploymentScriptAzureCli#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: seq<string * string>) : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_cli#timeout-1">ResourceDeploymentScriptAzureCli#timeout</a>.
        /// </summary>
        [<CustomOperation "timeout">]
        member _.Timeout(state: ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: string) : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.Timeout <- value)
            state : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_deployment_script_azure_cli#timeouts-1">ResourceDeploymentScriptAzureCli#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>, value: azurerm.ResourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliTimeouts) : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ResourceDeploymentScriptAzureCliState<'Location, 'Name, 'ResourceGroupName, 'RetentionInterval, 'Version>

        member _.Run(state: ResourceDeploymentScriptAzureCliState<Present, Present, Present, Present, Present>) : azurerm.ResourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCli =
            let config = azurerm.ResourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCliConfig()
            for setter in state.assignments do
                setter config
            azurerm.ResourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCli(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.resourceDeploymentScriptAzureCli: missing required arguments. Must call: location, name, resource_group_name, retention_interval, version.", 9999, IsError = true)>]
        member _.Run(_: ResourceDeploymentScriptAzureCliState<_, _, _, _, _>) : azurerm.ResourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCli =
            Unchecked.defaultof<azurerm.ResourceDeploymentScriptAzureCli.ResourceDeploymentScriptAzureCli>
