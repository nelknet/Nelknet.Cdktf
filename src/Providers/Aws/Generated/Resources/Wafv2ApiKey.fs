namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Wafv2ApiKeyState<'Scope, 'TokenDomains> = { assignments: ResizeArray<aws.Wafv2ApiKey.Wafv2ApiKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_api_key">aws_wafv2_api_key</a>.
    /// </summary>
    type Wafv2ApiKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : Wafv2ApiKeyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Wafv2ApiKeyState<Missing, Missing>)

        member _.Zero(()) : Wafv2ApiKeyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Wafv2ApiKeyState<Missing, Missing>)

        /// <summary>
        /// Specifies whether this is for an AWS CloudFront distribution or for a regional application. Valid values are CLOUDFRONT or REGIONAL. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_api_key#scope-1">Wafv2ApiKey#scope</a>
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: Wafv2ApiKeyState<Missing, 'TokenDomains>, value: string) : Wafv2ApiKeyState<Present, 'TokenDomains> =
            state.assignments.Add(fun config -> config.Scope <- value)
            ({ assignments = state.assignments } : Wafv2ApiKeyState<Present, 'TokenDomains>)

        /// <summary>
        /// The domains that you want to be able to use the API key with, for example example.com. Maximum of 5 domains. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_api_key#token_domains-1">Wafv2ApiKey#token_domains</a>
        /// </summary>
        [<CustomOperation "token_domains">]
        member _.TokenDomains(state: Wafv2ApiKeyState<'Scope, Missing>, value: seq<string>) : Wafv2ApiKeyState<'Scope, Present> =
            state.assignments.Add(fun config -> config.TokenDomains <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : Wafv2ApiKeyState<'Scope, Present>)

        member _.Run(state: Wafv2ApiKeyState<Present, Present>) : aws.Wafv2ApiKey.Wafv2ApiKey =
            let config = aws.Wafv2ApiKey.Wafv2ApiKeyConfig()
            for setter in state.assignments do
                setter config
            aws.Wafv2ApiKey.Wafv2ApiKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafv2ApiKey: missing required arguments. Must call: scope, token_domains.", 9999, IsError = true)>]
        member _.Run(_: Wafv2ApiKeyState<_, _>) : aws.Wafv2ApiKey.Wafv2ApiKey =
            Unchecked.defaultof<aws.Wafv2ApiKey.Wafv2ApiKey>
