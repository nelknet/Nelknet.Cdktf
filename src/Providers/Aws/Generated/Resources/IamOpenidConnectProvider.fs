namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamOpenidConnectProviderState<'ClientIdList, 'Url> = { assignments: ResizeArray<aws.IamOpenidConnectProvider.IamOpenidConnectProviderConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_openid_connect_provider">aws_iam_openid_connect_provider</a>.
    /// </summary>
    type IamOpenidConnectProviderBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamOpenidConnectProviderState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamOpenidConnectProviderState<Missing, Missing>)

        member _.Zero(()) : IamOpenidConnectProviderState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamOpenidConnectProviderState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_openid_connect_provider#client_id_list-1">IamOpenidConnectProvider#client_id_list</a>.
        /// </summary>
        [<CustomOperation "client_id_list">]
        member _.ClientIdList(state: IamOpenidConnectProviderState<Missing, 'Url>, value: seq<string>) : IamOpenidConnectProviderState<Present, 'Url> =
            state.assignments.Add(fun config -> config.ClientIdList <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : IamOpenidConnectProviderState<Present, 'Url>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_openid_connect_provider#url-1">IamOpenidConnectProvider#url</a>.
        /// </summary>
        [<CustomOperation "url">]
        member _.Url(state: IamOpenidConnectProviderState<'ClientIdList, Missing>, value: string) : IamOpenidConnectProviderState<'ClientIdList, Present> =
            state.assignments.Add(fun config -> config.Url <- value)
            ({ assignments = state.assignments } : IamOpenidConnectProviderState<'ClientIdList, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_openid_connect_provider#id-1">IamOpenidConnectProvider#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IamOpenidConnectProviderState<'ClientIdList, 'Url>, value: string) : IamOpenidConnectProviderState<'ClientIdList, 'Url> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IamOpenidConnectProviderState<'ClientIdList, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_openid_connect_provider#tags-1">IamOpenidConnectProvider#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IamOpenidConnectProviderState<'ClientIdList, 'Url>, value: seq<string * string>) : IamOpenidConnectProviderState<'ClientIdList, 'Url> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IamOpenidConnectProviderState<'ClientIdList, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_openid_connect_provider#tags_all-1">IamOpenidConnectProvider#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: IamOpenidConnectProviderState<'ClientIdList, 'Url>, value: seq<string * string>) : IamOpenidConnectProviderState<'ClientIdList, 'Url> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : IamOpenidConnectProviderState<'ClientIdList, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_openid_connect_provider#thumbprint_list-1">IamOpenidConnectProvider#thumbprint_list</a>.
        /// </summary>
        [<CustomOperation "thumbprint_list">]
        member _.ThumbprintList(state: IamOpenidConnectProviderState<'ClientIdList, 'Url>, value: seq<string>) : IamOpenidConnectProviderState<'ClientIdList, 'Url> =
            state.assignments.Add(fun config -> config.ThumbprintList <- (value |> Seq.toArray))
            state : IamOpenidConnectProviderState<'ClientIdList, 'Url>

        member _.Run(state: IamOpenidConnectProviderState<Present, Present>) : aws.IamOpenidConnectProvider.IamOpenidConnectProvider =
            let config = aws.IamOpenidConnectProvider.IamOpenidConnectProviderConfig()
            for setter in state.assignments do
                setter config
            aws.IamOpenidConnectProvider.IamOpenidConnectProvider(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamOpenidConnectProvider: missing required arguments. Must call: client_id_list, url.", 9999, IsError = true)>]
        member _.Run(_: IamOpenidConnectProviderState<_, _>) : aws.IamOpenidConnectProvider.IamOpenidConnectProvider =
            Unchecked.defaultof<aws.IamOpenidConnectProvider.IamOpenidConnectProvider>
