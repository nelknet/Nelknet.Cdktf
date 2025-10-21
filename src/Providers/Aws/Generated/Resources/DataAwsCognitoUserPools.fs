namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCognitoUserPoolsState<'Name> = { assignments: ResizeArray<aws.DataAwsCognitoUserPools.DataAwsCognitoUserPoolsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cognito_user_pools">aws_cognito_user_pools</a>.
    /// </summary>
    type DataAwsCognitoUserPoolsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCognitoUserPoolsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCognitoUserPoolsState<Missing>)

        member _.Zero(()) : DataAwsCognitoUserPoolsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCognitoUserPoolsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cognito_user_pools#name-1">DataAwsCognitoUserPools#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsCognitoUserPoolsState<Missing>, value: string) : DataAwsCognitoUserPoolsState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsCognitoUserPoolsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cognito_user_pools#id-1">DataAwsCognitoUserPools#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCognitoUserPoolsState<'Name>, value: string) : DataAwsCognitoUserPoolsState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCognitoUserPoolsState<'Name>

        member _.Run(state: DataAwsCognitoUserPoolsState<Present>) : aws.DataAwsCognitoUserPools.DataAwsCognitoUserPools =
            let config = aws.DataAwsCognitoUserPools.DataAwsCognitoUserPoolsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCognitoUserPools.DataAwsCognitoUserPools(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCognitoUserPools: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCognitoUserPoolsState<_>) : aws.DataAwsCognitoUserPools.DataAwsCognitoUserPools =
            Unchecked.defaultof<aws.DataAwsCognitoUserPools.DataAwsCognitoUserPools>
