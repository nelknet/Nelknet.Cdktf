namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermKeyVaultAccessPolicyAState<'Name> = { assignments: ResizeArray<azurerm.DataAzurermKeyVaultAccessPolicy.DataAzurermKeyVaultAccessPolicyAConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_access_policy">azurerm_key_vault_access_policy</a>.
    /// </summary>
    type DataAzurermKeyVaultAccessPolicyABuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermKeyVaultAccessPolicyAState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKeyVaultAccessPolicyAState<Missing>)

        member _.Zero(()) : DataAzurermKeyVaultAccessPolicyAState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKeyVaultAccessPolicyAState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_access_policy#name-1">DataAzurermKeyVaultAccessPolicyA#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermKeyVaultAccessPolicyAState<Missing>, value: string) : DataAzurermKeyVaultAccessPolicyAState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermKeyVaultAccessPolicyAState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_access_policy#id-1">DataAzurermKeyVaultAccessPolicyA#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermKeyVaultAccessPolicyAState<'Name>, value: string) : DataAzurermKeyVaultAccessPolicyAState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermKeyVaultAccessPolicyAState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_access_policy#timeouts-1">DataAzurermKeyVaultAccessPolicyA#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermKeyVaultAccessPolicyAState<'Name>, value: azurerm.DataAzurermKeyVaultAccessPolicy.DataAzurermKeyVaultAccessPolicyTimeouts) : DataAzurermKeyVaultAccessPolicyAState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermKeyVaultAccessPolicyAState<'Name>

        member _.Run(state: DataAzurermKeyVaultAccessPolicyAState<Present>) : azurerm.DataAzurermKeyVaultAccessPolicy.DataAzurermKeyVaultAccessPolicyA =
            let config = azurerm.DataAzurermKeyVaultAccessPolicy.DataAzurermKeyVaultAccessPolicyAConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermKeyVaultAccessPolicy.DataAzurermKeyVaultAccessPolicyA(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermKeyVaultAccessPolicyA: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermKeyVaultAccessPolicyAState<_>) : azurerm.DataAzurermKeyVaultAccessPolicy.DataAzurermKeyVaultAccessPolicyA =
            Unchecked.defaultof<azurerm.DataAzurermKeyVaultAccessPolicy.DataAzurermKeyVaultAccessPolicyA>
