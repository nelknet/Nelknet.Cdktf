namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KeyVaultAccessPolicyAState<'KeyVaultId, 'ObjectId, 'TenantId> = { assignments: ResizeArray<azurerm.KeyVaultAccessPolicy.KeyVaultAccessPolicyAConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_access_policy">azurerm_key_vault_access_policy</a>.
    /// </summary>
    type KeyVaultAccessPolicyABuilder(logicalId: string) =
        member _.Yield(_: unit) : KeyVaultAccessPolicyAState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KeyVaultAccessPolicyAState<Missing, Missing, Missing>)

        member _.Zero(()) : KeyVaultAccessPolicyAState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KeyVaultAccessPolicyAState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_access_policy#key_vault_id-1">KeyVaultAccessPolicyA#key_vault_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_id">]
        member _.KeyVaultId(state: KeyVaultAccessPolicyAState<Missing, 'ObjectId, 'TenantId>, value: string) : KeyVaultAccessPolicyAState<Present, 'ObjectId, 'TenantId> =
            state.assignments.Add(fun config -> config.KeyVaultId <- value)
            ({ assignments = state.assignments } : KeyVaultAccessPolicyAState<Present, 'ObjectId, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_access_policy#object_id-1">KeyVaultAccessPolicyA#object_id</a>.
        /// </summary>
        [<CustomOperation "object_id">]
        member _.ObjectId(state: KeyVaultAccessPolicyAState<'KeyVaultId, Missing, 'TenantId>, value: string) : KeyVaultAccessPolicyAState<'KeyVaultId, Present, 'TenantId> =
            state.assignments.Add(fun config -> config.ObjectId <- value)
            ({ assignments = state.assignments } : KeyVaultAccessPolicyAState<'KeyVaultId, Present, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_access_policy#tenant_id-1">KeyVaultAccessPolicyA#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: KeyVaultAccessPolicyAState<'KeyVaultId, 'ObjectId, Missing>, value: string) : KeyVaultAccessPolicyAState<'KeyVaultId, 'ObjectId, Present> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            ({ assignments = state.assignments } : KeyVaultAccessPolicyAState<'KeyVaultId, 'ObjectId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_access_policy#application_id-1">KeyVaultAccessPolicyA#application_id</a>.
        /// </summary>
        [<CustomOperation "application_id">]
        member _.ApplicationId(state: KeyVaultAccessPolicyAState<'KeyVaultId, 'ObjectId, 'TenantId>, value: string) : KeyVaultAccessPolicyAState<'KeyVaultId, 'ObjectId, 'TenantId> =
            state.assignments.Add(fun config -> config.ApplicationId <- value)
            state : KeyVaultAccessPolicyAState<'KeyVaultId, 'ObjectId, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_access_policy#certificate_permissions-1">KeyVaultAccessPolicyA#certificate_permissions</a>.
        /// </summary>
        [<CustomOperation "certificate_permissions">]
        member _.CertificatePermissions(state: KeyVaultAccessPolicyAState<'KeyVaultId, 'ObjectId, 'TenantId>, value: seq<string>) : KeyVaultAccessPolicyAState<'KeyVaultId, 'ObjectId, 'TenantId> =
            state.assignments.Add(fun config -> config.CertificatePermissions <- (value |> Seq.toArray))
            state : KeyVaultAccessPolicyAState<'KeyVaultId, 'ObjectId, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_access_policy#id-1">KeyVaultAccessPolicyA#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KeyVaultAccessPolicyAState<'KeyVaultId, 'ObjectId, 'TenantId>, value: string) : KeyVaultAccessPolicyAState<'KeyVaultId, 'ObjectId, 'TenantId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KeyVaultAccessPolicyAState<'KeyVaultId, 'ObjectId, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_access_policy#key_permissions-1">KeyVaultAccessPolicyA#key_permissions</a>.
        /// </summary>
        [<CustomOperation "key_permissions">]
        member _.KeyPermissions(state: KeyVaultAccessPolicyAState<'KeyVaultId, 'ObjectId, 'TenantId>, value: seq<string>) : KeyVaultAccessPolicyAState<'KeyVaultId, 'ObjectId, 'TenantId> =
            state.assignments.Add(fun config -> config.KeyPermissions <- (value |> Seq.toArray))
            state : KeyVaultAccessPolicyAState<'KeyVaultId, 'ObjectId, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_access_policy#secret_permissions-1">KeyVaultAccessPolicyA#secret_permissions</a>.
        /// </summary>
        [<CustomOperation "secret_permissions">]
        member _.SecretPermissions(state: KeyVaultAccessPolicyAState<'KeyVaultId, 'ObjectId, 'TenantId>, value: seq<string>) : KeyVaultAccessPolicyAState<'KeyVaultId, 'ObjectId, 'TenantId> =
            state.assignments.Add(fun config -> config.SecretPermissions <- (value |> Seq.toArray))
            state : KeyVaultAccessPolicyAState<'KeyVaultId, 'ObjectId, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_access_policy#storage_permissions-1">KeyVaultAccessPolicyA#storage_permissions</a>.
        /// </summary>
        [<CustomOperation "storage_permissions">]
        member _.StoragePermissions(state: KeyVaultAccessPolicyAState<'KeyVaultId, 'ObjectId, 'TenantId>, value: seq<string>) : KeyVaultAccessPolicyAState<'KeyVaultId, 'ObjectId, 'TenantId> =
            state.assignments.Add(fun config -> config.StoragePermissions <- (value |> Seq.toArray))
            state : KeyVaultAccessPolicyAState<'KeyVaultId, 'ObjectId, 'TenantId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_access_policy#timeouts-1">KeyVaultAccessPolicyA#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KeyVaultAccessPolicyAState<'KeyVaultId, 'ObjectId, 'TenantId>, value: azurerm.KeyVaultAccessPolicy.KeyVaultAccessPolicyTimeouts) : KeyVaultAccessPolicyAState<'KeyVaultId, 'ObjectId, 'TenantId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KeyVaultAccessPolicyAState<'KeyVaultId, 'ObjectId, 'TenantId>

        member _.Run(state: KeyVaultAccessPolicyAState<Present, Present, Present>) : azurerm.KeyVaultAccessPolicy.KeyVaultAccessPolicyA =
            let config = azurerm.KeyVaultAccessPolicy.KeyVaultAccessPolicyAConfig()
            for setter in state.assignments do
                setter config
            azurerm.KeyVaultAccessPolicy.KeyVaultAccessPolicyA(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.keyVaultAccessPolicyA: missing required arguments. Must call: key_vault_id, object_id, tenant_id.", 9999, IsError = true)>]
        member _.Run(_: KeyVaultAccessPolicyAState<_, _, _>) : azurerm.KeyVaultAccessPolicy.KeyVaultAccessPolicyA =
            Unchecked.defaultof<azurerm.KeyVaultAccessPolicy.KeyVaultAccessPolicyA>
