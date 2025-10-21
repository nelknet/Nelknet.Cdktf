namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCognitoUserPoolClientState<'ClientId, 'UserPoolId> = { assignments: ResizeArray<aws.DataAwsCognitoUserPoolClient.DataAwsCognitoUserPoolClientConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cognito_user_pool_client">aws_cognito_user_pool_client</a>.
    /// </summary>
    type DataAwsCognitoUserPoolClientBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCognitoUserPoolClientState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsCognitoUserPoolClientState<Missing, Missing>)

        member _.Zero(()) : DataAwsCognitoUserPoolClientState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsCognitoUserPoolClientState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cognito_user_pool_client#client_id-1">DataAwsCognitoUserPoolClient#client_id</a>.
        /// </summary>
        [<CustomOperation "client_id">]
        member _.ClientId(state: DataAwsCognitoUserPoolClientState<Missing, 'UserPoolId>, value: string) : DataAwsCognitoUserPoolClientState<Present, 'UserPoolId> =
            state.assignments.Add(fun config -> config.ClientId <- value)
            ({ assignments = state.assignments } : DataAwsCognitoUserPoolClientState<Present, 'UserPoolId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cognito_user_pool_client#user_pool_id-1">DataAwsCognitoUserPoolClient#user_pool_id</a>.
        /// </summary>
        [<CustomOperation "user_pool_id">]
        member _.UserPoolId(state: DataAwsCognitoUserPoolClientState<'ClientId, Missing>, value: string) : DataAwsCognitoUserPoolClientState<'ClientId, Present> =
            state.assignments.Add(fun config -> config.UserPoolId <- value)
            ({ assignments = state.assignments } : DataAwsCognitoUserPoolClientState<'ClientId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cognito_user_pool_client#id-1">DataAwsCognitoUserPoolClient#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCognitoUserPoolClientState<'ClientId, 'UserPoolId>, value: string) : DataAwsCognitoUserPoolClientState<'ClientId, 'UserPoolId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCognitoUserPoolClientState<'ClientId, 'UserPoolId>

        member _.Run(state: DataAwsCognitoUserPoolClientState<Present, Present>) : aws.DataAwsCognitoUserPoolClient.DataAwsCognitoUserPoolClient =
            let config = aws.DataAwsCognitoUserPoolClient.DataAwsCognitoUserPoolClientConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCognitoUserPoolClient.DataAwsCognitoUserPoolClient(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCognitoUserPoolClient: missing required arguments. Must call: client_id, user_pool_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCognitoUserPoolClientState<_, _>) : aws.DataAwsCognitoUserPoolClient.DataAwsCognitoUserPoolClient =
            Unchecked.defaultof<aws.DataAwsCognitoUserPoolClient.DataAwsCognitoUserPoolClient>
