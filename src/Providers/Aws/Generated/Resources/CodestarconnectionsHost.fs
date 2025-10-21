namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodestarconnectionsHostState<'Name, 'ProviderEndpoint, 'ProviderType> = { assignments: ResizeArray<aws.CodestarconnectionsHost.CodestarconnectionsHostConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codestarconnections_host">aws_codestarconnections_host</a>.
    /// </summary>
    type CodestarconnectionsHostBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodestarconnectionsHostState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CodestarconnectionsHostState<Missing, Missing, Missing>)

        member _.Zero(()) : CodestarconnectionsHostState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CodestarconnectionsHostState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codestarconnections_host#name-1">CodestarconnectionsHost#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CodestarconnectionsHostState<Missing, 'ProviderEndpoint, 'ProviderType>, value: string) : CodestarconnectionsHostState<Present, 'ProviderEndpoint, 'ProviderType> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CodestarconnectionsHostState<Present, 'ProviderEndpoint, 'ProviderType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codestarconnections_host#provider_endpoint-1">CodestarconnectionsHost#provider_endpoint</a>.
        /// </summary>
        [<CustomOperation "provider_endpoint">]
        member _.ProviderEndpoint(state: CodestarconnectionsHostState<'Name, Missing, 'ProviderType>, value: string) : CodestarconnectionsHostState<'Name, Present, 'ProviderType> =
            state.assignments.Add(fun config -> config.ProviderEndpoint <- value)
            ({ assignments = state.assignments } : CodestarconnectionsHostState<'Name, Present, 'ProviderType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codestarconnections_host#provider_type-1">CodestarconnectionsHost#provider_type</a>.
        /// </summary>
        [<CustomOperation "provider_type">]
        member _.ProviderType(state: CodestarconnectionsHostState<'Name, 'ProviderEndpoint, Missing>, value: string) : CodestarconnectionsHostState<'Name, 'ProviderEndpoint, Present> =
            state.assignments.Add(fun config -> config.ProviderType <- value)
            ({ assignments = state.assignments } : CodestarconnectionsHostState<'Name, 'ProviderEndpoint, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codestarconnections_host#id-1">CodestarconnectionsHost#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CodestarconnectionsHostState<'Name, 'ProviderEndpoint, 'ProviderType>, value: string) : CodestarconnectionsHostState<'Name, 'ProviderEndpoint, 'ProviderType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CodestarconnectionsHostState<'Name, 'ProviderEndpoint, 'ProviderType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codestarconnections_host#timeouts-1">CodestarconnectionsHost#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CodestarconnectionsHostState<'Name, 'ProviderEndpoint, 'ProviderType>, value: aws.CodestarconnectionsHost.CodestarconnectionsHostTimeouts) : CodestarconnectionsHostState<'Name, 'ProviderEndpoint, 'ProviderType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CodestarconnectionsHostState<'Name, 'ProviderEndpoint, 'ProviderType>

        /// <summary>
        /// vpc_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codestarconnections_host#vpc_configuration-1">CodestarconnectionsHost#vpc_configuration</a>
        /// </summary>
        [<CustomOperation "vpc_configuration">]
        member _.VpcConfiguration(state: CodestarconnectionsHostState<'Name, 'ProviderEndpoint, 'ProviderType>, value: aws.CodestarconnectionsHost.CodestarconnectionsHostVpcConfiguration) : CodestarconnectionsHostState<'Name, 'ProviderEndpoint, 'ProviderType> =
            state.assignments.Add(fun config -> config.VpcConfiguration <- value)
            state : CodestarconnectionsHostState<'Name, 'ProviderEndpoint, 'ProviderType>

        member _.Run(state: CodestarconnectionsHostState<Present, Present, Present>) : aws.CodestarconnectionsHost.CodestarconnectionsHost =
            let config = aws.CodestarconnectionsHost.CodestarconnectionsHostConfig()
            for setter in state.assignments do
                setter config
            aws.CodestarconnectionsHost.CodestarconnectionsHost(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codestarconnectionsHost: missing required arguments. Must call: name, provider_endpoint, provider_type.", 9999, IsError = true)>]
        member _.Run(_: CodestarconnectionsHostState<_, _, _>) : aws.CodestarconnectionsHost.CodestarconnectionsHost =
            Unchecked.defaultof<aws.CodestarconnectionsHost.CodestarconnectionsHost>
