namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCognitoIdentityPoolState<'IdentityPoolName> = { assignments: ResizeArray<aws.DataAwsCognitoIdentityPool.DataAwsCognitoIdentityPoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cognito_identity_pool">aws_cognito_identity_pool</a>.
    /// </summary>
    type DataAwsCognitoIdentityPoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCognitoIdentityPoolState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCognitoIdentityPoolState<Missing>)

        member _.Zero(()) : DataAwsCognitoIdentityPoolState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCognitoIdentityPoolState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cognito_identity_pool#identity_pool_name-1">DataAwsCognitoIdentityPool#identity_pool_name</a>.
        /// </summary>
        [<CustomOperation "identity_pool_name">]
        member _.IdentityPoolName(state: DataAwsCognitoIdentityPoolState<Missing>, value: string) : DataAwsCognitoIdentityPoolState<Present> =
            state.assignments.Add(fun config -> config.IdentityPoolName <- value)
            ({ assignments = state.assignments } : DataAwsCognitoIdentityPoolState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cognito_identity_pool#id-1">DataAwsCognitoIdentityPool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCognitoIdentityPoolState<'IdentityPoolName>, value: string) : DataAwsCognitoIdentityPoolState<'IdentityPoolName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCognitoIdentityPoolState<'IdentityPoolName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cognito_identity_pool#tags-1">DataAwsCognitoIdentityPool#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsCognitoIdentityPoolState<'IdentityPoolName>, value: seq<string * string>) : DataAwsCognitoIdentityPoolState<'IdentityPoolName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsCognitoIdentityPoolState<'IdentityPoolName>

        member _.Run(state: DataAwsCognitoIdentityPoolState<Present>) : aws.DataAwsCognitoIdentityPool.DataAwsCognitoIdentityPool =
            let config = aws.DataAwsCognitoIdentityPool.DataAwsCognitoIdentityPoolConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCognitoIdentityPool.DataAwsCognitoIdentityPool(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCognitoIdentityPool: missing required arguments. Must call: identity_pool_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCognitoIdentityPoolState<_>) : aws.DataAwsCognitoIdentityPool.DataAwsCognitoIdentityPool =
            Unchecked.defaultof<aws.DataAwsCognitoIdentityPool.DataAwsCognitoIdentityPool>
