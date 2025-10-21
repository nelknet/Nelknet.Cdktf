namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LbListenerCertificateState<'CertificateArn, 'ListenerArn> = { assignments: ResizeArray<aws.LbListenerCertificate.LbListenerCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_certificate">aws_lb_listener_certificate</a>.
    /// </summary>
    type LbListenerCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : LbListenerCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LbListenerCertificateState<Missing, Missing>)

        member _.Zero(()) : LbListenerCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LbListenerCertificateState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_certificate#certificate_arn-1">LbListenerCertificate#certificate_arn</a>.
        /// </summary>
        [<CustomOperation "certificate_arn">]
        member _.CertificateArn(state: LbListenerCertificateState<Missing, 'ListenerArn>, value: string) : LbListenerCertificateState<Present, 'ListenerArn> =
            state.assignments.Add(fun config -> config.CertificateArn <- value)
            ({ assignments = state.assignments } : LbListenerCertificateState<Present, 'ListenerArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_certificate#listener_arn-1">LbListenerCertificate#listener_arn</a>.
        /// </summary>
        [<CustomOperation "listener_arn">]
        member _.ListenerArn(state: LbListenerCertificateState<'CertificateArn, Missing>, value: string) : LbListenerCertificateState<'CertificateArn, Present> =
            state.assignments.Add(fun config -> config.ListenerArn <- value)
            ({ assignments = state.assignments } : LbListenerCertificateState<'CertificateArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener_certificate#id-1">LbListenerCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LbListenerCertificateState<'CertificateArn, 'ListenerArn>, value: string) : LbListenerCertificateState<'CertificateArn, 'ListenerArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LbListenerCertificateState<'CertificateArn, 'ListenerArn>

        member _.Run(state: LbListenerCertificateState<Present, Present>) : aws.LbListenerCertificate.LbListenerCertificate =
            let config = aws.LbListenerCertificate.LbListenerCertificateConfig()
            for setter in state.assignments do
                setter config
            aws.LbListenerCertificate.LbListenerCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lbListenerCertificate: missing required arguments. Must call: certificate_arn, listener_arn.", 9999, IsError = true)>]
        member _.Run(_: LbListenerCertificateState<_, _>) : aws.LbListenerCertificate.LbListenerCertificate =
            Unchecked.defaultof<aws.LbListenerCertificate.LbListenerCertificate>
