namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppConfigurationKeyState<'ConfigurationStoreId, 'Key> = { assignments: ResizeArray<azurerm.AppConfigurationKey.AppConfigurationKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_key">azurerm_app_configuration_key</a>.
    /// </summary>
    type AppConfigurationKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppConfigurationKeyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppConfigurationKeyState<Missing, Missing>)

        member _.Zero(()) : AppConfigurationKeyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppConfigurationKeyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_key#configuration_store_id-1">AppConfigurationKey#configuration_store_id</a>.
        /// </summary>
        [<CustomOperation "configuration_store_id">]
        member _.ConfigurationStoreId(state: AppConfigurationKeyState<Missing, 'Key>, value: string) : AppConfigurationKeyState<Present, 'Key> =
            state.assignments.Add(fun config -> config.ConfigurationStoreId <- value)
            ({ assignments = state.assignments } : AppConfigurationKeyState<Present, 'Key>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_key#key-1">AppConfigurationKey#key</a>.
        /// </summary>
        [<CustomOperation "key">]
        member _.Key(state: AppConfigurationKeyState<'ConfigurationStoreId, Missing>, value: string) : AppConfigurationKeyState<'ConfigurationStoreId, Present> =
            state.assignments.Add(fun config -> config.Key <- value)
            ({ assignments = state.assignments } : AppConfigurationKeyState<'ConfigurationStoreId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_key#content_type-1">AppConfigurationKey#content_type</a>.
        /// </summary>
        [<CustomOperation "content_type">]
        member _.ContentType(state: AppConfigurationKeyState<'ConfigurationStoreId, 'Key>, value: string) : AppConfigurationKeyState<'ConfigurationStoreId, 'Key> =
            state.assignments.Add(fun config -> config.ContentType <- value)
            state : AppConfigurationKeyState<'ConfigurationStoreId, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_key#etag-1">AppConfigurationKey#etag</a>.
        /// </summary>
        [<CustomOperation "etag">]
        member _.Etag(state: AppConfigurationKeyState<'ConfigurationStoreId, 'Key>, value: string) : AppConfigurationKeyState<'ConfigurationStoreId, 'Key> =
            state.assignments.Add(fun config -> config.Etag <- value)
            state : AppConfigurationKeyState<'ConfigurationStoreId, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_key#id-1">AppConfigurationKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppConfigurationKeyState<'ConfigurationStoreId, 'Key>, value: string) : AppConfigurationKeyState<'ConfigurationStoreId, 'Key> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppConfigurationKeyState<'ConfigurationStoreId, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_key#label-1">AppConfigurationKey#label</a>.
        /// </summary>
        [<CustomOperation "label">]
        member _.Label(state: AppConfigurationKeyState<'ConfigurationStoreId, 'Key>, value: string) : AppConfigurationKeyState<'ConfigurationStoreId, 'Key> =
            state.assignments.Add(fun config -> config.Label <- value)
            state : AppConfigurationKeyState<'ConfigurationStoreId, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_key#locked-1">AppConfigurationKey#locked</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "locked">]
        member _.Locked(state: AppConfigurationKeyState<'ConfigurationStoreId, 'Key>, value: bool) : AppConfigurationKeyState<'ConfigurationStoreId, 'Key> =
            state.assignments.Add(fun config -> config.Locked <- value)
            state : AppConfigurationKeyState<'ConfigurationStoreId, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_key#locked-1">AppConfigurationKey#locked</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "locked">]
        member _.Locked(state: AppConfigurationKeyState<'ConfigurationStoreId, 'Key>, value: HashiCorp.Cdktf.IResolvable) : AppConfigurationKeyState<'ConfigurationStoreId, 'Key> =
            state.assignments.Add(fun config -> config.Locked <- value)
            state : AppConfigurationKeyState<'ConfigurationStoreId, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_key#tags-1">AppConfigurationKey#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppConfigurationKeyState<'ConfigurationStoreId, 'Key>, value: seq<string * string>) : AppConfigurationKeyState<'ConfigurationStoreId, 'Key> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppConfigurationKeyState<'ConfigurationStoreId, 'Key>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_key#timeouts-1">AppConfigurationKey#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AppConfigurationKeyState<'ConfigurationStoreId, 'Key>, value: azurerm.AppConfigurationKey.AppConfigurationKeyTimeouts) : AppConfigurationKeyState<'ConfigurationStoreId, 'Key> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AppConfigurationKeyState<'ConfigurationStoreId, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_key#type-1">AppConfigurationKey#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: AppConfigurationKeyState<'ConfigurationStoreId, 'Key>, value: string) : AppConfigurationKeyState<'ConfigurationStoreId, 'Key> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : AppConfigurationKeyState<'ConfigurationStoreId, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_key#value-1">AppConfigurationKey#value</a>.
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: AppConfigurationKeyState<'ConfigurationStoreId, 'Key>, value: string) : AppConfigurationKeyState<'ConfigurationStoreId, 'Key> =
            state.assignments.Add(fun config -> config.Value <- value)
            state : AppConfigurationKeyState<'ConfigurationStoreId, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_key#vault_key_reference-1">AppConfigurationKey#vault_key_reference</a>.
        /// </summary>
        [<CustomOperation "vault_key_reference">]
        member _.VaultKeyReference(state: AppConfigurationKeyState<'ConfigurationStoreId, 'Key>, value: string) : AppConfigurationKeyState<'ConfigurationStoreId, 'Key> =
            state.assignments.Add(fun config -> config.VaultKeyReference <- value)
            state : AppConfigurationKeyState<'ConfigurationStoreId, 'Key>

        member _.Run(state: AppConfigurationKeyState<Present, Present>) : azurerm.AppConfigurationKey.AppConfigurationKey =
            let config = azurerm.AppConfigurationKey.AppConfigurationKeyConfig()
            for setter in state.assignments do
                setter config
            azurerm.AppConfigurationKey.AppConfigurationKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.appConfigurationKey: missing required arguments. Must call: configuration_store_id, key.", 9999, IsError = true)>]
        member _.Run(_: AppConfigurationKeyState<_, _>) : azurerm.AppConfigurationKey.AppConfigurationKey =
            Unchecked.defaultof<azurerm.AppConfigurationKey.AppConfigurationKey>
