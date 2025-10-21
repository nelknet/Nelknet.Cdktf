namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppsyncApiKeyState<'ApiId> = { assignments: ResizeArray<aws.AppsyncApiKey.AppsyncApiKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_api_key">aws_appsync_api_key</a>.
    /// </summary>
    type AppsyncApiKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppsyncApiKeyState<Missing> =
            ({ assignments = ResizeArray() } : AppsyncApiKeyState<Missing>)

        member _.Zero(()) : AppsyncApiKeyState<Missing> =
            ({ assignments = ResizeArray() } : AppsyncApiKeyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_api_key#api_id-1">AppsyncApiKey#api_id</a>.
        /// </summary>
        [<CustomOperation "api_id">]
        member _.ApiId(state: AppsyncApiKeyState<Missing>, value: string) : AppsyncApiKeyState<Present> =
            state.assignments.Add(fun config -> config.ApiId <- value)
            ({ assignments = state.assignments } : AppsyncApiKeyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_api_key#description-1">AppsyncApiKey#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AppsyncApiKeyState<'ApiId>, value: string) : AppsyncApiKeyState<'ApiId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AppsyncApiKeyState<'ApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_api_key#expires-1">AppsyncApiKey#expires</a>.
        /// </summary>
        [<CustomOperation "expires">]
        member _.Expires(state: AppsyncApiKeyState<'ApiId>, value: string) : AppsyncApiKeyState<'ApiId> =
            state.assignments.Add(fun config -> config.Expires <- value)
            state : AppsyncApiKeyState<'ApiId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_api_key#id-1">AppsyncApiKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppsyncApiKeyState<'ApiId>, value: string) : AppsyncApiKeyState<'ApiId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppsyncApiKeyState<'ApiId>

        member _.Run(state: AppsyncApiKeyState<Present>) : aws.AppsyncApiKey.AppsyncApiKey =
            let config = aws.AppsyncApiKey.AppsyncApiKeyConfig()
            for setter in state.assignments do
                setter config
            aws.AppsyncApiKey.AppsyncApiKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appsyncApiKey: missing required arguments. Must call: api_id.", 9999, IsError = true)>]
        member _.Run(_: AppsyncApiKeyState<_>) : aws.AppsyncApiKey.AppsyncApiKey =
            Unchecked.defaultof<aws.AppsyncApiKey.AppsyncApiKey>
