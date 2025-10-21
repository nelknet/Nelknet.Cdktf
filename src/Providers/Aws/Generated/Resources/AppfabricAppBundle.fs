namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppfabricAppBundleState = { assignments: ResizeArray<aws.AppfabricAppBundle.AppfabricAppBundleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_bundle">aws_appfabric_app_bundle</a>.
    /// </summary>
    type AppfabricAppBundleBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppfabricAppBundleState =
            { assignments = ResizeArray() }

        member _.Zero(()) : AppfabricAppBundleState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_bundle#customer_managed_key_arn-1">AppfabricAppBundle#customer_managed_key_arn</a>.
        /// </summary>
        [<CustomOperation "customer_managed_key_arn">]
        member _.CustomerManagedKeyArn(state: AppfabricAppBundleState, value: string) : AppfabricAppBundleState =
            state.assignments.Add(fun config -> config.CustomerManagedKeyArn <- value)
            state : AppfabricAppBundleState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_bundle#tags-1">AppfabricAppBundle#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppfabricAppBundleState, value: seq<string * string>) : AppfabricAppBundleState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppfabricAppBundleState

        member _.Run(state: AppfabricAppBundleState) : aws.AppfabricAppBundle.AppfabricAppBundle =
            let config = aws.AppfabricAppBundle.AppfabricAppBundleConfig()
            for setter in state.assignments do
                setter config
            aws.AppfabricAppBundle.AppfabricAppBundle(StackContext.get (), logicalId, config)
