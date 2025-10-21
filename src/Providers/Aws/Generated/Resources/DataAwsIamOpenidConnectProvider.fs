namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsIamOpenidConnectProviderState = { assignments: ResizeArray<aws.DataAwsIamOpenidConnectProvider.DataAwsIamOpenidConnectProviderConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_openid_connect_provider">aws_iam_openid_connect_provider</a>.
    /// </summary>
    type DataAwsIamOpenidConnectProviderBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsIamOpenidConnectProviderState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsIamOpenidConnectProviderState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_openid_connect_provider#arn-1">DataAwsIamOpenidConnectProvider#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsIamOpenidConnectProviderState, value: string) : DataAwsIamOpenidConnectProviderState =
            state.assignments.Add(fun config -> config.Arn <- value)
            state : DataAwsIamOpenidConnectProviderState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_openid_connect_provider#id-1">DataAwsIamOpenidConnectProvider#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsIamOpenidConnectProviderState, value: string) : DataAwsIamOpenidConnectProviderState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsIamOpenidConnectProviderState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_openid_connect_provider#tags-1">DataAwsIamOpenidConnectProvider#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsIamOpenidConnectProviderState, value: seq<string * string>) : DataAwsIamOpenidConnectProviderState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsIamOpenidConnectProviderState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_openid_connect_provider#url-1">DataAwsIamOpenidConnectProvider#url</a>.
        /// </summary>
        [<CustomOperation "url">]
        member _.Url(state: DataAwsIamOpenidConnectProviderState, value: string) : DataAwsIamOpenidConnectProviderState =
            state.assignments.Add(fun config -> config.Url <- value)
            state : DataAwsIamOpenidConnectProviderState

        member _.Run(state: DataAwsIamOpenidConnectProviderState) : aws.DataAwsIamOpenidConnectProvider.DataAwsIamOpenidConnectProvider =
            let config = aws.DataAwsIamOpenidConnectProvider.DataAwsIamOpenidConnectProviderConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsIamOpenidConnectProvider.DataAwsIamOpenidConnectProvider(StackContext.get (), logicalId, config)
