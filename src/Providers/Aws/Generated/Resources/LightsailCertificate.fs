namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LightsailCertificateState<'Name> = { assignments: ResizeArray<aws.LightsailCertificate.LightsailCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_certificate">aws_lightsail_certificate</a>.
    /// </summary>
    type LightsailCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : LightsailCertificateState<Missing> =
            ({ assignments = ResizeArray() } : LightsailCertificateState<Missing>)

        member _.Zero(()) : LightsailCertificateState<Missing> =
            ({ assignments = ResizeArray() } : LightsailCertificateState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_certificate#name-1">LightsailCertificate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LightsailCertificateState<Missing>, value: string) : LightsailCertificateState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LightsailCertificateState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_certificate#domain_name-1">LightsailCertificate#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: LightsailCertificateState<'Name>, value: string) : LightsailCertificateState<'Name> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            state : LightsailCertificateState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_certificate#id-1">LightsailCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LightsailCertificateState<'Name>, value: string) : LightsailCertificateState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LightsailCertificateState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_certificate#subject_alternative_names-1">LightsailCertificate#subject_alternative_names</a>.
        /// </summary>
        [<CustomOperation "subject_alternative_names">]
        member _.SubjectAlternativeNames(state: LightsailCertificateState<'Name>, value: seq<string>) : LightsailCertificateState<'Name> =
            state.assignments.Add(fun config -> config.SubjectAlternativeNames <- (value |> Seq.toArray))
            state : LightsailCertificateState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_certificate#tags-1">LightsailCertificate#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LightsailCertificateState<'Name>, value: seq<string * string>) : LightsailCertificateState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LightsailCertificateState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_certificate#tags_all-1">LightsailCertificate#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: LightsailCertificateState<'Name>, value: seq<string * string>) : LightsailCertificateState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : LightsailCertificateState<'Name>

        member _.Run(state: LightsailCertificateState<Present>) : aws.LightsailCertificate.LightsailCertificate =
            let config = aws.LightsailCertificate.LightsailCertificateConfig()
            for setter in state.assignments do
                setter config
            aws.LightsailCertificate.LightsailCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lightsailCertificate: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: LightsailCertificateState<_>) : aws.LightsailCertificate.LightsailCertificate =
            Unchecked.defaultof<aws.LightsailCertificate.LightsailCertificate>
