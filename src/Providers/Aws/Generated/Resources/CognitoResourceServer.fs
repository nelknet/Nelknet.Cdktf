namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CognitoResourceServerState<'Identifier, 'Name, 'UserPoolId> = { assignments: ResizeArray<aws.CognitoResourceServer.CognitoResourceServerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_resource_server">aws_cognito_resource_server</a>.
    /// </summary>
    type CognitoResourceServerBuilder(logicalId: string) =
        member _.Yield(_: unit) : CognitoResourceServerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CognitoResourceServerState<Missing, Missing, Missing>)

        member _.Zero(()) : CognitoResourceServerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CognitoResourceServerState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_resource_server#identifier-1">CognitoResourceServer#identifier</a>.
        /// </summary>
        [<CustomOperation "identifier">]
        member _.Identifier(state: CognitoResourceServerState<Missing, 'Name, 'UserPoolId>, value: string) : CognitoResourceServerState<Present, 'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.Identifier <- value)
            ({ assignments = state.assignments } : CognitoResourceServerState<Present, 'Name, 'UserPoolId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_resource_server#name-1">CognitoResourceServer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CognitoResourceServerState<'Identifier, Missing, 'UserPoolId>, value: string) : CognitoResourceServerState<'Identifier, Present, 'UserPoolId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CognitoResourceServerState<'Identifier, Present, 'UserPoolId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_resource_server#user_pool_id-1">CognitoResourceServer#user_pool_id</a>.
        /// </summary>
        [<CustomOperation "user_pool_id">]
        member _.UserPoolId(state: CognitoResourceServerState<'Identifier, 'Name, Missing>, value: string) : CognitoResourceServerState<'Identifier, 'Name, Present> =
            state.assignments.Add(fun config -> config.UserPoolId <- value)
            ({ assignments = state.assignments } : CognitoResourceServerState<'Identifier, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_resource_server#id-1">CognitoResourceServer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CognitoResourceServerState<'Identifier, 'Name, 'UserPoolId>, value: string) : CognitoResourceServerState<'Identifier, 'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CognitoResourceServerState<'Identifier, 'Name, 'UserPoolId>

        /// <summary>
        /// scope block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_resource_server#scope-1">CognitoResourceServer#scope</a> Accepts: aws.IResolvable | aws.CognitoResourceServer.CognitoResourceServerScope[]
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: CognitoResourceServerState<'Identifier, 'Name, 'UserPoolId>, value: HashiCorp.Cdktf.IResolvable) : CognitoResourceServerState<'Identifier, 'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.Scope <- value)
            state : CognitoResourceServerState<'Identifier, 'Name, 'UserPoolId>

        member _.Run(state: CognitoResourceServerState<Present, Present, Present>) : aws.CognitoResourceServer.CognitoResourceServer =
            let config = aws.CognitoResourceServer.CognitoResourceServerConfig()
            for setter in state.assignments do
                setter config
            aws.CognitoResourceServer.CognitoResourceServer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cognitoResourceServer: missing required arguments. Must call: identifier, name, user_pool_id.", 9999, IsError = true)>]
        member _.Run(_: CognitoResourceServerState<_, _, _>) : aws.CognitoResourceServer.CognitoResourceServer =
            Unchecked.defaultof<aws.CognitoResourceServer.CognitoResourceServer>
