namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type QuicksightAccountSettingsState = { assignments: ResizeArray<aws.QuicksightAccountSettings.QuicksightAccountSettingsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_account_settings">aws_quicksight_account_settings</a>.
    /// </summary>
    type QuicksightAccountSettingsBuilder(logicalId: string) =
        member _.Yield(_: unit) : QuicksightAccountSettingsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : QuicksightAccountSettingsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_account_settings#aws_account_id-1">QuicksightAccountSettings#aws_account_id</a>.
        /// </summary>
        [<CustomOperation "aws_account_id">]
        member _.AwsAccountId(state: QuicksightAccountSettingsState, value: string) : QuicksightAccountSettingsState =
            state.assignments.Add(fun config -> config.AwsAccountId <- value)
            state : QuicksightAccountSettingsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_account_settings#default_namespace-1">QuicksightAccountSettings#default_namespace</a>.
        /// </summary>
        [<CustomOperation "default_namespace">]
        member _.DefaultNamespace(state: QuicksightAccountSettingsState, value: string) : QuicksightAccountSettingsState =
            state.assignments.Add(fun config -> config.DefaultNamespace <- value)
            state : QuicksightAccountSettingsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_account_settings#termination_protection_enabled-1">QuicksightAccountSettings#termination_protection_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "termination_protection_enabled">]
        member _.TerminationProtectionEnabled(state: QuicksightAccountSettingsState, value: bool) : QuicksightAccountSettingsState =
            state.assignments.Add(fun config -> config.TerminationProtectionEnabled <- value)
            state : QuicksightAccountSettingsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_account_settings#termination_protection_enabled-1">QuicksightAccountSettings#termination_protection_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "termination_protection_enabled">]
        member _.TerminationProtectionEnabled(state: QuicksightAccountSettingsState, value: HashiCorp.Cdktf.IResolvable) : QuicksightAccountSettingsState =
            state.assignments.Add(fun config -> config.TerminationProtectionEnabled <- value)
            state : QuicksightAccountSettingsState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_account_settings#timeouts-1">QuicksightAccountSettings#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: QuicksightAccountSettingsState, value: aws.QuicksightAccountSettings.QuicksightAccountSettingsTimeouts) : QuicksightAccountSettingsState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : QuicksightAccountSettingsState

        member _.Run(state: QuicksightAccountSettingsState) : aws.QuicksightAccountSettings.QuicksightAccountSettings =
            let config = aws.QuicksightAccountSettings.QuicksightAccountSettingsConfig()
            for setter in state.assignments do
                setter config
            aws.QuicksightAccountSettings.QuicksightAccountSettings(StackContext.get (), logicalId, config)
