namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsoadminTrustedTokenIssuerState<'InstanceArn, 'Name, 'TrustedTokenIssuerType> = { assignments: ResizeArray<aws.SsoadminTrustedTokenIssuer.SsoadminTrustedTokenIssuerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_trusted_token_issuer">aws_ssoadmin_trusted_token_issuer</a>.
    /// </summary>
    type SsoadminTrustedTokenIssuerBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsoadminTrustedTokenIssuerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SsoadminTrustedTokenIssuerState<Missing, Missing, Missing>)

        member _.Zero(()) : SsoadminTrustedTokenIssuerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SsoadminTrustedTokenIssuerState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_trusted_token_issuer#instance_arn-1">SsoadminTrustedTokenIssuer#instance_arn</a>.
        /// </summary>
        [<CustomOperation "instance_arn">]
        member _.InstanceArn(state: SsoadminTrustedTokenIssuerState<Missing, 'Name, 'TrustedTokenIssuerType>, value: string) : SsoadminTrustedTokenIssuerState<Present, 'Name, 'TrustedTokenIssuerType> =
            state.assignments.Add(fun config -> config.InstanceArn <- value)
            ({ assignments = state.assignments } : SsoadminTrustedTokenIssuerState<Present, 'Name, 'TrustedTokenIssuerType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_trusted_token_issuer#name-1">SsoadminTrustedTokenIssuer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SsoadminTrustedTokenIssuerState<'InstanceArn, Missing, 'TrustedTokenIssuerType>, value: string) : SsoadminTrustedTokenIssuerState<'InstanceArn, Present, 'TrustedTokenIssuerType> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SsoadminTrustedTokenIssuerState<'InstanceArn, Present, 'TrustedTokenIssuerType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_trusted_token_issuer#trusted_token_issuer_type-1">SsoadminTrustedTokenIssuer#trusted_token_issuer_type</a>.
        /// </summary>
        [<CustomOperation "trusted_token_issuer_type">]
        member _.TrustedTokenIssuerType(state: SsoadminTrustedTokenIssuerState<'InstanceArn, 'Name, Missing>, value: string) : SsoadminTrustedTokenIssuerState<'InstanceArn, 'Name, Present> =
            state.assignments.Add(fun config -> config.TrustedTokenIssuerType <- value)
            ({ assignments = state.assignments } : SsoadminTrustedTokenIssuerState<'InstanceArn, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_trusted_token_issuer#client_token-1">SsoadminTrustedTokenIssuer#client_token</a>.
        /// </summary>
        [<CustomOperation "client_token">]
        member _.ClientToken(state: SsoadminTrustedTokenIssuerState<'InstanceArn, 'Name, 'TrustedTokenIssuerType>, value: string) : SsoadminTrustedTokenIssuerState<'InstanceArn, 'Name, 'TrustedTokenIssuerType> =
            state.assignments.Add(fun config -> config.ClientToken <- value)
            state : SsoadminTrustedTokenIssuerState<'InstanceArn, 'Name, 'TrustedTokenIssuerType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_trusted_token_issuer#tags-1">SsoadminTrustedTokenIssuer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SsoadminTrustedTokenIssuerState<'InstanceArn, 'Name, 'TrustedTokenIssuerType>, value: seq<string * string>) : SsoadminTrustedTokenIssuerState<'InstanceArn, 'Name, 'TrustedTokenIssuerType> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SsoadminTrustedTokenIssuerState<'InstanceArn, 'Name, 'TrustedTokenIssuerType>

        /// <summary>
        /// trusted_token_issuer_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_trusted_token_issuer#trusted_token_issuer_configuration-1">SsoadminTrustedTokenIssuer#trusted_token_issuer_configuration</a> Accepts: aws.IResolvable | aws.SsoadminTrustedTokenIssuer.SsoadminTrustedTokenIssuerTrustedTokenIssuerConfiguration[]
        /// </summary>
        [<CustomOperation "trusted_token_issuer_configuration">]
        member _.TrustedTokenIssuerConfiguration(state: SsoadminTrustedTokenIssuerState<'InstanceArn, 'Name, 'TrustedTokenIssuerType>, value: HashiCorp.Cdktf.IResolvable) : SsoadminTrustedTokenIssuerState<'InstanceArn, 'Name, 'TrustedTokenIssuerType> =
            state.assignments.Add(fun config -> config.TrustedTokenIssuerConfiguration <- value)
            state : SsoadminTrustedTokenIssuerState<'InstanceArn, 'Name, 'TrustedTokenIssuerType>

        member _.Run(state: SsoadminTrustedTokenIssuerState<Present, Present, Present>) : aws.SsoadminTrustedTokenIssuer.SsoadminTrustedTokenIssuer =
            let config = aws.SsoadminTrustedTokenIssuer.SsoadminTrustedTokenIssuerConfig()
            for setter in state.assignments do
                setter config
            aws.SsoadminTrustedTokenIssuer.SsoadminTrustedTokenIssuer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssoadminTrustedTokenIssuer: missing required arguments. Must call: instance_arn, name, trusted_token_issuer_type.", 9999, IsError = true)>]
        member _.Run(_: SsoadminTrustedTokenIssuerState<_, _, _>) : aws.SsoadminTrustedTokenIssuer.SsoadminTrustedTokenIssuer =
            Unchecked.defaultof<aws.SsoadminTrustedTokenIssuer.SsoadminTrustedTokenIssuer>
