namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PaymentcryptographyKeyAliasState<'AliasName> = { assignments: ResizeArray<aws.PaymentcryptographyKeyAlias.PaymentcryptographyKeyAliasConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/paymentcryptography_key_alias">aws_paymentcryptography_key_alias</a>.
    /// </summary>
    type PaymentcryptographyKeyAliasBuilder(logicalId: string) =
        member _.Yield(_: unit) : PaymentcryptographyKeyAliasState<Missing> =
            ({ assignments = ResizeArray() } : PaymentcryptographyKeyAliasState<Missing>)

        member _.Zero(()) : PaymentcryptographyKeyAliasState<Missing> =
            ({ assignments = ResizeArray() } : PaymentcryptographyKeyAliasState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/paymentcryptography_key_alias#alias_name-1">PaymentcryptographyKeyAlias#alias_name</a>.
        /// </summary>
        [<CustomOperation "alias_name">]
        member _.AliasName(state: PaymentcryptographyKeyAliasState<Missing>, value: string) : PaymentcryptographyKeyAliasState<Present> =
            state.assignments.Add(fun config -> config.AliasName <- value)
            ({ assignments = state.assignments } : PaymentcryptographyKeyAliasState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/paymentcryptography_key_alias#key_arn-1">PaymentcryptographyKeyAlias#key_arn</a>.
        /// </summary>
        [<CustomOperation "key_arn">]
        member _.KeyArn(state: PaymentcryptographyKeyAliasState<'AliasName>, value: string) : PaymentcryptographyKeyAliasState<'AliasName> =
            state.assignments.Add(fun config -> config.KeyArn <- value)
            state : PaymentcryptographyKeyAliasState<'AliasName>

        member _.Run(state: PaymentcryptographyKeyAliasState<Present>) : aws.PaymentcryptographyKeyAlias.PaymentcryptographyKeyAlias =
            let config = aws.PaymentcryptographyKeyAlias.PaymentcryptographyKeyAliasConfig()
            for setter in state.assignments do
                setter config
            aws.PaymentcryptographyKeyAlias.PaymentcryptographyKeyAlias(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.paymentcryptographyKeyAlias: missing required arguments. Must call: alias_name.", 9999, IsError = true)>]
        member _.Run(_: PaymentcryptographyKeyAliasState<_>) : aws.PaymentcryptographyKeyAlias.PaymentcryptographyKeyAlias =
            Unchecked.defaultof<aws.PaymentcryptographyKeyAlias.PaymentcryptographyKeyAlias>
