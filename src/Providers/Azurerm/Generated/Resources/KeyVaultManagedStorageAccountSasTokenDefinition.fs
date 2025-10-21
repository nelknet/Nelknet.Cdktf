namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KeyVaultManagedStorageAccountSasTokenDefinitionState<'ManagedStorageAccountId, 'Name, 'SasTemplateUri, 'SasType, 'ValidityPeriod> = { assignments: ResizeArray<azurerm.KeyVaultManagedStorageAccountSasTokenDefinition.KeyVaultManagedStorageAccountSasTokenDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_storage_account_sas_token_definition">azurerm_key_vault_managed_storage_account_sas_token_definition</a>.
    /// </summary>
    type KeyVaultManagedStorageAccountSasTokenDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : KeyVaultManagedStorageAccountSasTokenDefinitionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KeyVaultManagedStorageAccountSasTokenDefinitionState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : KeyVaultManagedStorageAccountSasTokenDefinitionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KeyVaultManagedStorageAccountSasTokenDefinitionState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_storage_account_sas_token_definition#managed_storage_account_id-1">KeyVaultManagedStorageAccountSasTokenDefinition#managed_storage_account_id</a>.
        /// </summary>
        [<CustomOperation "managed_storage_account_id">]
        member _.ManagedStorageAccountId(state: KeyVaultManagedStorageAccountSasTokenDefinitionState<Missing, 'Name, 'SasTemplateUri, 'SasType, 'ValidityPeriod>, value: string) : KeyVaultManagedStorageAccountSasTokenDefinitionState<Present, 'Name, 'SasTemplateUri, 'SasType, 'ValidityPeriod> =
            state.assignments.Add(fun config -> config.ManagedStorageAccountId <- value)
            ({ assignments = state.assignments } : KeyVaultManagedStorageAccountSasTokenDefinitionState<Present, 'Name, 'SasTemplateUri, 'SasType, 'ValidityPeriod>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_storage_account_sas_token_definition#name-1">KeyVaultManagedStorageAccountSasTokenDefinition#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KeyVaultManagedStorageAccountSasTokenDefinitionState<'ManagedStorageAccountId, Missing, 'SasTemplateUri, 'SasType, 'ValidityPeriod>, value: string) : KeyVaultManagedStorageAccountSasTokenDefinitionState<'ManagedStorageAccountId, Present, 'SasTemplateUri, 'SasType, 'ValidityPeriod> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KeyVaultManagedStorageAccountSasTokenDefinitionState<'ManagedStorageAccountId, Present, 'SasTemplateUri, 'SasType, 'ValidityPeriod>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_storage_account_sas_token_definition#sas_template_uri-1">KeyVaultManagedStorageAccountSasTokenDefinition#sas_template_uri</a>.
        /// </summary>
        [<CustomOperation "sas_template_uri">]
        member _.SasTemplateUri(state: KeyVaultManagedStorageAccountSasTokenDefinitionState<'ManagedStorageAccountId, 'Name, Missing, 'SasType, 'ValidityPeriod>, value: string) : KeyVaultManagedStorageAccountSasTokenDefinitionState<'ManagedStorageAccountId, 'Name, Present, 'SasType, 'ValidityPeriod> =
            state.assignments.Add(fun config -> config.SasTemplateUri <- value)
            ({ assignments = state.assignments } : KeyVaultManagedStorageAccountSasTokenDefinitionState<'ManagedStorageAccountId, 'Name, Present, 'SasType, 'ValidityPeriod>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_storage_account_sas_token_definition#sas_type-1">KeyVaultManagedStorageAccountSasTokenDefinition#sas_type</a>.
        /// </summary>
        [<CustomOperation "sas_type">]
        member _.SasType(state: KeyVaultManagedStorageAccountSasTokenDefinitionState<'ManagedStorageAccountId, 'Name, 'SasTemplateUri, Missing, 'ValidityPeriod>, value: string) : KeyVaultManagedStorageAccountSasTokenDefinitionState<'ManagedStorageAccountId, 'Name, 'SasTemplateUri, Present, 'ValidityPeriod> =
            state.assignments.Add(fun config -> config.SasType <- value)
            ({ assignments = state.assignments } : KeyVaultManagedStorageAccountSasTokenDefinitionState<'ManagedStorageAccountId, 'Name, 'SasTemplateUri, Present, 'ValidityPeriod>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_storage_account_sas_token_definition#validity_period-1">KeyVaultManagedStorageAccountSasTokenDefinition#validity_period</a>.
        /// </summary>
        [<CustomOperation "validity_period">]
        member _.ValidityPeriod(state: KeyVaultManagedStorageAccountSasTokenDefinitionState<'ManagedStorageAccountId, 'Name, 'SasTemplateUri, 'SasType, Missing>, value: string) : KeyVaultManagedStorageAccountSasTokenDefinitionState<'ManagedStorageAccountId, 'Name, 'SasTemplateUri, 'SasType, Present> =
            state.assignments.Add(fun config -> config.ValidityPeriod <- value)
            ({ assignments = state.assignments } : KeyVaultManagedStorageAccountSasTokenDefinitionState<'ManagedStorageAccountId, 'Name, 'SasTemplateUri, 'SasType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_storage_account_sas_token_definition#id-1">KeyVaultManagedStorageAccountSasTokenDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KeyVaultManagedStorageAccountSasTokenDefinitionState<'ManagedStorageAccountId, 'Name, 'SasTemplateUri, 'SasType, 'ValidityPeriod>, value: string) : KeyVaultManagedStorageAccountSasTokenDefinitionState<'ManagedStorageAccountId, 'Name, 'SasTemplateUri, 'SasType, 'ValidityPeriod> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KeyVaultManagedStorageAccountSasTokenDefinitionState<'ManagedStorageAccountId, 'Name, 'SasTemplateUri, 'SasType, 'ValidityPeriod>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_storage_account_sas_token_definition#tags-1">KeyVaultManagedStorageAccountSasTokenDefinition#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: KeyVaultManagedStorageAccountSasTokenDefinitionState<'ManagedStorageAccountId, 'Name, 'SasTemplateUri, 'SasType, 'ValidityPeriod>, value: seq<string * string>) : KeyVaultManagedStorageAccountSasTokenDefinitionState<'ManagedStorageAccountId, 'Name, 'SasTemplateUri, 'SasType, 'ValidityPeriod> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : KeyVaultManagedStorageAccountSasTokenDefinitionState<'ManagedStorageAccountId, 'Name, 'SasTemplateUri, 'SasType, 'ValidityPeriod>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_storage_account_sas_token_definition#timeouts-1">KeyVaultManagedStorageAccountSasTokenDefinition#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KeyVaultManagedStorageAccountSasTokenDefinitionState<'ManagedStorageAccountId, 'Name, 'SasTemplateUri, 'SasType, 'ValidityPeriod>, value: azurerm.KeyVaultManagedStorageAccountSasTokenDefinition.KeyVaultManagedStorageAccountSasTokenDefinitionTimeouts) : KeyVaultManagedStorageAccountSasTokenDefinitionState<'ManagedStorageAccountId, 'Name, 'SasTemplateUri, 'SasType, 'ValidityPeriod> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KeyVaultManagedStorageAccountSasTokenDefinitionState<'ManagedStorageAccountId, 'Name, 'SasTemplateUri, 'SasType, 'ValidityPeriod>

        member _.Run(state: KeyVaultManagedStorageAccountSasTokenDefinitionState<Present, Present, Present, Present, Present>) : azurerm.KeyVaultManagedStorageAccountSasTokenDefinition.KeyVaultManagedStorageAccountSasTokenDefinition =
            let config = azurerm.KeyVaultManagedStorageAccountSasTokenDefinition.KeyVaultManagedStorageAccountSasTokenDefinitionConfig()
            for setter in state.assignments do
                setter config
            azurerm.KeyVaultManagedStorageAccountSasTokenDefinition.KeyVaultManagedStorageAccountSasTokenDefinition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.keyVaultManagedStorageAccountSasTokenDefinition: missing required arguments. Must call: managed_storage_account_id, name, sas_template_uri, sas_type, validity_period.", 9999, IsError = true)>]
        member _.Run(_: KeyVaultManagedStorageAccountSasTokenDefinitionState<_, _, _, _, _>) : azurerm.KeyVaultManagedStorageAccountSasTokenDefinition.KeyVaultManagedStorageAccountSasTokenDefinition =
            Unchecked.defaultof<azurerm.KeyVaultManagedStorageAccountSasTokenDefinition.KeyVaultManagedStorageAccountSasTokenDefinition>
