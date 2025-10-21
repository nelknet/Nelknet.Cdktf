namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryLinkedServiceKusto.DataFactoryLinkedServiceKustoConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_kusto">azurerm_data_factory_linked_service_kusto</a>.
    /// </summary>
    type DataFactoryLinkedServiceKustoBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryLinkedServiceKustoState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceKustoState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryLinkedServiceKustoState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceKustoState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_kusto#data_factory_id-1">DataFactoryLinkedServiceKusto#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryLinkedServiceKustoState<Missing, 'KustoDatabaseName, 'KustoEndpoint, 'Name>, value: string) : DataFactoryLinkedServiceKustoState<Present, 'KustoDatabaseName, 'KustoEndpoint, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceKustoState<Present, 'KustoDatabaseName, 'KustoEndpoint, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_kusto#kusto_database_name-1">DataFactoryLinkedServiceKusto#kusto_database_name</a>.
        /// </summary>
        [<CustomOperation "kusto_database_name">]
        member _.KustoDatabaseName(state: DataFactoryLinkedServiceKustoState<'DataFactoryId, Missing, 'KustoEndpoint, 'Name>, value: string) : DataFactoryLinkedServiceKustoState<'DataFactoryId, Present, 'KustoEndpoint, 'Name> =
            state.assignments.Add(fun config -> config.KustoDatabaseName <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceKustoState<'DataFactoryId, Present, 'KustoEndpoint, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_kusto#kusto_endpoint-1">DataFactoryLinkedServiceKusto#kusto_endpoint</a>.
        /// </summary>
        [<CustomOperation "kusto_endpoint">]
        member _.KustoEndpoint(state: DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, Missing, 'Name>, value: string) : DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, Present, 'Name> =
            state.assignments.Add(fun config -> config.KustoEndpoint <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_kusto#name-1">DataFactoryLinkedServiceKusto#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, Missing>, value: string) : DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_kusto#additional_properties-1">DataFactoryLinkedServiceKusto#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name>, value: seq<string * string>) : DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_kusto#annotations-1">DataFactoryLinkedServiceKusto#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name>, value: seq<string>) : DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_kusto#description-1">DataFactoryLinkedServiceKusto#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name>, value: string) : DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_kusto#id-1">DataFactoryLinkedServiceKusto#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name>, value: string) : DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_kusto#integration_runtime_name-1">DataFactoryLinkedServiceKusto#integration_runtime_name</a>.
        /// </summary>
        [<CustomOperation "integration_runtime_name">]
        member _.IntegrationRuntimeName(state: DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name>, value: string) : DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name> =
            state.assignments.Add(fun config -> config.IntegrationRuntimeName <- value)
            state : DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_kusto#parameters-1">DataFactoryLinkedServiceKusto#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name>, value: seq<string * string>) : DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_kusto#service_principal_id-1">DataFactoryLinkedServiceKusto#service_principal_id</a>.
        /// </summary>
        [<CustomOperation "service_principal_id">]
        member _.ServicePrincipalId(state: DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name>, value: string) : DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name> =
            state.assignments.Add(fun config -> config.ServicePrincipalId <- value)
            state : DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_kusto#service_principal_key-1">DataFactoryLinkedServiceKusto#service_principal_key</a>.
        /// </summary>
        [<CustomOperation "service_principal_key">]
        member _.ServicePrincipalKey(state: DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name>, value: string) : DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name> =
            state.assignments.Add(fun config -> config.ServicePrincipalKey <- value)
            state : DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_kusto#tenant-1">DataFactoryLinkedServiceKusto#tenant</a>.
        /// </summary>
        [<CustomOperation "tenant">]
        member _.Tenant(state: DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name>, value: string) : DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name> =
            state.assignments.Add(fun config -> config.Tenant <- value)
            state : DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_kusto#timeouts-1">DataFactoryLinkedServiceKusto#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name>, value: azurerm.DataFactoryLinkedServiceKusto.DataFactoryLinkedServiceKustoTimeouts) : DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_kusto#use_managed_identity-1">DataFactoryLinkedServiceKusto#use_managed_identity</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_managed_identity">]
        member _.UseManagedIdentity(state: DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name>, value: bool) : DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name> =
            state.assignments.Add(fun config -> config.UseManagedIdentity <- value)
            state : DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_kusto#use_managed_identity-1">DataFactoryLinkedServiceKusto#use_managed_identity</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_managed_identity">]
        member _.UseManagedIdentity(state: DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name> =
            state.assignments.Add(fun config -> config.UseManagedIdentity <- value)
            state : DataFactoryLinkedServiceKustoState<'DataFactoryId, 'KustoDatabaseName, 'KustoEndpoint, 'Name>

        member _.Run(state: DataFactoryLinkedServiceKustoState<Present, Present, Present, Present>) : azurerm.DataFactoryLinkedServiceKusto.DataFactoryLinkedServiceKusto =
            let config = azurerm.DataFactoryLinkedServiceKusto.DataFactoryLinkedServiceKustoConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryLinkedServiceKusto.DataFactoryLinkedServiceKusto(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryLinkedServiceKusto: missing required arguments. Must call: data_factory_id, kusto_database_name, kusto_endpoint, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryLinkedServiceKustoState<_, _, _, _>) : azurerm.DataFactoryLinkedServiceKusto.DataFactoryLinkedServiceKusto =
            Unchecked.defaultof<azurerm.DataFactoryLinkedServiceKusto.DataFactoryLinkedServiceKusto>
