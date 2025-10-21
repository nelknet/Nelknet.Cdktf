namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermSshPublicKeyState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermSshPublicKey.DataAzurermSshPublicKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/ssh_public_key">azurerm_ssh_public_key</a>.
    /// </summary>
    type DataAzurermSshPublicKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermSshPublicKeyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSshPublicKeyState<Missing, Missing>)

        member _.Zero(()) : DataAzurermSshPublicKeyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSshPublicKeyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/ssh_public_key#name-1">DataAzurermSshPublicKey#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermSshPublicKeyState<Missing, 'ResourceGroupName>, value: string) : DataAzurermSshPublicKeyState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermSshPublicKeyState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/ssh_public_key#resource_group_name-1">DataAzurermSshPublicKey#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermSshPublicKeyState<'Name, Missing>, value: string) : DataAzurermSshPublicKeyState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermSshPublicKeyState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/ssh_public_key#id-1">DataAzurermSshPublicKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermSshPublicKeyState<'Name, 'ResourceGroupName>, value: string) : DataAzurermSshPublicKeyState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermSshPublicKeyState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/ssh_public_key#tags-1">DataAzurermSshPublicKey#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAzurermSshPublicKeyState<'Name, 'ResourceGroupName>, value: seq<string * string>) : DataAzurermSshPublicKeyState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAzurermSshPublicKeyState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/ssh_public_key#timeouts-1">DataAzurermSshPublicKey#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermSshPublicKeyState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermSshPublicKey.DataAzurermSshPublicKeyTimeouts) : DataAzurermSshPublicKeyState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermSshPublicKeyState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermSshPublicKeyState<Present, Present>) : azurerm.DataAzurermSshPublicKey.DataAzurermSshPublicKey =
            let config = azurerm.DataAzurermSshPublicKey.DataAzurermSshPublicKeyConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermSshPublicKey.DataAzurermSshPublicKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermSshPublicKey: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermSshPublicKeyState<_, _>) : azurerm.DataAzurermSshPublicKey.DataAzurermSshPublicKey =
            Unchecked.defaultof<azurerm.DataAzurermSshPublicKey.DataAzurermSshPublicKey>
