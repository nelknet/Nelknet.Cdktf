namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEcrpublicAuthorizationTokenState = { assignments: ResizeArray<aws.DataAwsEcrpublicAuthorizationToken.DataAwsEcrpublicAuthorizationTokenConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecrpublic_authorization_token">aws_ecrpublic_authorization_token</a>.
    /// </summary>
    type DataAwsEcrpublicAuthorizationTokenBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEcrpublicAuthorizationTokenState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEcrpublicAuthorizationTokenState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecrpublic_authorization_token#id-1">DataAwsEcrpublicAuthorizationToken#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEcrpublicAuthorizationTokenState, value: string) : DataAwsEcrpublicAuthorizationTokenState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEcrpublicAuthorizationTokenState

        member _.Run(state: DataAwsEcrpublicAuthorizationTokenState) : aws.DataAwsEcrpublicAuthorizationToken.DataAwsEcrpublicAuthorizationToken =
            let config = aws.DataAwsEcrpublicAuthorizationToken.DataAwsEcrpublicAuthorizationTokenConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEcrpublicAuthorizationToken.DataAwsEcrpublicAuthorizationToken(StackContext.get (), logicalId, config)
