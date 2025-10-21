namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodeconnectionsHostState<'Name, 'ProviderEndpoint, 'ProviderType> = { assignments: ResizeArray<aws.CodeconnectionsHost.CodeconnectionsHostConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeconnections_host">aws_codeconnections_host</a>.
    /// </summary>
    type CodeconnectionsHostBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodeconnectionsHostState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CodeconnectionsHostState<Missing, Missing, Missing>)

        member _.Zero(()) : CodeconnectionsHostState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CodeconnectionsHostState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeconnections_host#name-1">CodeconnectionsHost#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CodeconnectionsHostState<Missing, 'ProviderEndpoint, 'ProviderType>, value: string) : CodeconnectionsHostState<Present, 'ProviderEndpoint, 'ProviderType> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CodeconnectionsHostState<Present, 'ProviderEndpoint, 'ProviderType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeconnections_host#provider_endpoint-1">CodeconnectionsHost#provider_endpoint</a>.
        /// </summary>
        [<CustomOperation "provider_endpoint">]
        member _.ProviderEndpoint(state: CodeconnectionsHostState<'Name, Missing, 'ProviderType>, value: string) : CodeconnectionsHostState<'Name, Present, 'ProviderType> =
            state.assignments.Add(fun config -> config.ProviderEndpoint <- value)
            ({ assignments = state.assignments } : CodeconnectionsHostState<'Name, Present, 'ProviderType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeconnections_host#provider_type-1">CodeconnectionsHost#provider_type</a>.
        /// </summary>
        [<CustomOperation "provider_type">]
        member _.ProviderType(state: CodeconnectionsHostState<'Name, 'ProviderEndpoint, Missing>, value: string) : CodeconnectionsHostState<'Name, 'ProviderEndpoint, Present> =
            state.assignments.Add(fun config -> config.ProviderType <- value)
            ({ assignments = state.assignments } : CodeconnectionsHostState<'Name, 'ProviderEndpoint, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeconnections_host#tags-1">CodeconnectionsHost#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CodeconnectionsHostState<'Name, 'ProviderEndpoint, 'ProviderType>, value: seq<string * string>) : CodeconnectionsHostState<'Name, 'ProviderEndpoint, 'ProviderType> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CodeconnectionsHostState<'Name, 'ProviderEndpoint, 'ProviderType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeconnections_host#timeouts-1">CodeconnectionsHost#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CodeconnectionsHostState<'Name, 'ProviderEndpoint, 'ProviderType>, value: aws.CodeconnectionsHost.CodeconnectionsHostTimeouts) : CodeconnectionsHostState<'Name, 'ProviderEndpoint, 'ProviderType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CodeconnectionsHostState<'Name, 'ProviderEndpoint, 'ProviderType>

        /// <summary>
        /// vpc_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeconnections_host#vpc_configuration-1">CodeconnectionsHost#vpc_configuration</a> Accepts: aws.IResolvable | aws.CodeconnectionsHost.CodeconnectionsHostVpcConfiguration[]
        /// </summary>
        [<CustomOperation "vpc_configuration">]
        member _.VpcConfiguration(state: CodeconnectionsHostState<'Name, 'ProviderEndpoint, 'ProviderType>, value: HashiCorp.Cdktf.IResolvable) : CodeconnectionsHostState<'Name, 'ProviderEndpoint, 'ProviderType> =
            state.assignments.Add(fun config -> config.VpcConfiguration <- value)
            state : CodeconnectionsHostState<'Name, 'ProviderEndpoint, 'ProviderType>

        member _.Run(state: CodeconnectionsHostState<Present, Present, Present>) : aws.CodeconnectionsHost.CodeconnectionsHost =
            let config = aws.CodeconnectionsHost.CodeconnectionsHostConfig()
            for setter in state.assignments do
                setter config
            aws.CodeconnectionsHost.CodeconnectionsHost(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codeconnectionsHost: missing required arguments. Must call: name, provider_endpoint, provider_type.", 9999, IsError = true)>]
        member _.Run(_: CodeconnectionsHostState<_, _, _>) : aws.CodeconnectionsHost.CodeconnectionsHost =
            Unchecked.defaultof<aws.CodeconnectionsHost.CodeconnectionsHost>
