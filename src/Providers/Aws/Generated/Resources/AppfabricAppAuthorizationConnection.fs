namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppfabricAppAuthorizationConnectionState<'AppAuthorizationArn, 'AppBundleArn> = { assignments: ResizeArray<aws.AppfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization_connection">aws_appfabric_app_authorization_connection</a>.
    /// </summary>
    type AppfabricAppAuthorizationConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppfabricAppAuthorizationConnectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppfabricAppAuthorizationConnectionState<Missing, Missing>)

        member _.Zero(()) : AppfabricAppAuthorizationConnectionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppfabricAppAuthorizationConnectionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization_connection#app_authorization_arn-1">AppfabricAppAuthorizationConnection#app_authorization_arn</a>.
        /// </summary>
        [<CustomOperation "app_authorization_arn">]
        member _.AppAuthorizationArn(state: AppfabricAppAuthorizationConnectionState<Missing, 'AppBundleArn>, value: string) : AppfabricAppAuthorizationConnectionState<Present, 'AppBundleArn> =
            state.assignments.Add(fun config -> config.AppAuthorizationArn <- value)
            ({ assignments = state.assignments } : AppfabricAppAuthorizationConnectionState<Present, 'AppBundleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization_connection#app_bundle_arn-1">AppfabricAppAuthorizationConnection#app_bundle_arn</a>.
        /// </summary>
        [<CustomOperation "app_bundle_arn">]
        member _.AppBundleArn(state: AppfabricAppAuthorizationConnectionState<'AppAuthorizationArn, Missing>, value: string) : AppfabricAppAuthorizationConnectionState<'AppAuthorizationArn, Present> =
            state.assignments.Add(fun config -> config.AppBundleArn <- value)
            ({ assignments = state.assignments } : AppfabricAppAuthorizationConnectionState<'AppAuthorizationArn, Present>)

        /// <summary>
        /// auth_request block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization_connection#auth_request-1">AppfabricAppAuthorizationConnection#auth_request</a> Accepts: aws.IResolvable | aws.AppfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnectionAuthRequest[]
        /// </summary>
        [<CustomOperation "auth_request">]
        member _.AuthRequest(state: AppfabricAppAuthorizationConnectionState<'AppAuthorizationArn, 'AppBundleArn>, value: HashiCorp.Cdktf.IResolvable) : AppfabricAppAuthorizationConnectionState<'AppAuthorizationArn, 'AppBundleArn> =
            state.assignments.Add(fun config -> config.AuthRequest <- value)
            state : AppfabricAppAuthorizationConnectionState<'AppAuthorizationArn, 'AppBundleArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization_connection#timeouts-1">AppfabricAppAuthorizationConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AppfabricAppAuthorizationConnectionState<'AppAuthorizationArn, 'AppBundleArn>, value: aws.AppfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnectionTimeouts) : AppfabricAppAuthorizationConnectionState<'AppAuthorizationArn, 'AppBundleArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AppfabricAppAuthorizationConnectionState<'AppAuthorizationArn, 'AppBundleArn>

        member _.Run(state: AppfabricAppAuthorizationConnectionState<Present, Present>) : aws.AppfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnection =
            let config = aws.AppfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnectionConfig()
            for setter in state.assignments do
                setter config
            aws.AppfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appfabricAppAuthorizationConnection: missing required arguments. Must call: app_authorization_arn, app_bundle_arn.", 9999, IsError = true)>]
        member _.Run(_: AppfabricAppAuthorizationConnectionState<_, _>) : aws.AppfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnection =
            Unchecked.defaultof<aws.AppfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnection>
