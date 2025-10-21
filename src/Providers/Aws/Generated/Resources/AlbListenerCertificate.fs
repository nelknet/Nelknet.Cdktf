namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AlbListenerCertificateState<'CertificateArn, 'ListenerArn> = { assignments: ResizeArray<aws.AlbListenerCertificate.AlbListenerCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_certificate">aws_alb_listener_certificate</a>.
    /// </summary>
    type AlbListenerCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : AlbListenerCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AlbListenerCertificateState<Missing, Missing>)

        member _.Zero(()) : AlbListenerCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AlbListenerCertificateState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_certificate#certificate_arn-1">AlbListenerCertificate#certificate_arn</a>.
        /// </summary>
        [<CustomOperation "certificate_arn">]
        member _.CertificateArn(state: AlbListenerCertificateState<Missing, 'ListenerArn>, value: string) : AlbListenerCertificateState<Present, 'ListenerArn> =
            state.assignments.Add(fun config -> config.CertificateArn <- value)
            ({ assignments = state.assignments } : AlbListenerCertificateState<Present, 'ListenerArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_certificate#listener_arn-1">AlbListenerCertificate#listener_arn</a>.
        /// </summary>
        [<CustomOperation "listener_arn">]
        member _.ListenerArn(state: AlbListenerCertificateState<'CertificateArn, Missing>, value: string) : AlbListenerCertificateState<'CertificateArn, Present> =
            state.assignments.Add(fun config -> config.ListenerArn <- value)
            ({ assignments = state.assignments } : AlbListenerCertificateState<'CertificateArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener_certificate#id-1">AlbListenerCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AlbListenerCertificateState<'CertificateArn, 'ListenerArn>, value: string) : AlbListenerCertificateState<'CertificateArn, 'ListenerArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AlbListenerCertificateState<'CertificateArn, 'ListenerArn>

        member _.Run(state: AlbListenerCertificateState<Present, Present>) : aws.AlbListenerCertificate.AlbListenerCertificate =
            let config = aws.AlbListenerCertificate.AlbListenerCertificateConfig()
            for setter in state.assignments do
                setter config
            aws.AlbListenerCertificate.AlbListenerCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.albListenerCertificate: missing required arguments. Must call: certificate_arn, listener_arn.", 9999, IsError = true)>]
        member _.Run(_: AlbListenerCertificateState<_, _>) : aws.AlbListenerCertificate.AlbListenerCertificate =
            Unchecked.defaultof<aws.AlbListenerCertificate.AlbListenerCertificate>
