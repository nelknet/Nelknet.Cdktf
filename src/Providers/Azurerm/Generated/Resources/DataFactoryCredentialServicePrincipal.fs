namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryCredentialServicePrincipalState<'DataFactoryId, 'Name, 'ServicePrincipalId, 'TenantId> = { assignments: ResizeArray<azurerm.DataFactoryCredentialServicePrincipal.DataFactoryCredentialServicePrincipalConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_credential_service_principal">azurerm_data_factory_credential_service_principal</a>.
    /// </summary>
    type DataFactoryCredentialServicePrincipalBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryCredentialServicePrincipalState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryCredentialServicePrincipalState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryCredentialServicePrincipalState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryCredentialServicePrincipalState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// The resource ID of the parent Data Factory. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_credential_service_principal#data_factory_id-1">DataFactoryCredentialServicePrincipal#data_factory_id</a>
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryCredentialServicePrincipalState<Missing, 'Name, 'ServicePrincipalId, 'TenantId>, value: string) : DataFactoryCredentialServicePrincipalState<Present, 'Name, 'ServicePrincipalId, 'TenantId> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryCredentialServicePrincipalState<Present, 'Name, 'ServicePrincipalId, 'TenantId>)

        /// <summary>
        /// The desired name of the credential resource. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_credential_service_principal#name-1">DataFactoryCredentialServicePrincipal#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryCredentialServicePrincipalState<'DataFactoryId, Missing, 'ServicePrincipalId, 'TenantId>, value: string) : DataFactoryCredentialServicePrincipalState<'DataFactoryId, Present, 'ServicePrincipalId, 'TenantId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryCredentialServicePrincipalState<'DataFactoryId, Present, 'ServicePrincipalId, 'TenantId>)

        /// <summary>
        /// The Client ID of the Service Principal. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_credential_service_principal#service_principal_id-1">DataFactoryCredentialServicePrincipal#service_principal_id</a>
        /// </summary>
        [<CustomOperation "service_principal_id">]
        member _.ServicePrincipalId(state: DataFactoryCredentialServicePrincipalState<'DataFactoryId, 'Name, Missing, 'TenantId>, value: string) : DataFactoryCredentialServicePrincipalState<'DataFactoryId, 'Name, Present, 'TenantId> =
            state.assignments.Add(fun config -> config.ServicePrincipalId <- value)
            ({ assignments = state.assignments } : DataFactoryCredentialServicePrincipalState<'DataFactoryId, 'Name, Present, 'TenantId>)

        /// <summary>
        /// The Tenant ID of the Service Principal. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_credential_service_principal#tenant_id-1">DataFactoryCredentialServicePrincipal#tenant_id</a>
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: DataFactoryCredentialServicePrincipalState<'DataFactoryId, 'Name, 'ServicePrincipalId, Missing>, value: string) : DataFactoryCredentialServicePrincipalState<'DataFactoryId, 'Name, 'ServicePrincipalId, Present> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            ({ assignments = state.assignments } : DataFactoryCredentialServicePrincipalState<'DataFactoryId, 'Name, 'ServicePrincipalId, Present>)

        /// <summary>
        /// (Optional) List of string annotations. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_credential_service_principal#annotations-1">DataFactoryCredentialServicePrincipal#annotations</a>
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryCredentialServicePrincipalState<'DataFactoryId, 'Name, 'ServicePrincipalId, 'TenantId>, value: seq<string>) : DataFactoryCredentialServicePrincipalState<'DataFactoryId, 'Name, 'ServicePrincipalId, 'TenantId> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryCredentialServicePrincipalState<'DataFactoryId, 'Name, 'ServicePrincipalId, 'TenantId>

        /// <summary>
        /// (Optional) Short text description. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_credential_service_principal#description-1">DataFactoryCredentialServicePrincipal#description</a>
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryCredentialServicePrincipalState<'DataFactoryId, 'Name, 'ServicePrincipalId, 'TenantId>, value: string) : DataFactoryCredentialServicePrincipalState<'DataFactoryId, 'Name, 'ServicePrincipalId, 'TenantId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryCredentialServicePrincipalState<'DataFactoryId, 'Name, 'ServicePrincipalId, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_credential_service_principal#id-1">DataFactoryCredentialServicePrincipal#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryCredentialServicePrincipalState<'DataFactoryId, 'Name, 'ServicePrincipalId, 'TenantId>, value: string) : DataFactoryCredentialServicePrincipalState<'DataFactoryId, 'Name, 'ServicePrincipalId, 'TenantId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryCredentialServicePrincipalState<'DataFactoryId, 'Name, 'ServicePrincipalId, 'TenantId>

        /// <summary>
        /// service_principal_key block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_credential_service_principal#service_principal_key-1">DataFactoryCredentialServicePrincipal#service_principal_key</a>
        /// </summary>
        [<CustomOperation "service_principal_key">]
        member _.ServicePrincipalKey(state: DataFactoryCredentialServicePrincipalState<'DataFactoryId, 'Name, 'ServicePrincipalId, 'TenantId>, value: azurerm.DataFactoryCredentialServicePrincipal.DataFactoryCredentialServicePrincipalServicePrincipalKey) : DataFactoryCredentialServicePrincipalState<'DataFactoryId, 'Name, 'ServicePrincipalId, 'TenantId> =
            state.assignments.Add(fun config -> config.ServicePrincipalKey <- value)
            state : DataFactoryCredentialServicePrincipalState<'DataFactoryId, 'Name, 'ServicePrincipalId, 'TenantId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_credential_service_principal#timeouts-1">DataFactoryCredentialServicePrincipal#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryCredentialServicePrincipalState<'DataFactoryId, 'Name, 'ServicePrincipalId, 'TenantId>, value: azurerm.DataFactoryCredentialServicePrincipal.DataFactoryCredentialServicePrincipalTimeouts) : DataFactoryCredentialServicePrincipalState<'DataFactoryId, 'Name, 'ServicePrincipalId, 'TenantId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryCredentialServicePrincipalState<'DataFactoryId, 'Name, 'ServicePrincipalId, 'TenantId>

        member _.Run(state: DataFactoryCredentialServicePrincipalState<Present, Present, Present, Present>) : azurerm.DataFactoryCredentialServicePrincipal.DataFactoryCredentialServicePrincipal =
            let config = azurerm.DataFactoryCredentialServicePrincipal.DataFactoryCredentialServicePrincipalConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryCredentialServicePrincipal.DataFactoryCredentialServicePrincipal(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryCredentialServicePrincipal: missing required arguments. Must call: data_factory_id, name, service_principal_id, tenant_id.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryCredentialServicePrincipalState<_, _, _, _>) : azurerm.DataFactoryCredentialServicePrincipal.DataFactoryCredentialServicePrincipal =
            Unchecked.defaultof<azurerm.DataFactoryCredentialServicePrincipal.DataFactoryCredentialServicePrincipal>
