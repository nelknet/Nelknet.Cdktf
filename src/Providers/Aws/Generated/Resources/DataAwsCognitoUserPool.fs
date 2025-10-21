namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCognitoUserPoolState<'UserPoolId> = { assignments: ResizeArray<aws.DataAwsCognitoUserPool.DataAwsCognitoUserPoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cognito_user_pool">aws_cognito_user_pool</a>.
    /// </summary>
    type DataAwsCognitoUserPoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCognitoUserPoolState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCognitoUserPoolState<Missing>)

        member _.Zero(()) : DataAwsCognitoUserPoolState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCognitoUserPoolState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cognito_user_pool#user_pool_id-1">DataAwsCognitoUserPool#user_pool_id</a>.
        /// </summary>
        [<CustomOperation "user_pool_id">]
        member _.UserPoolId(state: DataAwsCognitoUserPoolState<Missing>, value: string) : DataAwsCognitoUserPoolState<Present> =
            state.assignments.Add(fun config -> config.UserPoolId <- value)
            ({ assignments = state.assignments } : DataAwsCognitoUserPoolState<Present>)

        member _.Run(state: DataAwsCognitoUserPoolState<Present>) : aws.DataAwsCognitoUserPool.DataAwsCognitoUserPool =
            let config = aws.DataAwsCognitoUserPool.DataAwsCognitoUserPoolConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCognitoUserPool.DataAwsCognitoUserPool(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCognitoUserPool: missing required arguments. Must call: user_pool_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCognitoUserPoolState<_>) : aws.DataAwsCognitoUserPool.DataAwsCognitoUserPool =
            Unchecked.defaultof<aws.DataAwsCognitoUserPool.DataAwsCognitoUserPool>
