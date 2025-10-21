namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username> = { assignments: ResizeArray<azurerm.DataFactoryLinkedServiceSftp.DataFactoryLinkedServiceSftpConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sftp">azurerm_data_factory_linked_service_sftp</a>.
    /// </summary>
    type DataFactoryLinkedServiceSftpBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryLinkedServiceSftpState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceSftpState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryLinkedServiceSftpState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceSftpState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sftp#authentication_type-1">DataFactoryLinkedServiceSftp#authentication_type</a>.
        /// </summary>
        [<CustomOperation "authentication_type">]
        member _.AuthenticationType(state: DataFactoryLinkedServiceSftpState<Missing, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username>, value: string) : DataFactoryLinkedServiceSftpState<Present, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username> =
            state.assignments.Add(fun config -> config.AuthenticationType <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceSftpState<Present, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sftp#data_factory_id-1">DataFactoryLinkedServiceSftp#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryLinkedServiceSftpState<'AuthenticationType, Missing, 'Host, 'Name, 'Password, 'Port, 'Username>, value: string) : DataFactoryLinkedServiceSftpState<'AuthenticationType, Present, 'Host, 'Name, 'Password, 'Port, 'Username> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceSftpState<'AuthenticationType, Present, 'Host, 'Name, 'Password, 'Port, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sftp#host-1">DataFactoryLinkedServiceSftp#host</a>.
        /// </summary>
        [<CustomOperation "host">]
        member _.Host(state: DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, Missing, 'Name, 'Password, 'Port, 'Username>, value: string) : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, Present, 'Name, 'Password, 'Port, 'Username> =
            state.assignments.Add(fun config -> config.Host <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, Present, 'Name, 'Password, 'Port, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sftp#name-1">DataFactoryLinkedServiceSftp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, Missing, 'Password, 'Port, 'Username>, value: string) : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, Present, 'Password, 'Port, 'Username> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, Present, 'Password, 'Port, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sftp#password-1">DataFactoryLinkedServiceSftp#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, Missing, 'Port, 'Username>, value: string) : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, Present, 'Port, 'Username> =
            state.assignments.Add(fun config -> config.Password <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, Present, 'Port, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sftp#port-1">DataFactoryLinkedServiceSftp#port</a>.
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, Missing, 'Username>, value: double) : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, Present, 'Username> =
            state.assignments.Add(fun config -> config.Port <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, Present, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sftp#username-1">DataFactoryLinkedServiceSftp#username</a>.
        /// </summary>
        [<CustomOperation "username">]
        member _.Username(state: DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, Missing>, value: string) : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, Present> =
            state.assignments.Add(fun config -> config.Username <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sftp#additional_properties-1">DataFactoryLinkedServiceSftp#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username>, value: seq<string * string>) : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sftp#annotations-1">DataFactoryLinkedServiceSftp#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username>, value: seq<string>) : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sftp#description-1">DataFactoryLinkedServiceSftp#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username>, value: string) : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sftp#host_key_fingerprint-1">DataFactoryLinkedServiceSftp#host_key_fingerprint</a>.
        /// </summary>
        [<CustomOperation "host_key_fingerprint">]
        member _.HostKeyFingerprint(state: DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username>, value: string) : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username> =
            state.assignments.Add(fun config -> config.HostKeyFingerprint <- value)
            state : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sftp#id-1">DataFactoryLinkedServiceSftp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username>, value: string) : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sftp#integration_runtime_name-1">DataFactoryLinkedServiceSftp#integration_runtime_name</a>.
        /// </summary>
        [<CustomOperation "integration_runtime_name">]
        member _.IntegrationRuntimeName(state: DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username>, value: string) : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username> =
            state.assignments.Add(fun config -> config.IntegrationRuntimeName <- value)
            state : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sftp#parameters-1">DataFactoryLinkedServiceSftp#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username>, value: seq<string * string>) : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sftp#skip_host_key_validation-1">DataFactoryLinkedServiceSftp#skip_host_key_validation</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "skip_host_key_validation">]
        member _.SkipHostKeyValidation(state: DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username>, value: bool) : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username> =
            state.assignments.Add(fun config -> config.SkipHostKeyValidation <- value)
            state : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sftp#skip_host_key_validation-1">DataFactoryLinkedServiceSftp#skip_host_key_validation</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "skip_host_key_validation">]
        member _.SkipHostKeyValidation(state: DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username> =
            state.assignments.Add(fun config -> config.SkipHostKeyValidation <- value)
            state : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sftp#timeouts-1">DataFactoryLinkedServiceSftp#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username>, value: azurerm.DataFactoryLinkedServiceSftp.DataFactoryLinkedServiceSftpTimeouts) : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryLinkedServiceSftpState<'AuthenticationType, 'DataFactoryId, 'Host, 'Name, 'Password, 'Port, 'Username>

        member _.Run(state: DataFactoryLinkedServiceSftpState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.DataFactoryLinkedServiceSftp.DataFactoryLinkedServiceSftp =
            let config = azurerm.DataFactoryLinkedServiceSftp.DataFactoryLinkedServiceSftpConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryLinkedServiceSftp.DataFactoryLinkedServiceSftp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryLinkedServiceSftp: missing required arguments. Must call: authentication_type, data_factory_id, host, name, password, port, username.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryLinkedServiceSftpState<_, _, _, _, _, _, _>) : azurerm.DataFactoryLinkedServiceSftp.DataFactoryLinkedServiceSftp =
            Unchecked.defaultof<azurerm.DataFactoryLinkedServiceSftp.DataFactoryLinkedServiceSftp>
