namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermKeyVaultState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermKeyVault.DataAzurermKeyVaultConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault">azurerm_key_vault</a>.
    /// </summary>
    type DataAzurermKeyVaultBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermKeyVaultState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKeyVaultState<Missing, Missing>)

        member _.Zero(()) : DataAzurermKeyVaultState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKeyVaultState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault#name-1">DataAzurermKeyVault#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermKeyVaultState<Missing, 'ResourceGroupName>, value: string) : DataAzurermKeyVaultState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermKeyVaultState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault#resource_group_name-1">DataAzurermKeyVault#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermKeyVaultState<'Name, Missing>, value: string) : DataAzurermKeyVaultState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermKeyVaultState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault#id-1">DataAzurermKeyVault#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermKeyVaultState<'Name, 'ResourceGroupName>, value: string) : DataAzurermKeyVaultState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermKeyVaultState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault#timeouts-1">DataAzurermKeyVault#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermKeyVaultState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermKeyVault.DataAzurermKeyVaultTimeouts) : DataAzurermKeyVaultState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermKeyVaultState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermKeyVaultState<Present, Present>) : azurerm.DataAzurermKeyVault.DataAzurermKeyVault =
            let config = azurerm.DataAzurermKeyVault.DataAzurermKeyVaultConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermKeyVault.DataAzurermKeyVault(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermKeyVault: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermKeyVaultState<_, _>) : azurerm.DataAzurermKeyVault.DataAzurermKeyVault =
            Unchecked.defaultof<azurerm.DataAzurermKeyVault.DataAzurermKeyVault>
