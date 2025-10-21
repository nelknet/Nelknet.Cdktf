namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SshPublicKeyState<'Location, 'Name, 'PublicKey, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.SshPublicKey.SshPublicKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ssh_public_key">azurerm_ssh_public_key</a>.
    /// </summary>
    type SshPublicKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : SshPublicKeyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SshPublicKeyState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SshPublicKeyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SshPublicKeyState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ssh_public_key#location-1">SshPublicKey#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: SshPublicKeyState<Missing, 'Name, 'PublicKey, 'ResourceGroupName>, value: string) : SshPublicKeyState<Present, 'Name, 'PublicKey, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : SshPublicKeyState<Present, 'Name, 'PublicKey, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ssh_public_key#name-1">SshPublicKey#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SshPublicKeyState<'Location, Missing, 'PublicKey, 'ResourceGroupName>, value: string) : SshPublicKeyState<'Location, Present, 'PublicKey, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SshPublicKeyState<'Location, Present, 'PublicKey, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ssh_public_key#public_key-1">SshPublicKey#public_key</a>.
        /// </summary>
        [<CustomOperation "public_key">]
        member _.PublicKey(state: SshPublicKeyState<'Location, 'Name, Missing, 'ResourceGroupName>, value: string) : SshPublicKeyState<'Location, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicKey <- value)
            ({ assignments = state.assignments } : SshPublicKeyState<'Location, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ssh_public_key#resource_group_name-1">SshPublicKey#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: SshPublicKeyState<'Location, 'Name, 'PublicKey, Missing>, value: string) : SshPublicKeyState<'Location, 'Name, 'PublicKey, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : SshPublicKeyState<'Location, 'Name, 'PublicKey, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ssh_public_key#id-1">SshPublicKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SshPublicKeyState<'Location, 'Name, 'PublicKey, 'ResourceGroupName>, value: string) : SshPublicKeyState<'Location, 'Name, 'PublicKey, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SshPublicKeyState<'Location, 'Name, 'PublicKey, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ssh_public_key#tags-1">SshPublicKey#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SshPublicKeyState<'Location, 'Name, 'PublicKey, 'ResourceGroupName>, value: seq<string * string>) : SshPublicKeyState<'Location, 'Name, 'PublicKey, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SshPublicKeyState<'Location, 'Name, 'PublicKey, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ssh_public_key#timeouts-1">SshPublicKey#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SshPublicKeyState<'Location, 'Name, 'PublicKey, 'ResourceGroupName>, value: azurerm.SshPublicKey.SshPublicKeyTimeouts) : SshPublicKeyState<'Location, 'Name, 'PublicKey, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SshPublicKeyState<'Location, 'Name, 'PublicKey, 'ResourceGroupName>

        member _.Run(state: SshPublicKeyState<Present, Present, Present, Present>) : azurerm.SshPublicKey.SshPublicKey =
            let config = azurerm.SshPublicKey.SshPublicKeyConfig()
            for setter in state.assignments do
                setter config
            azurerm.SshPublicKey.SshPublicKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sshPublicKey: missing required arguments. Must call: location, name, public_key, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: SshPublicKeyState<_, _, _, _>) : azurerm.SshPublicKey.SshPublicKey =
            Unchecked.defaultof<azurerm.SshPublicKey.SshPublicKey>
