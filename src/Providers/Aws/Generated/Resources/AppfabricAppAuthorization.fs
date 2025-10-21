namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppfabricAppAuthorizationState<'App, 'AppBundleArn, 'AuthType> = { assignments: ResizeArray<aws.AppfabricAppAuthorization.AppfabricAppAuthorizationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization">aws_appfabric_app_authorization</a>.
    /// </summary>
    type AppfabricAppAuthorizationBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppfabricAppAuthorizationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppfabricAppAuthorizationState<Missing, Missing, Missing>)

        member _.Zero(()) : AppfabricAppAuthorizationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppfabricAppAuthorizationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization#app-1">AppfabricAppAuthorization#app</a>.
        /// </summary>
        [<CustomOperation "app">]
        member _.App(state: AppfabricAppAuthorizationState<Missing, 'AppBundleArn, 'AuthType>, value: string) : AppfabricAppAuthorizationState<Present, 'AppBundleArn, 'AuthType> =
            state.assignments.Add(fun config -> config.App <- value)
            ({ assignments = state.assignments } : AppfabricAppAuthorizationState<Present, 'AppBundleArn, 'AuthType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization#app_bundle_arn-1">AppfabricAppAuthorization#app_bundle_arn</a>.
        /// </summary>
        [<CustomOperation "app_bundle_arn">]
        member _.AppBundleArn(state: AppfabricAppAuthorizationState<'App, Missing, 'AuthType>, value: string) : AppfabricAppAuthorizationState<'App, Present, 'AuthType> =
            state.assignments.Add(fun config -> config.AppBundleArn <- value)
            ({ assignments = state.assignments } : AppfabricAppAuthorizationState<'App, Present, 'AuthType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization#auth_type-1">AppfabricAppAuthorization#auth_type</a>.
        /// </summary>
        [<CustomOperation "auth_type">]
        member _.AuthType(state: AppfabricAppAuthorizationState<'App, 'AppBundleArn, Missing>, value: string) : AppfabricAppAuthorizationState<'App, 'AppBundleArn, Present> =
            state.assignments.Add(fun config -> config.AuthType <- value)
            ({ assignments = state.assignments } : AppfabricAppAuthorizationState<'App, 'AppBundleArn, Present>)

        /// <summary>
        /// credential block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization#credential-1">AppfabricAppAuthorization#credential</a> Accepts: aws.IResolvable | aws.AppfabricAppAuthorization.AppfabricAppAuthorizationCredential[]
        /// </summary>
        [<CustomOperation "credential">]
        member _.Credential(state: AppfabricAppAuthorizationState<'App, 'AppBundleArn, 'AuthType>, value: HashiCorp.Cdktf.IResolvable) : AppfabricAppAuthorizationState<'App, 'AppBundleArn, 'AuthType> =
            state.assignments.Add(fun config -> config.Credential <- value)
            state : AppfabricAppAuthorizationState<'App, 'AppBundleArn, 'AuthType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization#tags-1">AppfabricAppAuthorization#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppfabricAppAuthorizationState<'App, 'AppBundleArn, 'AuthType>, value: seq<string * string>) : AppfabricAppAuthorizationState<'App, 'AppBundleArn, 'AuthType> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppfabricAppAuthorizationState<'App, 'AppBundleArn, 'AuthType>

        /// <summary>
        /// tenant block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization#tenant-1">AppfabricAppAuthorization#tenant</a> Accepts: aws.IResolvable | aws.AppfabricAppAuthorization.AppfabricAppAuthorizationTenant[]
        /// </summary>
        [<CustomOperation "tenant">]
        member _.Tenant(state: AppfabricAppAuthorizationState<'App, 'AppBundleArn, 'AuthType>, value: HashiCorp.Cdktf.IResolvable) : AppfabricAppAuthorizationState<'App, 'AppBundleArn, 'AuthType> =
            state.assignments.Add(fun config -> config.Tenant <- value)
            state : AppfabricAppAuthorizationState<'App, 'AppBundleArn, 'AuthType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization#timeouts-1">AppfabricAppAuthorization#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AppfabricAppAuthorizationState<'App, 'AppBundleArn, 'AuthType>, value: aws.AppfabricAppAuthorization.AppfabricAppAuthorizationTimeouts) : AppfabricAppAuthorizationState<'App, 'AppBundleArn, 'AuthType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AppfabricAppAuthorizationState<'App, 'AppBundleArn, 'AuthType>

        member _.Run(state: AppfabricAppAuthorizationState<Present, Present, Present>) : aws.AppfabricAppAuthorization.AppfabricAppAuthorization =
            let config = aws.AppfabricAppAuthorization.AppfabricAppAuthorizationConfig()
            for setter in state.assignments do
                setter config
            aws.AppfabricAppAuthorization.AppfabricAppAuthorization(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appfabricAppAuthorization: missing required arguments. Must call: app, app_bundle_arn, auth_type.", 9999, IsError = true)>]
        member _.Run(_: AppfabricAppAuthorizationState<_, _, _>) : aws.AppfabricAppAuthorization.AppfabricAppAuthorization =
            Unchecked.defaultof<aws.AppfabricAppAuthorization.AppfabricAppAuthorization>
