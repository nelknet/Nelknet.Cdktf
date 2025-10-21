namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DirectoryServiceLogSubscriptionState<'DirectoryId, 'LogGroupName> = { assignments: ResizeArray<aws.DirectoryServiceLogSubscription.DirectoryServiceLogSubscriptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_log_subscription">aws_directory_service_log_subscription</a>.
    /// </summary>
    type DirectoryServiceLogSubscriptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DirectoryServiceLogSubscriptionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DirectoryServiceLogSubscriptionState<Missing, Missing>)

        member _.Zero(()) : DirectoryServiceLogSubscriptionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DirectoryServiceLogSubscriptionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_log_subscription#directory_id-1">DirectoryServiceLogSubscription#directory_id</a>.
        /// </summary>
        [<CustomOperation "directory_id">]
        member _.DirectoryId(state: DirectoryServiceLogSubscriptionState<Missing, 'LogGroupName>, value: string) : DirectoryServiceLogSubscriptionState<Present, 'LogGroupName> =
            state.assignments.Add(fun config -> config.DirectoryId <- value)
            ({ assignments = state.assignments } : DirectoryServiceLogSubscriptionState<Present, 'LogGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_log_subscription#log_group_name-1">DirectoryServiceLogSubscription#log_group_name</a>.
        /// </summary>
        [<CustomOperation "log_group_name">]
        member _.LogGroupName(state: DirectoryServiceLogSubscriptionState<'DirectoryId, Missing>, value: string) : DirectoryServiceLogSubscriptionState<'DirectoryId, Present> =
            state.assignments.Add(fun config -> config.LogGroupName <- value)
            ({ assignments = state.assignments } : DirectoryServiceLogSubscriptionState<'DirectoryId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_log_subscription#id-1">DirectoryServiceLogSubscription#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DirectoryServiceLogSubscriptionState<'DirectoryId, 'LogGroupName>, value: string) : DirectoryServiceLogSubscriptionState<'DirectoryId, 'LogGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DirectoryServiceLogSubscriptionState<'DirectoryId, 'LogGroupName>

        member _.Run(state: DirectoryServiceLogSubscriptionState<Present, Present>) : aws.DirectoryServiceLogSubscription.DirectoryServiceLogSubscription =
            let config = aws.DirectoryServiceLogSubscription.DirectoryServiceLogSubscriptionConfig()
            for setter in state.assignments do
                setter config
            aws.DirectoryServiceLogSubscription.DirectoryServiceLogSubscription(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.directoryServiceLogSubscription: missing required arguments. Must call: directory_id, log_group_name.", 9999, IsError = true)>]
        member _.Run(_: DirectoryServiceLogSubscriptionState<_, _>) : aws.DirectoryServiceLogSubscription.DirectoryServiceLogSubscription =
            Unchecked.defaultof<aws.DirectoryServiceLogSubscription.DirectoryServiceLogSubscription>
