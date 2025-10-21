namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PaymentcryptographyKeyState<'Exportable> = { assignments: ResizeArray<aws.PaymentcryptographyKey.PaymentcryptographyKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/paymentcryptography_key">aws_paymentcryptography_key</a>.
    /// </summary>
    type PaymentcryptographyKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : PaymentcryptographyKeyState<Missing> =
            ({ assignments = ResizeArray() } : PaymentcryptographyKeyState<Missing>)

        member _.Zero(()) : PaymentcryptographyKeyState<Missing> =
            ({ assignments = ResizeArray() } : PaymentcryptographyKeyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/paymentcryptography_key#exportable-1">PaymentcryptographyKey#exportable</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "exportable">]
        member _.Exportable(state: PaymentcryptographyKeyState<Missing>, value: bool) : PaymentcryptographyKeyState<Present> =
            state.assignments.Add(fun config -> config.Exportable <- value)
            ({ assignments = state.assignments } : PaymentcryptographyKeyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/paymentcryptography_key#exportable-1">PaymentcryptographyKey#exportable</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "exportable">]
        member _.Exportable(state: PaymentcryptographyKeyState<Missing>, value: HashiCorp.Cdktf.IResolvable) : PaymentcryptographyKeyState<Present> =
            state.assignments.Add(fun config -> config.Exportable <- value)
            ({ assignments = state.assignments } : PaymentcryptographyKeyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/paymentcryptography_key#deletion_window_in_days-1">PaymentcryptographyKey#deletion_window_in_days</a>.
        /// </summary>
        [<CustomOperation "deletion_window_in_days">]
        member _.DeletionWindowInDays(state: PaymentcryptographyKeyState<'Exportable>, value: double) : PaymentcryptographyKeyState<'Exportable> =
            state.assignments.Add(fun config -> config.DeletionWindowInDays <- value)
            state : PaymentcryptographyKeyState<'Exportable>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/paymentcryptography_key#enabled-1">PaymentcryptographyKey#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: PaymentcryptographyKeyState<'Exportable>, value: bool) : PaymentcryptographyKeyState<'Exportable> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : PaymentcryptographyKeyState<'Exportable>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/paymentcryptography_key#enabled-1">PaymentcryptographyKey#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: PaymentcryptographyKeyState<'Exportable>, value: HashiCorp.Cdktf.IResolvable) : PaymentcryptographyKeyState<'Exportable> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : PaymentcryptographyKeyState<'Exportable>

        /// <summary>
        /// key_attributes block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/paymentcryptography_key#key_attributes-1">PaymentcryptographyKey#key_attributes</a>
        /// </summary>
        [<CustomOperation "key_attributes">]
        member _.KeyAttributes(state: PaymentcryptographyKeyState<'Exportable>, value: aws.PaymentcryptographyKey.PaymentcryptographyKeyKeyAttributes) : PaymentcryptographyKeyState<'Exportable> =
            state.assignments.Add(fun config -> config.KeyAttributes <- value)
            state : PaymentcryptographyKeyState<'Exportable>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/paymentcryptography_key#key_check_value_algorithm-1">PaymentcryptographyKey#key_check_value_algorithm</a>.
        /// </summary>
        [<CustomOperation "key_check_value_algorithm">]
        member _.KeyCheckValueAlgorithm(state: PaymentcryptographyKeyState<'Exportable>, value: string) : PaymentcryptographyKeyState<'Exportable> =
            state.assignments.Add(fun config -> config.KeyCheckValueAlgorithm <- value)
            state : PaymentcryptographyKeyState<'Exportable>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/paymentcryptography_key#tags-1">PaymentcryptographyKey#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PaymentcryptographyKeyState<'Exportable>, value: seq<string * string>) : PaymentcryptographyKeyState<'Exportable> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PaymentcryptographyKeyState<'Exportable>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/paymentcryptography_key#timeouts-1">PaymentcryptographyKey#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PaymentcryptographyKeyState<'Exportable>, value: aws.PaymentcryptographyKey.PaymentcryptographyKeyTimeouts) : PaymentcryptographyKeyState<'Exportable> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PaymentcryptographyKeyState<'Exportable>

        member _.Run(state: PaymentcryptographyKeyState<Present>) : aws.PaymentcryptographyKey.PaymentcryptographyKey =
            let config = aws.PaymentcryptographyKey.PaymentcryptographyKeyConfig()
            for setter in state.assignments do
                setter config
            aws.PaymentcryptographyKey.PaymentcryptographyKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.paymentcryptographyKey: missing required arguments. Must call: exportable.", 9999, IsError = true)>]
        member _.Run(_: PaymentcryptographyKeyState<_>) : aws.PaymentcryptographyKey.PaymentcryptographyKey =
            Unchecked.defaultof<aws.PaymentcryptographyKey.PaymentcryptographyKey>
