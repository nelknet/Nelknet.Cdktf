namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecuritylakeSubscriberState = { assignments: ResizeArray<aws.SecuritylakeSubscriber.SecuritylakeSubscriberConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber">aws_securitylake_subscriber</a>.
    /// </summary>
    type SecuritylakeSubscriberBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecuritylakeSubscriberState =
            { assignments = ResizeArray() }

        member _.Zero(()) : SecuritylakeSubscriberState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber#access_type-1">SecuritylakeSubscriber#access_type</a>.
        /// </summary>
        [<CustomOperation "access_type">]
        member _.AccessType(state: SecuritylakeSubscriberState, value: string) : SecuritylakeSubscriberState =
            state.assignments.Add(fun config -> config.AccessType <- value)
            state : SecuritylakeSubscriberState

        /// <summary>
        /// source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber#source-1">SecuritylakeSubscriber#source</a> Accepts: aws.IResolvable | aws.SecuritylakeSubscriber.SecuritylakeSubscriberSource[]
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: SecuritylakeSubscriberState, value: HashiCorp.Cdktf.IResolvable) : SecuritylakeSubscriberState =
            state.assignments.Add(fun config -> config.Source <- value)
            state : SecuritylakeSubscriberState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber#subscriber_description-1">SecuritylakeSubscriber#subscriber_description</a>.
        /// </summary>
        [<CustomOperation "subscriber_description">]
        member _.SubscriberDescription(state: SecuritylakeSubscriberState, value: string) : SecuritylakeSubscriberState =
            state.assignments.Add(fun config -> config.SubscriberDescription <- value)
            state : SecuritylakeSubscriberState

        /// <summary>
        /// subscriber_identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber#subscriber_identity-1">SecuritylakeSubscriber#subscriber_identity</a> Accepts: aws.IResolvable | aws.SecuritylakeSubscriber.SecuritylakeSubscriberSubscriberIdentity[]
        /// </summary>
        [<CustomOperation "subscriber_identity">]
        member _.SubscriberIdentity(state: SecuritylakeSubscriberState, value: HashiCorp.Cdktf.IResolvable) : SecuritylakeSubscriberState =
            state.assignments.Add(fun config -> config.SubscriberIdentity <- value)
            state : SecuritylakeSubscriberState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber#subscriber_name-1">SecuritylakeSubscriber#subscriber_name</a>.
        /// </summary>
        [<CustomOperation "subscriber_name">]
        member _.SubscriberName(state: SecuritylakeSubscriberState, value: string) : SecuritylakeSubscriberState =
            state.assignments.Add(fun config -> config.SubscriberName <- value)
            state : SecuritylakeSubscriberState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber#tags-1">SecuritylakeSubscriber#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SecuritylakeSubscriberState, value: seq<string * string>) : SecuritylakeSubscriberState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SecuritylakeSubscriberState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber#timeouts-1">SecuritylakeSubscriber#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SecuritylakeSubscriberState, value: aws.SecuritylakeSubscriber.SecuritylakeSubscriberTimeouts) : SecuritylakeSubscriberState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SecuritylakeSubscriberState

        member _.Run(state: SecuritylakeSubscriberState) : aws.SecuritylakeSubscriber.SecuritylakeSubscriber =
            let config = aws.SecuritylakeSubscriber.SecuritylakeSubscriberConfig()
            for setter in state.assignments do
                setter config
            aws.SecuritylakeSubscriber.SecuritylakeSubscriber(StackContext.get (), logicalId, config)
