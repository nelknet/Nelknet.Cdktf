namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApprunnerConnectionState<'ConnectionName, 'ProviderType> = { assignments: ResizeArray<aws.ApprunnerConnection.ApprunnerConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_connection">aws_apprunner_connection</a>.
    /// </summary>
    type ApprunnerConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApprunnerConnectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApprunnerConnectionState<Missing, Missing>)

        member _.Zero(()) : ApprunnerConnectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApprunnerConnectionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_connection#connection_name-1">ApprunnerConnection#connection_name</a>.
        /// </summary>
        [<CustomOperation "connection_name">]
        member _.ConnectionName(state: ApprunnerConnectionState<Missing, 'ProviderType>, value: string) : ApprunnerConnectionState<Present, 'ProviderType> =
            state.assignments.Add(fun config -> config.ConnectionName <- value)
            ({ assignments = state.assignments } : ApprunnerConnectionState<Present, 'ProviderType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_connection#provider_type-1">ApprunnerConnection#provider_type</a>.
        /// </summary>
        [<CustomOperation "provider_type">]
        member _.ProviderType(state: ApprunnerConnectionState<'ConnectionName, Missing>, value: string) : ApprunnerConnectionState<'ConnectionName, Present> =
            state.assignments.Add(fun config -> config.ProviderType <- value)
            ({ assignments = state.assignments } : ApprunnerConnectionState<'ConnectionName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_connection#id-1">ApprunnerConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApprunnerConnectionState<'ConnectionName, 'ProviderType>, value: string) : ApprunnerConnectionState<'ConnectionName, 'ProviderType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApprunnerConnectionState<'ConnectionName, 'ProviderType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_connection#tags-1">ApprunnerConnection#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ApprunnerConnectionState<'ConnectionName, 'ProviderType>, value: seq<string * string>) : ApprunnerConnectionState<'ConnectionName, 'ProviderType> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ApprunnerConnectionState<'ConnectionName, 'ProviderType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_connection#tags_all-1">ApprunnerConnection#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ApprunnerConnectionState<'ConnectionName, 'ProviderType>, value: seq<string * string>) : ApprunnerConnectionState<'ConnectionName, 'ProviderType> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ApprunnerConnectionState<'ConnectionName, 'ProviderType>

        member _.Run(state: ApprunnerConnectionState<Present, Present>) : aws.ApprunnerConnection.ApprunnerConnection =
            let config = aws.ApprunnerConnection.ApprunnerConnectionConfig()
            for setter in state.assignments do
                setter config
            aws.ApprunnerConnection.ApprunnerConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apprunnerConnection: missing required arguments. Must call: connection_name, provider_type.", 9999, IsError = true)>]
        member _.Run(_: ApprunnerConnectionState<_, _>) : aws.ApprunnerConnection.ApprunnerConnection =
            Unchecked.defaultof<aws.ApprunnerConnection.ApprunnerConnection>
