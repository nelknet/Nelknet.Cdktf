namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCognitoUserPoolClientsState<'UserPoolId> = { assignments: ResizeArray<aws.DataAwsCognitoUserPoolClients.DataAwsCognitoUserPoolClientsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cognito_user_pool_clients">aws_cognito_user_pool_clients</a>.
    /// </summary>
    type DataAwsCognitoUserPoolClientsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCognitoUserPoolClientsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCognitoUserPoolClientsState<Missing>)

        member _.Zero(()) : DataAwsCognitoUserPoolClientsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCognitoUserPoolClientsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cognito_user_pool_clients#user_pool_id-1">DataAwsCognitoUserPoolClients#user_pool_id</a>.
        /// </summary>
        [<CustomOperation "user_pool_id">]
        member _.UserPoolId(state: DataAwsCognitoUserPoolClientsState<Missing>, value: string) : DataAwsCognitoUserPoolClientsState<Present> =
            state.assignments.Add(fun config -> config.UserPoolId <- value)
            ({ assignments = state.assignments } : DataAwsCognitoUserPoolClientsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cognito_user_pool_clients#id-1">DataAwsCognitoUserPoolClients#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCognitoUserPoolClientsState<'UserPoolId>, value: string) : DataAwsCognitoUserPoolClientsState<'UserPoolId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCognitoUserPoolClientsState<'UserPoolId>

        member _.Run(state: DataAwsCognitoUserPoolClientsState<Present>) : aws.DataAwsCognitoUserPoolClients.DataAwsCognitoUserPoolClients =
            let config = aws.DataAwsCognitoUserPoolClients.DataAwsCognitoUserPoolClientsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCognitoUserPoolClients.DataAwsCognitoUserPoolClients(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCognitoUserPoolClients: missing required arguments. Must call: user_pool_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCognitoUserPoolClientsState<_>) : aws.DataAwsCognitoUserPoolClients.DataAwsCognitoUserPoolClients =
            Unchecked.defaultof<aws.DataAwsCognitoUserPoolClients.DataAwsCognitoUserPoolClients>
