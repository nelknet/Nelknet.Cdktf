namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Sesv2ConfigurationSetState<'ConfigurationSetName> = { assignments: ResizeArray<aws.Sesv2ConfigurationSet.Sesv2ConfigurationSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set">aws_sesv2_configuration_set</a>.
    /// </summary>
    type Sesv2ConfigurationSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : Sesv2ConfigurationSetState<Missing> =
            ({ assignments = ResizeArray() } : Sesv2ConfigurationSetState<Missing>)

        member _.Zero(()) : Sesv2ConfigurationSetState<Missing> =
            ({ assignments = ResizeArray() } : Sesv2ConfigurationSetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#configuration_set_name-1">Sesv2ConfigurationSet#configuration_set_name</a>.
        /// </summary>
        [<CustomOperation "configuration_set_name">]
        member _.ConfigurationSetName(state: Sesv2ConfigurationSetState<Missing>, value: string) : Sesv2ConfigurationSetState<Present> =
            state.assignments.Add(fun config -> config.ConfigurationSetName <- value)
            ({ assignments = state.assignments } : Sesv2ConfigurationSetState<Present>)

        /// <summary>
        /// delivery_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#delivery_options-1">Sesv2ConfigurationSet#delivery_options</a>
        /// </summary>
        [<CustomOperation "delivery_options">]
        member _.DeliveryOptions(state: Sesv2ConfigurationSetState<'ConfigurationSetName>, value: aws.Sesv2ConfigurationSet.Sesv2ConfigurationSetDeliveryOptions) : Sesv2ConfigurationSetState<'ConfigurationSetName> =
            state.assignments.Add(fun config -> config.DeliveryOptions <- value)
            state : Sesv2ConfigurationSetState<'ConfigurationSetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#id-1">Sesv2ConfigurationSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Sesv2ConfigurationSetState<'ConfigurationSetName>, value: string) : Sesv2ConfigurationSetState<'ConfigurationSetName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Sesv2ConfigurationSetState<'ConfigurationSetName>

        /// <summary>
        /// reputation_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#reputation_options-1">Sesv2ConfigurationSet#reputation_options</a>
        /// </summary>
        [<CustomOperation "reputation_options">]
        member _.ReputationOptions(state: Sesv2ConfigurationSetState<'ConfigurationSetName>, value: aws.Sesv2ConfigurationSet.Sesv2ConfigurationSetReputationOptions) : Sesv2ConfigurationSetState<'ConfigurationSetName> =
            state.assignments.Add(fun config -> config.ReputationOptions <- value)
            state : Sesv2ConfigurationSetState<'ConfigurationSetName>

        /// <summary>
        /// sending_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#sending_options-1">Sesv2ConfigurationSet#sending_options</a>
        /// </summary>
        [<CustomOperation "sending_options">]
        member _.SendingOptions(state: Sesv2ConfigurationSetState<'ConfigurationSetName>, value: aws.Sesv2ConfigurationSet.Sesv2ConfigurationSetSendingOptions) : Sesv2ConfigurationSetState<'ConfigurationSetName> =
            state.assignments.Add(fun config -> config.SendingOptions <- value)
            state : Sesv2ConfigurationSetState<'ConfigurationSetName>

        /// <summary>
        /// suppression_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#suppression_options-1">Sesv2ConfigurationSet#suppression_options</a>
        /// </summary>
        [<CustomOperation "suppression_options">]
        member _.SuppressionOptions(state: Sesv2ConfigurationSetState<'ConfigurationSetName>, value: aws.Sesv2ConfigurationSet.Sesv2ConfigurationSetSuppressionOptions) : Sesv2ConfigurationSetState<'ConfigurationSetName> =
            state.assignments.Add(fun config -> config.SuppressionOptions <- value)
            state : Sesv2ConfigurationSetState<'ConfigurationSetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#tags-1">Sesv2ConfigurationSet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Sesv2ConfigurationSetState<'ConfigurationSetName>, value: seq<string * string>) : Sesv2ConfigurationSetState<'ConfigurationSetName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Sesv2ConfigurationSetState<'ConfigurationSetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#tags_all-1">Sesv2ConfigurationSet#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Sesv2ConfigurationSetState<'ConfigurationSetName>, value: seq<string * string>) : Sesv2ConfigurationSetState<'ConfigurationSetName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Sesv2ConfigurationSetState<'ConfigurationSetName>

        /// <summary>
        /// tracking_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#tracking_options-1">Sesv2ConfigurationSet#tracking_options</a>
        /// </summary>
        [<CustomOperation "tracking_options">]
        member _.TrackingOptions(state: Sesv2ConfigurationSetState<'ConfigurationSetName>, value: aws.Sesv2ConfigurationSet.Sesv2ConfigurationSetTrackingOptions) : Sesv2ConfigurationSetState<'ConfigurationSetName> =
            state.assignments.Add(fun config -> config.TrackingOptions <- value)
            state : Sesv2ConfigurationSetState<'ConfigurationSetName>

        /// <summary>
        /// vdm_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#vdm_options-1">Sesv2ConfigurationSet#vdm_options</a>
        /// </summary>
        [<CustomOperation "vdm_options">]
        member _.VdmOptions(state: Sesv2ConfigurationSetState<'ConfigurationSetName>, value: aws.Sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptions) : Sesv2ConfigurationSetState<'ConfigurationSetName> =
            state.assignments.Add(fun config -> config.VdmOptions <- value)
            state : Sesv2ConfigurationSetState<'ConfigurationSetName>

        member _.Run(state: Sesv2ConfigurationSetState<Present>) : aws.Sesv2ConfigurationSet.Sesv2ConfigurationSet =
            let config = aws.Sesv2ConfigurationSet.Sesv2ConfigurationSetConfig()
            for setter in state.assignments do
                setter config
            aws.Sesv2ConfigurationSet.Sesv2ConfigurationSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sesv2ConfigurationSet: missing required arguments. Must call: configuration_set_name.", 9999, IsError = true)>]
        member _.Run(_: Sesv2ConfigurationSetState<_>) : aws.Sesv2ConfigurationSet.Sesv2ConfigurationSet =
            Unchecked.defaultof<aws.Sesv2ConfigurationSet.Sesv2ConfigurationSet>
