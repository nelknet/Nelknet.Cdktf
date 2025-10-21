namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodebuildSourceCredentialState<'AuthType, 'ServerType, 'Token> = { assignments: ResizeArray<aws.CodebuildSourceCredential.CodebuildSourceCredentialConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_source_credential">aws_codebuild_source_credential</a>.
    /// </summary>
    type CodebuildSourceCredentialBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodebuildSourceCredentialState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CodebuildSourceCredentialState<Missing, Missing, Missing>)

        member _.Zero(()) : CodebuildSourceCredentialState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CodebuildSourceCredentialState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_source_credential#auth_type-1">CodebuildSourceCredential#auth_type</a>.
        /// </summary>
        [<CustomOperation "auth_type">]
        member _.AuthType(state: CodebuildSourceCredentialState<Missing, 'ServerType, 'Token>, value: string) : CodebuildSourceCredentialState<Present, 'ServerType, 'Token> =
            state.assignments.Add(fun config -> config.AuthType <- value)
            ({ assignments = state.assignments } : CodebuildSourceCredentialState<Present, 'ServerType, 'Token>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_source_credential#server_type-1">CodebuildSourceCredential#server_type</a>.
        /// </summary>
        [<CustomOperation "server_type">]
        member _.ServerType(state: CodebuildSourceCredentialState<'AuthType, Missing, 'Token>, value: string) : CodebuildSourceCredentialState<'AuthType, Present, 'Token> =
            state.assignments.Add(fun config -> config.ServerType <- value)
            ({ assignments = state.assignments } : CodebuildSourceCredentialState<'AuthType, Present, 'Token>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_source_credential#token-1">CodebuildSourceCredential#token</a>.
        /// </summary>
        [<CustomOperation "token">]
        member _.Token(state: CodebuildSourceCredentialState<'AuthType, 'ServerType, Missing>, value: string) : CodebuildSourceCredentialState<'AuthType, 'ServerType, Present> =
            state.assignments.Add(fun config -> config.Token <- value)
            ({ assignments = state.assignments } : CodebuildSourceCredentialState<'AuthType, 'ServerType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_source_credential#id-1">CodebuildSourceCredential#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CodebuildSourceCredentialState<'AuthType, 'ServerType, 'Token>, value: string) : CodebuildSourceCredentialState<'AuthType, 'ServerType, 'Token> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CodebuildSourceCredentialState<'AuthType, 'ServerType, 'Token>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_source_credential#user_name-1">CodebuildSourceCredential#user_name</a>.
        /// </summary>
        [<CustomOperation "user_name">]
        member _.UserName(state: CodebuildSourceCredentialState<'AuthType, 'ServerType, 'Token>, value: string) : CodebuildSourceCredentialState<'AuthType, 'ServerType, 'Token> =
            state.assignments.Add(fun config -> config.UserName <- value)
            state : CodebuildSourceCredentialState<'AuthType, 'ServerType, 'Token>

        member _.Run(state: CodebuildSourceCredentialState<Present, Present, Present>) : aws.CodebuildSourceCredential.CodebuildSourceCredential =
            let config = aws.CodebuildSourceCredential.CodebuildSourceCredentialConfig()
            for setter in state.assignments do
                setter config
            aws.CodebuildSourceCredential.CodebuildSourceCredential(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codebuildSourceCredential: missing required arguments. Must call: auth_type, server_type, token.", 9999, IsError = true)>]
        member _.Run(_: CodebuildSourceCredentialState<_, _, _>) : aws.CodebuildSourceCredential.CodebuildSourceCredential =
            Unchecked.defaultof<aws.CodebuildSourceCredential.CodebuildSourceCredential>
