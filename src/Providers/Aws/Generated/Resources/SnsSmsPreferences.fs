namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SnsSmsPreferencesState = { assignments: ResizeArray<aws.SnsSmsPreferences.SnsSmsPreferencesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_sms_preferences">aws_sns_sms_preferences</a>.
    /// </summary>
    type SnsSmsPreferencesBuilder(logicalId: string) =
        member _.Yield(_: unit) : SnsSmsPreferencesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : SnsSmsPreferencesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_sms_preferences#default_sender_id-1">SnsSmsPreferences#default_sender_id</a>.
        /// </summary>
        [<CustomOperation "default_sender_id">]
        member _.DefaultSenderId(state: SnsSmsPreferencesState, value: string) : SnsSmsPreferencesState =
            state.assignments.Add(fun config -> config.DefaultSenderId <- value)
            state : SnsSmsPreferencesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_sms_preferences#default_sms_type-1">SnsSmsPreferences#default_sms_type</a>.
        /// </summary>
        [<CustomOperation "default_sms_type">]
        member _.DefaultSmsType(state: SnsSmsPreferencesState, value: string) : SnsSmsPreferencesState =
            state.assignments.Add(fun config -> config.DefaultSmsType <- value)
            state : SnsSmsPreferencesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_sms_preferences#delivery_status_iam_role_arn-1">SnsSmsPreferences#delivery_status_iam_role_arn</a>.
        /// </summary>
        [<CustomOperation "delivery_status_iam_role_arn">]
        member _.DeliveryStatusIamRoleArn(state: SnsSmsPreferencesState, value: string) : SnsSmsPreferencesState =
            state.assignments.Add(fun config -> config.DeliveryStatusIamRoleArn <- value)
            state : SnsSmsPreferencesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_sms_preferences#delivery_status_success_sampling_rate-1">SnsSmsPreferences#delivery_status_success_sampling_rate</a>.
        /// </summary>
        [<CustomOperation "delivery_status_success_sampling_rate">]
        member _.DeliveryStatusSuccessSamplingRate(state: SnsSmsPreferencesState, value: string) : SnsSmsPreferencesState =
            state.assignments.Add(fun config -> config.DeliveryStatusSuccessSamplingRate <- value)
            state : SnsSmsPreferencesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_sms_preferences#id-1">SnsSmsPreferences#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SnsSmsPreferencesState, value: string) : SnsSmsPreferencesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SnsSmsPreferencesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_sms_preferences#monthly_spend_limit-1">SnsSmsPreferences#monthly_spend_limit</a>.
        /// </summary>
        [<CustomOperation "monthly_spend_limit">]
        member _.MonthlySpendLimit(state: SnsSmsPreferencesState, value: double) : SnsSmsPreferencesState =
            state.assignments.Add(fun config -> config.MonthlySpendLimit <- value)
            state : SnsSmsPreferencesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sns_sms_preferences#usage_report_s3_bucket-1">SnsSmsPreferences#usage_report_s3_bucket</a>.
        /// </summary>
        [<CustomOperation "usage_report_s3_bucket">]
        member _.UsageReportS3Bucket(state: SnsSmsPreferencesState, value: string) : SnsSmsPreferencesState =
            state.assignments.Add(fun config -> config.UsageReportS3Bucket <- value)
            state : SnsSmsPreferencesState

        member _.Run(state: SnsSmsPreferencesState) : aws.SnsSmsPreferences.SnsSmsPreferences =
            let config = aws.SnsSmsPreferences.SnsSmsPreferencesConfig()
            for setter in state.assignments do
                setter config
            aws.SnsSmsPreferences.SnsSmsPreferences(StackContext.get (), logicalId, config)
