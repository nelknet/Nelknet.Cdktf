namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SesConfigurationSetState<'Name> = { assignments: ResizeArray<aws.SesConfigurationSet.SesConfigurationSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_configuration_set">aws_ses_configuration_set</a>.
    /// </summary>
    type SesConfigurationSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : SesConfigurationSetState<Missing> =
            ({ assignments = ResizeArray() } : SesConfigurationSetState<Missing>)

        member _.Zero(()) : SesConfigurationSetState<Missing> =
            ({ assignments = ResizeArray() } : SesConfigurationSetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_configuration_set#name-1">SesConfigurationSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SesConfigurationSetState<Missing>, value: string) : SesConfigurationSetState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SesConfigurationSetState<Present>)

        /// <summary>
        /// delivery_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_configuration_set#delivery_options-1">SesConfigurationSet#delivery_options</a>
        /// </summary>
        [<CustomOperation "delivery_options">]
        member _.DeliveryOptions(state: SesConfigurationSetState<'Name>, value: aws.SesConfigurationSet.SesConfigurationSetDeliveryOptions) : SesConfigurationSetState<'Name> =
            state.assignments.Add(fun config -> config.DeliveryOptions <- value)
            state : SesConfigurationSetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_configuration_set#id-1">SesConfigurationSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SesConfigurationSetState<'Name>, value: string) : SesConfigurationSetState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SesConfigurationSetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_configuration_set#reputation_metrics_enabled-1">SesConfigurationSet#reputation_metrics_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "reputation_metrics_enabled">]
        member _.ReputationMetricsEnabled(state: SesConfigurationSetState<'Name>, value: bool) : SesConfigurationSetState<'Name> =
            state.assignments.Add(fun config -> config.ReputationMetricsEnabled <- value)
            state : SesConfigurationSetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_configuration_set#reputation_metrics_enabled-1">SesConfigurationSet#reputation_metrics_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "reputation_metrics_enabled">]
        member _.ReputationMetricsEnabled(state: SesConfigurationSetState<'Name>, value: HashiCorp.Cdktf.IResolvable) : SesConfigurationSetState<'Name> =
            state.assignments.Add(fun config -> config.ReputationMetricsEnabled <- value)
            state : SesConfigurationSetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_configuration_set#sending_enabled-1">SesConfigurationSet#sending_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "sending_enabled">]
        member _.SendingEnabled(state: SesConfigurationSetState<'Name>, value: bool) : SesConfigurationSetState<'Name> =
            state.assignments.Add(fun config -> config.SendingEnabled <- value)
            state : SesConfigurationSetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_configuration_set#sending_enabled-1">SesConfigurationSet#sending_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "sending_enabled">]
        member _.SendingEnabled(state: SesConfigurationSetState<'Name>, value: HashiCorp.Cdktf.IResolvable) : SesConfigurationSetState<'Name> =
            state.assignments.Add(fun config -> config.SendingEnabled <- value)
            state : SesConfigurationSetState<'Name>

        /// <summary>
        /// tracking_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_configuration_set#tracking_options-1">SesConfigurationSet#tracking_options</a>
        /// </summary>
        [<CustomOperation "tracking_options">]
        member _.TrackingOptions(state: SesConfigurationSetState<'Name>, value: aws.SesConfigurationSet.SesConfigurationSetTrackingOptions) : SesConfigurationSetState<'Name> =
            state.assignments.Add(fun config -> config.TrackingOptions <- value)
            state : SesConfigurationSetState<'Name>

        member _.Run(state: SesConfigurationSetState<Present>) : aws.SesConfigurationSet.SesConfigurationSet =
            let config = aws.SesConfigurationSet.SesConfigurationSetConfig()
            for setter in state.assignments do
                setter config
            aws.SesConfigurationSet.SesConfigurationSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sesConfigurationSet: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: SesConfigurationSetState<_>) : aws.SesConfigurationSet.SesConfigurationSet =
            Unchecked.defaultof<aws.SesConfigurationSet.SesConfigurationSet>
