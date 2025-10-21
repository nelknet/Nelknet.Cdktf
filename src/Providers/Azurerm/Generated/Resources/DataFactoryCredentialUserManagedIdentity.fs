namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryCredentialUserManagedIdentityState<'DataFactoryId, 'IdentityId, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryCredentialUserManagedIdentity.DataFactoryCredentialUserManagedIdentityConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_credential_user_managed_identity">azurerm_data_factory_credential_user_managed_identity</a>.
    /// </summary>
    type DataFactoryCredentialUserManagedIdentityBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryCredentialUserManagedIdentityState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryCredentialUserManagedIdentityState<Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryCredentialUserManagedIdentityState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryCredentialUserManagedIdentityState<Missing, Missing, Missing>)

        /// <summary>
        /// The resource ID of the parent Data Factory. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_credential_user_managed_identity#data_factory_id-1">DataFactoryCredentialUserManagedIdentity#data_factory_id</a>
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryCredentialUserManagedIdentityState<Missing, 'IdentityId, 'Name>, value: string) : DataFactoryCredentialUserManagedIdentityState<Present, 'IdentityId, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryCredentialUserManagedIdentityState<Present, 'IdentityId, 'Name>)

        /// <summary>
        /// The resource ID of the User Assigned Managed Identity. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_credential_user_managed_identity#identity_id-1">DataFactoryCredentialUserManagedIdentity#identity_id</a>
        /// </summary>
        [<CustomOperation "identity_id">]
        member _.IdentityId(state: DataFactoryCredentialUserManagedIdentityState<'DataFactoryId, Missing, 'Name>, value: string) : DataFactoryCredentialUserManagedIdentityState<'DataFactoryId, Present, 'Name> =
            state.assignments.Add(fun config -> config.IdentityId <- value)
            ({ assignments = state.assignments } : DataFactoryCredentialUserManagedIdentityState<'DataFactoryId, Present, 'Name>)

        /// <summary>
        /// The desired name of the credential resource. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_credential_user_managed_identity#name-1">DataFactoryCredentialUserManagedIdentity#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryCredentialUserManagedIdentityState<'DataFactoryId, 'IdentityId, Missing>, value: string) : DataFactoryCredentialUserManagedIdentityState<'DataFactoryId, 'IdentityId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryCredentialUserManagedIdentityState<'DataFactoryId, 'IdentityId, Present>)

        /// <summary>
        /// (Optional) List of string annotations. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_credential_user_managed_identity#annotations-1">DataFactoryCredentialUserManagedIdentity#annotations</a>
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryCredentialUserManagedIdentityState<'DataFactoryId, 'IdentityId, 'Name>, value: seq<string>) : DataFactoryCredentialUserManagedIdentityState<'DataFactoryId, 'IdentityId, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryCredentialUserManagedIdentityState<'DataFactoryId, 'IdentityId, 'Name>

        /// <summary>
        /// (Optional) Short text description. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_credential_user_managed_identity#description-1">DataFactoryCredentialUserManagedIdentity#description</a>
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryCredentialUserManagedIdentityState<'DataFactoryId, 'IdentityId, 'Name>, value: string) : DataFactoryCredentialUserManagedIdentityState<'DataFactoryId, 'IdentityId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryCredentialUserManagedIdentityState<'DataFactoryId, 'IdentityId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_credential_user_managed_identity#id-1">DataFactoryCredentialUserManagedIdentity#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryCredentialUserManagedIdentityState<'DataFactoryId, 'IdentityId, 'Name>, value: string) : DataFactoryCredentialUserManagedIdentityState<'DataFactoryId, 'IdentityId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryCredentialUserManagedIdentityState<'DataFactoryId, 'IdentityId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_credential_user_managed_identity#timeouts-1">DataFactoryCredentialUserManagedIdentity#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryCredentialUserManagedIdentityState<'DataFactoryId, 'IdentityId, 'Name>, value: azurerm.DataFactoryCredentialUserManagedIdentity.DataFactoryCredentialUserManagedIdentityTimeouts) : DataFactoryCredentialUserManagedIdentityState<'DataFactoryId, 'IdentityId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryCredentialUserManagedIdentityState<'DataFactoryId, 'IdentityId, 'Name>

        member _.Run(state: DataFactoryCredentialUserManagedIdentityState<Present, Present, Present>) : azurerm.DataFactoryCredentialUserManagedIdentity.DataFactoryCredentialUserManagedIdentity =
            let config = azurerm.DataFactoryCredentialUserManagedIdentity.DataFactoryCredentialUserManagedIdentityConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryCredentialUserManagedIdentity.DataFactoryCredentialUserManagedIdentity(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryCredentialUserManagedIdentity: missing required arguments. Must call: data_factory_id, identity_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryCredentialUserManagedIdentityState<_, _, _>) : azurerm.DataFactoryCredentialUserManagedIdentity.DataFactoryCredentialUserManagedIdentity =
            Unchecked.defaultof<azurerm.DataFactoryCredentialUserManagedIdentity.DataFactoryCredentialUserManagedIdentity>
