namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, 'DisplayLabel, 'RadiusPort, 'RadiusRetries, 'RadiusServers, 'RadiusTimeout, 'SharedSecret> = { assignments: ResizeArray<aws.DirectoryServiceRadiusSettings.DirectoryServiceRadiusSettingsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_radius_settings">aws_directory_service_radius_settings</a>.
    /// </summary>
    type DirectoryServiceRadiusSettingsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DirectoryServiceRadiusSettingsState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DirectoryServiceRadiusSettingsState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DirectoryServiceRadiusSettingsState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DirectoryServiceRadiusSettingsState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_radius_settings#authentication_protocol-1">DirectoryServiceRadiusSettings#authentication_protocol</a>.
        /// </summary>
        [<CustomOperation "authentication_protocol">]
        member _.AuthenticationProtocol(state: DirectoryServiceRadiusSettingsState<Missing, 'DirectoryId, 'DisplayLabel, 'RadiusPort, 'RadiusRetries, 'RadiusServers, 'RadiusTimeout, 'SharedSecret>, value: string) : DirectoryServiceRadiusSettingsState<Present, 'DirectoryId, 'DisplayLabel, 'RadiusPort, 'RadiusRetries, 'RadiusServers, 'RadiusTimeout, 'SharedSecret> =
            state.assignments.Add(fun config -> config.AuthenticationProtocol <- value)
            ({ assignments = state.assignments } : DirectoryServiceRadiusSettingsState<Present, 'DirectoryId, 'DisplayLabel, 'RadiusPort, 'RadiusRetries, 'RadiusServers, 'RadiusTimeout, 'SharedSecret>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_radius_settings#directory_id-1">DirectoryServiceRadiusSettings#directory_id</a>.
        /// </summary>
        [<CustomOperation "directory_id">]
        member _.DirectoryId(state: DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, Missing, 'DisplayLabel, 'RadiusPort, 'RadiusRetries, 'RadiusServers, 'RadiusTimeout, 'SharedSecret>, value: string) : DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, Present, 'DisplayLabel, 'RadiusPort, 'RadiusRetries, 'RadiusServers, 'RadiusTimeout, 'SharedSecret> =
            state.assignments.Add(fun config -> config.DirectoryId <- value)
            ({ assignments = state.assignments } : DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, Present, 'DisplayLabel, 'RadiusPort, 'RadiusRetries, 'RadiusServers, 'RadiusTimeout, 'SharedSecret>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_radius_settings#display_label-1">DirectoryServiceRadiusSettings#display_label</a>.
        /// </summary>
        [<CustomOperation "display_label">]
        member _.DisplayLabel(state: DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, Missing, 'RadiusPort, 'RadiusRetries, 'RadiusServers, 'RadiusTimeout, 'SharedSecret>, value: string) : DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, Present, 'RadiusPort, 'RadiusRetries, 'RadiusServers, 'RadiusTimeout, 'SharedSecret> =
            state.assignments.Add(fun config -> config.DisplayLabel <- value)
            ({ assignments = state.assignments } : DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, Present, 'RadiusPort, 'RadiusRetries, 'RadiusServers, 'RadiusTimeout, 'SharedSecret>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_radius_settings#radius_port-1">DirectoryServiceRadiusSettings#radius_port</a>.
        /// </summary>
        [<CustomOperation "radius_port">]
        member _.RadiusPort(state: DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, 'DisplayLabel, Missing, 'RadiusRetries, 'RadiusServers, 'RadiusTimeout, 'SharedSecret>, value: double) : DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, 'DisplayLabel, Present, 'RadiusRetries, 'RadiusServers, 'RadiusTimeout, 'SharedSecret> =
            state.assignments.Add(fun config -> config.RadiusPort <- value)
            ({ assignments = state.assignments } : DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, 'DisplayLabel, Present, 'RadiusRetries, 'RadiusServers, 'RadiusTimeout, 'SharedSecret>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_radius_settings#radius_retries-1">DirectoryServiceRadiusSettings#radius_retries</a>.
        /// </summary>
        [<CustomOperation "radius_retries">]
        member _.RadiusRetries(state: DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, 'DisplayLabel, 'RadiusPort, Missing, 'RadiusServers, 'RadiusTimeout, 'SharedSecret>, value: double) : DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, 'DisplayLabel, 'RadiusPort, Present, 'RadiusServers, 'RadiusTimeout, 'SharedSecret> =
            state.assignments.Add(fun config -> config.RadiusRetries <- value)
            ({ assignments = state.assignments } : DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, 'DisplayLabel, 'RadiusPort, Present, 'RadiusServers, 'RadiusTimeout, 'SharedSecret>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_radius_settings#radius_servers-1">DirectoryServiceRadiusSettings#radius_servers</a>.
        /// </summary>
        [<CustomOperation "radius_servers">]
        member _.RadiusServers(state: DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, 'DisplayLabel, 'RadiusPort, 'RadiusRetries, Missing, 'RadiusTimeout, 'SharedSecret>, value: seq<string>) : DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, 'DisplayLabel, 'RadiusPort, 'RadiusRetries, Present, 'RadiusTimeout, 'SharedSecret> =
            state.assignments.Add(fun config -> config.RadiusServers <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, 'DisplayLabel, 'RadiusPort, 'RadiusRetries, Present, 'RadiusTimeout, 'SharedSecret>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_radius_settings#radius_timeout-1">DirectoryServiceRadiusSettings#radius_timeout</a>.
        /// </summary>
        [<CustomOperation "radius_timeout">]
        member _.RadiusTimeout(state: DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, 'DisplayLabel, 'RadiusPort, 'RadiusRetries, 'RadiusServers, Missing, 'SharedSecret>, value: double) : DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, 'DisplayLabel, 'RadiusPort, 'RadiusRetries, 'RadiusServers, Present, 'SharedSecret> =
            state.assignments.Add(fun config -> config.RadiusTimeout <- value)
            ({ assignments = state.assignments } : DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, 'DisplayLabel, 'RadiusPort, 'RadiusRetries, 'RadiusServers, Present, 'SharedSecret>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_radius_settings#shared_secret-1">DirectoryServiceRadiusSettings#shared_secret</a>.
        /// </summary>
        [<CustomOperation "shared_secret">]
        member _.SharedSecret(state: DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, 'DisplayLabel, 'RadiusPort, 'RadiusRetries, 'RadiusServers, 'RadiusTimeout, Missing>, value: string) : DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, 'DisplayLabel, 'RadiusPort, 'RadiusRetries, 'RadiusServers, 'RadiusTimeout, Present> =
            state.assignments.Add(fun config -> config.SharedSecret <- value)
            ({ assignments = state.assignments } : DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, 'DisplayLabel, 'RadiusPort, 'RadiusRetries, 'RadiusServers, 'RadiusTimeout, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_radius_settings#id-1">DirectoryServiceRadiusSettings#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, 'DisplayLabel, 'RadiusPort, 'RadiusRetries, 'RadiusServers, 'RadiusTimeout, 'SharedSecret>, value: string) : DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, 'DisplayLabel, 'RadiusPort, 'RadiusRetries, 'RadiusServers, 'RadiusTimeout, 'SharedSecret> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, 'DisplayLabel, 'RadiusPort, 'RadiusRetries, 'RadiusServers, 'RadiusTimeout, 'SharedSecret>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_radius_settings#timeouts-1">DirectoryServiceRadiusSettings#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, 'DisplayLabel, 'RadiusPort, 'RadiusRetries, 'RadiusServers, 'RadiusTimeout, 'SharedSecret>, value: aws.DirectoryServiceRadiusSettings.DirectoryServiceRadiusSettingsTimeouts) : DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, 'DisplayLabel, 'RadiusPort, 'RadiusRetries, 'RadiusServers, 'RadiusTimeout, 'SharedSecret> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, 'DisplayLabel, 'RadiusPort, 'RadiusRetries, 'RadiusServers, 'RadiusTimeout, 'SharedSecret>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_radius_settings#use_same_username-1">DirectoryServiceRadiusSettings#use_same_username</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_same_username">]
        member _.UseSameUsername(state: DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, 'DisplayLabel, 'RadiusPort, 'RadiusRetries, 'RadiusServers, 'RadiusTimeout, 'SharedSecret>, value: bool) : DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, 'DisplayLabel, 'RadiusPort, 'RadiusRetries, 'RadiusServers, 'RadiusTimeout, 'SharedSecret> =
            state.assignments.Add(fun config -> config.UseSameUsername <- value)
            state : DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, 'DisplayLabel, 'RadiusPort, 'RadiusRetries, 'RadiusServers, 'RadiusTimeout, 'SharedSecret>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_radius_settings#use_same_username-1">DirectoryServiceRadiusSettings#use_same_username</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "use_same_username">]
        member _.UseSameUsername(state: DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, 'DisplayLabel, 'RadiusPort, 'RadiusRetries, 'RadiusServers, 'RadiusTimeout, 'SharedSecret>, value: HashiCorp.Cdktf.IResolvable) : DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, 'DisplayLabel, 'RadiusPort, 'RadiusRetries, 'RadiusServers, 'RadiusTimeout, 'SharedSecret> =
            state.assignments.Add(fun config -> config.UseSameUsername <- value)
            state : DirectoryServiceRadiusSettingsState<'AuthenticationProtocol, 'DirectoryId, 'DisplayLabel, 'RadiusPort, 'RadiusRetries, 'RadiusServers, 'RadiusTimeout, 'SharedSecret>

        member _.Run(state: DirectoryServiceRadiusSettingsState<Present, Present, Present, Present, Present, Present, Present, Present>) : aws.DirectoryServiceRadiusSettings.DirectoryServiceRadiusSettings =
            let config = aws.DirectoryServiceRadiusSettings.DirectoryServiceRadiusSettingsConfig()
            for setter in state.assignments do
                setter config
            aws.DirectoryServiceRadiusSettings.DirectoryServiceRadiusSettings(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.directoryServiceRadiusSettings: missing required arguments. Must call: authentication_protocol, directory_id, display_label, radius_port, radius_retries, radius_servers, radius_timeout, shared_secret.", 9999, IsError = true)>]
        member _.Run(_: DirectoryServiceRadiusSettingsState<_, _, _, _, _, _, _, _>) : aws.DirectoryServiceRadiusSettings.DirectoryServiceRadiusSettings =
            Unchecked.defaultof<aws.DirectoryServiceRadiusSettings.DirectoryServiceRadiusSettings>
