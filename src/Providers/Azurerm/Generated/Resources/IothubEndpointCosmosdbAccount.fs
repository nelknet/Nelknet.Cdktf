namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.IothubEndpointCosmosdbAccount.IothubEndpointCosmosdbAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_cosmosdb_account">azurerm_iothub_endpoint_cosmosdb_account</a>.
    /// </summary>
    type IothubEndpointCosmosdbAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : IothubEndpointCosmosdbAccountState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubEndpointCosmosdbAccountState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : IothubEndpointCosmosdbAccountState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubEndpointCosmosdbAccountState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_cosmosdb_account#container_name-1">IothubEndpointCosmosdbAccount#container_name</a>.
        /// </summary>
        [<CustomOperation "container_name">]
        member _.ContainerName(state: IothubEndpointCosmosdbAccountState<Missing, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointCosmosdbAccountState<Present, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ContainerName <- value)
            ({ assignments = state.assignments } : IothubEndpointCosmosdbAccountState<Present, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_cosmosdb_account#database_name-1">IothubEndpointCosmosdbAccount#database_name</a>.
        /// </summary>
        [<CustomOperation "database_name">]
        member _.DatabaseName(state: IothubEndpointCosmosdbAccountState<'ContainerName, Missing, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointCosmosdbAccountState<'ContainerName, Present, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DatabaseName <- value)
            ({ assignments = state.assignments } : IothubEndpointCosmosdbAccountState<'ContainerName, Present, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_cosmosdb_account#endpoint_uri-1">IothubEndpointCosmosdbAccount#endpoint_uri</a>.
        /// </summary>
        [<CustomOperation "endpoint_uri">]
        member _.EndpointUri(state: IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, Missing, 'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, Present, 'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EndpointUri <- value)
            ({ assignments = state.assignments } : IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, Present, 'IothubId, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_cosmosdb_account#iothub_id-1">IothubEndpointCosmosdbAccount#iothub_id</a>.
        /// </summary>
        [<CustomOperation "iothub_id">]
        member _.IothubId(state: IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, Missing, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IothubId <- value)
            ({ assignments = state.assignments } : IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_cosmosdb_account#name-1">IothubEndpointCosmosdbAccount#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, Missing, 'ResourceGroupName>, value: string) : IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_cosmosdb_account#resource_group_name-1">IothubEndpointCosmosdbAccount#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, Missing>, value: string) : IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_cosmosdb_account#authentication_type-1">IothubEndpointCosmosdbAccount#authentication_type</a>.
        /// </summary>
        [<CustomOperation "authentication_type">]
        member _.AuthenticationType(state: IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AuthenticationType <- value)
            state : IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_cosmosdb_account#id-1">IothubEndpointCosmosdbAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_cosmosdb_account#identity_id-1">IothubEndpointCosmosdbAccount#identity_id</a>.
        /// </summary>
        [<CustomOperation "identity_id">]
        member _.IdentityId(state: IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IdentityId <- value)
            state : IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_cosmosdb_account#partition_key_name-1">IothubEndpointCosmosdbAccount#partition_key_name</a>.
        /// </summary>
        [<CustomOperation "partition_key_name">]
        member _.PartitionKeyName(state: IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PartitionKeyName <- value)
            state : IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_cosmosdb_account#partition_key_template-1">IothubEndpointCosmosdbAccount#partition_key_template</a>.
        /// </summary>
        [<CustomOperation "partition_key_template">]
        member _.PartitionKeyTemplate(state: IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PartitionKeyTemplate <- value)
            state : IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_cosmosdb_account#primary_key-1">IothubEndpointCosmosdbAccount#primary_key</a>.
        /// </summary>
        [<CustomOperation "primary_key">]
        member _.PrimaryKey(state: IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PrimaryKey <- value)
            state : IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_cosmosdb_account#secondary_key-1">IothubEndpointCosmosdbAccount#secondary_key</a>.
        /// </summary>
        [<CustomOperation "secondary_key">]
        member _.SecondaryKey(state: IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SecondaryKey <- value)
            state : IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_cosmosdb_account#timeouts-1">IothubEndpointCosmosdbAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName>, value: azurerm.IothubEndpointCosmosdbAccount.IothubEndpointCosmosdbAccountTimeouts) : IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IothubEndpointCosmosdbAccountState<'ContainerName, 'DatabaseName, 'EndpointUri, 'IothubId, 'Name, 'ResourceGroupName>

        member _.Run(state: IothubEndpointCosmosdbAccountState<Present, Present, Present, Present, Present, Present>) : azurerm.IothubEndpointCosmosdbAccount.IothubEndpointCosmosdbAccount =
            let config = azurerm.IothubEndpointCosmosdbAccount.IothubEndpointCosmosdbAccountConfig()
            for setter in state.assignments do
                setter config
            azurerm.IothubEndpointCosmosdbAccount.IothubEndpointCosmosdbAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.iothubEndpointCosmosdbAccount: missing required arguments. Must call: container_name, database_name, endpoint_uri, iothub_id, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: IothubEndpointCosmosdbAccountState<_, _, _, _, _, _>) : azurerm.IothubEndpointCosmosdbAccount.IothubEndpointCosmosdbAccount =
            Unchecked.defaultof<azurerm.IothubEndpointCosmosdbAccount.IothubEndpointCosmosdbAccount>
