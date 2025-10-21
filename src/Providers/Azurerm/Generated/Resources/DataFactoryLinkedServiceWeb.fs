namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, 'Url> = { assignments: ResizeArray<azurerm.DataFactoryLinkedServiceWeb.DataFactoryLinkedServiceWebConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_web">azurerm_data_factory_linked_service_web</a>.
    /// </summary>
    type DataFactoryLinkedServiceWebBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryLinkedServiceWebState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceWebState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryLinkedServiceWebState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceWebState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_web#authentication_type-1">DataFactoryLinkedServiceWeb#authentication_type</a>.
        /// </summary>
        [<CustomOperation "authentication_type">]
        member _.AuthenticationType(state: DataFactoryLinkedServiceWebState<Missing, 'DataFactoryId, 'Name, 'Url>, value: string) : DataFactoryLinkedServiceWebState<Present, 'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.AuthenticationType <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceWebState<Present, 'DataFactoryId, 'Name, 'Url>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_web#data_factory_id-1">DataFactoryLinkedServiceWeb#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryLinkedServiceWebState<'AuthenticationType, Missing, 'Name, 'Url>, value: string) : DataFactoryLinkedServiceWebState<'AuthenticationType, Present, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceWebState<'AuthenticationType, Present, 'Name, 'Url>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_web#name-1">DataFactoryLinkedServiceWeb#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, Missing, 'Url>, value: string) : DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, Present, 'Url> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, Present, 'Url>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_web#url-1">DataFactoryLinkedServiceWeb#url</a>.
        /// </summary>
        [<CustomOperation "url">]
        member _.Url(state: DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, Missing>, value: string) : DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Url <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_web#additional_properties-1">DataFactoryLinkedServiceWeb#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, 'Url>, value: seq<string * string>) : DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_web#annotations-1">DataFactoryLinkedServiceWeb#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, 'Url>, value: seq<string>) : DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_web#description-1">DataFactoryLinkedServiceWeb#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, 'Url>, value: string) : DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_web#id-1">DataFactoryLinkedServiceWeb#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, 'Url>, value: string) : DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_web#integration_runtime_name-1">DataFactoryLinkedServiceWeb#integration_runtime_name</a>.
        /// </summary>
        [<CustomOperation "integration_runtime_name">]
        member _.IntegrationRuntimeName(state: DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, 'Url>, value: string) : DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.IntegrationRuntimeName <- value)
            state : DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_web#parameters-1">DataFactoryLinkedServiceWeb#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, 'Url>, value: seq<string * string>) : DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_web#password-1">DataFactoryLinkedServiceWeb#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, 'Url>, value: string) : DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.Password <- value)
            state : DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_web#timeouts-1">DataFactoryLinkedServiceWeb#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, 'Url>, value: azurerm.DataFactoryLinkedServiceWeb.DataFactoryLinkedServiceWebTimeouts) : DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_web#username-1">DataFactoryLinkedServiceWeb#username</a>.
        /// </summary>
        [<CustomOperation "username">]
        member _.Username(state: DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, 'Url>, value: string) : DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.Username <- value)
            state : DataFactoryLinkedServiceWebState<'AuthenticationType, 'DataFactoryId, 'Name, 'Url>

        member _.Run(state: DataFactoryLinkedServiceWebState<Present, Present, Present, Present>) : azurerm.DataFactoryLinkedServiceWeb.DataFactoryLinkedServiceWeb =
            let config = azurerm.DataFactoryLinkedServiceWeb.DataFactoryLinkedServiceWebConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryLinkedServiceWeb.DataFactoryLinkedServiceWeb(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryLinkedServiceWeb: missing required arguments. Must call: authentication_type, data_factory_id, name, url.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryLinkedServiceWebState<_, _, _, _>) : azurerm.DataFactoryLinkedServiceWeb.DataFactoryLinkedServiceWeb =
            Unchecked.defaultof<azurerm.DataFactoryLinkedServiceWeb.DataFactoryLinkedServiceWeb>
