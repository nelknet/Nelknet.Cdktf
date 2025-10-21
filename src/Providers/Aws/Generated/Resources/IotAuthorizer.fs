namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IotAuthorizerState<'AuthorizerFunctionArn, 'Name> = { assignments: ResizeArray<aws.IotAuthorizer.IotAuthorizerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_authorizer">aws_iot_authorizer</a>.
    /// </summary>
    type IotAuthorizerBuilder(logicalId: string) =
        member _.Yield(_: unit) : IotAuthorizerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IotAuthorizerState<Missing, Missing>)

        member _.Zero(()) : IotAuthorizerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IotAuthorizerState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_authorizer#authorizer_function_arn-1">IotAuthorizer#authorizer_function_arn</a>.
        /// </summary>
        [<CustomOperation "authorizer_function_arn">]
        member _.AuthorizerFunctionArn(state: IotAuthorizerState<Missing, 'Name>, value: string) : IotAuthorizerState<Present, 'Name> =
            state.assignments.Add(fun config -> config.AuthorizerFunctionArn <- value)
            ({ assignments = state.assignments } : IotAuthorizerState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_authorizer#name-1">IotAuthorizer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IotAuthorizerState<'AuthorizerFunctionArn, Missing>, value: string) : IotAuthorizerState<'AuthorizerFunctionArn, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IotAuthorizerState<'AuthorizerFunctionArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_authorizer#enable_caching_for_http-1">IotAuthorizer#enable_caching_for_http</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_caching_for_http">]
        member _.EnableCachingForHttp(state: IotAuthorizerState<'AuthorizerFunctionArn, 'Name>, value: bool) : IotAuthorizerState<'AuthorizerFunctionArn, 'Name> =
            state.assignments.Add(fun config -> config.EnableCachingForHttp <- value)
            state : IotAuthorizerState<'AuthorizerFunctionArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_authorizer#enable_caching_for_http-1">IotAuthorizer#enable_caching_for_http</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_caching_for_http">]
        member _.EnableCachingForHttp(state: IotAuthorizerState<'AuthorizerFunctionArn, 'Name>, value: HashiCorp.Cdktf.IResolvable) : IotAuthorizerState<'AuthorizerFunctionArn, 'Name> =
            state.assignments.Add(fun config -> config.EnableCachingForHttp <- value)
            state : IotAuthorizerState<'AuthorizerFunctionArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_authorizer#id-1">IotAuthorizer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IotAuthorizerState<'AuthorizerFunctionArn, 'Name>, value: string) : IotAuthorizerState<'AuthorizerFunctionArn, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IotAuthorizerState<'AuthorizerFunctionArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_authorizer#signing_disabled-1">IotAuthorizer#signing_disabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "signing_disabled">]
        member _.SigningDisabled(state: IotAuthorizerState<'AuthorizerFunctionArn, 'Name>, value: bool) : IotAuthorizerState<'AuthorizerFunctionArn, 'Name> =
            state.assignments.Add(fun config -> config.SigningDisabled <- value)
            state : IotAuthorizerState<'AuthorizerFunctionArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_authorizer#signing_disabled-1">IotAuthorizer#signing_disabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "signing_disabled">]
        member _.SigningDisabled(state: IotAuthorizerState<'AuthorizerFunctionArn, 'Name>, value: HashiCorp.Cdktf.IResolvable) : IotAuthorizerState<'AuthorizerFunctionArn, 'Name> =
            state.assignments.Add(fun config -> config.SigningDisabled <- value)
            state : IotAuthorizerState<'AuthorizerFunctionArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_authorizer#status-1">IotAuthorizer#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: IotAuthorizerState<'AuthorizerFunctionArn, 'Name>, value: string) : IotAuthorizerState<'AuthorizerFunctionArn, 'Name> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : IotAuthorizerState<'AuthorizerFunctionArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_authorizer#tags-1">IotAuthorizer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IotAuthorizerState<'AuthorizerFunctionArn, 'Name>, value: seq<string * string>) : IotAuthorizerState<'AuthorizerFunctionArn, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IotAuthorizerState<'AuthorizerFunctionArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_authorizer#tags_all-1">IotAuthorizer#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: IotAuthorizerState<'AuthorizerFunctionArn, 'Name>, value: seq<string * string>) : IotAuthorizerState<'AuthorizerFunctionArn, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : IotAuthorizerState<'AuthorizerFunctionArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_authorizer#token_key_name-1">IotAuthorizer#token_key_name</a>.
        /// </summary>
        [<CustomOperation "token_key_name">]
        member _.TokenKeyName(state: IotAuthorizerState<'AuthorizerFunctionArn, 'Name>, value: string) : IotAuthorizerState<'AuthorizerFunctionArn, 'Name> =
            state.assignments.Add(fun config -> config.TokenKeyName <- value)
            state : IotAuthorizerState<'AuthorizerFunctionArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_authorizer#token_signing_public_keys-1">IotAuthorizer#token_signing_public_keys</a>.
        /// </summary>
        [<CustomOperation "token_signing_public_keys">]
        member _.TokenSigningPublicKeys(state: IotAuthorizerState<'AuthorizerFunctionArn, 'Name>, value: seq<string * string>) : IotAuthorizerState<'AuthorizerFunctionArn, 'Name> =
            state.assignments.Add(fun config -> config.TokenSigningPublicKeys <- dict value)
            state : IotAuthorizerState<'AuthorizerFunctionArn, 'Name>

        member _.Run(state: IotAuthorizerState<Present, Present>) : aws.IotAuthorizer.IotAuthorizer =
            let config = aws.IotAuthorizer.IotAuthorizerConfig()
            for setter in state.assignments do
                setter config
            aws.IotAuthorizer.IotAuthorizer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iotAuthorizer: missing required arguments. Must call: authorizer_function_arn, name.", 9999, IsError = true)>]
        member _.Run(_: IotAuthorizerState<_, _>) : aws.IotAuthorizer.IotAuthorizer =
            Unchecked.defaultof<aws.IotAuthorizer.IotAuthorizer>
