namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpclatticeAccessLogSubscriptionState<'DestinationArn, 'ResourceIdentifier> = { assignments: ResizeArray<aws.VpclatticeAccessLogSubscription.VpclatticeAccessLogSubscriptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_access_log_subscription">aws_vpclattice_access_log_subscription</a>.
    /// </summary>
    type VpclatticeAccessLogSubscriptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpclatticeAccessLogSubscriptionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpclatticeAccessLogSubscriptionState<Missing, Missing>)

        member _.Zero(()) : VpclatticeAccessLogSubscriptionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpclatticeAccessLogSubscriptionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_access_log_subscription#destination_arn-1">VpclatticeAccessLogSubscription#destination_arn</a>.
        /// </summary>
        [<CustomOperation "destination_arn">]
        member _.DestinationArn(state: VpclatticeAccessLogSubscriptionState<Missing, 'ResourceIdentifier>, value: string) : VpclatticeAccessLogSubscriptionState<Present, 'ResourceIdentifier> =
            state.assignments.Add(fun config -> config.DestinationArn <- value)
            ({ assignments = state.assignments } : VpclatticeAccessLogSubscriptionState<Present, 'ResourceIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_access_log_subscription#resource_identifier-1">VpclatticeAccessLogSubscription#resource_identifier</a>.
        /// </summary>
        [<CustomOperation "resource_identifier">]
        member _.ResourceIdentifier(state: VpclatticeAccessLogSubscriptionState<'DestinationArn, Missing>, value: string) : VpclatticeAccessLogSubscriptionState<'DestinationArn, Present> =
            state.assignments.Add(fun config -> config.ResourceIdentifier <- value)
            ({ assignments = state.assignments } : VpclatticeAccessLogSubscriptionState<'DestinationArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_access_log_subscription#id-1">VpclatticeAccessLogSubscription#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpclatticeAccessLogSubscriptionState<'DestinationArn, 'ResourceIdentifier>, value: string) : VpclatticeAccessLogSubscriptionState<'DestinationArn, 'ResourceIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpclatticeAccessLogSubscriptionState<'DestinationArn, 'ResourceIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_access_log_subscription#service_network_log_type-1">VpclatticeAccessLogSubscription#service_network_log_type</a>.
        /// </summary>
        [<CustomOperation "service_network_log_type">]
        member _.ServiceNetworkLogType(state: VpclatticeAccessLogSubscriptionState<'DestinationArn, 'ResourceIdentifier>, value: string) : VpclatticeAccessLogSubscriptionState<'DestinationArn, 'ResourceIdentifier> =
            state.assignments.Add(fun config -> config.ServiceNetworkLogType <- value)
            state : VpclatticeAccessLogSubscriptionState<'DestinationArn, 'ResourceIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_access_log_subscription#tags-1">VpclatticeAccessLogSubscription#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpclatticeAccessLogSubscriptionState<'DestinationArn, 'ResourceIdentifier>, value: seq<string * string>) : VpclatticeAccessLogSubscriptionState<'DestinationArn, 'ResourceIdentifier> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpclatticeAccessLogSubscriptionState<'DestinationArn, 'ResourceIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_access_log_subscription#tags_all-1">VpclatticeAccessLogSubscription#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: VpclatticeAccessLogSubscriptionState<'DestinationArn, 'ResourceIdentifier>, value: seq<string * string>) : VpclatticeAccessLogSubscriptionState<'DestinationArn, 'ResourceIdentifier> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : VpclatticeAccessLogSubscriptionState<'DestinationArn, 'ResourceIdentifier>

        member _.Run(state: VpclatticeAccessLogSubscriptionState<Present, Present>) : aws.VpclatticeAccessLogSubscription.VpclatticeAccessLogSubscription =
            let config = aws.VpclatticeAccessLogSubscription.VpclatticeAccessLogSubscriptionConfig()
            for setter in state.assignments do
                setter config
            aws.VpclatticeAccessLogSubscription.VpclatticeAccessLogSubscription(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpclatticeAccessLogSubscription: missing required arguments. Must call: destination_arn, resource_identifier.", 9999, IsError = true)>]
        member _.Run(_: VpclatticeAccessLogSubscriptionState<_, _>) : aws.VpclatticeAccessLogSubscription.VpclatticeAccessLogSubscription =
            Unchecked.defaultof<aws.VpclatticeAccessLogSubscription.VpclatticeAccessLogSubscription>
