namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEcrAuthorizationTokenState = { assignments: ResizeArray<aws.DataAwsEcrAuthorizationToken.DataAwsEcrAuthorizationTokenConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecr_authorization_token">aws_ecr_authorization_token</a>.
    /// </summary>
    type DataAwsEcrAuthorizationTokenBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEcrAuthorizationTokenState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEcrAuthorizationTokenState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecr_authorization_token#id-1">DataAwsEcrAuthorizationToken#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEcrAuthorizationTokenState, value: string) : DataAwsEcrAuthorizationTokenState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEcrAuthorizationTokenState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecr_authorization_token#registry_id-1">DataAwsEcrAuthorizationToken#registry_id</a>.
        /// </summary>
        [<CustomOperation "registry_id">]
        member _.RegistryId(state: DataAwsEcrAuthorizationTokenState, value: string) : DataAwsEcrAuthorizationTokenState =
            state.assignments.Add(fun config -> config.RegistryId <- value)
            state : DataAwsEcrAuthorizationTokenState

        member _.Run(state: DataAwsEcrAuthorizationTokenState) : aws.DataAwsEcrAuthorizationToken.DataAwsEcrAuthorizationToken =
            let config = aws.DataAwsEcrAuthorizationToken.DataAwsEcrAuthorizationTokenConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEcrAuthorizationToken.DataAwsEcrAuthorizationToken(StackContext.get (), logicalId, config)
