namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LightsailLbCertificateState<'LbName, 'Name> = { assignments: ResizeArray<aws.LightsailLbCertificate.LightsailLbCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb_certificate">aws_lightsail_lb_certificate</a>.
    /// </summary>
    type LightsailLbCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : LightsailLbCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailLbCertificateState<Missing, Missing>)

        member _.Zero(()) : LightsailLbCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailLbCertificateState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb_certificate#lb_name-1">LightsailLbCertificate#lb_name</a>.
        /// </summary>
        [<CustomOperation "lb_name">]
        member _.LbName(state: LightsailLbCertificateState<Missing, 'Name>, value: string) : LightsailLbCertificateState<Present, 'Name> =
            state.assignments.Add(fun config -> config.LbName <- value)
            ({ assignments = state.assignments } : LightsailLbCertificateState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb_certificate#name-1">LightsailLbCertificate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LightsailLbCertificateState<'LbName, Missing>, value: string) : LightsailLbCertificateState<'LbName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LightsailLbCertificateState<'LbName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb_certificate#domain_name-1">LightsailLbCertificate#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: LightsailLbCertificateState<'LbName, 'Name>, value: string) : LightsailLbCertificateState<'LbName, 'Name> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            state : LightsailLbCertificateState<'LbName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb_certificate#id-1">LightsailLbCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LightsailLbCertificateState<'LbName, 'Name>, value: string) : LightsailLbCertificateState<'LbName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LightsailLbCertificateState<'LbName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb_certificate#subject_alternative_names-1">LightsailLbCertificate#subject_alternative_names</a>.
        /// </summary>
        [<CustomOperation "subject_alternative_names">]
        member _.SubjectAlternativeNames(state: LightsailLbCertificateState<'LbName, 'Name>, value: seq<string>) : LightsailLbCertificateState<'LbName, 'Name> =
            state.assignments.Add(fun config -> config.SubjectAlternativeNames <- (value |> Seq.toArray))
            state : LightsailLbCertificateState<'LbName, 'Name>

        member _.Run(state: LightsailLbCertificateState<Present, Present>) : aws.LightsailLbCertificate.LightsailLbCertificate =
            let config = aws.LightsailLbCertificate.LightsailLbCertificateConfig()
            for setter in state.assignments do
                setter config
            aws.LightsailLbCertificate.LightsailLbCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lightsailLbCertificate: missing required arguments. Must call: lb_name, name.", 9999, IsError = true)>]
        member _.Run(_: LightsailLbCertificateState<_, _>) : aws.LightsailLbCertificate.LightsailLbCertificate =
            Unchecked.defaultof<aws.LightsailLbCertificate.LightsailLbCertificate>
