namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StaticWebAppState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.StaticWebApp.StaticWebAppConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app">azurerm_static_web_app</a>.
    /// </summary>
    type StaticWebAppBuilder(logicalId: string) =
        member _.Yield(_: unit) : StaticWebAppState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StaticWebAppState<Missing, Missing, Missing>)

        member _.Zero(()) : StaticWebAppState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StaticWebAppState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app#location-1">StaticWebApp#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: StaticWebAppState<Missing, 'Name, 'ResourceGroupName>, value: string) : StaticWebAppState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : StaticWebAppState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app#name-1">StaticWebApp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StaticWebAppState<'Location, Missing, 'ResourceGroupName>, value: string) : StaticWebAppState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StaticWebAppState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app#resource_group_name-1">StaticWebApp#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: StaticWebAppState<'Location, 'Name, Missing>, value: string) : StaticWebAppState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : StaticWebAppState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app#app_settings-1">StaticWebApp#app_settings</a>.
        /// </summary>
        [<CustomOperation "app_settings">]
        member _.AppSettings(state: StaticWebAppState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : StaticWebAppState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AppSettings <- dict value)
            state : StaticWebAppState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// basic_auth block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app#basic_auth-1">StaticWebApp#basic_auth</a>
        /// </summary>
        [<CustomOperation "basic_auth">]
        member _.BasicAuth(state: StaticWebAppState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.StaticWebApp.StaticWebAppBasicAuth) : StaticWebAppState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BasicAuth <- value)
            state : StaticWebAppState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app#configuration_file_changes_enabled-1">StaticWebApp#configuration_file_changes_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "configuration_file_changes_enabled">]
        member _.ConfigurationFileChangesEnabled(state: StaticWebAppState<'Location, 'Name, 'ResourceGroupName>, value: bool) : StaticWebAppState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ConfigurationFileChangesEnabled <- value)
            state : StaticWebAppState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app#configuration_file_changes_enabled-1">StaticWebApp#configuration_file_changes_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "configuration_file_changes_enabled">]
        member _.ConfigurationFileChangesEnabled(state: StaticWebAppState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : StaticWebAppState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ConfigurationFileChangesEnabled <- value)
            state : StaticWebAppState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app#id-1">StaticWebApp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StaticWebAppState<'Location, 'Name, 'ResourceGroupName>, value: string) : StaticWebAppState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StaticWebAppState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app#identity-1">StaticWebApp#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: StaticWebAppState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.StaticWebApp.StaticWebAppIdentity) : StaticWebAppState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : StaticWebAppState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app#preview_environments_enabled-1">StaticWebApp#preview_environments_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "preview_environments_enabled">]
        member _.PreviewEnvironmentsEnabled(state: StaticWebAppState<'Location, 'Name, 'ResourceGroupName>, value: bool) : StaticWebAppState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PreviewEnvironmentsEnabled <- value)
            state : StaticWebAppState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app#preview_environments_enabled-1">StaticWebApp#preview_environments_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "preview_environments_enabled">]
        member _.PreviewEnvironmentsEnabled(state: StaticWebAppState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : StaticWebAppState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PreviewEnvironmentsEnabled <- value)
            state : StaticWebAppState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app#sku_size-1">StaticWebApp#sku_size</a>.
        /// </summary>
        [<CustomOperation "sku_size">]
        member _.SkuSize(state: StaticWebAppState<'Location, 'Name, 'ResourceGroupName>, value: string) : StaticWebAppState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SkuSize <- value)
            state : StaticWebAppState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app#sku_tier-1">StaticWebApp#sku_tier</a>.
        /// </summary>
        [<CustomOperation "sku_tier">]
        member _.SkuTier(state: StaticWebAppState<'Location, 'Name, 'ResourceGroupName>, value: string) : StaticWebAppState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SkuTier <- value)
            state : StaticWebAppState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app#tags-1">StaticWebApp#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: StaticWebAppState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : StaticWebAppState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : StaticWebAppState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app#timeouts-1">StaticWebApp#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StaticWebAppState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.StaticWebApp.StaticWebAppTimeouts) : StaticWebAppState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StaticWebAppState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: StaticWebAppState<Present, Present, Present>) : azurerm.StaticWebApp.StaticWebApp =
            let config = azurerm.StaticWebApp.StaticWebAppConfig()
            for setter in state.assignments do
                setter config
            azurerm.StaticWebApp.StaticWebApp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.staticWebApp: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: StaticWebAppState<_, _, _>) : azurerm.StaticWebApp.StaticWebApp =
            Unchecked.defaultof<azurerm.StaticWebApp.StaticWebApp>
