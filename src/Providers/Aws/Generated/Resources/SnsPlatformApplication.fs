namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential> = { assignments: ResizeArray<aws.SnsPlatformApplication.SnsPlatformApplicationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_platform_application">aws_sns_platform_application</a>.
    /// </summary>
    type SnsPlatformApplicationBuilder(logicalId: string) =
        member _.Yield(_: unit) : SnsPlatformApplicationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SnsPlatformApplicationState<Missing, Missing, Missing>)

        member _.Zero(()) : SnsPlatformApplicationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SnsPlatformApplicationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_platform_application#name-1">SnsPlatformApplication#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SnsPlatformApplicationState<Missing, 'Platform, 'PlatformCredential>, value: string) : SnsPlatformApplicationState<Present, 'Platform, 'PlatformCredential> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SnsPlatformApplicationState<Present, 'Platform, 'PlatformCredential>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_platform_application#platform-1">SnsPlatformApplication#platform</a>.
        /// </summary>
        [<CustomOperation "platform">]
        member _.Platform(state: SnsPlatformApplicationState<'Name, Missing, 'PlatformCredential>, value: string) : SnsPlatformApplicationState<'Name, Present, 'PlatformCredential> =
            state.assignments.Add(fun config -> config.Platform <- value)
            ({ assignments = state.assignments } : SnsPlatformApplicationState<'Name, Present, 'PlatformCredential>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_platform_application#platform_credential-1">SnsPlatformApplication#platform_credential</a>.
        /// </summary>
        [<CustomOperation "platform_credential">]
        member _.PlatformCredential(state: SnsPlatformApplicationState<'Name, 'Platform, Missing>, value: string) : SnsPlatformApplicationState<'Name, 'Platform, Present> =
            state.assignments.Add(fun config -> config.PlatformCredential <- value)
            ({ assignments = state.assignments } : SnsPlatformApplicationState<'Name, 'Platform, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_platform_application#apple_platform_bundle_id-1">SnsPlatformApplication#apple_platform_bundle_id</a>.
        /// </summary>
        [<CustomOperation "apple_platform_bundle_id">]
        member _.ApplePlatformBundleId(state: SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential>, value: string) : SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential> =
            state.assignments.Add(fun config -> config.ApplePlatformBundleId <- value)
            state : SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_platform_application#apple_platform_team_id-1">SnsPlatformApplication#apple_platform_team_id</a>.
        /// </summary>
        [<CustomOperation "apple_platform_team_id">]
        member _.ApplePlatformTeamId(state: SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential>, value: string) : SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential> =
            state.assignments.Add(fun config -> config.ApplePlatformTeamId <- value)
            state : SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_platform_application#event_delivery_failure_topic_arn-1">SnsPlatformApplication#event_delivery_failure_topic_arn</a>.
        /// </summary>
        [<CustomOperation "event_delivery_failure_topic_arn">]
        member _.EventDeliveryFailureTopicArn(state: SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential>, value: string) : SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential> =
            state.assignments.Add(fun config -> config.EventDeliveryFailureTopicArn <- value)
            state : SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_platform_application#event_endpoint_created_topic_arn-1">SnsPlatformApplication#event_endpoint_created_topic_arn</a>.
        /// </summary>
        [<CustomOperation "event_endpoint_created_topic_arn">]
        member _.EventEndpointCreatedTopicArn(state: SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential>, value: string) : SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential> =
            state.assignments.Add(fun config -> config.EventEndpointCreatedTopicArn <- value)
            state : SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_platform_application#event_endpoint_deleted_topic_arn-1">SnsPlatformApplication#event_endpoint_deleted_topic_arn</a>.
        /// </summary>
        [<CustomOperation "event_endpoint_deleted_topic_arn">]
        member _.EventEndpointDeletedTopicArn(state: SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential>, value: string) : SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential> =
            state.assignments.Add(fun config -> config.EventEndpointDeletedTopicArn <- value)
            state : SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_platform_application#event_endpoint_updated_topic_arn-1">SnsPlatformApplication#event_endpoint_updated_topic_arn</a>.
        /// </summary>
        [<CustomOperation "event_endpoint_updated_topic_arn">]
        member _.EventEndpointUpdatedTopicArn(state: SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential>, value: string) : SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential> =
            state.assignments.Add(fun config -> config.EventEndpointUpdatedTopicArn <- value)
            state : SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_platform_application#failure_feedback_role_arn-1">SnsPlatformApplication#failure_feedback_role_arn</a>.
        /// </summary>
        [<CustomOperation "failure_feedback_role_arn">]
        member _.FailureFeedbackRoleArn(state: SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential>, value: string) : SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential> =
            state.assignments.Add(fun config -> config.FailureFeedbackRoleArn <- value)
            state : SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_platform_application#id-1">SnsPlatformApplication#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential>, value: string) : SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_platform_application#platform_principal-1">SnsPlatformApplication#platform_principal</a>.
        /// </summary>
        [<CustomOperation "platform_principal">]
        member _.PlatformPrincipal(state: SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential>, value: string) : SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential> =
            state.assignments.Add(fun config -> config.PlatformPrincipal <- value)
            state : SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_platform_application#success_feedback_role_arn-1">SnsPlatformApplication#success_feedback_role_arn</a>.
        /// </summary>
        [<CustomOperation "success_feedback_role_arn">]
        member _.SuccessFeedbackRoleArn(state: SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential>, value: string) : SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential> =
            state.assignments.Add(fun config -> config.SuccessFeedbackRoleArn <- value)
            state : SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_platform_application#success_feedback_sample_rate-1">SnsPlatformApplication#success_feedback_sample_rate</a>.
        /// </summary>
        [<CustomOperation "success_feedback_sample_rate">]
        member _.SuccessFeedbackSampleRate(state: SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential>, value: string) : SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential> =
            state.assignments.Add(fun config -> config.SuccessFeedbackSampleRate <- value)
            state : SnsPlatformApplicationState<'Name, 'Platform, 'PlatformCredential>

        member _.Run(state: SnsPlatformApplicationState<Present, Present, Present>) : aws.SnsPlatformApplication.SnsPlatformApplication =
            let config = aws.SnsPlatformApplication.SnsPlatformApplicationConfig()
            for setter in state.assignments do
                setter config
            aws.SnsPlatformApplication.SnsPlatformApplication(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.snsPlatformApplication: missing required arguments. Must call: name, platform, platform_credential.", 9999, IsError = true)>]
        member _.Run(_: SnsPlatformApplicationState<_, _, _>) : aws.SnsPlatformApplication.SnsPlatformApplication =
            Unchecked.defaultof<aws.SnsPlatformApplication.SnsPlatformApplication>
